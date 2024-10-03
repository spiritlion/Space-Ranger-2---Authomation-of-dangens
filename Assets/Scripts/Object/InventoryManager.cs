using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject slots;
    public GameObject mainSlots;
    public GameObject player;
    [SerializeField] public int layer = 7;

    private int layerMask;
    private List<GameObject> allSlots = new List<GameObject>();
    private List<GameObject> allMainSlots = new List<GameObject>();

    void Start()
    {
      layerMask = (1 << layer);

      foreach(Transform t in slots.transform)
      {
        allSlots.Add(t.gameObject);
      }
      foreach(Transform t in mainSlots.transform)
      {
        allMainSlots.Add(t.gameObject);
      }
    }

    void Update()
    {
      Collider[] objectInRadius = Physics.OverlapSphere(player.transform.position, 6f, layerMask);

      foreach (var hitCollider in objectInRadius)
      {
          addItem(hitCollider.gameObject.GetComponent<Item>());

      }
      for (int i = 0; i < 10; i++)
      {
        Slot mSlot = allMainSlots[i].GetComponent<Slot>();
        Slot slot = allSlots[i].GetComponent<Slot>();
        Debug.Log(i);
        mSlot.item = slot.item;
        mSlot.count = slot.count;

      }

      // Настроить возможность поменять предметы местами в инвентаре

    }

    public void clickOnScreen()
    {
      Debug.Log("Click");
      foreach (var el in allMainSlots)
      {
        if (el.GetComponent<Toggle>().isOn && el.GetComponent<Slot>().item != null){
          Debug.Log(el.GetComponent<Slot>().item);
          el.GetComponent<Slot>().item.isClick();
          // Сделать так что-бы вызывался метод isClick не в ItemScriptableObject, а в его производных (Food, shortRangeWeapons, longRangeWeapons и других)

        }
      }
    }

    public void addItem(Item itemAdd)
    {
      foreach (var el in allSlots)
      {

        if (el.GetComponent<Slot>().item != null)
        {
          if (el.GetComponent<Slot>().item == itemAdd.item && el.GetComponent<Slot>().count < el.GetComponent<Slot>().item.amount)
          {
              if (el.GetComponent<Slot>().count + itemAdd.count <= el.GetComponent<Slot>().item.amount)
              {
                el.GetComponent<Slot>().count += itemAdd.count;
                Destroy(itemAdd.gameObject);
                break;
              } else {
                itemAdd.count -= el.GetComponent<Slot>().item.amount - el.GetComponent<Slot>().count;
                el.GetComponent<Slot>().count = el.GetComponent<Slot>().item.amount;
                break;
              }
          }
        } else {
          el.GetComponent<Slot>().item = itemAdd.item;
          if (itemAdd.count > itemAdd.item.amount)
          {
            el.GetComponent<Slot>().count = itemAdd.item.amount;
            itemAdd.count -= itemAdd.item.amount;
            break;
          } else {
            el.GetComponent<Slot>().count += itemAdd.count;
            Destroy(itemAdd.gameObject);
            break;
          }
        }
      }
    }
}

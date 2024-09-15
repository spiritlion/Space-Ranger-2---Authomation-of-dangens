using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
  public int SLotsCount;
  public Transform MainSlots;
  public Transform OtherSlots;

  public void ItemAdd(ItemScriptableObject item, int count)
  {
    for (int i = 0; i < 10; i++)
    {
      ItemScriptableObject slot = MainSlots.GetChild(i).GetComponent<InvenorySlot>();
      /*
      if (slot.item != null)
      {
        count - slot.count;

      } else {
        countSlots = count / item.count;

      }
      */
      // Досмотреть видео!
    }
  }
}

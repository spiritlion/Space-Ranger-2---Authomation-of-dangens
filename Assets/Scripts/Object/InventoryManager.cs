using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject slots;
    public GameObject player;
    [SerializeField] public int layer = 7;

    private int layerMask;

    void Start()
    {
      layerMask = (1 << layer);

      // взять все слоты в масив
    }

    void Update()
    {
      Collider[] objectInRadius = Physics.OverlapSphere(player.transform.position, 30f, layerMask);

      Debug.Log(objectInRadius);
      foreach (var hitCollider in objectInRadius)
      {
          // Добовлять предмет в инвенятарь
          Destroy(hitCollider.gameObject);
      }
    }
}

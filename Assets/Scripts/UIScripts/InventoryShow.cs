using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryShow : MonoBehaviour
{
    public GameObject inventory;

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.E))
      {
        inventory.SetActive(!inventory.activeSelf);
      }
    }
}

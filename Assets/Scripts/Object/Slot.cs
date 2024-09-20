using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Item item;
    public GameObject itemInSlot;
    public GameObject TextInSlot;

    public void Update ()
    {
      if (item != null)
      {
        itemInSlot.GetComponent<Image>().SourceImage = item.item.sprite;
      } else {
        itemInSlot.GetComponent<Image>().SourceImage = null;
      }
    }
}

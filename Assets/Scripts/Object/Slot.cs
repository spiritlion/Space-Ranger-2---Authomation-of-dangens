using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public GameObject itemInSlot;
    public GameObject TextInSlot;
    public int count;

    public void Update ()
    {
      if (item != null)
      {
        itemInSlot.GetComponent<Image>().sprite = item.item.sprite;
        TextInSlot.GetComponent<Text>().text = count.ToString();
      } else {
        itemInSlot.GetComponent<Image>().sprite = null;
        TextInSlot.GetComponent<Text>().text = "";
      }
    }

}

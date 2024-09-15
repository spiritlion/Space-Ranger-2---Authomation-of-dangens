using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Inventory/Items/New Food")]

public class Food : ItemScriptableObject
{
    public float healAumont; // + сколько HP

    void Start()
    {
      itemType = ItemType.Food;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType {Defualt,Food,Weapon,Tool}

public class ItemScriptableObject : ScriptableObject
{
    public ItemType itemType;
    public string name; // Названиее
    public int maxAmount; // Максимальное колличество в одном слоте
    public string description; // описание
}

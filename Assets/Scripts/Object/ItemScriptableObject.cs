using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScriptableObject : ScriptableObject
{
    public string title;
    public int amount;
    public Sprite sprite;

    public void isClick()
    {
      Debug.Log("isClick in ItemScriptableObject");
    }
}

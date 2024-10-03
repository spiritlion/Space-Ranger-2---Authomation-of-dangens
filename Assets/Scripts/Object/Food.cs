using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Inventory/Create Food Item")]
public class Food : ItemScriptableObject
{
    public float HealthPlus;
    public float ArmorPlus;


    GameObject player;
    void Start()
    {
      player = GameObject.FindWithTag("Player");
    }

    public void isClick() {
      Debug.Log("isClick in Food");
      player.GetComponent<BarsControler>().Healthing(HealthPlus, ArmorPlus);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreCreate : MonoBehaviour
{
    public GameObject core;
    public float count = 1000f;
    public int x, y, z;
    public int posI;


    void Start()
    {
        for (int i = 0; i < count; i ++)
        {
          Instantiate(core, new Vector3(
              UnityEngine.Random.Range(-2000f, 2000f),
              posI,
              UnityEngine.Random.Range(-2000f, 2000f)),
              Quaternion.Euler(new Vector3(x, y, z))
              );
        }
    }

}

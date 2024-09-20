using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    public GameObject player;

    private float _mult = 1f;

    private void Update()
    {
      float hor = Input.GetAxis("Horizontal");
      float ver = Input.GetAxis("Vertical");

      transform.Translate(new Vector3(hor, 0 , ver) * Time.deltaTime * _mult * speed, Space.Self);


    }
}

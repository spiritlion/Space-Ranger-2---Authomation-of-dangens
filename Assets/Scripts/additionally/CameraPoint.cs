using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPoint : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = new Vector3(
        player.transform.position.x - 1,
        player.transform.position.y + 17,
        player.transform.position.z - 31
        );
    }
}

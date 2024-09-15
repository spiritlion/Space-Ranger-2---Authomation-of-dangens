using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemys;
    public GameObject[] SpawnPoints;
    public bool isPauseTimer;
    public int timerTime;
    public int dificult = 1;
    public bool isUpDificult = true;
    public int UpDificult = 1;


    private float timer = 0;

    public void Spawn(GameObject spawnPoint, GameObject enemy)
    {
      Instantiate(enemy, spawnPoint.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
    }

    private void Update()
    {
      if (timer > 0)
      {
        if (!isPauseTimer)
        {
          timer -= Time.deltaTime;
        }
      } else {
        timer = timerTime;

        for (int i = 0; i < dificult; i++)
        {
          Spawn(SpawnPoints[UnityEngine.Random.Range(0, SpawnPoints.Length)], enemys[UnityEngine.Random.Range(0, enemys.Length)]);
        }

        if (isUpDificult)
        {
          dificult += UpDificult;
        }


      }
    }
}

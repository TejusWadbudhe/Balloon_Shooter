using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloon;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());   
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);
        for(int i=0; i<3; i++)
        {
            Instantiate(balloon[i], spawnPoints[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallon : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] ballons;
    public float spawnTimer = 4f;
    private float countdown = 0f;
   
    void Start()
    {
       
    }

    private void Update()
    {
        Debug.Log(Time.time % spawnTimer);
       
        if(countdown <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(ballons[i], spawnPoints[i].position, Quaternion.identity);
            }

            countdown = spawnTimer;
        }
        countdown -= Time.deltaTime;
    }


    
}

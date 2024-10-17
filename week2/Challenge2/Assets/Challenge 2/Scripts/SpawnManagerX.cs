﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    
   
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();

    }

    // Spawn random ball at random x position at the top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index
      

        // Generate random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate ball at random spawn location with random ball prefab
        int ballNumber =Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(2f,4f));
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRate = 1f;
    public GameObject hexagonPrefab;
    private float nextTimetoSpawn = 0f;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
       
        if (Time.time >= nextTimetoSpawn) {
            
          
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimetoSpawn = Time.time + 3f / SpawnRate;
            
        }
    }

   
}

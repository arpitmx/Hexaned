using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed =4f;
    int currentScore = scorerecorder.Score;

    void Start()
    {
       
        rb.rotation = Random.Range(0f,360f);
        transform.localScale = Vector3.one * 5f;
        
    }

   
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x <= 0.3f) {
            Destroy(gameObject);
        }
    }
}

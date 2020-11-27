using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Player : MonoBehaviour
{
    public float speed = 600f;
    float movement = 0f;
    public Joystick joystick;
    bool isPaused = false;

    void Update()
    { 
        
        movement = joystick.Horizontal;
        scorerecorder.Score += 5;


    }



    private void FixedUpdate()
    {
       transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * speed);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     
            SceneManager.LoadScene("RetryPage");
         
       
        
    
    }

}

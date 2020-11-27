using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int dir = 1;

  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, dir*Time.deltaTime * 20f);        
    }
}

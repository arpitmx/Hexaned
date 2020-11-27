using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scorerecorder : MonoBehaviour
{
    public TextMeshProUGUI textmesh;
    public static int Score = 0 ;
    public void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
        Score = 0;
    }

    // Update is called once per frame
   public void Update()
    {
        
        textmesh.text = Score.ToString();
        PlayerPrefs.SetInt("Highscore", Score);
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreDisplayerRetryPage : MonoBehaviour
{
    public TextMeshProUGUI textmesh;
  
 
    public void Start()
    {
        
        textmesh = GetComponent<TextMeshProUGUI>();
        textmesh.text = scorerecorder.Score.ToString();

        if (scorerecorder.Score > PlayerPrefs.GetInt("Highscore1")) {
            PlayerPrefs.SetInt("Highscore1",(int)scorerecorder.Score);
        
        }
       

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScoreLoader : MonoBehaviour
{
    private TextMeshProUGUI textmesh;
    
    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
        textmesh.text ="Last HighScore :"+ PlayerPrefs.GetInt("Highscore1");
    }

    // Update is called once per frame
  
}

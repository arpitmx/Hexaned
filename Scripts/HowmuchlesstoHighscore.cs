using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HowmuchlesstoHighscore : MonoBehaviour
{
    public TextMeshProUGUI textmesh;
    int Scoremade = scorerecorder.Score;



    void Start()
    { textmesh = GetComponent<TextMeshProUGUI>();

        if (Scoremade <= 5000)
        {
            textmesh.text = "This game is not for you! ";
        }


        else if (Scoremade <= 10000)
        {
            textmesh.text = "Can't you beat 10000? , huh. ";
        }


        else if (Scoremade > 10000 && Scoremade <= 20000)
        {
            textmesh.text = "Good, But not that great! More than 20000? ";
        }
        else if (Scoremade > 20000 && Scoremade <= 30000)
        {
            textmesh.text = "You are a beast , for sure! ";
        }
        else if (Scoremade > 30000 && Scoremade <= 40000)
        {
            textmesh.text = "Hexa King !";
        }
        else if (Scoremade >40000)
        {
            textmesh.text = "Hexa King !";
        }
        else {
            textmesh.text = "Why are you even playing?? ";

        }
    }

    
   
}

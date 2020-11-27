using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HscoreloaderHomepage : MonoBehaviour
{
    private TextMeshProUGUI textmesh1;

    // Start is called before the first frame update
    void Start()
    {
        textmesh1 = GetComponent<TextMeshProUGUI>();
        textmesh1.text =  PlayerPrefs.GetInt("Highscore1").ToString();
    }

    // Update is called once per frame

}

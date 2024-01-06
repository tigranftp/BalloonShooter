using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreRecordInTheEndScript : MonoBehaviour
{
    public GameObject NewRecordLabel;
    public TextMeshProUGUI score;
    void Start()
    {
        NewRecordLabel.SetActive(Scores.UpdateScores(GameStateScript.instance.score));
        score.text = "Score: " + GameStateScript.instance.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderBoardScript : MonoBehaviour
{
    public RowUI rowUi;
    public GameObject content;
    void Start()
    {
        var jsonScores = PlayerPrefs.GetString("scores", "{}");
        Debug.Log(jsonScores);
        if (jsonScores == "{}") {
            return;
        }
        var scores = JsonUtility.FromJson<Scores>(jsonScores);
        for (int i = 0; i < scores.scores.Count; i++)
        {
            var row = Instantiate(rowUi, content.transform).GetComponent<RowUI>();
            row.rank.text = (i+1).ToString();
            row.nickname.text = scores.scores[i].name;
            row.score.text = scores.scores[i].scoreValue.ToString();

        }

    }


    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Score
{
    public Score(string name, int scoreValue) {
        this.name = name;
        this.scoreValue = scoreValue;

    }
    public string name;
    public int scoreValue;
}

[Serializable]
public class Scores
{
    public List<Score> scores;

    public static bool UpdateScores(int scoreValue)
    {
        var curNickname = PlayerPrefs.GetString("currentName", "");
        if (curNickname == "") {
            return false;
        }
        var jsonScores = PlayerPrefs.GetString("scores", "{}");
        Scores scores;
        if (jsonScores == "{}")
        {
            scores = new Scores();
            scores.scores = new List<Score>();
            scores.scores.Add( new Score(curNickname, scoreValue));
            PlayerPrefs.SetString("scores", JsonUtility.ToJson(scores));
            Debug.Log(JsonUtility.ToJson(scores));
            return true;
        }
        scores = JsonUtility.FromJson<Scores>(jsonScores);
        for (int i = 0; i < scores.scores.Count; i++)
        {
            if (scoreValue > scores.scores[i].scoreValue) {
                scores.scores.Insert(i, new Score(curNickname, scoreValue));
                if (scores.scores.Count > 8) {
                    scores.scores.RemoveRange(0, 8);
                }
                PlayerPrefs.SetString("scores", JsonUtility.ToJson(scores));
                return true;
            }
        }
        if (scores.scores.Count < 8) {
            scores.scores.Insert(scores.scores.Count, new Score(curNickname, scoreValue));
            PlayerPrefs.SetString("scores", JsonUtility.ToJson(scores));
            return true;

        }
        return false;
    }
}

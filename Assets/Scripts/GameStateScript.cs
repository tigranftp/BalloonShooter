using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateScript: MonoBehaviour
{

    public static GameStateScript instance;

    [HideInInspector]public int score;
    [HideInInspector]public float gameSpeed;
    [HideInInspector]public int health;
    const float startGameSpeed = 0.2f;
    const int defaultHP = 3;

    private void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        health = defaultHP;
        gameSpeed = startGameSpeed;
    }

    void Update()
    {
        gameSpeed = startGameSpeed + score * 0.05f; 
    }

}

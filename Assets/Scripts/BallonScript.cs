using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonScript : MonoBehaviour
{
    [HideInInspector]public float gameSpeed;
    public GameObject main;

    private void Start()
    {
        main.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1.0f);

    }
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * gameSpeed);
    }
}

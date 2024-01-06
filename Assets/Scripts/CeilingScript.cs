using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CeilingScript : MonoBehaviour
{
    public GameStateScript gameState;
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        Destroy(collision.gameObject);
        gameState.health--;
        CheckHealthAndGameOverIfNeeded();
    }

    void CheckHealthAndGameOverIfNeeded()
    {
        if (gameState.health > 0)
        {
            return;
        }
        SceneManager.LoadScene("GameEnd");    
    }
}

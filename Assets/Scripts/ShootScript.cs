using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public GameStateScript gameState;

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            var colorOfBallon = hit.transform.gameObject.GetComponent<BallonScript>().main.GetComponent<Renderer>().material.color;
            Destroy(hit.transform.gameObject);
            gameState.score++;
            GameObject newSmoke = Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            newSmoke.GetComponent<Renderer>().material.color = colorOfBallon;

        }
    }

}

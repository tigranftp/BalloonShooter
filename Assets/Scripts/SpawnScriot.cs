using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriot : MonoBehaviour
{
    public int ballonsCountByTime;
    public GameObject[] ballons;
    public GameStateScript gameStateScript;
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);
        for (int i = 0; i < ballonsCountByTime; i++)
        {
            ballons[i % 3].GetComponent<BallonScript>().gameSpeed = gameStateScript.gameSpeed;
            var tempVec = RandomPointInAnnulus(new Vector2(0, 0), 2.0f, 5.0f);
            Vector3 positionOfNewBallon = new Vector3(tempVec.x, -3, tempVec.y);
            Instantiate(ballons[i % 3], positionOfNewBallon, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }

    public Vector2 RandomPointInAnnulus(Vector2 origin, float minRadius, float maxRadius)
    {

        var randomDirection = (Random.insideUnitCircle).normalized;

        var randomDistance = Random.Range(minRadius, maxRadius);

        var point = origin + randomDirection * randomDistance;

        return point;
    }
}

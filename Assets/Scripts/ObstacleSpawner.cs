using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePair;
    [SerializeField] private int intialObjectCount = 4;
    [SerializeField] private float obstaclesPadding = 3.0f;

    private List<GameObject> obstaclePairs = new List<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < intialObjectCount; i++)
        {
            GameObject obstacle = Instantiate(pipePair, new Vector2(transform.position.x + (i * obstaclesPadding), transform.position.y + Random.Range(-3.75f, -0.25f)), Quaternion.identity);
            obstacle.transform.SetParent(transform);
            obstacle.SetActive(true);
            obstaclePairs.Add(obstacle);
        }
    }

    private void FixedUpdate()
    {
        GameObject obstaclePair = GetInactiveObstacle();

        if (obstaclePair != null)
        {
            obstaclePair.transform.SetPositionAndRotation(new Vector2(transform.position.x + obstaclesPadding, transform.position.y + Random.Range(-3.75f, -0.25f)), transform.rotation);
            obstaclePair.SetActive(true);
        }
    }

    private GameObject GetInactiveObstacle()
    {
        foreach (GameObject obstacle in obstaclePairs)
        {
            if (!obstacle.activeInHierarchy)
            {
                return obstacle;
            }
        }

        return null;
    }
}

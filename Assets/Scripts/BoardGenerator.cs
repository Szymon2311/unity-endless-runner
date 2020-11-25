using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector2 boardBorders;
    [SerializeField] private float generationoffset = 10f;
    [SerializeField] private float generationdistance = 100f;
    [SerializeField] private float destructionDistance = 20f;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Transform obstaclesParent;
    [SerializeField] private List<GameObject> obstacles;
    
    private float lastZOffset;

    private void Start()
    {
        GenerateObstacles();

    }

    private void Update()
    {
        if(target.position.z > obstacles[0].transform.position.z + destructionDistance)
        {
            Destroy(obstacles[0]);
            obstacles.RemoveAt(0);

            lastZOffset += generationoffset;
            obstacles.Add(GenerateObstacle(lastZOffset));

        }
    }

    private void GenerateObstacles()
    {
        while(lastZOffset < target.position.z + generationdistance)
        {
            lastZOffset += generationoffset;
            obstacles.Add(GenerateObstacle(lastZOffset));
        }
    }

    private GameObject GenerateObstacle(float zOffset)
    {
        Vector3 spawnPosition = new Vector3(Random.Range(boardBorders[0], boardBorders[1]),
        target.position.y,
        zOffset);
        
        return Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity, obstaclesParent);
    }
}

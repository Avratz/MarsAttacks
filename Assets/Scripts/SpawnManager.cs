using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies;
    private float spawnRate = 2.0f;
    private float zBoundary = 10f;
    private float xSpawn = 30f;
    
    private void Awake() {
        InvokeRepeating("SpawnRandomEnemy", 1, spawnRate);
    }

    void SpawnRandomEnemy()
    {
        int randomEnemyIndex = Random.Range(0, enemies.Count);
        GameObject randomEnemy = enemies[randomEnemyIndex];
        Vector3 randomPosition = GenerateRandomPosition();
        Instantiate(randomEnemy, randomPosition, randomEnemy.transform.rotation);
    }

    Vector3 GenerateRandomPosition()
    {
        float randomZ = Random.Range(-zBoundary, zBoundary);
        return new Vector3(xSpawn, 1, randomZ);
    }
}

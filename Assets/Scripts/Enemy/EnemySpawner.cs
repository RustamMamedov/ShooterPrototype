using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField, Range(.5f, 3f)] private float spawnDeltaTimeInSeconds;
    [SerializeField] private List<Transform> spawnPoints;
    [SerializeField] private GameObjectSet enemies;


    // There is posible to use enemy pool here.
    // But in case of spawning not so much enemies i used instantiating.
    [SerializeField] private GameObject enemyPrefab; 
    private float spawnDelta = 0;

    private void OnEnable()
    {
        enemies.Clear();
    }

    public void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab);
        enemies.AddItem(enemy);
        PointEnemy(enemy);
    }

    private void PointEnemy(GameObject enemy)
    {
        Transform spawnPoint = GetRandomSpawnPoint();
        enemy.transform.position = spawnPoint.position;
        enemy.transform.rotation = spawnPoint.rotation;
    }

    private Transform GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Count)];
    }

    public void RemoveEnemy(GameObject enemy)
    {
        Destroy(enemy); // or recycle to pool
    }

    public void DestroyAllEnemies()
    {
        for (int i = enemies.Items.Count-1; i >= 0; i--)
            RemoveEnemy(enemies.Items[i]);

        enemies.Clear();
    }
}

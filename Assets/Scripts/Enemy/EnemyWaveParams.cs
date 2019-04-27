using UnityEngine;

[CreateAssetMenu]
public class EnemyWaveParams : ScriptableObject
{
    [Range(1,10)] public int waveCount = 3;
    [Range(1,10)] public int enemiesInWave = 3;
    [Range(.5f,3f)] public float spawnEnemyInEverySecond = .5f;
    [Range(3f,5f)] public float delayBetweenWaves = 3f;
}

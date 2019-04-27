using UnityEngine;
using UnityEngine.Events;

public class EnemyWaveConrtoller : MonoBehaviour
{
	[SerializeField] private EnemyWaveParams waveParams;
    [SerializeField] private BoolValue wavesDonde;
    [SerializeField] private IntegerValue currentWave;    
    [SerializeField] private GameObjectSet enemiesOnScene;
    [SerializeField, Range(1f,3f)] private float delayBetweenWavesInSeconds = 2f;
    public UnityEvent OnSpawnTimerEvent;
	private float waveTimer;
    private int enemiesLeftToSpawnInWave;


	public void InitParams()
	{
		currentWave.Value = 0;
        wavesDonde.Value = false;
        StartNextWave();
	}

	public void OnUpdate()
	{
        UpdateWaveTimer();
	}

    private void UpdateWaveTimer()
    {
        if (enemiesLeftToSpawnInWave == 0)
            return;

		waveTimer -= Time.deltaTime;

        if (waveTimer > 0)
            return;

        ItsSpawnTime();
    }

    private void ItsSpawnTime()
    {
        enemiesLeftToSpawnInWave--;
        waveTimer = waveParams.spawnEnemyInEverySecond;
        OnSpawnTimerEvent?.Invoke();
    }

    public void OnEnemyDie()
    {
        CheckEndOfWaves();
    }

    private void CheckEndOfWaves()
    {
        if (enemiesOnScene.Items.Count > 0)
            return;

        if (enemiesLeftToSpawnInWave > 0)
            return;    

        if (currentWave.Value < waveParams.waveCount)
        {
            StartNextWave();
            return;
        }

        Win();
    }

    private void StartNextWave()
    {
        currentWave.Value++;
        waveTimer = waveParams.spawnEnemyInEverySecond;
        if (currentWave.Value>1)
            waveTimer+=delayBetweenWavesInSeconds;
		enemiesLeftToSpawnInWave = waveParams.enemiesInWave;
    }

    private void Win()
    {
        wavesDonde.Value = true;
    }
}

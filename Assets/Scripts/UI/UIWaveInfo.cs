using UnityEngine;
using UnityEngine.UI;

public class UIWaveInfo : MonoBehaviour
{
    [SerializeField] private IntegerValue currentWave;
    [SerializeField] private Text waveText;
    private int prevWaveValue;

    [SerializeField] private GameObjectSet enemiesOnScene;
    [SerializeField] private Text enemiesLeftText;
    private int prevenEmiesLeftValue;

    public void OnUpdate()
    {
        ShowCurrentWaveText();
        ShowEnemiesLeftInWave();
    }

    private void ShowCurrentWaveText()
    {
        if (prevWaveValue == currentWave.Value)
            return;

        waveText.text = currentWave.Value.ToString();
        prevWaveValue = currentWave.Value;
    }

    private void ShowEnemiesLeftInWave()
    {
        if (prevenEmiesLeftValue == enemiesOnScene.Items.Count)
            return;

        enemiesLeftText.text = enemiesOnScene.Items.Count.ToString();
        prevenEmiesLeftValue = enemiesOnScene.Items.Count;
    }
}

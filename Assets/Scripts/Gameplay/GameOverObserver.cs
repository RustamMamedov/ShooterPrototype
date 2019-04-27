using UnityEngine;
using UnityEngine.Events;

public class GameOverObserver : MonoBehaviour
{
    [SerializeField] private IntegerValue playerHealth;
    [SerializeField] private BoolValue isGameStarted;
    public UnityEvent OnGameOver;

    public void OnUpdate()
    {
        CheckPlayerHealth();
    }

    private void CheckPlayerHealth()
    {
        if (playerHealth.Value > 0)
            return;

        isGameStarted.Value = false;
        OnGameOver?.Invoke();
    }

}

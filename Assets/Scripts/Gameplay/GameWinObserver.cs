using UnityEngine;
using UnityEngine.Events;

public class GameWinObserver : MonoBehaviour
{
    [SerializeField] private BoolValue isWavesDone;
    [SerializeField] private BoolValue isGameStarted;
    public UnityEvent OnGameWin;

    public void OnUpdate()
    {
        if (!isWavesDone.Value)
            return;

        if (!isGameStarted.Value)
            return;

        isGameStarted.Value = false;

        OnGameWin?.Invoke();
    }

}

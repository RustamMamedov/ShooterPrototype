using UnityEngine;
using UnityEngine.Events;

public class GameStartObserver : MonoBehaviour
{
    [SerializeField] private FloatValue startCountDown;
    [SerializeField] private BoolValue isGamestarted;
    [SerializeField] private GameEvent OnGameStarted;

    public void OnUpdate()
    {
        if (isGamestarted.Value)
            return;

        if (startCountDown.value > 0f)
            return;

        isGamestarted.Value = true;  
        OnGameStarted?.InvokeEvent();
    }
}

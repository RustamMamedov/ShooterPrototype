using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieDispatcher : MonoBehaviour
{
    [SerializeField] GameEvent OnEnemyDie;

    public void DispatchEnemyDie()
    {
        OnEnemyDie?.InvokeEvent();
    }
}

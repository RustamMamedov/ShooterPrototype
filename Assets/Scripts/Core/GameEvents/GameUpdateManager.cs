using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUpdateManager : MonoBehaviour
{
    [SerializeField] private BoolValue UpdateCondition;
    [SerializeField] private bool UpdateWhenConditionValueIs = true;
    [SerializeField] private GameEvent OnUpdate;
    [SerializeField] private GameEvent OnFixedUpdate;
    [SerializeField] private GameEvent OnLateUpdate;

    private void Awake()
    {
        UpdateCondition.Value = false;
    }

    private void Update()
    {
        if (UpdateCondition == null)
        {
            OnUpdate?.InvokeEvent();
            return;
        }

        if (UpdateCondition.Value == UpdateWhenConditionValueIs)
            OnUpdate?.InvokeEvent();
    }

    private void FixedUpdate()
    {
        if (UpdateCondition == null)
        {
            OnFixedUpdate?.InvokeEvent();
            return;
        }

        if (UpdateCondition.Value == UpdateWhenConditionValueIs)
            OnFixedUpdate?.InvokeEvent();
    }

    private void LateUpdate()
    {
        OnLateUpdate?.InvokeEvent();
    }
}

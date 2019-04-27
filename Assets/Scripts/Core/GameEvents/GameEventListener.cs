﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
    [SerializeField] private GameEventResponse response;

    private void OnEnable()
    {
        gameEvent?.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent?.UnregisterListener(this);
    }

    public void OnEventInvoked(GameEventData data)
    {
        response.Invoke(data);
    }
}

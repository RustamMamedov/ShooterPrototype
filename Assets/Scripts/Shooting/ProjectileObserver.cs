using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileObserver : MonoBehaviour
{
    [SerializeField] private ProjectileSet projectiles;

    public void OnGameStart()
    {
        projectiles.Clear();
    }

    public void OnUpdate()
    {
        for (int i = 0; i < projectiles.Items.Count; i++)
            projectiles.Items[i].OnUpdate();
    }
}

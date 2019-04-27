using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ProjectileParams : ScriptableObject
{
    [Range(1,5)] public int LifeTimeInSeconds = 3;
    [Range(1f,30f)] public float Speed = 1f;
}

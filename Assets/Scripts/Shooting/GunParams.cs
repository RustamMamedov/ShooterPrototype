using UnityEngine;

[CreateAssetMenu]
public class GunParams : ScriptableObject
{
    public RuntimePool projectilePool;
    [Range(0.1f, 3f)] public float RechargeTimeInSeconds = 1f;
}

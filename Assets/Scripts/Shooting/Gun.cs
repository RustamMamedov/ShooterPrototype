using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public GunParams gunParams;
    public Transform projectileSpawnPoint;
    // [HideInInspector] public float currentRechargeTime= 0f;
    [SerializeField] protected FloatValue currentRechargeTime;

    public abstract void Shoot();
}

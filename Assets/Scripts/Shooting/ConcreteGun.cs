using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteGun : Gun
{
    public override void Shoot()
    {
        if (currentRechargeTime.value > 0)
            return;
            
        CreateProjectile();
        SetRechargeTime();
    }

    private void CreateProjectile()
    {
        new ProjectileSpawner(gunParams.projectilePool, projectileSpawnPoint);
    }

    private void SetRechargeTime()
    {
        currentRechargeTime.value = gunParams.RechargeTimeInSeconds;
    }

    public void OnUpdate()
    {
        currentRechargeTime.value = Mathf.Max(0, currentRechargeTime.value - Time.deltaTime);
    }
}

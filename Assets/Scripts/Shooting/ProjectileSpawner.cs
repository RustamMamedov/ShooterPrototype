using UnityEngine;

public class ProjectileSpawner // TODO:
{
    public ProjectileSpawner(RuntimePool pool, Transform spawnTransform)
    {
        GameObject projectileObject = pool.GetItem();
        Projectile projectile = projectileObject.GetComponent<Projectile>();

        if (projectile == null)
            return;

        projectileObject.transform.position = spawnTransform.position;
        projectileObject.transform.rotation = spawnTransform.rotation;
        projectileObject.transform.forward = spawnTransform.forward;

        projectile.OnAddedToScene();
    }
}

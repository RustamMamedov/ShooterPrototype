using UnityEngine;
using UnityEngine.Events;

public class Projectile : MonoBehaviour
{
	[SerializeField] ProjectileParams projectileParams;
	[SerializeField] ProjectileSet projectileSet;
	private float lifeTime;
	public UnityEvent OnLifeTimeEnd;

	public void OnAddedToScene()
	{
		projectileSet.AddItem(this);
		lifeTime = projectileParams.LifeTimeInSeconds;
	}

	public void OnUpdate()
	{
		Move();
        CheckLifeTime();
	}

	private void Move()
	{
		transform.position += projectileParams.Speed * Time.deltaTime * transform.forward;
	}

	private void CheckLifeTime()
	{
		lifeTime -= Time.deltaTime;

		if (lifeTime <= 0)
			RemoveFromScene();
	}

	private void RemoveFromScene()
	{
		projectileSet.RemoveItem(this);
		OnLifeTimeEnd?.Invoke();
	}
}

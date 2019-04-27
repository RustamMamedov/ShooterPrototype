using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damager : MonoBehaviour
{
	public int damage;
	public LayerMask hittableLayers;
	private bool canDamage = true;
	private Vector3 halfScale;
	private Collider[] hitColliders;
    [SerializeField] private UnityEvent OnDamageableHit;

    private void OnEnable()
    {
        halfScale = transform.localScale * .5f;
        canDamage = true;
    }

	public void OnUpdate()
	{
        UpdateDamager();
	}

	public void EnableDamage()
	{
		canDamage = true;
	}

	public void DisableDamage()
	{
		canDamage = false;
	}

	public void UpdateDamager()
	{
		if (!canDamage)
			return;

		hitColliders = Physics.OverlapBox(transform.position, halfScale, Quaternion.identity, hittableLayers);

		for (int i = 0; i < hitColliders.Length; i++)
		{
			Damageable damageable = hitColliders[i].GetComponent<Damageable>();

			if (damageable == null)
				continue;

            OnDamageableHit?.Invoke();
            DisableDamage();
			damageable.TakeDamage(this);
		}
	}

}

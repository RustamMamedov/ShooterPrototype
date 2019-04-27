using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public int startHealth;
	public int health;
    [SerializeField] UnityEvent OnTakeDamage;
    [SerializeField] UnityEvent OnDie;
    [SerializeField] private IntegerValue intValue;

    public void ResetHealth()
    {
        SetHealth(startHealth);
    }

    private void OnEnable()
    {
        WriteHealthValue();
    }

	public void TakeDamage(Damager damager)
	{
		SetHealth(Mathf.Max(0, health - damager.damage));

        OnTakeDamage?.Invoke();

        if (health == 0)
            Die();
	}

    public void SetHealth(int value)
    {
        health = value;
        WriteHealthValue();
    }

    public void Die()
    {
        OnDie?.Invoke();
    }

    public void WriteHealthValue()
    {
        if (intValue== null)
            return;

        intValue.Value = health;
    }    
}

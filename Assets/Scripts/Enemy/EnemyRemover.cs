using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRemover : MonoBehaviour
{
	[SerializeField] private GameObjectSet enemiesOnScene;

	public void RemoveEnemyFromSet(GameObject enemy)
	{
		enemiesOnScene.RemoveItem(enemy);
	}

    public void DestroyEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }
}

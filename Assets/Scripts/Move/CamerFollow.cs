using UnityEngine;

public class CamerFollow : MonoBehaviour
{
	[SerializeField] private Transform target;
	public float cameraDistance = 20.0f;
	public float cameraHeight = 10.0f;
	private Vector3 heightVector;

	private void OnEnable()
	{
		heightVector = new Vector3(0, cameraHeight, 0);
	}

	public void OnLateUpdate()
	{
		if (target == null)
			return;

		transform.position = target.position - target.forward * cameraDistance + heightVector;
		transform.LookAt(target);
	}
}

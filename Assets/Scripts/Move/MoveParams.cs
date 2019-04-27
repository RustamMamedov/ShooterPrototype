using UnityEngine;

[CreateAssetMenu]
public class MoveParams : ScriptableObject
{
    [Range(1f,50f)] public float moveAccelerationForce;
    [Range(0.1f,20f)] public float maxMoveSpeed;
    [Range(1f,50f)] public float rotationAccelerationForce;
    [Range(0.1f,5f)] public float maxRotationSpeed;
}

using UnityEngine;

public class PlayerMove : CharacterMove
{
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Vector3Value inputVector;
    [SerializeField] private Vector3Value positionValue;

    public override void Move()
    {
        if (Mathf.Abs(rig.velocity.z) >= moveParams.maxMoveSpeed)
            return;

        if (Mathf.Abs(rig.velocity.x) >= moveParams.maxMoveSpeed)
            return;

        rig.AddForce(rig.transform.TransformDirection(inputVector.Value) * moveParams.moveAccelerationForce, ForceMode.Acceleration);

        positionValue.Value = rig.transform.position;
    }

    public void ResetPosition()
    {
        rig.transform.position = Vector3.zero;
    }
}

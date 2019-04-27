using UnityEngine;

public abstract class CharacterMove : MonoBehaviour
{
    protected Rigidbody rigidBody;
    [SerializeField] protected MoveParams moveParams;

    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    public abstract void Move();
}

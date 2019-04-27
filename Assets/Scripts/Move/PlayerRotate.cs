using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Vector3Value mouseButton1ClickPosition;

    public void Rotate()
    {
        if (mouseButton1ClickPosition.Value == Vector3.zero)
            return;

        // Vector3 mouseCurrentPosition    
        float dif = Input.mousePosition.x - mouseButton1ClickPosition.Value.x;
        mouseButton1ClickPosition.Value = Input.mousePosition;

        rig.transform.Rotate(Vector3.up, dif);
    }

    public void ResetRotation()
    {
        rig.transform.rotation = Quaternion.identity;
    }
}

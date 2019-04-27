using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private string Horizontal = "Horizontal";
    private string Vertical = "Vertical";

    [SerializeField] private Vector3Value inputVector;
    [SerializeField] private Vector3Value mouseButton1ClickPosition;

    [SerializeField] private GameEvent MouseLeftButtonClicked;

    private void OnEnable()
    {
        ResetInputValues();
    }

    public void ResetInputValues()
    {
        inputVector.Value = Vector3.zero;
        mouseButton1ClickPosition.Value = Vector3.zero;
    }

    public void OnUpdate()
    {
        inputVector.Value.x = Input.GetAxis(Horizontal);
        inputVector.Value.z = Input.GetAxis(Vertical);

        if (Input.GetMouseButtonDown(0))
            MouseLeftButtonClicked?.InvokeEvent();


        if (Input.GetMouseButtonDown(1))
            mouseButton1ClickPosition.Value = Input.mousePosition;

        if (Input.GetMouseButtonUp(1))
            mouseButton1ClickPosition.Value = Vector3.zero;
    }
}

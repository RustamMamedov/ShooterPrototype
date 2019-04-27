using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteHealthToValue : MonoBehaviour
{
    [SerializeField] private IntegerValue intValue;

    public void WriteValue(int value)
    {
        intValue.Value = value;
    }
}

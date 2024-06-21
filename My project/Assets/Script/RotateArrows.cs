using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArrows : MonoBehaviour
{
    public static Transform blockRotation;

    private void Update()
    {
        Quaternion rot = Camera.main.transform.rotation;
        transform.rotation = rot;
    }
}

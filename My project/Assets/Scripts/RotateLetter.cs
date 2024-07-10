using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLetter : MonoBehaviour
{
    [SerializeField] GameObject arrowCamera;

    void Update()
    {
        gameObject.transform.LookAt(arrowCamera.transform);
    }

}

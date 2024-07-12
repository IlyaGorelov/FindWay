using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToSelectedBlock : MonoBehaviour
{
    public GameObject selected=null;

    private void Update()
    {
        if (selected != null && States.isEditMode)
        {
            transform.LookAt(selected.transform.position);
        }
    }
    //On FirstPersonController
}

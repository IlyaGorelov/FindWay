using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToSelectedBlock : MonoBehaviour
{
    public GameObject block=null;

    private void Update()
    {
        if (block != null && States.isSelectMode)
        {
            transform.LookAt(block.transform.position);
        }
    }
}

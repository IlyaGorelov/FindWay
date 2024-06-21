using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEditMode : MonoBehaviour
{
    public bool isSelected = false;

    public void BecomeSelected()
    {
        isSelected = true;
        GameObject go = GameObject.Find("FirstPersonController");
        RotateToSelectedBlock rotateTo = go.GetComponent<RotateToSelectedBlock>();
        rotateTo.block = gameObject;
        RotateArrows.blockRotation = transform;
    }
    public void Deselect()
    {
        isSelected = false;
        GameObject go = GameObject.Find("FirstPersonController");
        RotateToSelectedBlock rotateTo = go.GetComponent<RotateToSelectedBlock>();
        rotateTo.block = null;
    }

    private void Update()
    {
        if (!States.isSelectMode)
        {
            Deselect();
        }
    }

    //On Block
}

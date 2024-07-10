using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBlock : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private LayerMask block;
    [SerializeField] private LayerMask arrow;
    //   private GameObject SelectInput;
    private ActivateEditMode positionChange;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!States.isSelectMode) States.isSelectMode = true;
            else States.isSelectMode = false;

        }
        if (States.isSelectMode)
        {
            //  SelectInput = GameObject.Find("SelectInput");
            Select();
        }
    }

    private void Select()
    {
        bool canDoIt = true;
        Vector3 mouse = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mouse);

        canDoIt = !Physics.Raycast(ray, out RaycastHit tempHit, 10, arrow);

        if (Physics.Raycast(ray, out RaycastHit hit, 100, block))
        {
            Transform hitted = hit.transform;
            if (Input.GetMouseButtonDown(0) && canDoIt)
            {
                try
                {
                    positionChange.Deselect();
                }//Deselect previous object with positionChange
                catch { }
                positionChange = hitted.GetComponent<ActivateEditMode>();
                positionChange.BecomeSelected();
                print(hit.transform.name);
            }
        }
    }
}

//On FirstPersonController


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBlock : MonoBehaviour
{
    [SerializeField] private GameObject camera;

    [SerializeField] LayerMask block;
    private GameObject SelectInput;
    private PositionChange positionChange;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            if (!States.isSelectMode) States.isSelectMode = true; 
            else States.isSelectMode = false;

        }
        if (States.isSelectMode) { 
            SelectInput = GameObject.Find("SelectInput");
            Select(); }
    }

   private void Select()
    {
        Vector3 mouse = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,10, block))
        { 
            Transform hitted = hit.transform;
                print(hitted.gameObject.name);
            if (Input.GetMouseButtonDown(0))
            {
                try
                {
                    positionChange.Deselect();
                }
                catch { }
                positionChange= hitted.GetComponent<PositionChange>();
                positionChange.BecomeSelected();
            }
        }
    }
}

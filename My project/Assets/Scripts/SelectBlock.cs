using UnityEngine;

public class SelectBlock : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private LayerMask block;
    private ActivateEditMode positionChange;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!States.isEditMode) States.isEditMode = true;
            else States.isEditMode = false;
        }
        if (States.isEditMode)
        {
            Select();
        }
    }

    private void Select()
    {
        Vector3 mouse = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mouse);

        if (Physics.Raycast(ray, out RaycastHit hit, 100, block))
        {
            Transform hitted = hit.transform;
            if (Input.GetMouseButtonDown(0))
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



using UnityEngine;

public class PositionChange : MonoBehaviour
{
    
    [SerializeField] float changer = 0.05f;
    private ActivateEditMode activateEditMode;

    private void Start()
    {
        activateEditMode = GetComponent<ActivateEditMode>();
        
    }
    private void Update()
    {
        if (activateEditMode.isSelected && States.isSelectMode)
        {
            switch (States.mode)
            {
                case States.SelectModeState.Position:
                    ChangePosition(changer);
                    break;
            }
        }
    }
    private void ChangePosition(float changer)
    {
       if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(changer, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(changer, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, changer);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= new Vector3(0, 0, changer);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, changer, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= new Vector3(0, changer, 0);
        }
    }
}

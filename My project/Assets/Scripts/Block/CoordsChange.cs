
using UnityEngine;

public class CoordsChange : MonoBehaviour
{
    [SerializeField] float changer = 0.05f;
    [SerializeField] float degrees = 0.5f;
    private ActivateEditMode activateEditMode;

    private void Start()
    {
        activateEditMode = GetComponent<ActivateEditMode>();
    }
    private void Update()
    {
        if (activateEditMode.isSelected && States.isEditMode)
        {
            switch (States.mode)
            {
                case States.EditModeState.Position:
                    ChangePosition(changer);
                    break;
                case States.EditModeState.Size:
                    ChangeSize(changer);
                    break;
                case States.EditModeState.Rotate:
                    ChangeRot(degrees);
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
        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, changer, 0);
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.C))
        {
            transform.position -= new Vector3(0, changer, 0);
        }
    }

    private void ChangeSize(float changer)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale += new Vector3(changer, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.localScale -= new Vector3(changer, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale += new Vector3(0, 0, changer);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale -= new Vector3(0, 0, changer);
        }
        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Space))
        {
            transform.localScale += new Vector3(0, changer, 0);
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.C))
        {
            transform.localScale -= new Vector3(0, changer, 0);
        }
    }
    private void ChangeRot(float changer)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(changer, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(-changer, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 0, changer);
        }
        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 0, -changer);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Space))
        {
            transform.rotation *= Quaternion.Euler(0, changer, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.C))
        {
            transform.rotation *= Quaternion.Euler(0, -changer, 0);
        }
    }
}
// On block prefab
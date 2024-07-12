using UnityEngine;

public class ChangeEditMode : MonoBehaviour
{
    [SerializeField] States states;
    [SerializeField] ArrowsControl arrowsControl;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            States.mode = States.EditModeState.Position;
            states.HighlightButton(states.buttonPos);
            arrowsControl.ActivateDifferentArrows(1);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            States.mode = States.EditModeState.Size;
            states.HighlightButton(states.buttonSize);
            arrowsControl.ActivateDifferentArrows(2);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            States.mode = States.EditModeState.Rotate;
            states.HighlightButton(states.buttonRot);
            arrowsControl.ActivateDifferentArrows(3);
        }
    }
    //On EditManager
}

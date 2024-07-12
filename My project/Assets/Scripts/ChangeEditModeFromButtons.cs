using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEditModeFromButtons : MonoBehaviour
{
    public void PositionMode() =>
        States.mode = States.EditModeState.Position;

    public void SizeMode() =>
        States.mode = States.EditModeState.Size;

    public void RotateMode() =>
        States.mode = States.EditModeState.Rotate;

}
// On ArrowsCamera
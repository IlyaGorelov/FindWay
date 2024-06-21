using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour
{
    public static bool isPaused;
    public static bool isSelectMode;
    public enum SelectModeState
    {
        Position, Size, Rotate
    }
    public static SelectModeState mode = SelectModeState.Position;
}

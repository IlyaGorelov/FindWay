using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class States : MonoBehaviour
{
    public static bool isPaused;
    public static bool isSelectMode;
    public static bool isBuildMode;
    public static GameObject selectedBlock = null;

    public enum SelectModeState
    {
        Position, Size, Rotate
    }
    public static SelectModeState mode = SelectModeState.Position;

    [SerializeField] Outline buttonPos;

    private void Update()
    {
        if (isSelectMode) isBuildMode = false;
        if(mode == SelectModeState.Position)
        {
            buttonPos.effectColor += new Color(0, 0, 0, 1);
        }
    }
}

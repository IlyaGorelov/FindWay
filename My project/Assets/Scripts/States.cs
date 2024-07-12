using UnityEngine;
using UnityEngine.UI;

public class States : MonoBehaviour
{
    public static bool isPaused;
    public static bool isEditMode;
    public static bool isBuildMode;
    public static GameObject selectedBlock = null;

    public enum EditModeState
    {
        Position, Size, Rotate
    }
    public static EditModeState mode = EditModeState.Position;

    [SerializeField] public Outline buttonPos;
    [SerializeField] public Outline buttonSize;
    [SerializeField] public Outline buttonRot;


    private void Update()
    {
        if (isEditMode) isBuildMode = false;
    }
    public void HighlightButton(Outline outline)
    {
        if (outline == buttonPos)
        {
            buttonPos.effectColor += new Color(0, 0, 0, 1);
             buttonSize.effectColor *= new Color(1, 1, 1, 0);
              buttonRot.effectColor *= new Color(1, 1, 1, 0);
        }
        else if (outline == buttonSize)
        {
            buttonSize.effectColor += new Color(0, 0, 0, 1);
            buttonPos.effectColor *= new Color(1, 1, 1, 0);
           buttonRot.effectColor *= new Color(1, 1, 1, 0);
        }
        else if (outline == buttonRot)
        {
            buttonRot.effectColor += new Color(0, 0, 0, 1);
            buttonPos.effectColor *= new Color(1, 1, 1, 0);
            buttonSize.effectColor *= new Color(1, 1, 1, 0);
        }
    }
}
//On GameManager
using UnityEngine;
using UnityEngine.UI;

public class ColorForHint : MonoBehaviour
{
    [SerializeField] Mode mode;
    private Image back;
    private Color prevColor;

    enum Mode
    {
        build, edit
    }

    private void Start()
    {
        back = GetComponent<Image>();
        prevColor = back.color;
    }

    private void Update()
    {
        switch (mode)
        {
            case Mode.build:
                if (States.isBuildMode)
                    back.color = new Color(0.6f, 0.6f, 0.6f);
                else back.color = prevColor; break;
            case Mode.edit:
                if (States.isEditMode)
                    back.color = new Color(0.6f, 0.6f, 0.6f);
                else back.color = prevColor; break;
        }
    }
}

using System;
using TMPro;
using UnityEngine;

public class BlockCoordsToInputFields : MonoBehaviour
{
    [SerializeField] TMP_InputField x;
    [SerializeField] TMP_InputField y;
    [SerializeField] TMP_InputField z;
    public bool canChange;

    private void Update()
    {
        switch (States.mode)
        {
            case States.EditModeState.Position:
                PositionCoords();
                break;
            case States.EditModeState.Size:
                SizeCoords();
                break;
            case States.EditModeState.Rotate:
                RotCoords();
                break;

        }
    }

    private void PositionCoords()
    {
        if (!canChange)
        {
            try
            {
                x.text = (States.selectedBlock.transform.position.x).ToString();
                y.text = (States.selectedBlock.transform.position.y).ToString();
                z.text = (States.selectedBlock.transform.position.z).ToString();
            }
            catch { }
        }
        else
        {
            try
            {
                float fX = Convert.ToSingle(x.text);
                float fY = Convert.ToSingle(y.text);
                float fZ = Convert.ToSingle(z.text);
                States.selectedBlock.transform.position = new Vector3(fX, fY, fZ);
            }
            catch { }
        }
    }
    private void SizeCoords()
    {
        if (!canChange)
        {
            try
            {
                x.text = (States.selectedBlock.transform.localScale.x).ToString();
                y.text = (States.selectedBlock.transform.localScale.y).ToString();
                z.text = (States.selectedBlock.transform.localScale.z).ToString();
            }
            catch { }
        }
        else
        {
            try
            {
                float fX = Convert.ToSingle(x.text);
                float fY = Convert.ToSingle(y.text);
                float fZ = Convert.ToSingle(z.text);
                States.selectedBlock.transform.localScale = new Vector3(fX, fY, fZ);
            }
            catch { }
        }
    }
    private void RotCoords()
    {
        if (!canChange)
        {
            try
            {
                x.text = (States.selectedBlock.transform.rotation.x).ToString();
                y.text = (States.selectedBlock.transform.rotation.y).ToString();
                z.text = (States.selectedBlock.transform.rotation.z).ToString();
            }
            catch { }
        }
        else
        {
            try
            {
                float fX = Convert.ToSingle(x.text);
                float fY = Convert.ToSingle(y.text);
                float fZ = Convert.ToSingle(z.text);
                States.selectedBlock.transform.rotation = Quaternion.Euler(fX, fY, fZ);
            }
            catch { }
        }
    }
}

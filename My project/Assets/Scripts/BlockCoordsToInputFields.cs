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
            float fX = Convert.ToSingle(x.text);
            float fY = Convert.ToSingle(y.text);
            float fZ = Convert.ToSingle(z.text);

            States.selectedBlock.transform.position = new Vector3(fX,fY,fZ);
        }
    }
}

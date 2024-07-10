using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowToChangeBlockPos : MonoBehaviour
{
    [SerializeField] BlockCoordsToInputFields script;

    public void Allow()
    {
        script.canChange = true;
    }

    public void NotAllow()
    {
        script.canChange = false;
    }

}

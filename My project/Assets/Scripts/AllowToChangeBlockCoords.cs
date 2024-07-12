using UnityEngine;

public class AllowToChangeBlockCoords : MonoBehaviour
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

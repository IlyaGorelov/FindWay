using UnityEngine;

public class CheckOnStuck : MonoBehaviour
{
    public bool isStacked = false;

    private void OnCollisionEnter(Collision collision)
    {
        isStacked= true;
        print("entered");
    }
}

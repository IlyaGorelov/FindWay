using UnityEngine;

public class HB_CheckCollision : MonoBehaviour
{
    public bool isCollisioned=false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Checkpoint c))
            isCollisioned = true;
    }
}

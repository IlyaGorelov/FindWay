
using UnityEngine;

public class CheckOnStuck : MonoBehaviour
{
    [SerializeField] GameObject parent;
    [SerializeField] LayerMask layerMask;

    public bool isStucked()
    {
        Ray rayForward = new(transform.position, transform.forward);
        Ray rayBack = new(transform.position, -transform.forward);
        Ray rayRight = new(transform.position, transform.right);
        Ray rayLeft = new(transform.position, -transform.right);
        Ray[] rays = { rayBack, rayForward, rayRight, rayLeft };

        foreach (Ray ray in rays)
            if (Physics.Raycast(ray, out RaycastHit hit, 200f, layerMask))
                if (Vector3.Distance(transform.position, hit.point) <= parent.transform.localScale.x / 2)
                    return true;
        return false;
    }
}

using Unity.Mathematics.Geometry;
using UnityEngine;
using System;

public class SizeControl : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        Ray rayForward = new(transform.position, transform.forward);
        Ray rayBack = new(transform.position, -transform.forward);
        Ray rayRight = new(transform.position, transform.right);
        Ray rayLeft = new(transform.position, -transform.right);
        Ray[] rays = { rayForward, rayBack, rayRight, rayLeft };
        RaycastHit[] hits = new RaycastHit[4];
        int raysIsReady = 0;

        foreach (Ray ray in rays)
            if (Physics.Raycast(ray, out RaycastHit hit, 200f, layerMask))
            {
                hits[raysIsReady]=hit;
                raysIsReady++;
            }

        if (raysIsReady == 4)
        {
            if (System.Math.Abs(hits[0].point.x - hits[1].point.x-transform.localScale.x)< 
                System.Math.Abs(hits[2].point.z - hits[3].point.z- transform.localScale.z))
            {
                transform.localScale += new Vector3(1,0,0);
            }
        }

    }
}

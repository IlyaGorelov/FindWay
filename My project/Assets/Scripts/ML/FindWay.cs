using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FindWay : MonoBehaviour
{
    [SerializeField] AgentInfo agentInfo;
    [SerializeField] LayerMask layerMask;
    //  [SerializeField] LayerMask layerMaskDefault;
    [SerializeField] GameObject checkpoint;
    public static bool isWayFinded = false;
    public static int step = 10;
    [SerializeField] GameObject helpBlock;
    static List<GameObject> checkpoints;

    private void Start()
    {
        checkpoints = new List<GameObject>();
        CheckOnOneLine();
    }

    private void Update()
    {

    }

    private void CheckOnOneLine()
    {
        Ray ray = new(transform.position,
            AgentInfo.finishPoint.transform.position - transform.position);
        Debug.DrawRay(transform.position,
            AgentInfo.finishPoint.transform.position - transform.position,
            Color.red, 30f);
        if (Physics.Raycast(ray, out RaycastHit hit, 200f, layerMask))
            if (hit.collider.gameObject.TryGetComponent(out Goal g))
            {
                print("success");
                isWayFinded = true;
            }
            else if (!isWayFinded) CreateRays();


    }

    private void CreateRays()
    {
        Ray rayForward = new(transform.position, transform.forward);
        Ray rayForwardRight = new(transform.position, Quaternion.Euler(0, 45, 0) * transform.forward);
        Ray rayForwardLeft = new(transform.position, Quaternion.Euler(0, -45, 0) * transform.forward);
        Ray rayBack = new(transform.position, -transform.forward);
        Ray rayBackRight = new(transform.position, Quaternion.Euler(0, 45, 0) * -transform.forward);
        Ray rayBackLeft = new(transform.position, Quaternion.Euler(0, -45, 0) * -transform.forward);
        Ray rayRight = new(transform.position, transform.right);
        Ray rayLeft = new(transform.position, -transform.right);
        Ray[] rays = { rayBack, rayForward, rayRight, rayLeft,rayForwardRight,
        rayForwardLeft,rayBackRight,rayBackLeft};

        foreach (Ray ray in rays)
            if (Physics.Raycast(ray, out RaycastHit hit, 200f, layerMask))
            {
                //GameObject hb = Instantiate(helpBlock, transform.position, Quaternion.identity);
                //while (!hb.GetComponentInChildren<HB_CheckCollision>().isCollisioned)
                //{
                //    Vector3 dir = (hb.transform.position - hit.point).normalized;
                //    hb.transform.position += dir;
                //}
                if (checkpoints.Count < 2)
                {
                    if (!hit.collider.TryGetComponent(out Checkpoint c))
                    {
                        GameObject cp = Instantiate(checkpoint, hit.point, Quaternion.identity);
                        checkpoints.Add(cp);
                        cp.transform.LookAt(transform);
                        Vector3 rightAngle = new Vector3(0, -90, 0);
                        cp.transform.Rotate(rightAngle);
                    }
                }
                else
                {
                    Destroy(checkpoints[1]);
                    checkpoints.Remove(checkpoints[1]);
                    GameObject cp = Instantiate(checkpoint, hit.point, Quaternion.identity);
                    checkpoints.Add(cp);
                    cp.transform.LookAt(transform);
                    Vector3 rightAngle = new Vector3(0, -90, 0);
                    cp.transform.Rotate(rightAngle);
                }
            }
    }
}

using UnityEngine;

public class FindWay : MonoBehaviour
{
    [SerializeField] AgentInfo agentInfo;
    [SerializeField] LayerMask layerMask;

    private void Start()
    {
        CheckOnOneLine();
    }

    private void CheckOnOneLine()
    {
        Ray ray = new(transform.position, 
            agentInfo.finishPoint.transform.position-transform.position);
        Debug.DrawRay(transform.position,
            agentInfo.finishPoint.transform.position - transform.position,
            Color.red,100f);
        if (Physics.Raycast(ray, 200f, layerMask)) print("success");

    }
}

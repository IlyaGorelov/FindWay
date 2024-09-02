using UnityEngine;
public class MoveToTargetAgent : MonoBehaviour
{
    private Transform finish;
    private Transform start;
    private CheckOnStuck check;
    [SerializeField] LearningManager learningManager;
    int idOfFin = 0;
    [SerializeField] LayerMask layerMask;
    [SerializeField] GameObject hitPoint;

    private void Start()
    {
        check = GetComponentInChildren<CheckOnStuck>();
        AgentInfo agentInfo = GetComponent<AgentInfo>();
        do
        {
            //finish = agentInfo.finishPoint;
            learningManager.DeactivateFinishes();
            learningManager.finishes[idOfFin].SetActive(true);
            finish = learningManager.finishes[idOfFin].transform;
            start = agentInfo.startPoint;
        } while (agentInfo == null);
        FindWay();
    }

    private void FindWay()
    {
        CreateHits();
    }

    private void CreateHits()
    {
        Ray rayForward = new(transform.position, transform.forward);
        Ray rayBack = new(transform.position, -transform.forward);
        Ray rayRight = new(transform.position, transform.right);
        Ray rayLeft = new(transform.position, -transform.right);
        Ray[] rays = { rayBack, rayForward, rayRight, rayLeft };

        foreach (Ray ray in rays)
            if (Physics.Raycast(ray, out RaycastHit hit, 200f, layerMask))
                Instantiate(hitPoint, hit.point, Quaternion.identity);
    }
}

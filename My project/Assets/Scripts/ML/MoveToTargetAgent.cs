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
    }


}

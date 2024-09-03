using UnityEngine;

public class AgentInfo : MonoBehaviour
{
    public Transform startPoint;
    public static Transform finishPoint;
    [SerializeField] Transform testFinish;

    private void Awake()
    {
        finishPoint = testFinish;
    }

}

using UnityEngine;

public class AgentInfo : MonoBehaviour
{
    public Transform startPoint;
    public Transform finishPoint;

    private void Awake()
    {
        startPoint = gameObject.transform;
    }
}

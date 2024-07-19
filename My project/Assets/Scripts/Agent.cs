using UnityEngine;

public class Agent : MonoBehaviour
{
    public Transform startPoint;
    public Transform finishPoint;

    private void Awake()
    {
        startPoint = gameObject.transform;
    }
}

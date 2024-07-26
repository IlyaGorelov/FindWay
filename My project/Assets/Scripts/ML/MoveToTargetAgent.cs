using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToTargetAgent : Agent
{
    private Transform finish;
    private Transform start;


    private void Start()
    {
        AgentInfo agentInfo = GetComponent<AgentInfo>();
        do
        {
            finish = agentInfo.finishPoint;
            start = agentInfo.startPoint;
        } while (agentInfo == null);
    }

    public override void OnEpisodeBegin()
    {
        transform.position = start.position;
        transform.position += new Vector3(0, 2, 0);
        print("start");
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.position);
        sensor.AddObservation(finish.position);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];
        float speed = 10f;

        transform.position += new Vector3(moveX, 0, moveZ) * Time.deltaTime * speed;
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Goal goal))
        {
            SetReward(1f);
            EndEpisode();
        }
    }


}

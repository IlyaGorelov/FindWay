using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Google.Protobuf.WellKnownTypes;
using System.Linq;
using System;

public class MoveToTargetAgent : Agent
{
    private Transform finish;
    private Transform start;
    private CheckOnStuck check;
    [SerializeField] LearningManager learningManager;
    int idOfFin = 0;

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

    public override void OnEpisodeBegin()
    {
        transform.localPosition = start.localPosition;
        transform.localPosition += new Vector3(0, 2, 0);
        print("ep_begin");
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(finish.localPosition);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];
        float speed = 5f;

        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * speed;
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
            SetReward(5f);
            print("success");
            //finish.position = new Vector3(100, 100, 1000);
            learningManager.finishes[idOfFin].SetActive(false);
            idOfFin += 1;
            learningManager.finishes[idOfFin].SetActive(true);
            finish = learningManager.finishes[idOfFin].transform;
            EndEpisode();
        }
    }

    private void Update()
    {
        if (!isGrounded())
        {
            SetReward(-2f);
            EndEpisode();
            print("not grounded");
        }
        if (check.isStucked())
        {
            SetReward(-2f);
            print("stuck");
            EndEpisode();
        }
    }

    private bool isGrounded()
    {
        bool hit = Physics.Raycast(transform.position, -transform.up, 200f);
        return hit;
    }

    
}

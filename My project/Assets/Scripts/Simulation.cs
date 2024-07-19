using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    [SerializeField] CreateBlocks createBlocks;
    [SerializeField] GameObject agentPrefab;
    private Transform finishBeforePrefab;

    private List<GameObject> agents = new List<GameObject>();

    public void StartSimulation()
    {
        foreach (var block in createBlocks.blocks)
        {
            if (block.layer == 7)
            {
                var newAgent = Instantiate(agentPrefab, block.transform.position, Quaternion.identity);
                agents.Add(newAgent);
            }
            if (block.layer == 8)
            {
                finishBeforePrefab = block.transform;
            }
        }

        foreach (var agent in agents)
        {
            Agent agent1 = agent.GetComponent<Agent>();
            agent1.finishPoint = finishBeforePrefab;
        }
    }
}
// On GameManager
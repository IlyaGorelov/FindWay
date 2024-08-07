using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{
    public GameObject block;
    [SerializeField] GameObject camera;
    public List<GameObject> blocks = new List<GameObject>();

    private void Update()
    {
        if (States.isBuildMode) Spawn();

        DeleteZ();
    }

    private void Spawn()
    {
        Ray ray = new(transform.position, camera.transform.forward);
        Debug.DrawRay(transform.position, camera.transform.forward, Color.yellow);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 spawn = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                var buildedBlock = Instantiate(block, spawn , block.transform.rotation);
                blocks.Add(buildedBlock);
            }
        }
    }//Spawn block on view direction

    private void DeleteZ()
    {
        // if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Z)) 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            try
            {
                blocks[^1].SetActive(false);
                blocks.Remove(blocks[blocks.Count - 1]);
            }
            catch
            {
                print("Error");
            }
        }
    }//Delete previous block with Z-key

    //On FirstPersonController
}

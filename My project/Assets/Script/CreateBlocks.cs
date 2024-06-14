using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] GameObject camera;
    private bool isBuildMode = false;
    private List<GameObject> blocks = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isBuildMode == false) isBuildMode = true;
            else isBuildMode = false;
        }

        if (isBuildMode) Spawn();

        DeleteZ();
    }

    private void Spawn()
    {
        Ray ray = new(transform.position, camera.transform.forward);
        Debug.DrawRay(transform.position, camera.transform.forward, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 spawn = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                var buildedBlock = Instantiate(block, spawn, Quaternion.identity);
                blocks.Add(buildedBlock);
            }
        }
    }

    private void DeleteZ()
    {
        // if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Z)) 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            try
            {
                blocks[blocks.Count - 1].SetActive(false);
                blocks.Remove(blocks[blocks.Count - 1]);
            }
            catch
            {
                print("Error");
            }
        }
    }
}

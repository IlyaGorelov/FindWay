using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField] private GameObject options;
    private bool optionsActivated = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!optionsActivated) options.SetActive(true);
            else Close();
        }


        if (options.activeSelf)
        {
            optionsActivated = true;
            States.isPaused = true;
        }
        else { optionsActivated = false;
            States.isPaused = false;
        }
    }

    public void Close() => options.SetActive(false);
 
}

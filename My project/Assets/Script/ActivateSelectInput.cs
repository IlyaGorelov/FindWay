using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSelectInput : MonoBehaviour
{
    [SerializeField] GameObject gameObject;


    private void Update()
    {
        if (States.isSelectMode)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

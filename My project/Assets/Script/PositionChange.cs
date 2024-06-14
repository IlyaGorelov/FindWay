using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChange : MonoBehaviour
{
    private bool isSelected = false;
    [SerializeField] private GameObject arrows;


    public void BecomeSelected() { isSelected = true;}
    public void Deselect () { isSelected = false; }

    private void Update()
    {
        if(isSelected) arrows.SetActive(true);
        else arrows.SetActive(false);
    }
}

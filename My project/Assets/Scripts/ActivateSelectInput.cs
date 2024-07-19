using UnityEngine;

public class ActivateSelectInput : MonoBehaviour
{
    [SerializeField] GameObject selectInputObject;

    private void Update()
    {
        if (States.isEditMode)
        {
            selectInputObject.SetActive(true);
        }
        else
        {
            selectInputObject.SetActive(false);
        }
    }
    //On GameManager
    //Activate SelectModeInput
}

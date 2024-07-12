using UnityEngine;

public class ActivateSelectInput : MonoBehaviour
{
    [SerializeField] GameObject gameObject;

    private void Update()
    {
        if (States.isEditMode)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    //On GameManager
    //Activate SelectModeInput
}

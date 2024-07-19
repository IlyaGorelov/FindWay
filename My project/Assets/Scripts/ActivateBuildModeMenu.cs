using UnityEngine;

public class ActivateBuildModeMenu : MonoBehaviour
{
    [SerializeField] private GameObject buildMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (States.isBuildMode == false) States.isBuildMode = true;
            else States.isBuildMode = false;
        }
        if(States.isBuildMode) buildMenu.SetActive(true);
        else buildMenu.SetActive(false);
    }
}
//On GameManager

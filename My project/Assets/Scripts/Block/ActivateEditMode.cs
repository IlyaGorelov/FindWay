using UnityEngine;

public class ActivateEditMode : MonoBehaviour
{
    public bool isSelected = false;
    [SerializeField] GameObject inline;
    [SerializeField] GameObject inline2;

    public void BecomeSelected()
    {
        isSelected = true;
        GameObject go = GameObject.Find("FirstPersonController");
        RotateToSelectedBlock rotateTo = go.GetComponent<RotateToSelectedBlock>();
        rotateTo.selected = gameObject;
        inline2.SetActive(true);
        States.selectedBlock = gameObject;
    }
    public void Deselect()
    {
        isSelected = false;
        GameObject go = GameObject.Find("FirstPersonController");
        RotateToSelectedBlock rotateTo = go.GetComponent<RotateToSelectedBlock>();
        rotateTo.selected = null;
        inline2.SetActive(false);
    }

    private void Delete()
    {
        GameObject go = GameObject.Find("FirstPersonController");
        CreateBlocks createBlocks = go.GetComponent<CreateBlocks>();
        createBlocks.blocks.Remove(gameObject);
        Deselect();
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (!States.isSelectMode)
        {
            Deselect();
        }
        if (Input.GetKeyDown(KeyCode.Delete) && isSelected) Delete();
    }

    private void OnMouseEnter()
    {
        if (States.isSelectMode)
            inline.SetActive(true);
        
    }
    private void OnMouseExit()
    {
        inline.SetActive(false);
    }

    //On Block Prefab
}

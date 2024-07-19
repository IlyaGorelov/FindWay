using UnityEngine;

public class SelectObjectToCreate : MonoBehaviour
{
    [SerializeField] GameObject outlineBlock;
    [SerializeField] GameObject outlineSpawn;
    [SerializeField] GameObject outlineFinish;
    [SerializeField] CreateBlocks createBlocks;
    [SerializeField] GameObject block;
    [SerializeField] GameObject spawn;
    [SerializeField] GameObject finish;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1)|| Input.GetKeyDown(KeyCode.Alpha1))
            SetBlock();
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) 
            SetSpawn();
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
            SetFinish();
    }

    public void SetBlock()
    {
        outlineBlock.SetActive(true);
        outlineSpawn.SetActive(false);
        outlineFinish.SetActive(false);
        createBlocks.block = block;
    }

    public void SetSpawn()
    {
        outlineSpawn.SetActive(true);
        outlineFinish.SetActive(false);
        outlineBlock.SetActive(false);
        createBlocks.block = spawn;
    }

    public void SetFinish()
    {
        outlineFinish.SetActive(true);
        outlineSpawn.SetActive(false);
        outlineBlock.SetActive(false);
        createBlocks.block = finish;
    }
}
//On BuildModeCanvas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CubeCheck : MonoBehaviour
{
    public bool redCube;
    public bool blueCube;
    public bool greenCube;
    // Start is called before the first frame update
   public void SelectCube(SelectEnterEventArgs args)
    { 
        if (args.interactable.gameObject.tag == "RedCube")
        {
            redCube = true;
        }
        if (args.interactable.gameObject.tag == "BlueCube")
        {
            blueCube = true;
        }
        if (args.interactable.gameObject.tag == "GreenCube")
        {
            greenCube = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (redCube && blueCube && greenCube)
        {
            Application.Quit();
        }
    }
}

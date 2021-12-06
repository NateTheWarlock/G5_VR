using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleSingleObject : MonoBehaviour
{
    public Vector3 targetBigScale = Vector3.one;
    public Vector3 targetSmallScale = Vector3.one;
    private Vector3 originalScale = Vector3.one;
    //public GameObject grabbedObject;
    public GameObject grabbedObject;
    public int sizeUses;
    public static int timesScaled = 0;
    public void HoverTarget(HoverEnterEventArgs args)
    { 
        if (args.interactable.gameObject.tag == "Target")
        {
            grabbedObject = args.interactable.gameObject;
        }
    }
    public void ApplyTargetBigScale()
    { 
        
        if (sizeUses > 0 & grabbedObject.transform.localScale != targetBigScale)
        {
            originalScale = transform.localScale;
            grabbedObject.transform.localScale = targetBigScale;
            sizeUses --;
            timesScaled ++;
        }
    }

    public void ResetScale()
    {
        
        grabbedObject.transform.localScale = originalScale;
        originalScale = Vector3.one;
    }
    public void ApplyTargetSmallScale()
    {
        
        if (sizeUses > 0 & grabbedObject.transform.localScale != targetSmallScale)
        {
            originalScale = transform.localScale;
            grabbedObject.transform.localScale = targetSmallScale;
            sizeUses --;
            timesScaled ++;
        }   
    }
}

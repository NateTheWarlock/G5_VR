using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleObject : MonoBehaviour
{
    public Vector3 targetScale = Vector3.one;
    private Vector3 originalScale = Vector3.one;
    public GameObject worldPosition;
    public GameObject others;
    public GameObject playerPosition;

    public void ApplyTargetScale()
    {
        others.transform.SetParent(playerPosition.transform);
        worldPosition.transform.position=playerPosition.transform.position;
        others.transform.SetParent(worldPosition.transform);
        originalScale = transform.localScale;
        worldPosition.transform.localScale = targetScale;
        // transform.localScale = targetScale;
    }

    public void ResetScale()
    {
        others.transform.SetParent(playerPosition.transform);
        worldPosition.transform.position=playerPosition.transform.position;
        others.transform.SetParent(worldPosition.transform);
        worldPosition.transform.localScale = originalScale;
        originalScale = Vector3.one;
    }
}

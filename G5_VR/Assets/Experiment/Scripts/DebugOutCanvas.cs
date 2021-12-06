using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugOutCanvas : MonoBehaviour
{
    public static DebugOutCanvas instance;
    public TextMeshProUGUI timeInstance;
    public TextMeshProUGUI angleInstance;
    public TextMeshProUGUI trialInstance;
    // Start is called before the first frame update
    void Start()
    {
        if (DebugOutCanvas.instance == null)
        {
            instance = this;
        }
    }


}

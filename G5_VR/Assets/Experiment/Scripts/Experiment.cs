using UnityEngine;
using UnityEngine.Events;

public struct Experiment
{
    public string name;
    public int trials;
    [Tooltip("The size of the volume where the experiment will spawn")]
    public Vector3 Bounds;
    public GameObject targetObject;
    public UnityEvent onStartTrial;
    public UnityEvent onEndTrial;
}
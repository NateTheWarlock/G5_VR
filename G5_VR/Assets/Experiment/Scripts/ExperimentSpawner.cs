
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Spawn an object at a transform's position
/// </summary>
public class ExperimentSpawner : MonoBehaviour
{
    public bool started = false;
    System.DateTime startTime;
    public DebugOutCanvas debugOutCanvas;
    public List<DataPoint> dataPoints = new List<DataPoint>();
    public class DataPoint
    {
        public int participantId;
        public string cubeId;
        public float timeSinceLoad;
        public float shrinkGrow;
        public DataPoint(int id, string cubeId, float timeSinceLoad, int shrinkGrow)
        {
            this.participantId = id;
            this.cubeId = cubeId;
            this.timeSinceLoad = timeSinceLoad;
            this.shrinkGrow = shrinkGrow;
        }
    }
    public void StopTimer(SelectEnterEventArgs args)
    {

       
        DataPoint dp = new DataPoint(1, args.interactable.gameObject.name, Time.time, ScaleSingleObject.timesScaled);
        dataPoints.Add(dp);
     var filename = Application.dataPath.ToString() +
            Path.DirectorySeparatorChar + "data" + Path.DirectorySeparatorChar + "output.csv";
            Sinbad.CsvUtil.SaveObjects(dataPoints, filename);
            Debug.Log("Done");
    }
}

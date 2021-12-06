using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using static ExperimentSpawner;
using System.IO;

public class WriteToCSV : MonoBehaviour {
    public static List<DataPoint> data;
    public static WriteToCSV instance;
    public string filename = "output.csv";
    public void Start()
    {
        instance = this;
    }
    public void CollectData()
    {

    }
    public void Write()
    {
        var filenameFull = Application.dataPath.ToString() +
    Path.DirectorySeparatorChar + "data" + Path.DirectorySeparatorChar + filename;
        Sinbad.CsvUtil.SaveObjects(data, filenameFull);
    }
}
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

public class JSONDemo : MonoBehaviour {


    string path;
    string jsonString;

    // Use this for initialization
    void Start() {
        path = Application.streamingAssetsPath + "/data.json";
        jsonString = File.ReadAllText(path);

        var selectedObject = JsonConvert.DeserializeObject<List<JSONData>>(jsonString);
        //Debug.Log(getDescritionByName(selectedObject));
    }

    public string getDescritionByName(List<JSONData> dataList) {
        foreach (var data in dataList) {
            if (data.Name.Equals(gameObject.name)) {
                return data.Description;
            }
        }
        return "";
    }
}

public class JSONData {
    public string Name { get; set; }
    public string Description { get; set; }
}

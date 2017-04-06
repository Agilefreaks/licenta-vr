using UnityEngine;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


public class JsonLoader : MonoBehaviour
{

    private string _path;

    public List<ObjectModel> ObjectModelList = new List<ObjectModel>();
    // Use this for initialization
    void Start()
    {
        _path = Application.streamingAssetsPath + "/data.json";
        var json = File.ReadAllText(_path);
        ObjectModelList = JsonConvert.DeserializeObject<List<ObjectModel>>(json);
        Debug.Log(ObjectModelList[0].Name);
    }

    public ObjectModel GetCurrentObjectDetails()
    {
        foreach (var model in ObjectModelList)
        {
            if (model.Name.Contains(gameObject.name))
            {
                return model;
            }
        }

        return null;
    }

    public ObjectModel GetObjectDetails(string name)
    {
        Debug.Log(name);
        foreach (var model in ObjectModelList)
        {
            Debug.Log(model.Name);
            if (model.Name.Equals(name))
            {
                return model;
            }
        }
        Debug.Log(name);
        return null;
    }

}

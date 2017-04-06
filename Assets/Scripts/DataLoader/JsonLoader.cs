using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
    }

    public ObjectModel GetCurrentObjectDetails()
    {
        return ObjectModelList.FirstOrDefault(model => model.Name.Contains(gameObject.name));
    }

    public ObjectModel GetObjectDetails(string name)
    {
        return ObjectModelList.FirstOrDefault(model => model.Name.Equals(name));
    }

}

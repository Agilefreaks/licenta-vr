using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionLoader : MonoBehaviour {

    private JsonLoader _jsonLoader;

    public Text Name;
    public Text Description;    

    // Use this for initialization
    void Start () {
        _jsonLoader = GetComponent<JsonLoader>();
       /*
        var model = _jsonLoader.GetObjectDetails("Directional Light");
        Name.text = model.Name;
        Description.text = model.Description;*/
    }
}

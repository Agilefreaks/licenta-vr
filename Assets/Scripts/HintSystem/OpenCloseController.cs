using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Hover.Core.Utils;

public class OpenCloseController : MonoBehaviour {

    private LineRenderer _lineRenderer;

    public Transform TargetObject;

    void Start()
    {
        _lineRenderer = gameObject.GetComponentInChildren<LineRenderer>();        
    }

    public void OnHintOpen()
    {
        if (!_lineRenderer.enabled) _lineRenderer.enabled = true;
        if (!TargetObject.gameObject.activeSelf) TargetObject.gameObject.SetActive(true);
        if (TargetObject.parent != null) TargetObject.parent = null;
    }

    public void OnHintClose()
    {
        if (_lineRenderer.enabled) _lineRenderer.enabled = false;
        if (TargetObject.gameObject.activeSelf) TargetObject.gameObject.SetActive(false);
        if (TargetObject.parent == null) TargetObject.parent = gameObject.transform;
    }
   
}

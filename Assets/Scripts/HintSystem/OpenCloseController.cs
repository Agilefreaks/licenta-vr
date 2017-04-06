using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseController : MonoBehaviour {

    private LineRenderer _lineRenderer;

    public Transform TargetObject;

    public SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;

    void Start()
    {
        _lineRenderer = gameObject.GetComponentInChildren<LineRenderer>();
        // = GetComponent<SteamVR_TrackedObject>();

    }

    public void OnHintOpen()
    {
        if (!_lineRenderer.enabled) _lineRenderer.enabled = true;
        if (!TargetObject.gameObject.activeSelf) TargetObject.gameObject.SetActive(true);
        if (TargetObject.parent != null) TargetObject.parent = null;
    }

    public void OnHintClose()
    {
        if (!_lineRenderer.enabled) _lineRenderer.enabled = false;
        if (!TargetObject.gameObject.activeSelf) TargetObject.gameObject.SetActive(false);
        if (TargetObject.parent != null) TargetObject.parent = gameObject.transform;
    }

    private void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            OnHintOpen();            
        }
    }
}

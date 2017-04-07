using UnityEngine;

namespace HintSystem
{
    public class ShowHintWindow : MonoBehaviour
    {

        private LineRenderer _lineRenderer;
        private Transform _cameraLocation;

        public Transform TargetObject;

        // Use this for initialization
        void Start()
        {
            _lineRenderer = gameObject.GetComponentInChildren<LineRenderer>();
            _cameraLocation = Camera.main.gameObject.transform;        
        }

        // Update is called once per frame
        void Update()
        {
            if (_lineRenderer == null) return;

            _lineRenderer.SetPosition(0, gameObject.transform.position);
            _lineRenderer.SetPosition(1, TargetObject.transform.position);
        
            TargetObject.position = new Vector3(_cameraLocation.position.x, _cameraLocation.position.y - 0.3f, _cameraLocation.position.z + 0.5f);
            TargetObject.eulerAngles = new Vector3(60, 0);
        }
    }
}

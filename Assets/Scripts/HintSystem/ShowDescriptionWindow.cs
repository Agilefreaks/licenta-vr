using UnityEngine;

namespace Prefabs.HintSystem
{
    public class ShowDescriptionWindow : MonoBehaviour {

        private LineRenderer _lineRenderer;
        private Transform _cameraLocation;

        public Transform TargetObject;

        // Use this for initialization
        void Start () {
            _lineRenderer = gameObject.GetComponentInChildren<LineRenderer>();
            _cameraLocation = Camera.main.gameObject.transform;
        }
	
        // Update is called once per frame
        void Update () {
            if(_lineRenderer == null) return;
            if (!TargetObject.gameObject.activeSelf)
            {
                _lineRenderer.SetPosition(2, _lineRenderer.GetPosition(1));
            }
            else
            {
                _lineRenderer.SetPosition(2, TargetObject.transform.position);

                TargetObject.position = new Vector3(_cameraLocation.position.x - 0.2f, _cameraLocation.position.y - 0.3f, _cameraLocation.position.z + 0.7f);
                TargetObject.eulerAngles = new Vector3(0, -50);
            }
        }
    }
}

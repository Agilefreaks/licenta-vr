using UnityEngine;

namespace HintSystem
{
    public class OpenCloseController : MonoBehaviour {

        private LineRenderer _lineRenderer;

        public Transform HintTransform;
        public Transform DescriptionTransform;

        void Start()
        {
            _lineRenderer = gameObject.GetComponentInChildren<LineRenderer>();        
        }

        public void OnHintOpen()
        {
            if (!_lineRenderer.enabled) _lineRenderer.enabled = true;
            if (!HintTransform.gameObject.activeSelf) HintTransform.gameObject.SetActive(true);
            if (HintTransform.parent != null) HintTransform.parent = null;
        }

        public void OnHintClose()
        {
            if (_lineRenderer.enabled) _lineRenderer.enabled = false;
            if (HintTransform.gameObject.activeSelf) HintTransform.gameObject.SetActive(false);
            if (HintTransform.parent == null) HintTransform.parent = gameObject.transform;
        }

        public void OnDescriptionOpen()
        {
            if (!DescriptionTransform.gameObject.activeSelf) DescriptionTransform.gameObject.SetActive(true);
            if (DescriptionTransform.parent != null) DescriptionTransform.parent = null;
        }

        public void OnDescriptionClose()
        {
            if (DescriptionTransform.gameObject.activeSelf) DescriptionTransform.gameObject.SetActive(false);
            if (DescriptionTransform.parent == null) DescriptionTransform.parent = gameObject.transform;
        }
    }
}

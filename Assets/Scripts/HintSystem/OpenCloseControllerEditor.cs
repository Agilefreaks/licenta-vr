using UnityEditor;
using UnityEngine;

namespace HintSystem
{
    [CustomEditor(typeof(OpenCloseController))]
    public class OpenCloseControllerEditor : Editor {

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            OpenCloseController myScript = (OpenCloseController)target;
            if (GUILayout.Button("Open Hint"))
            {
                myScript.OnHintOpen();
            }

            if (GUILayout.Button("Close Hint"))
            {
                myScript.OnHintClose();
            }
        }
    }
}

using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

namespace LLib.Extensions
{
    [CustomEditor(typeof(Image), true)]
    [CanEditMultipleObjects]
    public class ImageExtensionsEditor : ImageEditor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            bool canNativePivot = true;
            foreach (Object t in targets)
            {
                Image image = t as Image;
                bool valid = image.sprite != null
                             && (image.type == Image.Type.Simple || image.type == Image.Type.Tiled || image.type == Image.Type.Filled);

                if (!valid)
                {
                    canNativePivot = false;
                    break;
                }
            }

            if (!canNativePivot)
                return;

            GUILayout.BeginHorizontal();
            GUILayout.Space(EditorGUIUtility.labelWidth);

            if (GUILayout.Button("Set Native Pivot"))
            {
                foreach (Object t in targets)
                {
                    Image image = t as Image;
                    Undo.RecordObject(image.rectTransform, "Set Native Pivot");
                    image.SetNativePivot();
                    EditorUtility.SetDirty(image.rectTransform);
                }
            }

            GUILayout.EndHorizontal();
        }
    }
}



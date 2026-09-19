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

            bool canSetNativePivot = true;
            foreach (Object t in targets)
            {
                Image image = t as Image;
                bool valid = image.sprite != null
                             && (image.type == Image.Type.Simple || image.type == Image.Type.Tiled || image.type == Image.Type.Filled);

                if (!valid)
                {
                    canSetNativePivot = false;
                    break;
                }
            }

            if (!canSetNativePivot)
                return;

            EditorGUILayout.Space();

            if (GUILayout.Button("Set Native Transform"))
            {
                foreach (Object t in targets)
                {
                    Image image = t as Image;
                    Undo.RecordObject(image.rectTransform, "Set Native Transform");
                    image.SetNativeTransform();
                    EditorUtility.SetDirty(image.rectTransform);
                }
            }
        }
    }
}



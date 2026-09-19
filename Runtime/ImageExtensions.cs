using UnityEngine;
using UnityEngine.UI;

namespace LLib.Extensions
{
    public static class ImageExtensions
    {
        public static void SetNativeTransform(this Image image)
        {
            if (image == null)
                return;

            Sprite sprite = image.sprite;
            if (sprite == null)
                return;

            bool validType = image.type == Image.Type.Simple
                             || image.type == Image.Type.Tiled
                             || image.type == Image.Type.Filled;

            if (!validType)
                return;

            RectTransform rectTransform = image.rectTransform;
            Vector2 normalizedPivot = new Vector2(
                sprite.pivot.x / sprite.rect.width,
                sprite.pivot.y / sprite.rect.height
            );

            rectTransform.SetPivotPreservingPosition(normalizedPivot);
            image.SetNativeSize();
            rectTransform.anchoredPosition = Vector3.zero;
        }

        private static void SetPivotPreservingPosition(this RectTransform rectTransform, Vector2 pivot)
        {
            Vector2 size = rectTransform.rect.size;
            Vector2 deltaPivot = rectTransform.pivot - pivot;
            Vector3 deltaPosition = new Vector3(
                deltaPivot.x * size.x * rectTransform.localScale.x,
                deltaPivot.y * size.y * rectTransform.localScale.y,
                0f
            );

            rectTransform.pivot = pivot;
            rectTransform.localPosition -= deltaPosition;
        }
    }
}

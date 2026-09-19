using UnityEngine;
using UnityEngine.UI;

namespace LLib.Extensions
{
    public static class ImageExtensions
    {
        public static void SetNativePivot(this Image image)
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

            Vector2 normalizedPivot = new Vector2(
                sprite.pivot.x / sprite.rect.width,
                sprite.pivot.y / sprite.rect.height
            );

            image.rectTransform.pivot = normalizedPivot;
        }
    }
}

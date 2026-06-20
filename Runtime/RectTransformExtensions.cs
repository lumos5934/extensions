using UnityEngine;

namespace LLib.Extensions
{
    public static class RectTransformExtensions
    {
        /// <summary>
        /// width만 변경합니다
        /// </summary>
        public static void SetWidth(this RectTransform rt, float width)
        {
            rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);
        }

        /// <summary>
        /// height만 변경합니다
        /// </summary>
        public static void SetHeight(this RectTransform rt, float height)
        {
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, height);
        }


        /// <summary>
        /// X anchoredPosition만 변경합니다
        /// </summary>
        public static void SetAnchoredX(this RectTransform rt, float x)
        {
            var p = rt.anchoredPosition;
            p.x = x;
            rt.anchoredPosition = p;
        }

        /// <summary>
        /// Y anchoredPosition만 변경합니다
        /// </summary>
        public static void SetAnchoredY(this RectTransform rt, float y)
        {
            var p = rt.anchoredPosition;
            p.y = y;
            rt.anchoredPosition = p;
        }



        /// <summary>
        /// 위치 / 회전 / 스케일을 기본값으로 초기화합니다
        /// </summary>
        public static void Reset(this RectTransform rt)
        {
            rt.anchoredPosition = Vector2.zero;
            rt.localRotation = Quaternion.identity;
            rt.localScale = Vector3.one;
        }
    }
}


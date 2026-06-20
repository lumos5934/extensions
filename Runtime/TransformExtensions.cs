using System.Collections.Generic;
using UnityEngine;

namespace LLib.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// X 월드 위치만 변경합니다
        /// </summary>
        public static void SetPositionX(this Transform t, float x)
        {
            var p = t.position;
            p.x = x;
            t.position = p;
        }

        /// <summary>
        /// Y 월드 위치만 변경합니다
        /// </summary>
        public static void SetPositionY(this Transform t, float y)
        {
            var p = t.position;
            p.y = y;
            t.position = p;
        }

        /// <summary>
        /// Z 월드 위치만 변경합니다 
        /// </summary>
        public static void SetPositionZ(this Transform t, float z)
        {
            var p = t.position;
            p.z = z;
            t.position = p;
        }

        /// <summary>
        /// X 로컬 위치만 변경합니다
        /// </summary>
        public static void SetLocalPositionX(this Transform t, float x)
        {
            var p = t.position;
            p.x = x;
            t.position = p;
        }

        /// <summary>
        /// Y 로컬 위치만 변경합니다
        /// </summary>
        public static void SetLocalPositionY(this Transform t, float y)
        {
            var p = t.position;
            p.y = y;
            t.position = p;
        }

        /// <summary>
        /// Z 로컬 위치만 변경합니다
        /// </summary>
        public static void SetLocalPositionZ(this Transform t, float z)
        {
            var p = t.position;
            p.z = z;
            t.position = p;
        }
        

        /// <summary>
        /// X 회전값만 변경합니다
        /// </summary>
        public static void SetEulerX(this Transform t, float x)
        {
            var e = t.eulerAngles;
            e.x = x;
            t.eulerAngles = e;
        }

        /// <summary>
        /// Y 회전값만 변경합니다
        /// </summary>
        public static void SetEulerY(this Transform t, float y)
        {
            var e = t.eulerAngles;
            e.y = y;
            t.eulerAngles = e;
        }

        /// <summary>
        /// Z 회전값만 변경합니다
        /// </summary>
        public static void SetEulerZ(this Transform t, float z)
        {
            var e = t.eulerAngles;
            e.z = z;
            t.eulerAngles = e;
        }

        

        /// <summary>
        /// X 스케일만 변경합니다
        /// </summary>
        public static void SetScaleX(this Transform t, float x)
        {
            var s = t.localScale;
            s.x = x;
            t.localScale = s;
        }

        /// <summary>
        /// Y 스케일만 변경합니다
        /// </summary>
        public static void SetScaleY(this Transform t, float y)
        {
            var s = t.localScale;
            s.y = y;
            t.localScale = s;
        }

        /// <summary>
        /// Z 스케일만 변경합니다
        /// </summary>
        public static void SetScaleZ(this Transform t, float z)
        {
            var s = t.localScale;
            s.z = z;
            t.localScale = s;
        }


        
        /// <summary>
        /// 위치 / 회전 / 스케일을 기본값으로 초기화합니다
        /// </summary>
        public static void Reset(this Transform t)
        {
            t.localPosition = Vector3.zero;
            t.localRotation = Quaternion.identity;
            t.localScale = Vector3.one;
        }
        
        /// <summary>
        /// 2D 평면에서 target을 바라보도록 Z축 회전을 설정합니다
        /// </summary>
        public static void LookAt2D(this Transform t, Vector3 target)
        {
            Vector3 dir = target - t.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            t.rotation = Quaternion.Euler(0, 0, angle);
        }
        
        

        /// <summary>
        /// 모든 자식 Transform을 IEnumerable로 순회할 수 있게 반환합니다
        /// </summary>
        public static IEnumerable<Transform> GetChildren(this Transform t)
        {
            for (int i = 0; i < t.childCount; i++)
            {
                yield return t.GetChild(i);
            }
        }
    }
}


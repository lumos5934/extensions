using UnityEngine;

namespace LLib.Extensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// X 값 변경
        /// </summary>
        public static Vector2 WithX(this Vector2 vector, float x)
        {
            vector.x = x;
            return vector;
        }

        /// <summary>
        /// Y 값 변경
        /// </summary>
        public static Vector2 WithY(this Vector2 vector, float y)
        {
            vector.y = y;
            return vector;
        }

        /// <summary>
        /// X 값 추가
        /// </summary>
        public static Vector2 AddX(this Vector2 vector, float value)
        {
            vector.x += value;
            return vector;
        }

        /// <summary>
        /// Y 값 추가
        /// </summary>
        public static Vector2 AddY(this Vector2 vector, float value)
        {
            vector.y += value;
            return vector;
        }

        /// <summary>
        /// 두 위치 사이 정규화 된 방향
        /// </summary>
        public static Vector2 DirectionTo(this Vector2 from, Vector2 target)
        {
            return (target - from).normalized;
        }

        /// <summary>
        /// 일정 거리 이내인지 체크
        /// </summary>
        public static bool IsNear(this Vector2 vector, Vector2 target, float distance)
        {
            return (vector - target).sqrMagnitude <= distance * distance;
        }

        /// <summary>
        /// 거리 제곱 반환
        /// </summary>
        public static float DistanceSqr(this Vector2 a, Vector2 b)
        {
            return (a - b).sqrMagnitude;
        }

        /// <summary>
        /// Vector2 → Vector3 변환
        /// </summary>
        public static Vector3 ToVector3(this Vector2 vector, float y = 0)
        {
            return new Vector3(vector.x, y, vector.y);
        }
    }
}

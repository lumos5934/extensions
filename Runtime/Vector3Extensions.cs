using UnityEngine;

namespace LLib.Extensions
{
    public static class Vector3Extensions
    {
        /// <summary>
        /// X 값 변경
        /// </summary>
        public static Vector3 WithX(this Vector3 vector, float x)
        {
            vector.x = x;
            return vector;
        }

        /// <summary>
        /// Y 값 변경
        /// </summary>
        public static Vector3 WithY(this Vector3 vector, float y)
        {
            vector.y = y;
            return vector;
        }

        /// <summary>
        /// Z 값 변경
        /// </summary>
        public static Vector3 WithZ(this Vector3 vector, float z)
        {
            vector.z = z;
            return vector;
        }

        /// <summary>
        /// X 값 추가
        /// </summary>
        public static Vector3 AddX(this Vector3 vector, float value)
        {
            vector.x += value;
            return vector;
        }

        /// <summary>
        /// Y 값 추가
        /// </summary>
        public static Vector3 AddY(this Vector3 vector, float value)
        {
            vector.y += value;
            return vector;
        }

        /// <summary>
        /// Z 값 추가
        /// </summary>
        public static Vector3 AddZ(this Vector3 vector, float value)
        {
            vector.z += value;
            return vector;
        }

        /// <summary>
        /// 두 위치 사이 정규화 된 방향
        /// </summary>
        public static Vector3 DirectionTo(this Vector3 from, Vector3 target)
        {
            return (target - from).normalized;
        }

        /// <summary>
        /// 일정 거리 이내인지 체크
        /// </summary>
        public static bool IsNear(this Vector3 vector, Vector3 target, float distance)
        {
            return (vector - target).sqrMagnitude <= distance * distance;
        }

        /// <summary>
        /// 거리 제곱 반환
        /// </summary>
        public static float DistanceSqr(this Vector3 a, Vector3 b)
        {
            return (a - b).sqrMagnitude;
        }

        /// <summary>
        /// Vector3(X, Z) → Vector2 변환
        /// </summary>
        public static Vector2 ToVectorXZ(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }

        /// <summary>
        /// Vector3(X, Y) → Vector2 변환
        /// </summary>
        public static Vector2 ToVectorXY(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }

        /// <summary>
        /// Vector3(Y, Z) → Vector2 변환
        /// </summary>
        public static Vector2 ToVectorYZ(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.z);
        }
    }
}
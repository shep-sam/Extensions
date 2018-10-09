using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class Vector2Extension
    {
        public static Vector2 GetClosest(this Vector2 position, IEnumerable<Vector2> otherPositions)
        {
            var closest       = Vector2.zero;
            var shortDistance = Mathf.Infinity;

            foreach (var otherPosition in otherPositions)
            {
                var distance = (position - otherPosition).sqrMagnitude;

                if (distance < shortDistance)
                {
                    closest       = otherPosition;
                    shortDistance = distance;
                }
            }

            return closest;
        }

        public static Vector2 SetX(this Vector2 vector, float x)
        {
            return new Vector2(x, vector.y);
        }

        public static Vector2 SetY(this Vector2 vector, float y)
        {
            return new Vector2(vector.x, y);
        }

        public static Vector3 SetZ(this Vector2 vector, float z)
        {
            return new Vector3(vector.x, vector.y, z);
        }

        public static Vector3 ToXYZ(this Vector2 vector)
        {
            return new Vector3(vector.x, 0.0f, vector.y);
        }
    }
}

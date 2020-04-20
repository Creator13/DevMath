using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {
    public struct Vector3 {
        public float x;
        public float y;
        public float z;

        public float Magnitude => (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

        public Vector3 Normalized => this / Magnitude;

        public Vector3(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(Vector2 v) {
            return new Vector3(v.x, v.y, 0);
        }

        public static float Dot(Vector3 lhs, Vector3 rhs) {
            return
                lhs.x * rhs.x +
                lhs.y * rhs.y +
                lhs.z * lhs.z;
        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs) {
            throw new NotImplementedException();
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t) {
            throw new NotImplementedException();
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs) {
            return new Vector3(
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z
            );
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs) {
            return new Vector3(
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z
            );
        }

        public static Vector3 operator -(Vector3 v) {
            return new Vector3(-v.x, -v.y, -v.z);
        }

        public static Vector3 operator *(Vector3 lhs, float scalar) {
            return new Vector3(
                lhs.x * scalar,
                lhs.y * scalar,
                lhs.z * scalar
            );
        }

        public static Vector3 operator /(Vector3 lhs, float scalar) {
            return new Vector3(
                lhs.x / scalar,
                lhs.y / scalar,
                lhs.z / scalar
            );
        }
    }
}

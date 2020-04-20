using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {
    public struct Vector2 {
        public float x;
        public float y;

        public float Magnitude => (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        public Vector2 Normalized => this / Magnitude;

        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs) {
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t) {
            throw new NotImplementedException();
        }

        public static float Angle(Vector2 lhs, Vector2 rhs) {
            throw new NotImplementedException();
        }

        public static Vector2 DirectionFromAngle(float angle) {
            throw new NotImplementedException();
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs) {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs) {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        public static Vector2 operator -(Vector2 v) {
            // v.x = -v.x;
            // v.y = -v.y;
            // return v;
            
            return new Vector2(-v.x, -v.y);
        }

        public static Vector2 operator *(Vector2 lhs, float scalar) {
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar) {
            return new Vector2(lhs.x / scalar, lhs.y / scalar);
        }
    }
}

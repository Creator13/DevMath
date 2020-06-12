﻿using System;

namespace DevMath {
public struct Vector4 {
    public float x;
    public float y;
    public float z;
    public float w;

    public float Magnitude => (float) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(w, 2));

    public Vector4 Normalized => Magnitude == 0 ? new Vector4(0, 0, 0, 0) : this / Magnitude;

    public Vector4(float x, float y, float z, float w) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    public static implicit operator Vector4(Vector3 v) {
        return new Vector4(v.x, v.y, v.z, 0);
    }

    public static float Dot(Vector4 lhs, Vector4 rhs) {
        return lhs.x * rhs.x +
               lhs.y * rhs.y +
               lhs.z * lhs.z +
               lhs.w * lhs.w;
    }

    public static Vector4 Lerp(Vector4 a, Vector4 b, float t) {
        return a * (1 - t) + b * t;
    }

    public static Vector4 operator +(Vector4 lhs, Vector4 rhs) {
        return new Vector4(
            lhs.x + rhs.x,
            lhs.y + rhs.y,
            lhs.z + rhs.z,
            lhs.w + rhs.w
        );
    }

    public static Vector4 operator -(Vector4 lhs, Vector4 rhs) {
        return new Vector4(
            lhs.x - rhs.x,
            lhs.y - rhs.y,
            lhs.z - rhs.z,
            lhs.w - rhs.w
        );
    }

    public static Vector4 operator -(Vector4 v) {
        return new Vector4(-v.x, -v.y, -v.z, -v.w);
    }

    public static Vector4 operator *(Vector4 lhs, float scalar) {
        return new Vector4(
            lhs.x * scalar,
            lhs.y * scalar,
            lhs.z * scalar,
            lhs.w * scalar
        );
    }

    public static Vector4 operator /(Vector4 lhs, float scalar) {
        return new Vector4(
            lhs.x / scalar,
            lhs.y / scalar,
            lhs.z / scalar,
            lhs.w / scalar
        );
    }
}
}

﻿using System;

namespace DevMath {
public class Matrix4x4 {
    private float[][] m = {new float[4], new float[4], new float[4], new float[4]};

    public Matrix4x4() {
        for (var i = 0; i < 4; i++) {
            for (var j = 0; j < 4; j++) {
                m[i][j] = 0;
            }
        }
    }

    public Matrix4x4(float[,] matrix) {
        //TODO
    }

    public static Matrix4x4 Identity => new Matrix4x4(new float[,] {
        {1, 0, 0, 0},
        {0, 1, 0, 0},
        {0, 0, 1, 0},
        {0, 0, 0, 1},
    });

    public float Determinant {
        get { throw new NotImplementedException(); }
    }

    public Matrix4x4 Inverse {
        get { throw new NotImplementedException(); }
    }

    public float this[int x, int y] {
        get => m[x][y];
        set => m[x][y] = value;
    }

    public static Matrix4x4 Translate(Vector3 translation) {
        throw new NotImplementedException();
    }

    public static Matrix4x4 Rotate(Vector3 rotation) {
        //Er zijn 2 manieren om deze te berekenen
        throw new NotImplementedException();
    }

    public static Matrix4x4 RotateX(float rotation) {
        throw new NotImplementedException();
    }

    public static Matrix4x4 RotateY(float rotation) {
        throw new NotImplementedException();
    }

    public static Matrix4x4 RotateZ(float rotation) {
        throw new NotImplementedException();
    }

    public static Matrix4x4 Scale(Vector3 scale) {
        throw new NotImplementedException();
    }

    public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) {
        throw new NotImplementedException();
    }

    public static Vector4 operator *(Matrix4x4 lhs, Vector4 rhs) {
        throw new NotImplementedException();
    }
}
}

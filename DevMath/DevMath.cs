﻿using System;

namespace DevMath {
public class DevMath {
    public static float Lerp(float a, float b, float t) {
        return a * (1 - t) + b * t;
    }

    public static float DistanceTraveled(float startVelocity, float acceleration, float time) {
        // dX = 0.5 * (v/t^2) * t, x_start = v_start * t
        return startVelocity * time + 0.5f * acceleration * time;
    }

    public static float Clamp(float value, float min, float max) {
        if (value < min) {
            return min;
        }
        else if (value > max) {
            return max;
        }
        else {
            return value;
        }
    }

    public static float RadToDeg(float angle) {
        return (float) (angle * (180f / Math.PI));
    }

    public static float DegToRad(float angle) {
        return (float) (angle * (Math.PI / 180f));
    }
}
}

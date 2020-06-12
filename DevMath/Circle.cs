﻿namespace DevMath {
    public class Circle {
        public Vector2 Position { get; set; }

        public float Radius { get; set; }

        public bool CollidesWith(Circle circle) {
            return (circle.Position - Position).Magnitude <= circle.Radius + Radius;
        }
    }
}

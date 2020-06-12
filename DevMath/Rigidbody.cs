﻿using System;

namespace DevMath {
    public class Rigidbody {
        public Vector2 Velocity { get; private set; }

        public float mass = 1.0f;
        public float force = 150.0f;
        public float dragCoefficient = .47f;

        public void AddForce(Vector2 forceDirection, float deltaTime) {
            var acceleration = forceDirection * force / (mass * deltaTime);
            Velocity = Velocity * (float) (1 / dragCoefficient * Math.Exp(-dragCoefficient / mass * deltaTime)) * dragCoefficient +  acceleration * mass - acceleration * mass / dragCoefficient;
        }
    }
}

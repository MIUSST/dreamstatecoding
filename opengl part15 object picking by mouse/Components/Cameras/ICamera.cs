﻿using OpenTK;

namespace techdump.opengl.Components.Cameras
{
    public interface ICamera
    {
        Vector3 Position { get; }
        Matrix4 LookAtMatrix { get; }
        void Update(double time, double delta);
    }
}
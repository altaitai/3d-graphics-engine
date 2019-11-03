using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DGraphicsEngine
{
    class ProjectionMatrix : Matrix4x4
    {
        public ProjectionMatrix(float near, float far, float fov, float aspectRatio)
        {
            Near = near;
            Far = far;
            FieldOfView = fov;
            AspectRatio = aspectRatio;
            FieldOfViewRad = 1.0f / (float)Math.Tan(fov * 0.5f / 180.0f * 3.14159f);
            Values[0, 0] = AspectRatio * FieldOfViewRad;
            Values[1, 1] = FieldOfViewRad;
            Values[2, 2] = Far / (Far - Near);
            Values[3, 2] = (-Far * Near) / (Far - Near);
            Values[2, 3] = 1.0f;
            Values[3, 3] = 0.0f;
        }

        public readonly float Near;
        public readonly float Far;
        public readonly float FieldOfView;
        public readonly float AspectRatio;
        private float FieldOfViewRad;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DGraphicsEngine
{
    class Matrix4x4
    {
        public Matrix4x4()
        {
            Values = new float[4, 4]
            {
                { 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f },
                { 0.0f, 0.0f, 0.0f, 0.0f }
            };
        }

        public Vec3d Multiply(Vec3d input)
        {
            Vec3d output = new Vec3d
            {
                X = input.X * Values[0, 0] + input.Y * Values[1, 0] + input.Z * Values[2, 0] + Values[3, 0],
                Y = input.X * Values[0, 1] + input.Y * Values[1, 1] + input.Z * Values[2, 1] + Values[3, 1],
                Z = input.X * Values[0, 2] + input.Y * Values[1, 2] + input.Z * Values[2, 2] + Values[3, 2]
            };
            float w = input.X * Values[0, 3] + input.Y * Values[1, 3] + input.Z * Values[2, 3] + Values[3, 3];
            if (w != 0.0f)
            {
                output.X /= w;
                output.Y /= w;
                output.Z /= w;
            }
            return output;
        }

        public float[,] Values { get; set; } 
    }
}

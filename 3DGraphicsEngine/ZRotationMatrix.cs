using System;

namespace _3DGraphicsEngine
{
    class ZRotationMatrix : Matrix4x4
    {
        public ZRotationMatrix(float angle)
        {
            Values[0, 0] = (float) Math.Cos(angle);
            Values[0, 1] = (float) Math.Sin(angle);
            Values[1, 0] = (float)-Math.Sin(angle);
            Values[1, 1] = (float) Math.Cos(angle);
            Values[2, 2] = 1.0f;
            Values[3, 3] = 1.0f;
        }
    }
}

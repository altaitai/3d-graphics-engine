using System;

namespace _3DGraphicsEngine
{
    class YRotationMatrix : Matrix4x4
    {
        public YRotationMatrix(float angle)
        {
            Values[0, 0] = (float)Math.Cos(angle);
            Values[2, 0] = (float)Math.Sin(angle);
            Values[1, 1] = 1.0f;
            Values[0, 2] = (float)-Math.Sin(angle);
            Values[2, 2] = (float)Math.Cos(angle);
            Values[3, 3] = 1.0f;
        }
    }
}

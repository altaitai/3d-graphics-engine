using System;

namespace _3DGraphicsEngine
{
    class XRotationMatrix : Matrix4x4
    {
        public XRotationMatrix(float angle)
        {
            Values[0, 0] = 1.0f;
            Values[1, 1] = (float) Math.Cos(angle);
            Values[1, 2] = (float) Math.Sin(angle);
            Values[2, 1] = (float) -Math.Sin(angle);
            Values[2, 2] = (float) Math.Cos(angle);
            Values[3, 3] = 1.0f;
        }
    }
}

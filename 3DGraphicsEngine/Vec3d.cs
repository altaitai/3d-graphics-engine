namespace _3DGraphicsEngine
{
    class Vec3d
    {
        public Vec3d(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vec3d(Vec3d vec)
        {
            X = vec.X;
            Y = vec.Y;
            Z = vec.Z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}

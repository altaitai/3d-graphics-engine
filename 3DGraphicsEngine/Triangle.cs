namespace _3DGraphicsEngine
{
    class Triangle
    {
        public Vec3d[] Points { get; set; }

        public Triangle(Vec3d p1, Vec3d p2, Vec3d p3)
        {
            Points = new Vec3d[3];
            Points[0] = p1;
            Points[1] = p2;
            Points[2] = p3;
        }

        public Triangle(Triangle tri)
        {
            Points = new Vec3d[3];
            Points[0] = new Vec3d(tri.Points[0]);
            Points[1] = new Vec3d(tri.Points[1]);
            Points[2] = new Vec3d(tri.Points[2]);
        }

        public void Transform(Matrix4x4 matrix)
        {
            Points[0] = matrix.Multiply(Points[0]);
            Points[1] = matrix.Multiply(Points[1]);
            Points[2] = matrix.Multiply(Points[2]);
        }

        public void Translate(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            foreach (Vec3d point in Points)
            {
                point.X += x;
                point.Y += y;
                point.Z += z;
            }
        }

        public void Scale(float factor)
        {
            foreach (Vec3d point in Points)
            {
                point.X *= factor;
                point.Y *= factor;
                point.Z *= factor;
            }
        }

        public void Scale(float x = 0.0f, float y = 0.0f, float z = 0.0f)
        {
            foreach (Vec3d point in Points)
            {
                point.X *= x;
                point.Y *= y;
                point.Z *= z;
            }
        }
    }
}

using System.Collections.Generic;

namespace _3DGraphicsEngine
{
    class Mesh
    {
        public List<Triangle> Triangles { get; set; }

        public Mesh()
        {
            Triangles = new List<Triangle>();
        }

        public void Add(Vec3d p1, Vec3d p2, Vec3d p3)
        {
            Triangles.Add(new Triangle(p1, p2, p3));
        }
    }
}

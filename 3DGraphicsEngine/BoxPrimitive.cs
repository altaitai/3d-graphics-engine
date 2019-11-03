using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DGraphicsEngine
{
    class BoxPrimitive : Mesh
    {
        public BoxPrimitive(float width = 1.0f, float height = 1.0f, float depth = 1.0f)
        {
            // vertex
            Vec3d p1 = new Vec3d(0, 0, 0);
            Vec3d p2 = new Vec3d(0, height, 0);
            Vec3d p3 = new Vec3d(0, height, depth);
            Vec3d p4 = new Vec3d(0, 0, depth);
            Vec3d p5 = new Vec3d(width, 0, 0);
            Vec3d p6 = new Vec3d(width, height, 0);
            Vec3d p7 = new Vec3d(width, height, depth);
            Vec3d p8 = new Vec3d(width, 0, depth);

            // front triangles
            Add(p1, p2, p5);
            Add(p2, p5, p6);

            // back triangles
            Add(p3, p4, p7);
            Add(p4, p7, p8);

            // top triangles
            Add(p2, p3, p7);
            Add(p2, p6, p7);

            // bottom triangles
            Add(p1, p4, p8);
            Add(p1, p5, p8);

            // left side triangles
            Add(p1, p2, p3);
            Add(p1, p3, p4);

            // right side triangles
            Add(p5, p6, p7);
            Add(p5, p7, p8);
        }
    }
}

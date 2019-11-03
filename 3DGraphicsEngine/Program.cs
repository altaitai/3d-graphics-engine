using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelEngine;

namespace _3DGraphicsEngine
{
    public class TDGraphicsEngine : Game
    {
        private float LastFrameRate;

        static void Main(string[] args)
        {
            TDGraphicsEngine p = new TDGraphicsEngine();
            p.Construct(500, 500, 1, 1);
            p.Start();
        }

        public override void OnCreate()
        {
            AppName = "3D Demo";
            LastFrameRate = 0.0f;
            PixelMode = Pixel.Mode.Alpha;
            Box = new BoxPrimitive(1,1,1);
            BoxAngle = 0.0f;
            ViewProjectionMatrix = new ProjectionMatrix(0.1f, 1000.0f, 90.0f, ScreenHeight / ScreenWidth);
        }

        private BoxPrimitive Box;
        private ProjectionMatrix ViewProjectionMatrix;
        private float BoxAngle;
        
        public override void OnUpdate(float elapsed)
        {
            Clear(Pixel.Presets.White);

            // create rotation matrices
            BoxAngle += elapsed;

            ZRotationMatrix zRotation = new ZRotationMatrix(BoxAngle);
            XRotationMatrix xRotation = new XRotationMatrix(0.5f * BoxAngle);
            YRotationMatrix yRotation = new YRotationMatrix(0.25f * BoxAngle);

            // draw triangles
            foreach (Triangle tri in Box.Triangles)
            {
                // create triangle copy
                Triangle processedTriangle = new Triangle(tri);

                // rotate
                processedTriangle.Transform(zRotation);
                processedTriangle.Transform(xRotation);
                processedTriangle.Transform(yRotation);

                // push in z space to see it properly
                processedTriangle.Translate(0.0f, 0.0f, 3.0f);

                // project
                processedTriangle.Transform(ViewProjectionMatrix);

                // push in x,y space
                processedTriangle.Translate(1.0f, 1.0f);

                // scale it up
                processedTriangle.Scale(0.5f * ScreenWidth, 0.5f * ScreenHeight);

                // draw it
                DrawTriangle
                (
                    new Point((int)processedTriangle.Points[0].X, (int)processedTriangle.Points[0].Y),
                    new Point((int)processedTriangle.Points[1].X, (int)processedTriangle.Points[1].Y),
                    new Point((int)processedTriangle.Points[2].X, (int)processedTriangle.Points[2].Y),
                    Pixel.Presets.Black
                );
            }

            //float newFrameRate = 0.1f*(1 / elapsed) + 0.9f*LastFrameRate;
            //LastFrameRate = newFrameRate;
            //DrawText(new Point(10, 10), "FPS: " + newFrameRate.ToString(), Pixel.Presets.Black);   
        }
    }
}

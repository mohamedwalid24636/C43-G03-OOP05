using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IShape 
    {
        public float Area { set; get; }
        public void display_info(); 
    }


    internal interface ICircle : IShape
    {
        public float r { set; get; }
    }

    internal interface IRegtangle : IShape
    {
        public float height { get; }
        public float width { set; get; }

    }



    internal class Regtangle : IRegtangle
    {
        public Regtangle(float height, float width)
        {
            this.height = height;
            this.width = width;
            this.Area = height * width; 
        }

        public float height { set; get; }
        public float width { set; get; }
        public float Area { set; get; }


        public void display_info()
        {
            Console.WriteLine( $"height = {height}  width = {width} , Area = {Area}");
        }




    }

    internal class Circle : ICircle
    {
        public Circle(float r)
        {
            this.r = r;
            Area = (float)(22 / 7) * r * r;
            
        }

        public float r { set; get; }
        public float Area { set; get; }



        public void display_info()
        {
            Console.WriteLine($"Radius : {r} , Area = {Area}");
        }
    }




}

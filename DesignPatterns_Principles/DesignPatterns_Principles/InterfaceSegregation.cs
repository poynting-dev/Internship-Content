using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    interface IToy
    {
        void setPrice(double price);
        void setColor(String color);
    }
    interface IMovable
    {
        void move();
    }
    interface IFlyable
    {
        void fly();
    }

    class ToyHouse : IToy
    {
        double price;
        String color;
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
    }
    class ToyPlane : IToy, IMovable
    {
        double price;
        String color; 
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
        public void move()
        {
            //code related to moving plane}public void fly(){// code related to flying plane}
        }
    }
    class InterfaceSegregation
    {
        public void print()
        {
            ToyPlane tp = new ToyPlane();
            tp.setPrice(500);
            tp.setColor("Blue");
            tp.move();
        }
    }
}

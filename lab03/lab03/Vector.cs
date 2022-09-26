using System;
namespace lab03
{
    public struct Vector
    {
        private double x_;
        private double y_;
        private double z_;
        public Vector(double x, double y, double z)
        {
            x_ = x;
            y_ = y;
            z_ = z;
        }
        public Vector()
        {
            x_ = 0;
            y_ = 0;
            z_ = 0;
        }
        public double X
        {
            get => x_;
            set
            {
                x_ = value;
            }
        }
        public double Y
        {
            get => y_;
            set
            {
                y_ = value;  
            }
        }
        public double Z
        {
            get => z_;
            set
            {
                z_ = value;
            }
        }
        public static Vector operator +(Vector obj1, Vector obj2)
        {
            Vector result = new()
            {
                X = obj1.x_ + obj2.x_,
                Y = obj1.y_ + obj2.y_,
                Z = obj1.z_ + obj2.z_
            };
            Console.WriteLine($"X: {result.X}");
            Console.WriteLine($"Y: {result.Y}");
            Console.WriteLine($"Z: {result.Z}");
            return result;
        }
        public static double operator *(Vector obj1, Vector obj2)
        {
            double result = obj1.x_ * obj2.x_ + obj1.y_ * obj2.y_ + obj1.z_ * obj2.z_;
            return result;
        }
        public static double operator *(int value, Vector obj)
        {
            double result = obj.x_ * value + obj.y_ * value + obj.z_ * value;
            return result;
        }
        public static bool operator <(Vector obj1, Vector obj2)
        {
            double lenght1 = Math.Sqrt(Math.Pow(obj1.x_, 2) + Math.Pow(obj1.y_, 2) + Math.Pow(obj1.z_, 2));
            double lenght2 = Math.Sqrt(Math.Pow(obj2.x_, 2) + Math.Pow(obj2.y_, 2) + Math.Pow(obj2.z_, 2));
            return lenght1 < lenght2;
        }
        public static bool operator >(Vector obj1, Vector obj2) => !(obj1 < obj2);
        public static bool operator !=(Vector obj1, Vector obj2)
        {
            double lenght1 = Math.Sqrt(Math.Pow(obj1.x_, 2) + Math.Pow(obj1.y_, 2) + Math.Pow(obj1.z_, 2));
            double lenght2 = Math.Sqrt(Math.Pow(obj2.x_, 2) + Math.Pow(obj2.y_, 2) + Math.Pow(obj2.z_, 2));
            return lenght1 != lenght2;
        }
        public static bool operator ==(Vector obj1, Vector obj2) => !(obj1 != obj2);
    }
}


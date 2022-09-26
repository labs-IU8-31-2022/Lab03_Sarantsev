using System;
namespace lab03
{
    public class Car : IEquatable<Car>
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public string Engine { get; set; }
        public Car(string name, int max_speed, string engine)
        {
            Name = name;
            MaxSpeed = max_speed;
            Engine = engine;
        }
        public override string ToString()
        {
            return Name;
        }
        public bool Equals(Car car) => (Name == car.Name && MaxSpeed == car.MaxSpeed && Engine == car.Engine);
    }

    public class CarsCatalog
    {
        Car[] cars_;
        public CarsCatalog(Car[] cars) => cars_ = cars;
        public string this[int index]
        {
            get
            {
                return cars_[index].ToString() + " " + cars_[index].Engine;
            }
        }
    }
}


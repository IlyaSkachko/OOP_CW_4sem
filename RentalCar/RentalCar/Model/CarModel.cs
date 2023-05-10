using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Model
{
    public class CarModel
    {
        private int id;
        private string model;
        private string description;
        private string carBody;
        private int power;
        private string color;
        private string classCar;
        private int capacity;
        private float fuelConsumption;
        private int price;
        private byte[] photo;

        public int Id { get { return id; } set { id = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string CarBody { get { return carBody; } 
            set
            {
                carBody = value;
            } }
        public int Power { get { return power; } set { power = value; } }
        public string Color { get { return color; }
            set
            {
                color = value;
            } }   
        public string Class { get { return classCar; } 
            set
            {
                classCar = value;
            } }
        public int Capacity { get { return capacity; } set { capacity = value; } }    
        public float FuelConsumption { get { return fuelConsumption; } 
            set
            {
                fuelConsumption = value;
            } }
        public int Price { get { return price; } 
            set
            {
                price = value;
            } }
        public byte[] Photo { get { return photo; }
            set
            {
                photo = value;
            } }

        public CarModel(string model, string description, string carBody, int power, string color, string classCar, int capacity, float fuelConsumption, int price, byte[] photo)
        {
            this.model = model;
            this.description = description;
            this.carBody = carBody;
            this.power = power;
            this.color = color;
            this.classCar = classCar;
            this.capacity = capacity;
            this.fuelConsumption = fuelConsumption;
            this.price = price;
            this.photo = photo;
        }

        public CarModel() { }
    }
}

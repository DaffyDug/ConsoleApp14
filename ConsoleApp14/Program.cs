using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp14
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //public class Car
    //{
    //    private Color _Color;
    //    private string _Brand;
    //    public Car(Color color, string brand)
    //    {
    //        _Color = color;
    //        _Brand = brand;
    //    }
    //}

    //public class FastCar : Car
    //{
    //    private int _Speed;
    //    public FastCar(Color color, string brand) : base(color, brand)
    //    {

    //    }
    //}

    //public class Weapon
    //{
    //    private Color _Color;
    //    private Material _Material;
    //    public Weapon(Color color, Material material)
    //    {
    //        _Color = color;
    //        _Material = material;
    //    }
    //}

    //public class Shotgun : Weapon
    //{
    //    private float _Calibre;
    //    private float _Damage;
    //    public Shotgun(Color color, Material material, float calibre, float damage) : base(color, material)
    //    {
    //        _Calibre = calibre;
    //        _Damage = damage;
    //    }
    //}

    //public class Pistol : Shotgun
    //{
    //    private float _Calibre;
    //    private float _Damage;
    //    public Pistol(Color color, Material material, float calibre, float damage) : base(color, material, calibre, damage)
    //    {
    //        _Calibre = calibre;
    //        _Damage = damage;
    //    }
    //}

    public class Animal
    {
        private float _KG;
        private int _Fullness;
        public Animal(float kg, int fullness)
        {
            _KG = kg;
            _Fullness = fullness;
        }
        public void ADD_Fullness(int a)
        {
            _Fullness += a;
            Console.WriteLine(_Fullness);
        }
    }

    public class Cow : Animal
    {
        private float _price_meat;
        private float _price_milk;
        public Cow(float kg, int fullness, float price_meat, float price_milk) : base(kg, fullness)
        {
            _price_meat = price_meat;
            _price_milk = price_milk;
        }
    }

    public class Ship : Animal
    {
        private float _price_wool;
        public Ship(float kg, int fullness, float price_wool) : base(kg, fullness)
        {
            _price_wool = price_wool;
        }
    }

    public class Farm
    {
        private List<Animal> _animal = new List<Animal>();
        public void pocormit(Animal animal, int a)
        {
            foreach (var item in _animal)
            {
                animal.ADD_Fullness(a);
            }
        }
    }
}

//public enum Material
//{
//    Plastick, metal
//}

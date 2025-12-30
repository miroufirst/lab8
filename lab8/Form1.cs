using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        private ICar _currentCar;

        public Form1()
        {
            InitializeComponent();
            AttachEvents();
        }

        private void AttachEvents()
        {
            btnSedan.Click += (s, e) => CreateCar(new Sedan());
            btnSuv.Click += (s, e) => CreateCar(new SUV());

            btnGps.Click += (s, e) => AddDecorator(new GPS(_currentCar));
            btnLeather.Click += (s, e) => AddDecorator(new LeatherSeats(_currentCar));
            btnSpoiler.Click += (s, e) => AddDecorator(new Spoiler(_currentCar));
        }

        private void CreateCar(ICar car)
        {
            _currentCar = car;
            UpdateDisplay();
        }

        private void AddDecorator(ICar decorator)
        {
            if (_currentCar == null)
            {
                MessageBox.Show("Please select a base car first!");
                return;
            }

            _currentCar = decorator;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (_currentCar != null)
            {
                lblResult.Text = $"Description: {_currentCar.GetDescription()}\n\n" +
                                 $"Total Cost: {_currentCar.GetCost()} $";
            }
        }
    }

    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    public class Sedan : ICar
    {
        public string GetDescription() => "Sedan";
        public double GetCost() => 10000;
    }

    public class SUV : ICar
    {
        public string GetDescription() => "SUV";
        public double GetCost() => 15000;
    }

    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription() => _car.GetDescription();
        public virtual double GetCost() => _car.GetCost();
    }

    public class GPS : CarDecorator
    {
        public GPS(ICar car) : base(car) { }

        public override string GetDescription() => _car.GetDescription() + ", GPS Navigation";
        public override double GetCost() => _car.GetCost() + 500;
    }

    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(ICar car) : base(car) { }

        public override string GetDescription() => _car.GetDescription() + ", Leather Interior";
        public override double GetCost() => _car.GetCost() + 1000;
    }

    public class Spoiler : CarDecorator
    {
        public Spoiler(ICar car) : base(car) { }

        public override string GetDescription() => _car.GetDescription() + ", Sport Spoiler";
        public override double GetCost() => _car.GetCost() + 300;
    }
}
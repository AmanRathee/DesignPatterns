using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Engineer director = new Engineer();

            Builder b1 = new BikeBuilder();
            director.Construct(b1);
            VehicleFormed p1 = b1.GetVehicle();
            p1.Show();

            Builder b2 = new CarBuilder();
            director.Construct(b2);
            VehicleFormed p2 = b2.GetVehicle();
            p2.Show();


            Console.ReadKey();
        }
    }

    #region Builder | specifies an abstract interface for creating parts of a Product object
    abstract class Builder
    {
        public abstract void BuildBody();
        public abstract void BuildTyres();
        public abstract void InstallParts();
        public abstract void Paint();
        public abstract VehicleFormed GetVehicle();

    }
    #endregion

    #region Product | Define the constituent parts, including interfaces for assembling the parts into the final result
    class VehicleFormed
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
    #endregion

    #region Concrete Builder | constructs and assembles parts of the product by implementing the Builder interface
    class BikeBuilder : Builder
    {
        private VehicleFormed _product = new VehicleFormed();

        public override void BuildBody()
        {
            _product.Add("Bike body Built.");
        }

        public override void BuildTyres()
        {
            _product.Add("Bike tyres Built.");
        }             

        public override void InstallParts()
        {
            _product.Add("Bike parts installed.");
        }

        public override void Paint()
        {
            _product.Add("Bike painted.");
        }
        public override VehicleFormed GetVehicle()
        {
            return _product;
        }
    }
    class CarBuilder : Builder
    {
        private VehicleFormed _product = new VehicleFormed();

        public override void BuildBody()
        {
            _product.Add("Car body Built.");
        }

        public override void BuildTyres()
        {
            _product.Add("Car tyres Built.");
        }

        public override void InstallParts()
        {
            _product.Add("Car parts installed.");
        }

        public override void Paint()
        {
            _product.Add("Car painted.");
        }
        public override VehicleFormed GetVehicle()
        {
            return _product;
        }
    }

    #endregion

    #region Director | constructs an object using the Builder interface | tells the sequence in which the parts are to be assembled
    class Engineer
    {
        // Builder uses a complex series of steps

        public void Construct(Builder builder)
        {
            builder.BuildBody();
            builder.BuildTyres();
            builder.InstallParts();
            builder.Paint();
        }
    }

    #endregion
}

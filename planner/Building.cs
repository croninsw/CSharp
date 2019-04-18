using System;

namespace Planner
{
    public class Building
    {
        // CLASSES
        // private

        // get and set are also called accessor and mutator

        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        // public
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {
            get
            {
                return (Width * Depth) * (3 * Stories);
            }
        }

        // constructor
        public Building(string address, string designerlear)
        {
            _address = address;
            _designer = designerlear;
        }

        // METHODS
        // public interfaces for private variable

        // If you use "return this" instead of "void", you return the reference to the object instead of nothing.
        // This allows you to chain methods together because you return the thing itself which has another method on it.

        // public void Construct() {
        //     _dateConstructed = DateTime.Now;
        // }


        public Building Construct() {
            _dateConstructed = DateTime.Now;
            return this;
        }

        public Building Purchase(string BuyersName) {
            _owner = BuyersName;
            return this;
        }

        public void PrintPrivateInformation() {
            Console.WriteLine($@"
            {_address}
            -----------
            Designed by {_designer}
            Constructed on {_dateConstructed}
            Owned by {_owner}
            {Volume} cubic meters of space
            ");
        }
    }





    }

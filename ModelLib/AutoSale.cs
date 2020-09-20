using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    class AutoSale
    {
        public AutoSale(string name, string address)
        {
            Name = name;
            Address = address;
            Cars = new List<Car>();
        }

        public AutoSale(string name, string address, List<Car> cars)
        {
            Name = name;
            Address = address;
            Cars = cars;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }
    }
}

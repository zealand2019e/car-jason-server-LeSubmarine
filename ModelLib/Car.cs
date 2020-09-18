using System;

namespace ModelLib
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public string RegNr { get; set; }

        public override string ToString()
        {
            return $"{nameof(Color)}: {Color}, {nameof(Model)}: {Model}, {nameof(RegNr)}: {RegNr}";
        }
    }
}

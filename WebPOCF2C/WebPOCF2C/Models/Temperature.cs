using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPOCF2C.Models
{
    public class Temperature
    {
        public double Temp { get; set; }
        public Scale Scale { get; set; }
        public Temperature()
        {

        }
        public Temperature(double temp)
        {
            this.Temp = temp;
        }
        public Temperature(double temp, byte scale)
        {
            this.Temp = temp;
            if (scale < 0)
            {
                this.Scale = Scale.Celsius;
            }
            else if(scale > 1)
            {
                this.Scale = Scale.Farenheit;
            }
            else
            {
                this.Scale = (Scale)scale;
            }
        }

        public double C2F(double TC)
        {
            double TF;

            TF = ((9.0 / 5.0) * TC) + 32;

            return this.Truncate(TF, 2);
        }

        public double F2C(double TF)
        {
            double TC;

            TC = (TF * 5.0 / 9.0) - 32;

            return this.Truncate(TC, 2);
        }

        // This rounds down
        public float Truncate(double value, int digits)
        {
            double m = Math.Pow(10.0, digits);
            double result = Math.Truncate(m * value) / m;
            return (float)result;
        }
    }
}

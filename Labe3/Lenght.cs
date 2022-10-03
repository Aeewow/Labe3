using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Labe3
{
    public enum MeasureType { m, km, kn ,M}
    public class Length
    {
        private double value;
        private MeasureType type;
        public Length(double value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }
        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.m:
                    typeVerbose = "м/c.";
                    break;
                case MeasureType.km:
                    typeVerbose = "км/c.";
                    break;
                case MeasureType.kn:
                    typeVerbose = "уз.";
                    break;
                case MeasureType.M:
                    typeVerbose = "М";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
        public static Length operator + (Length instance, double number)
        {
            var newValue = instance.value + number;
            var lenght = new Length(newValue, MeasureType.m);
            return lenght;
        }
        public static Length operator + (double number, Length instance)
        {
            return instance + number;
        }
        public static Length operator *(Length instance, double number)
        {
            
            return new Length(instance.value * number, instance.type); ;
        }
        public static Length operator *(double number, Length instance)
        {
            return instance * number;
        }
        public static Length operator -(Length instance, double number)
        {
            return new Length(instance.value - number, instance.type); ;
        }
        public static Length operator -(double number, Length instance)
        {
            return instance - number;
        }
    }
}

using System;

namespace cross_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            float re, im; 
            double mod, arg;

            Console.Write("Введите действительную часть комплексного числа re = ");
            re = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа im = ");
            im = Convert.ToSingle(Console.ReadLine());
            var z1 = Complex.Complex_FromCartesian(re, im);

            Console.Write("Введите модуль комплексного числа mod = ");
            mod = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите аргумент комплексного числа arg = ");
            arg = Convert.ToDouble(Console.ReadLine());
            var z2 = Complex.Complex_FromPolar(mod, arg);

            Console.WriteLine("Первое комплексное число z = {0} + {1}i", z1.Re, z1.Im);
            Console.WriteLine("Второе комплексное число z = {0} + {1}i", z2.Re_Polar, z2.Im_Polar);
            Console.ReadKey();
        }
    }

    public class Complex
    {
        public Complex() { }

        public Complex(float _re, float _im)
        {
            Re = _re;
            Im = _im;
        }
        public Complex(double _re_polar, double _im_polar)
        {
            Re_Polar = _re_polar;
            Im_Polar = _im_polar;
        }
        public static Complex Complex_FromCartesian(float _re, float _im) // алгербраическая
        {
            return new Complex(_re, _im);
        }

        public static Complex Complex_FromPolar(double _mod, double _arg) // тригонометрическая
        {
            double _re_polar = _mod * Math.Cos(_arg);
            double _im_polar = _mod * Math.Sin(_arg);
            return new Complex(_re_polar, _im_polar);
        }

        public float Re { get; set; }
        public float Im { get; set; }
        public double Re_Polar { get; set; }
        public double Im_Polar { get; set; }
    }
}

/*
Алгебраическая форма комплексного числа: z = x + iy
Тригонометрическая форма: z = r(cos ω + i sin ω)
r = sqrt(x^2+y^2)
x = rcos(ω)
y = rsin(ω)
r - модуль (mod)
ω - аргумент (arg)
*/
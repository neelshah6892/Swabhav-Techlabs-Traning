using System;
using OverrideApp.Modal;

namespace OverrideApp
{
    class Program
    {
        static void Main(string[] args)
        {
            case_1();
            case_2();
            case_3();
            case_4();
        }

        public static void case_1()
        {
            Man x;
            x = new Man();
            x.read();
            x.play();
            x.eat();
        }

        public static void case_2()
        {
            Boy y;
            y = new Boy();
            y.run();
            y.play();
            y.read();
            y.eat();

        }

        public static void case_3()
        {
            Man z;
            z = new Boy();
            z.play();
            z.read();
            z.eat();
        }

        public static void case_4()
        {
            atTherestaurant(new Man());
            atTherestaurant(new Boy());
            atTherestaurant(new Kid());
            atTherestaurant(new Infant());
        }

        public static void atTherestaurant(Man x)
        {
            x.eat();
        }
    }
}

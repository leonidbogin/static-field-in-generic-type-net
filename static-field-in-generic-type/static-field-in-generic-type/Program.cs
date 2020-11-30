using System;
using System.Collections.Generic;

namespace static_field_in_generic_type
{
    class Program
    {
        private static void Main(string[] args)
        {
            var rackBread = new Rack<Bread>();
            var rackBread2 = new Rack<Bread>();
            var rackMilk = new Rack<Milk>();

            for (var i = 0; i < 50; i++)
            {
                rackBread.Add(new Bread("Bread " + i));
            }
            for (var i = 0; i < 45; i++)
            {
                rackBread2.Add(new Bread("Bread " + i));
            }
            for (var i = 0; i < 60; i++)
            {
                rackMilk.Add(new Milk("Milk " + i));
            }

            Console.WriteLine("Bread: " + Rack<Bread>.Count);
            Console.WriteLine("Milk: " + Rack<Milk>.Count);

            Console.ReadLine();
        }
    }
}

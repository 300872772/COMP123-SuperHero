using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Author: Md Mamunur Rahman
 * Student ID: 300872772 
 *
 * Date: June 06, 2016
 * Description: This program demonstrates a game charachtar named 'SuperHero', 
 * which has been inharited from Hero class 
 * 
 * 
 * Version: 0.0.2 - Added Instant variable, properties, constructor, private and public method
 */

namespace COMP123_SuperHero
{
    /**
     * This is the driver class for SuperHero program that calls SuperHero class
     * 
     * @class Program
     */
    class Program
    {

        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Mamun");

            superHero.Show();
            Console.WriteLine();   

            superHero.ShowPowers();

        }
    }
}

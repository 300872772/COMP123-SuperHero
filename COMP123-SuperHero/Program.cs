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
 * Version: 0.0.5 - Added UnitTest project.
 */

namespace COMP123_SuperHero
{
    /**
     * <summary>
     * This is the driver class for SuperHero program that calls SuperHero class
     * </summary>
     * 
     * @class Program
     */
    class Program
    {

        static void Main(string[] args)
        {
            //created superHero object
            SuperHero superHero = new SuperHero("Mamun");

            //called Show method under superHero object
            superHero.Show();
            Console.WriteLine();

            //called Fight method under superHero object
            superHero.Fight();
            Console.WriteLine();

            //called ShowPowers method under superHero object
            superHero.ShowPowers();
            Console.WriteLine();



        }
    }
}

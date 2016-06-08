using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 *Author: Md Mamunur Rahman
 * Student ID: 300872772 
 *
 * Date: June 06, 2016
 * Description: This program demonstrates a game charachtar named 'SuperHero', 
 * which has been inharited from Hero class 
 * 
 */

namespace COMP123_SuperHero
{
    /**
     *<summary>
     * This is the class which to demonstrate the charecter SuperHero which is inharited from the class Hero. 
     * </summary>
     *  
     * @class SuporHero
     * @field {List<string>} _superPowers
     *
     * 
     */
   public class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private List<string> _superPowers = new List<string>();


        //PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * This is the property for _superPowers field
         * 
         * @property{List<string>} SuperPowers
         * 
         */
        public List<string> SuperPowers
        {
            get
            {
                return this._superPowers;
            }
            set
            {
                this._superPowers = value;
            }


        }
        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is the constructor for SuperHero Class
         *  </summary>
         *  
         * @constructor SuperHero
         * @param {string} name
         * @extends Hero
         *
         * 
         */
        public SuperHero(string name) : base(name)
        {
            _generateRandomPowers();
            this.Name = name;


        }

        //PRIVATE METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         *  <summary>
         * This is the private method that randomly create 3 powers and add value to List array _superPowers 
         *  </summary>
         *  
         * @return {void}
         * @field {Random} random
         * @field {string[]} powers
         * @field {int} loopEnding
         * @field {int} i
         * @field {string} randomValue
         */
        private void _generateRandomPowers()
        {
            Random random = new Random();
            string[] powers = new string[6] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            int loopingEnd = 3;

            for (int i = 0; i < loopingEnd; i++)
            {
                string randomValue = powers[random.Next(0, 6)];
                if (this.SuperPowers.Contains(randomValue))
                {
                    loopingEnd++;
                }
                else
                {
                    this.SuperPowers.Add(randomValue);
                }

            }


        }// end _generateRandomPowers methods

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         *  <summary>
         * This is the method for displaying the value of List array _superPowers
         *  </summary>
         *  
         * @return {void}
         * @field {string} superPower
         */

        public void ShowPowers()
        {
            Thread.Sleep(400);
            Console.WriteLine(" __        __   __  __           __  __   __");
            Thread.Sleep(400);
            Console.WriteLine("|__  |  | |__| |__ |__|    |__| |__ |__| |  |");
            Thread.Sleep(400);
            Console.WriteLine(" __| |__| |    |__ |  \\    |  | |__ |  \\ |__|");
            Thread.Sleep(400);
            Console.WriteLine();
            Thread.Sleep(400);

            int count = 0;
            string heading = "# # # # # # # # # # # # # # # # _ S u p e r H e r o _ h a s _ g o t _ 3 _ P o w e r s _ # # # # # # # # # # # # # # # # # # # # #";
            string[] stringContainer = heading.Split();
            Thread.Sleep(40);

            foreach (string singleChar in stringContainer)
            {
                Thread.Sleep(20);
                Console.Write(singleChar);

            }
            Console.WriteLine();
            Console.WriteLine();

            Thread.Sleep(50);
            foreach (string superPower in this.SuperPowers)
            {
                count++;
                Console.WriteLine("     " + count + ": " + superPower);

            }

            Console.WriteLine();

            Thread.Sleep(50);

            for (int i = 0; i < 65; i++)
            {
                Thread.Sleep(20);
                Console.Write("#");
            }
            Console.WriteLine();
            Console.WriteLine();

            Thread.Sleep(50);
        }//end ShowPowers method

        /**
        * <summary>
        *This method is only used for testing _generateRandomPowers method under SuperHero class
        * 
        * @method GenerateRandomPowers
        * @field {int}  randomPower
        * @return {int}
        * 
        * </summary>
        */
        public int GenerateRandomPowers()
        {
             _generateRandomPowers();
            int randomPower=0;

            randomPower = SuperPowers.Count;

            return randomPower;
        }

    }//end SuperHero class


}//end namespace

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
 */

namespace COMP123_SuperHero
{
    /**
     *<summary>
     * This is the class which to demonstrate the charecter SuperHero which is inharited from the class Hero. 
     * 
     * @class SuporHero
     * @field {List<string>} _superPowers
     * </summary>
     * 
     */
    class SuperHero : Hero
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
            get {
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
         * 
         * @constructor SuperHero
         * @param {string} name
         * @extends Hero
         * </summary>
         * 
         */
        public SuperHero(string name) : base(name)
        {
            _generateRandomPowers();
            this.Name = name;


        }

        //PRIVATE METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * This is the private method that randomly create 3 powers and add value to List array _superPowers 
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
            string[] powers = new string[6] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control"};
            int loopingEnd = 3;

            for (int i =0; i< loopingEnd; i++)
            {
                string randomValue = powers[random.Next(0, 5)];
                 if (_superPowers.Contains(randomValue))
                 {
                    loopingEnd++;
                 }
                 else
                 {
                     _superPowers.Add(randomValue);
                 }
             
            }


        }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * This is the method for displaying the value of List array _superPowers
         * 
         * @return {void}
         * @field {string} superPower
         */

        public void ShowPowers()
        {
            foreach (string superPower in _superPowers)
            {
                Console.WriteLine(superPower);

            }
            
        }
    }


}

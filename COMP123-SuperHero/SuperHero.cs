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
 * Version: 0.0.1 - Added SuperHero class
 */

namespace COMP123_SuperHero
{
    class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            private List<string> _superPowers = new List<string>();


        //PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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
        private void _generateRandomPowers()
        {
            Random random = new Random();
            string[] powers = new string[6] { "Super Speed", "Super Strength", "Body Armou", "Flight", "Fire Generation", "Weather Control"};
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
        public void ShowPowers()
        {
            foreach (string _superPower in _superPowers)
            {
                Console.WriteLine(_superPower);

            }
            
        }
    }


}

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
     * <summary>
     * This 'Hero' class defines a charecter Hero which has 4 fields, 1 properties, 3 private methods and 2 public methods 
     *  </summary>
     *  
     * @class Hero
     * @field {int} _strength
     * @field {int} _speed
     * @field {int} _health
     * @field {string} _name
     *
     * 
     */
    public class Hero
    {

        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a property for _name field
        *  </summary>
        *  
        * @property {string} Name 
        *
        * 
        */

        public string Name
        {

            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /**
        * <summary>
        * This is a property for _strength field
        *  </summary>
        * @property {int} Strength 
        * 
        * 
        */

        public int Strength
        {

            get
            {
                return this._strength;
            }
            set
            {
                this._strength = value;
            }
        }
        /**
        * <summary>
        * This is a property for _speed field
        *  </summary>
        *  
        *  
        * @property {int} Speed 
        * 
        * 
        */

        public int Speed
        {

            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }

        /**
        * <summary>
        * This is a property for _health field
        *  </summary>
        *  
        * @property {int} Health 
        * 
        * 
        */

        public int Health
        {

            get
            {
                return this._health;
            }
            set
            {
                this._health = value;
            }
        }



        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that takes the name parametere and passes to nameinstance variable
        *  and call _generateAbilit Method.
        * </summary>
        *  
        * @constructor Hero 
        * @param {string} name 
        * 
        * 
        * 
        */

        public Hero(string name)
        {
            _generateAbility();
            this.Name = name;


        }
        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the privte method that generate random nuber and passed to _speed, _strength and _health instance variable
        * </summary>
        * 
        * @method _generateAbility
        * @returns {void}        * 
        * 
        * 
        */

        private void _generateAbility()
        {
            Random random = new Random();
            this.Speed = random.Next(1, 100);
            this.Strength = random.Next(1, 100);
            this.Health = random.Next(1, 100);
        }
        /**
        * <summary>
        * This is the privte method that generate GUI to show abilities and passed _speed, _strength and _health 
        * value by ability parametere
        * </summary>
        * 
        * @method _abilitiesGUI
        * @returns {string} abilityGUI        * 
        * 
        * 
        */

        private string _abilitiesGUI(int ability)
        {
            string abilityGUI = "";

            for (int i = 1; i <= 100; i += 2)
            {
                abilityGUI += ((i <= ability) ? "|" : " ");

            }

            return abilityGUI += " " + ability + "%";
        }

        /**
       * <summary>
       * This is the privte method that returns state of hit attempt of Hero charachter and set probability
       * by setProb parameter
       * </summary>
       * 
       * @method _hitAttempt
       * @param (int) setProb
       * @returns {bool}        * 
       * 
       * 
       */

        private bool _hitAttempt(int setProb)
        {
            Random random = new Random();
            int probability = random.Next(100);

            if (probability <= setProb)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /**
       * <summary>
       * This is the privte method that generate hit damage value randomly and return damage value 
       *  </summary>
       *  
       * @method _hitDamage
       * @returns {int}        * 
       *
       * 
       */
        private int _hitDamage()
        {
            Random random = new Random();
            int damage = (random.Next(1, 6)) * this.Strength;

            return damage;
        }

        //PUBLIC METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the Public Method that calls _hitAttempt boolean method and sets setProb paramete value. 
        * If _hitAttempt method returns true value calls _hitDamage method and show damage value to console
        *  </summary>
        *  
        *@method Fight
        *@returns {void} 
        *  
        *
        * 
        */
        public void Fight()
        {
            if (_hitAttempt(20))
            {
                Console.WriteLine("The Hero has attempted to fight and got damage value {0} ", _hitDamage());

            }
            else
            {
                Console.WriteLine("The Hero has not attempted to fight.");
            }

            //Testing purpose only
            /*
            if (_hitAttempt(20))
            {
                return "The Hero has attempted to fight and got damage value " + _hitDamage();

            }
            else
            {
                return "The Hero has not attempted to fight.";
            }
            */
        }

        /**
        * <summary>
        * This is the Public Method that displays all properties of Hero class
        *  </summary>
        *  
        *  
        * @method Show
        * @returns {void}
        * 
        *
        * 
        */

        public void Show()
        {
            Thread.Sleep(400);
            Console.WriteLine("       __  __   __");
            Thread.Sleep(400);
            Console.WriteLine(" |__| |__ |__| |  |");
            Thread.Sleep(400);
            Console.WriteLine(" |  | |__ |  \\ |__|");
            Thread.Sleep(400);
            Console.WriteLine();
            Thread.Sleep(400);

            for (int i = 0; i < 65; i++)
            {
                Thread.Sleep(20);
                Console.Write("_");

            }

            Console.WriteLine("\n\n Name: {0}\n\n Strength: {1}\n\n Speed:    {2}\n\n Health:   {3}\n"
                , this.Name, _abilitiesGUI(this.Strength), _abilitiesGUI(this.Speed), _abilitiesGUI(this.Health));

            for (int i = 0; i < 65; i++)
            {
                Thread.Sleep(20);
                Console.Write("_");
            }

            Console.WriteLine();
            Console.WriteLine();

        }

        //PUBLIC METHOD, TEST PURPOSE ONLY*********************++++++++++++++++****************************
        /**
       * <summary>
       * This is the public method made for testing purpose ony that calls _hitAttempt method 
       * by setProb parameter
       *  </summary>
       *  
       * @method HitAttempt
       * @param (int) setProb
       * @returns {bool}        * 
       *
       * 
       */

        public bool HitAttempt(int setProb)
        {

            return _hitAttempt(setProb);
        }

        /**
        * <summary>
        * This is the public method made for testing purpose only that calls _hitDamage method 
        *  </summary>
        *  
        * @method HitDamage
        * @returns {int}        * 
        *
        * 
        */
        public int HitDamage()
        {

            return _hitDamage();
        }


    }
}

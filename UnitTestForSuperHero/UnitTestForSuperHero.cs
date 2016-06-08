using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_SuperHero;
/*
 *Author: Md Mamunur Rahman
 * Student ID: 300872772 
 *
 * Date: June 06, 2016
 * Description: This project is used for testing program SuperHero
 * 
 * @namespace  UnitTestForSuperHero
 * 
 */

namespace UnitTestForSuperHero
{
    /**
     * <summary>
     *This class is used for testing SuperHero Class
     * 
     * @class  UnitTestForSuperHero Class
     * </summary>
     */
    [TestClass]
    public class UnitTestForSuperHero
    {
        /**
         * <summary>
         *This method is used for testing _generateRandomPowers method under SuperHero class
         * 
         * @method TestMethodForGenerateRandomPowers
         * @return {void}  
         * </summary>
         */
        [TestMethod]
        public void TestMethodForGenerateRandomPowers()
        {
            //Arrange

            int powerCount = 6;
            //Act
            SuperHero superHero = new SuperHero("Mamun");
            int actualPowerCount = superHero.GenerateRandomPowers();
            //Assert
            Assert.AreEqual(powerCount, actualPowerCount);

        }


    }//end calss
}//end namespace

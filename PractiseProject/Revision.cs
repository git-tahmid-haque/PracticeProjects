using System;
using System.Collections.Generic;
using System.Text;

// Things I need to revise/learn:
//  - DateTime class
//  - Arrays and Lists
//  - String manipulation
//  - Methods
//  - Interfaces
//  - Any other advanced topics found on Udemy course

namespace PractiseProject
{
    /*This is a standard class that demonstrates the concept of OOP*/
    public class Revision
    {
        /*PRIVATE VARIABLES*/
        //These are the most commonly used variables
        private int intVariable; //Use all the time if you can
        private float floatVariable; //Don't use these because of the lack of precision when rounding
        private double doubleVariable; //Use these if you have to for non-monetary decimal values
        private decimal decimalVariable; //Use these for money
        private string stringVariable; //String of characters
        private char charVariable; //Single character
        private bool booleanVariable; //Can be either true or false

        /*CONSTRUCTORS*/
        //You can have multiple constructors for the same class which require different parameters
        //Usually, you will pass the parameters to the properties below, rather than assign them directly to the variables
        public Revision(int intV, float floatV, double doubleV, decimal decimalV, string stringV, char charV, bool booleanV)
        {
            IntVariable = intV;
            FloatVariable = floatV;
            DoubleVariable = doubleV;
            DecimalVariable = decimalV;
            StringVariable = stringV;
            CharVariable = charV;
            booleanVariable = booleanV;
        }

        //This constructor requires no parameters to be passed when creating an instance of the class
        public Revision()
        {

        }
        
        /*PROPERTIES*/
        //These control access to the private variables within the class
        //You can add logic to control what the variables can be set and what they return
        public int IntVariable
        {
            get
            {
                return intVariable;
            }
            set
            {
                intVariable = value;
            }
        }

        public float FloatVariable
        {
            get
            {
                return floatVariable;
            }
                  set
            {
                floatVariable = value;
            }
        }

        public double DoubleVariable
        {
            get
            {
                return doubleVariable;
            }
            set
            {
                doubleVariable = value;
            }
        }

        public decimal DecimalVariable
        {
            get
            {
                return decimalVariable;
            }
            set
            {
                decimalVariable = value;
            }
        }

        public string StringVariable
        {
            get
            {
                return stringVariable;
            }
            set
            {
                stringVariable = value;
            }
        }

        public char CharVariable
        {
            get
            {
                return charVariable;
            }
            set
            {
                charVariable = value;
            }
        }

        public bool BooleanVariable
        {
            get
            {
                return booleanVariable;
            }
            set
            {
                booleanVariable = value;
            }
        }

        /*METHODS*/
        public static void AddOneValue(int number)
        {
            number++;
        }

        public static void AddOneRef(ref int number)
        {
            number++;
        }
    }
}

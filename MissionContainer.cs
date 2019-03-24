using System;
using System.Collections.Generic;


namespace Excercise_1
{
    /*delegate func - the math function - get and return double*/
    public delegate double func(double val);
    /*function container - using dictionary of string and func*/
    public class FunctionsContainer
    {
        /*dictionary of the mission name and the function*/
        private Dictionary<string, func> dict;

        /*function container constructor - initialize the dictionary*/ 
        public FunctionsContainer()
        {
            dict = new Dictionary<string, func>();
        }
        /*initialize the dictionary*/
        public func this[string key]
        {
            get
            {
                if (!this.dict.ContainsKey(key)) {
                    this.dict[key] = value => value;
                }
                return this.dict[key];
            }
            set
            {
                // check if contains the key and just change the value
                if (dict.ContainsKey(key))
                {
                    dict[key] = value;
                }
                //if the key isn't exist - add the key and the value
                else
                {
                    dict.Add(key, value);
                }
            }
        }
        /*return list of all the mission names (the keys)*/
        public List<string> getAllMissions()
        {
            return new List<string>(this.dict.Keys); //return the list with all the keys
        }


    }
}

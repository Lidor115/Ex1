using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                this.dict[key] = value;
            }
        }
        /*return list of all the mission names (the keys)*/
        public List<string> getAllMissions()
        {
            return new List<string>(this.dict.Keys);
        }


    }
}

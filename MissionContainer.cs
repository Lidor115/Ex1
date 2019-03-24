using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double func(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, func> dict;
        public FunctionsContainer()
        {
            dict = new Dictionary<string, func>();
        }
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
        public List<string> getAllMissions()
        {
            return new List<string>(this.dict.Keys);
        }


    }
}

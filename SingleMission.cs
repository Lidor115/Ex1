using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /*Single mission class - inhirit IMission*/
    public class SingleMission : IMission
    {
        private func function;
        string missionName;
        /*Constructor of Single mission - get a name and function to do*/
        public SingleMission(func f, string mn)
        {
            this.function = f;
            this.missionName = mn;
        }
        /*initialize the name of the mission*/
        public string Name => missionName;
        /*initialize the Type of the mission to Single*/
        public string Type => "Single";
        /*EventHandler of IMission*/
        public event EventHandler<double> OnCalculate;
        /*calculate the mission (use the function and invoke the 
         event handler about the soloution*/
        public double Calculate(double val)
        {
            double newval = this.function(val);
            OnCalculate?.Invoke(this, newval);
            return newval;
        }
    }

}

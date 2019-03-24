using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /*Composed mission class - inhirit IMission*/
    public class ComposedMission : IMission
    {
        private List<func> compList;
        private string missionName;
        /*Constructor of Composed mission - get a name and initialize list*/
        public ComposedMission(string name)
        {
            this.compList = new List<func>();
            this.missionName = name;
        }
        /*add functions to the list of the missions*/
        public ComposedMission Add(func f)
        {
            compList.Add(f);
            return this; 
        }
        /*initialize the name of the mission*/
        public string Name => this.missionName;

        /*initialize the Type of the mission to Composed*/
        public string Type => "Composed";

        /*EventHandler of IMission*/
        public event EventHandler<double> OnCalculate;

        /*calculate the mission (use the functions and invoke the 
         event handler about the soloution*/
        public double Calculate(double value)
        {
            double newVal = value;
            foreach(func f in compList)
            {
                newVal = f(newVal);
            }
            OnCalculate?.Invoke(this, newVal);
            return newVal ;
        }
    }
}

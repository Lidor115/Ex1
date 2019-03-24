using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<func> compList;
        private string missionName; 
        public ComposedMission(string name)
        {
            this.compList = new List<func>();
            this.missionName = name;
        }

        public ComposedMission Add(func f)
        {
            compList.Add(f);
            return this; 
        }
        public string Name => this.missionName;

        public string Type => "Composed";

        public event EventHandler<double> OnCalculate;

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

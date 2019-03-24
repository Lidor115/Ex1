using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private func function;
        string missionName;
       
        public SingleMission(func f, string mn)
        {
            this.function = f;
            this.missionName = mn;
        }

        public string Name => missionName;

        public string Type => "Single";

        public event EventHandler<double> OnCalculate;

        public double Calculate(double val)
        {
            double newval = this.function(val);
            OnCalculate?.Invoke(this, newval);
            return newval;
        }
    }

}

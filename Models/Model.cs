using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Model
    {
        private double budget;
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        private string season;
        public string Season
        {
            get { return season; }
            set { season = value; }
        }
        private string place;
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        private double expenses;
        public double Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }
        private string facility;
        public string Facility
        {
            get { return facility; }
            set { facility = value; }
        }
        public Model(double budget, string season)
        {
            this.budget = budget;
            this.season = season;
            this.place = "";
            this.facility = "";
            this.expenses = 0.0;
        }
        public Model() : this(0, "") {}
        public string DefinePlace()
        {
            if(budget < 100)
            {
                place = "Bulgaria";
            }
            else if(budget >= 100 && budget < 1000) 
            {
                this
                 
            }
        }
    }
}

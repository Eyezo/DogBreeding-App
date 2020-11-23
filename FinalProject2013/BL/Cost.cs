using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject2013.BL
{
   public  class Cost
    {
        private int costId;

        public int CostId
        {
            get { return costId; }
            set { costId = value; }
        }
        private string provider;

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        private double cost;

        public double Cost1
        {
            get { return cost; }
            set { cost = value; }
        }
        private DateTime costDate;

        public DateTime CostDate
        {
            get { return costDate; }
            set { costDate = value; }
        }
        private int dogId;

        public int DogId
        {
            get { return dogId; }
            set { dogId = value; }
        }
       public Cost()
       {
       }
    }
}

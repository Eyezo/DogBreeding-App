using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject2013.BL
{
  public  class Client
    {
        private int clientId;

        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        private string clientName;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        private string clientProvince;

        public string ClientProvince
        {
            get { return clientProvince; }
            set { clientProvince = value; }
        }
        private string clientCity;

        public string ClientCity
        {
            get { return clientCity; }
            set { clientCity = value; }
        }
        private string clientStreetName;

        public string ClientStreetName
        {
            get { return clientStreetName; }
            set { clientStreetName = value; }
        }
        private int clientPostalCost;

        public int ClientPostalCost
        {
            get { return clientPostalCost; }
            set { clientPostalCost = value; }
        }
        private int dogId;

        public int DogId
        {
            get { return dogId; }
            set { dogId = value; }
        }
        private double dogCost;

        public double DogCost
        {
            get { return dogCost; }
            set { dogCost = value; }
        }
      public Client()
      {
      }
    }
}

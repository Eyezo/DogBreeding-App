using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject2013.BL
{
  public  class Mating
    {
        private int matingId;

        public int MatingId
        {
            get { return matingId; }
            set { matingId = value; }
        }
        private DateTime matingDate;

        public DateTime MatingDate
        {
            get { return matingDate; }
            set { matingDate = value; }
        }
        private string matingPartnerName;

        public string MatingPartnerName
        {
            get { return matingPartnerName; }
            set { matingPartnerName = value; }
        }
        private DateTime dateFarrowBorn;

        public DateTime DateFarrowBorn
        {
            get { return dateFarrowBorn; }
            set { dateFarrowBorn = value; }
        }
        private int numberOfDogs;

        public int NumberOfDogs
        {
            get { return numberOfDogs; }
            set { numberOfDogs = value; }
        }
        private int numberOfBitches;

        public int NumberOfBitches
        {
            get { return numberOfBitches; }
            set { numberOfBitches = value; }
        }
        private int totalPuppies;

        public int TotalPuppies
        {
            get { return totalPuppies; }
            set { totalPuppies = value; }
        }
        private int dogId;

        public int DogId
        {
            get { return dogId; }
            set { dogId = value; }
        }
      public Mating()
      {

      }
    }
}

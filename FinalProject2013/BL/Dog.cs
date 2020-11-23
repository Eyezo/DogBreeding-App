using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject2013.BL
{
 public    class Dog
    {
        private int dogId;

        public int DogId
        {//Property Name : property int DogId
            //Purpose : Public property to give access to dogId instance variable
            //Re-use :none
            //Input :int value
            //       -auto generated dogId
            //Output:int
            //       -value stored in dogId instance variable
            get { return dogId; }//end get
            set { dogId = value; }//end set
        }//end property
        private string dogName;

        public string DogName
        {
            get { return dogName; }
            set { dogName = value; }
        }
        private string dogBreed;

        public string DogBreed
        {
            get { return dogBreed; }
            set { dogBreed = value; }
        }
        private DateTime dogDOB;

        public DateTime DogDOB
        {
            get { return dogDOB; }
            set { dogDOB = value; }
        }
        private string dogGender;

        public string DogGender
        {
            get { return dogGender; }
            set { dogGender = value; }
        }
        private string dogFather;

        public string DogFather
        {
            get { return dogFather; }
            set { dogFather = value; }
        }
        private string dogMother;

        public string DogMother
        {
            get { return dogMother; }
            set { dogMother = value; }
        }

      
     //public Dog()
        public Dog()
        {//
         //Method Name :
            //Empty Default Constructor
            //Re-use : none
            //Input none
            //Output : none
        }//end method
    }
}

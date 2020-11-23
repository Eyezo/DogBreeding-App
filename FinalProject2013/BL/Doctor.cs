using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject2013.BL
{
   public  class Doctor
    {
        private int docId;

        public int DocId
        {
            get { return docId; }
            set { docId = value; }
        }
        private string docName;

        public string DocName
        {
            get { return docName; }
            set { docName = value; }
        }
        private string dogType;

        public string DogType
        {
            get { return dogType; }
            set { dogType = value; }
        }
        private DateTime dogCertificate;

        public DateTime DogCertificate
        {
            get { return dogCertificate; }
            set { dogCertificate = value; }
        }
        private string dogId;

        public string DogId
        {
            get { return dogId; }
            set { dogId = value; }
        }




      public Doctor()
      {
      }
    }
}

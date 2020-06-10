using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using System.Diagnostics;

namespace AcmeLanding.Services
{
    public class SerialNumberValidate : ISerialNumber {
        private readonly DataAccess access;
       // DataAccess access = new DataAccess();
        public SerialNumberValidate(DataAccess serials)
        {
            access = serials;
        }
        public bool SerialNumberVali(int number)
        {
            List<int> valid = access.GetSerialsNumbers();
            foreach (var item in valid)
            {
                if (number == item)
                {
                    Debug.WriteLine("Det virker");

                    return true;
                }
            }
            Debug.WriteLine("Det virker ikke");

            return false;
        }
    } 
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using System.Diagnostics;

namespace AcmeLanding.Services
{
    public class SerialNumberValidate : ISerialNumber {
        private  readonly ClassLibrary.Acme_CorporationContext _context;
      //  DataAccess access = new DataAccess(_context);
       private readonly DataAccess _data;
      
        public bool SerialNumberVali(int number)
        {
            List<int> valid = _data.GetSerialsNumbers();
            foreach (var item in valid)
            {
                if (number == item)
                {

                    return true;
                }
            }

            return false;
        }
    } 
}


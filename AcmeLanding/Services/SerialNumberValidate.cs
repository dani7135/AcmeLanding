using ClassLibrary;
using System.Collections.Generic;
using System.Diagnostics;

namespace AcmeLanding.Services
{
    public class SerialNumberValidate : ISerialNumber
    {
        private readonly DataAccess _data;
        // DataAccess access = new DataAccess();
        public SerialNumberValidate(DataAccess access)
        {
            _data = access;
        }
        public bool SerialNumberVali(int number)
        {
            List<int> valid = _data.GetSerialsNumbers();
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


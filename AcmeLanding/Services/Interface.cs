using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeLanding.Services
{
    interface Interface
    {
    }
    public interface ISerialNumber
    {
        bool SerialNumberVali(int number);
    }
    public interface IAgeValidate
    {
        bool IsValid(int Min, int Max);
      //  string FormatErrorMessage(string name);
    }
}

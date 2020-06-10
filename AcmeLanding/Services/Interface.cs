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
    public interface IAge
    {
        bool IsValid(int value);
        string FormatErrorMessage(string name);
    }
}

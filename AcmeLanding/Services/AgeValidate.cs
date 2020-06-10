using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.Edm.Validation;
using ClassLibrary;
using System.Globalization;

namespace AcmeLanding.Services
{
    public class AgeValidate : ValidationAttribute, IAgeValidate
    {
        private readonly DataAccess _data;
        public AgeValidate(DataAccess access)
        {
            _data = access;
        }
        public int Min { get; }
        public int Max { get; }

        public bool IsValid(int Min, int Max)
        {

            if (Min < 18 || Max > 102)
            {
                 return false;

            }
            return true;
        }

    }
}

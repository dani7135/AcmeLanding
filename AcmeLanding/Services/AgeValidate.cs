﻿using System;
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
        public int Min = 18;
        public int Max = 102;
      //  int age = 0;


        public bool IsValid(int age)
        {
            if (age < 18)
            {
                 return false;

            }
            return true;
        }

    }
}

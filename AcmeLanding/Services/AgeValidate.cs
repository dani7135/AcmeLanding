using System.ComponentModel.DataAnnotations;

namespace AcmeLanding.Services
{
    public class AgeValidate : ValidationAttribute, IAgeValidate
    {

        public int Min { get; }
        public int Max { get; }

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

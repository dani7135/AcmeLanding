using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary
{
    public class DataAccess
    {
        readonly string textFile = @"SerialNumber.txt";
        public Acme_CorporationContext Acme_;
        public DataAccess(Acme_CorporationContext corporationContext)
        {
            Acme_ = corporationContext;
        }

        public List<int> GetSerialsNumbers()
        {
            List<int> serialNumberValidate = new List<int>();
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {
                    string rl;
                    while ((rl = file.ReadLine()) != null)
                    {
                        serialNumberValidate.Add(Convert.ToInt32(rl));
                    }

                    file.Close();
                }
            }
            return serialNumberValidate;

        }

        /*    public List<Submission_Model>GetSubmissions()
            {
                return Acme_.Submission_Model.ToList();
            }
           */
    }
}

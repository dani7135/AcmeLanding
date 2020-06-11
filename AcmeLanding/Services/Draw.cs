using System.ComponentModel.DataAnnotations;

namespace AcmeLanding.Services
{
    public class Draw : ValidationAttribute, IDraw
    {
        private readonly Data.Acme_CorporationContext _context;

        /* DataAccess data = new DataAccess(corporationContext);
         public Submission_Model Draws()
         {
             var ran = new Random();
             List<Submission_Model> submission_s =data.GetSubmissions();
             int index = ran.Next(submission_s.Count);
             Submission_Model submission = submission_s[index];

             return submission;
         }*/
        public bool WinnerOrNot(int number)
        {

            if (number > 1)
            {
                return false;
            }
            return true;
        }

        public bool Winner(int draw)
        {
            if (draw < 2)
            {
                return false;
            }
            return true;
        }
    }
}

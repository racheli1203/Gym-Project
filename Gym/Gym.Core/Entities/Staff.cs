using System.ComponentModel.DataAnnotations;

namespace Gym
{
    public class Staff
    {
        [Key]
        public int workerNumber { get; set; }
        public int id { get;  set; } 
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public string position { get; set; }
    }
}

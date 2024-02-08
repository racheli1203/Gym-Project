using System.ComponentModel.DataAnnotations;

namespace Gym
{
    public class Subscribers
    {
        [Key]
        public int subscriptionNumber { get; set; }
        public int idSubscriber { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime startSubscripion { get; set; }
        public DateTime endSubscripion { get; set; }
        public string status { get; set; }
    }
}

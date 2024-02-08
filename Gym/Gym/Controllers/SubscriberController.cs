using Gym.Core.Models;
using Gym.Core.ServicesModels;
using Gym.Servies.ServiesRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {

        private readonly ISubscriberService _subscriberServies;
        public SubscriberController(ISubscriberService subscriberServies)
        {
            _subscriberServies = subscriberServies;
        }
        // GET: api/<SubscriptionsController>
        [HttpGet]
        public IEnumerable<Subscribers> Get()
        {
            return _subscriberServies.GetSubscriber();
        }

        // GET api/<SubscriptionsController>/5
        [HttpGet("{subscriptionNumber}")]
        public Subscribers Get(int subscriptionNumber)
        {
           return _subscriberServies.GetById(subscriptionNumber);
        }

        // POST api/<SubscriptionsController>
        [HttpPost]
        public void Post([FromBody] Subscribers newSubscriber)
        {
             _subscriberServies.ServicePost(newSubscriber);
        }

        // PUT api/<SubscriptionsController>/5
        [HttpPut("{subscriptionNumber}")]
        public Subscribers Put(int subscriptionNumber, [FromBody] Subscribers value)
        {
             _subscriberServies.ServicePut(subscriptionNumber, value);
             return value;
            //Subscribers foundsub = _subscriberServies.GetSubscriber().Find(s => s.subscriptionNumber == subscriptionNumber);
            //if (foundsub != null)
            //{
            //    foundsub.id = foundsub.id;
            //    foundsub.phone = foundsub.phone;
            //    foundsub.email = value.email;
            //    foundsub.name = value.name;
            //    foundsub.status = value.status;
            //    foundsub.dateOfBirth = value.dateOfBirth;
            //    foundsub.endSubscripion = value.endSubscripion;
            //    foundsub.startSubscripion = value.startSubscripion;

            //}
            //return foundsub;

        }

       
    }
}

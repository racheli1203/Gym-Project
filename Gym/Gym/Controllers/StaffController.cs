using Gym.Core.ServicesModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staff;
        public StaffController(IStaffService context)
        {
            _staff = context;
        }
       
        private static int IdCount = 4;

        // GET: api/<StaffController>
        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return _staff.GetStaff();
        }

        // GET api/<StaffController>/5
        [HttpGet("{workerNumber}")]
        public Staff Get(int workerNumber)
        {
            //Staff foundWorker = _staff.GetStaff().Find(t => t.id == id);
            //if (foundWorker == null)
            //    return null;
            return _staff.GetStaffId(workerNumber);
        }
        // GET api/<StaffController>/5
        [HttpGet("getbytype/{position}")]
        public IEnumerable<Staff> Get(string position)
        {
            return _staff.GetPosition(position);
        }
      

        // POST api/<StaffController>
        [HttpPost]
        public void Post([FromBody] Staff newWorker)
        {
             _staff.ServicePost(newWorker);
                                                                                                                                                                                                                                                                                                                                                                                       

        }

        // PUT api/<StaffController>/5
        [HttpPut("{workerNumber}")]
        public Staff Put(int workerNumber, [FromBody] Staff updateWorker)
        {
             _staff.ServicePut(workerNumber, updateWorker);
            return updateWorker;
        }
    
    }
}

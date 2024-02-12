using Gym.Core.Models;
using Gym.Core.ServicesModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equipmentController : ControllerBase
    {
        
        private readonly IEquipmentService _equipment;
        public equipmentController(IEquipmentService context)
        {
            _equipment = context;
        }
        private static int IdCount = 4;


        // GET: api/<equipmentController>
        [HttpGet]
        public ActionResult<gymEquipment> Get()
        {
            var list= _equipment.GetEquipment();
            return Ok(list);
        }

        // GET api/<equipmentController>/5
        [HttpGet("{id}")]
        public gymEquipment Get(int id)
        {
            return _equipment.GetEquipmentId(id);
            //gymEquipment equipment = _equipment.GetEquipment().Find(e => e.id == id);
            //if (equipment == null)
            //    return null;
            //return equipment;
        }

        // POST api/<equipmentController>
        [HttpPost]
        public gymEquipment Post([FromBody] gymEquipment newEquipment)
        {
            _equipment.PostEquipment(newEquipment);
            return  newEquipment;
            //_equipment.GetEquipment().Add(new gymEquipment { id = IdCount, name = newEquipment.name, dateOfInspection = newEquipment.dateOfInspection, category = newEquipment.category, frequencyOfTesting = newEquipment.frequencyOfTesting, expiryDate = newEquipment.expiryDate });
            //IdCount++;
            //return _equipment.GetEquipment()[_equipment.GetEquipment().Count - 1];
        }

      

        // PUT api/<equipmentController>/5
        [HttpPut("{id}")]
        public gymEquipment Put(int id, [FromBody] gymEquipment value)
        {
             _equipment.PutEquipment(id, value);
            return value;
        }
        // DELETE api/<EquipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Equipment foundEq = _equipmentService.GetEquipment().Find(e => e.Id == id);
            //if(foundEq != null)
            //    _equipmentService.GetEquipment().Remove(foundEq);  
            _equipment.DeleteEquipment(id);
        }


    }
}

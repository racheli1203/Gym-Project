using Gym.Core.Models;
using Gym.Core.ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Servies.ServiesRepository
{
    public class EquipmentServies: IEquipmentService
    {
        private static int IdCount = 1;

        private readonly IEquipment _equipment;
        public EquipmentServies(IEquipment equipment)
        {
            _equipment = equipment;
        }
        public IEnumerable<gymEquipment> GetEquipment()
        {
            return _equipment.GetAllEquipment();
        }

        public gymEquipment GetEquipmentId(int id)
        {
            gymEquipment equipment = _equipment.GetAllEquipment().ToList().Find(e => e.id == id);
            return equipment;
          
        }


        public void PostEquipment(gymEquipment value)
        {
            _equipment.DataPost(value);
        }

        public void PutEquipment(int id, gymEquipment value)
        {
            int index = _equipment.GetAllEquipment().ToList().FindIndex(( e) =>  e.id == id );
            _equipment.GetAllEquipment().ToList()[index].name = value.name;
            _equipment.GetAllEquipment().ToList()[index].dateOfInspection = value.dateOfInspection;
            _equipment.GetAllEquipment().ToList()[index].category = value.category;
            _equipment.GetAllEquipment().ToList()[index].frequencyOfTesting = value.frequencyOfTesting;
            _equipment.GetAllEquipment().ToList()[index].expiryDate = value.expiryDate;
             _equipment.DataPut(index, value);
        }

        public void DeleteEquipment(int id)
        {
            int index = _equipment.GetAllEquipment().ToList().FindIndex(e => e.id == id);
            if(index != -1)
            {
                _equipment.DataDeleteEquipment(index);
            }

        }


    }
}

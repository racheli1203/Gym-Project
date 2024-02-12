using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.ServicesModels
{
    public interface IEquipmentService
    {
        public IEnumerable<gymEquipment> GetEquipment();

        public gymEquipment GetEquipmentId(int id);

        public void PostEquipment(gymEquipment newEquipment);

        public void PutEquipment(int id, gymEquipment value);


        public void DeleteEquipment(int id);

        //void PostEquipment(gymEquipment value);


    }
}

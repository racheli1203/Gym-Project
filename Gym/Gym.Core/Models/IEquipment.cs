using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Models
{
    public interface IEquipment
    {
        public  List<gymEquipment> GetAllEquipment();

        public void DataPost(gymEquipment value);

        public void DataPut(int index, gymEquipment value);

        public void DataDeleteEquipment(int index);


    }
}

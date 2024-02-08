using Gym.Core.Models;
using Gym.Data.DataContext;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.DataRepository
{
    public class EquipmenRepository: IEquipment
    {
        private readonly GymData _context;
        public EquipmenRepository(GymData equipmentData)
        {
            _context = equipmentData;
        }
        public  List<gymEquipment> GetAllEquipment()
        {
            return _context.equipments.ToList();
        }

        public void DataPost(gymEquipment value)
        {
            _context.equipments.Add(value);
            _context.SaveChanges();
        }
        public void DataPut(int index, gymEquipment value)
        {
            _context.equipments.ToList()[index] = value;
            _context.SaveChanges();
        }

        public void DataDeleteEquipment(int index)
        {
            _context.Remove(_context.equipments.ToList()[index]);
            _context.SaveChanges();
        }







    }
}

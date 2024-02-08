using Gym.Core.Models;
using Gym.Data.DataContext;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.DataRepository
{
    public class StaffRepository:IStaff
    {
        private readonly GymData _staffContext;
        public StaffRepository(GymData staffData)
        {
            _staffContext = staffData;
        }
        public  List<Staff> GetAllStaff()
        {
            return _staffContext.Staffs.ToList();
        }
        public void DataPost( Staff newWorker)
        {
            _staffContext.Staffs.Add(newWorker);
            _staffContext.SaveChanges();
        }
        public void DataPut(int index, Staff updateWorker)
        {
            _staffContext.Staffs.ToList()[index] = updateWorker;
            _staffContext.SaveChanges();

        }






    }
}

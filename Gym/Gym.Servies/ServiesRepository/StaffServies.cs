using Gym.Core.Models;
using Gym.Core.ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Servies.ServiesRepository
{
    public class StaffServies: IStaffService
    {
        private static int IdCount = 1;
        private readonly IStaff _staff;
        public StaffServies(IStaff staff)
        {
            _staff = staff;
        }
        public List<Staff> GetStaff()
        {
            return _staff.GetAllStaff();
        }
        public Staff GetStaffId(int workerNumber)
        {
            Staff foundWorker = _staff.GetAllStaff().Find(t => t.workerNumber == workerNumber);
            if (foundWorker == null)
                return null; 
            return foundWorker;
        }
        public List<Staff> GetPosition(string position)
        {
            var foundpos = _staff.GetAllStaff().Where(t => t.position == position).ToList();
            if (foundpos == null)
                return null;
            return foundpos;
        }
        public void ServicePost(Staff newWorker)
        {
            _staff.DataPost(newWorker);

        }
        public void ServicePut(int workerNumber,  Staff updateWorker)
        {
            int index = _staff.GetAllStaff().FindIndex(( w) =>  w.workerNumber == workerNumber);
            _staff.GetAllStaff()[index].name = updateWorker.name;
            _staff.GetAllStaff()[index].dateOfBirth = updateWorker.dateOfBirth;
           // _staff.GetAllStaff()[index].workerNumber = updateWorker.workerNumber;
            _staff.GetAllStaff()[index].phone = updateWorker.phone;
            _staff.GetAllStaff()[index].address = updateWorker.address;
            _staff.GetAllStaff()[index].email = updateWorker.email;
            _staff.GetAllStaff()[index].position = updateWorker.position;
            _staff.DataPut(index, updateWorker);
        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.ServicesModels
{
    public interface IStaffService
    {
        List<Staff> GetStaff();

        public Staff GetStaffId(int id);

        public List<Staff> GetPosition(string position);

        public void ServicePost(Staff newWorker);

        public void ServicePut(int id, Staff updateWorker);





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Models
{
    public interface IStaff
    {
        public  List<Staff> GetAllStaff();

        public void DataPost(Staff newWorker);

        public void DataPut(int index, Staff updateWorker);





    }
}

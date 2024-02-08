using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Models
{
    public interface ISubscriber
    {
        public  List<Subscribers> GetAllSubscriber();

        public void DataPost(Subscribers newSubscriber);

        public void DataPut(int index, Subscribers value);

    }
}

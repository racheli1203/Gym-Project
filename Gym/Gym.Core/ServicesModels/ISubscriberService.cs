using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.ServicesModels
{
    public interface ISubscriberService
    {
        List<Subscribers> GetSubscriber();

        public Subscribers GetById(int subscriptionNumber);

        public void ServicePost(Subscribers newSubscriber);

        public void ServicePut(int subscriptionNumber, Subscribers value);


    }
}

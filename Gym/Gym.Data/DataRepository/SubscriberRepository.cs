using Gym.Core.Models;
using Gym.Data.DataContext;
using Gym.Servies.ServiesRepository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.DataRepository
{
    public class SubscriberRepository:ISubscriber
    {
        private readonly GymData _subscriberData;

        public SubscriberRepository(GymData subscriberData)
        {
            _subscriberData = subscriberData;
        }
        public  List<Subscribers> GetAllSubscriber()
        {
            return _subscriberData.subscribers.ToList();
        }
        public void DataPost(Subscribers newSubscriber)
        {
            _subscriberData.subscribers.Add(newSubscriber);
            _subscriberData.SaveChanges();


        }
        public void DataPut(int index, Subscribers value)
        {
            _subscriberData.subscribers.ToList()[index] = value;
            _subscriberData.SaveChanges();
        }



    }
}

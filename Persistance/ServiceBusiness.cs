using Abacode.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abacode.Persistance
{
    public class ServiceBusiness : IServiceBusiness
    {
        public object CreateService(ServiceDto book)
        {
            throw new NotImplementedException();
        }

        public object EditService(Guid id, EditServiceDto bookDto)
        {
            throw new NotImplementedException();
        }

        public object GetService(int id)
        {
            throw new NotImplementedException();
        }

        public object GetServices(Filter filter)
        {
            throw new NotImplementedException();
        }
    }
}

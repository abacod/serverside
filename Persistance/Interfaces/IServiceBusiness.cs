using Abacode.Controllers;
using System;

namespace Abacode.Persistance
{
    public interface IServiceBusiness
    {
        object GetServices(Filter filter);
        object CreateService(ServiceDto book);
        object EditService(Guid id, EditServiceDto bookDto);
        object GetService(int id);
    }
}
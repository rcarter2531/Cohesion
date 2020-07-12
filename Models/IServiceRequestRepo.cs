
using System;
using System.Linq;

using System.Collections.Generic;
namespace CohesionCodingDemo.Models
{
    public interface IServiceRequestRepo
    {
        public GetServiceRequest(string Id);

        public List<ServiceRequest> GetServiceRequests();

        public ServiceRequest AddServiceRequest(ServiceRequest Id);

        public ServiceRequest UpdateServiceRequest(string Id, ServiceRequest ServiceRequestItem);

        public string DeleteServiceRequest(string Id);

    }
}

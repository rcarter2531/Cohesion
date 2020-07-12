using System;
using System.Linq;

using System.Collections.Generic;

namespace CohesionCodingDemo.Models
{
    public class MockServiceRequestRepo : IServiceRequestRepo

    {
        private List<ServiceRequest> _serviceRequestList;

       

        public MockServiceRequestRepo()
        {
            _serviceRequestList = new List<ServiceRequest>();
        }

        public List<ServiceRequest> GetServiceRequests()
        {
            return _serviceRequestList;
        }

        public ServiceRequest GetServiceRequest(string Id)
        {
            return _serviceRequestList.FirstOrDefault(e => e.Id == Id);
        }

        public ServiceRequest AddServiceRequest(ServiceRequest ServiceRequestItem)
        {
            _serviceRequestList.Add(ServiceRequestItem);
            return ServiceRequestItem;
        }

        public ServiceRequest UpdateServiceRequest(string id, ServiceRequest ServiceRequestItem)
        {
            for (var index = _serviceRequestList.Count - 1; index >= 0; index--)
            {
                if (_serviceRequestList[index].Id == id)
                {
                    _serviceRequestList[index] = ServiceRequestItem;
                }
                // stub out code to fire off email when status changes
                if (_serviceRequestList[index].currentStatus != ServiceRequestItem.currentStatus)
                {
                    //call our email service here.
                }

            }
            return ServiceRequestItem;
        }

        public string DeleteServiceRequest(string id)
        {
            for (var index = _serviceRequestList.Count - 1; index >= 0; index--)
            {
                if (_serviceRequestList[index].Id == id)
                {
                    _serviceRequestList.RemoveAt(index);
                }
            }

            return id;
        }
    }
}


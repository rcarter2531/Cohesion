using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CohesionCodingDemo.Models;

namespace CohesionCodingDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceRequestController
    {
        private ILogger _logger;
        private IServiceRequestRepo _service;

        public ServiceRequestController(ILogger<ServiceRequestController> logger, IServiceRequestRepo service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/servicerequest")]
        public ActionResult<List<ServiceRequest>> GetServiceRequests()
        {
            return _service.GetServiceRequests();
        }

        [HttpGet("/api/servicerequest")]
        public ActionResult<List<ServiceRequest>> GetServiceRequest(string id, ServiceRequest servicerequest)
        {
            return _service.GetServiceRequest();
        }

        [HttpPost("/api/servicerequest")]
        public ActionResult<ServiceRequest> AddServiceRequest(ServiceRequest servicerequest)
        {
            _service.AddServiceRequest(ServiceRequest);
            return servicerequest;
        }

        [HttpPut("/api/servicerequest/{id}")]
        public ActionResult<ServiceRequest> UpdateServiceRequest(string id, ServiceRequest servicerequest)
        {
            _service.UpdateServiceRequest(id, ServiceRequest);
            return servicerequest;
        }

        [HttpDelete("/api/servicerequest/{id}")]
        public ActionResult<string> DeleteProduct(string id)
        {
            _service.DeleteServiceRequest(id);
            
            return id;
        }

        public ServiceRequestController()
        {
        }
    }
}

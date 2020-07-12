using System;
namespace CohesionCodingDemo.Models
{
    public class ServiceRequest
    {
            public string Id { get; set; }
            public string buildingCode { get; set; }
            public string description { get; set;}
            public string currentStatus { get; set;}
            public string createdBy { get; set;}
            public DateTime createdDate { get; set; }
            public DateTime lastModifiedDate { get; set; }
       
    }
}

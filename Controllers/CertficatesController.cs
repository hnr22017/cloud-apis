using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace cloud_apis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CertificatesController : ControllerBase
    {
     
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IEnumerable<Certificates> Certificates()
        {
           List<Certificates> list = new List<Certificates>();

            Certificates obj1 = new Certificates();
            obj1.Id =100;
             obj1.Name = "Test Certificate";
            list.Add(obj1);

            return Enumerable.Range(1, 2).Select(index => new Certificates
            {
                Name = "Test Certificate" + index,
                Id =  100 + index,

            })
             .ToArray();
        }
    }
    }
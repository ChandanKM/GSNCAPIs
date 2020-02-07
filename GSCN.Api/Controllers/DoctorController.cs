using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSCN.BusinessLayer;
using GSCN.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GSCN.Api.Controllers
{
    [Route("api/Doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorServices doctorService;

        public DoctorController(DoctorServices _service)
        {
            this.doctorService = _service;
        }

        
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/Doctor/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Doctor
        [HttpPost]
        public void Post(DtoDoctor doctor)
        {

        }

        // PUT: api/Doctor/5
        [HttpPut("{id}")]
        public void Put(int id, DtoDoctor doctor)
        {

        }

        // DELETE: api/Doctor/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}
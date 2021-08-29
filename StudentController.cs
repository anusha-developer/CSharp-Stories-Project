using Stories.BussinessLayer;
using Stories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Stories.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/student")]
        public List<StudentModel> GetStudentModels()
        {
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            return studentBusinessLayer.GetStudentModel();

        }

        // GET: api/Student
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        [HttpPost]
        [Route("api/SaveData")]
        public string SaveStudentData(StudentModel student)
        {
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            return StudentBusinessLayer.SaveStudentData(student);
        }



        // PUT: api/Student/5

        [HttpPut]
        [Route("api/UpdateData")]
        public string UpdateStudentData([FromBody] StudentModel student)
        {
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            return StudentBusinessLayer.UpdateStudentData(student);
        }



        // DELETE: api/Student/5
        [HttpDelete]
        [Route("api/DeleteData")]
        public string DeleteStudentData(int Id)
        {
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            return StudentBusinessLayer.DeleteStudentData(Id);
        }

    }



}
    

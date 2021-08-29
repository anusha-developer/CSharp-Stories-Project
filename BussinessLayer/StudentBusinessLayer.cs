using Stories.Models;
using Stories.RepositaryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Stories.BussinessLayer
{
    public class StudentBusinessLayer
    {
        public List<StudentModel> GetStudentModel()
        {
            StudentRepositoryLayer studentRepository = new StudentRepositoryLayer();
            return studentRepository.GetStudentData();
        }
        public static string SaveStudentData(StudentModel student)
        {

            StudentRepositoryLayer studentRepository = new StudentRepositoryLayer();

            return studentRepository.SaveStudentData(student);
        }

        public static string UpdateStudentData(StudentModel student)
        {
            StudentRepositoryLayer studentRepository = new StudentRepositoryLayer();

            return studentRepository.UpdateStudentData(student);
        }
        public static string DeleteStudentData(int Id)
        {

            StudentRepositoryLayer studentRepository = new StudentRepositoryLayer();

            return studentRepository.DeleteStudentData(Id);

        }

    }


}

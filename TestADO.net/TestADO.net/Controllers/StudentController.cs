using Microsoft.AspNetCore.Mvc;
using TestADOnet.BOL;
using TestADOnet.BLL;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestADOnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        [EnableCors]
        public IEnumerable<Student> Get()
        {
            List<Student> students = new List<Student>();
            students = StudentManager.GetAllStudents();
            return students;
        }

        // get api/<valuescontroller>/5
        [HttpGet("{id}")]
        [EnableCors]
        public Student get(int id)
        {
            Student student= new Student();
            student = StudentManager.GetStudent(id);
            return student;
        }

        // post api/<valuescontroller>
        [HttpPost]
        [EnableCors]
        public void post(Student newStudent)
        {
            StudentManager.AddStudent(newStudent);
        }

        // put api/<valuescontroller>/5
        [HttpPut]
        [EnableCors]
        public void put(Student student)
        {
            StudentManager.Update(student);
        }

        // delete api/<valuescontroller>/5
        [HttpDelete("{id}")]
        [EnableCors]
        public void delete(int id)
        {
            StudentManager.DeleteStudent(id);
        }
    }
}

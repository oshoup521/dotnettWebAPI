using TestADOnet.DAL;
using TestADOnet.BOL;

namespace TestADOnet.BLL
{
    public static class StudentManager
    {
        public static List<Student> GetAllStudents() { 
            List<Student> studentList = new List<Student>();
            studentList = DBManager.GetStudents();
            return studentList;
        }

        public static Student GetStudent(int id)
        {
            Student student = new Student();
            student = DBManager.GetStudent(id);
            return student;
        }

        public static void AddStudent(Student newStudent)
        {
            DBManager.Insert(newStudent);
        }

        public static void DeleteStudent(int id) { 
            DBManager.Delete(id); 
        }

        public static void Update(Student student) {
            DBManager.Update(student);
        }

    }
}

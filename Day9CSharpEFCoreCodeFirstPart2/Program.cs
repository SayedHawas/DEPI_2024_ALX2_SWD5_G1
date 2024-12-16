using Day9CSharpEFCoreCodeFirstPart2.Models;
using Microsoft.EntityFrameworkCore;
namespace Day9CSharpEFCoreCodeFirstPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //CRUD 
            //Insert 

            //1- Instance DbContext Class Inherit
            //using (DbSchool db = new DbSchool())
            //{
            //    //DbSchool db = new DbSchool();
            //    //2 Call Entity DbSet Add (Entry Row == > Object From Class )
            //    db.Students.Add(new Student() { Name = "Ahmed Ali", Age = 25, EnrollmentDate = DateTime.Now });
            //    //3 Save All Changes on DbSets 
            //    db.SaveChanges();
            //    Console.WriteLine("Saving Done ....");
            //}
            //using (DbSchool db = new DbSchool())
            //{
            //    //2 Call Entity DbSet Add (Entry Row == > Object From Class )
            //    db.Students.Add(new Student() { Name = "tamer Ali", Age = 30, EnrollmentDate = DateTime.Now });
            //    //3 Save All Changes on DbSets 
            //    db.SaveChanges();
            //    Console.WriteLine("Saving Done ....");
            //}

            // Select  LINQ 
            //DbSchool db = new DbSchool();
            //var students = db.Students.ToList();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($" ID :{student.Id}  Name : {student.Name} Age {student.Age} EnrollDate : {student.EnrollmentDate}");
            //}

            StudentCRUD stuCRUD = new StudentCRUD();
            //stuCRUD.Update(new Student() { Id = 2, Name = "Yasser Mohamed", Age = 35, EnrollmentDate = DateTime.Now });

            //var show = stuCRUD.GetStudentGreaterThanAge(15);
            //foreach (var student in show)
            //{
            //    Console.WriteLine($" ID :{student.Id}  Name : {student.Name} Age {student.Age} EnrollDate : {student.EnrollmentDate}");
            //}
            stuCRUD.Delete(2);

            Console.ReadLine();
        }

    }

    public interface IEntityCRUD<T>
    {
        void Insert(T newEntity);
        void Update(T newEntity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetStudentByID(int id);
    }

    public class StudentCRUD : IEntityCRUD<Student>
    {
        private readonly DbSchool _db;
        public StudentCRUD()
        {
            _db = new DbSchool();
        }
        public void Delete(int id)
        {
            var deleteStudent = GetStudentByID(id);
            if (deleteStudent != null)
            {
                _db.Students.Remove(deleteStudent);
                _db.SaveChanges();
                Console.WriteLine("Deleted Done ...");
            }
            else
            {
                Console.WriteLine("Not Found ...");
            }
        }
        public IEnumerable<Student> GetAll()
        {
            return _db.Students.ToList();
        }
        public Student GetStudentByID(int id)
        {
            Student student = _db.Students.Where(s => s.Id == id).FirstOrDefault();
            return student;
        }
        public void Insert(Student newEntity)
        {
            _db.Students.Add(newEntity);
            _db.SaveChanges();
            Console.WriteLine("Saving Done ...");
        }
        public void Update(Student newEntity) //2
        {
            //var oldStudent = GetStudentByID(newEntity.Id);
            //var oldStudent = _db.Students.FirstOrDefault(s => s.Id == newEntity.Id);
            var oldStudent = _db.Students.AsNoTracking().FirstOrDefault(s => s.Id == newEntity.Id);
            if (oldStudent != null)
            {
                //oldStudent.Name = newEntity.Name;
                //oldStudent.Age = newEntity.Age;
                //oldStudent.EnrollmentDate = newEntity.EnrollmentDate;
                //_db.SaveChanges();
                //Console.WriteLine("Update Done ...");

                _db.Entry(newEntity).State = EntityState.Modified;
                _db.SaveChanges();
                Console.WriteLine("Update Done ...");
            }
        }
        public IEnumerable<Student> GetStudentGreaterThanAge(int age)
        {
            //IEnumerable vs IQueryable (Database).

            //var result = from student in _db.Students
            //             where student.Age >= age
            //             select student;
            //return result;

            var result2 = _db.Students.Where(s => s.Age >= age);
            return result2;

        }

    }

    //public interface IStudentCRUD
    //{
    //    void Insert(Student newstudent);
    //    void Update(Student newstudent);
    //    void Delete(int id);
    //    IEnumerable<Student> GetAll();
    //    Student GetStudentByID(int id);
    //}
    //public class Techer
    //{ 

    //}
    //public class TecherCRUD : IEntityCRUD<Techer>
    //{
    //    public void Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Techer> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Techer GetStudentByID(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Insert(Techer newEntity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Techer newEntity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

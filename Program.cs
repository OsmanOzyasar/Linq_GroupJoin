namespace Linq_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Classes> classes = new List<Classes>()
            {
                new Classes {ClassName = "Matematik", ClassId = 1},
                new Classes {ClassName = "Türkçe", ClassId = 2},
                new Classes {ClassName = "Kimya", ClassId = 3}
            };

            List<Students> students = new List<Students>()
            {
                new Students {StudentName = "Ayşe", StudentId = 1, Id = 2 },
                new Students {StudentName = "Furkan", StudentId = 2, Id = 2 },
                new Students {StudentName = "İrem", StudentId = 3, Id = 1 },
                new Students {StudentName = "Emir", StudentId = 4, Id = 3 },
                new Students {StudentName = "Uğur", StudentId=5, Id = 3 },
            };



            var gJoinedClass = classes.GroupJoin(students,
                                                 classess => classess.ClassId,
                                                 student => student.Id,
                                                 (studentClass, student) => new
                                                 {
                                                     Student = student.ToList(),
                                                     StudentClass = studentClass
                                                 });

            foreach (var item in gJoinedClass)
            {
                Console.WriteLine($"Sınıf: {item.StudentClass.ClassName}");

                foreach (var x in item.Student)
                {
                    Console.WriteLine($"Öğrenci: {x.StudentName}");
                }
            }
                                                
        }
    }
}
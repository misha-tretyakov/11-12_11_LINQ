namespace Classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SimpleExample

            List<Student> students = new()
            {
                new Student { Name = "Tom", Age = 10, Grade = 7 },
                new Student { Name = "Jerry", Age = 9, Grade = 8 },
                new Student { Name = "Harry Potter", Age = 10, Grade = 6 }
            };

            var result = students
                .Where(s => s.Age > 9)
                .OrderByDescending(s => s.Age)
                .Select(s => s.Name);

            // foreach (var student in students)
            // {
            //     Console.WriteLine(student.Name);
            // }

            #endregion
        }
    }
}

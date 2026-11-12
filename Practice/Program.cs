namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Завдання 1
            // Для масиву цілих реалізуйте такі запити:
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Отримати весь масив цілих;
            var returnArr = list.Select(n => n);
            // Отримати парні цілі;
            var returnEven = list.Where(n => n % 2 == 0);
            // Отримати непарні цілі;
            var returnOdd = list.Where(n => n % 2 != 0);
            // Отримати значення більше заданого;
            Console.WriteLine("enter num: ");
            int num = int.Parse(Console.ReadLine());
            var returnBiggerThan = list.Where(n => n > num);
            // Отримати числа в заданому діапазоні;
            Console.WriteLine("enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2: ");
            int num2 = int.Parse(Console.ReadLine());
            var returnRange = list.Where(n => n > num1 && n < num2);
            // Отримати числа кратні семи. Результат відсортувати за зростанням;
            var temp7 = list.Where(n => n % 7 == 0 && n != 0);
            var return7 = temp7.OrderBy(n => n);
            // Отримати числа кратні восьми. Результат відсортувати за спаданням.
            var temp8 = list.Where(n => n % 8 == 0 && n != 0);
            var return8 = temp8.OrderByDescending(n => n);




            
           // Завдання 2
           // Для масиву рядків, що містять назву міст, реалізуйте такі запити:
           List<string> list2 = new List<string>() { "odessa", "kyiv", "potuzhny-city", "adesa" };
           // Отримати весь масив міст;
           var stringReturnAll = list2.Select(n => n);
           // Отримати міста з довжиною назви, що дорівнює заданій;
           Console.Write("Enter length: ");
           int length = int.Parse(Console.ReadLine());
           var stringReturnSelectedLen = list2.Where(n => n.Length == length);
           // Отримати міста, назви яких починаються з літери A;
           var stringReturnFirstA = list2.Where(n => n[0] == 'A');
           foreach (var item in stringReturnFirstA)
           {
               Console.Write(item + " ");
           }
           Console.WriteLine();
           // Отримати міста, назви яких закінчуються літерою M;
           var stringReturnLastM = list2.Where(n => n[n.Length - 1] == 'M');
           foreach (var item in stringReturnLastM)
           {
               Console.Write(item + " ");
           }
           Console.WriteLine();
           // Отримати міста, назви яких починаються з літери N і закінчуються літерою K;
           var NK = list2.Where(n => n[n.Length - 1] == 'K' && n[0] == 'N');
           foreach (var item in stringReturnLastM)
           {
               Console.Write(item + " ");
           }
           Console.WriteLine();
           
           // Отримати міста назви яких починаються на Ne. Результат відсортувати за спаданням.
           var Ne = list2.Where(n => n[0] == 'N' && n[0] == 'e');
           foreach (var item in stringReturnLastM)
           {
               Console.Write(item + " ");
           }
           Console.WriteLine();
           
           // Завдання 3
           // Реалізуйте тип користувача "Студент". У ньому має бути інформація про ім'я, прізвище, вік, назву навчального закладу.
           List<Schueler> student = new()
           {
               new Schueler
               {
                   Name = "Mischa",
                   LastName = "Tretyakov",
                   Age = 13,
                   School = "Lol"
               },
               
               new Schueler
               {
                   Name = "Vladimir",
                   LastName = "Zelenske",
                   Age = 18,
                   School = "Kvartal 95"
               }
           };
           // Для масиву студентів реалізуйте такі запити:
           // Отримати весь масив студентів;
           var returnAllStudents = student.Select(n => n);
           // Отримати студентів з ім'ям Boris;
           var returnBoris = student.Where(n => n.Name == "Boris");
           // Отримати студентів із прізвищем, яке починається з Bro;
           var returnBro = student.Where(n => n.LastName[0] == 'B' && n.LastName[1] == 'r' && n.LastName[2] == 'o');
           // Отримати студентів, які старші за 19 років;
           var return19 = student.Where(n => n.Age > 19);
           // Отримати студентів, які старше 20 років і молодше 23 років;
           var return2023 = student.Where(n => n.Age > 20 && n.Age < 23);
           // Отримати студентів, які навчаються в MIT;
           var returnMIT = student.Where(n => n.School == "MIT");
           // Отримати студентів, які навчаються в Oxford і їхній вік старший за 18 років. Результат відсортувати за віком за спаданням.
           var tempOx18 = student.Where(n => n.School == "Oxford" && n.Age > 18);
           var returnOx18 = tempOx18.OrderBy(n => n.Age);
           // Завдання 4
           // Для масиву рядків реалізуйте користувацьке сортування.
           // Сортування має працювати за кількістю символів (за зростанням і спаданням).
           // Наприклад, якщо сортування здійснюється за спаданням, потрібно повернути рядки з максимальною довжиною в порядку спадання довжини.
           var sortAscending = list2.OrderBy(n => n.Length);

           foreach (var item in sortAscending)
           {
               Console.WriteLine(item);
           }

           Console.WriteLine();
           
           var sortDescending = list2.OrderByDescending(n => n.Length);

           foreach (var item in sortDescending)
           {
               Console.WriteLine(item);
           }
        }
    }
}
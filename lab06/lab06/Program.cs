using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Name = "Gabriela", Role = "Admin", Age = 21, Marks = null, CreatedAt = new DateTime(2022, 5, 16)
                },
                new User
                {
                    Name = "Miłosz", Role = "Moderator", Age = 29, Marks = null, CreatedAt = new DateTime(2022, 1, 21)
                },
                new User
                {
                    Name = "Roksana", Role = "Teacher", Age = 23, Marks = null, CreatedAt = new DateTime(2022, 9, 10)
                },
                new User
                {
                    Name = "Alex", Role = "Student", Age = 16, Marks = new int[]
                    {   4,
                        4,
                        2,
                        1,
                        4,
                        3 }, CreatedAt = new DateTime(2022, 1, 5)
                },
                new User
                {
                    Name = "Marek", Role = "Student", Age = 25, Marks = new int[]
                    {   1,
                        1,
                        1,
                        5 }, CreatedAt = new DateTime(2022, 2, 4)
                },
                new User
                {
                    Name = "Tomek", Role = "Student", Age = 31, Marks = new int[]
                    {   5,
                        5,
                        5,
                        5,
                        4,
                        6 }, CreatedAt = new DateTime(2022, 11, 5)
                },
                new User
                {
                    Name = "Olek", Role = "Student", Age = 42, Marks = new int[]
                    {   1,
                        2,
                        1,
                        3 }, CreatedAt = new DateTime(2022, 12, 6)
                },
                new User
                {
                    Name = "Damian", Role = "Student", Age = 21, Marks = new int[]
                    { 4,
                        4,
                        4,
                        4 }, CreatedAt = new DateTime(2022, 4, 7)
                },
                new User
                {
                    Name = "Bartek", Role = "Student", Age = 28, Marks = new int[]
                    {   2,
                        2,
                        2,
                        2 }, CreatedAt = new DateTime(2022, 6, 11)
                },
                new User
                {
                    Name = "Karolina", Role = "Student", Age = 25, Marks = new int[]
                    {   2,
                        5,
                        2,
                        1 }, CreatedAt = new DateTime(2022, 11, 9)
                },
                new User
                {
                    Name = "Michał", Role = "Student", Age = 19, Marks = new int[]
                    {   2,
                        5,
                        5,
                        1 }, CreatedAt = new DateTime(2022, 6, 10)
                },
                new User
                {
                    Name = "Oskar", Role = "Student", Age = 18, Marks = new int[]
                    {   1,
                        5,
                        6,
                        1 }, CreatedAt = new DateTime(2022, 7, 11)
                },
                new User
                {
                    Name = "Karol", Role = "Student", Age = 15, Marks = new int[]
                    { 2,
                        4,
                        3,
                        5 }, CreatedAt = new DateTime(2022, 5, 12)
                },
                new User
                {
                    Name = "Dominik", Role = "Student", Age = 17, Marks = new int[]
                    {   4,
                        2,
                        4,
                        2 }, CreatedAt = new DateTime(2022, 2, 13)
                },
                new User
                {
                    Name = "Aga", Role = "Student", Age = 15, Marks = new int[]
                    {   6,
                        1,
                        6,
                        2 }, CreatedAt = new DateTime(2022, 1, 14)
                },
                new User
                {
                    Name = "Adam", Role = "Student", Age = 21, Marks = new int[]
                    {   1,
                        1,
                        2,
                        6 }, CreatedAt = new DateTime(2022, 2, 15)
                },
                new User
                {
                    Name = "Iza", Role = "Student", Age = 18, Marks = new int[]
                    {   5,
                        6,
                        4,
                        6 }, CreatedAt = new DateTime(2022, 7, 11)
                },
                new User
                {
                    Name = "Nicola", Role = "Student", Age = 20, Marks = new int[]
                    {   6,
                        6,
                        6,
                        6 }, CreatedAt = new DateTime(2022, 9, 13)
                },
                new User
                {
                    Name = "Weronika", Role = "Student", Age = 18, Marks = new int[]
                    {   2,
                        4,
                        2,
                        1 }, CreatedAt = new DateTime(2022, 7, 12)
                },
                new User
                {
                    Name = "Filip", Role = "Student", Age = 27, Marks = new int[]
                    {   2,
                        1,
                        4,
                        1 }, CreatedAt = new DateTime(2022, 7, 28)
                },

            };
                Console.WriteLine("\u001b[31m1.Ilość rekordów w tablicy:\u001b[0m");
            Console.WriteLine((from user in users select user).Count());

                Console.WriteLine("\u001b[31m2.Listę nazw użytkowników:\u001b[0m");
            List<string> nazwa = users.Select(user => user.Name).ToList();
             List<string> nazwa2 = (from user in users select user.Name).ToList();

            foreach (string name in nazwa)
            {
                Console.WriteLine(name);
            }
                Console.WriteLine("\u001b[31m3.Posortowanych użytkowników po nazwach:\u001b[0m");
            List<User> uztykownik1 = (from user in users
                                  orderby user.Name
                                  select user).ToList();

            foreach (User user in uztykownik1)
            {
                Console.WriteLine(user.Name);
            }
       
            Console.WriteLine("\u001b[31m4.Listę dostępnych ról użytkowników:\u001b[0m");

                     List<string> roles = users.Select(user => user.Role).Distinct().ToList();

            foreach (string role in roles)
            {
                Console.WriteLine(role);
            }
            Console.WriteLine("\u001b[31m5.Listy pogrupowanych użytkowników po rolach:\u001b[0m");
            List<User> nazwarole = (from user in users orderby user.Role select user).ToList();

            foreach (User user in nazwarole)
            {
                Console.WriteLine(user.Role + " " + user.Name);
            }
            Console.WriteLine("\u001b[31m6.Ilość rekordów, dla których podano oceny :\u001b[0m");

                        var count = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Name);
            Console.WriteLine(count.Count());

            Console.WriteLine("\u001b[31m7.Sumę, ilość i średnią wszystkich ocen studentów:\u001b[0m");


            List<int[]> oceny = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Marks).ToList();

            int suma = 0;
            int iloscocen = 0;


            foreach (int[] abc in oceny)
            {
                foreach (int ocena in abc)
                {
                    iloscocen++;
                    suma += ocena;
                }
            }


            var srednia = (float)(suma / iloscocen);
            Console.WriteLine($"\u001b[31mSuma ocen:\u001b[0m {suma}");

            Console.WriteLine($"\u001b[31mIlosc ocen: \u001b[0m{iloscocen}");

            Console.WriteLine($"\u001b[31mSrednia:\u001b[0m {srednia}");

            Console.WriteLine("\u001b[31mNajlepsza ocenę:\u001b[0m");


            int max = 0;
            foreach (int[] ele in oceny)
            {
                for (int i = 0; i < ele.Length; i++)
                {
                    int temp = ele[i];

                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }

            Console.WriteLine(max);

            Console.WriteLine("\u001b[31m9.Najgorsza ocena\u001b[0m");

            int min = max;
            foreach (int[] ele in oceny)
            {
                for (int i = 0; i < ele.Length; i++)
                {
                    int temp = ele[i];

                    if (temp < max)
                    {
                        min = temp;
                    }
                }
            }
            Console.WriteLine(min);
            Console.WriteLine("\u001b[31m10.Najlepszy student:\u001b[0m");

            List<User> xs = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user).ToList();

            float sum = 0;
            float licznik = 0;

            float sredniamax = 0;
            var uzyt1 = "Nicola";
            foreach (User user in xs)
            {
                foreach (int gc in user.Marks)
                {
                    sum += gc;
                    licznik++;
                }
                float sred = sum / licznik;

                if (sred > sredniamax)
                {
                    sredniamax = sred;
                    uzyt1 = user.Name;
                }

                licznik = 0;
                sum = 0;
            }
            Console.WriteLine($"{uzyt1}" + " " + sredniamax);

            Console.WriteLine("\u001b[31m11.Listę studentów, którzy posiadają conajmniej ocen\u001b[0m");
            int minimin = 100000;
            int licznis = 0;

            foreach (User user in xs)
            {
                foreach (int oc in user.Marks)
                {
                    licznis++;
                }

                if (licznis < minimin)
                {
                    minimin = licznis;
                }

                licznis = 0;

            }

            List<string> names3 = (from user in users where user.Marks?.Length == minimin select user.Name).ToList();
            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("\u001b[31m13.Listę obiektów zawierających tylko nazwę i średnią ocenę\u001b[0m");


            List<User> nazwauzyt5 = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user).ToList();

            int[] srednie = new int[nazwauzyt5.Count];
            int b = 0;
            foreach (User user in nazwauzyt5)
            {

                float srednia2 = (float)user.Marks.Sum() / user.Marks.Length;


                Console.WriteLine(user.Name + " " + $"{srednia2:N2}");
                srednie[b] = (int)srednia2;

            }

           
            Console.WriteLine("\u001b[31m15.Średnią ocenę wszystkich studentów\u001b[0m");

            List<User> uztk = (from user in users where user.Marks != null || user.Marks?.Length > 0 orderby ((float)user.Marks.Sum() / user.Marks.Length) descending select user).ToList();

            foreach (User user in uztk)
            {

                float sr = (float)user.Marks.Sum() / user.Marks.Length;


                Console.WriteLine(user.Name + " " + $"{sr:N2}");

            }

            Console.WriteLine("\u001b[31m16.Listę użytkowników pogrupowanych po miesiącach daty utworzenia:\u001b[0m ");

            List<User> usersSorted = users.OrderByDescending(user => user.CreatedAt).ToList();
            string[] qwer = new string[usersSorted.Count];
            foreach (var user in usersSorted)
            {
                var sss = user.CreatedAt;
                var bbb = user.CreatedAt;

                string my = sss.ToString().Substring(3, 2) + "/" + bbb.ToString().Substring(6, 4);

                Console.WriteLine(my + " " + user.Name);

            }


            Console.WriteLine("\u001b[31m18.Najnowszy studenta\u001b[0m");

            var najnowszy = DateTime.Now;
            foreach (var user in usersSorted)
            {
                if (najnowszy < user.CreatedAt)
                {
                    najnowszy = (DateTime)user.CreatedAt;
                    Console.WriteLine(user.Name + " " + user.CreatedAt);
                }
            }

        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
        public int Age { get; set; }
        public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
        public DateTime? CreatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }

    }
}

﻿using System;
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
            Console.WriteLine("Ilość rekordów w tablicy:");
            Console.WriteLine((from user in users select user).Count());

            Console.WriteLine("-----------------");
            Console.WriteLine("Listę nazw użytkowników:");
            List<string> names = users.Select(user => user.Name).ToList();
            List<string> names2 = (from user in users select user.Name).ToList();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Posortowanych użytkowników po nazwach:");
            List<User> users_1 = (from user in users
                                  orderby user.Name
                                  select user).ToList();

            foreach (User user in users_1)
            {
                Console.WriteLine(user.Name);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Listę dostępnych ról użytkowników:");

            List<string> roles = users.Select(user => user.Role).Distinct().ToList();

            foreach (string role in roles)
            {
                Console.WriteLine(role);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Listy pogrupowanych użytkowników po rolach:");
            List<User> namesbyrole = (from user in users orderby user.Role select user).ToList();

            foreach (User user in namesbyrole)
            {
                Console.WriteLine(user.Role + " " + user.Name);
            }


            Console.WriteLine("-----------------");
            Console.WriteLine("Ilość rekordów, dla których podano oceny :");

            var count = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Name);
            Console.WriteLine(count.Count());


            Console.WriteLine("-----------------");

            Console.WriteLine("Sumę, ilość i średnią wszystkich ocen studentów");


            List<int[]> oceny = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user.Marks).ToList();

            int suma = 0;
            int iloscocen = 0;


            foreach (int[] ele in oceny)
            {
                foreach (int ocena in ele)
                {
                    iloscocen++;
                    suma += ocena;
                }
            }


            var srednia = (float)(suma / iloscocen);
            Console.WriteLine($"Suma ocen {suma}");
            Console.WriteLine($"Ilosc ocen {iloscocen}");
            Console.WriteLine($"Srednia {srednia}");





            Console.WriteLine("-----------------");
            Console.WriteLine("Najlepsza ocenę");


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


            Console.WriteLine("-----------------");
            Console.WriteLine("Najgorsza ocena");

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

            Console.WriteLine("-----------------");
            Console.WriteLine("Najlepszy student:");

            List<User> xs = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user).ToList();

            float sum = 0;
            float licznik = 0;

            float maxsr = 0;
            var name1 = "Nicola";
            foreach (User user in xs)
            {
                foreach (int oc in user.Marks)
                {
                    sum += oc;
                    licznik++;
                }
                float sr = sum / licznik;

                if (sr > maxsr)
                {
                    maxsr = sr;
                    name1 = user.Name;
                }

                licznik = 0;
                sum = 0;
            }
            Console.WriteLine($"{name1}" + " " + maxsr);



            Console.WriteLine("-----------------");
            Console.WriteLine("Listę studentów, którzy posiadają conajmniej ocen");
            int minOc = 100000;
            int licznikOc1 = 0;

            foreach (User user in xs)
            {
                foreach (int oc in user.Marks)
                {
                    licznikOc1++;
                }

                if (licznikOc1 < minOc)
                {
                    minOc = licznikOc1;
                }

                licznikOc1 = 0;

            }

            List<string> names3 = (from user in users where user.Marks?.Length == minOc select user.Name).ToList();
            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }




            Console.WriteLine("-----------------");
            Console.WriteLine("Listę studentów, którzy posiadają najwięcej ocen");
            int maxOc = 0;
            int licznikOc2 = 0;
            foreach (User user in xs)
            {
                foreach (int oc in user.Marks)
                {
                    licznikOc2++;
                }

                if (licznikOc2 > maxOc)
                {
                    maxOc = licznikOc2;
                }


                licznikOc2 = 0;


            }

            List<string> names4 = (from user in users where user.Marks?.Length == maxOc select user.Name).ToList();

            foreach (string name in names4)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("-----------------");
            Console.WriteLine("Listę obiektów zawierających tylko nazwę i średnią ocenę");


            List<User> names5 = (from user in users where user.Marks != null || user.Marks?.Length > 0 select user).ToList();

            int[] srednie = new int[names5.Count];
            int z = 0;
            foreach (User user in names5)
            {

                float sr = (float)user.Marks.Sum() / user.Marks.Length;


                Console.WriteLine(user.Name + " " + $"{sr:N2}");
                srednie[z] = (int)sr;

            }


            Console.WriteLine("-----------------");
            Console.WriteLine("Studentów posortowanych od najlepszego");

            List<User> names6 = (from user in users where user.Marks != null || user.Marks?.Length > 0 select new User { Name = user.Name, Marks = srednie }).ToList();
            List<User> Mapowanie = new List<User>();
            for (int i = 0; i < srednie.Length; i++)
            {
                Mapowanie = (from user in users where user.Marks != null || user.Marks?.Length > 0 select new User { Name = user.Name, Marks = new int[] { srednie[i] } }).ToList();
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Średnią ocenę wszystkich studentów");

            List<User> names11 = (from user in users where user.Marks != null || user.Marks?.Length > 0 orderby ((float)user.Marks.Sum() / user.Marks.Length) descending select user).ToList();

            foreach (User user in names11)
            {

                float sr = (float)user.Marks.Sum() / user.Marks.Length;


                Console.WriteLine(user.Name + " " + $"{sr:N2}");

            }



            Console.WriteLine("-----------------");
            Console.WriteLine("Listę użytkowników pogrupowanych po miesiącach daty utworzenia ");

            List<User> usersSorted = users.OrderByDescending(user => user.CreatedAt).ToList();
            string[] XSXS = new string[usersSorted.Count];
            foreach (var user in usersSorted)
            {
                var m = user.CreatedAt;
                var y = user.CreatedAt;

                string my = m.ToString().Substring(3, 2) + "/" + y.ToString().Substring(6, 4);

                Console.WriteLine(my + " " + user.Name);

            }



            Console.WriteLine("-----------------");
            Console.WriteLine("Listę użytkowników, którzy nie zostali usunięci");

            List<string> usersNotDeleted = (from user in users where user.RemovedAt == null select user.Name).ToList();

            foreach (string nd in usersNotDeleted)
            {
                Console.WriteLine(nd);
            }


            Console.WriteLine("-----------------");
            Console.WriteLine("Najnowszy studenta");

            var newest = DateTime.Now;
            foreach (var user in usersSorted)
            {
                if (newest < user.CreatedAt)
                {
                    newest = (DateTime)user.CreatedAt;
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
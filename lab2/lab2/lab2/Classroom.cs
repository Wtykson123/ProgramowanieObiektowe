<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Classroom
    {

        private string name;
        private Classroom[] classrooms;
        private string v;
        private Person[] persons;

        public string Name { get => this.name; }

        public Classroom(string name, Classroom[] classrooms )
        {

            this.name = name;
            this.classrooms = classrooms;

        }

        public Classroom(string v, Person[] persons)
        {
            this.v = v;
            this.persons = persons;
        }

        public override string ToString()
        {
            return $"Classroom: {base.ToString()}";
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Classroom
    {

        private string name;
        private Classroom[] classrooms;
        private string v;
        private Person[] persons;

        public string Name { get => this.name; }

        public Classroom(string name, Classroom[] classrooms )
        {

            this.name = name;
            this.classrooms = classrooms;

        }

        public Classroom(string v, Person[] persons)
        {
            this.v = v;
            this.persons = persons;
        }

        public override string ToString()
        {
            return $"Classroom: {base.ToString()}";
        }

    }
}
>>>>>>> 20a94b11db97ee0397c0cd48574142054d95e370

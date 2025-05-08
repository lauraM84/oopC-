﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal abstract class Person //classe astratta, non può essere istanziata
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Gender { get; set; }
        public DateTime Dob { get; set; }

        public Person(string name, string surname, int year, int month, int day)
        {
           
            Name = name;
            Surname = surname;
            Dob = new DateTime(year, month, day);
        }

        public override string ToString() //override del metodo ToString
        {
            return Name + " " + Surname;
        }

        public abstract string Wellcome(); //metodo astratto, deve essere implementato nelle classi figlie
    }
}

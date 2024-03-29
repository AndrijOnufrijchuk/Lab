﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }

            protected set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Children can't be older than 15");
                }

                base.Age = value;
            }
        }
    }
}
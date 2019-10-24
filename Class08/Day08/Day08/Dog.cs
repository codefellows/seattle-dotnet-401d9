using System;
using System.Collections.Generic;
using System.Text;

namespace Day08
{
    class Dog
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        
        public Dog(string name, string nickname, int age)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEditor
{
     public class RandomClass
    {

        public static void Go()
        {
            RandomClass person = new RandomClass();
            person.Age = 10;
            person.Id = 5;
            person.City = "Moscow";
            person.CardName = "Visa";
            person.Name = "Ivan";
            ObjectExplore.obj = person;
        }
        private int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        protected string CardName { get; set; }

    }
}

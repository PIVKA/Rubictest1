using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicTest
{
    class Planeta
    {
        private void Main()
        {
            CreateCat();
            CreateCat();
            CreateCat();
            CreateHuman();
            CreateHuman();

        }
        private void CreateCat()
        {
            Cat cat1 = new Cat();
            cat1.name = "johny";
            cat1.age = 1;
            cat1.height = 1.5F;
            cat1.isBoy = true;
        }
        private void CreateHuman()
        {
            human human1 = new human();
            human1.name = "john";
            human1.job = "warrior";
            human1.age = 32;
            human1.height = 69F;
            human1.isMale = true;
            human1.isANormal = false;
    }
    }
}

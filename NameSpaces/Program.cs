//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {

            ShopNameSpace.Shop shop = new ShopNameSpace.Shop();
            shop.GetName(); //одинаковые методы в разных неймспейсах но конфликта нет

            HumanNameSpaces.Human human = new HumanNameSpaces.Human();
            human.GetName();  //одинаковые методы в разных неймспейсах но конфликта нет

            HumanNameSpaces.organy.Organy organy = new HumanNameSpaces.organy.Organy();
            organy.name = "Golova";
            organy.ves = 2.50;


        }
    }
}

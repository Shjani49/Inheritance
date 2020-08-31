using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Create a Container object that cannot be instantiated itself, only its children can be instantiated.
                The Container will have a Capacity and Contents property and a Search() method. The search method will write "You open the container."    
                It's children will be "Box", "Chest" and "Cupboard".
                Each child will have a constructor that will define capacity at:
                    Box: 6
                    Chest: 8
                    Cupboard: 4
                Override the search method and add "The $type contains {Contents} items of a maximum {Capacity}." Call the base version first.
    
            */

            Box box1 = new Box();
            box1.Search();

            Chest chest = new Chest();
            chest.Search();

            Cupboard cupboard = new Cupboard();
            cupboard.Search();


            // Create a Fruit object that cannot be instantiated, with a Colour property. Inherit Apple, Orange and Banana therefrom and construct their colours appropriately.


            Apple apple = new Apple();
            apple.FruitColor();

            Orange orange = new Orange();
            orange.FruitColor();

            Banana banana = new Banana();
            banana.FruitColor();



        }
    }
}

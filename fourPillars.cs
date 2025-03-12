using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice
{
    public class fourPillars
    {
        //ENCAPSULATION & ABSTRACTION
        public class BankAccount
        {
            private decimal balance; // Encapsulation: hides the balance

            public void Deposit(decimal amount)
            { // Abstraction: hides implementation details
                balance += amount;
            }
        }


        //INHERITANCE
        //parent class
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("This animal eats food.");
            }
        }

        //child class
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog barks.");
            }
        }
        public void usage()
        {
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();
        }


        //POLYMORPHISM
        //RUNTIME

        public class Hayop
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal make sound");
            }

        }

        public class Iro : Hayop
        {
            public override void MakeSound()
            {
                Console.WriteLine("Aw aw!");
            }
        }

        public class Iring : Hayop
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow meow!");
            }
        }



        //COMPILE TIME
        public class mathoperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        public void gamit()
        {
            mathoperations mathoperations = new mathoperations();
            Console.WriteLine(mathoperations.Add(2, 3));
            Console.WriteLine(mathoperations.Add(0.2, 3.2));
        }



    }
}

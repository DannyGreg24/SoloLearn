using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 89;
            Console.WriteLine(x);
            // Outputs 89
            //-------------------------------------

            int age = 22;
            string name = "Daniel";
            string statement = "Learning C# for Unity";
            string yourName;
            string yourAge;
            int Age;
            int nosOfSkills;
            string fingerNumbers = "5";
            int nosOfFingers;
            var eyeNumber = 2;
            var eyeNosInwords = "two";
            const int numTest1 = 3;
            int x2 = 30;
            int y = 845;
            string emptyContainer;
            int numEmptyContainer;
            int z = 23;
            int w = 0;

            // These codes below are to test my knowledge on formatted strings with the use of variables
            Console.WriteLine("Hi, my name is {0} and I'm currently {1}, also I'm {2} years old", name, statement, age);
            Console.WriteLine("Just another formatted string text showing my name:{0}", name);
            Console.WriteLine("How many skills do you have?");
            Console.WriteLine("How many fingers do you have?");


            // The code below is another way of combining regular strings with variables of different types
            Console.WriteLine("Hi my name is " + name + " and I'm " + age + " years old");

            // Is This Line Right When Writing A String Accompanied With A Variable That Was Declared?---> Console.WriteLine("Hi, my name is" name);

            // For Name
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Your name is {0}", yourName);

            // For Age
            Console.WriteLine("How old are you?");
            yourAge = Console.ReadLine();
            Console.WriteLine("You are {0}", yourAge);
            Age = Convert.ToInt32(yourAge);
            Console.WriteLine("Your age {0}, has been converted from a string to an int", Age);

            // For Skills
            //Console.WriteLine("You have {0} number of skills", nosOfSkills);
            Console.WriteLine("How many skills do you have");
            nosOfSkills = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have {0} number of skills", nosOfSkills);

            // For Number Of Fingers
            Console.WriteLine("How many fingers do you have?");
            nosOfFingers = Convert.ToInt32(fingerNumbers);
            Console.WriteLine("You have {0} fingers", nosOfFingers);

            /* Eye Number: Can convert var1 [which is an integer, for example] of a value that is implicit (not specified) of a type TO 
             * var2 [which is a string, for example] of a value that is also implicit (not specified) by
             * the Convert.ToString [because for var2 = var1, var1 must be the same type as var2] and assign it to var2. 
             * BUT any and all var MUST be initialized [because the compiler doesn't know the type of data stored if the variable is empty] */
            eyeNosInwords = Convert.ToString(eyeNumber);
            Console.WriteLine("Number Of Eyes:{0}", eyeNosInwords);

            // Number Tests
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine($"x2 + y = {x2 + y}, y / x2 = {y / x2} , y * x2 = {y * x2}, y - x2 = {y - x2}");
            int q = z % numTest1;
            Console.WriteLine(q);

            Console.WriteLine((x2 * y) + q);

            int uy = 12;
            uy += 2;
            Console.WriteLine("This is the incrementation of uy = {0}", uy);

            int yu = 84;
            yu -= 23;
            Console.WriteLine($"This is the decrementation of yu = {yu}");

            float t = 10.5f;
            t *= yu;
            Console.WriteLine($"T result = {t} ");

            decimal io = 5.1m;
            io /= 2;
            Console.WriteLine("IO result = {0}", t);
            Console.WriteLine("Modulus of IO with respect to t = {0}", io%=yu);
            Console.WriteLine("Modulus of IO = {0}", io%=2);
            decimal.ToDouble(io);// Converts decimal to double because a decimal can not be converted to a string
            Convert.ToString(io);
            Console.WriteLine("Conveting decimal to string [for IO] = {0}", io);
            var box = io;
            var box2 = Convert.ToString(io);
            Console.WriteLine($"box (decimal type) = {box} & box2(string type) = {box2}");


            //We can also try to convert decimal to string by:
            Console.WriteLine("We can also try converting decimal to string by: io.ToString()");
            Console.WriteLine(io.ToString());
            Console.WriteLine(io.GetType()); //Shows the type of data of io
            Console.WriteLine(box.GetType()); //Shows the type ,of data of var box
            Console.WriteLine(box2.GetType()); //Shows the type of data of var box2

            //------------------------------------------------------------------------------

            int f = 84;
            f++;
            Console.WriteLine(f);

            int g = 64;
            g--;
            Console.WriteLine(g);

            Console.WriteLine("-----------------------------------------------");
            //Prefix and Postfix incrementation/decrementation
            f = f++;
            Console.WriteLine(f);
            Console.WriteLine(f++);
            Console.WriteLine(++f);

            g= --g;
            Console.WriteLine(g);
            Console.WriteLine(g--);
            Console.WriteLine(--g);

            Console.WriteLine("-----------------------------------------------");

            int r = 10;
            int j = ++r;
            Console.WriteLine("Prefix result {0}",j);

            int v = 10;
            int ty = v++;
            Console.WriteLine("Postfix Result {0}",ty);
            
            
            
            Console.WriteLine("-----------------------------------------------");

            // If-Else Statements
            Console.WriteLine("If-Else Statements");

            int ur = 55;
            int re = 78;
            int ageUser;
            int permittedAge = 18;
            int input;

            Console.Write("Put in your age: ");
            input = Convert.ToInt32(Console.ReadLine());
            ageUser = input;

            
            if (ageUser < permittedAge)
            {
                Console.WriteLine("Sorry you are not permitted to enter this site!");
            }

            else
            {
                Console.WriteLine("Welcome");
            }

            if (re > ur)
            {
                Console.WriteLine("You're Weird");
                
            }

            if (j != ty)
            {
                Console.WriteLine(g);
            }

            else if (j > ty)
            {
                Console.WriteLine(box);
            }

            if(g >= f)
            {
                Console.WriteLine(t);
            }
            
            if (box.GetType() == box2.GetType())
            {
                Convert.ToInt32(box);
                Console.WriteLine("This is readable because the if statement compared variables of different types {0}", box);
                
            }

            
            box.GetType();

            if (box.GetType() != box2.GetType())
            {
                Console.WriteLine("Seems like \"box\" couldn't be converted because of an issue");
                Convert.ToInt32(box);
                var newBox = box;
                Console.WriteLine(newBox.GetType());
                

            }
            else
            {
                Console.WriteLine("box seems to have converted to a different variable type");
            }

            Console.WriteLine("-----------------------------------------------");

            string goodGrade = "A";
            string okGrade = "B";
            string fairGrade = "C";
            string passGrade = "D";
            string failGrade = "F";
            string perfectGrade = "A+";
            int minGrade = 0;
            int maxGrade = 100;
            string inputLetterGrade;
            int inputNumberGrade;
            int studentA, studentB, studentC, studentD, studentE;
            int averageNumberGrade;
            string averageLetterGrade;
            studentA = 95;
            studentB = 84;
            studentC = 36;
            studentD = 72;
            studentE = 51;
            
            Console.Write("Insert Number Grade: ");
            inputNumberGrade = Convert.ToInt32(Console.ReadLine());

            if (inputNumberGrade == maxGrade) {
                Console.WriteLine("perfect you got an {0}", perfectGrade);

                if (inputNumberGrade <= 99 || inputNumberGrade >= 80)
                {
                    Console.WriteLine($"You got an {goodGrade}");

                    if (inputNumberGrade <= 79 || inputNumberGrade >= 70)
                    {
                        Console.WriteLine($"You got a {okGrade}");

                        if (inputNumberGrade <= 69 || inputNumberGrade >= 60)
                        {
                            Console.WriteLine($"You got a {fairGrade}");

                            if (inputNumberGrade <= 59 || inputNumberGrade >= 50)
                            {
                                Console.WriteLine("Poor performance, you got a {0}", passGrade);

                                if (inputNumberGrade >= 40 || inputNumberGrade <= 49)
                                {
                                    Console.WriteLine($"You fail, you got an {failGrade}");
                                }

                                else if (inputNumberGrade < 40 && inputNumberGrade != 0)
                                {
                                    Console.WriteLine($"You fail, you got an {failGrade}");
                                }

                                if ((inputNumberGrade != 0) == (inputNumberGrade == maxGrade))
                                {
                                    //Re-enter score to reflect whether or not the end-result is a positive or negative letter grade
                                    Console.Write("Re-enter Score: ");
                                    GetInputNumberGrade(inputNumberGrade);

                                    
                                }
                            }
                        }
                    }
                }

            }



            Console.WriteLine("-----------------------------------------------");
            
            Console.WriteLine(numTest1);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("I have synced my Lenovo to my Asus");


            // Profile Summary
            Console.WriteLine("PROFILE SUMMARY");

            // Another way of writing the codes above is
            Console.WriteLine("Your name is " + yourName);
            Console.WriteLine("You are " + yourAge + " years old");
            Console.WriteLine("Your age " + Age + ", has been converted from a string to an int");
            Console.WriteLine("You have " + nosOfSkills + " number of skills");
            Console.WriteLine("You have " + nosOfFingers + " fingers");
            Console.WriteLine("You have " + eyeNosInwords + " number of eyes");
        }

        private static int GetInputNumberGrade(int inputNumberGrade)
        {
            return inputNumberGrade;
        }
    }
}

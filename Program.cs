using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        //Random scoreNumberGenerator = new Random();

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
            Console.WriteLine("Modulus of IO with respect to t = {0}", io %= yu);
            Console.WriteLine("Modulus of IO = {0}", io %= 2);
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

            g = --g;
            Console.WriteLine(g);
            Console.WriteLine(g--);
            Console.WriteLine(--g);

            Console.WriteLine("-----------------------------------------------");

            int r = 10;
            int j = ++r;
            Console.WriteLine("Prefix result {0}", j);

            int v = 10;
            int ty = v++;
            Console.WriteLine("Postfix Result {0}", ty);



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

            if (g >= f)
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

            Console.WriteLine("-------------------Breakpoint----------------------------");

            string goodGrade = "A";
            string okGrade = "B";
            string fairGrade = "C";
            string passGrade = "D";
            string failGrade = "F";
            string perfectGrade = "A+";
            int minGrade = 0;
            const int maxGrade = 100;
            string inputLetterGrade;
            int inputNumberGrade = 65;
            int studentA, studentB, studentC, studentD, studentE;
            int averageNumberGrade;
            string averageLetterGrade;
            int recognitionThreshold;
            bool userInS = false; // bool for user input
            bool userGenS = false; // bool for user generate
            string choice;
            string userInputScore = "Input Score";
            string userGenerateScore = "Generate Score";
            string inputOrGenerateScore;
            // int scoreGenerator = scoreNumberGenerator.Next(0,101);

            studentA = 95;
            studentB = 84;
            studentC = 36;
            studentD = 72;
            studentE = 51;

            Console.Write("Do you wish to input your score or generate a random one?");
            inputOrGenerateScore = Console.ReadLine();

            if (inputOrGenerateScore == userInputScore)
            {

                userInS = true;

                if (userInS == true)
                {

                    Console.Write("Insert Number Grade: ");
                    inputNumberGrade = Convert.ToInt32(Console.ReadLine());

                    if (inputNumberGrade == maxGrade)
                    {
                        Console.WriteLine("perfect you got an {0}", perfectGrade);
                    }

                    else if (inputNumberGrade <= 99 && inputNumberGrade >= 80)
                    {
                        Console.WriteLine($"You got an {goodGrade}");
                    }


                    else if (inputNumberGrade <= 79 && inputNumberGrade >= 70)
                    {
                        Console.WriteLine($"You got a {okGrade}");
                    }

                    else if (inputNumberGrade <= 69 && inputNumberGrade >= 60)
                    {
                        Console.WriteLine($"You got a {fairGrade}");
                    }

                    else if (inputNumberGrade <= 59 && inputNumberGrade >= 50)
                    {
                        Console.WriteLine("Poor performance, you got a {0}", passGrade);
                    }

                    if (inputNumberGrade <= 49)
                    {
                        Console.WriteLine($"You fail, you got an {failGrade}");
                    }

                    //else if (inputNumberGrade < 40 && inputNumberGrade != 0)
                    //{
                    //    Console.WriteLine($"You fail, you got an {failGrade}");
                    //}

                    Console.ReadKey();

                }
            }

            /*else if (inputOrGenerateScore == userGenerateScore) {
                Console.WriteLine("Let's generate a score by pressing \"Enter\"");
                string keyEnter = Console.ReadLine();

                if (keyEnter == "Enter"){
                    scoreGenerator = Convert.ToInt32(Console.ReadLine());

                   if (scoreGenerator == maxGrade)
                   {
                       Console.WriteLine("perfect you got an {0}", perfectGrade);
                   }

                   else if (scoreGenerator <= 99 && scoreGenerator >= 80)
                    {
                           Console.WriteLine($"You got an {goodGrade}");                    
                    }

            
                   else if (scoreGenerator <= 79 && scoreGenerator >= 70)
                   {
                       Console.WriteLine($"You got a {okGrade}");
                   }

                   else if (scoreGenerator <= 69 && scoreGenerator >= 60)
                   {
                       Console.WriteLine($"You got a {fairGrade}");
                   }

                   else if (scoreGenerator <= 59 && scoreGenerator >= 50)
                   {
                       Console.WriteLine("Poor performance, you got a {0}", passGrade);
                   }

                   if (scoreGenerator <= 49)
                   {
                       Console.WriteLine($"You fail, you got an {failGrade}");
                   }

                   //else if (inputNumberGrade < 40 && inputNumberGrade != 0)
                   //{
                   //    Console.WriteLine($"You fail, you got an {failGrade}");
                   //}

                   Console.ReadKey();
                }

                else{
                    
                    Console.WriteLine("Wrong input");
                }
            } */

            Console.WriteLine("---------------Testing Switch Statements---------------------");

            switch (inputNumberGrade)
            {

                case maxGrade:
                    Console.WriteLine("Perferct");
                    break;

                case 50:
                    Console.WriteLine("Meh");
                    break;

                case 65:
                    Console.WriteLine("Finally, Switch Statement Worked");
                    break;


                // Similarly Switches can be written like this

                case 44:
                case 20:
                case 55:
                case 88:
                    Console.WriteLine("Multiple Cases On A Single Line Works As Well");
                    break;

                default:
                    Console.WriteLine("Finished");
                    break;
            }

            Console.WriteLine("---------------End Of Switch Statement Test---------------------");

            Console.WriteLine("--------------Breakpoint-----------------");
            string academicExellence = "These students are recognized for thier academic excellence";

            if (studentA == 90 && studentB == 90 && studentC == 90 && studentD == 90 && studentE == 90)
            {
                Console.WriteLine(academicExellence);
            }


            Console.WriteLine("-----------------------------------------------");


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

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("--------------------Testing Simple Game While Loops----------------------");

            string robber = "Put the money in the bag";
            string victimOption1 = "I have a family";
            bool trigger1 = false;
            bool trigger2 = false;
            string playerSelectA = "A";
            string playerSelectB = "B";
            string victimOption2 = "Refuse";
            string victimOption3 = "Ok Ok. How many?";
            string robberDeathResponse = "Robber shoots you";
            string robberResponse = "All of it you Bastard";
            int creditCard = 20;
            int atm;
            int cash;
            string robberCar = "The robber gets away in his car";
            string playerInput = " ";

            //for (int Counter = 0; Counter < 1; Counter++)
            //{
            //    while (trigger1 is false || playerInput == playerSelectB)
            //    {

            //        Console.WriteLine("A robber is ordering you to put you money in the bag. How do you respond?---Click Twice To See Option");
            //        Console.WriteLine("A: Comply");
            //        Console.WriteLine("B: Refuse");
            //        Console.WriteLine(robber);
            //        playerInput = Console.ReadLine();

            //        if (playerInput == playerSelectB)
            //        {
            //            Console.WriteLine("You chose: {0}", victimOption2);
            //            Console.WriteLine(robberDeathResponse);
            //            Console.WriteLine("THE END");
            //        }

            //        else if (playerInput != playerSelectB && playerInput != playerSelectA)
            //        {
            //            Console.WriteLine("Pick Either Option A or B Not Any Other Key");
            //            playerInput = Console.ReadLine();

            //        }
            //        else if (playerInput == playerSelectA)
            //        {
            //            Console.WriteLine(victimOption1);
            //            Console.WriteLine(victimOption3);
            //            Console.WriteLine(robberResponse);
            //            trigger2 = true;


            //            if (trigger2 = true)
            //            {
            //                Console.WriteLine("You insert your card into the atm to withdraw your money");
            //                atm = creditCard;
            //                --creditCard;

            //                if (creditCard == 0)
            //                {
            //                    Console.WriteLine("Your card balance is now $0");
            //                }

            //                cash = atm;


            //                if (cash == atm)
            //                {
            //                    Console.WriteLine("You have withdrawn all of your money from the ATM and given it to the robber");
            //                    Console.WriteLine(robberCar);
            //                }
            //                else
            //                {

            //                    Console.WriteLine($"The money has was not able to withdraw from the atm. Let's see the amount that is available in the atm: {atm}");
            //                    while (atm < creditCard)
            //                    {
            //                        ++atm;
            //                        Console.WriteLine("You re-tried and put in your total amount of {0} from your credit card to the atm which is {1}", creditCard, atm);
            //                    }

            //                }




            //            }
            //        }

            //    }


            //}


            

            Console.WriteLine("--------------------Testing While Loops----------------------");

            //int conTest = 10;
            //while (conTest < 21)
            //{
            //    Console.WriteLine(conTest);
            //    conTest++;
            //}

            Console.WriteLine("Another While loop incremental test");

            int value1 = 1;
            int value2 = 12;
            int value3 = 5;
            int value4 = 3;
            int baseNum = -5;

            Console.WriteLine("-----------------------------------------------");
            //while (value1++ < value3)
            //{
            //    if (value1 % 2 == 0)
            //    {
            //        Console.WriteLine($"Postfix: While Loop Result Of V1 & V3 = {value1}");
            //        value1 += 2;
            //        Console.WriteLine($"Result After Postfix Increment = {value1}");

            //    }



            //}

            Console.WriteLine("-----------------------------------------------");

            //while (value2 > value4++)
            //{
            //    Console.WriteLine("While Loop Result Of V3 & V4 = {0}", value4);

            //}

            Console.WriteLine("-----------------------------------------------");

            //if (value1 < value2)
            //{
            //    Console.WriteLine($"Incrementing V1 = {value1}");
            //    value1++;
            //    Console.WriteLine($"If-Condition for V1 & V2 = {value1}");

            //    while (value4 < value1++)
            //    {
            //        Console.WriteLine($"While Loop For V4 & V1++ = {value4}");
            //        value2 -= 2;
            //        Console.WriteLine($"Decrementing V2 by 2 = {value2}");
            //    }
            //}



            Console.WriteLine("-----------------------For Loop Test------------------------");

            for(int cnt = 0; cnt < 5; cnt++)
            {
                while(value3 < 7)
                {
                    value3++;
                    Console.WriteLine($"Incremeting V3: {value3}");

                    Console.WriteLine("Incrementing V1 to evaluate the While-Loop: {0}", value1);
                    value1++;
                }
            }

            Console.WriteLine("----------------------BreakPoint-------------------------");

            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine("Displaying Counter: {0}", cnt);

                if (baseNum < -9) {
                
                    baseNum ++;
                    Console.WriteLine($"Incrementing the baseNum to test For-Loop Only: {baseNum}");
                    
                }
            }


            Console.WriteLine("-----------------------------------------------");




        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            cube cube1 = new cube();
            cube1.stats(01, "Cube One", 10, 10, 30, 10, 10, 50.00); //Set the stats of cube1
            cube1.moveSet(01, 02, 00, 00); //Set the moves that cube1 knows
            cube1.experience(1000.00); //Set experience of cube1
            //Console.WriteLine("Working"); //Line written as placeholder to check program working
            //Test Output
            Console.WriteLine("Name: " + cube1.name);
            Console.WriteLine("Level: " + cube1.level + " (" + cube1.xp + "exp)");
            Console.WriteLine("Moves: " + cube1.move1 + ", " + cube1.move2 + ", " + cube1.move3 + ", " + cube1.move4);
            Console.WriteLine("Health: " + cube1.health);
            Console.WriteLine("Attack: " + cube1.attack);
            Console.WriteLine("Defence: " + cube1.defence);
            Console.WriteLine("Speed: " + cube1.speed);
            Console.ReadKey();
        }

    }
    class cube
    {
        public int id, attack, defence, speed, specAttack, specDefence, move1, move2, move3, move4, level;
        public double health, xp;
        public string name;

        public void stats(int i, string n, int atk, int def, int spd, int sAtk, int sDef, double hp)
        {
            id = i;
            name = n;
            attack = atk;
            defence = def;
            speed = spd;
            specAttack = sAtk;
            specDefence = sDef;
            health = hp;
        }

        public void moveSet(int m1, int m2, int m3, int m4)
        {
            move1 = m1;
            move2 = m2;
            move3 = m3;
            move4 = m4;
        }

        public void experience(double x)
        {
            //Define all integers (x is defined in the function)
            int[] n = new int[101]; //Define "n" as an array with 101 integers
            int i, q; //Defines "i" & "q"


            //Beginning of for loop for "i" to set all values within array "n"
            for (i = 0; i < 101; i++)
            {
                n[i] = i * i * i; //Sets array "n" equal to "i"^3
            }

            //Beginning of for loop for "q" to check what level the cube is based on current experience
            for (q = 0; x > n[q]; q++)
            {
                level = q;
                exp = x;
            }
        }
    }



}

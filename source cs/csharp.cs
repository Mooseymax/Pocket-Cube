using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket-Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            cube cube1 = new cube();
            cube1.stats(01, "Cube One", 10, 10, 30, 10, 10, 50.00);
            cube1.moveSet(01, 02, 00, 00);
            cube1.experience(1000.00);
            Console.WriteLine("Working");
        }

    }
    class cube
    {
        private int id, attack, defence, speed, specAttack, specDefence, move1, move2, move3, move4;
        private double health;
        private string name;

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

        public void experience(double exp)
        {
            //Define all integers
            int[] n = new int[101]; //Define "n" as an array with 101 integers
            int i, q, level; //Defines "i", "q" & "level"
            double x = exp; //Sets "x" equal to "exp"

            //Beginning of for loop for "i" to set all values within array "n"
            for (i = 0; i < 101; i++)
            {
                n[i] = i * i * i; //Sets array "n" equal to "i"^3
            }

            //Beginning of for loop for "q" to check what level the cube is based on current experience
            for (q = 0; x > n[q]; q++)
            {
                level = q;
            }
        }
    }



}
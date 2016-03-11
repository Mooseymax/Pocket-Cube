using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Cube {
    class Program {
        static void Main(string[] args) {
            cube cube1 = new cube();
            cube1.stats(01, "Cube One", 10, 10, 30, 10, 10, 50.00); //Set the stats of cube1
            cube1.ev_stats(10, 10, 30, 10, 10, 50.00); //Set the ev stats of cube1
            cube1.moveSet(01, 02, 00, 00); //Set the moves that cube1 knows
            cube1.experience(1000.00); //Set experience of cube1
            //Console.WriteLine("Working"); //Line written as placeholder to check program working

            //Test Output
            Console.WriteLine("Name: " + cube1.name);
            Console.WriteLine("Level: " + cube1.level + " (" + cube1.exp + "exp)");
            Console.WriteLine("Moves: " + cube1.move1 + ", " + cube1.move2 + ", " + cube1.move3 + ", " + cube1.move4);
            Console.WriteLine("Health: " + cube1.health);
            Console.WriteLine("Attack: " + cube1.attack);
            Console.WriteLine("Defence: " + cube1.defence);
            Console.WriteLine("Speed: " + cube1.speed);
            Console.WriteLine("If you destroyed this cube, you would get " + cube1.giveExp + " experience.");
            Console.ReadKey();
        }
    }

    class cube {
        //stats variables
        public int id, attack, defence, speed, specAttack, specDefence, level;
        public double health;
        public string name;

        //base stats variables
        private int base_attack, base_defence, base_speed, base_specAttack, base_specDefence;
        private double base_health;

        //ev stats variables
        private int ev_attack, ev_defence, ev_speed, ev_specAttack, ev_specDefence;
        private double ev_health;

        //moveset variables
        public int move1, move2, move3, move4;

        //experience variables
        public double exp;
        public double giveExp;

        //base stats method
        public void stats(int i, string n, int atk, int def, int spd, int sAtk, int sDef, double hp) {
            id = i;
            name = n;
            base_attack = atk;
            base_defence = def;
            base_speed = spd;
            base_specAttack = sAtk;
            base_specDefence = sDef;
            base_health = hp;
        }

        //evstats method
        public void ev_stats(int atk, int def, int spd, int sAtk, int sDef, double hp) {
            ev_attack = atk;
            ev_defence = def;
            ev_speed = spd;
            ev_specAttack = sAtk;
            ev_specDefence = sDef;
            ev_health = hp;
        }

        //moveset method
        public void moveSet(int m1, int m2, int m3, int m4) {
            move1 = m1;
            move2 = m2;
            move3 = m3;
            move4 = m4;
        }

        //experience method
        public void experience(double x) {
            //Define all integers (x is defined in the function)
            int[] n = new int[100]; //Define "n" as an array with 101 integers
            int i, l; //Defines "i" & "l"


            //Beginning of for loop for "i" to set all values within array "n"
            for (i = 0; i <= 100; i++) {
             n[i] = i * i * i; //Sets array "n" equal to "i"^3
            }

            //Beginning of for loop for "l" to check what level the cube is based on current experience
            for (l = 0; x > n[l]; l++) {
             level = l;
             exp = x;
            }

            //set the amount of experience a cube gives
            giveExp = ((exp / 100) + ((1 / 3) * (n[level] - n[level - 1])) * ((attack + defence + speed + specAttack + specDefence + health) / 900));

        }
        public void setStats() {
            //setting value of stats equal to the base plus the EVs
            attack = base_attack + ev_attack;
            defence = base_defence + ev_defence;
            speed = base_speed + ev_speed;
            specAttack = base_specAttack + ev_specAttack;
            specDefence = base_specDefence + ev_specDefence;
            health = base_health + ev_health;
        }
    }
}

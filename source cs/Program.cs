using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pocket_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            //call all cube base details into existance.
            callCubes();

            //Test Output
            Console.WriteLine("Name: " + cube1.name);
            Console.WriteLine("Level: " + cube1.level + " (" + cube1.exp + "exp)");
            Console.WriteLine("Moves: " + cube1.move1 + ", " + cube1.move2 + ", " + cube1.move3 + ", " + cube1.move4);
            Console.WriteLine("Health: " + cube1.health);
            Console.WriteLine("Attack: " + cube1.attack);
            Console.WriteLine("Defence: " + cube1.defence);
            Console.WriteLine("Speed: " + cube1.speed);
            Console.WriteLine("If you destroyed this cube, you would get " + cube1.giveExp + " experience.");
            Console.WriteLine("");
            //xml();
            Console.ReadKey();
        }

/*          static void xml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Moose\Desktop\Pocket-Cube\source cs\cubes.xml");
            string xmlcontents = doc.InnerXml;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlcontents);

            XmlNodeList xnList = xml.SelectNodes("/cubes/cube");
            foreach (XmlNode xn in xnList)
            {
                string name = xn["name"].InnerText;
                string base_attack = xn["base_attack"].InnerText;
                Console.WriteLine("Name: {0} {1}", name, base_attack);
            }
        }
*/

        static void callCubes()
        {
            cube blank = new cube();
            blank.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            blank.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            blank.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube1 = new cube();
            cube1.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube1.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube1.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube2 = new cube();
            cube2.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube2.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube2.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube3 = new cube();
            cube3.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube3.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube3.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube4 = new cube();
            cube4.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube4.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube4.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube5 = new cube();
            cube5.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube5.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube5.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube6 = new cube();
            cube6.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube6.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube6.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube7 = new cube();
            cube7.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube7.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube7.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube8 = new cube();
            cube8.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube8.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube8.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube9 = new cube();
            cube9.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube9.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube9.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube10 = new cube();
            cube10.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube10.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube10.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube11 = new cube();
            cube11.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube11.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube11.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

            cube cube12 = new cube();
            cube12.base_stats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube12.ev_stats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube12.moveSet(00, 00, 00, 00);//move1, move2, move3, move4

        }

    }
    class cube
        {
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
            public void base_stats(int i, string n, int atk, int def, int spd, int sAtk, int sDef, double hp)
            {
                id = i;
                name = n;
                base_attack = atk;
                base_defence = def;
                base_speed = spd;
                base_specAttack = sAtk;
                base_specDefence = sDef;
                base_health = hp;
                setStats();
            }

            //evstats method
            public void ev_stats(int atk, int def, int spd, int sAtk, int sDef, double hp)
            {
                ev_attack = atk;
                ev_defence = def;
                ev_speed = spd;
                ev_specAttack = sAtk;
                ev_specDefence = sDef;
                ev_health = hp;
                setStats();
            }

            public void moveSet(int m1, int m2, int m3, int m4)
            {
                move1 = m1;
                move2 = m2;
                move3 = m3;
                move4 = m4;
            }

            //experience method
            public void experience(double xp)
            {
                //Define all integers
                int[] n = new int[100]; //Define "n" as an array with 101 integers
                int i, q; //Defines "i" & "q"
                double x = xp; //Sets "x" equal to "exp"


                //Beginning of for loop for "i" to set all values within array "n"
                for (i = 0; i < 100; i++)
                {
                    n[i] = i * i * i; //Sets array "n" equal to "i"^3
                }

                //Beginning of for loop for "q" to check what level the cube is based on current experience
                for (q = 0; x > n[q]; q++)
                {
                    level = q;
                    exp = xp;
                }

                //set the amount of experience a cube gives
                giveExp = (100);

            }
            public void setStats()
            {
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
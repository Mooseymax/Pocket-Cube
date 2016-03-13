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
            //call all Cube base details into existance.
            CallCubes();

            //Test Output
            Console.WriteLine("Name: " + cube1.name);
            Console.WriteLine("Level: " + cube1.level + " (" + cube1.exp + "exp)");
            Console.WriteLine("Moves: " + cube1.move1 + ", " + cube1.move2 + ", " + cube1.move3 + ", " + cube1.move4);
            Console.WriteLine("Health: " + cube1.health);
            Console.WriteLine("Attack: " + cube1.attack);
            Console.WriteLine("Defence: " + cube1.defence);
            Console.WriteLine("Speed: " + cube1.speed);
            Console.WriteLine("If you destroyed this cube, you would get " + cube1.giveExp + " Experience.");
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
                string baseAttack = xn["baseAttack"].InnerText;
                Console.WriteLine("Name: {0} {1}", name, baseAttack);
            }
        }
*/

        static void CallCubes()
        {
            Cube blank = new Cube();
            blank.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            blank.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            blank.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube1 = new Cube();
            cube1.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube1.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube1.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube2 = new Cube();
            cube2.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube2.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube2.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube3 = new Cube();
            cube3.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube3.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube3.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube4 = new Cube();
            cube4.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube4.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube4.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube5 = new Cube();
            cube5.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube5.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube5.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube6 = new Cube();
            cube6.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube6.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube6.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube7 = new Cube();
            cube7.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube7.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube7.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube8 = new Cube();
            cube8.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube8.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube8.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube9 = new Cube();
            cube9.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube9.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube9.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube10 = new Cube();
            cube10.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube10.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube10.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube11 = new Cube();
            cube11.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube11.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube11.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

            Cube cube12 = new Cube();
            cube12.BaseStats(00, "Blank", 0, 0, 0, 0, 0, 0.00); //id, name, atk, def, speed, sp. atk, sp. def, health
            cube12.EvStats(0, 0, 0, 0, 0, 0.00); //atk, def, speed, sp. atk, sp. def, health
            cube12.MoveSet(00, 00, 00, 00);//move1, move2, move3, move4

        }

    }
    class Cube
        {
            //stats variables
            public int id, attack, defence, speed, specAttack, specDefence, level;
            public double health;
            public string name;

            //base stats variables
            private int baseAttack, baseDefence, baseSpeed, baseSpecAttack, baseSpecDefence;
            private double baseHealth;

            //ev stats variables
            private int evAttack, evDefence, evSpeed, evSpecAttack, evSpecDefence;
            private double evHealth;

            //MoveSet variables
            public int move1, move2, move3, move4;

            //Experience variables
            public double exp;
            public double giveExp;

            //base stats method
            public void BaseStats(int i, string n, int atk, int def, int spd, int sAtk, int sDef, double hp)
            {
                id = i;
                name = n;
                baseAttack = atk;
                baseDefence = def;
                baseSpeed = spd;
                baseSpecAttack = sAtk;
                baseSpecDefence = sDef;
                baseHealth = hp;
                SetStats();
            }

            //evstats method
            public void EvStats(int atk, int def, int spd, int sAtk, int sDef, double hp)
            {
                evAttack = atk;
                evDefence = def;
                evSpeed = spd;
                evSpecAttack = sAtk;
                evSpecDefence = sDef;
                evHealth = hp;
                SetStats();
            }

            public void MoveSet(int m1, int m2, int m3, int m4)
            {
                move1 = m1;
                move2 = m2;
                move3 = m3;
                move4 = m4;
            }

            //Experience method
            public void Experience(double xp)
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

                //Beginning of for loop for "q" to check what level the Cube is baseD on current Experience
                for (q = 0; x > n[q]; q++)
                {
                    level = q;
                    exp = xp;
                }

                //set the amount of Experience a Cube gives
                giveExp = (100); //Placeholder while I figure out the best calculation method

            }
            public void SetStats()
            {
                //setting value of stats equal to the base plus the EVs
                attack = baseAttack + evAttack;
                defence = baseDefence + evDefence;
                speed = baseSpeed + evSpeed;
                specAttack = baseSpecAttack + evSpecAttack;
                specDefence = baseSpecDefence + evSpecDefence;
                health = baseHealth + evHealth;
            }
        }

}
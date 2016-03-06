class levelArrayClass
{
    static void levelArray(string[] args)
    {
        int []  n = new int[101]; /* n is an array of 101 integers */
        int i,j;

        /* initialize elements of array n */
        for ( i = 0; i < 101; i++ )
        {
            n[ i ] = i * i * i;
        }
        
        double x = experience;
        int q;
        int level;
        
        for ( q > 0; x > n[q]; q++ )
        {
            level = q;
        }
        
        public int getLevel()
        {
            return level; //placeholder
        }

    }
}

class cube 
{
    private int id, attack, defence, speed, specAttack, specDefence, move1, move2, move3, move4;
    private double health, experience;
    private string name;
    public int level;
          
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
     
}

cube cube1 = new cube()
cube1.stats(01, "Cube One", 10, 10, 30, 10, 10, 50.00);
cube1.moveSet(01,02,00,00);
cube1.experience = 1000.00;
cube1.level = cube1.getLevel();
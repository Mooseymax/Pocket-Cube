using System.Collections;

class Cube
{
    //stats variables
    private int id, attack, defence, speed, specAttack, specDefence, level;
    private double health;
    private string name;

    //base stats variables
    private int baseAttack, baseDefence, baseSpeed, baseSpecAttack, baseSpecDefence;
    private double baseHealth;

    //ev stats variables
    private int evAttack, evDefence, evSpeed, evSpecAttack, evSpecDefence;
    private double evHealth;

    //MoveSet variables
    private int move1, move2, move3, move4;

    //Experience variables
    private double exp;
    private double giveExp;

    //Experience:Level Array
    private int[] levelTable = new int[101];

    //Access level
    public int Level {
        get { return level; }
        set { level = Exp; }
    }

    int Exp()
    {
        int i,q;
    
        for (i = 0; i< 100; i++)
        {
            levelTable[i] = i* i * i;
        }

        for (q = 0; exp > levelTable[q]; q++)
        {
            
        }
        return q;
    }

    /*
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

        //Beginning of for loop for "q" to check what level the Cube is based on current Experience
        for (q = 0; x > n[q]; q++)
        {
            level = q;
            exp = xp;
        }

        //set the amount of Experience a Cube gives
        giveExp = (100); //Placeholder while I figure out the best calculation method

    }*/

    //Access Overall Info
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string CubeName
    {
        get { return name; }
        set { name = value; }
    }
    public double Experience
    {
        get { return exp; }
        set { exp = value; }
    }
    public int Attack
    {
        get { return attack; }
        set { attack = baseAttack + evAttack; }
    }
    public int Defence
    {
        get { return defence; }
        set { defence = baseDefence + evDefence; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = baseSpeed + evSpeed; }
    }
    public int SpecAttack
    {
        get { return specAttack; }
        set { specAttack = baseSpecAttack + evSpecAttack; }
    }
    public int SpecDefence
    {
        get { return specDefence; }
        set { specDefenceid = baseSpecDefence + evSpecDefence; }
    }
    public double Health
    {
        get { return health; }
        set { health = baseHealth + evHealth; }
    }

    //Access Base Stats
    public int BaseAttack
    {
        get { return baseAttack; }
        set { baseAttack = value; }
    }
    public int BaseDefence
    {
        get { return baseDefence; }
        set { baseDefence = value; }
    }
    public int BaseSpeed
    {
        get { return baseSpeed; }
        set { baseSpeed = value; }
    }
    public int BaseSpecAttack
    {
        get { return baseSpecAttack; }
        set { baseSpecAttack = value; }
    }
    public int BaseSpecDefence
    {
        get { return baseSpecDefence; }
        set { baseSpecDefenceid = value; }
    }
    public double BaseHealth
    {
        get { return baseHealth; }
        set { baseHealth = value; }
    }


    //Access EV Stats
    public int EvAttack
    {
        get { return evAttack; }
        set { evAttack = value; }
    }
    public int EvDefence
    {
        get { return evDefence; }
        set { evDefence = value; }
    }
    public int EvSpeed
    {
        get { return evSpeed; }
        set { evSpeed = value; }
    }
    public int EvSpecAttack
    {
        get { return evSpecAttack; }
        set { evSpecAttack = value; }
    }
    public int EvSpecDefence
    {
        get { return evSpecDefence; }
        set { evSpecDefenceid = value; }
    }
    public double EvHealth
    {
        get { return evHealth; }
        set { evHealth = value; }
    }
   
   /* public void SetStats()
    {
        //setting value of stats equal to the base plus the EVs
        attack = baseAttack + evAttack;
        defence = baseDefence + evDefence;
        speed = baseSpeed + evSpeed;
        specAttack = baseSpecAttack + evSpecAttack;
        specDefence = baseSpecDefence + evSpecDefence;
        health = baseHealth + evHealth;
    }*/

}
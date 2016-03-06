#ifndef PKMN_H
#define PKMN_H
class Move
{
    public:
    Move (int, int, double, double, int, double);
    int damage, pp, effect;
	double critical, accuracy, effectChance;
}
Move::Move(int d, int p, double a, double c, int e, double eC)
{
    this->damage = d;
    this->accuracy = a;
	this->pp = p;
	this->critical = c;
	this->effect = e;
	this->effectChance = eC;
}
class Pokecube
{
    public:
    Pokecube (Move, Move, Move, Move);
    Move *move1, *move2, *move3, *move4;
    int attack, defence, spcAttack, spcDefence, speed; 
    double health, experience;
}
Pokecube::Pokecube (Move m1, Move m2, Move m3, Move m4)
{
    this->move1 = &m1;
    this->move2 = &m2;
    this->move3 = &m3;
    this->move4 = &m4;
}
#endif
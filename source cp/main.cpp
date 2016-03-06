class randomCube {
    public:
        randomCube(int, double, int, int, int, int);
        int cube, move1, move2, move3, move4;
        double chance;
}
randomCube::randomCube(int cube, double chance, int m1, int m2, int m3, int m4) {
    this -> move1 = m1;
    this -> move2 = m2;
    this -> move3 = m3;
    this -> move4 = m4;
}


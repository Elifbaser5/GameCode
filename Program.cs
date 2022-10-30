//Coordinates of A
using System;
using System.Reflection;
using System.Xml.Serialization;

Console.WriteLine("Please type Ax between -10,10:");
int Ax = Convert.ToInt32(Console.ReadLine());

if ((Ax + 10) > 20 || 0 > (Ax + 10))
{
    Console.WriteLine("Please write a number in written range.");
    return;
}

Console.WriteLine("Please type Ay between -10,10:");
int Ay = Convert.ToInt32(Console.ReadLine());

if ((Ay + 11) > 21 || 1 > (Ay + 11))
{
    Console.WriteLine("Please write a number in written range.");
    return;
}


//Coordinates of B
Random random = new Random();
int Bx;
Bx = random.Next(-10, 11);

Random random1 = new Random();
int By;
By = random.Next(-10, 11);



//Coordinates of C
Random random3 = new Random();
int Cx;
Cx = random.Next(-10, 11);

Random random2 = new Random();
int Cy;
Cy = random.Next(-10, 11);



int SetA = 0;
int SetB = 0;
int SetC = 0;
int HealthA = 0;
int HealthB = 0;
int HealthC = 0;
Random random12 = new Random();
int set = random.Next(1, 7);
int health = random.Next(1, 7);

switch (set)
{
    case 1:
        SetA = 1;
        SetB = 2;
        SetC = 3;
        break;
    case 2:
        SetA = 1;
        SetB = 3;
        SetC = 2;
        break;
    case 3:
        SetA = 2;
        SetB = 1;
        SetC = 3;
        break;
    case 4:
        SetA = 2;
        SetB = 3;
        SetC = 1;
        break;
    case 5:
        SetA = 3;
        SetB = 2;
        SetC = 1;
        break;
    case 6:
        SetA = 3;
        SetB = 1;
        SetC = 2;
        break;

}

switch (health)
{
    case 1:
        HealthA = 60;
        HealthB = 80;
        HealthC = 100;
        break;
    case 2:
        HealthA = 60;
        HealthB = 100;
        HealthC = 80;
        break;
    case 3:
        HealthA = 80;
        HealthB = 60;
        HealthC = 100;
        break;
    case 4:
        HealthA = 80;
        HealthB = 100;
        HealthC = 60;
        break;
    case 5:
        HealthA = 100;
        HealthB = 80;
        HealthC = 60;
        break;
    case 6:
        HealthA = 100;
        HealthB = 60;
        HealthC = 80;
        break;

}

Console.WriteLine("A: " + (Ax, Ay) + "           Set:" + (SetA) + "             Health: " + (HealthA));
Console.WriteLine("B: " + (Bx, By) + "           Set:" + (SetB) + "             Health: " + (HealthB));
Console.WriteLine("C: " + (Cx, Cy) + "           Set:" + (SetC) + "             Health: " + (HealthC));

Console.ReadKey();
Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +");
Console.WriteLine(" 10| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  9| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  8| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  7| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  6| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  5| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  4| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  3| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  2| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  1| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("  0| - - - - - - - - - - - - - - - - - - - - - >");
Console.WriteLine(" -1| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -2| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -3| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -4| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -5| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -6| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -7| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -8| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine(" -9| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("-10| . . . . . . . . . . | . . . . . . . . . . |");
Console.WriteLine("   + - - - - - - - - - - - - - - - - - - - - - +");
Console.WriteLine("    10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10");



//Their places on coordinate plane
Console.SetCursorPosition(((Ax + 11) * 2 + 3), ((Ay * -1) + 18));
Console.Write("A");
Console.ReadKey();

Console.SetCursorPosition(((Bx + 11) * 2 + 3), ((By * -1) + 18));
Console.Write("B");
Console.ReadKey();

Console.SetCursorPosition(((Cx + 11) * 2 + 3), ((Cy * -1) + 18));
Console.Write("C");
Console.ReadKey();


// For Battle Their Manhattan Distance
int distanceAB = (Math.Abs(Ax - Bx) + Math.Abs(Ay - By));
int distanceBC = (Math.Abs(Bx - Cx) + Math.Abs(By - Cy));
int distanceAC = (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy));

if (distanceAB - distanceBC == 0 || distanceAB - distanceAC == 0 || distanceBC - distanceAC == 0)
{
    Bx = random.Next(-10, 11);
    By = random.Next(-10, 11);
    Cx = random.Next(-10, 11);
    Cy = random.Next(-10, 11);
    int distanceAB1 = (Math.Abs(Ax - Bx) + Math.Abs(Ay - By));
    int distanceBC2 = (Math.Abs(Bx - Cx) + Math.Abs(By - Cy));
    int distanceAC3 = (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy));

    if (distanceAB - distanceBC == 0 || distanceAB - distanceAC == 0 || distanceBC - distanceAC == 0)
    {

        Console.Clear();
        Console.WriteLine("Player's distances to each other are equal or they are in the same place.");
        Console.WriteLine("Please try again.");
        return;
    }
}


if (distanceAB > 16 && distanceAC > 16 && distanceBC > 16)
{
    Bx = random.Next(-10, 11);
    By = random.Next(-10, 11);
    Cx = random.Next(-10, 11);
    Cy = random.Next(-10, 11);
    int distanceAB1 = (Math.Abs(Ax - Bx) + Math.Abs(Ay - By));
    int distanceBC2 = (Math.Abs(Bx - Cx) + Math.Abs(By - Cy));
    int distanceAC3 = (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy));

    if (distanceAB > 16 && distanceAC > 16 && distanceBC > 16)
    {

        Console.Clear();
        Console.WriteLine("Player's distances are grater than 15 units.");
        Console.WriteLine("Please try again");
        return;
    }
}
Console.SetCursorPosition(0,32);

//Assign the player of Round1
int chosendistance = 0;
int setP1;
int setP2;
int healthP1;
int healthP2;
//int scoreP1;
//int scoreP2;
char char1;
char char2;
char1 = 'A';
char2 = 'B';
int score = 0;
int score2 = 0;
char winner;
char defeat;

if (distanceAB < distanceAC && distanceAB < distanceBC)
{
    chosendistance = distanceAB;

    Console.WriteLine("Round 1 : A-B");
    char1 = 'A';
    char2 = 'B';
    setP1 = SetA;
    setP2 = SetB;
    healthP1 = HealthA;
    healthP2 = HealthB;


    if ((setP1 - setP2) == 1)
    {
        score = ((distanceAB * 10) + (100 - (healthP1 - 25)));
        Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
        Console.WriteLine("B: Defeated           Health:0" + "           Score:0");
        Console.WriteLine("C: Non-fighter        Health:" + (HealthC) + "           Score:0");

        if (distanceAC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAC <= 15)
        {
            Console.WriteLine("Round 2 : A-C");
            score = ((distanceAB * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAC * 10) + (100 - (HealthC - 25)));
            Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
            Console.WriteLine("B: Defeated           Health:0" + "           Score:0");
            Console.WriteLine("C: Survivor           Health:" + (HealthC - 25) + "           Score:" + (score2));

            if (score < score2)
            {
                Console.WriteLine("C has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("A has the maximum score " + ((score)));


        }
    }


    if ((setP1 - setP2) == -1)
    {
        score = ((distanceAB * 10) + (100 - (healthP2 - 25)));
        Console.WriteLine("A: Defeated           Health:0" + "           Score:0");
        Console.WriteLine("B: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));
        Console.WriteLine("C: Non-fighter        Health:" + (HealthC) + "           Score:0");

        if (distanceBC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceBC <= 15)
        {
            Console.WriteLine("Round 2 : B-C");
            score = ((distanceAB * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceBC * 10) + (100 - (HealthC - 25)));
            Console.WriteLine("A: Defeated           Health:0           Score:0");
            Console.WriteLine("B: Defeat             Health:0" + "           Score:" + (score));
            Console.WriteLine("C: Survivor           Health:" + (HealthC - 25) + "           Score:" + (score2));


            if (score < score2)
            {
                Console.WriteLine("B has the maximum score " + ((score)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("C has the maximum score " + ((score2)));

        }
    }


    if ((setP1 - setP2) == -2)
    {
        score = ((distanceAB * 10) + (100 - (healthP1 - 25)));
        Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
        Console.WriteLine("B: Defeated           Health:0" + "           Score:");
        Console.WriteLine("C: Non-fighter        Health:" + (HealthC) + "           Score:0");

        if (distanceAC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAC <= 15)
        {
            Console.WriteLine("Round 2 : A-C");
            score = ((distanceAB * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAC * 10) + (100 - (HealthC - 25)));

            Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
            Console.WriteLine("B: Defeated           Health:0" + "           Score:0");
            Console.WriteLine("C: Survivor           Health:" + (HealthC - 25) + "           Score:" + (score2));

            if (score < score2)
            {
                Console.WriteLine("C has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("A has the maximum score " + ((score)));

        }
    }

    if ((setP1 - setP2) == 2)
    {
        score = ((distanceAB * 10) + (100 - (healthP2 - 25)));
        Console.WriteLine("A: Defeated           Health:0" + "           Score:0");
        Console.WriteLine("B: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));
        Console.WriteLine("C: Non-fighter        Health:" + (HealthC) + "           Score:0");

        if (distanceBC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceBC <= 15)
        {
            Console.WriteLine("Round 2 : B-C");
            score = ((distanceAB * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceBC * 10) + (100 - (HealthC - 25)));
            Console.WriteLine("A: Defeated           Health:0           Score:0");
            Console.WriteLine("B: Defeat             Health:0" + "           Score:" + (score));
            Console.WriteLine("C: Survivor           Health:" + (HealthC - 25) + "           Score:" + (score2));


            if (score < score2)
            {
                Console.WriteLine("B has the maximum score " + ((score)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("C has the maximum score " + ((score2)));

        }
    }


}



if (distanceAC < distanceAB && distanceAC < distanceBC)
{
    chosendistance = distanceAC;
    Console.WriteLine("Round 1 : A-C");
    char1 = 'A';
    char2 = 'C';
    setP1 = SetA;
    setP2 = SetC;
    healthP1 = HealthA;
    healthP2 = HealthC;

    if ((setP1 - setP2) == 1)
    {
        score = ((distanceAC * 10) + (100 - (healthP1 - 25)));
        Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
        Console.WriteLine("B: Non-fighter        Health:" + (HealthB) + "           Score:0");
        Console.WriteLine("C: Defeated           Health:0           Score:0");

        if (distanceAB > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAB <= 15)
        {
            Console.WriteLine("Round 2 : A-B");
            score = ((distanceAC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAB * 10) + (100 - (HealthB - 25)));

            Console.WriteLine("A: Defeat            Health:0" + "           Score:" + (score));
            Console.WriteLine("B: Survivor           Health:" + (HealthB - 25) + "           Score:" + (score2));
            Console.WriteLine("C: Defeated           Health:0           Score:0");

            if (score < score2)
            {
                Console.WriteLine("B has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("A has the maximum score " + ((score)));

        }
    }



    if ((setP1 - setP2) == -1)
    {
        score = ((distanceAC * 10) + (100 - (healthP2 - 25)));
        Console.WriteLine("A: Defeated           Health:0           Score:0");
        Console.WriteLine("B: Non-fighter        Health:" + HealthB + "           Score:0");
        Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));

        if (distanceBC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceBC <= 15)
        {
            Console.WriteLine("Round 2 : B-C");
            score = ((distanceAC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceBC * 10) + (100 - (HealthB - 25)));
            Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
            Console.WriteLine("B: Survivor           Health:" + (HealthB - 25) + "           Score:" + (score2));
            Console.WriteLine("C: Defeated           Health:0           Score:0");

            if (score < score2)
            {
                Console.WriteLine("B has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("A has the maximum score " + ((score)));

        }
    }



    if ((setP1 - setP2) == -2)
    {
        score = ((distanceAC * 10) + (100 - (healthP1 - 25)));
        Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
        Console.WriteLine("B: Non-fighter        Health:" + HealthB + "           Score:0");
        Console.WriteLine("C: Defeated           Health:0           Score:0");

        if (distanceAB > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAB <= 15)
        {
            Console.WriteLine("Round 2 : A-B");
            score = ((distanceAC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAB * 10) + (100 - (HealthB - 25)));
            Console.WriteLine("A: Defeat             Health:0"  + "           Score:" + (score));
            Console.WriteLine("B: Survivor           Health:" + (HealthB - 25) + "           Score:" + (score2));
            Console.WriteLine("C: Defeated           Health:0           Score:0");

            if (score < score2)
            {
                Console.WriteLine("B has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("A has the maximum score " + ((score)));
        }
    }

    if ((setP1 - setP2) == 2)
    {
        score = ((distanceAC * 10) + (100 - (healthP2 - 25)));
        Console.WriteLine("A: Defeated           Health:0           Score:0");
        Console.WriteLine("B: Non-fighter        Health:" + HealthB + "           Score:0");
        Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));

        if (distanceBC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceBC <= 15)
        {
            Console.WriteLine("Round 2 : B-C");
            score = ((distanceAC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceBC * 10) + (100 - (HealthB - 25)));
            Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
            Console.WriteLine("B: Survivor           Health:" + (HealthB - 25) + "           Score:" + (score2));
            Console.WriteLine("C: Defeated           Health:0           Score:0");

            if (score < score2)
            {
                Console.WriteLine("B has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("A has the maximum score " + ((score)));

        }
    }

}


if (distanceBC < distanceAB && distanceBC < distanceAC)
{
    chosendistance = distanceBC;
    Console.WriteLine("Round 1 : B-C");
    char1 = 'B';
    char2 = 'C';
    setP1 = SetB;
    setP2 = SetC;
    healthP1 = HealthB;
    healthP2 = HealthC;

    if ((setP1 - setP2) == 1)
    {
        score = ((distanceBC * 10) + (100 - (healthP1 - 25)));
        Console.WriteLine("A: Non-fighter        Health:" + (HealthA) + "           Score:0");
        Console.WriteLine("B: Survivor           Health:" + (healthP1 - 25) + "           Score:" + score);
        Console.WriteLine("C: Defeated           Health:0           Score:0");

        if (distanceAB > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAB <= 15)
        {
            Console.WriteLine("Round 2 : A-B");
            score = ((distanceBC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAB * 10) + (100 - (HealthA - 25)));

            Console.WriteLine("A: Survivor           Health:" + (HealthA - 25) + "           Score:" + (score2));
            Console.WriteLine("B: Defeat             Health:0"  + "           Score:" + (score));
            Console.WriteLine("C: Defeated           Health:0           Score:0");

            if (score < score2)
            {
                Console.WriteLine("A has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("B has the maximum score " + ((score)));

        }
    }

    if ((setP1 - setP2) == -1)
    {
        score = ((distanceBC * 10) + (100 - (healthP2 - 25)));
        Console.WriteLine("A: Non-fighter        Health:" + (HealthA) + "           Score:0");
        Console.WriteLine("B: Defeated           Health:0           Score:0");
        Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + score);

        if (distanceAC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAC <= 15)
        {
            Console.WriteLine("Round 2 : A-C");
            score = ((distanceBC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAC * 10) + (100 - (HealthA - 25)));

            Console.WriteLine("A: Survivor           Health:" + (HealthA - 25) + "           Score:" + (score2));
            Console.WriteLine("B: Defeated           Health:0           Score:0");
            Console.WriteLine("C: Defeat             Health:0" + "           Score:" + (score));

            if (score < score2)
            {
                Console.WriteLine("A has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("C has the maximum score " + ((score)));

        }
    }

    if ((setP1 - setP2) == -2)
    {
        score = ((distanceBC * 10) + (100 - (healthP1 - 25)));
        Console.WriteLine("A: Non-fighter        Health:" + HealthA + "           Score:0");
        Console.WriteLine("B: Survivor           Health:" + (healthP1 - 25) + "           Score:" + score);
        Console.WriteLine("C: Defeated           Health:0           Score:0");

        if (distanceAB > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAB <= 15)
        {
            Console.WriteLine("Round 2 : A-B");
            score = ((distanceBC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAB * 10) + (100 - (HealthA - 25)));
            Console.WriteLine("A: Survivor           Health:" + (HealthA - 25) + "            Score:" + (score2));
            Console.WriteLine("B: Defeat             Health:0"  + "           Score:" + (score));
            Console.WriteLine("C: Defeated           Health:0            Score:0");

            if (score < score2)
            {
                Console.WriteLine("A has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("B has the maximum score " + ((score)));


        }
    }

    if ((setP1 - setP2) == 2)
    {
        score = ((distanceBC * 10) + (100 - (healthP2 - 25)));
        Console.WriteLine("A: Non-fighter        Health:" + (HealthA) + "           Score:0");
        Console.WriteLine("B: Defeated           Health:0           Score:0");
        Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + score);

        if (distanceAC > 15)
        {
            Console.WriteLine("The distance between players not suitable for round 2");
        }


        if (distanceAC <= 15)
        {
            Console.WriteLine("Round 2 : A-C");
            score = ((distanceBC * 10) + (100 - (healthP1 - 25)));
            score2 = ((distanceAC * 10) + (100 - (HealthA - 25)));

            Console.WriteLine("A: Survivor           Health:" + (HealthA - 25) + "           Score:" + (score2));
            Console.WriteLine("B: Defeated           Health:0           Score:0");
            Console.WriteLine("C: Defeat             Health:0" + "           Score:" + (score));

            if (score < score2)
            {
                Console.WriteLine("A has the maximum score " + ((score2)));

            }
            else if (score == score2)
            {
                Console.WriteLine("A an C are have maximum score.");
            }
            else
                Console.WriteLine("C has the maximum score " + ((score)));

        }
    }
}

chosendistance = Convert.ToInt32(chosendistance);
Console.ReadKey();

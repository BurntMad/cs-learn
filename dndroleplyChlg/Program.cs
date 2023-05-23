// ** Role playing game battle challenge
// todo - write code to implement the game rules
// * 1. use either the do-while statement or the while statement as an outer game loop.
// * 2. the hero and the monster will start with 10 health points each.
// * 3. all attacks will be a value between 1 - 10
// * 4. the hero will attack the monster first.
// * 5. print the amount of health the monster has lost, and their remaining health.
// * 6. if the monster is still alive, (health greater than 0) it attacks the hero.
// * 7. print the amount of health the hero has lost, and their remaining health.
// * 8. continue this sequence until either the monster's health or the hero's health is zero or less.
// * 9. print the winner.

/* 
? Output should look like this:
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
 */

int heroHealth = 10;
int monsterHealth = 10;

int attackValue = 0;

Random rand = new Random();

do
{
    attackValue = rand.Next(1, 11);
    monsterHealth -= attackValue;
    Console.WriteLine($"Monster was damaged and lost {attackValue} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    attackValue = rand.Next(1, 11);
    heroHealth -= attackValue;
    Console.WriteLine($"Hero was damaged and lost {attackValue} health and now has {heroHealth} health.");

    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }
} while (true);

// ? possible solution:
/* 
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
 */
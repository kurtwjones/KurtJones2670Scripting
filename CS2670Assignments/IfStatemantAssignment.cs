using UnityEngine;
using System.Collections;

public class IfStatemantAssignment : MonoBehaviour {

    public int weapon = 0;
    public int damage = 0;
    private int sword = 100;
    private int bow = 55;
    private int rock = 10;
    private int hands = 5;
    private int dragonHealth = 50;

	// Use this for initialization
	void Start () {
        
           
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp("space"))
        {
            grabWeapon();
            fightDragon();
        }
        
    }
    void grabWeapon()
    {
        weapon = Random.Range(1, 4);
        switch (weapon)
        {
            case 1:
                print("You have a Sword!");
                damage = sword;
                break;
            case 2:
                print("You have a Bow!");
                damage = bow;
                break;
            case 3:
                print("You have a rock.");
                damage = rock;
                break;
            default:
                print("you have your hands.");
                damage = hands;
                break;
        }
        
    }
    void fightDragon()
    {
        if (damage < dragonHealth)
        {
            print("Your weapon is not strong enough... You Died!");
        }
        else
        {
            print("You slayed the dragon!");
        }
    }
}
/* If statements are just what they sound like. They are conditional statements
 * that perform logic. You can compare two different variables and if the statement
 * is true then it will run that line of code. If it is not true it will not run the code
   This is very usefull but can be limited as some times there are many instances or comparisons
   that would take a ton of statements to cover all of your conditions. It is best to use these
   when things are simple and easy to compare.
 */
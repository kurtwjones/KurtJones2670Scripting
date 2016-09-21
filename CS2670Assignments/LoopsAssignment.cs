using UnityEngine;
using System.Collections;

public class LoopsAssignment : MonoBehaviour {
    int enemyAmount = 0;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space"))
        {
            enemyNumber();
        }
    }
    void enemyNumber()
    {
        
        for (int i = 0; i < 5; i++) ;
        enemyAmount = Random.Range(0, 5);
        if (enemyAmount >= 5)
        {
            print("We are being overrun by the enemy! ");
        }
        if (enemyAmount <= 5)
        {
            print("The enemy is getting stronger.");
        }
        if (enemyAmount == 0)
        {
            print("we are safe...for now.");
        }
    }
}
//Loops are a set of code that runs over and over until the conditions are met.
//there are many types of loops. a for loop runs a set of code a certain number
//of times. A while loop repeates a set of code while the condition is true. a
//do while loop is similar to the while except it runs its code before it looks
//if the statement is true. Loops can help you simplify your code so you can write less.

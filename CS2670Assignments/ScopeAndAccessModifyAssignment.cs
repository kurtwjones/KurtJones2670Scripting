using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifyAssignment : MonoBehaviour {
    public int dogAmount = 2;
    public int catAmount = 1;

    private int dogFood = 10;
    private int catFood = 12;

    // Use this for initialization
    private void groceryList()
    {
        if (catFood < catAmount)
        {

            print("Its time to buy more cat food ");
            int thingsToBuy = 1;
        }
    }


    // Update is called once per frame
    public void Animal() {
        if (dogAmount <= 0)
        {
            print("You don't need to buy dog food anymore");
            int deadDog = dogAmount- dogAmount;
        }
    }
}
/* The scope is the area in which a variable can be used. When a variable is local
 * it usually can be found within a set of currly brackets. an access modifyer is a word
 * that is located in front of a variable found in the class. This word defines its scope.
 * Keywords like public and private are used to either allow its scope to be wider or shorter.
 * Private variables can't be seen in the unity inspector or gui. while public ones can. Public variables can
 * be seen from outside the class. If other scripts need access to a variable you should make it public.
 * anything written in the inspector overides the values in the script. private is the default modifyer
 * if you do not declare its scope.
 */

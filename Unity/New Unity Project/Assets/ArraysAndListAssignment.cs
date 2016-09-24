using UnityEngine;
using System.Collections;

public class ArraysAndListAssignment : MonoBehaviour
{
    public int[] arrayList = { 123, 32, 54, 7 };
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < arrayList.Length; i++)
        {
            print("item number " + i + " has a value of: " + arrayList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
/* arrays are a way of grouping like objects of the same type together such as objects or ints. 
 * you can declare many values at the same time by putting the items in curly braces with each
 * value being followed by a comma. Arrays have a length or how many objects are in the group. 
 * To have an array you must give it a name, a type, square
 * brackets and declare the length. The first unit of an array starts at zero as apposed to
 * one. If you make your array public the information will show up as a list in unity. You can
 * then change any of those values in unity within the information box.
 */

using UnityEngine;
using System.Collections;

public class ArraysAssignment : MonoBehaviour {
    public int[] arrayList = { 123, 32, 54, 7 };
	// Use this for initialization
	void Start () {
        for (int i = 0; i < arrayList.Length; i++)
        {
            print("item number" + arrayList[i] + "has a value of:" + i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
/* arrays are a way of grouping like objects of the same type together such as objects or ints. 
 * you can declare many values at the same time. Arrays have a length or
 * how many objects are in the group. To have an array you must have a name, type, square
 * brackets and declare the length. The first unit of an array starts at zero as apposed to
 * one.
 */

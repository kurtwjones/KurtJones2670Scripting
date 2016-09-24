using UnityEngine;
using System.Collections;

public class InheritanceAssignment : MonoBehaviour {
    const double PI = 3.14;
	// Use this for initialization
	void Start () {
        double radius = 12.5;
        double areaOfCircle = CalculateArea(radius);
        print (areaOfCircle);
	}

    
    private double CalculateArea( double radius) {
        double areaOfCircle = PI * radius;
        return areaOfCircle;
	}
}
/* Inheritance is one of the important parts of object oriented programing. When a class inherits something
 * it gains the features of another such as variables or methods. This means they dont need to be created
 * again. The class that is giving the inheritance is called the parent or base class. The class that 
 * is inheriting is called the child or derived class. When dealing with inheritance it is improtant to
 * understand the scope of objects in your parent class that you might want your child class to have. If
 * your variable is private it cannot be accessed in the child class while protected will be avalible to
 * the child but not to any other classes not in the parent to child relation.
 */

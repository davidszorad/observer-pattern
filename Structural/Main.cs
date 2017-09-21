using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Structural
{
    /*
    Define a one-to-many dependency between objects so that when one object changes 
    state, all its dependents are notified and updated automatically. 

    This structural code demonstrates the Observer pattern in which registered 
    objects are notified of and updated with a state change.

    OUTPUT:
    Observer X's new state is ABC
    Observer Y's new state is ABC
    Observer Z's new state is ABC
    */

    /// <summary>
    /// Main startup class for Structural 
    /// Observer Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainStructural()
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}

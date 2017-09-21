using System;

namespace ObserverPattern
{
    /*
    This real-world code demonstrates the Observer pattern in which registered investors are notified every time a stock changes value.

    
    The classes and objects participating in this pattern are:

    Subject  (Stock)
        knows its observers. Any number of Observer objects may observe a subject
        provides an interface for attaching and detaching Observer objects.
    ConcreteSubject  (IBM)
        stores state of interest to ConcreteObserver
        sends a notification to its observers when its state changes
    Observer  (IInvestor)
        defines an updating interface for objects that should be notified of changes in a subject.
    ConcreteObserver  (Investor)
        maintains a reference to a ConcreteSubject object
        stores state that should stay consistent with the subject's
        implements the Observer updating interface to keep its state consistent with the subject's


    OUTPUT:
    Notified Sorros of IBM's change to $120.10
    Notified Berkshire of IBM's change to $120.10

    Notified Sorros of IBM's change to $121.00
    Notified Berkshire of IBM's change to $121.00

    Notified Sorros of IBM's change to $120.50
    Notified Berkshire of IBM's change to $120.50

    Notified Sorros of IBM's change to $120.75
    Notified Berkshire of IBM's change to $120.75
    */

    /// <summary>
    /// MainApp startup class for Real-World 
    /// Observer Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user
            Console.ReadKey();
        }
    }
}
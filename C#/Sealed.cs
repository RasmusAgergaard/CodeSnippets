using System;

namespace Sealed
{
    class A { }
    sealed class B : A { }
    //class C : B { }           //Error: 'C': cannot derive from sealed type 'B'

    class Base
    {
        public virtual void TestMethod() { }
    }

    class SubClass1 : Base
    {
        public sealed override void TestMethod() { }
    }

    class SubClass2 : SubClass1
    {
        //Method is sealed, and cannot be overridden
        public override void TestMethod() { }
        //If "Subclass1.TestMethod" was not sealed, it would've compiled correctly.
    }
}

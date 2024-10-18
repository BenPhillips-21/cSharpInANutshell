using static System.Console;
WriteLine("Hello World!");
// Above allows us to use WriteLine without the whole name


namespace MyTradingCompany
{
    namespace Common
    {
        class ReportBase {}
    }
    namespace ManagementReporting
    {
        class SalesReport : Common.ReportBase  {}
    }
}
// Names declared in outer namespaces can be used unqualified within inner namespaces


namespace Outer
{
    class Foo { }

    namespace Inner
    {
        class Foo { }

        class Test
        {
            Foo f1;         // = Outer.Inner.Foo
            Outer.Foo f2;   // = Outer.Foo
        }
    }
}
// If the same type name appears in both an inner and an outer namespace, the inner name wins. 


// Repeated namespaces
// You can repeat a namespace declaration, as long as the type names within the namespaces don’t conflict...
namespace Outer.Middle.Inner
{
    class Class1 {}
}

namespace Outer.Middle.Inner
{
    class Class2 {}
}


// Nested using directives
namespace N1
{
    class Class1 {}
}

namespace N2
{
    using N1;

    class Class2 : Class1 {}
}

namespace N2
{
    // class Class3 : Class1 {}  COMPILE TIME ERROR  
}
// See https://aka.ms/new-console-template for more information
using OOPSample.Sales.Domain.Model.Aggregates;
using OOPSample.Shared.Util;

Console.WriteLine("Hello, World!");

SalesOrder salesOrder = new SalesOrder(1, "John Doe", 100.0);   
Console.WriteLine(salesOrder.getOrderString());

SalesOrderItem salesOrderItem = new SalesOrderItem(2, 50.0);
Console.WriteLine(salesOrderItem.getOrderItemString());

////////////////////////////


Guid uuid = SalesOrderItem.GenerateOrderItemId();
string uuidUpper = SalesOrderItem.UpperUuid(uuid);

//string uuidLower = StringExtender.LowerUuid(uuid.ToString());
string uuidLower = uuidUpper.ToLowerUuid();

Console.WriteLine(uuidUpper);
Console.WriteLine(uuidLower);


/////////////77

Console.WriteLine("Ejemplos de delegado:");

SumDelegate sumDelegate = new SumDelegate(Sum._Sum2);
sumDelegate(1, 2);


Action<string> greet = name =>
{
    string greeting = $"Hello {name}!";
    Console.WriteLine(greeting);
};
greet("World");


Func<string, string> greet2 = name =>
{
    string greeting = $"Hello {name}!";
    return greeting;
};

Func<string, bool> cond = name =>
{
    return name.Length > 5;
};
Func<string, bool> cond2 = name => name.Length > 5;


Console.WriteLine(greet2("World"));

///////////////////
///

Sum._Sum3((a, b) => a + b);

Console.WriteLine("");
Console.WriteLine("Ejemplos de eventos:");

SalesOrder salesOrder1 = new SaleOrderComplete(1, "John Doe", 100.0, "COMPLETED");
Console.WriteLine(salesOrder1.GetStatus());

SaleOrderComplete salesOrder2 = new SaleOrderComplete(1, "John Doe", 100.0, "COMPLETED");
Console.WriteLine(salesOrder2.GetStatus());

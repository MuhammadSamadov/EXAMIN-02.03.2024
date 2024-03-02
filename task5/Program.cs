

using task5;

var per= new Person("Enter yor Name","Enter your Address");
System.Console.WriteLine(per.ToString());

var st1=new Student("Muhammad","101mkr","Js",29,10);
st1.SetProgram("C#");
st1.SetYear(18);
st1.SetFee(1000);
System.Console.WriteLine(st1.ToString());
System.Console.WriteLine("------------------");

var st2=new Student("Sunatullo","101mkr","Js",29,10);
st2.SetProgram("Math");
st2.SetYear(25);
st2.SetFee(5000);
st2.SetAddress("Ispechak");
System.Console.WriteLine(st2.ToString());
System.Console.WriteLine("------------------");

var staff1=new Staff("Ahmad","Duabi","Number 1",100);
staff1.SetSchool("Prezidenti");
System.Console.WriteLine(staff1.ToString());
System.Console.WriteLine("------------------");

var staff2=new Staff("Ahmad","Duabi","Number 1",100);
staff2.SetSchool("MTMU 82");
staff2.SetPay(500);
staff2.SetAddress("Canada");
System.Console.WriteLine(staff1.ToString());


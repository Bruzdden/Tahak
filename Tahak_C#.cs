Console.WriteLine("neco); //Printování něčeho
Convet.ToInt32(Console.Readline()); //Input něčeho
Var neco = 55.5; //variabl nemusis pouzit double, pozna to samo
const float = 2.5f; //float je staly, nelze jiz zmenit
if(neco > neco){
}
switch (neco){
case 38:
console.writeLine("ano");
break;
default; //neco jako else u if}
while loop; //dokud to plati
for (urceni; loop; co se deje)
for(;;){} // nekonecny loop
//Methody se muzou volat jinou metodou
static void metoda(int x){ // urci se metoda s x
}
static void halo(){
metoda(40) //volam metodu "metoda" a urcim x jako 40}
//void metoda nevyzaduje return, zatimco ostatni musi, třeba int
//Metoda může volat sama sebe a nazýva se to exit condition
//class se vytvaří - "class jmeno{obsah}"
//instance new vytvaří objekt
/* Encapsulation - ma tyto acces modifikace public, private, protected, internal, protected internal
//Constructors - kdyz je class vytvorena, construktor se vytvori public Claass()
//Destructor - ~Claass()
//Property - setter (vraceni/ psani) getter (cteni)
public string Name { get; set; } //auto implement
//objekt se uklada do heap (dynamic)
//array "int[] b = {neco, halo};"
//vice dimensionalni array int[ , ] arr = new int [3,4];
// array metody - .Rank (kolik má dymenzi) , .Lenght (jak je arr dlouhy)
//array pouziva jenom int a inderex muze mit string, char a tak

Static - static variable se musi povolit jedine pres nazev classy ve ktery je static, to same plati pro static metodu/funkci, vsechny const jsou static
Static class - ma jenom static members

this - v objektu uziva se pro aktualni class
Dedičnost - 
  inheritance/Dědičnost nám umožňuje definovat třídu na základě jiné třídy.
  base class - class Animal
  derived/prevzatá class - class Dog : Animal
  když je class SEALED, tak se z ní nemůže dědit
Polymorphismus (mít více forem) - 
  Jedna metoda může mít více různých implementací
  Virtuální metody umožňují pracovat se skupinami souvisejících objektů jednotným způsobem.
  Metoda override přepíše obsah funkce a může se zdědit
  Shape c = new Circle(); Shape je base class, Circle je derived/dědící class
Abstract classes - 
  deklarace abstraktních metod jsou povoleny pouze v abstraktních třídách
  abstrakt class musi být děděna
  všechno ostatní jsou custom class
Interface (abstrktní class) -
  Může mít jen metody nebo property, nemůže mít variably/containery
  Múže se dědit díky tomu víc class
Nested class - 
  classy v classy (př. motor v autě)
Namespace - poznámka ve kterým se píše cely program

Struct - 
  nemají dědičnost
  classy ale limitovaný
  pro jednoduší ukladaní dat
  je int
Enums - 
  enumator list
  používají se často se Switch
Exception - 
  Error
  Try, Catch (exception e), finally
Files - 
  System.IO - namespace/knihovna
  Příkaz File.neco()

GENERIC:
Generic method/class - 
  <> definuje generic typ
Collections - 
  pomáha k lépe používání dat
  lépe se pracuje s větší skupinou objektů
    Generic collections - 
      using Systems.Collections.Generic;
    non-generic -
      System.Collections
    generic collectins jsou lepší na použití
  List (generic collection)- 
    List<T> Má i podpříkazy
  Sorted list - 
    SortedList<K, V> key/value K = string, V = list
  BitArray - 
    bollean
  Stack
  Queue
  Dictionary
  HashSet

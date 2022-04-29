// See https://aka.ms/new-console-template for more information

using FileHelper;

var fileHelper = new Helper(@"C:\Data\rub.csv");

var rub = fileHelper.ReadAllContact();

Console.WriteLine("*********************");

foreach (var contact in rub)
{
    Console.WriteLine($"nome: {contact.nome} - cognome: {contact.cognome} - telefono: {contact.telefono} - indirizzo: {contact.indirizzo}");
}

Console.WriteLine("*********************");

Console.WriteLine("Inserisci il nome");
var name = Console.ReadLine();
Console.WriteLine("Inserisci il cognome");
var surname = Console.ReadLine();
Console.WriteLine("Inserisci il numero di telefono");
var phone = Console.ReadLine();
Console.WriteLine("Inserisci l'indirizzo");
var address = Console.ReadLine();

var contactnew = new Contact();
contactnew.nome = name;
contactnew.cognome = surname;
contactnew.telefono = phone;
contactnew.indirizzo = address;

fileHelper.AddContact(contactnew);

rub = fileHelper.ReadAllContact();


Console.WriteLine("*********************");

foreach (var contact in rub)
{
    Console.WriteLine($"nome: {contact.nome} - cognome: {contact.cognome} - telefono: {contact.telefono} - indirizzo: {contact.indirizzo}");
}

Console.WriteLine("*********************");


Console.ReadLine();
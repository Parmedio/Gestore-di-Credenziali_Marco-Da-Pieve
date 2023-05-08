using Credential_Manager.PasswordChecker;
using DBManager.Repositories;
using DBManager.Repositories.DBContext;
using DBManager.Services;
using Microsoft.Extensions.Logging;

//var test01 = "G4ttoRo$so";

//var test01_status = PWChecksHandler.GetReport(test01).Item1;
//var test01_report = PWChecksHandler.GetReport(test01).Item2;

//Console.WriteLine($"psw1: {test01}{Environment.NewLine}is valid: {test01_status}{Environment.NewLine}missing requirement:{Environment.NewLine}{test01_report}");

var context = new CredentialContext();
var usersRepository = new UsersRepository(context);
var usersService = new UsersService(usersRepository);

//var receiptContent = usersService.SearchByIDAndPassword(2, "PinkCandy");
//Console.WriteLine(receiptContent.ToString());

//Console.WriteLine();
//Console.WriteLine($"User \"Carmello\" already in database: {usersService.IsAreadyUsername("Carmello")}");
//Console.WriteLine();
//Console.WriteLine($"User \"Citrullo\" already in database: {usersService.IsAreadyUsername("Citrullo")}");

Console.WriteLine(usersService.Insert("Matteo", "Usignolo"));


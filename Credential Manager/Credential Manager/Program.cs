using Credential_Manager.PasswordChecker;
using Credential_Manager.PasswordChecker.Checkers_Decorator;

var test01 = "G4ttoRo$so";

var test01_status = PWChecksHandler.GetReport(test01).Item1;
var test01_report = PWChecksHandler.GetReport(test01).Item2;

Console.WriteLine($"psw1: {test01}{Environment.NewLine}is valid: {test01_status}{Environment.NewLine}missing requirement:{Environment.NewLine}{test01_report}");
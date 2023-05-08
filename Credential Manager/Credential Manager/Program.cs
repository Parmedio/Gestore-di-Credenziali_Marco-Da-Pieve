using Credential_Manager.MailChecker;
using Credential_Manager.PasswordChecker;
using DBManager.Models.Entities;
using DBManager.Repositories;
using DBManager.Repositories.DBContext;
using DBManager.Services;

var context = new CredentialContext();
var usersRepository = new UsersRepository(context);
var usersService = new UsersService(usersRepository);
var MailChecker = new SetupChain().GetChain;
var PWChecker = new PWChecksHandler();

var user01 = new User { UserEmail = "rick.purple@gmail.com", Password = "G4ttoRo$so" }; //ok
var user02 = new User { UserEmail = "nick.purple@gmail.com", Password = "Go" }; // PW criteria problem
var user03 = new User { UserEmail = "rick.purple@gmail.com", Password = "G4ttoRo$so" }; // mail already in DB
var user04 = new User { UserEmail = "rgmail.com", Password = "G4ttoRo$so" }; // mail format problem

void registrationHandler(User user)
{
    var EmailIsValid = MailChecker.ProcessRequest(user.UserEmail).Item1;
    var PWIsValid = PWChecker.GetReport(user.Password).Item1;

    if (EmailIsValid && PWIsValid)
    {
        user.UserId = usersService.Insert(user.UserEmail, user.Password);
        var newUser = usersService.SearchByIDAndPassword(user.UserId, user.Password);
        Console.WriteLine($"New account succesfully registered:\n{newUser.ToString()}");
    }
    else
    {
        Console.WriteLine("Can't register new user:");
        if (!EmailIsValid)
            Console.WriteLine($"{MailChecker.ProcessRequest(user.UserEmail).Item2}");
        if (!PWIsValid)
            Console.WriteLine($"{PWChecker.GetReport(user.Password).Item2}");
    }
    Console.WriteLine($"=============================================\n");
}

registrationHandler(user01);
registrationHandler(user02);
registrationHandler(user03);
registrationHandler(user04);


Console.WriteLine("program executed. turn off");
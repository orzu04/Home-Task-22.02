


using task2;

var user = new User();
user.FirstName ="Abdullo";
user.LastName = "Abdulloev";
user.UserName = "Becen";
user.Password = "@12346";
System.Console.WriteLine(user.GetInfo());
user.Login("Becen","@12346");
user.Logout();


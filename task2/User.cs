namespace task2;

public class User
{

    public string FirstName;
    public string LastName;
    public string UserName;
    public string Password;
    public bool IsLogginIn;

    public void Login(string username, string password)
    {

         System.Console.WriteLine($"Your password or username is incorrect");
        if(username== UserName && password == Password)
        {
            System.Console.WriteLine(true);
        }
    
       
    UserName = username;
    Password = password;
    
   

    }

    public void Logout()

    {
    
        
      System.Console.WriteLine($"Your password or username is incorrect");

    }

     public  string  GetInfo()
     {

        return  $" FirsName: {FirstName}\nLastName:  {LastName}";
     }  

}

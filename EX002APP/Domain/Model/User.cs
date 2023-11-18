namespace Model;

public class User

{
    public User(string login)
    {
        this.Password = Guid.NewGuid().ToString().Substring(0,8);
        this.Login = login;
    }
    public string Login {get; set;}
    private string Password {get; set;}

}
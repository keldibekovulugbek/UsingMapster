using UsingMapster;
using Sharprompt;
using UsingMapster.DTOs;

var service  = new UserService();

while (true)
{
    var choose = Prompt.Select("Tanlang: ", new[] { "User yaratish", "Get users" });

    if (choose == "User yaratish")
    {
        var firstName = Prompt.Input<string>("Ism Kiriting:"); 
        var lastName = Prompt.Input<string>("Familiya Kiriting:"); 
        var email = Prompt.Input<string>("Email Kiriting:"); 
        var password = Prompt.Input<string>("Password Kiriting:"); 
        var username = Prompt.Input<string>("Username Kiriting:");


        var user = new UserForCreation()
        {
            Firstname = firstName,
            Lastname = lastName,
            Email = email,
            Password = password,
            UserName = username
        };


        service.Create(user);  
    }
    else if(choose == "Get users")
    {
        var users = service.GetUsers();

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Lastname} {user.Firstname} {user.UserName} {user.CreatedAt}");
            Prompt.Input<string>(" ");
        }
    }

    Console.Clear();
}
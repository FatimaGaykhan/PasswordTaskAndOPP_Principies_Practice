using PasswordTask.Models;

User user = new User("Fatima", "Gaykhanova",22);
Console.WriteLine($"Name:{user.name} Surname:{user.surname} Age:{user.age}");
string result = user.Set("Fatima123");
Console.WriteLine($"Password:{result}");



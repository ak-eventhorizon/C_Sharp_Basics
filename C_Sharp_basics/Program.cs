List<User> users = new List<User>()
{
    new User { Name = "Tom", Age = 33 },
    new User { Name = "Bob", Age = 30 },
    new User { Name = "Tom", Age = 21 },
    new User { Name = "Sam", Age = 43 }
};
 
var sortedUsers = from u in users
                  orderby u.Age descending
                  select u;
 
foreach (User u in sortedUsers)
    Console.WriteLine(u.Name + " " + u.Age);


class User {
    public string? Name{get; set;}
    public int Age{get; set;}
}
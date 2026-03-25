var credentialManager = new CredentialManager();
var library = new Library();

// Seed admin
credentialManager.Register("admin", "Admin@123");

bool running = true;
string currentUser = null;

while(running){
    Console.WriteLine("\n=== Library Credential Manager ===");
    Console.WriteLine(currentUser == null ? "Not signed in" : $"Signed in as {currentUser}");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Change Password");
    Console.WriteLine("4. List Users");
    Console.WriteLine("5. Add Book (requires login)");
    Console.WriteLine("6. Add Patron (requires login)");
    Console.WriteLine("7. Display Books");
    Console.WriteLine("8. Display Patrons");
    Console.WriteLine("9. Logout");
    Console.WriteLine("0. Exit");
    Console.Write("Choice: ");
    var choice = Console.ReadLine();

    switch(choice){
        case "1":
            Console.Write("Username: ");
            var regUser = Console.ReadLine();
            Console.Write("Password: ");
            var regPass = ReadPassword();
            if(credentialManager.Register(regUser, regPass)) Console.WriteLine("Registered successfully.");
            else Console.WriteLine("Register failed: user exists or invalid.");
            break;
        case "2":
            Console.Write("Username: ");
            var loginUser = Console.ReadLine();
            Console.Write("Password: ");
            var loginPass = ReadPassword();
            if(credentialManager.Authenticate(loginUser, loginPass)){
                currentUser = loginUser;
                Console.WriteLine("Login successful.");
            } else {
                Console.WriteLine("Authentication failed.");
            }
            break;
        case "3":
            if(currentUser == null){ Console.WriteLine("Please log in first."); break; }
            Console.Write("Old password: ");
            var oldPass = ReadPassword();
            Console.Write("New password: ");
            var newPass = ReadPassword();
            if(credentialManager.ChangePassword(currentUser, oldPass, newPass)) Console.WriteLine("Password changed.");
            else Console.WriteLine("Change password failed.");
            break;
        case "4":
            Console.WriteLine("Users:");
            foreach(var user in credentialManager.GetUserList()) Console.WriteLine("- " + user);
            break;
        case "5":
            if(currentUser == null){ Console.WriteLine("Please log in first."); break; }
            Console.Write("Book title: ");
            var title = Console.ReadLine();
            Console.Write("Book author: ");
            var author = Console.ReadLine();
            Console.Write("Available copies: ");
            if(int.TryParse(Console.ReadLine(), out int copies)){
                library.AddBook(new Book(title, author, copies));
                Console.WriteLine("Book added.");
            } else {
                Console.WriteLine("Invalid number.");
            }
            break;
        case "6":
            if(currentUser == null){ Console.WriteLine("Please log in first."); break; }
            Console.Write("Patron name: ");
            var name = Console.ReadLine();
            Console.Write("Patron ID: ");
            if(int.TryParse(Console.ReadLine(), out int id)){
                Console.Write("Username for patron: ");
                var pUser = Console.ReadLine();
                library.AddPatron(new Person(name, id, pUser));
                Console.WriteLine("Patron added.");
            } else {
                Console.WriteLine("Invalid ID.");
            }
            break;
        case "7":
            library.DisplayBooks();
            break;
        case "8":
            library.DisplayPatrons();
            break;
        case "9":
            currentUser = null;
            Console.WriteLine("Logged out.");
            break;
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

static string ReadPassword(){
    var sb = new StringBuilder();
    while(true){
        var key = Console.ReadKey(true);
        if(key.Key == ConsoleKey.Enter){
            Console.WriteLine();
            break;
        }
        if(key.Key == ConsoleKey.Backspace && sb.Length > 0){
            sb.Length--;
            Console.Write("\b \b");
            continue;
        }
        if(!char.IsControl(key.KeyChar)){
            sb.Append(key.KeyChar);
            Console.Write("*");
        }
    }
    return sb.ToString();
}

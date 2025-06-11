using System.Xml;

namespace VariablesProjectCSharp_56;

class Program
{
    
    static bool passwordInputed = false;

    static bool passwordCorrect = false;

    static string userPassword = "error";

    static int PasswordStealAttempts = 0;
    
    static void Main(string[] args)
    {

        Console.WriteLine("tell me your password: ");
        
        InputPassword();

    }

    static void isthisyourpassword()
    {
        if (PasswordStealAttempts == 1)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"your password is '{userPassword}', is it?");
            Console.WriteLine($"{userPassword} dose not seem like a good password.");
            Console.WriteLine($"is {userPassword} really your password?");
            
        }

        if (PasswordStealAttempts == 2)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"{userPassword} better be your real password.");
            Console.WriteLine("Please tell me you told me the truth.");
            Console.WriteLine($"is {userPassword} your real password?");

        }

        if (PasswordStealAttempts == 3)
        {
            Console.WriteLine(" ");
            Console.WriteLine("ok my boss is starting to get mad");
            Console.WriteLine("If this is not your real password he might fire me.");
            Console.WriteLine("I dont want to be fired ");
            Console.WriteLine("So tell me");
            Console.WriteLine($"is {userPassword} really your password?");
        }

        if (PasswordStealAttempts == 4)
        {
            Console.WriteLine("so here we are");
            Console.WriteLine("this is the 4th time you have told me your ''password''");
            Console.WriteLine("this time i take it you were smart and told me your real password.");
            Console.WriteLine("you don't want your house burnt down after all");
            Console.WriteLine($"so {userPassword} is your actual password then is it?");
        }
        
        
        passwordCheck();
        
    }

    static void passwordCheck()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Type");
        
        Console.WriteLine("Yes:");
        
        Console.WriteLine("No:");
        
        string PaswordIsCorrect = Console.ReadLine();

        if (PaswordIsCorrect == "yes")
        {
            if (PasswordStealAttempts == 1)
            {
                Console.WriteLine("it is?");
                Console.WriteLine("..(first try boss)..");
                Console.WriteLine("..(they didn't lie to me over and over again this time)..");
            }
            
            Console.WriteLine("Thank you for telling us your personal information.");
            Console.WriteLine("When all your accounts have been hacked please do not be alarmed");
            Console.WriteLine("do not get help.");
            Console.WriteLine("Just let us do our thing");
            Console.WriteLine("Stealing 'This Is What We Do.'");
            
            
            passwordInputed = true;
            System.Environment.Exit(-1);
        }

        if (PaswordIsCorrect == "no")
        {
            if (PasswordStealAttempts == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Why did you lie to me?");
                Console.WriteLine("What is your real password?");
            }
            if (PasswordStealAttempts == 2)
            {
                Console.WriteLine(" ");
                Console.WriteLine("i promise you can trust me");
                Console.WriteLine("i have never done anything to hurt you yet");
                Console.WriteLine("what is your actual password?");
            }

            if (PasswordStealAttempts == 3)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ok");
                Console.WriteLine("so you want to play that way do you?");
                Console.WriteLine("you won't tell me your personal information so i can sell it on the internet without your personal consent will you?");
                Console.WriteLine("i can figure out were you live");
                Console.WriteLine("I can find you and burn EVERYTHING YOU LOVE to the GROUND");
                Console.WriteLine("you dont believe me do you?");
                doYouBeleaveMe();
            }

            if (PasswordStealAttempts == 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("I QUIT");
                System.Environment.Exit(-1);
            }
            
            passwordInputed = false;
            InputPassword();
                
        }
    }

    static void doYouBeleaveMe()
    {
        Console.WriteLine(" ");
        Console.WriteLine("tell me do you believe me");
        
        Console.WriteLine($"Type");
        
        Console.WriteLine("Yes:");
        
        Console.WriteLine("No:");
        
        string bealeafe = Console.ReadLine();

        if (bealeafe == "yes")
        {
            Console.WriteLine(" ");
            Console.WriteLine("i see you don't lack all sense");
            Console.WriteLine("so tell me what is your password?");
            passwordInputed = false;
            InputPassword();
            
        }

        if (bealeafe == "no")
        {
            Console.WriteLine(" ");
            Console.WriteLine("Ok then");
            Console.WriteLine("let me prove it");
            Console.WriteLine("Where do you live");
            Console.WriteLine(" ");
            Console.WriteLine("wait a second");
            Console.WriteLine("i dont think this is working");
            Console.WriteLine("maybe i am bad at my job");
            Console.WriteLine("i cant do this any more");
            Console.WriteLine("i quit");
        }
        
    }
    
     static void InputPassword()
    {

        if (passwordInputed == false)
        {
            userPassword = Console.ReadLine();
            passwordInputed = true;
            PasswordStealAttempts++;
            isthisyourpassword();
        }
            
    }
}
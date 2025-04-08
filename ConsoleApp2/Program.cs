using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {

        //Q1
        //Regtangle r1 = new(50, 60);
        //r1.display_info();
        //IShape S = new Regtangle (50,60);



        // Q2
        //IAuthenticationService authService = new BasicAuthenticationService();
        //Console.WriteLine (authService.AuthenticateUser("mohamedwalid@gmail.com" , "Mody24636"));
        //Console.WriteLine(authService.AuthorizeUser("mohamed"));



        //Q3

        EmailNotificationService A1 = new EmailNotificationService();
        SmsNotificationService   A2 = new SmsNotificationService();
        PushNotificationService  A3 = new PushNotificationService();

        A1.SendNotification("mewalid24636@gmail.com" , "it was better if u not Born");
        A2.SendNotification("mewalid24636@gmail.com" , "it was better if u not Born");
        A3.SendNotification("mewalid24636@gmail.com" , "it was better if u not Born");



    }
}
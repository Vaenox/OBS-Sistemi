// See https://aka.ms/new-console-template for more information
using OBS_Sistemi.Web.Controllers;

Console.WriteLine("Hello, World!");


AnasayfaController controller = new AnasayfaController();

//controller.SaveUser("Yusuf", "1234");

controller.CheckIsUserValid("Yusuf2", "1234");
controller.CheckIsUserValid("Yusuf", "11234");
controller.CheckIsUserValid("Yusuf", "  ");



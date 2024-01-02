using System;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using InstagramTutorial.Models;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Logger;
//using Microsoft.Win32;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace InstagramTutorial
{
    class Program
    {

        ///Start proxy///////////////////////
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption
        (IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        //////end/////////////////////
        
        #region Hidden
        private static UserSessionData user;
        private static IInstaApi api;
        #endregion
        [STAThread]
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            ///////proxy start////////////////
            //int a;
            //bool settingsReturn, refreshReturn;

            //Console.WriteLine("*************Proxy ON OFF*************\n");
            //Console.WriteLine("1 for ON\n");
            //Console.WriteLine("0 for OFF\n");

            //a = Convert.ToInt32(Console.ReadLine());

            //RegistryKey registry = Registry.CurrentUser.OpenSubKey
            //   ("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            //switch (a)
            //{
            //    case 1:
            //        {
            //            registry.SetValue("ProxyEnable", 1);
            //            registry.SetValue
            //            ("ProxyServer", "Your proxy IP:8080");
            //            if ((int)registry.GetValue("ProxyEnable", 0) == 0)
            //                Console.WriteLine("Unable to enable the proxy.");
            //            else
            //                Console.WriteLine("The proxy has been turned on.");
            //            break;
            //        }
            //    case 0:
            //        {
            //            registry.SetValue("ProxyEnable", 0);
            //            registry.SetValue("ProxyServer", 0);
            //            if ((int)registry.GetValue("ProxyEnable", 1) == 1)
            //                Console.WriteLine("Unable to disable the proxy.");
            //            else
            //                Console.WriteLine("The proxy has been turned off.");

            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Invalid Argument!");
            //            Console.ReadKey();
            //            return;
            //        }
            //}
            //registry.Close();
            //settingsReturn = InternetSetOption
            //(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            //refreshReturn = InternetSetOption
            //(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            //Console.WriteLine("Press any key to exit...");
            DataClassesDataContext db = new DataClassesDataContext();
            var users = db.InstaUser.ToList();   
            foreach (var item in users)
            {
                user = new UserSessionData();
                user.UserName = item.UserName;
                user.Password = item.UserPass;
                api = InstaApiBuilder.CreateBuilder()
            .SetUser(user)
            .UseLogger(new DebugLogger(LogLevel.Exceptions))
            .SetRequestDelay(RequestDelay.FromSeconds(24, 24))
            .Build();
                var loginRequest = await api.LoginAsync();
                if (loginRequest.Succeeded)
                {
                    Console.WriteLine("Hesaba daxil olundu!\n\t" + ' ' + user.UserName);
                    var followMe = await api.FollowUserAsync(5050619457);
                    Console.WriteLine("Takip etdi");
                    if (api.IsUserAuthenticated)
                    {
                        var like = await api.LikeMediaAsync("2763249406228924556");
                        var likeResult = await api.LikeMediaAsync("2713999268275093699");

                        Console.WriteLine("Beyenildi");
                        var postcomment3 = await api.CommentMediaAsync("2667665637498709773", "Have You heard the news?-What news ?-Azerbaijan attacked Armenia. You mean Yerevan ?-NO, Karabakh- Is Karabakh Armenian Territory ?-No, it is the independent country.- According to what.I mean.- Who recognizes Karabakh as an independent country ?-Abkhazia and Southern Ossetia.- Are there even such countries ?-Yeah- Who recognizes them ?-Nicaragua and Nauri..-Hold on.- So, let me ask you that, how is Karabakh recognized by official countries and international organizations then ?-As part of Azerbaijan.- How does Armenia recognize Karabakh ? I mean, as an independent county or as a part of Armenia ?-No, Not really ?-Nagorno - Karabakh is occupied by Armenia.Can You dispute that ?-Armenians have always been in Nagorno - Karabakh.- So the UN os wrong ? Say it.");
                        var postcomment1 = await api.CommentMediaAsync("2779336615047874790_5050619457", "Barbar tüm gönderilerinde korkulu rüyan olcam :D");
                        var postcomment2 = await api.CommentMediaAsync("2779336615047874790_5050619457", "Barbar tüm gönderilerinde korkulu rüyan olcam :D");
                        var postcomment4 = await api.CommentMediaAsync("2779336615047874790_5050619457", "Barbar tüm gönderilerinde korkulu rüyan olcam :D");
                        await api.UnFollowUserAsync(11851764767);
                        if (postcomment3.Succeeded && postcomment1.Succeeded)
                        {
                            Console.WriteLine("Komment yazildi");
                        }
                        await api.LogoutAsync();
                        Console.WriteLine("Cixis edildi");
                        Console.WriteLine("____________________________________________");
                    }
                    else
                    {
                        Console.WriteLine("Xeta!Follow etmek mumkun olmadi!\n\t" + ' ');
                        Console.WriteLine("____________________________________________");
                    }
                }
                else
                {
                    Console.WriteLine("Xeta!Hesaba daxil olmaq mumkun deyil.Zehmet olmasa sifre veya istifadeci adini yoxlayin!\n\t" + user.UserName + ' ' + loginRequest.Info.Message);
                    Console.WriteLine("________________________________________________________________________________________________");
                }
            }
            Console.WriteLine("Emeliyyat bitmisdir!!");
            Console.WriteLine("______________________________________________________________________________________________________________________________");
            Console.ReadKey();
        }
    }
}
























//for (int i = 0; i < mediaList.Count; i++)
//{
//    InstaMedia m = mediaList[i];
//    if (m != null && m.Caption != null)
//    {
//        string captionText = m.Caption.Text;
//        if (captionText != null)
//        {
//            if (m.MediaType == InstaMediaType.Image)
//            {
//                for (int x = 0; x < m.Images.Count; x++)
//                {
//                    if (m.Images[x] != null && m.Images[x].URI != null)
//                    {
//                        Console.WriteLine($"\n\t{captionText}\n\t");
//                        string uri = m.Images[x].URI;
//                        Console.Write($"{uri}\n\t");
//                    }
//                }    
//            }
//        }
//    }
//}
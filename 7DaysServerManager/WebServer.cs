using System;
using System.Net;
using System.Threading;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _7DaysServerManager
{
    public partial class Server_Panel_Form : Form
    {

        public HttpListener _listener = new HttpListener();


        public void RunWebServer()
        {
            



            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine("Webserver running...");
                try
                {
                    while (_listener.IsListening)
                    {
                        ThreadPool.QueueUserWorkItem((c) =>
                        {
                            var ctx = c as HttpListenerContext;
                            
                            try
                            {
                                string rstr = GenerateContent(ctx.Request.RawUrl);
                                byte[] buf = Encoding.UTF8.GetBytes(rstr);
                                ctx.Response.ContentLength64 = buf.Length;
                                ctx.Response.OutputStream.Write(buf, 0, buf.Length);
                            }
                            catch { } // suppress any exceptions
                            finally
                            {
                                // always close the stream
                                try
                                {
                                    ctx.Response.OutputStream.Close();
                                }
                                catch {
                                    System.Threading.Thread.Sleep(100);
                                    try
                                    {
                                        ctx.Response.OutputStream.Close();
                                    }
                                    catch
                                    { }
                                }

                            }
                        }, _listener.GetContext());
                        
                    }
                }
                catch (Exception e){
                    Console.WriteLine("WebServer: STOP ON EXCEPTION:\n"+e);
                } // suppress any exceptions
            });
        }

        public void StopWebServer()
        {
            _listener.Stop();
            webserver_running = false;
            //_listener.Close();
        }




        private string GenerateContent(string page)
        {
            


            string rstr="";

            if (page.Contains("widget") && (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "android_allow", null)=="1")
            {
                if(page.Contains((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "android_access_key", null)))
                {
                    if (server_online == true)
                        rstr += "Server: ONLINE;";
                    else
                        rstr += "Server: OFFLINE;";

                    Online_Player_List.Invoke((MethodInvoker)delegate
                    {
                        rstr += "Players: " + Online_Player_List.Items.Count + "/" + maxpl.Value;
                    });

                }
                else
                {
                    rstr += "Wrong Android;access key";
                }
                

            }
            else if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "enable_website", null) == "1")
            {
                string content="", sname = "", ip = "", port_="", serv_onl = "", pl_cnt="", max_pl_cnt="", for_url="";
                Online_Player_List.Invoke((MethodInvoker)delegate
                {
                    if (page.Contains("rules"))
                        content = rules_content.Text;
                    else
                        content = www_main_content.Text;

                    sname = server_nazwa.Text;
                    ip = Public_IP_Address_Label.Text;
                    if (server_online)
                        serv_onl = "ONLINE";
                    else
                        serv_onl = "OFFLINE";

                    port_ = port.Text;
                    pl_cnt = Convert.ToString(Online_Player_List.Items.Count);
                    max_pl_cnt = Convert.ToString(maxpl.Value);
                    for_url = forum_url.Text;
                });


                rstr += "<html> <head> <title>{server_name}</title> <link rel=\"stylesheet\" type=\"text/css\" href=\"https://fonts.googleapis.com/css?family=Permanent+Marker\"> <link rel=\"stylesheet\" type=\"text/css\" href=\"https://fonts.googleapis.com/css?family=Boogaloo\"> <style> body { background-color: black; background-image: url('{img_1}'); background-size: auto 100%; background-repeat: no-repeat; background-attachment: fixed; background-position: top; } #footer { color: #666; position: fixed; bottom: 0px; width: 1000px; height: 35px; left: calc(50% - 500px); text-align: center; font-size: 10px; } #footer a{ text-decoration: none; color: #888; } #logo{ position: fixed; width: 800px; left: calc(50% - 450px); top: 20px; vertical-align: middle; text-align: center; z-index: 2; } #logo img { vertical-align: middle; } #logo span { display: inline-block; vertical-align: 80%; font-size: 50px; font-family: 'Permanent Marker', cursive; text-shadow: 4px 4px 2px rgba(200, 0, 0, 1); } #content{ left: calc(50% - 500px); top: 150px; position: fixed; width: 1000px; min-height: 600px; z-index: 1; opacity: 0.97; background-image: url('{img_2}'); /*Downloaded from http://subtlepatterns.com*/ border-radius: 10px 10px 10px 10px; padding: 50px; padding-top: 130px; font-family: 'Boogaloo'; font-size: 20px; } #status{ position: fixed; width: 200px; left: calc(50% - 480px); top: 160px; z-index: 2; font-family: 'Boogaloo'; font-size: 20px; } #menu{ position: fixed; width: 400px; left: calc(50% + 195px); top: 160px; z-index: 2; font-family: 'Boogaloo'; font-size: 35px; } #menu a{ padding-left:50px; text-decoration: none; color: black; } </style> </head> <body> <div id=\"logo\"> <img src=\"{img_3}\"> <span>{server_name}</span> </div> <div id=\"status\"> Server: {server_is_online}<br>Players: {server_players}/{server_players_max} </div> <div id=\"menu\"> <a href=\"/\">Home</a> <a href=\"{forum_url}\">Forum</a> <a href=\"rules\">Rules</a> </div> <div id=\"content\">{internal_content}</div> {internal_footer} </body> </html>";


                if ((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\pionner\7DSM\" + profile_name, "hide_footer", null) != "1")
                    rstr = rstr.Replace("{internal_footer}", "<div id=\"footer\"> Content &copy; {server_name}.<br>Website created with <a href=\"https://7dsm.smartmoose.org\" target=\"_blank\">7 Days Server Manager</a>. </div>");
                else
                    rstr = rstr.Replace("{internal_footer}", "");





                    rstr = rstr.Replace("{internal_content}", content);

                rstr = rstr.Replace("{server_name}", sname)
                    .Replace("{server_ip}", ip)
                    .Replace("{server_is_online}", serv_onl)
                    .Replace("{server_port}", port_)
                    .Replace("{server_players}", pl_cnt)
                    .Replace("{server_players_max}", max_pl_cnt)
                    .Replace("{forum_url}", for_url);




                rstr = rstr.Replace("{img_1}", Base64_img(1)).Replace("{img_2}", Base64_img(2)).Replace("{img_3}", Base64_img(3));
            }
            else
            {
                return null;
            }




            
                
            return rstr;
        }
    }

}
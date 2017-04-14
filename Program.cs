using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace SFTP
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //string source = @"D:\D_Drive\Help.pdf";
        //    //string destination = "";
        //    //string host = "sdfsdfs";
        //    //string username = "ubunsdfdssdfdsftu";
        //    //string password = "%sdfdsfsdf?MTV";
        //    //int port = 22;  //Port 22 is defaulted for SFTP upload

        //    //sftp.UploadSFTPFile(host, username, password, source, destination, port);


        //    ///////////////////////////////////////////////////////////


        //    var localPath = @"D:\D_Drive\download\";
        //    var fileName = "EasierJSAngular-08.mov";
        //    var uploadFullPath = @"D:\D_Drive\download\";

        //    var keyFile = new PrivateKeyFile(@"D:\D_Drive\wavedevelopment.pem");
        //    var keyFiles = new[] { keyFile };
        //    var username = "sdfdsfdsf";

        //    var methods = new List<AuthenticationMethod>();
        //    methods.Add(new PasswordAuthenticationMethod(username, "password"));
        //    methods.Add(new PrivateKeyAuthenticationMethod(username, keyFiles));

        //    Console.WriteLine("Start of upload...");
        //    DateTime dtStart = DateTime.Now;
        //    var con = new ConnectionInfo("dsfsdfdsf", 22, username, methods.ToArray());
            
        //    using (var client = new SftpClient(con))
        //    {
        //        client.Connect();

        //        //uploading
        //        using (var fs = new FileStream(uploadFullPath + fileName, FileMode.Open))
        //        {
        //            client.UploadFile(fs, "/var/www/html/Test/" + fileName);
        //            fs.Close();
        //        }

        //        //downloading
        //        //var files = client.ListDirectory("/var/www/html/Test/");
        //        //foreach (var file in files)
        //        //{
        //        //    if (file.IsRegularFile)
        //        //    {
        //        //        Console.WriteLine(file);
        //        //        using (var fs = new FileStream(localPath + file.Name, FileMode.Create))
        //        //        {
        //        //            client.DownloadFile(file.FullName, fs);
        //        //            fs.Close();
        //        //        }
        //        //    }
        //        //}

        //        client.Disconnect();
        //    }
        //    DateTime dtEnd = DateTime.Now;

        //    double ts = (dtEnd - dtStart).TotalSeconds;

        //    Console.WriteLine("Time to upload:{0} seconds", ts);
        //    Console.WriteLine("End of upload...");
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            // Get the object used to communicate with the server.  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("dfhgjhfjf");  
            request.Method = WebRequestMethods.Ftp.UploadFile;  
  
            // This example assumes the FTP site uses anonymous logon.  
            request.Credentials = new NetworkCredential("sssss","dddddddddd");  
  
            var uploadFullPath = @"D:\D_Drive\download\Help.pdf";

            // Copy the contents of the file to the request stream.  
            StreamReader sourceStream = new StreamReader(uploadFullPath);
            byte [] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());  
            sourceStream.Close();  
            request.ContentLength = fileContents.Length;  
  
            Stream requestStream = request.GetRequestStream();  
            requestStream.Write(fileContents, 0, fileContents.Length);  
            requestStream.Close();  
  
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();  
  
            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);  
  
            response.Close();  
            }  
                
        
    }
}

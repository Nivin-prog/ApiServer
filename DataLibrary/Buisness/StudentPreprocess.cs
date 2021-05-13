using MySampleProject.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Configuration;

namespace DataLibrary.Buisness
{
    public class StudentPreprocess
    {
        public static string GetConnectionUrl(string connectionName)
        {
            return ConfigurationManager.AppSettings[connectionName];
        }
       
        public static List<Student> LoadEmployees1()
        {
            List < Student > objlist = new List<Student>();
            string url = GetConnectionUrl("GETALL");
            WebRequest tRequest = WebRequest.Create(url);
            tRequest.Method = "GET";
            WebResponse response = tRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            var responce = responseReader.ReadToEnd();
        
            objlist = (List<Student>)JsonConvert.DeserializeObject(responce, typeof(List<Student>));
            return objlist;
        }


        public static List<Student> LoadEmployee(int ID)
        {
            List<Student> objlist = new List<Student>();
            string url = GetConnectionUrl("GETALL");
            url = string.Concat(url, "/", ID);
            WebRequest tRequest = WebRequest.Create(url);
            tRequest.Method = "GET";
            WebResponse response = tRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            var responce = responseReader.ReadToEnd();

            objlist = (List<Student>)JsonConvert.DeserializeObject(responce, typeof(List<Student>));
            return objlist;
        }

        public static string UpdateData(Student details, int Id)
        {
            string url = GetConnectionUrl("GETALL");
            url = string.Concat(url, "/", Id);
            WebRequest tRequest = WebRequest.Create(url);
            tRequest.Method = "POST";
            tRequest.ContentType = "application/json";
            string json = JsonConvert.SerializeObject(details);
            Byte[] byteArray = Encoding.UTF8.GetBytes(json);
            tRequest.ContentLength = byteArray.Length;
            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

                       
            WebResponse response = tRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            string responce = responseReader.ReadToEnd();

           
            return responce;
        }

        public static string CreateNewData(Student details)
        {
            string url = GetConnectionUrl("GETALL");
            
            WebRequest tRequest = WebRequest.Create(url);
            tRequest.Method = "POST";
            tRequest.ContentType = "application/json";
            string json = JsonConvert.SerializeObject(details);
            Byte[] byteArray = Encoding.UTF8.GetBytes(json);
            tRequest.ContentLength = byteArray.Length;
            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();


            WebResponse response = tRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            string responce = responseReader.ReadToEnd();


            return responce;
        }


    }
}

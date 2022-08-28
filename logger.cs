using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;



namespace Game
{
    public class Log
    {


        public string time;
        public string typeOfMessage;
        public string textOfMessage;
        public XmlDocument xDoc;
        public
        Log()
        {
            time = DateTime.Now.ToString();
            typeOfMessage = "EmptyType";
            textOfMessage = "EmptyMessage";
            xDoc = new XmlDocument();
        }

        Log(string type, string text)
        {
            time = DateTime.Now.ToString();
            typeOfMessage = type;
            textOfMessage = text;
           
        }

        public void setText(string str)
        {
            this.textOfMessage = str;
        }

    }
    public class Logger
    {

        XmlDocument logs;
        public Log newLog;
       

        public Logger()
        {
            newLog = new Log();
            logs = new XmlDocument();
            Console.WriteLine(this.newLog.typeOfMessage);

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Log));
            try
            {
                using (Stream fStream = File.Create("log.xml"))
                {
                    xmlFormat.Serialize(fStream, this.newLog);

                }

                Console.WriteLine("XmlSerialize OK!\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        void WriteMessage(string str)
        {
            this.newLog.setText(str);


        }

       public void redordLog(string typeOfMess, string TextOfMess)
        {
          //  Console.WriteLine("start log");

            try
            {
            
                this.logs.Load("log.xml");
              //  Console.WriteLine("1");
                XmlNode root = logs.DocumentElement;
              //  Console.WriteLine("1.5");
                XmlNode newlog = logs.CreateElement("next_log");
              //  Console.WriteLine("2");
                XmlNode node1 = logs.CreateElement("Time");
             //   Console.WriteLine("3");
                XmlNode node2 = logs.CreateElement("typeOfMessage");
            //    Console.WriteLine("4");
                XmlNode node3 = logs.CreateElement("textOfMessage");
             //   Console.WriteLine("5");
                XmlNode text1 = logs.CreateTextNode(DateTime.Now.ToString());
             //   Console.WriteLine("6");
                XmlNode text2 = logs.CreateTextNode(typeOfMess);
            //    Console.WriteLine("7");
               
                XmlNode text3 = logs.CreateTextNode(TextOfMess);
             //   Console.WriteLine("8");
                node1.AppendChild(text1);
                node2.AppendChild(text2);
                node3.AppendChild(text3);
                newlog.AppendChild(node1);
                newlog.AppendChild(node2);
                newlog.AppendChild(node3);
                root.AppendChild(newlog);
                logs.Save("log.xml");
                Console.WriteLine("Log save sucsessful\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }

}




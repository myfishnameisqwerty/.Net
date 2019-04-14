
using System.IO;
using System.Xml.Serialization;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737
{
   public class LastAppSession
    {

        
        public string LastAccessToken { get; set; }
        private  string m_FilePath;


        public LastAppSession()
        {
           
            LastAccessToken = string.Empty;
            m_FilePath = LoadFilePath(@"Resources\LastAppSession.xml");
        }


        public static string LoadFilePath(string i_FilePath)
        {
            


            string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string file = Path.Combine(projectFolder, i_FilePath);
            

            return file;
        }




        public void WriteToFile()
        {


            using (FileStream stream = new FileStream(m_FilePath, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LastAppSession));
                serializer.Serialize(stream,this);
            }
        }

        public static LastAppSession ReadFromFile(string i_FilePath)//The method has to get file path suffix to pass it to LoadfromFile
        {
            LastAppSession sessionParameters = new LastAppSession();

            string file = LoadFilePath(i_FilePath);

                using (Stream stream = new FileStream(file, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LastAppSession));
                    sessionParameters = serializer.Deserialize(stream) as LastAppSession;
                }
            

            return sessionParameters;

        }

        public void RemoveLastAppSessionXML()
        {
            if (File.Exists(m_FilePath))
            {
                File.Delete(m_FilePath);
            }
        }
             
    }
}

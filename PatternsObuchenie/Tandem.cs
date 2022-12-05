using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;

namespace PatternsObuchenie
{
    interface IXML
    {
        void XMLReturn(Serialize_PIVO_tandem pivo);
    }
    class TandemJson
    {
        public void JsonReturn(Serialize_PIVO_tandem pivo)
        {
            JsonSerializer jserializ = new JsonSerializer();
            using(StreamWriter sw = new StreamWriter(@"C:\Users\MohenTohen\source\repos\KOLYAN.json"))
            using(JsonWriter jw = new JsonTextWriter(sw))
            {
                jserializ.Serialize(jw, pivo);
            }
        }
    }
    class Adapter_kotoryi_Singleton: IXML
    {
        public void XMLReturn(Serialize_PIVO_tandem pivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serialize_PIVO_tandem));
            using (FileStream fs = new FileStream(@"C:\Users\MohenTohen\source\repos\PIVO.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, pivo);
            }
        }
        private TandemJson Tjson = new TandemJson();
        public void JsonVozvrat(Serialize_PIVO_tandem pivo)
        {
            this.Tjson.JsonReturn(pivo);
        }
        private Adapter_kotoryi_Singleton()
        {

        }
        private static Adapter_kotoryi_Singleton _instance;
        public static Adapter_kotoryi_Singleton GetInstance2()
        {
            if(_instance == null)
            {
                _instance = new Adapter_kotoryi_Singleton();
            }
            return _instance;
        }
    }
    [Serializable]
    public class Serialize_PIVO_tandem
    {
        public string name_napitok = "PIVO";
        public string takzhe_ya = "i etot chsmoshnik (hamilton)";
        public int litry_piva = 497;
    }
}

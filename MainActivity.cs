using System;

namespace DistroDL
{
    public struct distroDB
    {
        public string name;
        public string version;
        public string url;
    }

    internal class JSONParser //TODO: Make a simple jsonparser
    {
        public void Parse()
        {
            return;
        }
        public string Sort(string status)
        {
            return status = "zero";
        }
    }
    internal class DistroDL
    {
        distroDB dbStruct = new distroDB();

        public void DLDistro(string distroname)
        {
            Console.WriteLine("DistroDL -> Requested download of {0} - {1} from link found {2}", dbStruct.name, dbStruct.version, dbStruct.url);
            return;

        }

        public void Init()
        {
            return; //TODO: Make an initializer for DistroDB/DistroDL
        }
    }
}


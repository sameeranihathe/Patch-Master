using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Xml;

namespace Patch_Master.DbContext.QueryReader
{
    public static class SqlQueryStringReader
    {
        private static string ReadQueryStringFromFile(string id,string xmlfilename)
        {
            var filePath = ConfigurationManager.AppSettings["XmlQueryPath"] + xmlfilename + ".xml";

            using (var reader = new XmlTextReader(filePath))
            {
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "SqlQueryString")
                    {
                        string currentId = reader.GetAttribute("Id");
                        if (currentId == id)
                        {
                            reader.Read();
                            return reader.Value;
                        }
                    }
                }
            }
            return null;
        }

        public static string GetQueryStringById(string id, string xmlfilename)
        {
            return ReadQueryStringFromFile(id, xmlfilename);
        }


        public static IDictionary<string, string> GetQueries(string xmlFileName)
        {
            return GetQueries(xmlFileName, null);
        }
        public static IDictionary<string,string> GetQueries(string xmlFileName, string prefix)
        {
            var queries = new Dictionary<string, string>();
            var filePath = ConfigurationManager.AppSettings["XmlQueryPath"] + xmlFileName + ".xml";
            var matchPrefix = !string.IsNullOrEmpty(prefix);

            using (var reader = new XmlTextReader(filePath))
            {
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "SqlQueryString")
                    {
                        string currentId = reader.GetAttribute("Id");
                        if(!matchPrefix || currentId.StartsWith(prefix,System.StringComparison.InvariantCulture))
                        {
                            reader.Read();
                            queries.Add(currentId, reader.Value);
                        }
                    }
                }
            }
            return queries;
        }
    }
}

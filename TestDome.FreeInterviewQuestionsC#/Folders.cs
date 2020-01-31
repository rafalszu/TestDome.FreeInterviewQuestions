using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TestDome.FreeInterviewQuestionsC
{
    /*
    Implement a function FolderNames, which accepts a string containing an XML file that specifies folder structure and returns all folder names that start 
    with startingLetter. The XML format is given in the example below.

    For example, for the letter 'u' and XML file:

    <?xml version="1.0" encoding="UTF-8"?>
    <folder name="c">
        <folder name="program files">
            <folder name="uninstall information" />
        </folder>
        <folder name="users" />
    </folder>
    */
    public class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            if(string.IsNullOrWhiteSpace(xml))
                return null;

            XDocument xdoc = XDocument.Parse(xml);
            var desc = xdoc.Descendants();
            
            return desc.Where(x => x.Attribute("name") != null && x.Attribute("name").Value.StartsWith(startingLetter.ToString()))
            .Select(x => x.Attribute("name").Value);
        }

        public static void Execute(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'u'))
                Console.WriteLine(name);
        }
    }
}
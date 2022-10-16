
using System.Net.NetworkInformation;

using Microsoft.VisualBasic.FileIO;



using (TextFieldParser parser = new TextFieldParser(@"D:\Sapienza\SapienzaCourses\Statistics\Blog\user0x1234.github.io\code\HomeWork2\test.csv"))
{
    parser.TextFieldType = FieldType.Delimited;
    parser.SetDelimiters(",");
    while (!parser.EndOfData)
    {
        //Processing row
        string[] fields = parser.ReadFields();
        foreach (string field in fields)
        {
            //TODO: Process field
            Console.Write(field);
        }
    }
}
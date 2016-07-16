using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public static String Error;
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    public string SearchWSDL(string WsdlURL)
    {
        StringBuilder sb = new StringBuilder();
        ArrayList list = new ArrayList();
        XmlTextReader reader = new XmlTextReader(WsdlURL);
        while (reader.Read())
        {
            string name = reader.Name;
            if (name.Contains("wsdl:operation"))
            {
                if (reader.AttributeCount != 0 && !list.Contains(reader.GetAttribute(0)))
                {
                    list.Add(reader.GetAttribute(0));
                    sb.Append(reader.GetAttribute(0));
                    sb.Append(" ");
                }
            }
        }
        return sb.ToString();
    }
    public string Verification(string xmlURL, string xsdURL)
      {
          Error = "";
          // Create the XmlSchemaSet class.
          XmlSchemaSet sc = new XmlSchemaSet();
          sc.Add(null, xsdURL);
          // Set the validation settings.
          XmlReaderSettings settings = new XmlReaderSettings();
          settings.ValidationType = ValidationType.Schema;
          settings.Schemas = sc;
          settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
          XmlReader reader = XmlReader.Create(xmlURL, settings);
          while (reader.Read()) ;
          if (Error == "") Error = "NO Error";
          return Error;
      }
    // Display any validation errors. 
    private static void ValidationCallBack(object sender, ValidationEventArgs e)
    {
        Error = Error+"Validation Error: "+e.Message;
    }
 }


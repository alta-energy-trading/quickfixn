// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class XML_Non_FIX : Message
        {
            public const string MsgType = "n";

            public XML_Non_FIX() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("n"));
            }

            public XML_Non_FIX(
                    QuickFix.Fields.XmlDataLen aXmlDataLen,
                    QuickFix.Fields.XmlData aXmlData
                ) : this()
            {
                this.XmlDataLen = aXmlDataLen;
                this.XmlData = aXmlData;
            }

            public QuickFix.Fields.XmlDataLen XmlDataLen
            { 
                get 
                {
                    QuickFix.Fields.XmlDataLen val = new QuickFix.Fields.XmlDataLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.XmlDataLen val) 
            { 
                this.XmlDataLen = val;
            }
            
            public QuickFix.Fields.XmlDataLen Get(QuickFix.Fields.XmlDataLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.XmlDataLen val) 
            { 
                return IsSetXmlDataLen();
            }
            
            public bool IsSetXmlDataLen() 
            { 
                return IsSetField(Tags.XmlDataLen);
            }
            public QuickFix.Fields.XmlData XmlData
            { 
                get 
                {
                    QuickFix.Fields.XmlData val = new QuickFix.Fields.XmlData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.XmlData val) 
            { 
                this.XmlData = val;
            }
            
            public QuickFix.Fields.XmlData Get(QuickFix.Fields.XmlData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.XmlData val) 
            { 
                return IsSetXmlData();
            }
            
            public bool IsSetXmlData() 
            { 
                return IsSetField(Tags.XmlData);
            }
        }
    }
}

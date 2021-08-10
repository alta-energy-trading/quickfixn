// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Logon : Message
        {
            public const string MsgType = "A";

            public Logon() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("A"));
            }

            public Logon(
                    QuickFix.Fields.EncryptMethod aEncryptMethod,
                    QuickFix.Fields.HeartBtInt aHeartBtInt,
                    QuickFix.Fields.ApplicationSystemName aApplicationSystemName,
                    QuickFix.Fields.TradingSystemVersion aTradingSystemVersion,
                    QuickFix.Fields.ApplicationSystemVendor aApplicationSystemVendor
                ) : this()
            {
                this.EncryptMethod = aEncryptMethod;
                this.HeartBtInt = aHeartBtInt;
                this.ApplicationSystemName = aApplicationSystemName;
                this.TradingSystemVersion = aTradingSystemVersion;
                this.ApplicationSystemVendor = aApplicationSystemVendor;
            }

            public QuickFix.Fields.EncryptMethod EncryptMethod
            { 
                get 
                {
                    QuickFix.Fields.EncryptMethod val = new QuickFix.Fields.EncryptMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptMethod val) 
            { 
                this.EncryptMethod = val;
            }
            
            public QuickFix.Fields.EncryptMethod Get(QuickFix.Fields.EncryptMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptMethod val) 
            { 
                return IsSetEncryptMethod();
            }
            
            public bool IsSetEncryptMethod() 
            { 
                return IsSetField(Tags.EncryptMethod);
            }
            public QuickFix.Fields.HeartBtInt HeartBtInt
            { 
                get 
                {
                    QuickFix.Fields.HeartBtInt val = new QuickFix.Fields.HeartBtInt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HeartBtInt val) 
            { 
                this.HeartBtInt = val;
            }
            
            public QuickFix.Fields.HeartBtInt Get(QuickFix.Fields.HeartBtInt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HeartBtInt val) 
            { 
                return IsSetHeartBtInt();
            }
            
            public bool IsSetHeartBtInt() 
            { 
                return IsSetField(Tags.HeartBtInt);
            }
            public QuickFix.Fields.ResetSeqNumFlag ResetSeqNumFlag
            { 
                get 
                {
                    QuickFix.Fields.ResetSeqNumFlag val = new QuickFix.Fields.ResetSeqNumFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                this.ResetSeqNumFlag = val;
            }
            
            public QuickFix.Fields.ResetSeqNumFlag Get(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                return IsSetResetSeqNumFlag();
            }
            
            public bool IsSetResetSeqNumFlag() 
            { 
                return IsSetField(Tags.ResetSeqNumFlag);
            }
            public QuickFix.Fields.ApplicationSystemName ApplicationSystemName
            { 
                get 
                {
                    QuickFix.Fields.ApplicationSystemName val = new QuickFix.Fields.ApplicationSystemName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplicationSystemName val) 
            { 
                this.ApplicationSystemName = val;
            }
            
            public QuickFix.Fields.ApplicationSystemName Get(QuickFix.Fields.ApplicationSystemName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplicationSystemName val) 
            { 
                return IsSetApplicationSystemName();
            }
            
            public bool IsSetApplicationSystemName() 
            { 
                return IsSetField(Tags.ApplicationSystemName);
            }
            public QuickFix.Fields.TradingSystemVersion TradingSystemVersion
            { 
                get 
                {
                    QuickFix.Fields.TradingSystemVersion val = new QuickFix.Fields.TradingSystemVersion();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSystemVersion val) 
            { 
                this.TradingSystemVersion = val;
            }
            
            public QuickFix.Fields.TradingSystemVersion Get(QuickFix.Fields.TradingSystemVersion val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSystemVersion val) 
            { 
                return IsSetTradingSystemVersion();
            }
            
            public bool IsSetTradingSystemVersion() 
            { 
                return IsSetField(Tags.TradingSystemVersion);
            }
            public QuickFix.Fields.ApplicationSystemVendor ApplicationSystemVendor
            { 
                get 
                {
                    QuickFix.Fields.ApplicationSystemVendor val = new QuickFix.Fields.ApplicationSystemVendor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplicationSystemVendor val) 
            { 
                this.ApplicationSystemVendor = val;
            }
            
            public QuickFix.Fields.ApplicationSystemVendor Get(QuickFix.Fields.ApplicationSystemVendor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplicationSystemVendor val) 
            { 
                return IsSetApplicationSystemVendor();
            }
            
            public bool IsSetApplicationSystemVendor() 
            { 
                return IsSetField(Tags.ApplicationSystemVendor);
            }
            public QuickFix.Fields.SplitMsg SplitMsg
            { 
                get 
                {
                    QuickFix.Fields.SplitMsg val = new QuickFix.Fields.SplitMsg();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SplitMsg val) 
            { 
                this.SplitMsg = val;
            }
            
            public QuickFix.Fields.SplitMsg Get(QuickFix.Fields.SplitMsg val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SplitMsg val) 
            { 
                return IsSetSplitMsg();
            }
            
            public bool IsSetSplitMsg() 
            { 
                return IsSetField(Tags.SplitMsg);
            }
        }
    }
}

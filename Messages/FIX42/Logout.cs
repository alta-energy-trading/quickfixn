// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Logout : Message
        {
            public const string MsgType = "5";

            public Logout() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("5"));
            }

            public Logout(
                    QuickFix.Fields.NextExpectedMsgSeqNum aNextExpectedMsgSeqNum
                ) : this()
            {
                this.NextExpectedMsgSeqNum = aNextExpectedMsgSeqNum;
            }

            public QuickFix.Fields.Text Text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.Text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.NextExpectedMsgSeqNum NextExpectedMsgSeqNum
            { 
                get 
                {
                    QuickFix.Fields.NextExpectedMsgSeqNum val = new QuickFix.Fields.NextExpectedMsgSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                this.NextExpectedMsgSeqNum = val;
            }
            
            public QuickFix.Fields.NextExpectedMsgSeqNum Get(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                return IsSetNextExpectedMsgSeqNum();
            }
            
            public bool IsSetNextExpectedMsgSeqNum() 
            { 
                return IsSetField(Tags.NextExpectedMsgSeqNum);
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

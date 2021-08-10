// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class ExecutionReport : Message
        {
            public const string MsgType = "8";

            public ExecutionReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("8"));
            }

            public ExecutionReport(
                    QuickFix.Fields.Account aAccount,
                    QuickFix.Fields.AvgPx aAvgPx,
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.CumQty aCumQty,
                    QuickFix.Fields.ExecID aExecID,
                    QuickFix.Fields.ExecTransType aExecTransType,
                    QuickFix.Fields.LastPx aLastPx,
                    QuickFix.Fields.LastQty aLastQty,
                    QuickFix.Fields.OrderID aOrderID,
                    QuickFix.Fields.OrdStatus aOrdStatus,
                    QuickFix.Fields.OrdType aOrdType,
                    QuickFix.Fields.SecurityID aSecurityID,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.TradeDate aTradeDate,
                    QuickFix.Fields.SecurityDesc aSecurityDesc,
                    QuickFix.Fields.ExecType aExecType,
                    QuickFix.Fields.ManualOrderIndicator aManualOrderIndicator,
                    QuickFix.Fields.CustOrderHandlingInst aCustOrderHandlingInst,
                    QuickFix.Fields.SecondaryExecID aSecondaryExecID,
                    QuickFix.Fields.RequestTime aRequestTime
                ) : this()
            {
                this.Account = aAccount;
                this.AvgPx = aAvgPx;
                this.ClOrdID = aClOrdID;
                this.CumQty = aCumQty;
                this.ExecID = aExecID;
                this.ExecTransType = aExecTransType;
                this.LastPx = aLastPx;
                this.LastQty = aLastQty;
                this.OrderID = aOrderID;
                this.OrdStatus = aOrdStatus;
                this.OrdType = aOrdType;
                this.SecurityID = aSecurityID;
                this.Side = aSide;
                this.Symbol = aSymbol;
                this.TransactTime = aTransactTime;
                this.TradeDate = aTradeDate;
                this.SecurityDesc = aSecurityDesc;
                this.ExecType = aExecType;
                this.ManualOrderIndicator = aManualOrderIndicator;
                this.CustOrderHandlingInst = aCustOrderHandlingInst;
                this.SecondaryExecID = aSecondaryExecID;
                this.RequestTime = aRequestTime;
            }

            public QuickFix.Fields.Account Account
            { 
                get 
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Account val) 
            { 
                this.Account = val;
            }
            
            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(Tags.Account);
            }
            public QuickFix.Fields.AvgPx AvgPx
            { 
                get 
                {
                    QuickFix.Fields.AvgPx val = new QuickFix.Fields.AvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AvgPx val) 
            { 
                this.AvgPx = val;
            }
            
            public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AvgPx val) 
            { 
                return IsSetAvgPx();
            }
            
            public bool IsSetAvgPx() 
            { 
                return IsSetField(Tags.AvgPx);
            }
            public QuickFix.Fields.ClOrdID ClOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdID val) 
            { 
                this.ClOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.CumQty CumQty
            { 
                get 
                {
                    QuickFix.Fields.CumQty val = new QuickFix.Fields.CumQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CumQty val) 
            { 
                this.CumQty = val;
            }
            
            public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CumQty val) 
            { 
                return IsSetCumQty();
            }
            
            public bool IsSetCumQty() 
            { 
                return IsSetField(Tags.CumQty);
            }
            public QuickFix.Fields.MDTradeEntryID MDTradeEntryID
            { 
                get 
                {
                    QuickFix.Fields.MDTradeEntryID val = new QuickFix.Fields.MDTradeEntryID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MDTradeEntryID val) 
            { 
                this.MDTradeEntryID = val;
            }
            
            public QuickFix.Fields.MDTradeEntryID Get(QuickFix.Fields.MDTradeEntryID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MDTradeEntryID val) 
            { 
                return IsSetMDTradeEntryID();
            }
            
            public bool IsSetMDTradeEntryID() 
            { 
                return IsSetField(Tags.MDTradeEntryID);
            }
            public QuickFix.Fields.ExecID ExecID
            { 
                get 
                {
                    QuickFix.Fields.ExecID val = new QuickFix.Fields.ExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecID val) 
            { 
                this.ExecID = val;
            }
            
            public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecID val) 
            { 
                return IsSetExecID();
            }
            
            public bool IsSetExecID() 
            { 
                return IsSetField(Tags.ExecID);
            }
            public QuickFix.Fields.ExecTransType ExecTransType
            { 
                get 
                {
                    QuickFix.Fields.ExecTransType val = new QuickFix.Fields.ExecTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecTransType val) 
            { 
                this.ExecTransType = val;
            }
            
            public QuickFix.Fields.ExecTransType Get(QuickFix.Fields.ExecTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecTransType val) 
            { 
                return IsSetExecTransType();
            }
            
            public bool IsSetExecTransType() 
            { 
                return IsSetField(Tags.ExecTransType);
            }
            public QuickFix.Fields.LastPx LastPx
            { 
                get 
                {
                    QuickFix.Fields.LastPx val = new QuickFix.Fields.LastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastPx val) 
            { 
                this.LastPx = val;
            }
            
            public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastPx val) 
            { 
                return IsSetLastPx();
            }
            
            public bool IsSetLastPx() 
            { 
                return IsSetField(Tags.LastPx);
            }
            public QuickFix.Fields.LastQty LastQty
            { 
                get 
                {
                    QuickFix.Fields.LastQty val = new QuickFix.Fields.LastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastQty val) 
            { 
                this.LastQty = val;
            }
            
            public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastQty val) 
            { 
                return IsSetLastQty();
            }
            
            public bool IsSetLastQty() 
            { 
                return IsSetField(Tags.LastQty);
            }
            public QuickFix.Fields.OrderID OrderID
            { 
                get 
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Tags.OrderID);
            }
            public QuickFix.Fields.OrderQty OrderQty
            { 
                get 
                {
                    QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderQty val) 
            { 
                this.OrderQty = val;
            }
            
            public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderQty val) 
            { 
                return IsSetOrderQty();
            }
            
            public bool IsSetOrderQty() 
            { 
                return IsSetField(Tags.OrderQty);
            }
            public QuickFix.Fields.OrdStatus OrdStatus
            { 
                get 
                {
                    QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrdStatus val) 
            { 
                this.OrdStatus = val;
            }
            
            public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrdStatus val) 
            { 
                return IsSetOrdStatus();
            }
            
            public bool IsSetOrdStatus() 
            { 
                return IsSetField(Tags.OrdStatus);
            }
            public QuickFix.Fields.OrdType OrdType
            { 
                get 
                {
                    QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrdType val) 
            { 
                this.OrdType = val;
            }
            
            public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrdType val) 
            { 
                return IsSetOrdType();
            }
            
            public bool IsSetOrdType() 
            { 
                return IsSetField(Tags.OrdType);
            }
            public QuickFix.Fields.OrigClOrdID OrigClOrdID
            { 
                get 
                {
                    QuickFix.Fields.OrigClOrdID val = new QuickFix.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigClOrdID val) 
            { 
                this.OrigClOrdID = val;
            }
            
            public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigClOrdID val) 
            { 
                return IsSetOrigClOrdID();
            }
            
            public bool IsSetOrigClOrdID() 
            { 
                return IsSetField(Tags.OrigClOrdID);
            }
            public QuickFix.Fields.Price Price
            { 
                get 
                {
                    QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Price val) 
            { 
                this.Price = val;
            }
            
            public QuickFix.Fields.Price Get(QuickFix.Fields.Price val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Price val) 
            { 
                return IsSetPrice();
            }
            
            public bool IsSetPrice() 
            { 
                return IsSetField(Tags.Price);
            }
            public QuickFix.Fields.SecurityID SecurityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                this.SecurityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.Side Side
            { 
                get 
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Side val) 
            { 
                this.Side = val;
            }
            
            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Side val) 
            { 
                return IsSetSide();
            }
            
            public bool IsSetSide() 
            { 
                return IsSetField(Tags.Side);
            }
            public QuickFix.Fields.Symbol Symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.TimeInForce TimeInForce
            { 
                get 
                {
                    QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeInForce val) 
            { 
                this.TimeInForce = val;
            }
            
            public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeInForce val) 
            { 
                return IsSetTimeInForce();
            }
            
            public bool IsSetTimeInForce() 
            { 
                return IsSetField(Tags.TimeInForce);
            }
            public QuickFix.Fields.TransactTime TransactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.TransactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.TradeDate TradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                this.TradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.SecurityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.ExecType ExecType
            { 
                get 
                {
                    QuickFix.Fields.ExecType val = new QuickFix.Fields.ExecType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecType val) 
            { 
                this.ExecType = val;
            }
            
            public QuickFix.Fields.ExecType Get(QuickFix.Fields.ExecType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecType val) 
            { 
                return IsSetExecType();
            }
            
            public bool IsSetExecType() 
            { 
                return IsSetField(Tags.ExecType);
            }
            public QuickFix.Fields.LeavesQty LeavesQty
            { 
                get 
                {
                    QuickFix.Fields.LeavesQty val = new QuickFix.Fields.LeavesQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LeavesQty val) 
            { 
                this.LeavesQty = val;
            }
            
            public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LeavesQty val) 
            { 
                return IsSetLeavesQty();
            }
            
            public bool IsSetLeavesQty() 
            { 
                return IsSetField(Tags.LeavesQty);
            }
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.ContraTrader ContraTrader
            { 
                get 
                {
                    QuickFix.Fields.ContraTrader val = new QuickFix.Fields.ContraTrader();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContraTrader val) 
            { 
                this.ContraTrader = val;
            }
            
            public QuickFix.Fields.ContraTrader Get(QuickFix.Fields.ContraTrader val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContraTrader val) 
            { 
                return IsSetContraTrader();
            }
            
            public bool IsSetContraTrader() 
            { 
                return IsSetField(Tags.ContraTrader);
            }
            public QuickFix.Fields.ContraBroker ContraBroker
            { 
                get 
                {
                    QuickFix.Fields.ContraBroker val = new QuickFix.Fields.ContraBroker();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContraBroker val) 
            { 
                this.ContraBroker = val;
            }
            
            public QuickFix.Fields.ContraBroker Get(QuickFix.Fields.ContraBroker val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContraBroker val) 
            { 
                return IsSetContraBroker();
            }
            
            public bool IsSetContraBroker() 
            { 
                return IsSetField(Tags.ContraBroker);
            }
            public QuickFix.Fields.TotalNumSecurities TotalNumSecurities
            { 
                get 
                {
                    QuickFix.Fields.TotalNumSecurities val = new QuickFix.Fields.TotalNumSecurities();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalNumSecurities val) 
            { 
                this.TotalNumSecurities = val;
            }
            
            public QuickFix.Fields.TotalNumSecurities Get(QuickFix.Fields.TotalNumSecurities val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalNumSecurities val) 
            { 
                return IsSetTotalNumSecurities();
            }
            
            public bool IsSetTotalNumSecurities() 
            { 
                return IsSetField(Tags.TotalNumSecurities);
            }
            public QuickFix.Fields.ExpireDate ExpireDate
            { 
                get 
                {
                    QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExpireDate val) 
            { 
                this.ExpireDate = val;
            }
            
            public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExpireDate val) 
            { 
                return IsSetExpireDate();
            }
            
            public bool IsSetExpireDate() 
            { 
                return IsSetField(Tags.ExpireDate);
            }
            public QuickFix.Fields.ManualOrderIndicator ManualOrderIndicator
            { 
                get 
                {
                    QuickFix.Fields.ManualOrderIndicator val = new QuickFix.Fields.ManualOrderIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ManualOrderIndicator val) 
            { 
                this.ManualOrderIndicator = val;
            }
            
            public QuickFix.Fields.ManualOrderIndicator Get(QuickFix.Fields.ManualOrderIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ManualOrderIndicator val) 
            { 
                return IsSetManualOrderIndicator();
            }
            
            public bool IsSetManualOrderIndicator() 
            { 
                return IsSetField(Tags.ManualOrderIndicator);
            }
            public QuickFix.Fields.CustOrderHandlingInst CustOrderHandlingInst
            { 
                get 
                {
                    QuickFix.Fields.CustOrderHandlingInst val = new QuickFix.Fields.CustOrderHandlingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CustOrderHandlingInst val) 
            { 
                this.CustOrderHandlingInst = val;
            }
            
            public QuickFix.Fields.CustOrderHandlingInst Get(QuickFix.Fields.CustOrderHandlingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CustOrderHandlingInst val) 
            { 
                return IsSetCustOrderHandlingInst();
            }
            
            public bool IsSetCustOrderHandlingInst() 
            { 
                return IsSetField(Tags.CustOrderHandlingInst);
            }
            public QuickFix.Fields.AvgPxGroupID AvgPxGroupID
            { 
                get 
                {
                    QuickFix.Fields.AvgPxGroupID val = new QuickFix.Fields.AvgPxGroupID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AvgPxGroupID val) 
            { 
                this.AvgPxGroupID = val;
            }
            
            public QuickFix.Fields.AvgPxGroupID Get(QuickFix.Fields.AvgPxGroupID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AvgPxGroupID val) 
            { 
                return IsSetAvgPxGroupID();
            }
            
            public bool IsSetAvgPxGroupID() 
            { 
                return IsSetField(Tags.AvgPxGroupID);
            }
            public QuickFix.Fields.ClearingTradePriceType ClearingTradePriceType
            { 
                get 
                {
                    QuickFix.Fields.ClearingTradePriceType val = new QuickFix.Fields.ClearingTradePriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingTradePriceType val) 
            { 
                this.ClearingTradePriceType = val;
            }
            
            public QuickFix.Fields.ClearingTradePriceType Get(QuickFix.Fields.ClearingTradePriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingTradePriceType val) 
            { 
                return IsSetClearingTradePriceType();
            }
            
            public bool IsSetClearingTradePriceType() 
            { 
                return IsSetField(Tags.ClearingTradePriceType);
            }
            public QuickFix.Fields.MultiLegReportingType MultiLegReportingType
            { 
                get 
                {
                    QuickFix.Fields.MultiLegReportingType val = new QuickFix.Fields.MultiLegReportingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MultiLegReportingType val) 
            { 
                this.MultiLegReportingType = val;
            }
            
            public QuickFix.Fields.MultiLegReportingType Get(QuickFix.Fields.MultiLegReportingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MultiLegReportingType val) 
            { 
                return IsSetMultiLegReportingType();
            }
            
            public bool IsSetMultiLegReportingType() 
            { 
                return IsSetField(Tags.MultiLegReportingType);
            }
            public QuickFix.Fields.SecondaryExecID SecondaryExecID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryExecID val = new QuickFix.Fields.SecondaryExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryExecID val) 
            { 
                this.SecondaryExecID = val;
            }
            
            public QuickFix.Fields.SecondaryExecID Get(QuickFix.Fields.SecondaryExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryExecID val) 
            { 
                return IsSetSecondaryExecID();
            }
            
            public bool IsSetSecondaryExecID() 
            { 
                return IsSetField(Tags.SecondaryExecID);
            }
            public QuickFix.Fields.CrossID CrossID
            { 
                get 
                {
                    QuickFix.Fields.CrossID val = new QuickFix.Fields.CrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossID val) 
            { 
                this.CrossID = val;
            }
            
            public QuickFix.Fields.CrossID Get(QuickFix.Fields.CrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossID val) 
            { 
                return IsSetCrossID();
            }
            
            public bool IsSetCrossID() 
            { 
                return IsSetField(Tags.CrossID);
            }
            public QuickFix.Fields.CrossType CrossType
            { 
                get 
                {
                    QuickFix.Fields.CrossType val = new QuickFix.Fields.CrossType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossType val) 
            { 
                this.CrossType = val;
            }
            
            public QuickFix.Fields.CrossType Get(QuickFix.Fields.CrossType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossType val) 
            { 
                return IsSetCrossType();
            }
            
            public bool IsSetCrossType() 
            { 
                return IsSetField(Tags.CrossType);
            }
            public QuickFix.Fields.AvgPXIndicator AvgPXIndicator
            { 
                get 
                {
                    QuickFix.Fields.AvgPXIndicator val = new QuickFix.Fields.AvgPXIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AvgPXIndicator val) 
            { 
                this.AvgPXIndicator = val;
            }
            
            public QuickFix.Fields.AvgPXIndicator Get(QuickFix.Fields.AvgPXIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AvgPXIndicator val) 
            { 
                return IsSetAvgPXIndicator();
            }
            
            public bool IsSetAvgPXIndicator() 
            { 
                return IsSetField(Tags.AvgPXIndicator);
            }
            public QuickFix.Fields.Memo Memo
            { 
                get 
                {
                    QuickFix.Fields.Memo val = new QuickFix.Fields.Memo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Memo val) 
            { 
                this.Memo = val;
            }
            
            public QuickFix.Fields.Memo Get(QuickFix.Fields.Memo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Memo val) 
            { 
                return IsSetMemo();
            }
            
            public bool IsSetMemo() 
            { 
                return IsSetField(Tags.Memo);
            }
            public QuickFix.Fields.UnderlyingPx UnderlyingPx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPx val) 
            { 
                this.UnderlyingPx = val;
            }
            
            public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPx val) 
            { 
                return IsSetUnderlyingPx();
            }
            
            public bool IsSetUnderlyingPx() 
            { 
                return IsSetField(Tags.UnderlyingPx);
            }
            public QuickFix.Fields.OptionDelta OptionDelta
            { 
                get 
                {
                    QuickFix.Fields.OptionDelta val = new QuickFix.Fields.OptionDelta();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptionDelta val) 
            { 
                this.OptionDelta = val;
            }
            
            public QuickFix.Fields.OptionDelta Get(QuickFix.Fields.OptionDelta val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptionDelta val) 
            { 
                return IsSetOptionDelta();
            }
            
            public bool IsSetOptionDelta() 
            { 
                return IsSetField(Tags.OptionDelta);
            }
            public QuickFix.Fields.AggressorIndicator AggressorIndicator
            { 
                get 
                {
                    QuickFix.Fields.AggressorIndicator val = new QuickFix.Fields.AggressorIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AggressorIndicator val) 
            { 
                this.AggressorIndicator = val;
            }
            
            public QuickFix.Fields.AggressorIndicator Get(QuickFix.Fields.AggressorIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AggressorIndicator val) 
            { 
                return IsSetAggressorIndicator();
            }
            
            public bool IsSetAggressorIndicator() 
            { 
                return IsSetField(Tags.AggressorIndicator);
            }
            public QuickFix.Fields.Volatility Volatility
            { 
                get 
                {
                    QuickFix.Fields.Volatility val = new QuickFix.Fields.Volatility();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Volatility val) 
            { 
                this.Volatility = val;
            }
            
            public QuickFix.Fields.Volatility Get(QuickFix.Fields.Volatility val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Volatility val) 
            { 
                return IsSetVolatility();
            }
            
            public bool IsSetVolatility() 
            { 
                return IsSetField(Tags.Volatility);
            }
            public QuickFix.Fields.ExpirationTimeValue ExpirationTimeValue
            { 
                get 
                {
                    QuickFix.Fields.ExpirationTimeValue val = new QuickFix.Fields.ExpirationTimeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExpirationTimeValue val) 
            { 
                this.ExpirationTimeValue = val;
            }
            
            public QuickFix.Fields.ExpirationTimeValue Get(QuickFix.Fields.ExpirationTimeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExpirationTimeValue val) 
            { 
                return IsSetExpirationTimeValue();
            }
            
            public bool IsSetExpirationTimeValue() 
            { 
                return IsSetField(Tags.ExpirationTimeValue);
            }
            public QuickFix.Fields.RiskFreeRate RiskFreeRate
            { 
                get 
                {
                    QuickFix.Fields.RiskFreeRate val = new QuickFix.Fields.RiskFreeRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RiskFreeRate val) 
            { 
                this.RiskFreeRate = val;
            }
            
            public QuickFix.Fields.RiskFreeRate Get(QuickFix.Fields.RiskFreeRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RiskFreeRate val) 
            { 
                return IsSetRiskFreeRate();
            }
            
            public bool IsSetRiskFreeRate() 
            { 
                return IsSetField(Tags.RiskFreeRate);
            }
            public QuickFix.Fields.SelfMatchPreventionID SelfMatchPreventionID
            { 
                get 
                {
                    QuickFix.Fields.SelfMatchPreventionID val = new QuickFix.Fields.SelfMatchPreventionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SelfMatchPreventionID val) 
            { 
                this.SelfMatchPreventionID = val;
            }
            
            public QuickFix.Fields.SelfMatchPreventionID Get(QuickFix.Fields.SelfMatchPreventionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SelfMatchPreventionID val) 
            { 
                return IsSetSelfMatchPreventionID();
            }
            
            public bool IsSetSelfMatchPreventionID() 
            { 
                return IsSetField(Tags.SelfMatchPreventionID);
            }
            public QuickFix.Fields.CorrelationClOrdID CorrelationClOrdID
            { 
                get 
                {
                    QuickFix.Fields.CorrelationClOrdID val = new QuickFix.Fields.CorrelationClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CorrelationClOrdID val) 
            { 
                this.CorrelationClOrdID = val;
            }
            
            public QuickFix.Fields.CorrelationClOrdID Get(QuickFix.Fields.CorrelationClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CorrelationClOrdID val) 
            { 
                return IsSetCorrelationClOrdID();
            }
            
            public bool IsSetCorrelationClOrdID() 
            { 
                return IsSetField(Tags.CorrelationClOrdID);
            }
            public QuickFix.Fields.RequestTime RequestTime
            { 
                get 
                {
                    QuickFix.Fields.RequestTime val = new QuickFix.Fields.RequestTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RequestTime val) 
            { 
                this.RequestTime = val;
            }
            
            public QuickFix.Fields.RequestTime Get(QuickFix.Fields.RequestTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RequestTime val) 
            { 
                return IsSetRequestTime();
            }
            
            public bool IsSetRequestTime() 
            { 
                return IsSetField(Tags.RequestTime);
            }
            public QuickFix.Fields.SettlDate SettlDate
            { 
                get 
                {
                    QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDate val) 
            { 
                this.SettlDate = val;
            }
            
            public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDate val) 
            { 
                return IsSetSettlDate();
            }
            
            public bool IsSetSettlDate() 
            { 
                return IsSetField(Tags.SettlDate);
            }
            public QuickFix.Fields.NoFills NoFills
            { 
                get 
                {
                    QuickFix.Fields.NoFills val = new QuickFix.Fields.NoFills();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoFills val) 
            { 
                this.NoFills = val;
            }
            
            public QuickFix.Fields.NoFills Get(QuickFix.Fields.NoFills val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoFills val) 
            { 
                return IsSetNoFills();
            }
            
            public bool IsSetNoFills() 
            { 
                return IsSetField(Tags.NoFills);
            }
            public class NoFillsGroup : Group
            {
                public static int[] fieldOrder = {Tags.FillExecID, Tags.FillPx, Tags.FillQty, Tags.FillYieldType, 0};
            
                public NoFillsGroup() 
                  :base( Tags.NoFills, Tags.FillExecID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoFillsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.FillExecID FillExecID
                { 
                    get 
                    {
                        QuickFix.Fields.FillExecID val = new QuickFix.Fields.FillExecID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillExecID val) 
                { 
                    this.FillExecID = val;
                }
                
                public QuickFix.Fields.FillExecID Get(QuickFix.Fields.FillExecID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillExecID val) 
                { 
                    return IsSetFillExecID();
                }
                
                public bool IsSetFillExecID() 
                { 
                    return IsSetField(Tags.FillExecID);
                }
                public QuickFix.Fields.FillPx FillPx
                { 
                    get 
                    {
                        QuickFix.Fields.FillPx val = new QuickFix.Fields.FillPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillPx val) 
                { 
                    this.FillPx = val;
                }
                
                public QuickFix.Fields.FillPx Get(QuickFix.Fields.FillPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillPx val) 
                { 
                    return IsSetFillPx();
                }
                
                public bool IsSetFillPx() 
                { 
                    return IsSetField(Tags.FillPx);
                }
                public QuickFix.Fields.FillQty FillQty
                { 
                    get 
                    {
                        QuickFix.Fields.FillQty val = new QuickFix.Fields.FillQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillQty val) 
                { 
                    this.FillQty = val;
                }
                
                public QuickFix.Fields.FillQty Get(QuickFix.Fields.FillQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillQty val) 
                { 
                    return IsSetFillQty();
                }
                
                public bool IsSetFillQty() 
                { 
                    return IsSetField(Tags.FillQty);
                }
                public QuickFix.Fields.FillYieldType FillYieldType
                { 
                    get 
                    {
                        QuickFix.Fields.FillYieldType val = new QuickFix.Fields.FillYieldType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillYieldType val) 
                { 
                    this.FillYieldType = val;
                }
                
                public QuickFix.Fields.FillYieldType Get(QuickFix.Fields.FillYieldType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillYieldType val) 
                { 
                    return IsSetFillYieldType();
                }
                
                public bool IsSetFillYieldType() 
                { 
                    return IsSetField(Tags.FillYieldType);
                }
            
            }
        }
    }
}

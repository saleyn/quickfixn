// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class NewOrderList : Message
    {
            public const string MsgType = "E";

            public NewOrderList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("E"));
            }

            public NewOrderList(
                    QuickFix.Fields.ListID aListID,
                    QuickFix.Fields.BidType aBidType,
                    QuickFix.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.ListID = aListID;
                this.BidType = aBidType;
                this.TotNoOrders = aTotNoOrders;
            }

            public QuickFix.Fields.ListID ListID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListID val) 
            { 
                ListID = val;
            }
            
            public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListID);
            }
            
            public QuickFix.Fields.BidID BidID
            { 
                get 
                {
                    var val = new QuickFix.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidID val) 
            { 
                BidID = val;
            }
            
            public QuickFix.Fields.BidID Get(QuickFix.Fields.BidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidID val) 
            { 
                return IsSetBidID();
            }
            
            public bool IsSetBidID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BidID);
            }
            
            public QuickFix.Fields.ClientBidID ClientBidID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientBidID val) 
            { 
                ClientBidID = val;
            }
            
            public QuickFix.Fields.ClientBidID Get(QuickFix.Fields.ClientBidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientBidID val) 
            { 
                return IsSetClientBidID();
            }
            
            public bool IsSetClientBidID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClientBidID);
            }
            
            public QuickFix.Fields.ProgRptReqs ProgRptReqs
            { 
                get 
                {
                    var val = new QuickFix.Fields.ProgRptReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgRptReqs val) 
            { 
                ProgRptReqs = val;
            }
            
            public QuickFix.Fields.ProgRptReqs Get(QuickFix.Fields.ProgRptReqs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgRptReqs val) 
            { 
                return IsSetProgRptReqs();
            }
            
            public bool IsSetProgRptReqs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ProgRptReqs);
            }
            
            public QuickFix.Fields.BidType BidType
            { 
                get 
                {
                    var val = new QuickFix.Fields.BidType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidType val) 
            { 
                BidType = val;
            }
            
            public QuickFix.Fields.BidType Get(QuickFix.Fields.BidType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidType val) 
            { 
                return IsSetBidType();
            }
            
            public bool IsSetBidType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BidType);
            }
            
            public QuickFix.Fields.ProgPeriodInterval ProgPeriodInterval
            { 
                get 
                {
                    var val = new QuickFix.Fields.ProgPeriodInterval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                ProgPeriodInterval = val;
            }
            
            public QuickFix.Fields.ProgPeriodInterval Get(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                return IsSetProgPeriodInterval();
            }
            
            public bool IsSetProgPeriodInterval() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ProgPeriodInterval);
            }
            
            public QuickFix.Fields.ListExecInstType ListExecInstType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListExecInstType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListExecInstType val) 
            { 
                ListExecInstType = val;
            }
            
            public QuickFix.Fields.ListExecInstType Get(QuickFix.Fields.ListExecInstType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListExecInstType val) 
            { 
                return IsSetListExecInstType();
            }
            
            public bool IsSetListExecInstType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListExecInstType);
            }
            
            public QuickFix.Fields.ListExecInst ListExecInst
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListExecInst val) 
            { 
                ListExecInst = val;
            }
            
            public QuickFix.Fields.ListExecInst Get(QuickFix.Fields.ListExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListExecInst val) 
            { 
                return IsSetListExecInst();
            }
            
            public bool IsSetListExecInst() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListExecInst);
            }
            
            public QuickFix.Fields.EncodedListExecInstLen EncodedListExecInstLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedListExecInstLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                EncodedListExecInstLen = val;
            }
            
            public QuickFix.Fields.EncodedListExecInstLen Get(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                return IsSetEncodedListExecInstLen();
            }
            
            public bool IsSetEncodedListExecInstLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedListExecInstLen);
            }
            
            public QuickFix.Fields.EncodedListExecInst EncodedListExecInst
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedListExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListExecInst val) 
            { 
                EncodedListExecInst = val;
            }
            
            public QuickFix.Fields.EncodedListExecInst Get(QuickFix.Fields.EncodedListExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListExecInst val) 
            { 
                return IsSetEncodedListExecInst();
            }
            
            public bool IsSetEncodedListExecInst() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedListExecInst);
            }
            
            public QuickFix.Fields.TotNoOrders TotNoOrders
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotNoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoOrders val) 
            { 
                TotNoOrders = val;
            }
            
            public QuickFix.Fields.TotNoOrders Get(QuickFix.Fields.TotNoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoOrders val) 
            { 
                return IsSetTotNoOrders();
            }
            
            public bool IsSetTotNoOrders() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotNoOrders);
            }
            
            public QuickFix.Fields.NoOrders NoOrders
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrders val) 
            { 
                NoOrders = val;
            }
            
            public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoOrders);
            }
            
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.ClOrdID, QuickFix.Fields.Tags.ListSeqNo, QuickFix.Fields.Tags.SettlInstMode, QuickFix.Fields.Tags.ClientID, QuickFix.Fields.Tags.ExecBroker, QuickFix.Fields.Tags.Account, QuickFix.Fields.Tags.NoAllocs, QuickFix.Fields.Tags.SettlmntTyp, QuickFix.Fields.Tags.FutSettDate, QuickFix.Fields.Tags.HandlInst, QuickFix.Fields.Tags.ExecInst, QuickFix.Fields.Tags.MinQty, QuickFix.Fields.Tags.MaxFloor, QuickFix.Fields.Tags.ExDestination, QuickFix.Fields.Tags.NoTradingSessions, QuickFix.Fields.Tags.ProcessCode, QuickFix.Fields.Tags.Symbol, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.IDSource, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDay, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, QuickFix.Fields.Tags.PrevClosePx, QuickFix.Fields.Tags.Side, QuickFix.Fields.Tags.SideValueInd, QuickFix.Fields.Tags.LocateReqd, QuickFix.Fields.Tags.TransactTime, QuickFix.Fields.Tags.OrderQty, QuickFix.Fields.Tags.CashOrderQty, QuickFix.Fields.Tags.OrdType, QuickFix.Fields.Tags.Price, QuickFix.Fields.Tags.StopPx, QuickFix.Fields.Tags.Currency, QuickFix.Fields.Tags.ComplianceID, QuickFix.Fields.Tags.SolicitedFlag, QuickFix.Fields.Tags.IOIid, QuickFix.Fields.Tags.QuoteID, QuickFix.Fields.Tags.TimeInForce, QuickFix.Fields.Tags.EffectiveTime, QuickFix.Fields.Tags.ExpireDate, QuickFix.Fields.Tags.ExpireTime, QuickFix.Fields.Tags.GTBookingInst, QuickFix.Fields.Tags.Commission, QuickFix.Fields.Tags.CommType, QuickFix.Fields.Tags.Rule80A, QuickFix.Fields.Tags.ForexReq, QuickFix.Fields.Tags.SettlCurrency, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, QuickFix.Fields.Tags.FutSettDate2, QuickFix.Fields.Tags.OrderQty2, QuickFix.Fields.Tags.OpenClose, QuickFix.Fields.Tags.CoveredOrUncovered, QuickFix.Fields.Tags.CustomerOrFirm, QuickFix.Fields.Tags.MaxShow, QuickFix.Fields.Tags.PegDifference, QuickFix.Fields.Tags.DiscretionInst, QuickFix.Fields.Tags.DiscretionOffset, QuickFix.Fields.Tags.ClearingFirm, QuickFix.Fields.Tags.ClearingAccount, 0};
            
                public NoOrdersGroup() 
                  :base( QuickFix.Fields.Tags.NoOrders, QuickFix.Fields.Tags.ClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ClOrdID ClOrdID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClOrdID val) 
                { 
                    ClOrdID = val;
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
                    return IsSetField(QuickFix.Fields.Tags.ClOrdID);
                }
                
                public QuickFix.Fields.ListSeqNo ListSeqNo
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ListSeqNo();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListSeqNo val) 
                { 
                    ListSeqNo = val;
                }
                
                public QuickFix.Fields.ListSeqNo Get(QuickFix.Fields.ListSeqNo val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListSeqNo val) 
                { 
                    return IsSetListSeqNo();
                }
                
                public bool IsSetListSeqNo() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ListSeqNo);
                }
                
                public QuickFix.Fields.SettlInstMode SettlInstMode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlInstMode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlInstMode val) 
                { 
                    SettlInstMode = val;
                }
                
                public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlInstMode val) 
                { 
                    return IsSetSettlInstMode();
                }
                
                public bool IsSetSettlInstMode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlInstMode);
                }
                
                public QuickFix.Fields.ClientID ClientID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ClientID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClientID val) 
                { 
                    ClientID = val;
                }
                
                public QuickFix.Fields.ClientID Get(QuickFix.Fields.ClientID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClientID val) 
                { 
                    return IsSetClientID();
                }
                
                public bool IsSetClientID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ClientID);
                }
                
                public QuickFix.Fields.ExecBroker ExecBroker
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExecBroker();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecBroker val) 
                { 
                    ExecBroker = val;
                }
                
                public QuickFix.Fields.ExecBroker Get(QuickFix.Fields.ExecBroker val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecBroker val) 
                { 
                    return IsSetExecBroker();
                }
                
                public bool IsSetExecBroker() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExecBroker);
                }
                
                public QuickFix.Fields.Account Account
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Account();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Account val) 
                { 
                    Account = val;
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
                    return IsSetField(QuickFix.Fields.Tags.Account);
                }
                
                public QuickFix.Fields.NoAllocs NoAllocs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoAllocs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoAllocs val) 
                { 
                    NoAllocs = val;
                }
                
                public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoAllocs val) 
                { 
                    return IsSetNoAllocs();
                }
                
                public bool IsSetNoAllocs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoAllocs);
                }
                
                public QuickFix.Fields.SettlmntTyp SettlmntTyp
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlmntTyp();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlmntTyp val) 
                { 
                    SettlmntTyp = val;
                }
                
                public QuickFix.Fields.SettlmntTyp Get(QuickFix.Fields.SettlmntTyp val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlmntTyp val) 
                { 
                    return IsSetSettlmntTyp();
                }
                
                public bool IsSetSettlmntTyp() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlmntTyp);
                }
                
                public QuickFix.Fields.FutSettDate FutSettDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FutSettDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FutSettDate val) 
                { 
                    FutSettDate = val;
                }
                
                public QuickFix.Fields.FutSettDate Get(QuickFix.Fields.FutSettDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FutSettDate val) 
                { 
                    return IsSetFutSettDate();
                }
                
                public bool IsSetFutSettDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FutSettDate);
                }
                
                public QuickFix.Fields.HandlInst HandlInst
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.HandlInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HandlInst val) 
                { 
                    HandlInst = val;
                }
                
                public QuickFix.Fields.HandlInst Get(QuickFix.Fields.HandlInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HandlInst val) 
                { 
                    return IsSetHandlInst();
                }
                
                public bool IsSetHandlInst() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.HandlInst);
                }
                
                public QuickFix.Fields.ExecInst ExecInst
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExecInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecInst val) 
                { 
                    ExecInst = val;
                }
                
                public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecInst val) 
                { 
                    return IsSetExecInst();
                }
                
                public bool IsSetExecInst() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExecInst);
                }
                
                public QuickFix.Fields.MinQty MinQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MinQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinQty val) 
                { 
                    MinQty = val;
                }
                
                public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinQty val) 
                { 
                    return IsSetMinQty();
                }
                
                public bool IsSetMinQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MinQty);
                }
                
                public QuickFix.Fields.MaxFloor MaxFloor
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaxFloor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxFloor val) 
                { 
                    MaxFloor = val;
                }
                
                public QuickFix.Fields.MaxFloor Get(QuickFix.Fields.MaxFloor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxFloor val) 
                { 
                    return IsSetMaxFloor();
                }
                
                public bool IsSetMaxFloor() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaxFloor);
                }
                
                public QuickFix.Fields.ExDestination ExDestination
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExDestination();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExDestination val) 
                { 
                    ExDestination = val;
                }
                
                public QuickFix.Fields.ExDestination Get(QuickFix.Fields.ExDestination val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExDestination val) 
                { 
                    return IsSetExDestination();
                }
                
                public bool IsSetExDestination() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExDestination);
                }
                
                public QuickFix.Fields.NoTradingSessions NoTradingSessions
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoTradingSessions();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTradingSessions val) 
                { 
                    NoTradingSessions = val;
                }
                
                public QuickFix.Fields.NoTradingSessions Get(QuickFix.Fields.NoTradingSessions val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTradingSessions val) 
                { 
                    return IsSetNoTradingSessions();
                }
                
                public bool IsSetNoTradingSessions() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoTradingSessions);
                }
                
                public QuickFix.Fields.ProcessCode ProcessCode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ProcessCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProcessCode val) 
                { 
                    ProcessCode = val;
                }
                
                public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProcessCode val) 
                { 
                    return IsSetProcessCode();
                }
                
                public bool IsSetProcessCode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ProcessCode);
                }
                
                public QuickFix.Fields.Symbol Symbol
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Symbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Symbol val) 
                { 
                    Symbol = val;
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
                    return IsSetField(QuickFix.Fields.Tags.Symbol);
                }
                
                public QuickFix.Fields.SymbolSfx SymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SymbolSfx val) 
                { 
                    SymbolSfx = val;
                }
                
                public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SymbolSfx val) 
                { 
                    return IsSetSymbolSfx();
                }
                
                public bool IsSetSymbolSfx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SymbolSfx);
                }
                
                public QuickFix.Fields.SecurityID SecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityID val) 
                { 
                    SecurityID = val;
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
                    return IsSetField(QuickFix.Fields.Tags.SecurityID);
                }
                
                public QuickFix.Fields.IDSource IDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.IDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IDSource val) 
                { 
                    IDSource = val;
                }
                
                public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IDSource val) 
                { 
                    return IsSetIDSource();
                }
                
                public bool IsSetIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.IDSource);
                }
                
                public QuickFix.Fields.SecurityType SecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityType val) 
                { 
                    SecurityType = val;
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
                    return IsSetField(QuickFix.Fields.Tags.SecurityType);
                }
                
                public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    MaturityMonthYear = val;
                }
                
                public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    return IsSetMaturityMonthYear();
                }
                
                public bool IsSetMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaturityMonthYear);
                }
                
                public QuickFix.Fields.MaturityDay MaturityDay
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaturityDay val) 
                { 
                    MaturityDay = val;
                }
                
                public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaturityDay val) 
                { 
                    return IsSetMaturityDay();
                }
                
                public bool IsSetMaturityDay() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaturityDay);
                }
                
                public QuickFix.Fields.PutOrCall PutOrCall
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PutOrCall val) 
                { 
                    PutOrCall = val;
                }
                
                public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PutOrCall val) 
                { 
                    return IsSetPutOrCall();
                }
                
                public bool IsSetPutOrCall() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PutOrCall);
                }
                
                public QuickFix.Fields.StrikePrice StrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikePrice val) 
                { 
                    StrikePrice = val;
                }
                
                public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikePrice val) 
                { 
                    return IsSetStrikePrice();
                }
                
                public bool IsSetStrikePrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikePrice);
                }
                
                public QuickFix.Fields.OptAttribute OptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OptAttribute val) 
                { 
                    OptAttribute = val;
                }
                
                public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OptAttribute val) 
                { 
                    return IsSetOptAttribute();
                }
                
                public bool IsSetOptAttribute() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OptAttribute);
                }
                
                public QuickFix.Fields.ContractMultiplier ContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContractMultiplier val) 
                { 
                    ContractMultiplier = val;
                }
                
                public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
                { 
                    return IsSetContractMultiplier();
                }
                
                public bool IsSetContractMultiplier() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ContractMultiplier);
                }
                
                public QuickFix.Fields.CouponRate CouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CouponRate val) 
                { 
                    CouponRate = val;
                }
                
                public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CouponRate val) 
                { 
                    return IsSetCouponRate();
                }
                
                public bool IsSetCouponRate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CouponRate);
                }
                
                public QuickFix.Fields.SecurityExchange SecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityExchange val) 
                { 
                    SecurityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return IsSetSecurityExchange();
                }
                
                public bool IsSetSecurityExchange() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityExchange);
                }
                
                public QuickFix.Fields.Issuer Issuer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Issuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Issuer val) 
                { 
                    Issuer = val;
                }
                
                public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Issuer val) 
                { 
                    return IsSetIssuer();
                }
                
                public bool IsSetIssuer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Issuer);
                }
                
                public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    EncodedIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    return IsSetEncodedIssuerLen();
                }
                
                public bool IsSetEncodedIssuerLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedIssuerLen);
                }
                
                public QuickFix.Fields.EncodedIssuer EncodedIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedIssuer val) 
                { 
                    EncodedIssuer = val;
                }
                
                public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
                { 
                    return IsSetEncodedIssuer();
                }
                
                public bool IsSetEncodedIssuer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedIssuer);
                }
                
                public QuickFix.Fields.SecurityDesc SecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityDesc val) 
                { 
                    SecurityDesc = val;
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
                    return IsSetField(QuickFix.Fields.Tags.SecurityDesc);
                }
                
                public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    EncodedSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    return IsSetEncodedSecurityDescLen();
                }
                
                public bool IsSetEncodedSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedSecurityDescLen);
                }
                
                public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    EncodedSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    return IsSetEncodedSecurityDesc();
                }
                
                public bool IsSetEncodedSecurityDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedSecurityDesc);
                }
                
                public QuickFix.Fields.PrevClosePx PrevClosePx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PrevClosePx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PrevClosePx val) 
                { 
                    PrevClosePx = val;
                }
                
                public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PrevClosePx val) 
                { 
                    return IsSetPrevClosePx();
                }
                
                public bool IsSetPrevClosePx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PrevClosePx);
                }
                
                public QuickFix.Fields.Side Side
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Side val) 
                { 
                    Side = val;
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
                    return IsSetField(QuickFix.Fields.Tags.Side);
                }
                
                public QuickFix.Fields.SideValueInd SideValueInd
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SideValueInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SideValueInd val) 
                { 
                    SideValueInd = val;
                }
                
                public QuickFix.Fields.SideValueInd Get(QuickFix.Fields.SideValueInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SideValueInd val) 
                { 
                    return IsSetSideValueInd();
                }
                
                public bool IsSetSideValueInd() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SideValueInd);
                }
                
                public QuickFix.Fields.LocateReqd LocateReqd
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LocateReqd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocateReqd val) 
                { 
                    LocateReqd = val;
                }
                
                public QuickFix.Fields.LocateReqd Get(QuickFix.Fields.LocateReqd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocateReqd val) 
                { 
                    return IsSetLocateReqd();
                }
                
                public bool IsSetLocateReqd() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LocateReqd);
                }
                
                public QuickFix.Fields.TransactTime TransactTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TransactTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TransactTime val) 
                { 
                    TransactTime = val;
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
                    return IsSetField(QuickFix.Fields.Tags.TransactTime);
                }
                
                public QuickFix.Fields.OrderQty OrderQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty val) 
                { 
                    OrderQty = val;
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
                    return IsSetField(QuickFix.Fields.Tags.OrderQty);
                }
                
                public QuickFix.Fields.CashOrderQty CashOrderQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashOrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashOrderQty val) 
                { 
                    CashOrderQty = val;
                }
                
                public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashOrderQty val) 
                { 
                    return IsSetCashOrderQty();
                }
                
                public bool IsSetCashOrderQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashOrderQty);
                }
                
                public QuickFix.Fields.OrdType OrdType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OrdType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdType val) 
                { 
                    OrdType = val;
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
                    return IsSetField(QuickFix.Fields.Tags.OrdType);
                }
                
                public QuickFix.Fields.Price Price
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Price();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Price val) 
                { 
                    Price = val;
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
                    return IsSetField(QuickFix.Fields.Tags.Price);
                }
                
                public QuickFix.Fields.StopPx StopPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StopPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StopPx val) 
                { 
                    StopPx = val;
                }
                
                public QuickFix.Fields.StopPx Get(QuickFix.Fields.StopPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StopPx val) 
                { 
                    return IsSetStopPx();
                }
                
                public bool IsSetStopPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StopPx);
                }
                
                public QuickFix.Fields.Currency Currency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Currency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Currency val) 
                { 
                    Currency = val;
                }
                
                public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Currency val) 
                { 
                    return IsSetCurrency();
                }
                
                public bool IsSetCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Currency);
                }
                
                public QuickFix.Fields.ComplianceID ComplianceID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ComplianceID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplianceID val) 
                { 
                    ComplianceID = val;
                }
                
                public QuickFix.Fields.ComplianceID Get(QuickFix.Fields.ComplianceID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplianceID val) 
                { 
                    return IsSetComplianceID();
                }
                
                public bool IsSetComplianceID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ComplianceID);
                }
                
                public QuickFix.Fields.SolicitedFlag SolicitedFlag
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SolicitedFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SolicitedFlag val) 
                { 
                    SolicitedFlag = val;
                }
                
                public QuickFix.Fields.SolicitedFlag Get(QuickFix.Fields.SolicitedFlag val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SolicitedFlag val) 
                { 
                    return IsSetSolicitedFlag();
                }
                
                public bool IsSetSolicitedFlag() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SolicitedFlag);
                }
                
                public QuickFix.Fields.IOIid IOIid
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.IOIid();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IOIid val) 
                { 
                    IOIid = val;
                }
                
                public QuickFix.Fields.IOIid Get(QuickFix.Fields.IOIid val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IOIid val) 
                { 
                    return IsSetIOIid();
                }
                
                public bool IsSetIOIid() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.IOIid);
                }
                
                public QuickFix.Fields.QuoteID QuoteID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QuoteID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteID val) 
                { 
                    QuoteID = val;
                }
                
                public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteID val) 
                { 
                    return IsSetQuoteID();
                }
                
                public bool IsSetQuoteID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QuoteID);
                }
                
                public QuickFix.Fields.TimeInForce TimeInForce
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TimeInForce();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TimeInForce val) 
                { 
                    TimeInForce = val;
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
                    return IsSetField(QuickFix.Fields.Tags.TimeInForce);
                }
                
                public QuickFix.Fields.EffectiveTime EffectiveTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EffectiveTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EffectiveTime val) 
                { 
                    EffectiveTime = val;
                }
                
                public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EffectiveTime val) 
                { 
                    return IsSetEffectiveTime();
                }
                
                public bool IsSetEffectiveTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EffectiveTime);
                }
                
                public QuickFix.Fields.ExpireDate ExpireDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExpireDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireDate val) 
                { 
                    ExpireDate = val;
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
                    return IsSetField(QuickFix.Fields.Tags.ExpireDate);
                }
                
                public QuickFix.Fields.ExpireTime ExpireTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExpireTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireTime val) 
                { 
                    ExpireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return IsSetExpireTime();
                }
                
                public bool IsSetExpireTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExpireTime);
                }
                
                public QuickFix.Fields.GTBookingInst GTBookingInst
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.GTBookingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.GTBookingInst val) 
                { 
                    GTBookingInst = val;
                }
                
                public QuickFix.Fields.GTBookingInst Get(QuickFix.Fields.GTBookingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.GTBookingInst val) 
                { 
                    return IsSetGTBookingInst();
                }
                
                public bool IsSetGTBookingInst() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.GTBookingInst);
                }
                
                public QuickFix.Fields.Commission Commission
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Commission();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Commission val) 
                { 
                    Commission = val;
                }
                
                public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Commission val) 
                { 
                    return IsSetCommission();
                }
                
                public bool IsSetCommission() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Commission);
                }
                
                public QuickFix.Fields.CommType CommType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CommType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CommType val) 
                { 
                    CommType = val;
                }
                
                public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CommType val) 
                { 
                    return IsSetCommType();
                }
                
                public bool IsSetCommType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CommType);
                }
                
                public QuickFix.Fields.Rule80A Rule80A
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Rule80A();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Rule80A val) 
                { 
                    Rule80A = val;
                }
                
                public QuickFix.Fields.Rule80A Get(QuickFix.Fields.Rule80A val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Rule80A val) 
                { 
                    return IsSetRule80A();
                }
                
                public bool IsSetRule80A() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Rule80A);
                }
                
                public QuickFix.Fields.ForexReq ForexReq
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ForexReq();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ForexReq val) 
                { 
                    ForexReq = val;
                }
                
                public QuickFix.Fields.ForexReq Get(QuickFix.Fields.ForexReq val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ForexReq val) 
                { 
                    return IsSetForexReq();
                }
                
                public bool IsSetForexReq() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ForexReq);
                }
                
                public QuickFix.Fields.SettlCurrency SettlCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrency val) 
                { 
                    SettlCurrency = val;
                }
                
                public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrency val) 
                { 
                    return IsSetSettlCurrency();
                }
                
                public bool IsSetSettlCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlCurrency);
                }
                
                public QuickFix.Fields.Text Text
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Text();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Text val) 
                { 
                    Text = val;
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
                    return IsSetField(QuickFix.Fields.Tags.Text);
                }
                
                public QuickFix.Fields.EncodedTextLen EncodedTextLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    EncodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return IsSetEncodedTextLen();
                }
                
                public bool IsSetEncodedTextLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedTextLen);
                }
                
                public QuickFix.Fields.EncodedText EncodedText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedText val) 
                { 
                    EncodedText = val;
                }
                
                public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedText val) 
                { 
                    return IsSetEncodedText();
                }
                
                public bool IsSetEncodedText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedText);
                }
                
                public QuickFix.Fields.FutSettDate2 FutSettDate2
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FutSettDate2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FutSettDate2 val) 
                { 
                    FutSettDate2 = val;
                }
                
                public QuickFix.Fields.FutSettDate2 Get(QuickFix.Fields.FutSettDate2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FutSettDate2 val) 
                { 
                    return IsSetFutSettDate2();
                }
                
                public bool IsSetFutSettDate2() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FutSettDate2);
                }
                
                public QuickFix.Fields.OrderQty2 OrderQty2
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OrderQty2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty2 val) 
                { 
                    OrderQty2 = val;
                }
                
                public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderQty2 val) 
                { 
                    return IsSetOrderQty2();
                }
                
                public bool IsSetOrderQty2() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OrderQty2);
                }
                
                public QuickFix.Fields.OpenClose OpenClose
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OpenClose();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OpenClose val) 
                { 
                    OpenClose = val;
                }
                
                public QuickFix.Fields.OpenClose Get(QuickFix.Fields.OpenClose val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OpenClose val) 
                { 
                    return IsSetOpenClose();
                }
                
                public bool IsSetOpenClose() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OpenClose);
                }
                
                public QuickFix.Fields.CoveredOrUncovered CoveredOrUncovered
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CoveredOrUncovered();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    CoveredOrUncovered = val;
                }
                
                public QuickFix.Fields.CoveredOrUncovered Get(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    return IsSetCoveredOrUncovered();
                }
                
                public bool IsSetCoveredOrUncovered() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CoveredOrUncovered);
                }
                
                public QuickFix.Fields.CustomerOrFirm CustomerOrFirm
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CustomerOrFirm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CustomerOrFirm val) 
                { 
                    CustomerOrFirm = val;
                }
                
                public QuickFix.Fields.CustomerOrFirm Get(QuickFix.Fields.CustomerOrFirm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CustomerOrFirm val) 
                { 
                    return IsSetCustomerOrFirm();
                }
                
                public bool IsSetCustomerOrFirm() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CustomerOrFirm);
                }
                
                public QuickFix.Fields.MaxShow MaxShow
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaxShow();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxShow val) 
                { 
                    MaxShow = val;
                }
                
                public QuickFix.Fields.MaxShow Get(QuickFix.Fields.MaxShow val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxShow val) 
                { 
                    return IsSetMaxShow();
                }
                
                public bool IsSetMaxShow() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaxShow);
                }
                
                public QuickFix.Fields.PegDifference PegDifference
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PegDifference();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PegDifference val) 
                { 
                    PegDifference = val;
                }
                
                public QuickFix.Fields.PegDifference Get(QuickFix.Fields.PegDifference val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PegDifference val) 
                { 
                    return IsSetPegDifference();
                }
                
                public bool IsSetPegDifference() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PegDifference);
                }
                
                public QuickFix.Fields.DiscretionInst DiscretionInst
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DiscretionInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionInst val) 
                { 
                    DiscretionInst = val;
                }
                
                public QuickFix.Fields.DiscretionInst Get(QuickFix.Fields.DiscretionInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionInst val) 
                { 
                    return IsSetDiscretionInst();
                }
                
                public bool IsSetDiscretionInst() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DiscretionInst);
                }
                
                public QuickFix.Fields.DiscretionOffset DiscretionOffset
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DiscretionOffset();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DiscretionOffset val) 
                { 
                    DiscretionOffset = val;
                }
                
                public QuickFix.Fields.DiscretionOffset Get(QuickFix.Fields.DiscretionOffset val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DiscretionOffset val) 
                { 
                    return IsSetDiscretionOffset();
                }
                
                public bool IsSetDiscretionOffset() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DiscretionOffset);
                }
                
                public QuickFix.Fields.ClearingFirm ClearingFirm
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ClearingFirm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClearingFirm val) 
                { 
                    ClearingFirm = val;
                }
                
                public QuickFix.Fields.ClearingFirm Get(QuickFix.Fields.ClearingFirm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClearingFirm val) 
                { 
                    return IsSetClearingFirm();
                }
                
                public bool IsSetClearingFirm() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ClearingFirm);
                }
                
                public QuickFix.Fields.ClearingAccount ClearingAccount
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ClearingAccount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClearingAccount val) 
                { 
                    ClearingAccount = val;
                }
                
                public QuickFix.Fields.ClearingAccount Get(QuickFix.Fields.ClearingAccount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClearingAccount val) 
                { 
                    return IsSetClearingAccount();
                }
                
                public bool IsSetClearingAccount() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ClearingAccount);
                }
                
                            public class NoAllocsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.AllocAccount, QuickFix.Fields.Tags.AllocShares, 0};
                
                    public NoAllocsGroup() 
                      :base( QuickFix.Fields.Tags.NoAllocs, QuickFix.Fields.Tags.AllocAccount, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoAllocsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.AllocAccount AllocAccount
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.AllocAccount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocAccount val) 
                    { 
                        AllocAccount = val;
                    }
                    
                    public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocAccount val) 
                    { 
                        return IsSetAllocAccount();
                    }
                    
                    public bool IsSetAllocAccount() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.AllocAccount);
                    }
                    
                    public QuickFix.Fields.AllocShares AllocShares
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.AllocShares();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocShares val) 
                    { 
                        AllocShares = val;
                    }
                    
                    public QuickFix.Fields.AllocShares Get(QuickFix.Fields.AllocShares val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocShares val) 
                    { 
                        return IsSetAllocShares();
                    }
                    
                    public bool IsSetAllocShares() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.AllocShares);
                    }
                    
                
                }
                public class NoTradingSessionsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.TradingSessionID, 0};
                
                    public NoTradingSessionsGroup() 
                      :base( QuickFix.Fields.Tags.NoTradingSessions, QuickFix.Fields.Tags.TradingSessionID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTradingSessionsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.TradingSessionID TradingSessionID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.TradingSessionID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TradingSessionID val) 
                    { 
                        TradingSessionID = val;
                    }
                    
                    public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TradingSessionID val) 
                    { 
                        return IsSetTradingSessionID();
                    }
                    
                    public bool IsSetTradingSessionID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.TradingSessionID);
                    }
                    
                
                }
            }
    }
}

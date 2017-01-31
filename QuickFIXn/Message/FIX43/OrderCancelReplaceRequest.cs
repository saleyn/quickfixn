// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class OrderCancelReplaceRequest : Message
    {
            public const string MsgType = "G";

            public OrderCancelReplaceRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("G"));
            }

            public OrderCancelReplaceRequest(
                    QuickFix.Fields.OrigClOrdID aOrigClOrdID,
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.HandlInst aHandlInst,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.OrdType aOrdType
                ) : this()
            {
                this.OrigClOrdID = aOrigClOrdID;
                this.ClOrdID = aClOrdID;
                this.HandlInst = aHandlInst;
                this.Symbol = aSymbol;
                this.Side = aSide;
                this.TransactTime = aTransactTime;
                this.OrdType = aOrdType;
            }

            public QuickFix.Fields.OrderID OrderID
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderID val) 
            { 
                OrderID = val;
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
                return IsSetField(QuickFix.Fields.Tags.OrderID);
            }
            
            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyIDs val) 
            { 
                NoPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoPartyIDs);
            }
            
            public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeOriginationDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeOriginationDate val) 
            { 
                TradeOriginationDate = val;
            }
            
            public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeOriginationDate val) 
            { 
                return IsSetTradeOriginationDate();
            }
            
            public bool IsSetTradeOriginationDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeOriginationDate);
            }
            
            public QuickFix.Fields.OrigClOrdID OrigClOrdID
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigClOrdID val) 
            { 
                OrigClOrdID = val;
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
                return IsSetField(QuickFix.Fields.Tags.OrigClOrdID);
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
            
            public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                SecondaryClOrdID = val;
            }
            
            public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                return IsSetSecondaryClOrdID();
            }
            
            public bool IsSetSecondaryClOrdID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecondaryClOrdID);
            }
            
            public QuickFix.Fields.ClOrdLinkID ClOrdLinkID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClOrdLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdLinkID val) 
            { 
                ClOrdLinkID = val;
            }
            
            public QuickFix.Fields.ClOrdLinkID Get(QuickFix.Fields.ClOrdLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdLinkID val) 
            { 
                return IsSetClOrdLinkID();
            }
            
            public bool IsSetClOrdLinkID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClOrdLinkID);
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
            
            public QuickFix.Fields.OrigOrdModTime OrigOrdModTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrigOrdModTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigOrdModTime val) 
            { 
                OrigOrdModTime = val;
            }
            
            public QuickFix.Fields.OrigOrdModTime Get(QuickFix.Fields.OrigOrdModTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigOrdModTime val) 
            { 
                return IsSetOrigOrdModTime();
            }
            
            public bool IsSetOrigOrdModTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrigOrdModTime);
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
            
            public QuickFix.Fields.AccountType AccountType
            { 
                get 
                {
                    var val = new QuickFix.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccountType val) 
            { 
                AccountType = val;
            }
            
            public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AccountType);
            }
            
            public QuickFix.Fields.DayBookingInst DayBookingInst
            { 
                get 
                {
                    var val = new QuickFix.Fields.DayBookingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DayBookingInst val) 
            { 
                DayBookingInst = val;
            }
            
            public QuickFix.Fields.DayBookingInst Get(QuickFix.Fields.DayBookingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DayBookingInst val) 
            { 
                return IsSetDayBookingInst();
            }
            
            public bool IsSetDayBookingInst() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DayBookingInst);
            }
            
            public QuickFix.Fields.BookingUnit BookingUnit
            { 
                get 
                {
                    var val = new QuickFix.Fields.BookingUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BookingUnit val) 
            { 
                BookingUnit = val;
            }
            
            public QuickFix.Fields.BookingUnit Get(QuickFix.Fields.BookingUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BookingUnit val) 
            { 
                return IsSetBookingUnit();
            }
            
            public bool IsSetBookingUnit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BookingUnit);
            }
            
            public QuickFix.Fields.PreallocMethod PreallocMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.PreallocMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PreallocMethod val) 
            { 
                PreallocMethod = val;
            }
            
            public QuickFix.Fields.PreallocMethod Get(QuickFix.Fields.PreallocMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PreallocMethod val) 
            { 
                return IsSetPreallocMethod();
            }
            
            public bool IsSetPreallocMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PreallocMethod);
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
            
            public QuickFix.Fields.CashMargin CashMargin
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashMargin();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashMargin val) 
            { 
                CashMargin = val;
            }
            
            public QuickFix.Fields.CashMargin Get(QuickFix.Fields.CashMargin val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashMargin val) 
            { 
                return IsSetCashMargin();
            }
            
            public bool IsSetCashMargin() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashMargin);
            }
            
            public QuickFix.Fields.ClearingFeeIndicator ClearingFeeIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClearingFeeIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                ClearingFeeIndicator = val;
            }
            
            public QuickFix.Fields.ClearingFeeIndicator Get(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                return IsSetClearingFeeIndicator();
            }
            
            public bool IsSetClearingFeeIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClearingFeeIndicator);
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
            
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                SecurityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityIDSource);
            }
            
            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                NoSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoSecurityAltID);
            }
            
            public QuickFix.Fields.Product Product
            { 
                get 
                {
                    var val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                Product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Product);
            }
            
            public QuickFix.Fields.CFICode CFICode
            { 
                get 
                {
                    var val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                CFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CFICode);
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
            
            public QuickFix.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                MaturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaturityDate);
            }
            
            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                CouponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CouponPaymentDate);
            }
            
            public QuickFix.Fields.IssueDate IssueDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                IssueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IssueDate);
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                RepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepoCollateralSecurityType);
            }
            
            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                RepurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepurchaseTerm);
            }
            
            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                RepurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepurchaseRate);
            }
            
            public QuickFix.Fields.Factor Factor
            { 
                get 
                {
                    var val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                Factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Factor);
            }
            
            public QuickFix.Fields.CreditRating CreditRating
            { 
                get 
                {
                    var val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                CreditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CreditRating);
            }
            
            public QuickFix.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                InstrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(QuickFix.Fields.Tags.InstrRegistry);
            }
            
            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                CountryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CountryOfIssue);
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StateOrProvinceOfIssue);
            }
            
            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                LocaleOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LocaleOfIssue);
            }
            
            public QuickFix.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                RedemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RedemptionDate);
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
            
            public QuickFix.Fields.QuantityType QuantityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.QuantityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuantityType val) 
            { 
                QuantityType = val;
            }
            
            public QuickFix.Fields.QuantityType Get(QuickFix.Fields.QuantityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuantityType val) 
            { 
                return IsSetQuantityType();
            }
            
            public bool IsSetQuantityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.QuantityType);
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
            
            public QuickFix.Fields.OrderPercent OrderPercent
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderPercent val) 
            { 
                OrderPercent = val;
            }
            
            public QuickFix.Fields.OrderPercent Get(QuickFix.Fields.OrderPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderPercent val) 
            { 
                return IsSetOrderPercent();
            }
            
            public bool IsSetOrderPercent() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderPercent);
            }
            
            public QuickFix.Fields.RoundingDirection RoundingDirection
            { 
                get 
                {
                    var val = new QuickFix.Fields.RoundingDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RoundingDirection val) 
            { 
                RoundingDirection = val;
            }
            
            public QuickFix.Fields.RoundingDirection Get(QuickFix.Fields.RoundingDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RoundingDirection val) 
            { 
                return IsSetRoundingDirection();
            }
            
            public bool IsSetRoundingDirection() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RoundingDirection);
            }
            
            public QuickFix.Fields.RoundingModulus RoundingModulus
            { 
                get 
                {
                    var val = new QuickFix.Fields.RoundingModulus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RoundingModulus val) 
            { 
                RoundingModulus = val;
            }
            
            public QuickFix.Fields.RoundingModulus Get(QuickFix.Fields.RoundingModulus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RoundingModulus val) 
            { 
                return IsSetRoundingModulus();
            }
            
            public bool IsSetRoundingModulus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RoundingModulus);
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
            
            public QuickFix.Fields.PriceType PriceType
            { 
                get 
                {
                    var val = new QuickFix.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceType val) 
            { 
                PriceType = val;
            }
            
            public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceType val) 
            { 
                return IsSetPriceType();
            }
            
            public bool IsSetPriceType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PriceType);
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
            
            public QuickFix.Fields.Spread Spread
            { 
                get 
                {
                    var val = new QuickFix.Fields.Spread();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Spread val) 
            { 
                Spread = val;
            }
            
            public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Spread val) 
            { 
                return IsSetSpread();
            }
            
            public bool IsSetSpread() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Spread);
            }
            
            public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkCurveCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                BenchmarkCurveCurrency = val;
            }
            
            public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                return IsSetBenchmarkCurveCurrency();
            }
            
            public bool IsSetBenchmarkCurveCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkCurveCurrency);
            }
            
            public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkCurveName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                BenchmarkCurveName = val;
            }
            
            public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                return IsSetBenchmarkCurveName();
            }
            
            public bool IsSetBenchmarkCurveName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkCurveName);
            }
            
            public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkCurvePoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                BenchmarkCurvePoint = val;
            }
            
            public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                return IsSetBenchmarkCurvePoint();
            }
            
            public bool IsSetBenchmarkCurvePoint() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkCurvePoint);
            }
            
            public QuickFix.Fields.YieldType YieldType
            { 
                get 
                {
                    var val = new QuickFix.Fields.YieldType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldType val) 
            { 
                YieldType = val;
            }
            
            public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldType val) 
            { 
                return IsSetYieldType();
            }
            
            public bool IsSetYieldType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.YieldType);
            }
            
            public QuickFix.Fields.Yield Yield
            { 
                get 
                {
                    var val = new QuickFix.Fields.Yield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Yield val) 
            { 
                Yield = val;
            }
            
            public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Yield val) 
            { 
                return IsSetYield();
            }
            
            public bool IsSetYield() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Yield);
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
            
            public QuickFix.Fields.CommCurrency CommCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.CommCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CommCurrency val) 
            { 
                CommCurrency = val;
            }
            
            public QuickFix.Fields.CommCurrency Get(QuickFix.Fields.CommCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CommCurrency val) 
            { 
                return IsSetCommCurrency();
            }
            
            public bool IsSetCommCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CommCurrency);
            }
            
            public QuickFix.Fields.FundRenewWaiv FundRenewWaiv
            { 
                get 
                {
                    var val = new QuickFix.Fields.FundRenewWaiv();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FundRenewWaiv val) 
            { 
                FundRenewWaiv = val;
            }
            
            public QuickFix.Fields.FundRenewWaiv Get(QuickFix.Fields.FundRenewWaiv val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FundRenewWaiv val) 
            { 
                return IsSetFundRenewWaiv();
            }
            
            public bool IsSetFundRenewWaiv() 
            { 
                return IsSetField(QuickFix.Fields.Tags.FundRenewWaiv);
            }
            
            public QuickFix.Fields.OrderCapacity OrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderCapacity val) 
            { 
                OrderCapacity = val;
            }
            
            public QuickFix.Fields.OrderCapacity Get(QuickFix.Fields.OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderCapacity);
            }
            
            public QuickFix.Fields.OrderRestrictions OrderRestrictions
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderRestrictions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderRestrictions val) 
            { 
                OrderRestrictions = val;
            }
            
            public QuickFix.Fields.OrderRestrictions Get(QuickFix.Fields.OrderRestrictions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderRestrictions val) 
            { 
                return IsSetOrderRestrictions();
            }
            
            public bool IsSetOrderRestrictions() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderRestrictions);
            }
            
            public QuickFix.Fields.CustOrderCapacity CustOrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.Fields.CustOrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CustOrderCapacity val) 
            { 
                CustOrderCapacity = val;
            }
            
            public QuickFix.Fields.CustOrderCapacity Get(QuickFix.Fields.CustOrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CustOrderCapacity val) 
            { 
                return IsSetCustOrderCapacity();
            }
            
            public bool IsSetCustOrderCapacity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CustOrderCapacity);
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
            
            public QuickFix.Fields.Price2 Price2
            { 
                get 
                {
                    var val = new QuickFix.Fields.Price2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Price2 val) 
            { 
                Price2 = val;
            }
            
            public QuickFix.Fields.Price2 Get(QuickFix.Fields.Price2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Price2 val) 
            { 
                return IsSetPrice2();
            }
            
            public bool IsSetPrice2() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Price2);
            }
            
            public QuickFix.Fields.PositionEffect PositionEffect
            { 
                get 
                {
                    var val = new QuickFix.Fields.PositionEffect();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionEffect val) 
            { 
                PositionEffect = val;
            }
            
            public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionEffect val) 
            { 
                return IsSetPositionEffect();
            }
            
            public bool IsSetPositionEffect() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PositionEffect);
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
            
            public QuickFix.Fields.CancellationRights CancellationRights
            { 
                get 
                {
                    var val = new QuickFix.Fields.CancellationRights();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CancellationRights val) 
            { 
                CancellationRights = val;
            }
            
            public QuickFix.Fields.CancellationRights Get(QuickFix.Fields.CancellationRights val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CancellationRights val) 
            { 
                return IsSetCancellationRights();
            }
            
            public bool IsSetCancellationRights() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CancellationRights);
            }
            
            public QuickFix.Fields.MoneyLaunderingStatus MoneyLaunderingStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.MoneyLaunderingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                MoneyLaunderingStatus = val;
            }
            
            public QuickFix.Fields.MoneyLaunderingStatus Get(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                return IsSetMoneyLaunderingStatus();
            }
            
            public bool IsSetMoneyLaunderingStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MoneyLaunderingStatus);
            }
            
            public QuickFix.Fields.RegistID RegistID
            { 
                get 
                {
                    var val = new QuickFix.Fields.RegistID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistID val) 
            { 
                RegistID = val;
            }
            
            public QuickFix.Fields.RegistID Get(QuickFix.Fields.RegistID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistID val) 
            { 
                return IsSetRegistID();
            }
            
            public bool IsSetRegistID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RegistID);
            }
            
            public QuickFix.Fields.Designation Designation
            { 
                get 
                {
                    var val = new QuickFix.Fields.Designation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Designation val) 
            { 
                Designation = val;
            }
            
            public QuickFix.Fields.Designation Get(QuickFix.Fields.Designation val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Designation val) 
            { 
                return IsSetDesignation();
            }
            
            public bool IsSetDesignation() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Designation);
            }
            
            public QuickFix.Fields.AccruedInterestRate AccruedInterestRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.AccruedInterestRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccruedInterestRate val) 
            { 
                AccruedInterestRate = val;
            }
            
            public QuickFix.Fields.AccruedInterestRate Get(QuickFix.Fields.AccruedInterestRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccruedInterestRate val) 
            { 
                return IsSetAccruedInterestRate();
            }
            
            public bool IsSetAccruedInterestRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AccruedInterestRate);
            }
            
            public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
            { 
                get 
                {
                    var val = new QuickFix.Fields.AccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                AccruedInterestAmt = val;
            }
            
            public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                return IsSetAccruedInterestAmt();
            }
            
            public bool IsSetAccruedInterestAmt() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AccruedInterestAmt);
            }
            
            public QuickFix.Fields.NetMoney NetMoney
            { 
                get 
                {
                    var val = new QuickFix.Fields.NetMoney();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetMoney val) 
            { 
                NetMoney = val;
            }
            
            public QuickFix.Fields.NetMoney Get(QuickFix.Fields.NetMoney val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetMoney val) 
            { 
                return IsSetNetMoney();
            }
            
            public bool IsSetNetMoney() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NetMoney);
            }
            
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyID, QuickFix.Fields.Tags.PartyIDSource, QuickFix.Fields.Tags.PartyRole, QuickFix.Fields.Tags.PartySubID, 0};
            
                public NoPartyIDsGroup() 
                  :base( QuickFix.Fields.Tags.NoPartyIDs, QuickFix.Fields.Tags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.PartyID PartyID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    PartyID = val;
                }
                
                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartyID);
                }
                
                public QuickFix.Fields.PartyIDSource PartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyIDSource val) 
                { 
                    PartyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartyIDSource);
                }
                
                public QuickFix.Fields.PartyRole PartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRole val) 
                { 
                    PartyRole = val;
                }
                
                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartyRole);
                }
                
                public QuickFix.Fields.PartySubID PartySubID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartySubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartySubID val) 
                { 
                    PartySubID = val;
                }
                
                public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartySubID val) 
                { 
                    return IsSetPartySubID();
                }
                
                public bool IsSetPartySubID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartySubID);
                }
                
            
            }
            public class NoAllocsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.AllocAccount, QuickFix.Fields.Tags.IndividualAllocID, QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.AllocQty, 0};
            
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
                
                public QuickFix.Fields.IndividualAllocID IndividualAllocID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.IndividualAllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IndividualAllocID val) 
                { 
                    IndividualAllocID = val;
                }
                
                public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
                { 
                    return IsSetIndividualAllocID();
                }
                
                public bool IsSetIndividualAllocID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.IndividualAllocID);
                }
                
                public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    NoNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoNestedPartyIDs);
                }
                
                public QuickFix.Fields.AllocQty AllocQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocQty val) 
                { 
                    AllocQty = val;
                }
                
                public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocQty val) 
                { 
                    return IsSetAllocQty();
                }
                
                public bool IsSetAllocQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocQty);
                }
                
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartyID, QuickFix.Fields.Tags.NestedPartyIDSource, QuickFix.Fields.Tags.NestedPartyRole, QuickFix.Fields.Tags.NestedPartySubID, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        NestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyID);
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyIDSource);
                    }
                    
                    public QuickFix.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        NestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyRole);
                    }
                    
                    public QuickFix.Fields.NestedPartySubID NestedPartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartySubID val) 
                    { 
                        NestedPartySubID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                    { 
                        return IsSetNestedPartySubID();
                    }
                    
                    public bool IsSetNestedPartySubID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartySubID);
                    }
                    
                
                }
            }
            public class NoTradingSessionsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, 0};
            
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
                
                public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradingSessionSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    TradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    return IsSetTradingSessionSubID();
                }
                
                public bool IsSetTradingSessionSubID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradingSessionSubID);
                }
                
            
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.SecurityAltID, QuickFix.Fields.Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    SecurityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityAltID);
                }
                
                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    SecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityAltIDSource);
                }
                
            
            }
    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class OrderMassActionRequest : Message
    {
            public const string MsgType = "CA";

            public OrderMassActionRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CA"));
            }

            public OrderMassActionRequest(
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.MassActionType aMassActionType,
                    QuickFix.Fields.MassActionScope aMassActionScope,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.ClOrdID = aClOrdID;
                this.MassActionType = aMassActionType;
                this.MassActionScope = aMassActionScope;
                this.TransactTime = aTransactTime;
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
            
            public QuickFix.Fields.MassActionType MassActionType
            { 
                get 
                {
                    var val = new QuickFix.Fields.MassActionType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassActionType val) 
            { 
                MassActionType = val;
            }
            
            public QuickFix.Fields.MassActionType Get(QuickFix.Fields.MassActionType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassActionType val) 
            { 
                return IsSetMassActionType();
            }
            
            public bool IsSetMassActionType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MassActionType);
            }
            
            public QuickFix.Fields.MassActionScope MassActionScope
            { 
                get 
                {
                    var val = new QuickFix.Fields.MassActionScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassActionScope val) 
            { 
                MassActionScope = val;
            }
            
            public QuickFix.Fields.MassActionScope Get(QuickFix.Fields.MassActionScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassActionScope val) 
            { 
                return IsSetMassActionScope();
            }
            
            public bool IsSetMassActionScope() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MassActionScope);
            }
            
            public QuickFix.Fields.MarketID MarketID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketID val) 
            { 
                MarketID = val;
            }
            
            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketID val) 
            { 
                return IsSetMarketID();
            }
            
            public bool IsSetMarketID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketID);
            }
            
            public QuickFix.Fields.MarketSegmentID MarketSegmentID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentID val) 
            { 
                MarketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return IsSetMarketSegmentID();
            }
            
            public bool IsSetMarketSegmentID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketSegmentID);
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
            
            public QuickFix.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                SecuritySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySubType);
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
            
            public QuickFix.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeCurrency val) 
            { 
                StrikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StrikeCurrency);
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
            
            public QuickFix.Fields.Pool Pool
            { 
                get 
                {
                    var val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Pool val) 
            { 
                Pool = val;
            }
            
            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Pool);
            }
            
            public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    var val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                ContractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ContractSettlMonth);
            }
            
            public QuickFix.Fields.CPProgram CPProgram
            { 
                get 
                {
                    var val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPProgram val) 
            { 
                CPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CPProgram);
            }
            
            public QuickFix.Fields.CPRegType CPRegType
            { 
                get 
                {
                    var val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPRegType val) 
            { 
                CPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CPRegType);
            }
            
            public QuickFix.Fields.NoEvents NoEvents
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoEvents val) 
            { 
                NoEvents = val;
            }
            
            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoEvents);
            }
            
            public QuickFix.Fields.DatedDate DatedDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DatedDate val) 
            { 
                DatedDate = val;
            }
            
            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DatedDate);
            }
            
            public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                InterestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.InterestAccrualDate);
            }
            
            public QuickFix.Fields.SecurityStatus SecurityStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityStatus val) 
            { 
                SecurityStatus = val;
            }
            
            public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityStatus val) 
            { 
                return IsSetSecurityStatus();
            }
            
            public bool IsSetSecurityStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityStatus);
            }
            
            public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                SettleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                return IsSetSettleOnOpenFlag();
            }
            
            public bool IsSetSettleOnOpenFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettleOnOpenFlag);
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                InstrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                return IsSetInstrmtAssignmentMethod();
            }
            
            public bool IsSetInstrmtAssignmentMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.InstrmtAssignmentMethod);
            }
            
            public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
            { 
                get 
                {
                    var val = new QuickFix.Fields.StrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeMultiplier val) 
            { 
                StrikeMultiplier = val;
            }
            
            public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeMultiplier val) 
            { 
                return IsSetStrikeMultiplier();
            }
            
            public bool IsSetStrikeMultiplier() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StrikeMultiplier);
            }
            
            public QuickFix.Fields.StrikeValue StrikeValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.StrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeValue val) 
            { 
                StrikeValue = val;
            }
            
            public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeValue val) 
            { 
                return IsSetStrikeValue();
            }
            
            public bool IsSetStrikeValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StrikeValue);
            }
            
            public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
            { 
                get 
                {
                    var val = new QuickFix.Fields.MinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrement val) 
            { 
                MinPriceIncrement = val;
            }
            
            public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrement val) 
            { 
                return IsSetMinPriceIncrement();
            }
            
            public bool IsSetMinPriceIncrement() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MinPriceIncrement);
            }
            
            public QuickFix.Fields.PositionLimit PositionLimit
            { 
                get 
                {
                    var val = new QuickFix.Fields.PositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionLimit val) 
            { 
                PositionLimit = val;
            }
            
            public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionLimit val) 
            { 
                return IsSetPositionLimit();
            }
            
            public bool IsSetPositionLimit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PositionLimit);
            }
            
            public QuickFix.Fields.NTPositionLimit NTPositionLimit
            { 
                get 
                {
                    var val = new QuickFix.Fields.NTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NTPositionLimit val) 
            { 
                NTPositionLimit = val;
            }
            
            public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NTPositionLimit val) 
            { 
                return IsSetNTPositionLimit();
            }
            
            public bool IsSetNTPositionLimit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NTPositionLimit);
            }
            
            public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoInstrumentParties val) 
            { 
                NoInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoInstrumentParties val) 
            { 
                return IsSetNoInstrumentParties();
            }
            
            public bool IsSetNoInstrumentParties() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoInstrumentParties);
            }
            
            public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                UnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return IsSetUnitOfMeasure();
            }
            
            public bool IsSetUnitOfMeasure() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnitOfMeasure);
            }
            
            public QuickFix.Fields.TimeUnit TimeUnit
            { 
                get 
                {
                    var val = new QuickFix.Fields.TimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeUnit val) 
            { 
                TimeUnit = val;
            }
            
            public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeUnit val) 
            { 
                return IsSetTimeUnit();
            }
            
            public bool IsSetTimeUnit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TimeUnit);
            }
            
            public QuickFix.Fields.MaturityTime MaturityTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityTime val) 
            { 
                MaturityTime = val;
            }
            
            public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityTime val) 
            { 
                return IsSetMaturityTime();
            }
            
            public bool IsSetMaturityTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaturityTime);
            }
            
            public QuickFix.Fields.SecurityGroup SecurityGroup
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityGroup val) 
            { 
                SecurityGroup = val;
            }
            
            public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityGroup val) 
            { 
                return IsSetSecurityGroup();
            }
            
            public bool IsSetSecurityGroup() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityGroup);
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount MinPriceIncrementAmount
            { 
                get 
                {
                    var val = new QuickFix.Fields.MinPriceIncrementAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                MinPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                return IsSetMinPriceIncrementAmount();
            }
            
            public bool IsSetMinPriceIncrementAmount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MinPriceIncrementAmount);
            }
            
            public QuickFix.Fields.UnitOfMeasureQty UnitOfMeasureQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                UnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                return IsSetUnitOfMeasureQty();
            }
            
            public bool IsSetUnitOfMeasureQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnitOfMeasureQty);
            }
            
            public QuickFix.Fields.SecurityXMLLen SecurityXMLLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityXMLLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLLen val) 
            { 
                SecurityXMLLen = val;
            }
            
            public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLLen val) 
            { 
                return IsSetSecurityXMLLen();
            }
            
            public bool IsSetSecurityXMLLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityXMLLen);
            }
            
            public QuickFix.Fields.SecurityXML SecurityXML
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityXML();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXML val) 
            { 
                SecurityXML = val;
            }
            
            public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXML val) 
            { 
                return IsSetSecurityXML();
            }
            
            public bool IsSetSecurityXML() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityXML);
            }
            
            public QuickFix.Fields.SecurityXMLSchema SecurityXMLSchema
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityXMLSchema();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                SecurityXMLSchema = val;
            }
            
            public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                return IsSetSecurityXMLSchema();
            }
            
            public bool IsSetSecurityXMLSchema() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityXMLSchema);
            }
            
            public QuickFix.Fields.ProductComplex ProductComplex
            { 
                get 
                {
                    var val = new QuickFix.Fields.ProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProductComplex val) 
            { 
                ProductComplex = val;
            }
            
            public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProductComplex val) 
            { 
                return IsSetProductComplex();
            }
            
            public bool IsSetProductComplex() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ProductComplex);
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure PriceUnitOfMeasure
            { 
                get 
                {
                    var val = new QuickFix.Fields.PriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                PriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                return IsSetPriceUnitOfMeasure();
            }
            
            public bool IsSetPriceUnitOfMeasure() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PriceUnitOfMeasure);
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty PriceUnitOfMeasureQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                PriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                return IsSetPriceUnitOfMeasureQty();
            }
            
            public bool IsSetPriceUnitOfMeasureQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PriceUnitOfMeasureQty);
            }
            
            public QuickFix.Fields.SettlMethod SettlMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlMethod val) 
            { 
                SettlMethod = val;
            }
            
            public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlMethod val) 
            { 
                return IsSetSettlMethod();
            }
            
            public bool IsSetSettlMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlMethod);
            }
            
            public QuickFix.Fields.ExerciseStyle ExerciseStyle
            { 
                get 
                {
                    var val = new QuickFix.Fields.ExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExerciseStyle val) 
            { 
                ExerciseStyle = val;
            }
            
            public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExerciseStyle val) 
            { 
                return IsSetExerciseStyle();
            }
            
            public bool IsSetExerciseStyle() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ExerciseStyle);
            }
            
            public QuickFix.Fields.OptPayAmount OptPayAmount
            { 
                get 
                {
                    var val = new QuickFix.Fields.OptPayAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptPayAmount val) 
            { 
                OptPayAmount = val;
            }
            
            public QuickFix.Fields.OptPayAmount Get(QuickFix.Fields.OptPayAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptPayAmount val) 
            { 
                return IsSetOptPayAmount();
            }
            
            public bool IsSetOptPayAmount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OptPayAmount);
            }
            
            public QuickFix.Fields.PriceQuoteMethod PriceQuoteMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.PriceQuoteMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                PriceQuoteMethod = val;
            }
            
            public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                return IsSetPriceQuoteMethod();
            }
            
            public bool IsSetPriceQuoteMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PriceQuoteMethod);
            }
            
            public QuickFix.Fields.ListMethod ListMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListMethod val) 
            { 
                ListMethod = val;
            }
            
            public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListMethod val) 
            { 
                return IsSetListMethod();
            }
            
            public bool IsSetListMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListMethod);
            }
            
            public QuickFix.Fields.CapPrice CapPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.CapPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CapPrice val) 
            { 
                CapPrice = val;
            }
            
            public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CapPrice val) 
            { 
                return IsSetCapPrice();
            }
            
            public bool IsSetCapPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CapPrice);
            }
            
            public QuickFix.Fields.FloorPrice FloorPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.FloorPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FloorPrice val) 
            { 
                FloorPrice = val;
            }
            
            public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FloorPrice val) 
            { 
                return IsSetFloorPrice();
            }
            
            public bool IsSetFloorPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.FloorPrice);
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
            
            public QuickFix.Fields.FlexibleIndicator FlexibleIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.FlexibleIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexibleIndicator val) 
            { 
                FlexibleIndicator = val;
            }
            
            public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexibleIndicator val) 
            { 
                return IsSetFlexibleIndicator();
            }
            
            public bool IsSetFlexibleIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.FlexibleIndicator);
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                FlexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                return IsSetFlexProductEligibilityIndicator();
            }
            
            public bool IsSetFlexProductEligibilityIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.FlexProductEligibilityIndicator);
            }
            
            public QuickFix.Fields.FuturesValuationMethod FuturesValuationMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.FuturesValuationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                FuturesValuationMethod = val;
            }
            
            public QuickFix.Fields.FuturesValuationMethod Get(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                return IsSetFuturesValuationMethod();
            }
            
            public bool IsSetFuturesValuationMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.FuturesValuationMethod);
            }
            
            public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                UnderlyingSymbol = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                return IsSetUnderlyingSymbol();
            }
            
            public bool IsSetUnderlyingSymbol() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSymbol);
            }
            
            public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                UnderlyingSymbolSfx = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                return IsSetUnderlyingSymbolSfx();
            }
            
            public bool IsSetUnderlyingSymbolSfx() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSymbolSfx);
            }
            
            public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                UnderlyingSecurityID = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                return IsSetUnderlyingSecurityID();
            }
            
            public bool IsSetUnderlyingSecurityID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityID);
            }
            
            public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                UnderlyingSecurityIDSource = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                return IsSetUnderlyingSecurityIDSource();
            }
            
            public bool IsSetUnderlyingSecurityIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityIDSource);
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                NoUnderlyingSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                return IsSetNoUnderlyingSecurityAltID();
            }
            
            public bool IsSetNoUnderlyingSecurityAltID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoUnderlyingSecurityAltID);
            }
            
            public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingProduct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingProduct val) 
            { 
                UnderlyingProduct = val;
            }
            
            public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingProduct val) 
            { 
                return IsSetUnderlyingProduct();
            }
            
            public bool IsSetUnderlyingProduct() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingProduct);
            }
            
            public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                UnderlyingCFICode = val;
            }
            
            public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                return IsSetUnderlyingCFICode();
            }
            
            public bool IsSetUnderlyingCFICode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCFICode);
            }
            
            public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                UnderlyingSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                return IsSetUnderlyingSecurityType();
            }
            
            public bool IsSetUnderlyingSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityType);
            }
            
            public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                UnderlyingSecuritySubType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                return IsSetUnderlyingSecuritySubType();
            }
            
            public bool IsSetUnderlyingSecuritySubType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSecuritySubType);
            }
            
            public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                UnderlyingMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                return IsSetUnderlyingMaturityMonthYear();
            }
            
            public bool IsSetUnderlyingMaturityMonthYear() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityMonthYear);
            }
            
            public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingMaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                UnderlyingMaturityDate = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                return IsSetUnderlyingMaturityDate();
            }
            
            public bool IsSetUnderlyingMaturityDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityDate);
            }
            
            public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                UnderlyingCouponPaymentDate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                return IsSetUnderlyingCouponPaymentDate();
            }
            
            public bool IsSetUnderlyingCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCouponPaymentDate);
            }
            
            public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingIssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                UnderlyingIssueDate = val;
            }
            
            public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                return IsSetUnderlyingIssueDate();
            }
            
            public bool IsSetUnderlyingIssueDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingIssueDate);
            }
            
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                UnderlyingRepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                return IsSetUnderlyingRepoCollateralSecurityType();
            }
            
            public bool IsSetUnderlyingRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingRepoCollateralSecurityType);
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                UnderlyingRepurchaseTerm = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                return IsSetUnderlyingRepurchaseTerm();
            }
            
            public bool IsSetUnderlyingRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingRepurchaseTerm);
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                UnderlyingRepurchaseRate = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                return IsSetUnderlyingRepurchaseRate();
            }
            
            public bool IsSetUnderlyingRepurchaseRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingRepurchaseRate);
            }
            
            public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingFactor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingFactor val) 
            { 
                UnderlyingFactor = val;
            }
            
            public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
            { 
                return IsSetUnderlyingFactor();
            }
            
            public bool IsSetUnderlyingFactor() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingFactor);
            }
            
            public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                UnderlyingCreditRating = val;
            }
            
            public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                return IsSetUnderlyingCreditRating();
            }
            
            public bool IsSetUnderlyingCreditRating() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCreditRating);
            }
            
            public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingInstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                UnderlyingInstrRegistry = val;
            }
            
            public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                return IsSetUnderlyingInstrRegistry();
            }
            
            public bool IsSetUnderlyingInstrRegistry() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrRegistry);
            }
            
            public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                UnderlyingCountryOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                return IsSetUnderlyingCountryOfIssue();
            }
            
            public bool IsSetUnderlyingCountryOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCountryOfIssue);
            }
            
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                UnderlyingStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                return IsSetUnderlyingStateOrProvinceOfIssue();
            }
            
            public bool IsSetUnderlyingStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingStateOrProvinceOfIssue);
            }
            
            public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                UnderlyingLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                return IsSetUnderlyingLocaleOfIssue();
            }
            
            public bool IsSetUnderlyingLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingLocaleOfIssue);
            }
            
            public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                UnderlyingRedemptionDate = val;
            }
            
            public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                return IsSetUnderlyingRedemptionDate();
            }
            
            public bool IsSetUnderlyingRedemptionDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingRedemptionDate);
            }
            
            public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingStrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                UnderlyingStrikePrice = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                return IsSetUnderlyingStrikePrice();
            }
            
            public bool IsSetUnderlyingStrikePrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingStrikePrice);
            }
            
            public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                UnderlyingStrikeCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                return IsSetUnderlyingStrikeCurrency();
            }
            
            public bool IsSetUnderlyingStrikeCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingStrikeCurrency);
            }
            
            public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingOptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                UnderlyingOptAttribute = val;
            }
            
            public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                return IsSetUnderlyingOptAttribute();
            }
            
            public bool IsSetUnderlyingOptAttribute() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingOptAttribute);
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                UnderlyingContractMultiplier = val;
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                return IsSetUnderlyingContractMultiplier();
            }
            
            public bool IsSetUnderlyingContractMultiplier() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingContractMultiplier);
            }
            
            public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                UnderlyingCouponRate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                return IsSetUnderlyingCouponRate();
            }
            
            public bool IsSetUnderlyingCouponRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCouponRate);
            }
            
            public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                UnderlyingSecurityExchange = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                return IsSetUnderlyingSecurityExchange();
            }
            
            public bool IsSetUnderlyingSecurityExchange() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityExchange);
            }
            
            public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                UnderlyingIssuer = val;
            }
            
            public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                return IsSetUnderlyingIssuer();
            }
            
            public bool IsSetUnderlyingIssuer() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingIssuer);
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                EncodedUnderlyingIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                return IsSetEncodedUnderlyingIssuerLen();
            }
            
            public bool IsSetEncodedUnderlyingIssuerLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingIssuerLen);
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                EncodedUnderlyingIssuer = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                return IsSetEncodedUnderlyingIssuer();
            }
            
            public bool IsSetEncodedUnderlyingIssuer() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingIssuer);
            }
            
            public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                UnderlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                return IsSetUnderlyingSecurityDesc();
            }
            
            public bool IsSetUnderlyingSecurityDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityDesc);
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                EncodedUnderlyingSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                return IsSetEncodedUnderlyingSecurityDescLen();
            }
            
            public bool IsSetEncodedUnderlyingSecurityDescLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingSecurityDescLen);
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                EncodedUnderlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                return IsSetEncodedUnderlyingSecurityDesc();
            }
            
            public bool IsSetEncodedUnderlyingSecurityDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingSecurityDesc);
            }
            
            public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                UnderlyingCPProgram = val;
            }
            
            public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                return IsSetUnderlyingCPProgram();
            }
            
            public bool IsSetUnderlyingCPProgram() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCPProgram);
            }
            
            public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                UnderlyingCPRegType = val;
            }
            
            public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                return IsSetUnderlyingCPRegType();
            }
            
            public bool IsSetUnderlyingCPRegType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCPRegType);
            }
            
            public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                UnderlyingCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                return IsSetUnderlyingCurrency();
            }
            
            public bool IsSetUnderlyingCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCurrency);
            }
            
            public QuickFix.Fields.UnderlyingQty UnderlyingQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingQty val) 
            { 
                UnderlyingQty = val;
            }
            
            public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingQty val) 
            { 
                return IsSetUnderlyingQty();
            }
            
            public bool IsSetUnderlyingQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingQty);
            }
            
            public QuickFix.Fields.UnderlyingPx UnderlyingPx
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPx val) 
            { 
                UnderlyingPx = val;
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
                return IsSetField(QuickFix.Fields.Tags.UnderlyingPx);
            }
            
            public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingDirtyPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                UnderlyingDirtyPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                return IsSetUnderlyingDirtyPrice();
            }
            
            public bool IsSetUnderlyingDirtyPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingDirtyPrice);
            }
            
            public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingEndPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                UnderlyingEndPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                return IsSetUnderlyingEndPrice();
            }
            
            public bool IsSetUnderlyingEndPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingEndPrice);
            }
            
            public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingStartValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                UnderlyingStartValue = val;
            }
            
            public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                return IsSetUnderlyingStartValue();
            }
            
            public bool IsSetUnderlyingStartValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingStartValue);
            }
            
            public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCurrentValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                UnderlyingCurrentValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                return IsSetUnderlyingCurrentValue();
            }
            
            public bool IsSetUnderlyingCurrentValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCurrentValue);
            }
            
            public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingEndValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                UnderlyingEndValue = val;
            }
            
            public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                return IsSetUnderlyingEndValue();
            }
            
            public bool IsSetUnderlyingEndValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingEndValue);
            }
            
            public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoUnderlyingStips();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                NoUnderlyingStips = val;
            }
            
            public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                return IsSetNoUnderlyingStips();
            }
            
            public bool IsSetNoUnderlyingStips() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoUnderlyingStips);
            }
            
            public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingAllocationPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                UnderlyingAllocationPercent = val;
            }
            
            public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                return IsSetUnderlyingAllocationPercent();
            }
            
            public bool IsSetUnderlyingAllocationPercent() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingAllocationPercent);
            }
            
            public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSettlementType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                UnderlyingSettlementType = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                return IsSetUnderlyingSettlementType();
            }
            
            public bool IsSetUnderlyingSettlementType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSettlementType);
            }
            
            public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCashAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                UnderlyingCashAmount = val;
            }
            
            public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                return IsSetUnderlyingCashAmount();
            }
            
            public bool IsSetUnderlyingCashAmount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCashAmount);
            }
            
            public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCashType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCashType val) 
            { 
                UnderlyingCashType = val;
            }
            
            public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCashType val) 
            { 
                return IsSetUnderlyingCashType();
            }
            
            public bool IsSetUnderlyingCashType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCashType);
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                UnderlyingUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                return IsSetUnderlyingUnitOfMeasure();
            }
            
            public bool IsSetUnderlyingUnitOfMeasure() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingUnitOfMeasure);
            }
            
            public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingTimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                UnderlyingTimeUnit = val;
            }
            
            public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                return IsSetUnderlyingTimeUnit();
            }
            
            public bool IsSetUnderlyingTimeUnit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingTimeUnit);
            }
            
            public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingCapValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                UnderlyingCapValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                return IsSetUnderlyingCapValue();
            }
            
            public bool IsSetUnderlyingCapValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingCapValue);
            }
            
            public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoUndlyInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                NoUndlyInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                return IsSetNoUndlyInstrumentParties();
            }
            
            public bool IsSetNoUndlyInstrumentParties() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoUndlyInstrumentParties);
            }
            
            public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingSettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                UnderlyingSettlMethod = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                return IsSetUnderlyingSettlMethod();
            }
            
            public bool IsSetUnderlyingSettlMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingSettlMethod);
            }
            
            public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                UnderlyingAdjustedQuantity = val;
            }
            
            public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                return IsSetUnderlyingAdjustedQuantity();
            }
            
            public bool IsSetUnderlyingAdjustedQuantity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingAdjustedQuantity);
            }
            
            public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingFXRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                UnderlyingFXRate = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                return IsSetUnderlyingFXRate();
            }
            
            public bool IsSetUnderlyingFXRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingFXRate);
            }
            
            public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingFXRateCalc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                UnderlyingFXRateCalc = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                return IsSetUnderlyingFXRateCalc();
            }
            
            public bool IsSetUnderlyingFXRateCalc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingFXRateCalc);
            }
            
            public QuickFix.Fields.UnderlyingMaturityTime UnderlyingMaturityTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingMaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                UnderlyingMaturityTime = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                return IsSetUnderlyingMaturityTime();
            }
            
            public bool IsSetUnderlyingMaturityTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityTime);
            }
            
            public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingPutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                UnderlyingPutOrCall = val;
            }
            
            public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                return IsSetUnderlyingPutOrCall();
            }
            
            public bool IsSetUnderlyingPutOrCall() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingPutOrCall);
            }
            
            public QuickFix.Fields.UnderlyingExerciseStyle UnderlyingExerciseStyle
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                UnderlyingExerciseStyle = val;
            }
            
            public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                return IsSetUnderlyingExerciseStyle();
            }
            
            public bool IsSetUnderlyingExerciseStyle() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingExerciseStyle);
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                UnderlyingUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                return IsSetUnderlyingUnitOfMeasureQty();
            }
            
            public bool IsSetUnderlyingUnitOfMeasureQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingUnitOfMeasureQty);
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                UnderlyingPriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                return IsSetUnderlyingPriceUnitOfMeasure();
            }
            
            public bool IsSetUnderlyingPriceUnitOfMeasure() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingPriceUnitOfMeasure);
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                UnderlyingPriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                return IsSetUnderlyingPriceUnitOfMeasureQty();
            }
            
            public bool IsSetUnderlyingPriceUnitOfMeasureQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnderlyingPriceUnitOfMeasureQty);
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
            
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyID, QuickFix.Fields.Tags.PartyIDSource, QuickFix.Fields.Tags.PartyRole, QuickFix.Fields.Tags.NoPartySubIDs, 0};
            
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
                
                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    NoPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoPartySubIDs);
                }
                
                            public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.PartySubID, QuickFix.Fields.Tags.PartySubIDType, 0};
                
                    public NoPartySubIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoPartySubIDs, QuickFix.Fields.Tags.PartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
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
                    
                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        PartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.PartySubIDType);
                    }
                    
                
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
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.EventType, QuickFix.Fields.Tags.EventDate, QuickFix.Fields.Tags.EventPx, QuickFix.Fields.Tags.EventText, QuickFix.Fields.Tags.EventTime, 0};
            
                public NoEventsGroup() 
                  :base( QuickFix.Fields.Tags.NoEvents, QuickFix.Fields.Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.EventType EventType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventType val) 
                { 
                    EventType = val;
                }
                
                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventType);
                }
                
                public QuickFix.Fields.EventDate EventDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventDate val) 
                { 
                    EventDate = val;
                }
                
                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventDate);
                }
                
                public QuickFix.Fields.EventPx EventPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventPx val) 
                { 
                    EventPx = val;
                }
                
                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventPx);
                }
                
                public QuickFix.Fields.EventText EventText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventText val) 
                { 
                    EventText = val;
                }
                
                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventText);
                }
                
                public QuickFix.Fields.EventTime EventTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventTime val) 
                { 
                    EventTime = val;
                }
                
                public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventTime val) 
                { 
                    return IsSetEventTime();
                }
                
                public bool IsSetEventTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventTime);
                }
                
            
            }
            public class NoInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.InstrumentPartyID, QuickFix.Fields.Tags.InstrumentPartyIDSource, QuickFix.Fields.Tags.InstrumentPartyRole, QuickFix.Fields.Tags.NoInstrumentPartySubIDs, 0};
            
                public NoInstrumentPartiesGroup() 
                  :base( QuickFix.Fields.Tags.NoInstrumentParties, QuickFix.Fields.Tags.InstrumentPartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoInstrumentPartiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.InstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    InstrumentPartyID = val;
                }
                
                public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    return IsSetInstrumentPartyID();
                }
                
                public bool IsSetInstrumentPartyID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.InstrumentPartyID);
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.InstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    InstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    return IsSetInstrumentPartyIDSource();
                }
                
                public bool IsSetInstrumentPartyIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.InstrumentPartyIDSource);
                }
                
                public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.InstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    InstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    return IsSetInstrumentPartyRole();
                }
                
                public bool IsSetInstrumentPartyRole() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.InstrumentPartyRole);
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    NoInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    return IsSetNoInstrumentPartySubIDs();
                }
                
                public bool IsSetNoInstrumentPartySubIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoInstrumentPartySubIDs);
                }
                
                            public class NoInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.InstrumentPartySubID, QuickFix.Fields.Tags.InstrumentPartySubIDType, 0};
                
                    public NoInstrumentPartySubIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoInstrumentPartySubIDs, QuickFix.Fields.Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrumentPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        InstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        return IsSetInstrumentPartySubID();
                    }
                    
                    public bool IsSetInstrumentPartySubID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrumentPartySubID);
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        InstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        return IsSetInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetInstrumentPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrumentPartySubIDType);
                    }
                    
                
                }
            }
            public class NoUnderlyingSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingSecurityAltIDSource, 0};
            
                public NoUnderlyingSecurityAltIDGroup() 
                  :base( QuickFix.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingSecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    UnderlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    return IsSetUnderlyingSecurityAltID();
                }
                
                public bool IsSetUnderlyingSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityAltID);
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    UnderlyingSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    return IsSetUnderlyingSecurityAltIDSource();
                }
                
                public bool IsSetUnderlyingSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityAltIDSource);
                }
                
            
            }
            public class NoUnderlyingStipsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingStipType, QuickFix.Fields.Tags.UnderlyingStipValue, 0};
            
                public NoUnderlyingStipsGroup() 
                  :base( QuickFix.Fields.Tags.NoUnderlyingStips, QuickFix.Fields.Tags.UnderlyingStipType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingStipsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingStipType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    UnderlyingStipType = val;
                }
                
                public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    return IsSetUnderlyingStipType();
                }
                
                public bool IsSetUnderlyingStipType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingStipType);
                }
                
                public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingStipValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    UnderlyingStipValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    return IsSetUnderlyingStipValue();
                }
                
                public bool IsSetUnderlyingStipValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingStipValue);
                }
                
            
            }
            public class NoUndlyInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.UndlyInstrumentPartyID, QuickFix.Fields.Tags.UndlyInstrumentPartyIDSource, QuickFix.Fields.Tags.UndlyInstrumentPartyRole, QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs, 0};
            
                public NoUndlyInstrumentPartiesGroup() 
                  :base( QuickFix.Fields.Tags.NoUndlyInstrumentParties, QuickFix.Fields.Tags.UndlyInstrumentPartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUndlyInstrumentPartiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.UndlyInstrumentPartyID UndlyInstrumentPartyID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UndlyInstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    UndlyInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyID Get(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    return IsSetUndlyInstrumentPartyID();
                }
                
                public bool IsSetUndlyInstrumentPartyID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UndlyInstrumentPartyID);
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    UndlyInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyIDSource Get(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    return IsSetUndlyInstrumentPartyIDSource();
                }
                
                public bool IsSetUndlyInstrumentPartyIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UndlyInstrumentPartyIDSource);
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyRole UndlyInstrumentPartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    UndlyInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyRole Get(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    return IsSetUndlyInstrumentPartyRole();
                }
                
                public bool IsSetUndlyInstrumentPartyRole() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UndlyInstrumentPartyRole);
                }
                
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    NoUndlyInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    return IsSetNoUndlyInstrumentPartySubIDs();
                }
                
                public bool IsSetNoUndlyInstrumentPartySubIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs);
                }
                
                            public class NoUndlyInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.UndlyInstrumentPartySubID, QuickFix.Fields.Tags.UndlyInstrumentPartySubIDType, 0};
                
                    public NoUndlyInstrumentPartySubIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs, QuickFix.Fields.Tags.UndlyInstrumentPartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUndlyInstrumentPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UndlyInstrumentPartySubID UndlyInstrumentPartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        UndlyInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubID Get(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        return IsSetUndlyInstrumentPartySubID();
                    }
                    
                    public bool IsSetUndlyInstrumentPartySubID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UndlyInstrumentPartySubID);
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        UndlyInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType Get(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        return IsSetUndlyInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetUndlyInstrumentPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UndlyInstrumentPartySubIDType);
                    }
                    
                
                }
            }
    }
}

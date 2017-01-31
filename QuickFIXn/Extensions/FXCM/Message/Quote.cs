// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class Quote : Message
    {
            public const string MsgType = "S";

            public Quote() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("S"));
            }

            public Quote(
                    QuickFix.FXCM.Fields.QuoteID aQuoteID,
                    QuickFix.FXCM.Fields.Symbol aSymbol
                ) : this()
            {
                this.QuoteID = aQuoteID;
                this.Symbol = aSymbol;
            }

            public QuickFix.FXCM.Fields.QuoteReqID QuoteReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QuoteReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QuoteReqID val) 
            { 
                QuoteReqID = val;
            }
            
            public QuickFix.FXCM.Fields.QuoteReqID Get(QuickFix.FXCM.Fields.QuoteReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QuoteReqID val) 
            { 
                return IsSetQuoteReqID();
            }
            
            public bool IsSetQuoteReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteReqID);
            }
            
            public QuickFix.FXCM.Fields.QuoteID QuoteID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QuoteID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QuoteID val) 
            { 
                QuoteID = val;
            }
            
            public QuickFix.FXCM.Fields.QuoteID Get(QuickFix.FXCM.Fields.QuoteID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QuoteID val) 
            { 
                return IsSetQuoteID();
            }
            
            public bool IsSetQuoteID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteID);
            }
            
            public QuickFix.FXCM.Fields.QuoteRespID QuoteRespID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QuoteRespID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QuoteRespID val) 
            { 
                QuoteRespID = val;
            }
            
            public QuickFix.FXCM.Fields.QuoteRespID Get(QuickFix.FXCM.Fields.QuoteRespID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QuoteRespID val) 
            { 
                return IsSetQuoteRespID();
            }
            
            public bool IsSetQuoteRespID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteRespID);
            }
            
            public QuickFix.FXCM.Fields.QuoteType QuoteType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QuoteType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QuoteType val) 
            { 
                QuoteType = val;
            }
            
            public QuickFix.FXCM.Fields.QuoteType Get(QuickFix.FXCM.Fields.QuoteType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QuoteType val) 
            { 
                return IsSetQuoteType();
            }
            
            public bool IsSetQuoteType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteType);
            }
            
            public QuickFix.FXCM.Fields.NoQuoteQualifiers NoQuoteQualifiers
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoQuoteQualifiers();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoQuoteQualifiers val) 
            { 
                NoQuoteQualifiers = val;
            }
            
            public QuickFix.FXCM.Fields.NoQuoteQualifiers Get(QuickFix.FXCM.Fields.NoQuoteQualifiers val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoQuoteQualifiers val) 
            { 
                return IsSetNoQuoteQualifiers();
            }
            
            public bool IsSetNoQuoteQualifiers() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers);
            }
            
            public QuickFix.FXCM.Fields.QuoteResponseLevel QuoteResponseLevel
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QuoteResponseLevel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QuoteResponseLevel val) 
            { 
                QuoteResponseLevel = val;
            }
            
            public QuickFix.FXCM.Fields.QuoteResponseLevel Get(QuickFix.FXCM.Fields.QuoteResponseLevel val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QuoteResponseLevel val) 
            { 
                return IsSetQuoteResponseLevel();
            }
            
            public bool IsSetQuoteResponseLevel() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteResponseLevel);
            }
            
            public QuickFix.FXCM.Fields.NoPartyIDs NoPartyIDs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoPartyIDs val) 
            { 
                NoPartyIDs = val;
            }
            
            public QuickFix.FXCM.Fields.NoPartyIDs Get(QuickFix.FXCM.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoPartyIDs);
            }
            
            public QuickFix.FXCM.Fields.TradingSessionID TradingSessionID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradingSessionID val) 
            { 
                TradingSessionID = val;
            }
            
            public QuickFix.FXCM.Fields.TradingSessionID Get(QuickFix.FXCM.Fields.TradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradingSessionID val) 
            { 
                return IsSetTradingSessionID();
            }
            
            public bool IsSetTradingSessionID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradingSessionID);
            }
            
            public QuickFix.FXCM.Fields.TradingSessionSubID TradingSessionSubID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradingSessionSubID val) 
            { 
                TradingSessionSubID = val;
            }
            
            public QuickFix.FXCM.Fields.TradingSessionSubID Get(QuickFix.FXCM.Fields.TradingSessionSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradingSessionSubID val) 
            { 
                return IsSetTradingSessionSubID();
            }
            
            public bool IsSetTradingSessionSubID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradingSessionSubID);
            }
            
            public QuickFix.FXCM.Fields.Symbol Symbol
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Symbol val) 
            { 
                Symbol = val;
            }
            
            public QuickFix.FXCM.Fields.Symbol Get(QuickFix.FXCM.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Symbol);
            }
            
            public QuickFix.FXCM.Fields.SymbolSfx SymbolSfx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                SymbolSfx = val;
            }
            
            public QuickFix.FXCM.Fields.SymbolSfx Get(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SymbolSfx);
            }
            
            public QuickFix.FXCM.Fields.SecurityID SecurityID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                SecurityID = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityID Get(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityID);
            }
            
            public QuickFix.FXCM.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                SecurityIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityIDSource Get(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityIDSource);
            }
            
            public QuickFix.FXCM.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                NoSecurityAltID = val;
            }
            
            public QuickFix.FXCM.Fields.NoSecurityAltID Get(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoSecurityAltID);
            }
            
            public QuickFix.FXCM.Fields.Product Product
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Product val) 
            { 
                Product = val;
            }
            
            public QuickFix.FXCM.Fields.Product Get(QuickFix.FXCM.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Product);
            }
            
            public QuickFix.FXCM.Fields.CFICode CFICode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CFICode val) 
            { 
                CFICode = val;
            }
            
            public QuickFix.FXCM.Fields.CFICode Get(QuickFix.FXCM.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CFICode);
            }
            
            public QuickFix.FXCM.Fields.SecurityType SecurityType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityType val) 
            { 
                SecurityType = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityType Get(QuickFix.FXCM.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityType);
            }
            
            public QuickFix.FXCM.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                SecuritySubType = val;
            }
            
            public QuickFix.FXCM.Fields.SecuritySubType Get(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecuritySubType);
            }
            
            public QuickFix.FXCM.Fields.MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                MaturityMonthYear = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityMonthYear Get(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityMonthYear);
            }
            
            public QuickFix.FXCM.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                MaturityDate = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityDate Get(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityDate);
            }
            
            public QuickFix.FXCM.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                CouponPaymentDate = val;
            }
            
            public QuickFix.FXCM.Fields.CouponPaymentDate Get(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CouponPaymentDate);
            }
            
            public QuickFix.FXCM.Fields.IssueDate IssueDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                IssueDate = val;
            }
            
            public QuickFix.FXCM.Fields.IssueDate Get(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.IssueDate);
            }
            
            public QuickFix.FXCM.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                RepoCollateralSecurityType = val;
            }
            
            public QuickFix.FXCM.Fields.RepoCollateralSecurityType Get(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepoCollateralSecurityType);
            }
            
            public QuickFix.FXCM.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                RepurchaseTerm = val;
            }
            
            public QuickFix.FXCM.Fields.RepurchaseTerm Get(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepurchaseTerm);
            }
            
            public QuickFix.FXCM.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                RepurchaseRate = val;
            }
            
            public QuickFix.FXCM.Fields.RepurchaseRate Get(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepurchaseRate);
            }
            
            public QuickFix.FXCM.Fields.Factor Factor
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Factor val) 
            { 
                Factor = val;
            }
            
            public QuickFix.FXCM.Fields.Factor Get(QuickFix.FXCM.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Factor);
            }
            
            public QuickFix.FXCM.Fields.CreditRating CreditRating
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                CreditRating = val;
            }
            
            public QuickFix.FXCM.Fields.CreditRating Get(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CreditRating);
            }
            
            public QuickFix.FXCM.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                InstrRegistry = val;
            }
            
            public QuickFix.FXCM.Fields.InstrRegistry Get(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InstrRegistry);
            }
            
            public QuickFix.FXCM.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                CountryOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.CountryOfIssue Get(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CountryOfIssue);
            }
            
            public QuickFix.FXCM.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.StateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StateOrProvinceOfIssue);
            }
            
            public QuickFix.FXCM.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                LocaleOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.LocaleOfIssue Get(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LocaleOfIssue);
            }
            
            public QuickFix.FXCM.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                RedemptionDate = val;
            }
            
            public QuickFix.FXCM.Fields.RedemptionDate Get(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RedemptionDate);
            }
            
            public QuickFix.FXCM.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                StrikePrice = val;
            }
            
            public QuickFix.FXCM.Fields.StrikePrice Get(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikePrice);
            }
            
            public QuickFix.FXCM.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                StrikeCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.StrikeCurrency Get(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikeCurrency);
            }
            
            public QuickFix.FXCM.Fields.OptAttribute OptAttribute
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                OptAttribute = val;
            }
            
            public QuickFix.FXCM.Fields.OptAttribute Get(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OptAttribute);
            }
            
            public QuickFix.FXCM.Fields.ContractMultiplier ContractMultiplier
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                ContractMultiplier = val;
            }
            
            public QuickFix.FXCM.Fields.ContractMultiplier Get(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContractMultiplier);
            }
            
            public QuickFix.FXCM.Fields.CouponRate CouponRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                CouponRate = val;
            }
            
            public QuickFix.FXCM.Fields.CouponRate Get(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CouponRate);
            }
            
            public QuickFix.FXCM.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                SecurityExchange = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityExchange Get(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityExchange);
            }
            
            public QuickFix.FXCM.Fields.Issuer Issuer
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Issuer val) 
            { 
                Issuer = val;
            }
            
            public QuickFix.FXCM.Fields.Issuer Get(QuickFix.FXCM.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Issuer);
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuerLen EncodedIssuerLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                EncodedIssuerLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuerLen Get(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedIssuerLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuer EncodedIssuer
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                EncodedIssuer = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuer Get(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedIssuer);
            }
            
            public QuickFix.FXCM.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                SecurityDesc = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityDesc Get(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityDesc);
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                EncodedSecurityDescLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedSecurityDescLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDesc EncodedSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                EncodedSecurityDesc = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDesc Get(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedSecurityDesc);
            }
            
            public QuickFix.FXCM.Fields.Pool Pool
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Pool val) 
            { 
                Pool = val;
            }
            
            public QuickFix.FXCM.Fields.Pool Get(QuickFix.FXCM.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Pool);
            }
            
            public QuickFix.FXCM.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                ContractSettlMonth = val;
            }
            
            public QuickFix.FXCM.Fields.ContractSettlMonth Get(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContractSettlMonth);
            }
            
            public QuickFix.FXCM.Fields.CPProgram CPProgram
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                CPProgram = val;
            }
            
            public QuickFix.FXCM.Fields.CPProgram Get(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CPProgram);
            }
            
            public QuickFix.FXCM.Fields.CPRegType CPRegType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                CPRegType = val;
            }
            
            public QuickFix.FXCM.Fields.CPRegType Get(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CPRegType);
            }
            
            public QuickFix.FXCM.Fields.NoEvents NoEvents
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                NoEvents = val;
            }
            
            public QuickFix.FXCM.Fields.NoEvents Get(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoEvents);
            }
            
            public QuickFix.FXCM.Fields.DatedDate DatedDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                DatedDate = val;
            }
            
            public QuickFix.FXCM.Fields.DatedDate Get(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DatedDate);
            }
            
            public QuickFix.FXCM.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                InterestAccrualDate = val;
            }
            
            public QuickFix.FXCM.Fields.InterestAccrualDate Get(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InterestAccrualDate);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymID FXCMSymID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                FXCMSymID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymID Get(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                return IsSetFXCMSymID();
            }
            
            public bool IsSetFXCMSymID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymID);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPrecision FXCMSymPrecision
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                FXCMSymPrecision = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPrecision Get(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                return IsSetFXCMSymPrecision();
            }
            
            public bool IsSetFXCMSymPrecision() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymPrecision);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPointSize FXCMSymPointSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymPointSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                FXCMSymPointSize = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPointSize Get(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                return IsSetFXCMSymPointSize();
            }
            
            public bool IsSetFXCMSymPointSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymPointSize);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymSortOrder FXCMSymSortOrder
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymSortOrder();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                FXCMSymSortOrder = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymSortOrder Get(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                return IsSetFXCMSymSortOrder();
            }
            
            public bool IsSetFXCMSymSortOrder() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymSortOrder);
            }
            
            public QuickFix.FXCM.Fields.FXCMProductID FXCMProductID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMProductID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                FXCMProductID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMProductID Get(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                return IsSetFXCMProductID();
            }
            
            public bool IsSetFXCMProductID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMProductID);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymMarginRatio FXCMSymMarginRatio
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymMarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                FXCMSymMarginRatio = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymMarginRatio Get(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                return IsSetFXCMSymMarginRatio();
            }
            
            public bool IsSetFXCMSymMarginRatio() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymMarginRatio);
            }
            
            public QuickFix.FXCM.Fields.Ccy Ccy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Ccy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Ccy val) 
            { 
                Ccy = val;
            }
            
            public QuickFix.FXCM.Fields.Ccy Get(QuickFix.FXCM.Fields.Ccy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Ccy val) 
            { 
                return IsSetCcy();
            }
            
            public bool IsSetCcy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Ccy);
            }
            
            public QuickFix.FXCM.Fields.RndLot RndLot
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RndLot();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RndLot val) 
            { 
                RndLot = val;
            }
            
            public QuickFix.FXCM.Fields.RndLot Get(QuickFix.FXCM.Fields.RndLot val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RndLot val) 
            { 
                return IsSetRndLot();
            }
            
            public bool IsSetRndLot() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RndLot);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestBuy FXCMSymInterestBuy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymInterestBuy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                FXCMSymInterestBuy = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestBuy Get(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                return IsSetFXCMSymInterestBuy();
            }
            
            public bool IsSetFXCMSymInterestBuy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymInterestBuy);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestSell FXCMSymInterestSell
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymInterestSell();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                FXCMSymInterestSell = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestSell Get(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                return IsSetFXCMSymInterestSell();
            }
            
            public bool IsSetFXCMSymInterestSell() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymInterestSell);
            }
            
            public QuickFix.FXCM.Fields.FXCMSubscriptionStatus FXCMSubscriptionStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSubscriptionStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                FXCMSubscriptionStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSubscriptionStatus Get(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                return IsSetFXCMSubscriptionStatus();
            }
            
            public bool IsSetFXCMSubscriptionStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSubscriptionStatus);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistStop FXCMCondDistStop
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistStop();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                FXCMCondDistStop = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistStop Get(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                return IsSetFXCMCondDistStop();
            }
            
            public bool IsSetFXCMCondDistStop() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistStop);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistLimit FXCMCondDistLimit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                FXCMCondDistLimit = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistLimit Get(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                return IsSetFXCMCondDistLimit();
            }
            
            public bool IsSetFXCMCondDistLimit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistLimit);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryStop FXCMCondDistEntryStop
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistEntryStop();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                FXCMCondDistEntryStop = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryStop Get(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                return IsSetFXCMCondDistEntryStop();
            }
            
            public bool IsSetFXCMCondDistEntryStop() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistEntryStop);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryLimit FXCMCondDistEntryLimit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistEntryLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                FXCMCondDistEntryLimit = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryLimit Get(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                return IsSetFXCMCondDistEntryLimit();
            }
            
            public bool IsSetFXCMCondDistEntryLimit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistEntryLimit);
            }
            
            public QuickFix.FXCM.Fields.FXCMMaxQuantity FXCMMaxQuantity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMMaxQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                FXCMMaxQuantity = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMMaxQuantity Get(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                return IsSetFXCMMaxQuantity();
            }
            
            public bool IsSetFXCMMaxQuantity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMMaxQuantity);
            }
            
            public QuickFix.FXCM.Fields.FXCMMinQuantity FXCMMinQuantity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMMinQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                FXCMMinQuantity = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMMinQuantity Get(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                return IsSetFXCMMinQuantity();
            }
            
            public bool IsSetFXCMMinQuantity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMMinQuantity);
            }
            
            public QuickFix.FXCM.Fields.FXCMTradingStatus FXCMTradingStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMTradingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                FXCMTradingStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMTradingStatus Get(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                return IsSetFXCMTradingStatus();
            }
            
            public bool IsSetFXCMTradingStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMTradingStatus);
            }
            
            public QuickFix.FXCM.Fields.AgreementDesc AgreementDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                AgreementDesc = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementDesc Get(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                return IsSetAgreementDesc();
            }
            
            public bool IsSetAgreementDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementDesc);
            }
            
            public QuickFix.FXCM.Fields.AgreementID AgreementID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                AgreementID = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementID Get(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                return IsSetAgreementID();
            }
            
            public bool IsSetAgreementID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementID);
            }
            
            public QuickFix.FXCM.Fields.AgreementDate AgreementDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                AgreementDate = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementDate Get(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                return IsSetAgreementDate();
            }
            
            public bool IsSetAgreementDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementDate);
            }
            
            public QuickFix.FXCM.Fields.AgreementCurrency AgreementCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                AgreementCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementCurrency Get(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                return IsSetAgreementCurrency();
            }
            
            public bool IsSetAgreementCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementCurrency);
            }
            
            public QuickFix.FXCM.Fields.TerminationType TerminationType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TerminationType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                TerminationType = val;
            }
            
            public QuickFix.FXCM.Fields.TerminationType Get(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                return IsSetTerminationType();
            }
            
            public bool IsSetTerminationType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TerminationType);
            }
            
            public QuickFix.FXCM.Fields.StartDate StartDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StartDate val) 
            { 
                StartDate = val;
            }
            
            public QuickFix.FXCM.Fields.StartDate Get(QuickFix.FXCM.Fields.StartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StartDate val) 
            { 
                return IsSetStartDate();
            }
            
            public bool IsSetStartDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StartDate);
            }
            
            public QuickFix.FXCM.Fields.EndDate EndDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndDate val) 
            { 
                EndDate = val;
            }
            
            public QuickFix.FXCM.Fields.EndDate Get(QuickFix.FXCM.Fields.EndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndDate val) 
            { 
                return IsSetEndDate();
            }
            
            public bool IsSetEndDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndDate);
            }
            
            public QuickFix.FXCM.Fields.DeliveryType DeliveryType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                DeliveryType = val;
            }
            
            public QuickFix.FXCM.Fields.DeliveryType Get(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                return IsSetDeliveryType();
            }
            
            public bool IsSetDeliveryType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DeliveryType);
            }
            
            public QuickFix.FXCM.Fields.MarginRatio MarginRatio
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                MarginRatio = val;
            }
            
            public QuickFix.FXCM.Fields.MarginRatio Get(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                return IsSetMarginRatio();
            }
            
            public bool IsSetMarginRatio() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MarginRatio);
            }
            
            public QuickFix.FXCM.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                NoUnderlyings = val;
            }
            
            public QuickFix.FXCM.Fields.NoUnderlyings Get(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyings);
            }
            
            public QuickFix.FXCM.Fields.Side Side
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Side val) 
            { 
                Side = val;
            }
            
            public QuickFix.FXCM.Fields.Side Get(QuickFix.FXCM.Fields.Side val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Side val) 
            { 
                return IsSetSide();
            }
            
            public bool IsSetSide() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Side);
            }
            
            public QuickFix.FXCM.Fields.OrderQty OrderQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderQty val) 
            { 
                OrderQty = val;
            }
            
            public QuickFix.FXCM.Fields.OrderQty Get(QuickFix.FXCM.Fields.OrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderQty val) 
            { 
                return IsSetOrderQty();
            }
            
            public bool IsSetOrderQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderQty);
            }
            
            public QuickFix.FXCM.Fields.CashOrderQty CashOrderQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CashOrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CashOrderQty val) 
            { 
                CashOrderQty = val;
            }
            
            public QuickFix.FXCM.Fields.CashOrderQty Get(QuickFix.FXCM.Fields.CashOrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CashOrderQty val) 
            { 
                return IsSetCashOrderQty();
            }
            
            public bool IsSetCashOrderQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CashOrderQty);
            }
            
            public QuickFix.FXCM.Fields.OrderPercent OrderPercent
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderPercent val) 
            { 
                OrderPercent = val;
            }
            
            public QuickFix.FXCM.Fields.OrderPercent Get(QuickFix.FXCM.Fields.OrderPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderPercent val) 
            { 
                return IsSetOrderPercent();
            }
            
            public bool IsSetOrderPercent() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderPercent);
            }
            
            public QuickFix.FXCM.Fields.RoundingDirection RoundingDirection
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RoundingDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RoundingDirection val) 
            { 
                RoundingDirection = val;
            }
            
            public QuickFix.FXCM.Fields.RoundingDirection Get(QuickFix.FXCM.Fields.RoundingDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RoundingDirection val) 
            { 
                return IsSetRoundingDirection();
            }
            
            public bool IsSetRoundingDirection() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RoundingDirection);
            }
            
            public QuickFix.FXCM.Fields.RoundingModulus RoundingModulus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RoundingModulus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RoundingModulus val) 
            { 
                RoundingModulus = val;
            }
            
            public QuickFix.FXCM.Fields.RoundingModulus Get(QuickFix.FXCM.Fields.RoundingModulus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RoundingModulus val) 
            { 
                return IsSetRoundingModulus();
            }
            
            public bool IsSetRoundingModulus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RoundingModulus);
            }
            
            public QuickFix.FXCM.Fields.SettlType SettlType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlType val) 
            { 
                SettlType = val;
            }
            
            public QuickFix.FXCM.Fields.SettlType Get(QuickFix.FXCM.Fields.SettlType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlType val) 
            { 
                return IsSetSettlType();
            }
            
            public bool IsSetSettlType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlType);
            }
            
            public QuickFix.FXCM.Fields.SettlDate SettlDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlDate val) 
            { 
                SettlDate = val;
            }
            
            public QuickFix.FXCM.Fields.SettlDate Get(QuickFix.FXCM.Fields.SettlDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlDate val) 
            { 
                return IsSetSettlDate();
            }
            
            public bool IsSetSettlDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlDate);
            }
            
            public QuickFix.FXCM.Fields.SettlDate2 SettlDate2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlDate2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlDate2 val) 
            { 
                SettlDate2 = val;
            }
            
            public QuickFix.FXCM.Fields.SettlDate2 Get(QuickFix.FXCM.Fields.SettlDate2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlDate2 val) 
            { 
                return IsSetSettlDate2();
            }
            
            public bool IsSetSettlDate2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlDate2);
            }
            
            public QuickFix.FXCM.Fields.OrderQty2 OrderQty2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderQty2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderQty2 val) 
            { 
                OrderQty2 = val;
            }
            
            public QuickFix.FXCM.Fields.OrderQty2 Get(QuickFix.FXCM.Fields.OrderQty2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderQty2 val) 
            { 
                return IsSetOrderQty2();
            }
            
            public bool IsSetOrderQty2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderQty2);
            }
            
            public QuickFix.FXCM.Fields.Currency Currency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Currency val) 
            { 
                Currency = val;
            }
            
            public QuickFix.FXCM.Fields.Currency Get(QuickFix.FXCM.Fields.Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Currency);
            }
            
            public QuickFix.FXCM.Fields.NoStipulations NoStipulations
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoStipulations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                NoStipulations = val;
            }
            
            public QuickFix.FXCM.Fields.NoStipulations Get(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                return IsSetNoStipulations();
            }
            
            public bool IsSetNoStipulations() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoStipulations);
            }
            
            public QuickFix.FXCM.Fields.Account Account
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Account val) 
            { 
                Account = val;
            }
            
            public QuickFix.FXCM.Fields.Account Get(QuickFix.FXCM.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Account);
            }
            
            public QuickFix.FXCM.Fields.AcctIDSource AcctIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AcctIDSource val) 
            { 
                AcctIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.AcctIDSource Get(QuickFix.FXCM.Fields.AcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AcctIDSource val) 
            { 
                return IsSetAcctIDSource();
            }
            
            public bool IsSetAcctIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AcctIDSource);
            }
            
            public QuickFix.FXCM.Fields.AccountType AccountType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccountType val) 
            { 
                AccountType = val;
            }
            
            public QuickFix.FXCM.Fields.AccountType Get(QuickFix.FXCM.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccountType);
            }
            
            public QuickFix.FXCM.Fields.NoLegs NoLegs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                NoLegs = val;
            }
            
            public QuickFix.FXCM.Fields.NoLegs Get(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegs);
            }
            
            public QuickFix.FXCM.Fields.BidPx BidPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidPx val) 
            { 
                BidPx = val;
            }
            
            public QuickFix.FXCM.Fields.BidPx Get(QuickFix.FXCM.Fields.BidPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidPx val) 
            { 
                return IsSetBidPx();
            }
            
            public bool IsSetBidPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidPx);
            }
            
            public QuickFix.FXCM.Fields.OfferPx OfferPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OfferPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OfferPx val) 
            { 
                OfferPx = val;
            }
            
            public QuickFix.FXCM.Fields.OfferPx Get(QuickFix.FXCM.Fields.OfferPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OfferPx val) 
            { 
                return IsSetOfferPx();
            }
            
            public bool IsSetOfferPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OfferPx);
            }
            
            public QuickFix.FXCM.Fields.MktBidPx MktBidPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MktBidPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MktBidPx val) 
            { 
                MktBidPx = val;
            }
            
            public QuickFix.FXCM.Fields.MktBidPx Get(QuickFix.FXCM.Fields.MktBidPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MktBidPx val) 
            { 
                return IsSetMktBidPx();
            }
            
            public bool IsSetMktBidPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MktBidPx);
            }
            
            public QuickFix.FXCM.Fields.MktOfferPx MktOfferPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MktOfferPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MktOfferPx val) 
            { 
                MktOfferPx = val;
            }
            
            public QuickFix.FXCM.Fields.MktOfferPx Get(QuickFix.FXCM.Fields.MktOfferPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MktOfferPx val) 
            { 
                return IsSetMktOfferPx();
            }
            
            public bool IsSetMktOfferPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MktOfferPx);
            }
            
            public QuickFix.FXCM.Fields.MinBidSize MinBidSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MinBidSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MinBidSize val) 
            { 
                MinBidSize = val;
            }
            
            public QuickFix.FXCM.Fields.MinBidSize Get(QuickFix.FXCM.Fields.MinBidSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MinBidSize val) 
            { 
                return IsSetMinBidSize();
            }
            
            public bool IsSetMinBidSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MinBidSize);
            }
            
            public QuickFix.FXCM.Fields.BidSize BidSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidSize val) 
            { 
                BidSize = val;
            }
            
            public QuickFix.FXCM.Fields.BidSize Get(QuickFix.FXCM.Fields.BidSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidSize val) 
            { 
                return IsSetBidSize();
            }
            
            public bool IsSetBidSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidSize);
            }
            
            public QuickFix.FXCM.Fields.MinOfferSize MinOfferSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MinOfferSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MinOfferSize val) 
            { 
                MinOfferSize = val;
            }
            
            public QuickFix.FXCM.Fields.MinOfferSize Get(QuickFix.FXCM.Fields.MinOfferSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MinOfferSize val) 
            { 
                return IsSetMinOfferSize();
            }
            
            public bool IsSetMinOfferSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MinOfferSize);
            }
            
            public QuickFix.FXCM.Fields.OfferSize OfferSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OfferSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OfferSize val) 
            { 
                OfferSize = val;
            }
            
            public QuickFix.FXCM.Fields.OfferSize Get(QuickFix.FXCM.Fields.OfferSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OfferSize val) 
            { 
                return IsSetOfferSize();
            }
            
            public bool IsSetOfferSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OfferSize);
            }
            
            public QuickFix.FXCM.Fields.ValidUntilTime ValidUntilTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ValidUntilTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ValidUntilTime val) 
            { 
                ValidUntilTime = val;
            }
            
            public QuickFix.FXCM.Fields.ValidUntilTime Get(QuickFix.FXCM.Fields.ValidUntilTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ValidUntilTime val) 
            { 
                return IsSetValidUntilTime();
            }
            
            public bool IsSetValidUntilTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ValidUntilTime);
            }
            
            public QuickFix.FXCM.Fields.BidSpotRate BidSpotRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidSpotRate val) 
            { 
                BidSpotRate = val;
            }
            
            public QuickFix.FXCM.Fields.BidSpotRate Get(QuickFix.FXCM.Fields.BidSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidSpotRate val) 
            { 
                return IsSetBidSpotRate();
            }
            
            public bool IsSetBidSpotRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidSpotRate);
            }
            
            public QuickFix.FXCM.Fields.OfferSpotRate OfferSpotRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OfferSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OfferSpotRate val) 
            { 
                OfferSpotRate = val;
            }
            
            public QuickFix.FXCM.Fields.OfferSpotRate Get(QuickFix.FXCM.Fields.OfferSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OfferSpotRate val) 
            { 
                return IsSetOfferSpotRate();
            }
            
            public bool IsSetOfferSpotRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OfferSpotRate);
            }
            
            public QuickFix.FXCM.Fields.BidForwardPoints BidForwardPoints
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidForwardPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidForwardPoints val) 
            { 
                BidForwardPoints = val;
            }
            
            public QuickFix.FXCM.Fields.BidForwardPoints Get(QuickFix.FXCM.Fields.BidForwardPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidForwardPoints val) 
            { 
                return IsSetBidForwardPoints();
            }
            
            public bool IsSetBidForwardPoints() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidForwardPoints);
            }
            
            public QuickFix.FXCM.Fields.OfferForwardPoints OfferForwardPoints
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OfferForwardPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OfferForwardPoints val) 
            { 
                OfferForwardPoints = val;
            }
            
            public QuickFix.FXCM.Fields.OfferForwardPoints Get(QuickFix.FXCM.Fields.OfferForwardPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OfferForwardPoints val) 
            { 
                return IsSetOfferForwardPoints();
            }
            
            public bool IsSetOfferForwardPoints() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OfferForwardPoints);
            }
            
            public QuickFix.FXCM.Fields.MidPx MidPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MidPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MidPx val) 
            { 
                MidPx = val;
            }
            
            public QuickFix.FXCM.Fields.MidPx Get(QuickFix.FXCM.Fields.MidPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MidPx val) 
            { 
                return IsSetMidPx();
            }
            
            public bool IsSetMidPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MidPx);
            }
            
            public QuickFix.FXCM.Fields.BidYield BidYield
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidYield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidYield val) 
            { 
                BidYield = val;
            }
            
            public QuickFix.FXCM.Fields.BidYield Get(QuickFix.FXCM.Fields.BidYield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidYield val) 
            { 
                return IsSetBidYield();
            }
            
            public bool IsSetBidYield() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidYield);
            }
            
            public QuickFix.FXCM.Fields.MidYield MidYield
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MidYield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MidYield val) 
            { 
                MidYield = val;
            }
            
            public QuickFix.FXCM.Fields.MidYield Get(QuickFix.FXCM.Fields.MidYield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MidYield val) 
            { 
                return IsSetMidYield();
            }
            
            public bool IsSetMidYield() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MidYield);
            }
            
            public QuickFix.FXCM.Fields.OfferYield OfferYield
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OfferYield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OfferYield val) 
            { 
                OfferYield = val;
            }
            
            public QuickFix.FXCM.Fields.OfferYield Get(QuickFix.FXCM.Fields.OfferYield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OfferYield val) 
            { 
                return IsSetOfferYield();
            }
            
            public bool IsSetOfferYield() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OfferYield);
            }
            
            public QuickFix.FXCM.Fields.TransactTime TransactTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                TransactTime = val;
            }
            
            public QuickFix.FXCM.Fields.TransactTime Get(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TransactTime);
            }
            
            public QuickFix.FXCM.Fields.OrdType OrdType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrdType val) 
            { 
                OrdType = val;
            }
            
            public QuickFix.FXCM.Fields.OrdType Get(QuickFix.FXCM.Fields.OrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrdType val) 
            { 
                return IsSetOrdType();
            }
            
            public bool IsSetOrdType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrdType);
            }
            
            public QuickFix.FXCM.Fields.BidForwardPoints2 BidForwardPoints2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidForwardPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidForwardPoints2 val) 
            { 
                BidForwardPoints2 = val;
            }
            
            public QuickFix.FXCM.Fields.BidForwardPoints2 Get(QuickFix.FXCM.Fields.BidForwardPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidForwardPoints2 val) 
            { 
                return IsSetBidForwardPoints2();
            }
            
            public bool IsSetBidForwardPoints2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidForwardPoints2);
            }
            
            public QuickFix.FXCM.Fields.OfferForwardPoints2 OfferForwardPoints2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OfferForwardPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OfferForwardPoints2 val) 
            { 
                OfferForwardPoints2 = val;
            }
            
            public QuickFix.FXCM.Fields.OfferForwardPoints2 Get(QuickFix.FXCM.Fields.OfferForwardPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OfferForwardPoints2 val) 
            { 
                return IsSetOfferForwardPoints2();
            }
            
            public bool IsSetOfferForwardPoints2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OfferForwardPoints2);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrBidFxRate SettlCurrBidFxRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrBidFxRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrBidFxRate val) 
            { 
                SettlCurrBidFxRate = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrBidFxRate Get(QuickFix.FXCM.Fields.SettlCurrBidFxRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrBidFxRate val) 
            { 
                return IsSetSettlCurrBidFxRate();
            }
            
            public bool IsSetSettlCurrBidFxRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrBidFxRate);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrOfferFxRate SettlCurrOfferFxRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrOfferFxRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrOfferFxRate val) 
            { 
                SettlCurrOfferFxRate = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrOfferFxRate Get(QuickFix.FXCM.Fields.SettlCurrOfferFxRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrOfferFxRate val) 
            { 
                return IsSetSettlCurrOfferFxRate();
            }
            
            public bool IsSetSettlCurrOfferFxRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrOfferFxRate);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrFxRateCalc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                SettlCurrFxRateCalc = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRateCalc Get(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                return IsSetSettlCurrFxRateCalc();
            }
            
            public bool IsSetSettlCurrFxRateCalc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrFxRateCalc);
            }
            
            public QuickFix.FXCM.Fields.CommType CommType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CommType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CommType val) 
            { 
                CommType = val;
            }
            
            public QuickFix.FXCM.Fields.CommType Get(QuickFix.FXCM.Fields.CommType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CommType val) 
            { 
                return IsSetCommType();
            }
            
            public bool IsSetCommType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CommType);
            }
            
            public QuickFix.FXCM.Fields.Commission Commission
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Commission();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Commission val) 
            { 
                Commission = val;
            }
            
            public QuickFix.FXCM.Fields.Commission Get(QuickFix.FXCM.Fields.Commission val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Commission val) 
            { 
                return IsSetCommission();
            }
            
            public bool IsSetCommission() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Commission);
            }
            
            public QuickFix.FXCM.Fields.CustOrderCapacity CustOrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CustOrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CustOrderCapacity val) 
            { 
                CustOrderCapacity = val;
            }
            
            public QuickFix.FXCM.Fields.CustOrderCapacity Get(QuickFix.FXCM.Fields.CustOrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CustOrderCapacity val) 
            { 
                return IsSetCustOrderCapacity();
            }
            
            public bool IsSetCustOrderCapacity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CustOrderCapacity);
            }
            
            public QuickFix.FXCM.Fields.ExDestination ExDestination
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExDestination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExDestination val) 
            { 
                ExDestination = val;
            }
            
            public QuickFix.FXCM.Fields.ExDestination Get(QuickFix.FXCM.Fields.ExDestination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExDestination val) 
            { 
                return IsSetExDestination();
            }
            
            public bool IsSetExDestination() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExDestination);
            }
            
            public QuickFix.FXCM.Fields.OrderCapacity OrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderCapacity val) 
            { 
                OrderCapacity = val;
            }
            
            public QuickFix.FXCM.Fields.OrderCapacity Get(QuickFix.FXCM.Fields.OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderCapacity);
            }
            
            public QuickFix.FXCM.Fields.PriceType PriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PriceType val) 
            { 
                PriceType = val;
            }
            
            public QuickFix.FXCM.Fields.PriceType Get(QuickFix.FXCM.Fields.PriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PriceType val) 
            { 
                return IsSetPriceType();
            }
            
            public bool IsSetPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PriceType);
            }
            
            public QuickFix.FXCM.Fields.Spread Spread
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Spread();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Spread val) 
            { 
                Spread = val;
            }
            
            public QuickFix.FXCM.Fields.Spread Get(QuickFix.FXCM.Fields.Spread val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Spread val) 
            { 
                return IsSetSpread();
            }
            
            public bool IsSetSpread() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Spread);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurveCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                BenchmarkCurveCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveCurrency Get(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                return IsSetBenchmarkCurveCurrency();
            }
            
            public bool IsSetBenchmarkCurveCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurveCurrency);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveName BenchmarkCurveName
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurveName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                BenchmarkCurveName = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveName Get(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                return IsSetBenchmarkCurveName();
            }
            
            public bool IsSetBenchmarkCurveName() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurveName);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurvePoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                BenchmarkCurvePoint = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurvePoint Get(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                return IsSetBenchmarkCurvePoint();
            }
            
            public bool IsSetBenchmarkCurvePoint() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurvePoint);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPrice BenchmarkPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                BenchmarkPrice = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPrice Get(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                return IsSetBenchmarkPrice();
            }
            
            public bool IsSetBenchmarkPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkPrice);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPriceType BenchmarkPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                BenchmarkPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPriceType Get(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                return IsSetBenchmarkPriceType();
            }
            
            public bool IsSetBenchmarkPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkPriceType);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityID BenchmarkSecurityID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                BenchmarkSecurityID = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityID Get(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                return IsSetBenchmarkSecurityID();
            }
            
            public bool IsSetBenchmarkSecurityID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkSecurityID);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                BenchmarkSecurityIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityIDSource Get(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                return IsSetBenchmarkSecurityIDSource();
            }
            
            public bool IsSetBenchmarkSecurityIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkSecurityIDSource);
            }
            
            public QuickFix.FXCM.Fields.YieldType YieldType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldType val) 
            { 
                YieldType = val;
            }
            
            public QuickFix.FXCM.Fields.YieldType Get(QuickFix.FXCM.Fields.YieldType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldType val) 
            { 
                return IsSetYieldType();
            }
            
            public bool IsSetYieldType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldType);
            }
            
            public QuickFix.FXCM.Fields.Yield Yield
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Yield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Yield val) 
            { 
                Yield = val;
            }
            
            public QuickFix.FXCM.Fields.Yield Get(QuickFix.FXCM.Fields.Yield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Yield val) 
            { 
                return IsSetYield();
            }
            
            public bool IsSetYield() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Yield);
            }
            
            public QuickFix.FXCM.Fields.YieldCalcDate YieldCalcDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldCalcDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                YieldCalcDate = val;
            }
            
            public QuickFix.FXCM.Fields.YieldCalcDate Get(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                return IsSetYieldCalcDate();
            }
            
            public bool IsSetYieldCalcDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldCalcDate);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionDate YieldRedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                YieldRedemptionDate = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionDate Get(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                return IsSetYieldRedemptionDate();
            }
            
            public bool IsSetYieldRedemptionDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionDate);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPrice YieldRedemptionPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                YieldRedemptionPrice = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPrice Get(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                return IsSetYieldRedemptionPrice();
            }
            
            public bool IsSetYieldRedemptionPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionPrice);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                YieldRedemptionPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPriceType Get(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                return IsSetYieldRedemptionPriceType();
            }
            
            public bool IsSetYieldRedemptionPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionPriceType);
            }
            
            public QuickFix.FXCM.Fields.Text Text
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Text val) 
            { 
                Text = val;
            }
            
            public QuickFix.FXCM.Fields.Text Get(QuickFix.FXCM.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Text);
            }
            
            public QuickFix.FXCM.Fields.EncodedTextLen EncodedTextLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                EncodedTextLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedTextLen Get(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedTextLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedText EncodedText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                EncodedText = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedText Get(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedText);
            }
            
            public class NoQuoteQualifiersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.QuoteQualifier, 0};
            
                public NoQuoteQualifiersGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoQuoteQualifiers, QuickFix.FXCM.Fields.Tags.QuoteQualifier, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoQuoteQualifiersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.QuoteQualifier QuoteQualifier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.QuoteQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.QuoteQualifier val) 
                { 
                    QuoteQualifier = val;
                }
                
                public QuickFix.FXCM.Fields.QuoteQualifier Get(QuickFix.FXCM.Fields.QuoteQualifier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.QuoteQualifier val) 
                { 
                    return IsSetQuoteQualifier();
                }
                
                public bool IsSetQuoteQualifier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteQualifier);
                }
                
            
            }
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.PartyID, QuickFix.FXCM.Fields.Tags.PartyIDSource, QuickFix.FXCM.Fields.Tags.PartyRole, QuickFix.FXCM.Fields.Tags.NoPartySubIDs, 0};
            
                public NoPartyIDsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoPartyIDs, QuickFix.FXCM.Fields.Tags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.PartyID PartyID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PartyID val) 
                { 
                    PartyID = val;
                }
                
                public QuickFix.FXCM.Fields.PartyID Get(QuickFix.FXCM.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PartyID);
                }
                
                public QuickFix.FXCM.Fields.PartyIDSource PartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PartyIDSource val) 
                { 
                    PartyIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.PartyIDSource Get(QuickFix.FXCM.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PartyIDSource);
                }
                
                public QuickFix.FXCM.Fields.PartyRole PartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PartyRole val) 
                { 
                    PartyRole = val;
                }
                
                public QuickFix.FXCM.Fields.PartyRole Get(QuickFix.FXCM.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PartyRole);
                }
                
                public QuickFix.FXCM.Fields.NoPartySubIDs NoPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoPartySubIDs val) 
                { 
                    NoPartySubIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoPartySubIDs Get(QuickFix.FXCM.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoPartySubIDs);
                }
                
                            public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.PartySubID, QuickFix.FXCM.Fields.Tags.PartySubIDType, 0};
                
                    public NoPartySubIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoPartySubIDs, QuickFix.FXCM.Fields.Tags.PartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.PartySubID PartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.PartySubID val) 
                    { 
                        PartySubID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.PartySubID Get(QuickFix.FXCM.Fields.PartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.PartySubID val) 
                    { 
                        return IsSetPartySubID();
                    }
                    
                    public bool IsSetPartySubID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.PartySubID);
                    }
                    
                    public QuickFix.FXCM.Fields.PartySubIDType PartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.PartySubIDType val) 
                    { 
                        PartySubIDType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.PartySubIDType Get(QuickFix.FXCM.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.PartySubIDType);
                    }
                    
                
                }
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SecurityAltID, QuickFix.FXCM.Fields.Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoSecurityAltID, QuickFix.FXCM.Fields.Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    SecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityAltID Get(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    SecurityAltIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityAltIDSource Get(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityAltIDSource);
                }
                
            
            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.EventType, QuickFix.FXCM.Fields.Tags.EventDate, QuickFix.FXCM.Fields.Tags.EventPx, QuickFix.FXCM.Fields.Tags.EventText, 0};
            
                public NoEventsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoEvents, QuickFix.FXCM.Fields.Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.EventType EventType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventType val) 
                { 
                    EventType = val;
                }
                
                public QuickFix.FXCM.Fields.EventType Get(QuickFix.FXCM.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventType);
                }
                
                public QuickFix.FXCM.Fields.EventDate EventDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    EventDate = val;
                }
                
                public QuickFix.FXCM.Fields.EventDate Get(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventDate);
                }
                
                public QuickFix.FXCM.Fields.EventPx EventPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    EventPx = val;
                }
                
                public QuickFix.FXCM.Fields.EventPx Get(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventPx);
                }
                
                public QuickFix.FXCM.Fields.EventText EventText
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventText val) 
                { 
                    EventText = val;
                }
                
                public QuickFix.FXCM.Fields.EventText Get(QuickFix.FXCM.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventText);
                }
                
            
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingSymbol, QuickFix.FXCM.Fields.Tags.UnderlyingSymbolSfx, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityIDSource, QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingProduct, QuickFix.FXCM.Fields.Tags.UnderlyingCFICode, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityType, QuickFix.FXCM.Fields.Tags.UnderlyingSecuritySubType, QuickFix.FXCM.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.FXCM.Fields.Tags.UnderlyingMaturityDate, QuickFix.FXCM.Fields.Tags.UnderlyingCouponPaymentDate, QuickFix.FXCM.Fields.Tags.UnderlyingIssueDate, QuickFix.FXCM.Fields.Tags.UnderlyingRepoCollateralSecurityType, QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseTerm, QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseRate, QuickFix.FXCM.Fields.Tags.UnderlyingFactor, QuickFix.FXCM.Fields.Tags.UnderlyingCreditRating, QuickFix.FXCM.Fields.Tags.UnderlyingInstrRegistry, QuickFix.FXCM.Fields.Tags.UnderlyingCountryOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingStateOrProvinceOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingLocaleOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingRedemptionDate, QuickFix.FXCM.Fields.Tags.UnderlyingStrikePrice, QuickFix.FXCM.Fields.Tags.UnderlyingStrikeCurrency, QuickFix.FXCM.Fields.Tags.UnderlyingOptAttribute, QuickFix.FXCM.Fields.Tags.UnderlyingContractMultiplier, QuickFix.FXCM.Fields.Tags.UnderlyingCouponRate, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityExchange, QuickFix.FXCM.Fields.Tags.UnderlyingIssuer, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityDesc, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.FXCM.Fields.Tags.UnderlyingCPProgram, QuickFix.FXCM.Fields.Tags.UnderlyingCPRegType, QuickFix.FXCM.Fields.Tags.UnderlyingCurrency, QuickFix.FXCM.Fields.Tags.UnderlyingQty, QuickFix.FXCM.Fields.Tags.UnderlyingPx, QuickFix.FXCM.Fields.Tags.UnderlyingDirtyPrice, QuickFix.FXCM.Fields.Tags.UnderlyingEndPrice, QuickFix.FXCM.Fields.Tags.UnderlyingStartValue, QuickFix.FXCM.Fields.Tags.UnderlyingCurrentValue, QuickFix.FXCM.Fields.Tags.UnderlyingEndValue, QuickFix.FXCM.Fields.Tags.NoUnderlyingStips, 0};
            
                public NoUnderlyingsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoUnderlyings, QuickFix.FXCM.Fields.Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.UnderlyingSymbol UnderlyingSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    UnderlyingSymbol = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbol Get(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    return IsSetUnderlyingSymbol();
                }
                
                public bool IsSetUnderlyingSymbol() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSymbol);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    UnderlyingSymbolSfx = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbolSfx Get(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    return IsSetUnderlyingSymbolSfx();
                }
                
                public bool IsSetUnderlyingSymbolSfx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSymbolSfx);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityID UnderlyingSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    UnderlyingSecurityID = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityID Get(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    return IsSetUnderlyingSecurityID();
                }
                
                public bool IsSetUnderlyingSecurityID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityID);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    UnderlyingSecurityIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityIDSource Get(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return IsSetUnderlyingSecurityIDSource();
                }
                
                public bool IsSetUnderlyingSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityIDSource);
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    NoUnderlyingSecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID Get(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    return IsSetNoUnderlyingSecurityAltID();
                }
                
                public bool IsSetNoUnderlyingSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingProduct UnderlyingProduct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    UnderlyingProduct = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingProduct Get(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    return IsSetUnderlyingProduct();
                }
                
                public bool IsSetUnderlyingProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingProduct);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCFICode UnderlyingCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    UnderlyingCFICode = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCFICode Get(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    return IsSetUnderlyingCFICode();
                }
                
                public bool IsSetUnderlyingCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCFICode);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityType UnderlyingSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    UnderlyingSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityType Get(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    return IsSetUnderlyingSecurityType();
                }
                
                public bool IsSetUnderlyingSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    UnderlyingSecuritySubType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecuritySubType Get(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    return IsSetUnderlyingSecuritySubType();
                }
                
                public bool IsSetUnderlyingSecuritySubType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecuritySubType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    UnderlyingMaturityMonthYear = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear Get(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    return IsSetUnderlyingMaturityMonthYear();
                }
                
                public bool IsSetUnderlyingMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingMaturityMonthYear);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    UnderlyingMaturityDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityDate Get(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    return IsSetUnderlyingMaturityDate();
                }
                
                public bool IsSetUnderlyingMaturityDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingMaturityDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    UnderlyingCouponPaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate Get(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    return IsSetUnderlyingCouponPaymentDate();
                }
                
                public bool IsSetUnderlyingCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCouponPaymentDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssueDate UnderlyingIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    UnderlyingIssueDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssueDate Get(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    return IsSetUnderlyingIssueDate();
                }
                
                public bool IsSetUnderlyingIssueDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingIssueDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    UnderlyingRepoCollateralSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    return IsSetUnderlyingRepoCollateralSecurityType();
                }
                
                public bool IsSetUnderlyingRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepoCollateralSecurityType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    UnderlyingRepurchaseTerm = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm Get(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    return IsSetUnderlyingRepurchaseTerm();
                }
                
                public bool IsSetUnderlyingRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseTerm);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    UnderlyingRepurchaseRate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseRate Get(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return IsSetUnderlyingRepurchaseRate();
                }
                
                public bool IsSetUnderlyingRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseRate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingFactor UnderlyingFactor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    UnderlyingFactor = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingFactor Get(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    return IsSetUnderlyingFactor();
                }
                
                public bool IsSetUnderlyingFactor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingFactor);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCreditRating UnderlyingCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    UnderlyingCreditRating = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCreditRating Get(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    return IsSetUnderlyingCreditRating();
                }
                
                public bool IsSetUnderlyingCreditRating() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCreditRating);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    UnderlyingInstrRegistry = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingInstrRegistry Get(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    return IsSetUnderlyingInstrRegistry();
                }
                
                public bool IsSetUnderlyingInstrRegistry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingInstrRegistry);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    UnderlyingCountryOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCountryOfIssue Get(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    return IsSetUnderlyingCountryOfIssue();
                }
                
                public bool IsSetUnderlyingCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCountryOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    UnderlyingStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    return IsSetUnderlyingStateOrProvinceOfIssue();
                }
                
                public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStateOrProvinceOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    UnderlyingLocaleOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue Get(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    return IsSetUnderlyingLocaleOfIssue();
                }
                
                public bool IsSetUnderlyingLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingLocaleOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    UnderlyingRedemptionDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRedemptionDate Get(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    return IsSetUnderlyingRedemptionDate();
                }
                
                public bool IsSetUnderlyingRedemptionDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRedemptionDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    UnderlyingStrikePrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikePrice Get(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    return IsSetUnderlyingStrikePrice();
                }
                
                public bool IsSetUnderlyingStrikePrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStrikePrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    UnderlyingStrikeCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikeCurrency Get(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    return IsSetUnderlyingStrikeCurrency();
                }
                
                public bool IsSetUnderlyingStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStrikeCurrency);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    UnderlyingOptAttribute = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingOptAttribute Get(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    return IsSetUnderlyingOptAttribute();
                }
                
                public bool IsSetUnderlyingOptAttribute() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingOptAttribute);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    UnderlyingContractMultiplier = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingContractMultiplier Get(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    return IsSetUnderlyingContractMultiplier();
                }
                
                public bool IsSetUnderlyingContractMultiplier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingContractMultiplier);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponRate UnderlyingCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    UnderlyingCouponRate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponRate Get(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    return IsSetUnderlyingCouponRate();
                }
                
                public bool IsSetUnderlyingCouponRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCouponRate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    UnderlyingSecurityExchange = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityExchange Get(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    return IsSetUnderlyingSecurityExchange();
                }
                
                public bool IsSetUnderlyingSecurityExchange() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityExchange);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssuer UnderlyingIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    UnderlyingIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssuer Get(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    return IsSetUnderlyingIssuer();
                }
                
                public bool IsSetUnderlyingIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingIssuer);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    EncodedUnderlyingIssuerLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    return IsSetEncodedUnderlyingIssuerLen();
                }
                
                public bool IsSetEncodedUnderlyingIssuerLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuerLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    EncodedUnderlyingIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuer Get(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    return IsSetEncodedUnderlyingIssuer();
                }
                
                public bool IsSetEncodedUnderlyingIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuer);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    UnderlyingSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityDesc Get(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    return IsSetUnderlyingSecurityDesc();
                }
                
                public bool IsSetUnderlyingSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    EncodedUnderlyingSecurityDescLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDescLen();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDescLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    EncodedUnderlyingSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDesc();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPProgram UnderlyingCPProgram
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    UnderlyingCPProgram = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPProgram Get(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    return IsSetUnderlyingCPProgram();
                }
                
                public bool IsSetUnderlyingCPProgram() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCPProgram);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPRegType UnderlyingCPRegType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    UnderlyingCPRegType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPRegType Get(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    return IsSetUnderlyingCPRegType();
                }
                
                public bool IsSetUnderlyingCPRegType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCPRegType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrency UnderlyingCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    UnderlyingCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrency Get(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    return IsSetUnderlyingCurrency();
                }
                
                public bool IsSetUnderlyingCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCurrency);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingQty UnderlyingQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    UnderlyingQty = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingQty Get(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    return IsSetUnderlyingQty();
                }
                
                public bool IsSetUnderlyingQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingQty);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingPx UnderlyingPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    UnderlyingPx = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingPx Get(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    return IsSetUnderlyingPx();
                }
                
                public bool IsSetUnderlyingPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingPx);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingDirtyPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    UnderlyingDirtyPrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingDirtyPrice Get(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    return IsSetUnderlyingDirtyPrice();
                }
                
                public bool IsSetUnderlyingDirtyPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingDirtyPrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndPrice UnderlyingEndPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingEndPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    UnderlyingEndPrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndPrice Get(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    return IsSetUnderlyingEndPrice();
                }
                
                public bool IsSetUnderlyingEndPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingEndPrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStartValue UnderlyingStartValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStartValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    UnderlyingStartValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStartValue Get(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    return IsSetUnderlyingStartValue();
                }
                
                public bool IsSetUnderlyingStartValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStartValue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCurrentValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    UnderlyingCurrentValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrentValue Get(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    return IsSetUnderlyingCurrentValue();
                }
                
                public bool IsSetUnderlyingCurrentValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCurrentValue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndValue UnderlyingEndValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingEndValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    UnderlyingEndValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndValue Get(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    return IsSetUnderlyingEndValue();
                }
                
                public bool IsSetUnderlyingEndValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingEndValue);
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingStips NoUnderlyingStips
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoUnderlyingStips();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    NoUnderlyingStips = val;
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingStips Get(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    return IsSetNoUnderlyingStips();
                }
                
                public bool IsSetNoUnderlyingStips() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyingStips);
                }
                
                            public class NoUnderlyingSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltIDSource, 0};
                
                    public NoUnderlyingSecurityAltIDGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        UnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltID Get(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        return IsSetUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID);
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        UnderlyingSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityAltIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltIDSource);
                    }
                    
                
                }
                public class NoUnderlyingStipsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingStipType, QuickFix.FXCM.Fields.Tags.UnderlyingStipValue, 0};
                
                    public NoUnderlyingStipsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoUnderlyingStips, QuickFix.FXCM.Fields.Tags.UnderlyingStipType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingStipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.UnderlyingStipType UnderlyingStipType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingStipType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        UnderlyingStipType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipType Get(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        return IsSetUnderlyingStipType();
                    }
                    
                    public bool IsSetUnderlyingStipType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStipType);
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipValue UnderlyingStipValue
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingStipValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        UnderlyingStipValue = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipValue Get(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        return IsSetUnderlyingStipValue();
                    }
                    
                    public bool IsSetUnderlyingStipValue() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStipValue);
                    }
                    
                
                }
            }
            public class NoStipulationsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.StipulationType, QuickFix.FXCM.Fields.Tags.StipulationValue, 0};
            
                public NoStipulationsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoStipulations, QuickFix.FXCM.Fields.Tags.StipulationType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStipulationsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.StipulationType StipulationType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StipulationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    StipulationType = val;
                }
                
                public QuickFix.FXCM.Fields.StipulationType Get(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    return IsSetStipulationType();
                }
                
                public bool IsSetStipulationType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StipulationType);
                }
                
                public QuickFix.FXCM.Fields.StipulationValue StipulationValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StipulationValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    StipulationValue = val;
                }
                
                public QuickFix.FXCM.Fields.StipulationValue Get(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    return IsSetStipulationValue();
                }
                
                public bool IsSetStipulationValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StipulationValue);
                }
                
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegSymbol, QuickFix.FXCM.Fields.Tags.LegSymbolSfx, QuickFix.FXCM.Fields.Tags.LegSecurityID, QuickFix.FXCM.Fields.Tags.LegSecurityIDSource, QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegProduct, QuickFix.FXCM.Fields.Tags.LegCFICode, QuickFix.FXCM.Fields.Tags.LegSecurityType, QuickFix.FXCM.Fields.Tags.LegSecuritySubType, QuickFix.FXCM.Fields.Tags.LegMaturityMonthYear, QuickFix.FXCM.Fields.Tags.LegMaturityDate, QuickFix.FXCM.Fields.Tags.LegCouponPaymentDate, QuickFix.FXCM.Fields.Tags.LegIssueDate, QuickFix.FXCM.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.FXCM.Fields.Tags.LegRepurchaseTerm, QuickFix.FXCM.Fields.Tags.LegRepurchaseRate, QuickFix.FXCM.Fields.Tags.LegFactor, QuickFix.FXCM.Fields.Tags.LegCreditRating, QuickFix.FXCM.Fields.Tags.LegInstrRegistry, QuickFix.FXCM.Fields.Tags.LegCountryOfIssue, QuickFix.FXCM.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.FXCM.Fields.Tags.LegLocaleOfIssue, QuickFix.FXCM.Fields.Tags.LegRedemptionDate, QuickFix.FXCM.Fields.Tags.LegStrikePrice, QuickFix.FXCM.Fields.Tags.LegStrikeCurrency, QuickFix.FXCM.Fields.Tags.LegOptAttribute, QuickFix.FXCM.Fields.Tags.LegContractMultiplier, QuickFix.FXCM.Fields.Tags.LegCouponRate, QuickFix.FXCM.Fields.Tags.LegSecurityExchange, QuickFix.FXCM.Fields.Tags.LegIssuer, QuickFix.FXCM.Fields.Tags.EncodedLegIssuerLen, QuickFix.FXCM.Fields.Tags.EncodedLegIssuer, QuickFix.FXCM.Fields.Tags.LegSecurityDesc, QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDesc, QuickFix.FXCM.Fields.Tags.LegRatioQty, QuickFix.FXCM.Fields.Tags.LegSide, QuickFix.FXCM.Fields.Tags.LegCurrency, QuickFix.FXCM.Fields.Tags.LegPool, QuickFix.FXCM.Fields.Tags.LegDatedDate, QuickFix.FXCM.Fields.Tags.LegContractSettlMonth, QuickFix.FXCM.Fields.Tags.LegInterestAccrualDate, QuickFix.FXCM.Fields.Tags.LegQty, QuickFix.FXCM.Fields.Tags.LegSwapType, QuickFix.FXCM.Fields.Tags.LegSettlType, QuickFix.FXCM.Fields.Tags.LegSettlDate, QuickFix.FXCM.Fields.Tags.NoLegStipulations, QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, QuickFix.FXCM.Fields.Tags.LegPriceType, QuickFix.FXCM.Fields.Tags.LegBidPx, QuickFix.FXCM.Fields.Tags.LegOfferPx, QuickFix.FXCM.Fields.Tags.LegBenchmarkCurveCurrency, QuickFix.FXCM.Fields.Tags.LegBenchmarkCurveName, QuickFix.FXCM.Fields.Tags.LegBenchmarkCurvePoint, QuickFix.FXCM.Fields.Tags.LegBenchmarkPrice, QuickFix.FXCM.Fields.Tags.LegBenchmarkPriceType, 0};
            
                public NoLegsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoLegs, QuickFix.FXCM.Fields.Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    LegSymbol = val;
                }
                
                public QuickFix.FXCM.Fields.LegSymbol Get(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSymbol);
                }
                
                public QuickFix.FXCM.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    LegSymbolSfx = val;
                }
                
                public QuickFix.FXCM.Fields.LegSymbolSfx Get(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSymbolSfx);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    LegSecurityID = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityID Get(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityID);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    LegSecurityIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityIDSource Get(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityIDSource);
                }
                
                public QuickFix.FXCM.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    NoLegSecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.NoLegSecurityAltID Get(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    LegProduct = val;
                }
                
                public QuickFix.FXCM.Fields.LegProduct Get(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegProduct);
                }
                
                public QuickFix.FXCM.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    LegCFICode = val;
                }
                
                public QuickFix.FXCM.Fields.LegCFICode Get(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCFICode);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    LegSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityType Get(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityType);
                }
                
                public QuickFix.FXCM.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    LegSecuritySubType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecuritySubType Get(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecuritySubType);
                }
                
                public QuickFix.FXCM.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    LegMaturityMonthYear = val;
                }
                
                public QuickFix.FXCM.Fields.LegMaturityMonthYear Get(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegMaturityMonthYear);
                }
                
                public QuickFix.FXCM.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    LegMaturityDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegMaturityDate Get(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegMaturityDate);
                }
                
                public QuickFix.FXCM.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    LegCouponPaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegCouponPaymentDate Get(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCouponPaymentDate);
                }
                
                public QuickFix.FXCM.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    LegIssueDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegIssueDate Get(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegIssueDate);
                }
                
                public QuickFix.FXCM.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepoCollateralSecurityType Get(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepoCollateralSecurityType);
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    LegRepurchaseTerm = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseTerm Get(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepurchaseTerm);
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    LegRepurchaseRate = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseRate Get(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepurchaseRate);
                }
                
                public QuickFix.FXCM.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    LegFactor = val;
                }
                
                public QuickFix.FXCM.Fields.LegFactor Get(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegFactor);
                }
                
                public QuickFix.FXCM.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    LegCreditRating = val;
                }
                
                public QuickFix.FXCM.Fields.LegCreditRating Get(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCreditRating);
                }
                
                public QuickFix.FXCM.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    LegInstrRegistry = val;
                }
                
                public QuickFix.FXCM.Fields.LegInstrRegistry Get(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegInstrRegistry);
                }
                
                public QuickFix.FXCM.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    LegCountryOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegCountryOfIssue Get(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCountryOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStateOrProvinceOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    LegLocaleOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegLocaleOfIssue Get(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegLocaleOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    LegRedemptionDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegRedemptionDate Get(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRedemptionDate);
                }
                
                public QuickFix.FXCM.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    LegStrikePrice = val;
                }
                
                public QuickFix.FXCM.Fields.LegStrikePrice Get(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStrikePrice);
                }
                
                public QuickFix.FXCM.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    LegStrikeCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegStrikeCurrency Get(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStrikeCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    LegOptAttribute = val;
                }
                
                public QuickFix.FXCM.Fields.LegOptAttribute Get(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegOptAttribute);
                }
                
                public QuickFix.FXCM.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    LegContractMultiplier = val;
                }
                
                public QuickFix.FXCM.Fields.LegContractMultiplier Get(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegContractMultiplier);
                }
                
                public QuickFix.FXCM.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    LegCouponRate = val;
                }
                
                public QuickFix.FXCM.Fields.LegCouponRate Get(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCouponRate);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    LegSecurityExchange = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityExchange Get(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityExchange);
                }
                
                public QuickFix.FXCM.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    LegIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.LegIssuer Get(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegIssuer);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    EncodedLegIssuerLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuerLen Get(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegIssuerLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    EncodedLegIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuer Get(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegIssuer);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    LegSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityDesc Get(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDescLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDesc Get(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    LegRatioQty = val;
                }
                
                public QuickFix.FXCM.Fields.LegRatioQty Get(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRatioQty);
                }
                
                public QuickFix.FXCM.Fields.LegSide LegSide
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    LegSide = val;
                }
                
                public QuickFix.FXCM.Fields.LegSide Get(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSide);
                }
                
                public QuickFix.FXCM.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    LegCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegCurrency Get(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegPool LegPool
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    LegPool = val;
                }
                
                public QuickFix.FXCM.Fields.LegPool Get(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegPool);
                }
                
                public QuickFix.FXCM.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    LegDatedDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegDatedDate Get(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegDatedDate);
                }
                
                public QuickFix.FXCM.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    LegContractSettlMonth = val;
                }
                
                public QuickFix.FXCM.Fields.LegContractSettlMonth Get(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegContractSettlMonth);
                }
                
                public QuickFix.FXCM.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    LegInterestAccrualDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegInterestAccrualDate Get(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegInterestAccrualDate);
                }
                
                public QuickFix.FXCM.Fields.LegQty LegQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegQty val) 
                { 
                    LegQty = val;
                }
                
                public QuickFix.FXCM.Fields.LegQty Get(QuickFix.FXCM.Fields.LegQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegQty val) 
                { 
                    return IsSetLegQty();
                }
                
                public bool IsSetLegQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegQty);
                }
                
                public QuickFix.FXCM.Fields.LegSwapType LegSwapType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSwapType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSwapType val) 
                { 
                    LegSwapType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSwapType Get(QuickFix.FXCM.Fields.LegSwapType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSwapType val) 
                { 
                    return IsSetLegSwapType();
                }
                
                public bool IsSetLegSwapType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSwapType);
                }
                
                public QuickFix.FXCM.Fields.LegSettlType LegSettlType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSettlType val) 
                { 
                    LegSettlType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSettlType Get(QuickFix.FXCM.Fields.LegSettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSettlType val) 
                { 
                    return IsSetLegSettlType();
                }
                
                public bool IsSetLegSettlType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSettlType);
                }
                
                public QuickFix.FXCM.Fields.LegSettlDate LegSettlDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSettlDate val) 
                { 
                    LegSettlDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegSettlDate Get(QuickFix.FXCM.Fields.LegSettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSettlDate val) 
                { 
                    return IsSetLegSettlDate();
                }
                
                public bool IsSetLegSettlDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSettlDate);
                }
                
                public QuickFix.FXCM.Fields.NoLegStipulations NoLegStipulations
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoLegStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoLegStipulations val) 
                { 
                    NoLegStipulations = val;
                }
                
                public QuickFix.FXCM.Fields.NoLegStipulations Get(QuickFix.FXCM.Fields.NoLegStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoLegStipulations val) 
                { 
                    return IsSetNoLegStipulations();
                }
                
                public bool IsSetNoLegStipulations() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegStipulations);
                }
                
                public QuickFix.FXCM.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    NoNestedPartyIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoNestedPartyIDs Get(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs);
                }
                
                public QuickFix.FXCM.Fields.LegPriceType LegPriceType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegPriceType val) 
                { 
                    LegPriceType = val;
                }
                
                public QuickFix.FXCM.Fields.LegPriceType Get(QuickFix.FXCM.Fields.LegPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegPriceType val) 
                { 
                    return IsSetLegPriceType();
                }
                
                public bool IsSetLegPriceType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegPriceType);
                }
                
                public QuickFix.FXCM.Fields.LegBidPx LegBidPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegBidPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegBidPx val) 
                { 
                    LegBidPx = val;
                }
                
                public QuickFix.FXCM.Fields.LegBidPx Get(QuickFix.FXCM.Fields.LegBidPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegBidPx val) 
                { 
                    return IsSetLegBidPx();
                }
                
                public bool IsSetLegBidPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegBidPx);
                }
                
                public QuickFix.FXCM.Fields.LegOfferPx LegOfferPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegOfferPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegOfferPx val) 
                { 
                    LegOfferPx = val;
                }
                
                public QuickFix.FXCM.Fields.LegOfferPx Get(QuickFix.FXCM.Fields.LegOfferPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegOfferPx val) 
                { 
                    return IsSetLegOfferPx();
                }
                
                public bool IsSetLegOfferPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegOfferPx);
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkCurveCurrency LegBenchmarkCurveCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegBenchmarkCurveCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegBenchmarkCurveCurrency val) 
                { 
                    LegBenchmarkCurveCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkCurveCurrency Get(QuickFix.FXCM.Fields.LegBenchmarkCurveCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegBenchmarkCurveCurrency val) 
                { 
                    return IsSetLegBenchmarkCurveCurrency();
                }
                
                public bool IsSetLegBenchmarkCurveCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegBenchmarkCurveCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkCurveName LegBenchmarkCurveName
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegBenchmarkCurveName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegBenchmarkCurveName val) 
                { 
                    LegBenchmarkCurveName = val;
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkCurveName Get(QuickFix.FXCM.Fields.LegBenchmarkCurveName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegBenchmarkCurveName val) 
                { 
                    return IsSetLegBenchmarkCurveName();
                }
                
                public bool IsSetLegBenchmarkCurveName() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegBenchmarkCurveName);
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkCurvePoint LegBenchmarkCurvePoint
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegBenchmarkCurvePoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegBenchmarkCurvePoint val) 
                { 
                    LegBenchmarkCurvePoint = val;
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkCurvePoint Get(QuickFix.FXCM.Fields.LegBenchmarkCurvePoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegBenchmarkCurvePoint val) 
                { 
                    return IsSetLegBenchmarkCurvePoint();
                }
                
                public bool IsSetLegBenchmarkCurvePoint() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegBenchmarkCurvePoint);
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkPrice LegBenchmarkPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegBenchmarkPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegBenchmarkPrice val) 
                { 
                    LegBenchmarkPrice = val;
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkPrice Get(QuickFix.FXCM.Fields.LegBenchmarkPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegBenchmarkPrice val) 
                { 
                    return IsSetLegBenchmarkPrice();
                }
                
                public bool IsSetLegBenchmarkPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegBenchmarkPrice);
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkPriceType LegBenchmarkPriceType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegBenchmarkPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegBenchmarkPriceType val) 
                { 
                    LegBenchmarkPriceType = val;
                }
                
                public QuickFix.FXCM.Fields.LegBenchmarkPriceType Get(QuickFix.FXCM.Fields.LegBenchmarkPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegBenchmarkPriceType val) 
                { 
                    return IsSetLegBenchmarkPriceType();
                }
                
                public bool IsSetLegBenchmarkPriceType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegBenchmarkPriceType);
                }
                
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        LegSecurityAltID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltID Get(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityAltID);
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltIDSource Get(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityAltIDSource);
                    }
                    
                
                }
                public class NoLegStipulationsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegStipulationType, QuickFix.FXCM.Fields.Tags.LegStipulationValue, 0};
                
                    public NoLegStipulationsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoLegStipulations, QuickFix.FXCM.Fields.Tags.LegStipulationType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegStipulationsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.LegStipulationType LegStipulationType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegStipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegStipulationType val) 
                    { 
                        LegStipulationType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegStipulationType Get(QuickFix.FXCM.Fields.LegStipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegStipulationType val) 
                    { 
                        return IsSetLegStipulationType();
                    }
                    
                    public bool IsSetLegStipulationType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegStipulationType);
                    }
                    
                    public QuickFix.FXCM.Fields.LegStipulationValue LegStipulationValue
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegStipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegStipulationValue val) 
                    { 
                        LegStipulationValue = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegStipulationValue Get(QuickFix.FXCM.Fields.LegStipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegStipulationValue val) 
                    { 
                        return IsSetLegStipulationValue();
                    }
                    
                    public bool IsSetLegStipulationValue() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegStipulationValue);
                    }
                    
                
                }
                public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.NestedPartyID, QuickFix.FXCM.Fields.Tags.NestedPartyIDSource, QuickFix.FXCM.Fields.Tags.NestedPartyRole, QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, QuickFix.FXCM.Fields.Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        NestedPartyID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyID Get(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyID);
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyIDSource Get(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyIDSource);
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        NestedPartyRole = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyRole Get(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyRole);
                    }
                    
                    public QuickFix.FXCM.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NoNestedPartySubIDs Get(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs);
                    }
                    
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.NestedPartySubID, QuickFix.FXCM.Fields.Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs, QuickFix.FXCM.Fields.Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.FXCM.Fields.NestedPartySubID NestedPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NestedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            NestedPartySubID = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubID Get(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            return IsSetNestedPartySubID();
                        }
                        
                        public bool IsSetNestedPartySubID() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartySubID);
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubIDType Get(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartySubIDType);
                        }
                        
                    
                    }
                }
            }
    }
}

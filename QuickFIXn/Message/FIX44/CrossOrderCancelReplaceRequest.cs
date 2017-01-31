// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class CrossOrderCancelReplaceRequest : Message
    {
            public const string MsgType = "t";

            public CrossOrderCancelReplaceRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("t"));
            }

            public CrossOrderCancelReplaceRequest(
                    QuickFix.Fields.CrossID aCrossID,
                    QuickFix.Fields.OrigCrossID aOrigCrossID,
                    QuickFix.Fields.CrossType aCrossType,
                    QuickFix.Fields.CrossPrioritization aCrossPrioritization,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.OrdType aOrdType
                ) : this()
            {
                this.CrossID = aCrossID;
                this.OrigCrossID = aOrigCrossID;
                this.CrossType = aCrossType;
                this.CrossPrioritization = aCrossPrioritization;
                this.Symbol = aSymbol;
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
            
            public QuickFix.Fields.CrossID CrossID
            { 
                get 
                {
                    var val = new QuickFix.Fields.CrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossID val) 
            { 
                CrossID = val;
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
                return IsSetField(QuickFix.Fields.Tags.CrossID);
            }
            
            public QuickFix.Fields.OrigCrossID OrigCrossID
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrigCrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigCrossID val) 
            { 
                OrigCrossID = val;
            }
            
            public QuickFix.Fields.OrigCrossID Get(QuickFix.Fields.OrigCrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigCrossID val) 
            { 
                return IsSetOrigCrossID();
            }
            
            public bool IsSetOrigCrossID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrigCrossID);
            }
            
            public QuickFix.Fields.CrossType CrossType
            { 
                get 
                {
                    var val = new QuickFix.Fields.CrossType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossType val) 
            { 
                CrossType = val;
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
                return IsSetField(QuickFix.Fields.Tags.CrossType);
            }
            
            public QuickFix.Fields.CrossPrioritization CrossPrioritization
            { 
                get 
                {
                    var val = new QuickFix.Fields.CrossPrioritization();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossPrioritization val) 
            { 
                CrossPrioritization = val;
            }
            
            public QuickFix.Fields.CrossPrioritization Get(QuickFix.Fields.CrossPrioritization val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossPrioritization val) 
            { 
                return IsSetCrossPrioritization();
            }
            
            public bool IsSetCrossPrioritization() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CrossPrioritization);
            }
            
            public QuickFix.Fields.NoSides NoSides
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoSides();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSides val) 
            { 
                NoSides = val;
            }
            
            public QuickFix.Fields.NoSides Get(QuickFix.Fields.NoSides val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSides val) 
            { 
                return IsSetNoSides();
            }
            
            public bool IsSetNoSides() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoSides);
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
            
            public QuickFix.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyings val) 
            { 
                NoUnderlyings = val;
            }
            
            public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoUnderlyings);
            }
            
            public QuickFix.Fields.NoLegs NoLegs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLegs val) 
            { 
                NoLegs = val;
            }
            
            public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoLegs);
            }
            
            public QuickFix.Fields.SettlType SettlType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlType val) 
            { 
                SettlType = val;
            }
            
            public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlType val) 
            { 
                return IsSetSettlType();
            }
            
            public bool IsSetSettlType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlType);
            }
            
            public QuickFix.Fields.SettlDate SettlDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDate val) 
            { 
                SettlDate = val;
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
                return IsSetField(QuickFix.Fields.Tags.SettlDate);
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
            
            public QuickFix.Fields.NoStipulations NoStipulations
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoStipulations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoStipulations val) 
            { 
                NoStipulations = val;
            }
            
            public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoStipulations val) 
            { 
                return IsSetNoStipulations();
            }
            
            public bool IsSetNoStipulations() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoStipulations);
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
            
            public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkPrice val) 
            { 
                BenchmarkPrice = val;
            }
            
            public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkPrice val) 
            { 
                return IsSetBenchmarkPrice();
            }
            
            public bool IsSetBenchmarkPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkPrice);
            }
            
            public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                BenchmarkPriceType = val;
            }
            
            public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                return IsSetBenchmarkPriceType();
            }
            
            public bool IsSetBenchmarkPriceType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkPriceType);
            }
            
            public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                BenchmarkSecurityID = val;
            }
            
            public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                return IsSetBenchmarkSecurityID();
            }
            
            public bool IsSetBenchmarkSecurityID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkSecurityID);
            }
            
            public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                BenchmarkSecurityIDSource = val;
            }
            
            public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                return IsSetBenchmarkSecurityIDSource();
            }
            
            public bool IsSetBenchmarkSecurityIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BenchmarkSecurityIDSource);
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
            
            public QuickFix.Fields.YieldCalcDate YieldCalcDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.YieldCalcDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldCalcDate val) 
            { 
                YieldCalcDate = val;
            }
            
            public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldCalcDate val) 
            { 
                return IsSetYieldCalcDate();
            }
            
            public bool IsSetYieldCalcDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.YieldCalcDate);
            }
            
            public QuickFix.Fields.YieldRedemptionDate YieldRedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.YieldRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                YieldRedemptionDate = val;
            }
            
            public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                return IsSetYieldRedemptionDate();
            }
            
            public bool IsSetYieldRedemptionDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.YieldRedemptionDate);
            }
            
            public QuickFix.Fields.YieldRedemptionPrice YieldRedemptionPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.YieldRedemptionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                YieldRedemptionPrice = val;
            }
            
            public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                return IsSetYieldRedemptionPrice();
            }
            
            public bool IsSetYieldRedemptionPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.YieldRedemptionPrice);
            }
            
            public QuickFix.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
            { 
                get 
                {
                    var val = new QuickFix.Fields.YieldRedemptionPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                YieldRedemptionPriceType = val;
            }
            
            public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                return IsSetYieldRedemptionPriceType();
            }
            
            public bool IsSetYieldRedemptionPriceType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.YieldRedemptionPriceType);
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
            
            public QuickFix.Fields.PegOffsetValue PegOffsetValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.PegOffsetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegOffsetValue val) 
            { 
                PegOffsetValue = val;
            }
            
            public QuickFix.Fields.PegOffsetValue Get(QuickFix.Fields.PegOffsetValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegOffsetValue val) 
            { 
                return IsSetPegOffsetValue();
            }
            
            public bool IsSetPegOffsetValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PegOffsetValue);
            }
            
            public QuickFix.Fields.PegMoveType PegMoveType
            { 
                get 
                {
                    var val = new QuickFix.Fields.PegMoveType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegMoveType val) 
            { 
                PegMoveType = val;
            }
            
            public QuickFix.Fields.PegMoveType Get(QuickFix.Fields.PegMoveType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegMoveType val) 
            { 
                return IsSetPegMoveType();
            }
            
            public bool IsSetPegMoveType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PegMoveType);
            }
            
            public QuickFix.Fields.PegOffsetType PegOffsetType
            { 
                get 
                {
                    var val = new QuickFix.Fields.PegOffsetType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegOffsetType val) 
            { 
                PegOffsetType = val;
            }
            
            public QuickFix.Fields.PegOffsetType Get(QuickFix.Fields.PegOffsetType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegOffsetType val) 
            { 
                return IsSetPegOffsetType();
            }
            
            public bool IsSetPegOffsetType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PegOffsetType);
            }
            
            public QuickFix.Fields.PegLimitType PegLimitType
            { 
                get 
                {
                    var val = new QuickFix.Fields.PegLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegLimitType val) 
            { 
                PegLimitType = val;
            }
            
            public QuickFix.Fields.PegLimitType Get(QuickFix.Fields.PegLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegLimitType val) 
            { 
                return IsSetPegLimitType();
            }
            
            public bool IsSetPegLimitType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PegLimitType);
            }
            
            public QuickFix.Fields.PegRoundDirection PegRoundDirection
            { 
                get 
                {
                    var val = new QuickFix.Fields.PegRoundDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegRoundDirection val) 
            { 
                PegRoundDirection = val;
            }
            
            public QuickFix.Fields.PegRoundDirection Get(QuickFix.Fields.PegRoundDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegRoundDirection val) 
            { 
                return IsSetPegRoundDirection();
            }
            
            public bool IsSetPegRoundDirection() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PegRoundDirection);
            }
            
            public QuickFix.Fields.PegScope PegScope
            { 
                get 
                {
                    var val = new QuickFix.Fields.PegScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegScope val) 
            { 
                PegScope = val;
            }
            
            public QuickFix.Fields.PegScope Get(QuickFix.Fields.PegScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegScope val) 
            { 
                return IsSetPegScope();
            }
            
            public bool IsSetPegScope() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PegScope);
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
            
            public QuickFix.Fields.DiscretionOffsetValue DiscretionOffsetValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.DiscretionOffsetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionOffsetValue val) 
            { 
                DiscretionOffsetValue = val;
            }
            
            public QuickFix.Fields.DiscretionOffsetValue Get(QuickFix.Fields.DiscretionOffsetValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionOffsetValue val) 
            { 
                return IsSetDiscretionOffsetValue();
            }
            
            public bool IsSetDiscretionOffsetValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DiscretionOffsetValue);
            }
            
            public QuickFix.Fields.DiscretionMoveType DiscretionMoveType
            { 
                get 
                {
                    var val = new QuickFix.Fields.DiscretionMoveType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionMoveType val) 
            { 
                DiscretionMoveType = val;
            }
            
            public QuickFix.Fields.DiscretionMoveType Get(QuickFix.Fields.DiscretionMoveType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionMoveType val) 
            { 
                return IsSetDiscretionMoveType();
            }
            
            public bool IsSetDiscretionMoveType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DiscretionMoveType);
            }
            
            public QuickFix.Fields.DiscretionOffsetType DiscretionOffsetType
            { 
                get 
                {
                    var val = new QuickFix.Fields.DiscretionOffsetType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionOffsetType val) 
            { 
                DiscretionOffsetType = val;
            }
            
            public QuickFix.Fields.DiscretionOffsetType Get(QuickFix.Fields.DiscretionOffsetType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionOffsetType val) 
            { 
                return IsSetDiscretionOffsetType();
            }
            
            public bool IsSetDiscretionOffsetType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DiscretionOffsetType);
            }
            
            public QuickFix.Fields.DiscretionLimitType DiscretionLimitType
            { 
                get 
                {
                    var val = new QuickFix.Fields.DiscretionLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionLimitType val) 
            { 
                DiscretionLimitType = val;
            }
            
            public QuickFix.Fields.DiscretionLimitType Get(QuickFix.Fields.DiscretionLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionLimitType val) 
            { 
                return IsSetDiscretionLimitType();
            }
            
            public bool IsSetDiscretionLimitType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DiscretionLimitType);
            }
            
            public QuickFix.Fields.DiscretionRoundDirection DiscretionRoundDirection
            { 
                get 
                {
                    var val = new QuickFix.Fields.DiscretionRoundDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionRoundDirection val) 
            { 
                DiscretionRoundDirection = val;
            }
            
            public QuickFix.Fields.DiscretionRoundDirection Get(QuickFix.Fields.DiscretionRoundDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionRoundDirection val) 
            { 
                return IsSetDiscretionRoundDirection();
            }
            
            public bool IsSetDiscretionRoundDirection() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DiscretionRoundDirection);
            }
            
            public QuickFix.Fields.DiscretionScope DiscretionScope
            { 
                get 
                {
                    var val = new QuickFix.Fields.DiscretionScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionScope val) 
            { 
                DiscretionScope = val;
            }
            
            public QuickFix.Fields.DiscretionScope Get(QuickFix.Fields.DiscretionScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionScope val) 
            { 
                return IsSetDiscretionScope();
            }
            
            public bool IsSetDiscretionScope() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DiscretionScope);
            }
            
            public QuickFix.Fields.TargetStrategy TargetStrategy
            { 
                get 
                {
                    var val = new QuickFix.Fields.TargetStrategy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TargetStrategy val) 
            { 
                TargetStrategy = val;
            }
            
            public QuickFix.Fields.TargetStrategy Get(QuickFix.Fields.TargetStrategy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TargetStrategy val) 
            { 
                return IsSetTargetStrategy();
            }
            
            public bool IsSetTargetStrategy() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TargetStrategy);
            }
            
            public QuickFix.Fields.TargetStrategyParameters TargetStrategyParameters
            { 
                get 
                {
                    var val = new QuickFix.Fields.TargetStrategyParameters();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TargetStrategyParameters val) 
            { 
                TargetStrategyParameters = val;
            }
            
            public QuickFix.Fields.TargetStrategyParameters Get(QuickFix.Fields.TargetStrategyParameters val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TargetStrategyParameters val) 
            { 
                return IsSetTargetStrategyParameters();
            }
            
            public bool IsSetTargetStrategyParameters() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TargetStrategyParameters);
            }
            
            public QuickFix.Fields.ParticipationRate ParticipationRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.ParticipationRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ParticipationRate val) 
            { 
                ParticipationRate = val;
            }
            
            public QuickFix.Fields.ParticipationRate Get(QuickFix.Fields.ParticipationRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ParticipationRate val) 
            { 
                return IsSetParticipationRate();
            }
            
            public bool IsSetParticipationRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ParticipationRate);
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
            
            public class NoSidesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Side, QuickFix.Fields.Tags.OrigClOrdID, QuickFix.Fields.Tags.ClOrdID, QuickFix.Fields.Tags.SecondaryClOrdID, QuickFix.Fields.Tags.ClOrdLinkID, QuickFix.Fields.Tags.OrigOrdModTime, QuickFix.Fields.Tags.NoPartyIDs, QuickFix.Fields.Tags.TradeOriginationDate, QuickFix.Fields.Tags.TradeDate, QuickFix.Fields.Tags.Account, QuickFix.Fields.Tags.AcctIDSource, QuickFix.Fields.Tags.AccountType, QuickFix.Fields.Tags.DayBookingInst, QuickFix.Fields.Tags.BookingUnit, QuickFix.Fields.Tags.PreallocMethod, QuickFix.Fields.Tags.AllocID, QuickFix.Fields.Tags.NoAllocs, QuickFix.Fields.Tags.QtyType, QuickFix.Fields.Tags.OrderQty, QuickFix.Fields.Tags.CashOrderQty, QuickFix.Fields.Tags.OrderPercent, QuickFix.Fields.Tags.RoundingDirection, QuickFix.Fields.Tags.RoundingModulus, QuickFix.Fields.Tags.Commission, QuickFix.Fields.Tags.CommType, QuickFix.Fields.Tags.CommCurrency, QuickFix.Fields.Tags.FundRenewWaiv, QuickFix.Fields.Tags.OrderCapacity, QuickFix.Fields.Tags.OrderRestrictions, QuickFix.Fields.Tags.CustOrderCapacity, QuickFix.Fields.Tags.ForexReq, QuickFix.Fields.Tags.SettlCurrency, QuickFix.Fields.Tags.BookingType, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, QuickFix.Fields.Tags.PositionEffect, QuickFix.Fields.Tags.CoveredOrUncovered, QuickFix.Fields.Tags.CashMargin, QuickFix.Fields.Tags.ClearingFeeIndicator, QuickFix.Fields.Tags.SolicitedFlag, QuickFix.Fields.Tags.SideComplianceID, 0};
            
                public NoSidesGroup() 
                  :base( QuickFix.Fields.Tags.NoSides, QuickFix.Fields.Tags.Side, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSidesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.TradeDate TradeDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradeDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradeDate val) 
                { 
                    TradeDate = val;
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
                    return IsSetField(QuickFix.Fields.Tags.TradeDate);
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
                
                public QuickFix.Fields.AcctIDSource AcctIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AcctIDSource val) 
                { 
                    AcctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return IsSetAcctIDSource();
                }
                
                public bool IsSetAcctIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AcctIDSource);
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
                
                public QuickFix.Fields.AllocID AllocID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocID val) 
                { 
                    AllocID = val;
                }
                
                public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocID val) 
                { 
                    return IsSetAllocID();
                }
                
                public bool IsSetAllocID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocID);
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
                
                public QuickFix.Fields.QtyType QtyType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QtyType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QtyType val) 
                { 
                    QtyType = val;
                }
                
                public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QtyType val) 
                { 
                    return IsSetQtyType();
                }
                
                public bool IsSetQtyType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QtyType);
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
                
                public QuickFix.Fields.BookingType BookingType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BookingType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BookingType val) 
                { 
                    BookingType = val;
                }
                
                public QuickFix.Fields.BookingType Get(QuickFix.Fields.BookingType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BookingType val) 
                { 
                    return IsSetBookingType();
                }
                
                public bool IsSetBookingType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BookingType);
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
                
                public QuickFix.Fields.SideComplianceID SideComplianceID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SideComplianceID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SideComplianceID val) 
                { 
                    SideComplianceID = val;
                }
                
                public QuickFix.Fields.SideComplianceID Get(QuickFix.Fields.SideComplianceID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SideComplianceID val) 
                { 
                    return IsSetSideComplianceID();
                }
                
                public bool IsSetSideComplianceID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SideComplianceID);
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
                public class NoAllocsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.AllocAccount, QuickFix.Fields.Tags.AllocAcctIDSource, QuickFix.Fields.Tags.AllocSettlCurrency, QuickFix.Fields.Tags.IndividualAllocID, QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.AllocQty, 0};
                
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
                    
                    public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.AllocAcctIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        AllocAcctIDSource = val;
                    }
                    
                    public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        return IsSetAllocAcctIDSource();
                    }
                    
                    public bool IsSetAllocAcctIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.AllocAcctIDSource);
                    }
                    
                    public QuickFix.Fields.AllocSettlCurrency AllocSettlCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.AllocSettlCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        AllocSettlCurrency = val;
                    }
                    
                    public QuickFix.Fields.AllocSettlCurrency Get(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        return IsSetAllocSettlCurrency();
                    }
                    
                    public bool IsSetAllocSettlCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.AllocSettlCurrency);
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
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartyID, QuickFix.Fields.Tags.NestedPartyIDSource, QuickFix.Fields.Tags.NestedPartyRole, QuickFix.Fields.Tags.NoNestedPartySubIDs, 0};
                    
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
                        
                        public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoNestedPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            NoNestedPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            return IsSetNoNestedPartySubIDs();
                        }
                        
                        public bool IsSetNoNestedPartySubIDs() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoNestedPartySubIDs);
                        }
                        
                                            public class NoNestedPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartySubID, QuickFix.Fields.Tags.NestedPartySubIDType, 0};
                        
                            public NoNestedPartySubIDsGroup() 
                              :base( QuickFix.Fields.Tags.NoNestedPartySubIDs, QuickFix.Fields.Tags.NestedPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoNestedPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
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
                            
                            public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.NestedPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                NestedPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                return IsSetNestedPartySubIDType();
                            }
                            
                            public bool IsSetNestedPartySubIDType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.NestedPartySubIDType);
                            }
                            
                        
                        }
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
                public static int[] fieldOrder = {QuickFix.Fields.Tags.EventType, QuickFix.Fields.Tags.EventDate, QuickFix.Fields.Tags.EventPx, QuickFix.Fields.Tags.EventText, 0};
            
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
                
            
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingSymbol, QuickFix.Fields.Tags.UnderlyingSymbolSfx, QuickFix.Fields.Tags.UnderlyingSecurityID, QuickFix.Fields.Tags.UnderlyingSecurityIDSource, QuickFix.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingProduct, QuickFix.Fields.Tags.UnderlyingCFICode, QuickFix.Fields.Tags.UnderlyingSecurityType, QuickFix.Fields.Tags.UnderlyingSecuritySubType, QuickFix.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.Fields.Tags.UnderlyingMaturityDate, QuickFix.Fields.Tags.UnderlyingPutOrCall, QuickFix.Fields.Tags.UnderlyingCouponPaymentDate, QuickFix.Fields.Tags.UnderlyingIssueDate, QuickFix.Fields.Tags.UnderlyingRepoCollateralSecurityType, QuickFix.Fields.Tags.UnderlyingRepurchaseTerm, QuickFix.Fields.Tags.UnderlyingRepurchaseRate, QuickFix.Fields.Tags.UnderlyingFactor, QuickFix.Fields.Tags.UnderlyingCreditRating, QuickFix.Fields.Tags.UnderlyingInstrRegistry, QuickFix.Fields.Tags.UnderlyingCountryOfIssue, QuickFix.Fields.Tags.UnderlyingStateOrProvinceOfIssue, QuickFix.Fields.Tags.UnderlyingLocaleOfIssue, QuickFix.Fields.Tags.UnderlyingRedemptionDate, QuickFix.Fields.Tags.UnderlyingStrikePrice, QuickFix.Fields.Tags.UnderlyingStrikeCurrency, QuickFix.Fields.Tags.UnderlyingOptAttribute, QuickFix.Fields.Tags.UnderlyingContractMultiplier, QuickFix.Fields.Tags.UnderlyingCouponRate, QuickFix.Fields.Tags.UnderlyingSecurityExchange, QuickFix.Fields.Tags.UnderlyingIssuer, QuickFix.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.Fields.Tags.UnderlyingSecurityDesc, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.Fields.Tags.UnderlyingCPProgram, QuickFix.Fields.Tags.UnderlyingCPRegType, QuickFix.Fields.Tags.UnderlyingCurrency, QuickFix.Fields.Tags.UnderlyingQty, QuickFix.Fields.Tags.UnderlyingPx, QuickFix.Fields.Tags.UnderlyingDirtyPrice, QuickFix.Fields.Tags.UnderlyingEndPrice, QuickFix.Fields.Tags.UnderlyingStartValue, QuickFix.Fields.Tags.UnderlyingCurrentValue, QuickFix.Fields.Tags.UnderlyingEndValue, QuickFix.Fields.Tags.NoUnderlyingStips, 0};
            
                public NoUnderlyingsGroup() 
                  :base( QuickFix.Fields.Tags.NoUnderlyings, QuickFix.Fields.Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSymbol, QuickFix.Fields.Tags.LegSymbolSfx, QuickFix.Fields.Tags.LegSecurityID, QuickFix.Fields.Tags.LegSecurityIDSource, QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegProduct, QuickFix.Fields.Tags.LegCFICode, QuickFix.Fields.Tags.LegSecurityType, QuickFix.Fields.Tags.LegSecuritySubType, QuickFix.Fields.Tags.LegMaturityMonthYear, QuickFix.Fields.Tags.LegMaturityDate, QuickFix.Fields.Tags.LegCouponPaymentDate, QuickFix.Fields.Tags.LegIssueDate, QuickFix.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.Fields.Tags.LegRepurchaseTerm, QuickFix.Fields.Tags.LegRepurchaseRate, QuickFix.Fields.Tags.LegFactor, QuickFix.Fields.Tags.LegCreditRating, QuickFix.Fields.Tags.LegInstrRegistry, QuickFix.Fields.Tags.LegCountryOfIssue, QuickFix.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.Fields.Tags.LegLocaleOfIssue, QuickFix.Fields.Tags.LegRedemptionDate, QuickFix.Fields.Tags.LegStrikePrice, QuickFix.Fields.Tags.LegStrikeCurrency, QuickFix.Fields.Tags.LegOptAttribute, QuickFix.Fields.Tags.LegContractMultiplier, QuickFix.Fields.Tags.LegCouponRate, QuickFix.Fields.Tags.LegSecurityExchange, QuickFix.Fields.Tags.LegIssuer, QuickFix.Fields.Tags.EncodedLegIssuerLen, QuickFix.Fields.Tags.EncodedLegIssuer, QuickFix.Fields.Tags.LegSecurityDesc, QuickFix.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.Fields.Tags.EncodedLegSecurityDesc, QuickFix.Fields.Tags.LegRatioQty, QuickFix.Fields.Tags.LegSide, QuickFix.Fields.Tags.LegCurrency, QuickFix.Fields.Tags.LegPool, QuickFix.Fields.Tags.LegDatedDate, QuickFix.Fields.Tags.LegContractSettlMonth, QuickFix.Fields.Tags.LegInterestAccrualDate, 0};
            
                public NoLegsGroup() 
                  :base( QuickFix.Fields.Tags.NoLegs, QuickFix.Fields.Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbol val) 
                { 
                    LegSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSymbol);
                }
                
                public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    LegSymbolSfx = val;
                }
                
                public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSymbolSfx);
                }
                
                public QuickFix.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityID val) 
                { 
                    LegSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityID);
                }
                
                public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    LegSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityIDSource);
                }
                
                public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    NoLegSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoLegSecurityAltID);
                }
                
                public QuickFix.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegProduct val) 
                { 
                    LegProduct = val;
                }
                
                public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegProduct);
                }
                
                public QuickFix.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCFICode val) 
                { 
                    LegCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCFICode);
                }
                
                public QuickFix.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityType val) 
                { 
                    LegSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityType);
                }
                
                public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    LegSecuritySubType = val;
                }
                
                public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecuritySubType);
                }
                
                public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    LegMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegMaturityMonthYear);
                }
                
                public QuickFix.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityDate val) 
                { 
                    LegMaturityDate = val;
                }
                
                public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegMaturityDate);
                }
                
                public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    LegCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCouponPaymentDate);
                }
                
                public QuickFix.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssueDate val) 
                { 
                    LegIssueDate = val;
                }
                
                public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegIssueDate);
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRepoCollateralSecurityType);
                }
                
                public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    LegRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRepurchaseTerm);
                }
                
                public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    LegRepurchaseRate = val;
                }
                
                public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRepurchaseRate);
                }
                
                public QuickFix.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegFactor val) 
                { 
                    LegFactor = val;
                }
                
                public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegFactor);
                }
                
                public QuickFix.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCreditRating val) 
                { 
                    LegCreditRating = val;
                }
                
                public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCreditRating);
                }
                
                public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    LegInstrRegistry = val;
                }
                
                public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegInstrRegistry);
                }
                
                public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    LegCountryOfIssue = val;
                }
                
                public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCountryOfIssue);
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegStateOrProvinceOfIssue);
                }
                
                public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    LegLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegLocaleOfIssue);
                }
                
                public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    LegRedemptionDate = val;
                }
                
                public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRedemptionDate);
                }
                
                public QuickFix.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    LegStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegStrikePrice);
                }
                
                public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    LegStrikeCurrency = val;
                }
                
                public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegStrikeCurrency);
                }
                
                public QuickFix.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptAttribute val) 
                { 
                    LegOptAttribute = val;
                }
                
                public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegOptAttribute);
                }
                
                public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    LegContractMultiplier = val;
                }
                
                public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegContractMultiplier);
                }
                
                public QuickFix.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponRate val) 
                { 
                    LegCouponRate = val;
                }
                
                public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCouponRate);
                }
                
                public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    LegSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityExchange);
                }
                
                public QuickFix.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssuer val) 
                { 
                    LegIssuer = val;
                }
                
                public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegIssuer);
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    EncodedLegIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegIssuerLen);
                }
                
                public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    EncodedLegIssuer = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegIssuer);
                }
                
                public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    LegSecurityDesc = val;
                }
                
                public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityDesc);
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegSecurityDescLen);
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegSecurityDesc);
                }
                
                public QuickFix.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioQty val) 
                { 
                    LegRatioQty = val;
                }
                
                public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRatioQty);
                }
                
                public QuickFix.Fields.LegSide LegSide
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSide val) 
                { 
                    LegSide = val;
                }
                
                public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSide);
                }
                
                public QuickFix.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCurrency val) 
                { 
                    LegCurrency = val;
                }
                
                public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCurrency);
                }
                
                public QuickFix.Fields.LegPool LegPool
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPool val) 
                { 
                    LegPool = val;
                }
                
                public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegPool);
                }
                
                public QuickFix.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegDatedDate val) 
                { 
                    LegDatedDate = val;
                }
                
                public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegDatedDate);
                }
                
                public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    LegContractSettlMonth = val;
                }
                
                public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegContractSettlMonth);
                }
                
                public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    LegInterestAccrualDate = val;
                }
                
                public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegInterestAccrualDate);
                }
                
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSecurityAltID, QuickFix.Fields.Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        LegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityAltID);
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityAltIDSource);
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
            public class NoStipulationsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.StipulationType, QuickFix.Fields.Tags.StipulationValue, 0};
            
                public NoStipulationsGroup() 
                  :base( QuickFix.Fields.Tags.NoStipulations, QuickFix.Fields.Tags.StipulationType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStipulationsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.StipulationType StipulationType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StipulationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StipulationType val) 
                { 
                    StipulationType = val;
                }
                
                public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StipulationType val) 
                { 
                    return IsSetStipulationType();
                }
                
                public bool IsSetStipulationType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StipulationType);
                }
                
                public QuickFix.Fields.StipulationValue StipulationValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StipulationValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StipulationValue val) 
                { 
                    StipulationValue = val;
                }
                
                public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StipulationValue val) 
                { 
                    return IsSetStipulationValue();
                }
                
                public bool IsSetStipulationValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StipulationValue);
                }
                
            
            }
    }
}

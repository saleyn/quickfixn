// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class MarketDataSnapshotFullRefresh : Message
    {
            public const string MsgType = "W";

            public MarketDataSnapshotFullRefresh() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("W"));
            }

            public MarketDataSnapshotFullRefresh(
                    QuickFix.Fields.Symbol aSymbol
                ) : this()
            {
                this.Symbol = aSymbol;
            }

            public QuickFix.Fields.MDReqID MDReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MDReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MDReqID val) 
            { 
                MDReqID = val;
            }
            
            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MDReqID val) 
            { 
                return IsSetMDReqID();
            }
            
            public bool IsSetMDReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MDReqID);
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
            
            public QuickFix.Fields.FinancialStatus FinancialStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.FinancialStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FinancialStatus val) 
            { 
                FinancialStatus = val;
            }
            
            public QuickFix.Fields.FinancialStatus Get(QuickFix.Fields.FinancialStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FinancialStatus val) 
            { 
                return IsSetFinancialStatus();
            }
            
            public bool IsSetFinancialStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.FinancialStatus);
            }
            
            public QuickFix.Fields.CorporateAction CorporateAction
            { 
                get 
                {
                    var val = new QuickFix.Fields.CorporateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CorporateAction val) 
            { 
                CorporateAction = val;
            }
            
            public QuickFix.Fields.CorporateAction Get(QuickFix.Fields.CorporateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CorporateAction val) 
            { 
                return IsSetCorporateAction();
            }
            
            public bool IsSetCorporateAction() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CorporateAction);
            }
            
            public QuickFix.Fields.TotalVolumeTraded TotalVolumeTraded
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotalVolumeTraded();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                TotalVolumeTraded = val;
            }
            
            public QuickFix.Fields.TotalVolumeTraded Get(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                return IsSetTotalVolumeTraded();
            }
            
            public bool IsSetTotalVolumeTraded() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotalVolumeTraded);
            }
            
            public QuickFix.Fields.TotalVolumeTradedDate TotalVolumeTradedDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotalVolumeTradedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalVolumeTradedDate val) 
            { 
                TotalVolumeTradedDate = val;
            }
            
            public QuickFix.Fields.TotalVolumeTradedDate Get(QuickFix.Fields.TotalVolumeTradedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalVolumeTradedDate val) 
            { 
                return IsSetTotalVolumeTradedDate();
            }
            
            public bool IsSetTotalVolumeTradedDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotalVolumeTradedDate);
            }
            
            public QuickFix.Fields.TotalVolumeTradedTime TotalVolumeTradedTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotalVolumeTradedTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalVolumeTradedTime val) 
            { 
                TotalVolumeTradedTime = val;
            }
            
            public QuickFix.Fields.TotalVolumeTradedTime Get(QuickFix.Fields.TotalVolumeTradedTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalVolumeTradedTime val) 
            { 
                return IsSetTotalVolumeTradedTime();
            }
            
            public bool IsSetTotalVolumeTradedTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotalVolumeTradedTime);
            }
            
            public QuickFix.Fields.NetChgPrevDay NetChgPrevDay
            { 
                get 
                {
                    var val = new QuickFix.Fields.NetChgPrevDay();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetChgPrevDay val) 
            { 
                NetChgPrevDay = val;
            }
            
            public QuickFix.Fields.NetChgPrevDay Get(QuickFix.Fields.NetChgPrevDay val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetChgPrevDay val) 
            { 
                return IsSetNetChgPrevDay();
            }
            
            public bool IsSetNetChgPrevDay() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NetChgPrevDay);
            }
            
            public QuickFix.Fields.NoMDEntries NoMDEntries
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoMDEntries();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMDEntries val) 
            { 
                NoMDEntries = val;
            }
            
            public QuickFix.Fields.NoMDEntries Get(QuickFix.Fields.NoMDEntries val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMDEntries val) 
            { 
                return IsSetNoMDEntries();
            }
            
            public bool IsSetNoMDEntries() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoMDEntries);
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
            public class NoMDEntriesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.MDEntryType, QuickFix.Fields.Tags.MDEntryPx, QuickFix.Fields.Tags.Currency, QuickFix.Fields.Tags.MDEntrySize, QuickFix.Fields.Tags.MDEntryDate, QuickFix.Fields.Tags.MDEntryTime, QuickFix.Fields.Tags.TickDirection, QuickFix.Fields.Tags.MDMkt, QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.QuoteCondition, QuickFix.Fields.Tags.TradeCondition, QuickFix.Fields.Tags.MDEntryOriginator, QuickFix.Fields.Tags.LocationID, QuickFix.Fields.Tags.DeskID, QuickFix.Fields.Tags.OpenCloseSettleFlag, QuickFix.Fields.Tags.TimeInForce, QuickFix.Fields.Tags.ExpireDate, QuickFix.Fields.Tags.ExpireTime, QuickFix.Fields.Tags.MinQty, QuickFix.Fields.Tags.ExecInst, QuickFix.Fields.Tags.SellerDays, QuickFix.Fields.Tags.OrderID, QuickFix.Fields.Tags.QuoteEntryID, QuickFix.Fields.Tags.MDEntryBuyer, QuickFix.Fields.Tags.MDEntrySeller, QuickFix.Fields.Tags.NumberOfOrders, QuickFix.Fields.Tags.MDEntryPositionNo, QuickFix.Fields.Tags.Scope, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, 0};
            
                public NoMDEntriesGroup() 
                  :base( QuickFix.Fields.Tags.NoMDEntries, QuickFix.Fields.Tags.MDEntryType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMDEntriesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.MDEntryType MDEntryType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryType val) 
                { 
                    MDEntryType = val;
                }
                
                public QuickFix.Fields.MDEntryType Get(QuickFix.Fields.MDEntryType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryType val) 
                { 
                    return IsSetMDEntryType();
                }
                
                public bool IsSetMDEntryType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryType);
                }
                
                public QuickFix.Fields.MDEntryPx MDEntryPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryPx val) 
                { 
                    MDEntryPx = val;
                }
                
                public QuickFix.Fields.MDEntryPx Get(QuickFix.Fields.MDEntryPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryPx val) 
                { 
                    return IsSetMDEntryPx();
                }
                
                public bool IsSetMDEntryPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryPx);
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
                
                public QuickFix.Fields.MDEntrySize MDEntrySize
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntrySize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntrySize val) 
                { 
                    MDEntrySize = val;
                }
                
                public QuickFix.Fields.MDEntrySize Get(QuickFix.Fields.MDEntrySize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntrySize val) 
                { 
                    return IsSetMDEntrySize();
                }
                
                public bool IsSetMDEntrySize() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntrySize);
                }
                
                public QuickFix.Fields.MDEntryDate MDEntryDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryDate val) 
                { 
                    MDEntryDate = val;
                }
                
                public QuickFix.Fields.MDEntryDate Get(QuickFix.Fields.MDEntryDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryDate val) 
                { 
                    return IsSetMDEntryDate();
                }
                
                public bool IsSetMDEntryDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryDate);
                }
                
                public QuickFix.Fields.MDEntryTime MDEntryTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryTime val) 
                { 
                    MDEntryTime = val;
                }
                
                public QuickFix.Fields.MDEntryTime Get(QuickFix.Fields.MDEntryTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryTime val) 
                { 
                    return IsSetMDEntryTime();
                }
                
                public bool IsSetMDEntryTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryTime);
                }
                
                public QuickFix.Fields.TickDirection TickDirection
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TickDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickDirection val) 
                { 
                    TickDirection = val;
                }
                
                public QuickFix.Fields.TickDirection Get(QuickFix.Fields.TickDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickDirection val) 
                { 
                    return IsSetTickDirection();
                }
                
                public bool IsSetTickDirection() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TickDirection);
                }
                
                public QuickFix.Fields.MDMkt MDMkt
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDMkt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDMkt val) 
                { 
                    MDMkt = val;
                }
                
                public QuickFix.Fields.MDMkt Get(QuickFix.Fields.MDMkt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDMkt val) 
                { 
                    return IsSetMDMkt();
                }
                
                public bool IsSetMDMkt() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDMkt);
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
                
                public QuickFix.Fields.QuoteCondition QuoteCondition
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QuoteCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteCondition val) 
                { 
                    QuoteCondition = val;
                }
                
                public QuickFix.Fields.QuoteCondition Get(QuickFix.Fields.QuoteCondition val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteCondition val) 
                { 
                    return IsSetQuoteCondition();
                }
                
                public bool IsSetQuoteCondition() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QuoteCondition);
                }
                
                public QuickFix.Fields.TradeCondition TradeCondition
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradeCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradeCondition val) 
                { 
                    TradeCondition = val;
                }
                
                public QuickFix.Fields.TradeCondition Get(QuickFix.Fields.TradeCondition val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradeCondition val) 
                { 
                    return IsSetTradeCondition();
                }
                
                public bool IsSetTradeCondition() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradeCondition);
                }
                
                public QuickFix.Fields.MDEntryOriginator MDEntryOriginator
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryOriginator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    MDEntryOriginator = val;
                }
                
                public QuickFix.Fields.MDEntryOriginator Get(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    return IsSetMDEntryOriginator();
                }
                
                public bool IsSetMDEntryOriginator() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryOriginator);
                }
                
                public QuickFix.Fields.LocationID LocationID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocationID val) 
                { 
                    LocationID = val;
                }
                
                public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocationID val) 
                { 
                    return IsSetLocationID();
                }
                
                public bool IsSetLocationID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LocationID);
                }
                
                public QuickFix.Fields.DeskID DeskID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DeskID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskID val) 
                { 
                    DeskID = val;
                }
                
                public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskID val) 
                { 
                    return IsSetDeskID();
                }
                
                public bool IsSetDeskID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DeskID);
                }
                
                public QuickFix.Fields.OpenCloseSettleFlag OpenCloseSettleFlag
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OpenCloseSettleFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    OpenCloseSettleFlag = val;
                }
                
                public QuickFix.Fields.OpenCloseSettleFlag Get(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    return IsSetOpenCloseSettleFlag();
                }
                
                public bool IsSetOpenCloseSettleFlag() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OpenCloseSettleFlag);
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
                
                public QuickFix.Fields.SellerDays SellerDays
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SellerDays();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SellerDays val) 
                { 
                    SellerDays = val;
                }
                
                public QuickFix.Fields.SellerDays Get(QuickFix.Fields.SellerDays val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SellerDays val) 
                { 
                    return IsSetSellerDays();
                }
                
                public bool IsSetSellerDays() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SellerDays);
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
                
                public QuickFix.Fields.QuoteEntryID QuoteEntryID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QuoteEntryID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteEntryID val) 
                { 
                    QuoteEntryID = val;
                }
                
                public QuickFix.Fields.QuoteEntryID Get(QuickFix.Fields.QuoteEntryID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteEntryID val) 
                { 
                    return IsSetQuoteEntryID();
                }
                
                public bool IsSetQuoteEntryID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QuoteEntryID);
                }
                
                public QuickFix.Fields.MDEntryBuyer MDEntryBuyer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryBuyer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    MDEntryBuyer = val;
                }
                
                public QuickFix.Fields.MDEntryBuyer Get(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    return IsSetMDEntryBuyer();
                }
                
                public bool IsSetMDEntryBuyer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryBuyer);
                }
                
                public QuickFix.Fields.MDEntrySeller MDEntrySeller
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntrySeller();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntrySeller val) 
                { 
                    MDEntrySeller = val;
                }
                
                public QuickFix.Fields.MDEntrySeller Get(QuickFix.Fields.MDEntrySeller val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntrySeller val) 
                { 
                    return IsSetMDEntrySeller();
                }
                
                public bool IsSetMDEntrySeller() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntrySeller);
                }
                
                public QuickFix.Fields.NumberOfOrders NumberOfOrders
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NumberOfOrders();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NumberOfOrders val) 
                { 
                    NumberOfOrders = val;
                }
                
                public QuickFix.Fields.NumberOfOrders Get(QuickFix.Fields.NumberOfOrders val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NumberOfOrders val) 
                { 
                    return IsSetNumberOfOrders();
                }
                
                public bool IsSetNumberOfOrders() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NumberOfOrders);
                }
                
                public QuickFix.Fields.MDEntryPositionNo MDEntryPositionNo
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MDEntryPositionNo();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    MDEntryPositionNo = val;
                }
                
                public QuickFix.Fields.MDEntryPositionNo Get(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    return IsSetMDEntryPositionNo();
                }
                
                public bool IsSetMDEntryPositionNo() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MDEntryPositionNo);
                }
                
                public QuickFix.Fields.Scope Scope
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Scope();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Scope val) 
                { 
                    Scope = val;
                }
                
                public QuickFix.Fields.Scope Get(QuickFix.Fields.Scope val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Scope val) 
                { 
                    return IsSetScope();
                }
                
                public bool IsSetScope() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Scope);
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
                
            
            }
    }
}

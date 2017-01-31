// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class DerivativeSecurityList : Message
    {
            public const string MsgType = "AA";

            public DerivativeSecurityList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AA"));
            }

            public DerivativeSecurityList(
                    QuickFix.Fields.SecurityResponseID aSecurityResponseID
                ) : this()
            {
                this.SecurityResponseID = aSecurityResponseID;
            }

            public QuickFix.Fields.SecurityReqID SecurityReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityReqID val) 
            { 
                SecurityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityReqID);
            }
            
            public QuickFix.Fields.SecurityResponseID SecurityResponseID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityResponseID val) 
            { 
                SecurityResponseID = val;
            }
            
            public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityResponseID val) 
            { 
                return IsSetSecurityResponseID();
            }
            
            public bool IsSetSecurityResponseID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityResponseID);
            }
            
            public QuickFix.Fields.SecurityRequestResult SecurityRequestResult
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityRequestResult val) 
            { 
                SecurityRequestResult = val;
            }
            
            public QuickFix.Fields.SecurityRequestResult Get(QuickFix.Fields.SecurityRequestResult val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityRequestResult val) 
            { 
                return IsSetSecurityRequestResult();
            }
            
            public bool IsSetSecurityRequestResult() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityRequestResult);
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
            
            public QuickFix.Fields.TotNoRelatedSym TotNoRelatedSym
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                TotNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym Get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return IsSetTotNoRelatedSym();
            }
            
            public bool IsSetTotNoRelatedSym() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotNoRelatedSym);
            }
            
            public QuickFix.Fields.LastFragment LastFragment
            { 
                get 
                {
                    var val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                LastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LastFragment);
            }
            
            public QuickFix.Fields.NoRelatedSym NoRelatedSym
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRelatedSym val) 
            { 
                NoRelatedSym = val;
            }
            
            public QuickFix.Fields.NoRelatedSym Get(QuickFix.Fields.NoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRelatedSym val) 
            { 
                return IsSetNoRelatedSym();
            }
            
            public bool IsSetNoRelatedSym() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoRelatedSym);
            }
            
            public QuickFix.Fields.DerivativeSymbol DerivativeSymbol
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSymbol val) 
            { 
                DerivativeSymbol = val;
            }
            
            public QuickFix.Fields.DerivativeSymbol Get(QuickFix.Fields.DerivativeSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSymbol val) 
            { 
                return IsSetDerivativeSymbol();
            }
            
            public bool IsSetDerivativeSymbol() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSymbol);
            }
            
            public QuickFix.Fields.DerivativeSymbolSfx DerivativeSymbolSfx
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                DerivativeSymbolSfx = val;
            }
            
            public QuickFix.Fields.DerivativeSymbolSfx Get(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                return IsSetDerivativeSymbolSfx();
            }
            
            public bool IsSetDerivativeSymbolSfx() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSymbolSfx);
            }
            
            public QuickFix.Fields.DerivativeSecurityID DerivativeSecurityID
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                DerivativeSecurityID = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityID Get(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                return IsSetDerivativeSecurityID();
            }
            
            public bool IsSetDerivativeSecurityID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityID);
            }
            
            public QuickFix.Fields.DerivativeSecurityIDSource DerivativeSecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                DerivativeSecurityIDSource = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityIDSource Get(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                return IsSetDerivativeSecurityIDSource();
            }
            
            public bool IsSetDerivativeSecurityIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityIDSource);
            }
            
            public QuickFix.Fields.NoDerivativeSecurityAltID NoDerivativeSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoDerivativeSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                NoDerivativeSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoDerivativeSecurityAltID Get(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                return IsSetNoDerivativeSecurityAltID();
            }
            
            public bool IsSetNoDerivativeSecurityAltID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoDerivativeSecurityAltID);
            }
            
            public QuickFix.Fields.DerivativeProduct DerivativeProduct
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeProduct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeProduct val) 
            { 
                DerivativeProduct = val;
            }
            
            public QuickFix.Fields.DerivativeProduct Get(QuickFix.Fields.DerivativeProduct val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeProduct val) 
            { 
                return IsSetDerivativeProduct();
            }
            
            public bool IsSetDerivativeProduct() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeProduct);
            }
            
            public QuickFix.Fields.DerivativeProductComplex DerivativeProductComplex
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                DerivativeProductComplex = val;
            }
            
            public QuickFix.Fields.DerivativeProductComplex Get(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                return IsSetDerivativeProductComplex();
            }
            
            public bool IsSetDerivativeProductComplex() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeProductComplex);
            }
            
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator DerivFlexProductEligibilityIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivFlexProductEligibilityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                DerivFlexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator Get(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                return IsSetDerivFlexProductEligibilityIndicator();
            }
            
            public bool IsSetDerivFlexProductEligibilityIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivFlexProductEligibilityIndicator);
            }
            
            public QuickFix.Fields.DerivativeSecurityGroup DerivativeSecurityGroup
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                DerivativeSecurityGroup = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityGroup Get(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                return IsSetDerivativeSecurityGroup();
            }
            
            public bool IsSetDerivativeSecurityGroup() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityGroup);
            }
            
            public QuickFix.Fields.DerivativeCFICode DerivativeCFICode
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeCFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeCFICode val) 
            { 
                DerivativeCFICode = val;
            }
            
            public QuickFix.Fields.DerivativeCFICode Get(QuickFix.Fields.DerivativeCFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeCFICode val) 
            { 
                return IsSetDerivativeCFICode();
            }
            
            public bool IsSetDerivativeCFICode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeCFICode);
            }
            
            public QuickFix.Fields.DerivativeSecurityType DerivativeSecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                DerivativeSecurityType = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityType Get(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                return IsSetDerivativeSecurityType();
            }
            
            public bool IsSetDerivativeSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityType);
            }
            
            public QuickFix.Fields.DerivativeSecuritySubType DerivativeSecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                DerivativeSecuritySubType = val;
            }
            
            public QuickFix.Fields.DerivativeSecuritySubType Get(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                return IsSetDerivativeSecuritySubType();
            }
            
            public bool IsSetDerivativeSecuritySubType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecuritySubType);
            }
            
            public QuickFix.Fields.DerivativeMaturityMonthYear DerivativeMaturityMonthYear
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeMaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                DerivativeMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityMonthYear Get(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                return IsSetDerivativeMaturityMonthYear();
            }
            
            public bool IsSetDerivativeMaturityMonthYear() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeMaturityMonthYear);
            }
            
            public QuickFix.Fields.DerivativeMaturityDate DerivativeMaturityDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeMaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                DerivativeMaturityDate = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityDate Get(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                return IsSetDerivativeMaturityDate();
            }
            
            public bool IsSetDerivativeMaturityDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeMaturityDate);
            }
            
            public QuickFix.Fields.DerivativeMaturityTime DerivativeMaturityTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeMaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                DerivativeMaturityTime = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityTime Get(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                return IsSetDerivativeMaturityTime();
            }
            
            public bool IsSetDerivativeMaturityTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeMaturityTime);
            }
            
            public QuickFix.Fields.DerivativeSettleOnOpenFlag DerivativeSettleOnOpenFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                DerivativeSettleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.DerivativeSettleOnOpenFlag Get(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                return IsSetDerivativeSettleOnOpenFlag();
            }
            
            public bool IsSetDerivativeSettleOnOpenFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSettleOnOpenFlag);
            }
            
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod DerivativeInstrmtAssignmentMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeInstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                DerivativeInstrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod Get(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                return IsSetDerivativeInstrmtAssignmentMethod();
            }
            
            public bool IsSetDerivativeInstrmtAssignmentMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeInstrmtAssignmentMethod);
            }
            
            public QuickFix.Fields.DerivativeSecurityStatus DerivativeSecurityStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                DerivativeSecurityStatus = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityStatus Get(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                return IsSetDerivativeSecurityStatus();
            }
            
            public bool IsSetDerivativeSecurityStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityStatus);
            }
            
            public QuickFix.Fields.DerivativeIssueDate DerivativeIssueDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeIssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                DerivativeIssueDate = val;
            }
            
            public QuickFix.Fields.DerivativeIssueDate Get(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                return IsSetDerivativeIssueDate();
            }
            
            public bool IsSetDerivativeIssueDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeIssueDate);
            }
            
            public QuickFix.Fields.DerivativeInstrRegistry DerivativeInstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeInstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                DerivativeInstrRegistry = val;
            }
            
            public QuickFix.Fields.DerivativeInstrRegistry Get(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                return IsSetDerivativeInstrRegistry();
            }
            
            public bool IsSetDerivativeInstrRegistry() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeInstrRegistry);
            }
            
            public QuickFix.Fields.DerivativeCountryOfIssue DerivativeCountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeCountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                DerivativeCountryOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeCountryOfIssue Get(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                return IsSetDerivativeCountryOfIssue();
            }
            
            public bool IsSetDerivativeCountryOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeCountryOfIssue);
            }
            
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue DerivativeStateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeStateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                DerivativeStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue Get(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                return IsSetDerivativeStateOrProvinceOfIssue();
            }
            
            public bool IsSetDerivativeStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeStateOrProvinceOfIssue);
            }
            
            public QuickFix.Fields.DerivativeStrikePrice DerivativeStrikePrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeStrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                DerivativeStrikePrice = val;
            }
            
            public QuickFix.Fields.DerivativeStrikePrice Get(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                return IsSetDerivativeStrikePrice();
            }
            
            public bool IsSetDerivativeStrikePrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeStrikePrice);
            }
            
            public QuickFix.Fields.DerivativeLocaleOfIssue DerivativeLocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeLocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                DerivativeLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeLocaleOfIssue Get(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                return IsSetDerivativeLocaleOfIssue();
            }
            
            public bool IsSetDerivativeLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeLocaleOfIssue);
            }
            
            public QuickFix.Fields.DerivativeStrikeCurrency DerivativeStrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeStrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                DerivativeStrikeCurrency = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeCurrency Get(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                return IsSetDerivativeStrikeCurrency();
            }
            
            public bool IsSetDerivativeStrikeCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeStrikeCurrency);
            }
            
            public QuickFix.Fields.DerivativeStrikeMultiplier DerivativeStrikeMultiplier
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeStrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                DerivativeStrikeMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeMultiplier Get(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                return IsSetDerivativeStrikeMultiplier();
            }
            
            public bool IsSetDerivativeStrikeMultiplier() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeStrikeMultiplier);
            }
            
            public QuickFix.Fields.DerivativeStrikeValue DerivativeStrikeValue
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeStrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                DerivativeStrikeValue = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeValue Get(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                return IsSetDerivativeStrikeValue();
            }
            
            public bool IsSetDerivativeStrikeValue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeStrikeValue);
            }
            
            public QuickFix.Fields.DerivativeOptAttribute DerivativeOptAttribute
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeOptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                DerivativeOptAttribute = val;
            }
            
            public QuickFix.Fields.DerivativeOptAttribute Get(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                return IsSetDerivativeOptAttribute();
            }
            
            public bool IsSetDerivativeOptAttribute() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeOptAttribute);
            }
            
            public QuickFix.Fields.DerivativeContractMultiplier DerivativeContractMultiplier
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                DerivativeContractMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeContractMultiplier Get(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                return IsSetDerivativeContractMultiplier();
            }
            
            public bool IsSetDerivativeContractMultiplier() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeContractMultiplier);
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrement DerivativeMinPriceIncrement
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeMinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                DerivativeMinPriceIncrement = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrement Get(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                return IsSetDerivativeMinPriceIncrement();
            }
            
            public bool IsSetDerivativeMinPriceIncrement() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeMinPriceIncrement);
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount DerivativeMinPriceIncrementAmount
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeMinPriceIncrementAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                DerivativeMinPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount Get(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                return IsSetDerivativeMinPriceIncrementAmount();
            }
            
            public bool IsSetDerivativeMinPriceIncrementAmount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeMinPriceIncrementAmount);
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasure DerivativeUnitOfMeasure
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                DerivativeUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasure Get(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                return IsSetDerivativeUnitOfMeasure();
            }
            
            public bool IsSetDerivativeUnitOfMeasure() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeUnitOfMeasure);
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasureQty DerivativeUnitOfMeasureQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                DerivativeUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasureQty Get(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                return IsSetDerivativeUnitOfMeasureQty();
            }
            
            public bool IsSetDerivativeUnitOfMeasureQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeUnitOfMeasureQty);
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasure DerivativePriceUnitOfMeasure
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativePriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                DerivativePriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasure Get(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                return IsSetDerivativePriceUnitOfMeasure();
            }
            
            public bool IsSetDerivativePriceUnitOfMeasure() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativePriceUnitOfMeasure);
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty DerivativePriceUnitOfMeasureQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativePriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                DerivativePriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty Get(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                return IsSetDerivativePriceUnitOfMeasureQty();
            }
            
            public bool IsSetDerivativePriceUnitOfMeasureQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativePriceUnitOfMeasureQty);
            }
            
            public QuickFix.Fields.DerivativeExerciseStyle DerivativeExerciseStyle
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                DerivativeExerciseStyle = val;
            }
            
            public QuickFix.Fields.DerivativeExerciseStyle Get(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                return IsSetDerivativeExerciseStyle();
            }
            
            public bool IsSetDerivativeExerciseStyle() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeExerciseStyle);
            }
            
            public QuickFix.Fields.DerivativeOptPayAmount DerivativeOptPayAmount
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeOptPayAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                DerivativeOptPayAmount = val;
            }
            
            public QuickFix.Fields.DerivativeOptPayAmount Get(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                return IsSetDerivativeOptPayAmount();
            }
            
            public bool IsSetDerivativeOptPayAmount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeOptPayAmount);
            }
            
            public QuickFix.Fields.DerivativeTimeUnit DerivativeTimeUnit
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeTimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                DerivativeTimeUnit = val;
            }
            
            public QuickFix.Fields.DerivativeTimeUnit Get(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                return IsSetDerivativeTimeUnit();
            }
            
            public bool IsSetDerivativeTimeUnit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeTimeUnit);
            }
            
            public QuickFix.Fields.DerivativeSecurityExchange DerivativeSecurityExchange
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                DerivativeSecurityExchange = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityExchange Get(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                return IsSetDerivativeSecurityExchange();
            }
            
            public bool IsSetDerivativeSecurityExchange() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityExchange);
            }
            
            public QuickFix.Fields.DerivativePositionLimit DerivativePositionLimit
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativePositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                DerivativePositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativePositionLimit Get(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                return IsSetDerivativePositionLimit();
            }
            
            public bool IsSetDerivativePositionLimit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativePositionLimit);
            }
            
            public QuickFix.Fields.DerivativeNTPositionLimit DerivativeNTPositionLimit
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeNTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                DerivativeNTPositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativeNTPositionLimit Get(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                return IsSetDerivativeNTPositionLimit();
            }
            
            public bool IsSetDerivativeNTPositionLimit() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeNTPositionLimit);
            }
            
            public QuickFix.Fields.DerivativeIssuer DerivativeIssuer
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeIssuer val) 
            { 
                DerivativeIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeIssuer Get(QuickFix.Fields.DerivativeIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeIssuer val) 
            { 
                return IsSetDerivativeIssuer();
            }
            
            public bool IsSetDerivativeIssuer() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeIssuer);
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuerLen DerivativeEncodedIssuerLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeEncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                DerivativeEncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuerLen Get(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                return IsSetDerivativeEncodedIssuerLen();
            }
            
            public bool IsSetDerivativeEncodedIssuerLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeEncodedIssuerLen);
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuer DerivativeEncodedIssuer
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeEncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                DerivativeEncodedIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuer Get(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                return IsSetDerivativeEncodedIssuer();
            }
            
            public bool IsSetDerivativeEncodedIssuer() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeEncodedIssuer);
            }
            
            public QuickFix.Fields.DerivativeSecurityDesc DerivativeSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                DerivativeSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityDesc Get(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                return IsSetDerivativeSecurityDesc();
            }
            
            public bool IsSetDerivativeSecurityDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityDesc);
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen DerivativeEncodedSecurityDescLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeEncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                DerivativeEncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen Get(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                return IsSetDerivativeEncodedSecurityDescLen();
            }
            
            public bool IsSetDerivativeEncodedSecurityDescLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeEncodedSecurityDescLen);
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDesc DerivativeEncodedSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeEncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                DerivativeEncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDesc Get(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                return IsSetDerivativeEncodedSecurityDesc();
            }
            
            public bool IsSetDerivativeEncodedSecurityDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeEncodedSecurityDesc);
            }
            
            public QuickFix.Fields.DerivativeContractSettlMonth DerivativeContractSettlMonth
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                DerivativeContractSettlMonth = val;
            }
            
            public QuickFix.Fields.DerivativeContractSettlMonth Get(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                return IsSetDerivativeContractSettlMonth();
            }
            
            public bool IsSetDerivativeContractSettlMonth() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeContractSettlMonth);
            }
            
            public QuickFix.Fields.NoDerivativeEvents NoDerivativeEvents
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoDerivativeEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                NoDerivativeEvents = val;
            }
            
            public QuickFix.Fields.NoDerivativeEvents Get(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                return IsSetNoDerivativeEvents();
            }
            
            public bool IsSetNoDerivativeEvents() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoDerivativeEvents);
            }
            
            public QuickFix.Fields.NoDerivativeInstrumentParties NoDerivativeInstrumentParties
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoDerivativeInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                NoDerivativeInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrumentParties Get(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                return IsSetNoDerivativeInstrumentParties();
            }
            
            public bool IsSetNoDerivativeInstrumentParties() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoDerivativeInstrumentParties);
            }
            
            public QuickFix.Fields.DerivativeSettlMethod DerivativeSettlMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                DerivativeSettlMethod = val;
            }
            
            public QuickFix.Fields.DerivativeSettlMethod Get(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                return IsSetDerivativeSettlMethod();
            }
            
            public bool IsSetDerivativeSettlMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSettlMethod);
            }
            
            public QuickFix.Fields.DerivativePriceQuoteMethod DerivativePriceQuoteMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativePriceQuoteMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                DerivativePriceQuoteMethod = val;
            }
            
            public QuickFix.Fields.DerivativePriceQuoteMethod Get(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                return IsSetDerivativePriceQuoteMethod();
            }
            
            public bool IsSetDerivativePriceQuoteMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativePriceQuoteMethod);
            }
            
            public QuickFix.Fields.DerivativeFuturesValuationMethod DerivativeFuturesValuationMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeFuturesValuationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                DerivativeFuturesValuationMethod = val;
            }
            
            public QuickFix.Fields.DerivativeFuturesValuationMethod Get(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                return IsSetDerivativeFuturesValuationMethod();
            }
            
            public bool IsSetDerivativeFuturesValuationMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeFuturesValuationMethod);
            }
            
            public QuickFix.Fields.DerivativeListMethod DerivativeListMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeListMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeListMethod val) 
            { 
                DerivativeListMethod = val;
            }
            
            public QuickFix.Fields.DerivativeListMethod Get(QuickFix.Fields.DerivativeListMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeListMethod val) 
            { 
                return IsSetDerivativeListMethod();
            }
            
            public bool IsSetDerivativeListMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeListMethod);
            }
            
            public QuickFix.Fields.DerivativeCapPrice DerivativeCapPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeCapPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                DerivativeCapPrice = val;
            }
            
            public QuickFix.Fields.DerivativeCapPrice Get(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                return IsSetDerivativeCapPrice();
            }
            
            public bool IsSetDerivativeCapPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeCapPrice);
            }
            
            public QuickFix.Fields.DerivativeFloorPrice DerivativeFloorPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeFloorPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                DerivativeFloorPrice = val;
            }
            
            public QuickFix.Fields.DerivativeFloorPrice Get(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                return IsSetDerivativeFloorPrice();
            }
            
            public bool IsSetDerivativeFloorPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeFloorPrice);
            }
            
            public QuickFix.Fields.DerivativePutOrCall DerivativePutOrCall
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativePutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                DerivativePutOrCall = val;
            }
            
            public QuickFix.Fields.DerivativePutOrCall Get(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                return IsSetDerivativePutOrCall();
            }
            
            public bool IsSetDerivativePutOrCall() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativePutOrCall);
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLLen DerivativeSecurityXMLLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityXMLLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                DerivativeSecurityXMLLen = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLLen Get(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                return IsSetDerivativeSecurityXMLLen();
            }
            
            public bool IsSetDerivativeSecurityXMLLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityXMLLen);
            }
            
            public QuickFix.Fields.DerivativeSecurityXML DerivativeSecurityXML
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityXML();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                DerivativeSecurityXML = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXML Get(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                return IsSetDerivativeSecurityXML();
            }
            
            public bool IsSetDerivativeSecurityXML() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityXML);
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLSchema DerivativeSecurityXMLSchema
            { 
                get 
                {
                    var val = new QuickFix.Fields.DerivativeSecurityXMLSchema();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                DerivativeSecurityXMLSchema = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLSchema Get(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                return IsSetDerivativeSecurityXMLSchema();
            }
            
            public bool IsSetDerivativeSecurityXMLSchema() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityXMLSchema);
            }
            
            public QuickFix.Fields.NoDerivativeInstrAttrib NoDerivativeInstrAttrib
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoDerivativeInstrAttrib();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                NoDerivativeInstrAttrib = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrAttrib Get(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                return IsSetNoDerivativeInstrAttrib();
            }
            
            public bool IsSetNoDerivativeInstrAttrib() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoDerivativeInstrAttrib);
            }
            
            public QuickFix.Fields.NoMarketSegments NoMarketSegments
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoMarketSegments();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMarketSegments val) 
            { 
                NoMarketSegments = val;
            }
            
            public QuickFix.Fields.NoMarketSegments Get(QuickFix.Fields.NoMarketSegments val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMarketSegments val) 
            { 
                return IsSetNoMarketSegments();
            }
            
            public bool IsSetNoMarketSegments() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoMarketSegments);
            }
            
            public QuickFix.Fields.ApplID ApplID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                ApplID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplID);
            }
            
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                ApplSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplSeqNum);
            }
            
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                ApplLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplLastSeqNum);
            }
            
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                ApplResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplResendFlag);
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
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Symbol, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.SecurityIDSource, QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.Product, QuickFix.Fields.Tags.CFICode, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.SecuritySubType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDate, QuickFix.Fields.Tags.CouponPaymentDate, QuickFix.Fields.Tags.IssueDate, QuickFix.Fields.Tags.RepoCollateralSecurityType, QuickFix.Fields.Tags.RepurchaseTerm, QuickFix.Fields.Tags.RepurchaseRate, QuickFix.Fields.Tags.Factor, QuickFix.Fields.Tags.CreditRating, QuickFix.Fields.Tags.InstrRegistry, QuickFix.Fields.Tags.CountryOfIssue, QuickFix.Fields.Tags.StateOrProvinceOfIssue, QuickFix.Fields.Tags.LocaleOfIssue, QuickFix.Fields.Tags.RedemptionDate, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.StrikeCurrency, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, QuickFix.Fields.Tags.Pool, QuickFix.Fields.Tags.ContractSettlMonth, QuickFix.Fields.Tags.CPProgram, QuickFix.Fields.Tags.CPRegType, QuickFix.Fields.Tags.NoEvents, QuickFix.Fields.Tags.DatedDate, QuickFix.Fields.Tags.InterestAccrualDate, QuickFix.Fields.Tags.SecurityStatus, QuickFix.Fields.Tags.SettleOnOpenFlag, QuickFix.Fields.Tags.InstrmtAssignmentMethod, QuickFix.Fields.Tags.StrikeMultiplier, QuickFix.Fields.Tags.StrikeValue, QuickFix.Fields.Tags.MinPriceIncrement, QuickFix.Fields.Tags.PositionLimit, QuickFix.Fields.Tags.NTPositionLimit, QuickFix.Fields.Tags.NoInstrumentParties, QuickFix.Fields.Tags.UnitOfMeasure, QuickFix.Fields.Tags.TimeUnit, QuickFix.Fields.Tags.MaturityTime, QuickFix.Fields.Tags.SecurityGroup, QuickFix.Fields.Tags.MinPriceIncrementAmount, QuickFix.Fields.Tags.UnitOfMeasureQty, QuickFix.Fields.Tags.SecurityXMLLen, QuickFix.Fields.Tags.SecurityXML, QuickFix.Fields.Tags.SecurityXMLSchema, QuickFix.Fields.Tags.ProductComplex, QuickFix.Fields.Tags.PriceUnitOfMeasure, QuickFix.Fields.Tags.PriceUnitOfMeasureQty, QuickFix.Fields.Tags.SettlMethod, QuickFix.Fields.Tags.ExerciseStyle, QuickFix.Fields.Tags.OptPayAmount, QuickFix.Fields.Tags.PriceQuoteMethod, QuickFix.Fields.Tags.ListMethod, QuickFix.Fields.Tags.CapPrice, QuickFix.Fields.Tags.FloorPrice, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.FlexibleIndicator, QuickFix.Fields.Tags.FlexProductEligibilityIndicator, QuickFix.Fields.Tags.FuturesValuationMethod, QuickFix.Fields.Tags.Currency, QuickFix.Fields.Tags.DeliveryForm, QuickFix.Fields.Tags.PctAtRisk, QuickFix.Fields.Tags.NoInstrAttrib, QuickFix.Fields.Tags.NoLegs, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, QuickFix.Fields.Tags.SecondaryPriceLimitType, QuickFix.Fields.Tags.SecondaryLowLimitPrice, QuickFix.Fields.Tags.SecondaryHighLimitPrice, QuickFix.Fields.Tags.SecondaryTradingReferencePrice, QuickFix.Fields.Tags.CorporateAction, 0};
            
                public NoRelatedSymGroup() 
                  :base( QuickFix.Fields.Tags.NoRelatedSym, QuickFix.Fields.Tags.Symbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.DeliveryForm DeliveryForm
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DeliveryForm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeliveryForm val) 
                { 
                    DeliveryForm = val;
                }
                
                public QuickFix.Fields.DeliveryForm Get(QuickFix.Fields.DeliveryForm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeliveryForm val) 
                { 
                    return IsSetDeliveryForm();
                }
                
                public bool IsSetDeliveryForm() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DeliveryForm);
                }
                
                public QuickFix.Fields.PctAtRisk PctAtRisk
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PctAtRisk();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PctAtRisk val) 
                { 
                    PctAtRisk = val;
                }
                
                public QuickFix.Fields.PctAtRisk Get(QuickFix.Fields.PctAtRisk val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PctAtRisk val) 
                { 
                    return IsSetPctAtRisk();
                }
                
                public bool IsSetPctAtRisk() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PctAtRisk);
                }
                
                public QuickFix.Fields.NoInstrAttrib NoInstrAttrib
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoInstrAttrib();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    NoInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoInstrAttrib Get(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    return IsSetNoInstrAttrib();
                }
                
                public bool IsSetNoInstrAttrib() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoInstrAttrib);
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
                
                public QuickFix.Fields.SecondaryPriceLimitType SecondaryPriceLimitType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryPriceLimitType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    SecondaryPriceLimitType = val;
                }
                
                public QuickFix.Fields.SecondaryPriceLimitType Get(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    return IsSetSecondaryPriceLimitType();
                }
                
                public bool IsSetSecondaryPriceLimitType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryPriceLimitType);
                }
                
                public QuickFix.Fields.SecondaryLowLimitPrice SecondaryLowLimitPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryLowLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    SecondaryLowLimitPrice = val;
                }
                
                public QuickFix.Fields.SecondaryLowLimitPrice Get(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    return IsSetSecondaryLowLimitPrice();
                }
                
                public bool IsSetSecondaryLowLimitPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryLowLimitPrice);
                }
                
                public QuickFix.Fields.SecondaryHighLimitPrice SecondaryHighLimitPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryHighLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    SecondaryHighLimitPrice = val;
                }
                
                public QuickFix.Fields.SecondaryHighLimitPrice Get(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    return IsSetSecondaryHighLimitPrice();
                }
                
                public bool IsSetSecondaryHighLimitPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryHighLimitPrice);
                }
                
                public QuickFix.Fields.SecondaryTradingReferencePrice SecondaryTradingReferencePrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryTradingReferencePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    SecondaryTradingReferencePrice = val;
                }
                
                public QuickFix.Fields.SecondaryTradingReferencePrice Get(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    return IsSetSecondaryTradingReferencePrice();
                }
                
                public bool IsSetSecondaryTradingReferencePrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryTradingReferencePrice);
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
                public class NoInstrAttribGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.InstrAttribType, QuickFix.Fields.Tags.InstrAttribValue, 0};
                
                    public NoInstrAttribGroup() 
                      :base( QuickFix.Fields.Tags.NoInstrAttrib, QuickFix.Fields.Tags.InstrAttribType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrAttribGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrAttribType InstrAttribType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrAttribType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrAttribType val) 
                    { 
                        InstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribType Get(QuickFix.Fields.InstrAttribType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrAttribType val) 
                    { 
                        return IsSetInstrAttribType();
                    }
                    
                    public bool IsSetInstrAttribType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrAttribType);
                    }
                    
                    public QuickFix.Fields.InstrAttribValue InstrAttribValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrAttribValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        InstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribValue Get(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        return IsSetInstrAttribValue();
                    }
                    
                    public bool IsSetInstrAttribValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrAttribValue);
                    }
                    
                
                }
                public class NoLegsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSymbol, QuickFix.Fields.Tags.LegSymbolSfx, QuickFix.Fields.Tags.LegSecurityID, QuickFix.Fields.Tags.LegSecurityIDSource, QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegProduct, QuickFix.Fields.Tags.LegCFICode, QuickFix.Fields.Tags.LegSecurityType, QuickFix.Fields.Tags.LegSecuritySubType, QuickFix.Fields.Tags.LegMaturityMonthYear, QuickFix.Fields.Tags.LegMaturityDate, QuickFix.Fields.Tags.LegCouponPaymentDate, QuickFix.Fields.Tags.LegIssueDate, QuickFix.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.Fields.Tags.LegRepurchaseTerm, QuickFix.Fields.Tags.LegRepurchaseRate, QuickFix.Fields.Tags.LegFactor, QuickFix.Fields.Tags.LegCreditRating, QuickFix.Fields.Tags.LegInstrRegistry, QuickFix.Fields.Tags.LegCountryOfIssue, QuickFix.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.Fields.Tags.LegLocaleOfIssue, QuickFix.Fields.Tags.LegRedemptionDate, QuickFix.Fields.Tags.LegStrikePrice, QuickFix.Fields.Tags.LegStrikeCurrency, QuickFix.Fields.Tags.LegOptAttribute, QuickFix.Fields.Tags.LegContractMultiplier, QuickFix.Fields.Tags.LegCouponRate, QuickFix.Fields.Tags.LegSecurityExchange, QuickFix.Fields.Tags.LegIssuer, QuickFix.Fields.Tags.EncodedLegIssuerLen, QuickFix.Fields.Tags.EncodedLegIssuer, QuickFix.Fields.Tags.LegSecurityDesc, QuickFix.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.Fields.Tags.EncodedLegSecurityDesc, QuickFix.Fields.Tags.LegRatioQty, QuickFix.Fields.Tags.LegSide, QuickFix.Fields.Tags.LegCurrency, QuickFix.Fields.Tags.LegPool, QuickFix.Fields.Tags.LegDatedDate, QuickFix.Fields.Tags.LegContractSettlMonth, QuickFix.Fields.Tags.LegInterestAccrualDate, QuickFix.Fields.Tags.LegUnitOfMeasure, QuickFix.Fields.Tags.LegTimeUnit, QuickFix.Fields.Tags.LegOptionRatio, QuickFix.Fields.Tags.LegPrice, QuickFix.Fields.Tags.LegMaturityTime, QuickFix.Fields.Tags.LegPutOrCall, QuickFix.Fields.Tags.LegExerciseStyle, QuickFix.Fields.Tags.LegUnitOfMeasureQty, QuickFix.Fields.Tags.LegPriceUnitOfMeasure, QuickFix.Fields.Tags.LegPriceUnitOfMeasureQty, 0};
                
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
                    
                    public QuickFix.Fields.LegUnitOfMeasure LegUnitOfMeasure
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        LegUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        return IsSetLegUnitOfMeasure();
                    }
                    
                    public bool IsSetLegUnitOfMeasure() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegUnitOfMeasure);
                    }
                    
                    public QuickFix.Fields.LegTimeUnit LegTimeUnit
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegTimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        LegTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        return IsSetLegTimeUnit();
                    }
                    
                    public bool IsSetLegTimeUnit() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegTimeUnit);
                    }
                    
                    public QuickFix.Fields.LegOptionRatio LegOptionRatio
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegOptionRatio();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        LegOptionRatio = val;
                    }
                    
                    public QuickFix.Fields.LegOptionRatio Get(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        return IsSetLegOptionRatio();
                    }
                    
                    public bool IsSetLegOptionRatio() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegOptionRatio);
                    }
                    
                    public QuickFix.Fields.LegPrice LegPrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPrice val) 
                    { 
                        LegPrice = val;
                    }
                    
                    public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPrice val) 
                    { 
                        return IsSetLegPrice();
                    }
                    
                    public bool IsSetLegPrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPrice);
                    }
                    
                    public QuickFix.Fields.LegMaturityTime LegMaturityTime
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegMaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        LegMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityTime Get(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        return IsSetLegMaturityTime();
                    }
                    
                    public bool IsSetLegMaturityTime() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegMaturityTime);
                    }
                    
                    public QuickFix.Fields.LegPutOrCall LegPutOrCall
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        LegPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.LegPutOrCall Get(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        return IsSetLegPutOrCall();
                    }
                    
                    public bool IsSetLegPutOrCall() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPutOrCall);
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle LegExerciseStyle
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        LegExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle Get(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        return IsSetLegExerciseStyle();
                    }
                    
                    public bool IsSetLegExerciseStyle() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegExerciseStyle);
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty LegUnitOfMeasureQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        LegUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty Get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        return IsSetLegUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegUnitOfMeasureQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegUnitOfMeasureQty);
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure LegPriceUnitOfMeasure
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        LegPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure Get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        return IsSetLegPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasure() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPriceUnitOfMeasure);
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        LegPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty Get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        return IsSetLegPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPriceUnitOfMeasureQty);
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
            }
            public class NoDerivativeSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.DerivativeSecurityAltID, QuickFix.Fields.Tags.DerivativeSecurityAltIDSource, 0};
            
                public NoDerivativeSecurityAltIDGroup() 
                  :base( QuickFix.Fields.Tags.NoDerivativeSecurityAltID, QuickFix.Fields.Tags.DerivativeSecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDerivativeSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.DerivativeSecurityAltID DerivativeSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    DerivativeSecurityAltID = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltID Get(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    return IsSetDerivativeSecurityAltID();
                }
                
                public bool IsSetDerivativeSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityAltID);
                }
                
                public QuickFix.Fields.DerivativeSecurityAltIDSource DerivativeSecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    DerivativeSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltIDSource Get(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    return IsSetDerivativeSecurityAltIDSource();
                }
                
                public bool IsSetDerivativeSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeSecurityAltIDSource);
                }
                
            
            }
            public class NoDerivativeEventsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.DerivativeEventType, QuickFix.Fields.Tags.DerivativeEventDate, QuickFix.Fields.Tags.DerivativeEventTime, QuickFix.Fields.Tags.DerivativeEventPx, QuickFix.Fields.Tags.DerivativeEventText, 0};
            
                public NoDerivativeEventsGroup() 
                  :base( QuickFix.Fields.Tags.NoDerivativeEvents, QuickFix.Fields.Tags.DerivativeEventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDerivativeEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.DerivativeEventType DerivativeEventType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeEventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventType val) 
                { 
                    DerivativeEventType = val;
                }
                
                public QuickFix.Fields.DerivativeEventType Get(QuickFix.Fields.DerivativeEventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventType val) 
                { 
                    return IsSetDerivativeEventType();
                }
                
                public bool IsSetDerivativeEventType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeEventType);
                }
                
                public QuickFix.Fields.DerivativeEventDate DerivativeEventDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeEventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    DerivativeEventDate = val;
                }
                
                public QuickFix.Fields.DerivativeEventDate Get(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    return IsSetDerivativeEventDate();
                }
                
                public bool IsSetDerivativeEventDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeEventDate);
                }
                
                public QuickFix.Fields.DerivativeEventTime DerivativeEventTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeEventTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    DerivativeEventTime = val;
                }
                
                public QuickFix.Fields.DerivativeEventTime Get(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    return IsSetDerivativeEventTime();
                }
                
                public bool IsSetDerivativeEventTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeEventTime);
                }
                
                public QuickFix.Fields.DerivativeEventPx DerivativeEventPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeEventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    DerivativeEventPx = val;
                }
                
                public QuickFix.Fields.DerivativeEventPx Get(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    return IsSetDerivativeEventPx();
                }
                
                public bool IsSetDerivativeEventPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeEventPx);
                }
                
                public QuickFix.Fields.DerivativeEventText DerivativeEventText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeEventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventText val) 
                { 
                    DerivativeEventText = val;
                }
                
                public QuickFix.Fields.DerivativeEventText Get(QuickFix.Fields.DerivativeEventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventText val) 
                { 
                    return IsSetDerivativeEventText();
                }
                
                public bool IsSetDerivativeEventText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeEventText);
                }
                
            
            }
            public class NoDerivativeInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.DerivativeInstrumentPartyID, QuickFix.Fields.Tags.DerivativeInstrumentPartyIDSource, QuickFix.Fields.Tags.DerivativeInstrumentPartyRole, QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs, 0};
            
                public NoDerivativeInstrumentPartiesGroup() 
                  :base( QuickFix.Fields.Tags.NoDerivativeInstrumentParties, QuickFix.Fields.Tags.DerivativeInstrumentPartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDerivativeInstrumentPartiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.DerivativeInstrumentPartyID DerivativeInstrumentPartyID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeInstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    DerivativeInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyID Get(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    return IsSetDerivativeInstrumentPartyID();
                }
                
                public bool IsSetDerivativeInstrumentPartyID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeInstrumentPartyID);
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource DerivativeInstrumentPartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeInstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    DerivativeInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource Get(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    return IsSetDerivativeInstrumentPartyIDSource();
                }
                
                public bool IsSetDerivativeInstrumentPartyIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeInstrumentPartyIDSource);
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyRole DerivativeInstrumentPartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeInstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    DerivativeInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyRole Get(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    return IsSetDerivativeInstrumentPartyRole();
                }
                
                public bool IsSetDerivativeInstrumentPartyRole() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeInstrumentPartyRole);
                }
                
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs NoDerivativeInstrumentPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoDerivativeInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    NoDerivativeInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs Get(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    return IsSetNoDerivativeInstrumentPartySubIDs();
                }
                
                public bool IsSetNoDerivativeInstrumentPartySubIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs);
                }
                
                            public class NoDerivativeInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.DerivativeInstrumentPartySubID, QuickFix.Fields.Tags.DerivativeInstrumentPartySubIDType, 0};
                
                    public NoDerivativeInstrumentPartySubIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs, QuickFix.Fields.Tags.DerivativeInstrumentPartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoDerivativeInstrumentPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.DerivativeInstrumentPartySubID DerivativeInstrumentPartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.DerivativeInstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        DerivativeInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubID Get(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        return IsSetDerivativeInstrumentPartySubID();
                    }
                    
                    public bool IsSetDerivativeInstrumentPartySubID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.DerivativeInstrumentPartySubID);
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType DerivativeInstrumentPartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.DerivativeInstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        DerivativeInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType Get(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        return IsSetDerivativeInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetDerivativeInstrumentPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.DerivativeInstrumentPartySubIDType);
                    }
                    
                
                }
            }
            public class NoDerivativeInstrAttribGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.DerivativeInstrAttribType, QuickFix.Fields.Tags.DerivativeInstrAttribValue, 0};
            
                public NoDerivativeInstrAttribGroup() 
                  :base( QuickFix.Fields.Tags.NoDerivativeInstrAttrib, QuickFix.Fields.Tags.DerivativeInstrAttribType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDerivativeInstrAttribGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.DerivativeInstrAttribType DerivativeInstrAttribType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeInstrAttribType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    DerivativeInstrAttribType = val;
                }
                
                public QuickFix.Fields.DerivativeInstrAttribType Get(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    return IsSetDerivativeInstrAttribType();
                }
                
                public bool IsSetDerivativeInstrAttribType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeInstrAttribType);
                }
                
                public QuickFix.Fields.DerivativeInstrAttribValue DerivativeInstrAttribValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DerivativeInstrAttribValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    DerivativeInstrAttribValue = val;
                }
                
                public QuickFix.Fields.DerivativeInstrAttribValue Get(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    return IsSetDerivativeInstrAttribValue();
                }
                
                public bool IsSetDerivativeInstrAttribValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DerivativeInstrAttribValue);
                }
                
            
            }
            public class NoMarketSegmentsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.MarketID, QuickFix.Fields.Tags.MarketSegmentID, QuickFix.Fields.Tags.NoTickRules, QuickFix.Fields.Tags.NoLotTypeRules, QuickFix.Fields.Tags.PriceLimitType, QuickFix.Fields.Tags.LowLimitPrice, QuickFix.Fields.Tags.HighLimitPrice, QuickFix.Fields.Tags.TradingReferencePrice, QuickFix.Fields.Tags.ExpirationCycle, QuickFix.Fields.Tags.MinTradeVol, QuickFix.Fields.Tags.MaxTradeVol, QuickFix.Fields.Tags.MaxPriceVariation, QuickFix.Fields.Tags.ImpliedMarketIndicator, QuickFix.Fields.Tags.TradingCurrency, QuickFix.Fields.Tags.RoundLot, QuickFix.Fields.Tags.MultilegModel, QuickFix.Fields.Tags.MultilegPriceMethod, QuickFix.Fields.Tags.PriceType, QuickFix.Fields.Tags.NoTradingSessionRules, QuickFix.Fields.Tags.NoNestedInstrAttrib, QuickFix.Fields.Tags.NoStrikeRules, 0};
            
                public NoMarketSegmentsGroup() 
                  :base( QuickFix.Fields.Tags.NoMarketSegments, QuickFix.Fields.Tags.MarketID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMarketSegmentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.NoTickRules NoTickRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoTickRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTickRules val) 
                { 
                    NoTickRules = val;
                }
                
                public QuickFix.Fields.NoTickRules Get(QuickFix.Fields.NoTickRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTickRules val) 
                { 
                    return IsSetNoTickRules();
                }
                
                public bool IsSetNoTickRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoTickRules);
                }
                
                public QuickFix.Fields.NoLotTypeRules NoLotTypeRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoLotTypeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    NoLotTypeRules = val;
                }
                
                public QuickFix.Fields.NoLotTypeRules Get(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    return IsSetNoLotTypeRules();
                }
                
                public bool IsSetNoLotTypeRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoLotTypeRules);
                }
                
                public QuickFix.Fields.PriceLimitType PriceLimitType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PriceLimitType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceLimitType val) 
                { 
                    PriceLimitType = val;
                }
                
                public QuickFix.Fields.PriceLimitType Get(QuickFix.Fields.PriceLimitType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceLimitType val) 
                { 
                    return IsSetPriceLimitType();
                }
                
                public bool IsSetPriceLimitType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PriceLimitType);
                }
                
                public QuickFix.Fields.LowLimitPrice LowLimitPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LowLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LowLimitPrice val) 
                { 
                    LowLimitPrice = val;
                }
                
                public QuickFix.Fields.LowLimitPrice Get(QuickFix.Fields.LowLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LowLimitPrice val) 
                { 
                    return IsSetLowLimitPrice();
                }
                
                public bool IsSetLowLimitPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LowLimitPrice);
                }
                
                public QuickFix.Fields.HighLimitPrice HighLimitPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.HighLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HighLimitPrice val) 
                { 
                    HighLimitPrice = val;
                }
                
                public QuickFix.Fields.HighLimitPrice Get(QuickFix.Fields.HighLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HighLimitPrice val) 
                { 
                    return IsSetHighLimitPrice();
                }
                
                public bool IsSetHighLimitPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.HighLimitPrice);
                }
                
                public QuickFix.Fields.TradingReferencePrice TradingReferencePrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradingReferencePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    TradingReferencePrice = val;
                }
                
                public QuickFix.Fields.TradingReferencePrice Get(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    return IsSetTradingReferencePrice();
                }
                
                public bool IsSetTradingReferencePrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradingReferencePrice);
                }
                
                public QuickFix.Fields.ExpirationCycle ExpirationCycle
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExpirationCycle();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpirationCycle val) 
                { 
                    ExpirationCycle = val;
                }
                
                public QuickFix.Fields.ExpirationCycle Get(QuickFix.Fields.ExpirationCycle val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpirationCycle val) 
                { 
                    return IsSetExpirationCycle();
                }
                
                public bool IsSetExpirationCycle() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExpirationCycle);
                }
                
                public QuickFix.Fields.MinTradeVol MinTradeVol
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MinTradeVol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinTradeVol val) 
                { 
                    MinTradeVol = val;
                }
                
                public QuickFix.Fields.MinTradeVol Get(QuickFix.Fields.MinTradeVol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinTradeVol val) 
                { 
                    return IsSetMinTradeVol();
                }
                
                public bool IsSetMinTradeVol() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MinTradeVol);
                }
                
                public QuickFix.Fields.MaxTradeVol MaxTradeVol
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaxTradeVol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxTradeVol val) 
                { 
                    MaxTradeVol = val;
                }
                
                public QuickFix.Fields.MaxTradeVol Get(QuickFix.Fields.MaxTradeVol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxTradeVol val) 
                { 
                    return IsSetMaxTradeVol();
                }
                
                public bool IsSetMaxTradeVol() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaxTradeVol);
                }
                
                public QuickFix.Fields.MaxPriceVariation MaxPriceVariation
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaxPriceVariation();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    MaxPriceVariation = val;
                }
                
                public QuickFix.Fields.MaxPriceVariation Get(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    return IsSetMaxPriceVariation();
                }
                
                public bool IsSetMaxPriceVariation() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaxPriceVariation);
                }
                
                public QuickFix.Fields.ImpliedMarketIndicator ImpliedMarketIndicator
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ImpliedMarketIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    ImpliedMarketIndicator = val;
                }
                
                public QuickFix.Fields.ImpliedMarketIndicator Get(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    return IsSetImpliedMarketIndicator();
                }
                
                public bool IsSetImpliedMarketIndicator() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ImpliedMarketIndicator);
                }
                
                public QuickFix.Fields.TradingCurrency TradingCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingCurrency val) 
                { 
                    TradingCurrency = val;
                }
                
                public QuickFix.Fields.TradingCurrency Get(QuickFix.Fields.TradingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingCurrency val) 
                { 
                    return IsSetTradingCurrency();
                }
                
                public bool IsSetTradingCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradingCurrency);
                }
                
                public QuickFix.Fields.RoundLot RoundLot
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RoundLot();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoundLot val) 
                { 
                    RoundLot = val;
                }
                
                public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoundLot val) 
                { 
                    return IsSetRoundLot();
                }
                
                public bool IsSetRoundLot() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RoundLot);
                }
                
                public QuickFix.Fields.MultilegModel MultilegModel
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MultilegModel();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MultilegModel val) 
                { 
                    MultilegModel = val;
                }
                
                public QuickFix.Fields.MultilegModel Get(QuickFix.Fields.MultilegModel val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MultilegModel val) 
                { 
                    return IsSetMultilegModel();
                }
                
                public bool IsSetMultilegModel() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MultilegModel);
                }
                
                public QuickFix.Fields.MultilegPriceMethod MultilegPriceMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MultilegPriceMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    MultilegPriceMethod = val;
                }
                
                public QuickFix.Fields.MultilegPriceMethod Get(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    return IsSetMultilegPriceMethod();
                }
                
                public bool IsSetMultilegPriceMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MultilegPriceMethod);
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
                
                public QuickFix.Fields.NoTradingSessionRules NoTradingSessionRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoTradingSessionRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    NoTradingSessionRules = val;
                }
                
                public QuickFix.Fields.NoTradingSessionRules Get(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    return IsSetNoTradingSessionRules();
                }
                
                public bool IsSetNoTradingSessionRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoTradingSessionRules);
                }
                
                public QuickFix.Fields.NoNestedInstrAttrib NoNestedInstrAttrib
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoNestedInstrAttrib();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    NoNestedInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoNestedInstrAttrib Get(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    return IsSetNoNestedInstrAttrib();
                }
                
                public bool IsSetNoNestedInstrAttrib() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoNestedInstrAttrib);
                }
                
                public QuickFix.Fields.NoStrikeRules NoStrikeRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoStrikeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoStrikeRules val) 
                { 
                    NoStrikeRules = val;
                }
                
                public QuickFix.Fields.NoStrikeRules Get(QuickFix.Fields.NoStrikeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoStrikeRules val) 
                { 
                    return IsSetNoStrikeRules();
                }
                
                public bool IsSetNoStrikeRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoStrikeRules);
                }
                
                            public class NoTickRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.StartTickPriceRange, QuickFix.Fields.Tags.EndTickPriceRange, QuickFix.Fields.Tags.TickIncrement, QuickFix.Fields.Tags.TickRuleType, 0};
                
                    public NoTickRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoTickRules, QuickFix.Fields.Tags.StartTickPriceRange, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTickRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StartTickPriceRange StartTickPriceRange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StartTickPriceRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        StartTickPriceRange = val;
                    }
                    
                    public QuickFix.Fields.StartTickPriceRange Get(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        return IsSetStartTickPriceRange();
                    }
                    
                    public bool IsSetStartTickPriceRange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StartTickPriceRange);
                    }
                    
                    public QuickFix.Fields.EndTickPriceRange EndTickPriceRange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EndTickPriceRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        EndTickPriceRange = val;
                    }
                    
                    public QuickFix.Fields.EndTickPriceRange Get(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        return IsSetEndTickPriceRange();
                    }
                    
                    public bool IsSetEndTickPriceRange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EndTickPriceRange);
                    }
                    
                    public QuickFix.Fields.TickIncrement TickIncrement
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.TickIncrement();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TickIncrement val) 
                    { 
                        TickIncrement = val;
                    }
                    
                    public QuickFix.Fields.TickIncrement Get(QuickFix.Fields.TickIncrement val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TickIncrement val) 
                    { 
                        return IsSetTickIncrement();
                    }
                    
                    public bool IsSetTickIncrement() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.TickIncrement);
                    }
                    
                    public QuickFix.Fields.TickRuleType TickRuleType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.TickRuleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TickRuleType val) 
                    { 
                        TickRuleType = val;
                    }
                    
                    public QuickFix.Fields.TickRuleType Get(QuickFix.Fields.TickRuleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TickRuleType val) 
                    { 
                        return IsSetTickRuleType();
                    }
                    
                    public bool IsSetTickRuleType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.TickRuleType);
                    }
                    
                
                }
                public class NoLotTypeRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.LotType, QuickFix.Fields.Tags.MinLotSize, 0};
                
                    public NoLotTypeRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoLotTypeRules, QuickFix.Fields.Tags.LotType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLotTypeRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LotType LotType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LotType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LotType val) 
                    { 
                        LotType = val;
                    }
                    
                    public QuickFix.Fields.LotType Get(QuickFix.Fields.LotType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LotType val) 
                    { 
                        return IsSetLotType();
                    }
                    
                    public bool IsSetLotType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LotType);
                    }
                    
                    public QuickFix.Fields.MinLotSize MinLotSize
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MinLotSize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MinLotSize val) 
                    { 
                        MinLotSize = val;
                    }
                    
                    public QuickFix.Fields.MinLotSize Get(QuickFix.Fields.MinLotSize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MinLotSize val) 
                    { 
                        return IsSetMinLotSize();
                    }
                    
                    public bool IsSetMinLotSize() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MinLotSize);
                    }
                    
                
                }
                public class NoTradingSessionRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.NoOrdTypeRules, QuickFix.Fields.Tags.NoTimeInForceRules, QuickFix.Fields.Tags.NoExecInstRules, QuickFix.Fields.Tags.NoMatchRules, QuickFix.Fields.Tags.NoMDFeedTypes, 0};
                
                    public NoTradingSessionRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoTradingSessionRules, QuickFix.Fields.Tags.TradingSessionID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTradingSessionRulesGroup();
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
                    
                    public QuickFix.Fields.NoOrdTypeRules NoOrdTypeRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoOrdTypeRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        NoOrdTypeRules = val;
                    }
                    
                    public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        return IsSetNoOrdTypeRules();
                    }
                    
                    public bool IsSetNoOrdTypeRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoOrdTypeRules);
                    }
                    
                    public QuickFix.Fields.NoTimeInForceRules NoTimeInForceRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoTimeInForceRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        NoTimeInForceRules = val;
                    }
                    
                    public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        return IsSetNoTimeInForceRules();
                    }
                    
                    public bool IsSetNoTimeInForceRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoTimeInForceRules);
                    }
                    
                    public QuickFix.Fields.NoExecInstRules NoExecInstRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoExecInstRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        NoExecInstRules = val;
                    }
                    
                    public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        return IsSetNoExecInstRules();
                    }
                    
                    public bool IsSetNoExecInstRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoExecInstRules);
                    }
                    
                    public QuickFix.Fields.NoMatchRules NoMatchRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoMatchRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMatchRules val) 
                    { 
                        NoMatchRules = val;
                    }
                    
                    public QuickFix.Fields.NoMatchRules Get(QuickFix.Fields.NoMatchRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMatchRules val) 
                    { 
                        return IsSetNoMatchRules();
                    }
                    
                    public bool IsSetNoMatchRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoMatchRules);
                    }
                    
                    public QuickFix.Fields.NoMDFeedTypes NoMDFeedTypes
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoMDFeedTypes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        NoMDFeedTypes = val;
                    }
                    
                    public QuickFix.Fields.NoMDFeedTypes Get(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        return IsSetNoMDFeedTypes();
                    }
                    
                    public bool IsSetNoMDFeedTypes() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoMDFeedTypes);
                    }
                    
                                    public class NoOrdTypeRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.OrdType, 0};
                    
                        public NoOrdTypeRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoOrdTypeRules, QuickFix.Fields.Tags.OrdType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoOrdTypeRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
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
                        
                    
                    }
                    public class NoTimeInForceRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.TimeInForce, 0};
                    
                        public NoTimeInForceRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoTimeInForceRules, QuickFix.Fields.Tags.TimeInForce, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoTimeInForceRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
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
                        
                    
                    }
                    public class NoExecInstRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.ExecInstValue, 0};
                    
                        public NoExecInstRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoExecInstRules, QuickFix.Fields.Tags.ExecInstValue, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoExecInstRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.ExecInstValue ExecInstValue
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.ExecInstValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ExecInstValue val) 
                        { 
                            ExecInstValue = val;
                        }
                        
                        public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ExecInstValue val) 
                        { 
                            return IsSetExecInstValue();
                        }
                        
                        public bool IsSetExecInstValue() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.ExecInstValue);
                        }
                        
                    
                    }
                    public class NoMatchRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.MatchAlgorithm, QuickFix.Fields.Tags.MatchType, 0};
                    
                        public NoMatchRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoMatchRules, QuickFix.Fields.Tags.MatchAlgorithm, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMatchRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MatchAlgorithm MatchAlgorithm
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MatchAlgorithm();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            MatchAlgorithm = val;
                        }
                        
                        public QuickFix.Fields.MatchAlgorithm Get(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            return IsSetMatchAlgorithm();
                        }
                        
                        public bool IsSetMatchAlgorithm() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MatchAlgorithm);
                        }
                        
                        public QuickFix.Fields.MatchType MatchType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MatchType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MatchType val) 
                        { 
                            MatchType = val;
                        }
                        
                        public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MatchType val) 
                        { 
                            return IsSetMatchType();
                        }
                        
                        public bool IsSetMatchType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MatchType);
                        }
                        
                    
                    }
                    public class NoMDFeedTypesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.MDFeedType, QuickFix.Fields.Tags.MarketDepth, QuickFix.Fields.Tags.MDBookType, 0};
                    
                        public NoMDFeedTypesGroup() 
                          :base( QuickFix.Fields.Tags.NoMDFeedTypes, QuickFix.Fields.Tags.MDFeedType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMDFeedTypesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MDFeedType MDFeedType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MDFeedType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MDFeedType val) 
                        { 
                            MDFeedType = val;
                        }
                        
                        public QuickFix.Fields.MDFeedType Get(QuickFix.Fields.MDFeedType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MDFeedType val) 
                        { 
                            return IsSetMDFeedType();
                        }
                        
                        public bool IsSetMDFeedType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MDFeedType);
                        }
                        
                        public QuickFix.Fields.MarketDepth MarketDepth
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MarketDepth();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MarketDepth val) 
                        { 
                            MarketDepth = val;
                        }
                        
                        public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MarketDepth val) 
                        { 
                            return IsSetMarketDepth();
                        }
                        
                        public bool IsSetMarketDepth() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MarketDepth);
                        }
                        
                        public QuickFix.Fields.MDBookType MDBookType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MDBookType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MDBookType val) 
                        { 
                            MDBookType = val;
                        }
                        
                        public QuickFix.Fields.MDBookType Get(QuickFix.Fields.MDBookType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MDBookType val) 
                        { 
                            return IsSetMDBookType();
                        }
                        
                        public bool IsSetMDBookType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MDBookType);
                        }
                        
                    
                    }
                }
                public class NoNestedInstrAttribGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedInstrAttribType, QuickFix.Fields.Tags.NestedInstrAttribValue, 0};
                
                    public NoNestedInstrAttribGroup() 
                      :base( QuickFix.Fields.Tags.NoNestedInstrAttrib, QuickFix.Fields.Tags.NestedInstrAttribType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedInstrAttribGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedInstrAttribType NestedInstrAttribType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedInstrAttribType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        NestedInstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribType Get(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        return IsSetNestedInstrAttribType();
                    }
                    
                    public bool IsSetNestedInstrAttribType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedInstrAttribType);
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribValue NestedInstrAttribValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedInstrAttribValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        NestedInstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribValue Get(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        return IsSetNestedInstrAttribValue();
                    }
                    
                    public bool IsSetNestedInstrAttribValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedInstrAttribValue);
                    }
                    
                
                }
                public class NoStrikeRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.StrikeRuleID, QuickFix.Fields.Tags.StartStrikePxRange, QuickFix.Fields.Tags.EndStrikePxRange, QuickFix.Fields.Tags.StrikeIncrement, QuickFix.Fields.Tags.StrikeExerciseStyle, QuickFix.Fields.Tags.NoMaturityRules, 0};
                
                    public NoStrikeRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoStrikeRules, QuickFix.Fields.Tags.StrikeRuleID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoStrikeRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StrikeRuleID StrikeRuleID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StrikeRuleID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        StrikeRuleID = val;
                    }
                    
                    public QuickFix.Fields.StrikeRuleID Get(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        return IsSetStrikeRuleID();
                    }
                    
                    public bool IsSetStrikeRuleID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StrikeRuleID);
                    }
                    
                    public QuickFix.Fields.StartStrikePxRange StartStrikePxRange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StartStrikePxRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        StartStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.StartStrikePxRange Get(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        return IsSetStartStrikePxRange();
                    }
                    
                    public bool IsSetStartStrikePxRange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StartStrikePxRange);
                    }
                    
                    public QuickFix.Fields.EndStrikePxRange EndStrikePxRange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EndStrikePxRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        EndStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.EndStrikePxRange Get(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        return IsSetEndStrikePxRange();
                    }
                    
                    public bool IsSetEndStrikePxRange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EndStrikePxRange);
                    }
                    
                    public QuickFix.Fields.StrikeIncrement StrikeIncrement
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StrikeIncrement();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        StrikeIncrement = val;
                    }
                    
                    public QuickFix.Fields.StrikeIncrement Get(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        return IsSetStrikeIncrement();
                    }
                    
                    public bool IsSetStrikeIncrement() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StrikeIncrement);
                    }
                    
                    public QuickFix.Fields.StrikeExerciseStyle StrikeExerciseStyle
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StrikeExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        StrikeExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.StrikeExerciseStyle Get(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        return IsSetStrikeExerciseStyle();
                    }
                    
                    public bool IsSetStrikeExerciseStyle() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StrikeExerciseStyle);
                    }
                    
                    public QuickFix.Fields.NoMaturityRules NoMaturityRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoMaturityRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        NoMaturityRules = val;
                    }
                    
                    public QuickFix.Fields.NoMaturityRules Get(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        return IsSetNoMaturityRules();
                    }
                    
                    public bool IsSetNoMaturityRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoMaturityRules);
                    }
                    
                                    public class NoMaturityRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.MaturityRuleID, QuickFix.Fields.Tags.MaturityMonthYearFormat, QuickFix.Fields.Tags.MaturityMonthYearIncrementUnits, QuickFix.Fields.Tags.StartMaturityMonthYear, QuickFix.Fields.Tags.EndMaturityMonthYear, QuickFix.Fields.Tags.MaturityMonthYearIncrement, 0};
                    
                        public NoMaturityRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoMaturityRules, QuickFix.Fields.Tags.MaturityRuleID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMaturityRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MaturityRuleID MaturityRuleID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityRuleID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            MaturityRuleID = val;
                        }
                        
                        public QuickFix.Fields.MaturityRuleID Get(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            return IsSetMaturityRuleID();
                        }
                        
                        public bool IsSetMaturityRuleID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityRuleID);
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearFormat MaturityMonthYearFormat
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityMonthYearFormat();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            MaturityMonthYearFormat = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearFormat Get(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            return IsSetMaturityMonthYearFormat();
                        }
                        
                        public bool IsSetMaturityMonthYearFormat() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityMonthYearFormat);
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits MaturityMonthYearIncrementUnits
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityMonthYearIncrementUnits();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            MaturityMonthYearIncrementUnits = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits Get(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            return IsSetMaturityMonthYearIncrementUnits();
                        }
                        
                        public bool IsSetMaturityMonthYearIncrementUnits() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityMonthYearIncrementUnits);
                        }
                        
                        public QuickFix.Fields.StartMaturityMonthYear StartMaturityMonthYear
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.StartMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            StartMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.StartMaturityMonthYear Get(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            return IsSetStartMaturityMonthYear();
                        }
                        
                        public bool IsSetStartMaturityMonthYear() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.StartMaturityMonthYear);
                        }
                        
                        public QuickFix.Fields.EndMaturityMonthYear EndMaturityMonthYear
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.EndMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            EndMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.EndMaturityMonthYear Get(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            return IsSetEndMaturityMonthYear();
                        }
                        
                        public bool IsSetEndMaturityMonthYear() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.EndMaturityMonthYear);
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrement MaturityMonthYearIncrement
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityMonthYearIncrement();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            MaturityMonthYearIncrement = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrement Get(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            return IsSetMaturityMonthYearIncrement();
                        }
                        
                        public bool IsSetMaturityMonthYearIncrement() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityMonthYearIncrement);
                        }
                        
                    
                    }
                }
            }
    }
}

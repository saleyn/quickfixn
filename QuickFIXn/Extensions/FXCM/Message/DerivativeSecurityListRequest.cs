// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class DerivativeSecurityListRequest : Message
    {
            public const string MsgType = "z";

            public DerivativeSecurityListRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("z"));
            }

            public DerivativeSecurityListRequest(
                    QuickFix.FXCM.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.FXCM.Fields.SecurityListRequestType aSecurityListRequestType
                ) : this()
            {
                this.SecurityReqID = aSecurityReqID;
                this.SecurityListRequestType = aSecurityListRequestType;
            }

            public QuickFix.FXCM.Fields.SecurityReqID SecurityReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityReqID val) 
            { 
                SecurityReqID = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityReqID Get(QuickFix.FXCM.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityReqID);
            }
            
            public QuickFix.FXCM.Fields.SecurityListRequestType SecurityListRequestType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityListRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityListRequestType val) 
            { 
                SecurityListRequestType = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityListRequestType Get(QuickFix.FXCM.Fields.SecurityListRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityListRequestType val) 
            { 
                return IsSetSecurityListRequestType();
            }
            
            public bool IsSetSecurityListRequestType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityListRequestType);
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
            
            public QuickFix.FXCM.Fields.SubscriptionRequestType SubscriptionRequestType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SubscriptionRequestType val) 
            { 
                SubscriptionRequestType = val;
            }
            
            public QuickFix.FXCM.Fields.SubscriptionRequestType Get(QuickFix.FXCM.Fields.SubscriptionRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SubscriptionRequestType val) 
            { 
                return IsSetSubscriptionRequestType();
            }
            
            public bool IsSetSubscriptionRequestType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SubscriptionRequestType);
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
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class MassQuote : Message
    {
            public const string MsgType = "i";

            public MassQuote() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("i"));
            }

            public MassQuote(
                    QuickFix.Fields.QuoteID aQuoteID
                ) : this()
            {
                this.QuoteID = aQuoteID;
            }

            public QuickFix.Fields.QuoteReqID QuoteReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.QuoteReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteReqID val) 
            { 
                QuoteReqID = val;
            }
            
            public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteReqID val) 
            { 
                return IsSetQuoteReqID();
            }
            
            public bool IsSetQuoteReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.QuoteReqID);
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
            
            public QuickFix.Fields.QuoteType QuoteType
            { 
                get 
                {
                    var val = new QuickFix.Fields.QuoteType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteType val) 
            { 
                QuoteType = val;
            }
            
            public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteType val) 
            { 
                return IsSetQuoteType();
            }
            
            public bool IsSetQuoteType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.QuoteType);
            }
            
            public QuickFix.Fields.QuoteResponseLevel QuoteResponseLevel
            { 
                get 
                {
                    var val = new QuickFix.Fields.QuoteResponseLevel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                QuoteResponseLevel = val;
            }
            
            public QuickFix.Fields.QuoteResponseLevel Get(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                return IsSetQuoteResponseLevel();
            }
            
            public bool IsSetQuoteResponseLevel() 
            { 
                return IsSetField(QuickFix.Fields.Tags.QuoteResponseLevel);
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
            
            public QuickFix.Fields.DefBidSize DefBidSize
            { 
                get 
                {
                    var val = new QuickFix.Fields.DefBidSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DefBidSize val) 
            { 
                DefBidSize = val;
            }
            
            public QuickFix.Fields.DefBidSize Get(QuickFix.Fields.DefBidSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DefBidSize val) 
            { 
                return IsSetDefBidSize();
            }
            
            public bool IsSetDefBidSize() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DefBidSize);
            }
            
            public QuickFix.Fields.DefOfferSize DefOfferSize
            { 
                get 
                {
                    var val = new QuickFix.Fields.DefOfferSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DefOfferSize val) 
            { 
                DefOfferSize = val;
            }
            
            public QuickFix.Fields.DefOfferSize Get(QuickFix.Fields.DefOfferSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DefOfferSize val) 
            { 
                return IsSetDefOfferSize();
            }
            
            public bool IsSetDefOfferSize() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DefOfferSize);
            }
            
            public QuickFix.Fields.NoQuoteSets NoQuoteSets
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoQuoteSets();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoQuoteSets val) 
            { 
                NoQuoteSets = val;
            }
            
            public QuickFix.Fields.NoQuoteSets Get(QuickFix.Fields.NoQuoteSets val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoQuoteSets val) 
            { 
                return IsSetNoQuoteSets();
            }
            
            public bool IsSetNoQuoteSets() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoQuoteSets);
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
            public class NoQuoteSetsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.QuoteSetID, QuickFix.Fields.Tags.UnderlyingSymbol, QuickFix.Fields.Tags.UnderlyingSymbolSfx, QuickFix.Fields.Tags.UnderlyingSecurityID, QuickFix.Fields.Tags.UnderlyingSecurityIDSource, QuickFix.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingProduct, QuickFix.Fields.Tags.UnderlyingCFICode, QuickFix.Fields.Tags.UnderlyingSecurityType, QuickFix.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.Fields.Tags.UnderlyingMaturityDate, QuickFix.Fields.Tags.UnderlyingCouponPaymentDate, QuickFix.Fields.Tags.UnderlyingIssueDate, QuickFix.Fields.Tags.UnderlyingRepoCollateralSecurityType, QuickFix.Fields.Tags.UnderlyingRepurchaseTerm, QuickFix.Fields.Tags.UnderlyingRepurchaseRate, QuickFix.Fields.Tags.UnderlyingFactor, QuickFix.Fields.Tags.UnderlyingCreditRating, QuickFix.Fields.Tags.UnderlyingInstrRegistry, QuickFix.Fields.Tags.UnderlyingCountryOfIssue, QuickFix.Fields.Tags.UnderlyingStateOrProvinceOfIssue, QuickFix.Fields.Tags.UnderlyingLocaleOfIssue, QuickFix.Fields.Tags.UnderlyingRedemptionDate, QuickFix.Fields.Tags.UnderlyingPutOrCall, QuickFix.Fields.Tags.UnderlyingStrikePrice, QuickFix.Fields.Tags.UnderlyingOptAttribute, QuickFix.Fields.Tags.UnderlyingContractMultiplier, QuickFix.Fields.Tags.UnderlyingCouponRate, QuickFix.Fields.Tags.UnderlyingSecurityExchange, QuickFix.Fields.Tags.UnderlyingIssuer, QuickFix.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.Fields.Tags.UnderlyingSecurityDesc, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.Fields.Tags.QuoteSetValidUntilTime, QuickFix.Fields.Tags.TotQuoteEntries, QuickFix.Fields.Tags.NoQuoteEntries, 0};
            
                public NoQuoteSetsGroup() 
                  :base( QuickFix.Fields.Tags.NoQuoteSets, QuickFix.Fields.Tags.QuoteSetID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoQuoteSetsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.QuoteSetID QuoteSetID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QuoteSetID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteSetID val) 
                { 
                    QuoteSetID = val;
                }
                
                public QuickFix.Fields.QuoteSetID Get(QuickFix.Fields.QuoteSetID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteSetID val) 
                { 
                    return IsSetQuoteSetID();
                }
                
                public bool IsSetQuoteSetID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QuoteSetID);
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
                
                public QuickFix.Fields.QuoteSetValidUntilTime QuoteSetValidUntilTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QuoteSetValidUntilTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    QuoteSetValidUntilTime = val;
                }
                
                public QuickFix.Fields.QuoteSetValidUntilTime Get(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    return IsSetQuoteSetValidUntilTime();
                }
                
                public bool IsSetQuoteSetValidUntilTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QuoteSetValidUntilTime);
                }
                
                public QuickFix.Fields.TotQuoteEntries TotQuoteEntries
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TotQuoteEntries();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    TotQuoteEntries = val;
                }
                
                public QuickFix.Fields.TotQuoteEntries Get(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    return IsSetTotQuoteEntries();
                }
                
                public bool IsSetTotQuoteEntries() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TotQuoteEntries);
                }
                
                public QuickFix.Fields.NoQuoteEntries NoQuoteEntries
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoQuoteEntries();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoQuoteEntries val) 
                { 
                    NoQuoteEntries = val;
                }
                
                public QuickFix.Fields.NoQuoteEntries Get(QuickFix.Fields.NoQuoteEntries val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoQuoteEntries val) 
                { 
                    return IsSetNoQuoteEntries();
                }
                
                public bool IsSetNoQuoteEntries() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoQuoteEntries);
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
                public class NoQuoteEntriesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.QuoteEntryID, QuickFix.Fields.Tags.Symbol, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.SecurityIDSource, QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.Product, QuickFix.Fields.Tags.CFICode, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDate, QuickFix.Fields.Tags.CouponPaymentDate, QuickFix.Fields.Tags.IssueDate, QuickFix.Fields.Tags.RepoCollateralSecurityType, QuickFix.Fields.Tags.RepurchaseTerm, QuickFix.Fields.Tags.RepurchaseRate, QuickFix.Fields.Tags.Factor, QuickFix.Fields.Tags.CreditRating, QuickFix.Fields.Tags.InstrRegistry, QuickFix.Fields.Tags.CountryOfIssue, QuickFix.Fields.Tags.StateOrProvinceOfIssue, QuickFix.Fields.Tags.LocaleOfIssue, QuickFix.Fields.Tags.RedemptionDate, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, QuickFix.Fields.Tags.BidPx, QuickFix.Fields.Tags.OfferPx, QuickFix.Fields.Tags.BidSize, QuickFix.Fields.Tags.OfferSize, QuickFix.Fields.Tags.ValidUntilTime, QuickFix.Fields.Tags.BidSpotRate, QuickFix.Fields.Tags.OfferSpotRate, QuickFix.Fields.Tags.BidForwardPoints, QuickFix.Fields.Tags.OfferForwardPoints, QuickFix.Fields.Tags.MidPx, QuickFix.Fields.Tags.BidYield, QuickFix.Fields.Tags.MidYield, QuickFix.Fields.Tags.OfferYield, QuickFix.Fields.Tags.TransactTime, QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.FutSettDate, QuickFix.Fields.Tags.OrdType, QuickFix.Fields.Tags.FutSettDate2, QuickFix.Fields.Tags.OrderQty2, QuickFix.Fields.Tags.BidForwardPoints2, QuickFix.Fields.Tags.OfferForwardPoints2, QuickFix.Fields.Tags.Currency, 0};
                
                    public NoQuoteEntriesGroup() 
                      :base( QuickFix.Fields.Tags.NoQuoteEntries, QuickFix.Fields.Tags.QuoteEntryID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoQuoteEntriesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
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
                    
                    public QuickFix.Fields.BidPx BidPx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.BidPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidPx val) 
                    { 
                        BidPx = val;
                    }
                    
                    public QuickFix.Fields.BidPx Get(QuickFix.Fields.BidPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidPx val) 
                    { 
                        return IsSetBidPx();
                    }
                    
                    public bool IsSetBidPx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.BidPx);
                    }
                    
                    public QuickFix.Fields.OfferPx OfferPx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OfferPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferPx val) 
                    { 
                        OfferPx = val;
                    }
                    
                    public QuickFix.Fields.OfferPx Get(QuickFix.Fields.OfferPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferPx val) 
                    { 
                        return IsSetOfferPx();
                    }
                    
                    public bool IsSetOfferPx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OfferPx);
                    }
                    
                    public QuickFix.Fields.BidSize BidSize
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.BidSize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidSize val) 
                    { 
                        BidSize = val;
                    }
                    
                    public QuickFix.Fields.BidSize Get(QuickFix.Fields.BidSize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidSize val) 
                    { 
                        return IsSetBidSize();
                    }
                    
                    public bool IsSetBidSize() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.BidSize);
                    }
                    
                    public QuickFix.Fields.OfferSize OfferSize
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OfferSize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferSize val) 
                    { 
                        OfferSize = val;
                    }
                    
                    public QuickFix.Fields.OfferSize Get(QuickFix.Fields.OfferSize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferSize val) 
                    { 
                        return IsSetOfferSize();
                    }
                    
                    public bool IsSetOfferSize() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OfferSize);
                    }
                    
                    public QuickFix.Fields.ValidUntilTime ValidUntilTime
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ValidUntilTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        ValidUntilTime = val;
                    }
                    
                    public QuickFix.Fields.ValidUntilTime Get(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        return IsSetValidUntilTime();
                    }
                    
                    public bool IsSetValidUntilTime() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ValidUntilTime);
                    }
                    
                    public QuickFix.Fields.BidSpotRate BidSpotRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.BidSpotRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidSpotRate val) 
                    { 
                        BidSpotRate = val;
                    }
                    
                    public QuickFix.Fields.BidSpotRate Get(QuickFix.Fields.BidSpotRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidSpotRate val) 
                    { 
                        return IsSetBidSpotRate();
                    }
                    
                    public bool IsSetBidSpotRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.BidSpotRate);
                    }
                    
                    public QuickFix.Fields.OfferSpotRate OfferSpotRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OfferSpotRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        OfferSpotRate = val;
                    }
                    
                    public QuickFix.Fields.OfferSpotRate Get(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        return IsSetOfferSpotRate();
                    }
                    
                    public bool IsSetOfferSpotRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OfferSpotRate);
                    }
                    
                    public QuickFix.Fields.BidForwardPoints BidForwardPoints
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.BidForwardPoints();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        BidForwardPoints = val;
                    }
                    
                    public QuickFix.Fields.BidForwardPoints Get(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        return IsSetBidForwardPoints();
                    }
                    
                    public bool IsSetBidForwardPoints() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.BidForwardPoints);
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints OfferForwardPoints
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OfferForwardPoints();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        OfferForwardPoints = val;
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints Get(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        return IsSetOfferForwardPoints();
                    }
                    
                    public bool IsSetOfferForwardPoints() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OfferForwardPoints);
                    }
                    
                    public QuickFix.Fields.MidPx MidPx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MidPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MidPx val) 
                    { 
                        MidPx = val;
                    }
                    
                    public QuickFix.Fields.MidPx Get(QuickFix.Fields.MidPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MidPx val) 
                    { 
                        return IsSetMidPx();
                    }
                    
                    public bool IsSetMidPx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MidPx);
                    }
                    
                    public QuickFix.Fields.BidYield BidYield
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.BidYield();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidYield val) 
                    { 
                        BidYield = val;
                    }
                    
                    public QuickFix.Fields.BidYield Get(QuickFix.Fields.BidYield val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidYield val) 
                    { 
                        return IsSetBidYield();
                    }
                    
                    public bool IsSetBidYield() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.BidYield);
                    }
                    
                    public QuickFix.Fields.MidYield MidYield
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MidYield();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MidYield val) 
                    { 
                        MidYield = val;
                    }
                    
                    public QuickFix.Fields.MidYield Get(QuickFix.Fields.MidYield val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MidYield val) 
                    { 
                        return IsSetMidYield();
                    }
                    
                    public bool IsSetMidYield() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MidYield);
                    }
                    
                    public QuickFix.Fields.OfferYield OfferYield
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OfferYield();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferYield val) 
                    { 
                        OfferYield = val;
                    }
                    
                    public QuickFix.Fields.OfferYield Get(QuickFix.Fields.OfferYield val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferYield val) 
                    { 
                        return IsSetOfferYield();
                    }
                    
                    public bool IsSetOfferYield() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OfferYield);
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
                    
                    public QuickFix.Fields.BidForwardPoints2 BidForwardPoints2
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.BidForwardPoints2();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        BidForwardPoints2 = val;
                    }
                    
                    public QuickFix.Fields.BidForwardPoints2 Get(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        return IsSetBidForwardPoints2();
                    }
                    
                    public bool IsSetBidForwardPoints2() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.BidForwardPoints2);
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints2 OfferForwardPoints2
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OfferForwardPoints2();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        OfferForwardPoints2 = val;
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints2 Get(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        return IsSetOfferForwardPoints2();
                    }
                    
                    public bool IsSetOfferForwardPoints2() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OfferForwardPoints2);
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
    }
}

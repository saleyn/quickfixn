// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class QuoteAcknowledgement : Message
    {
            public const string MsgType = "b";

            public QuoteAcknowledgement() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("b"));
            }

            public QuoteAcknowledgement(
                    QuickFix.Fields.QuoteAckStatus aQuoteAckStatus
                ) : this()
            {
                this.QuoteAckStatus = aQuoteAckStatus;
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
            
            public QuickFix.Fields.QuoteAckStatus QuoteAckStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.QuoteAckStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteAckStatus val) 
            { 
                QuoteAckStatus = val;
            }
            
            public QuickFix.Fields.QuoteAckStatus Get(QuickFix.Fields.QuoteAckStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteAckStatus val) 
            { 
                return IsSetQuoteAckStatus();
            }
            
            public bool IsSetQuoteAckStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.QuoteAckStatus);
            }
            
            public QuickFix.Fields.QuoteRejectReason QuoteRejectReason
            { 
                get 
                {
                    var val = new QuickFix.Fields.QuoteRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteRejectReason val) 
            { 
                QuoteRejectReason = val;
            }
            
            public QuickFix.Fields.QuoteRejectReason Get(QuickFix.Fields.QuoteRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteRejectReason val) 
            { 
                return IsSetQuoteRejectReason();
            }
            
            public bool IsSetQuoteRejectReason() 
            { 
                return IsSetField(QuickFix.Fields.Tags.QuoteRejectReason);
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
            
            public class NoQuoteSetsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.QuoteSetID, QuickFix.Fields.Tags.UnderlyingSymbol, QuickFix.Fields.Tags.UnderlyingSymbolSfx, QuickFix.Fields.Tags.UnderlyingSecurityID, QuickFix.Fields.Tags.UnderlyingIDSource, QuickFix.Fields.Tags.UnderlyingSecurityType, QuickFix.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.Fields.Tags.UnderlyingMaturityDay, QuickFix.Fields.Tags.UnderlyingPutOrCall, QuickFix.Fields.Tags.UnderlyingStrikePrice, QuickFix.Fields.Tags.UnderlyingOptAttribute, QuickFix.Fields.Tags.UnderlyingContractMultiplier, QuickFix.Fields.Tags.UnderlyingCouponRate, QuickFix.Fields.Tags.UnderlyingSecurityExchange, QuickFix.Fields.Tags.UnderlyingIssuer, QuickFix.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.Fields.Tags.UnderlyingSecurityDesc, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.Fields.Tags.TotQuoteEntries, QuickFix.Fields.Tags.NoQuoteEntries, 0};
            
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
                
                public QuickFix.Fields.UnderlyingIDSource UnderlyingIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    UnderlyingIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingIDSource Get(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    return IsSetUnderlyingIDSource();
                }
                
                public bool IsSetUnderlyingIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingIDSource);
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
                
                public QuickFix.Fields.UnderlyingMaturityDay UnderlyingMaturityDay
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingMaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    UnderlyingMaturityDay = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDay Get(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    return IsSetUnderlyingMaturityDay();
                }
                
                public bool IsSetUnderlyingMaturityDay() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityDay);
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
                
                            public class NoQuoteEntriesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.QuoteEntryID, QuickFix.Fields.Tags.Symbol, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.IDSource, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDay, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, QuickFix.Fields.Tags.QuoteEntryRejectReason, 0};
                
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
                    
                    public QuickFix.Fields.QuoteEntryRejectReason QuoteEntryRejectReason
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.QuoteEntryRejectReason();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.QuoteEntryRejectReason val) 
                    { 
                        QuoteEntryRejectReason = val;
                    }
                    
                    public QuickFix.Fields.QuoteEntryRejectReason Get(QuickFix.Fields.QuoteEntryRejectReason val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.QuoteEntryRejectReason val) 
                    { 
                        return IsSetQuoteEntryRejectReason();
                    }
                    
                    public bool IsSetQuoteEntryRejectReason() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.QuoteEntryRejectReason);
                    }
                    
                
                }
            }
    }
}

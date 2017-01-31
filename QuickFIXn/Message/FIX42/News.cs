// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class News : Message
    {
            public const string MsgType = "B";

            public News() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("B"));
            }

            public News(
                    QuickFix.Fields.Headline aHeadline
                ) : this()
            {
                this.Headline = aHeadline;
            }

            public QuickFix.Fields.OrigTime OrigTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrigTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigTime val) 
            { 
                OrigTime = val;
            }
            
            public QuickFix.Fields.OrigTime Get(QuickFix.Fields.OrigTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigTime val) 
            { 
                return IsSetOrigTime();
            }
            
            public bool IsSetOrigTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrigTime);
            }
            
            public QuickFix.Fields.Urgency Urgency
            { 
                get 
                {
                    var val = new QuickFix.Fields.Urgency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Urgency val) 
            { 
                Urgency = val;
            }
            
            public QuickFix.Fields.Urgency Get(QuickFix.Fields.Urgency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Urgency val) 
            { 
                return IsSetUrgency();
            }
            
            public bool IsSetUrgency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Urgency);
            }
            
            public QuickFix.Fields.Headline Headline
            { 
                get 
                {
                    var val = new QuickFix.Fields.Headline();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Headline val) 
            { 
                Headline = val;
            }
            
            public QuickFix.Fields.Headline Get(QuickFix.Fields.Headline val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Headline val) 
            { 
                return IsSetHeadline();
            }
            
            public bool IsSetHeadline() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Headline);
            }
            
            public QuickFix.Fields.EncodedHeadlineLen EncodedHeadlineLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedHeadlineLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedHeadlineLen val) 
            { 
                EncodedHeadlineLen = val;
            }
            
            public QuickFix.Fields.EncodedHeadlineLen Get(QuickFix.Fields.EncodedHeadlineLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedHeadlineLen val) 
            { 
                return IsSetEncodedHeadlineLen();
            }
            
            public bool IsSetEncodedHeadlineLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedHeadlineLen);
            }
            
            public QuickFix.Fields.EncodedHeadline EncodedHeadline
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedHeadline();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedHeadline val) 
            { 
                EncodedHeadline = val;
            }
            
            public QuickFix.Fields.EncodedHeadline Get(QuickFix.Fields.EncodedHeadline val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedHeadline val) 
            { 
                return IsSetEncodedHeadline();
            }
            
            public bool IsSetEncodedHeadline() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedHeadline);
            }
            
            public QuickFix.Fields.NoRoutingIDs NoRoutingIDs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoRoutingIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRoutingIDs val) 
            { 
                NoRoutingIDs = val;
            }
            
            public QuickFix.Fields.NoRoutingIDs Get(QuickFix.Fields.NoRoutingIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRoutingIDs val) 
            { 
                return IsSetNoRoutingIDs();
            }
            
            public bool IsSetNoRoutingIDs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoRoutingIDs);
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
            
            public QuickFix.Fields.LinesOfText LinesOfText
            { 
                get 
                {
                    var val = new QuickFix.Fields.LinesOfText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LinesOfText val) 
            { 
                LinesOfText = val;
            }
            
            public QuickFix.Fields.LinesOfText Get(QuickFix.Fields.LinesOfText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LinesOfText val) 
            { 
                return IsSetLinesOfText();
            }
            
            public bool IsSetLinesOfText() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LinesOfText);
            }
            
            public QuickFix.Fields.URLLink URLLink
            { 
                get 
                {
                    var val = new QuickFix.Fields.URLLink();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.URLLink val) 
            { 
                URLLink = val;
            }
            
            public QuickFix.Fields.URLLink Get(QuickFix.Fields.URLLink val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.URLLink val) 
            { 
                return IsSetURLLink();
            }
            
            public bool IsSetURLLink() 
            { 
                return IsSetField(QuickFix.Fields.Tags.URLLink);
            }
            
            public QuickFix.Fields.RawDataLength RawDataLength
            { 
                get 
                {
                    var val = new QuickFix.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawDataLength val) 
            { 
                RawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RawDataLength);
            }
            
            public QuickFix.Fields.RawData RawData
            { 
                get 
                {
                    var val = new QuickFix.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawData val) 
            { 
                RawData = val;
            }
            
            public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RawData);
            }
            
            public class NoRoutingIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RoutingType, QuickFix.Fields.Tags.RoutingID, 0};
            
                public NoRoutingIDsGroup() 
                  :base( QuickFix.Fields.Tags.NoRoutingIDs, QuickFix.Fields.Tags.RoutingType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRoutingIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RoutingType RoutingType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RoutingType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoutingType val) 
                { 
                    RoutingType = val;
                }
                
                public QuickFix.Fields.RoutingType Get(QuickFix.Fields.RoutingType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoutingType val) 
                { 
                    return IsSetRoutingType();
                }
                
                public bool IsSetRoutingType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RoutingType);
                }
                
                public QuickFix.Fields.RoutingID RoutingID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RoutingID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoutingID val) 
                { 
                    RoutingID = val;
                }
                
                public QuickFix.Fields.RoutingID Get(QuickFix.Fields.RoutingID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoutingID val) 
                { 
                    return IsSetRoutingID();
                }
                
                public bool IsSetRoutingID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RoutingID);
                }
                
            
            }
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatdSym, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.IDSource, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDay, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, 0};
            
                public NoRelatedSymGroup() 
                  :base( QuickFix.Fields.Tags.NoRelatedSym, QuickFix.Fields.Tags.RelatdSym, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RelatdSym RelatdSym
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RelatdSym();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RelatdSym val) 
                { 
                    RelatdSym = val;
                }
                
                public QuickFix.Fields.RelatdSym Get(QuickFix.Fields.RelatdSym val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RelatdSym val) 
                { 
                    return IsSetRelatdSym();
                }
                
                public bool IsSetRelatdSym() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RelatdSym);
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
                
            
            }
            public class LinesOfTextGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, 0};
            
                public LinesOfTextGroup() 
                  :base( QuickFix.Fields.Tags.LinesOfText, QuickFix.Fields.Tags.Text, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new LinesOfTextGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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

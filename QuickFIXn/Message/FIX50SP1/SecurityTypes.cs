// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class SecurityTypes : Message
    {
            public const string MsgType = "w";

            public SecurityTypes() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("w"));
            }

            public SecurityTypes(
                    QuickFix.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.Fields.SecurityResponseID aSecurityResponseID,
                    QuickFix.Fields.SecurityResponseType aSecurityResponseType
                ) : this()
            {
                this.SecurityReqID = aSecurityReqID;
                this.SecurityResponseID = aSecurityResponseID;
                this.SecurityResponseType = aSecurityResponseType;
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
            
            public QuickFix.Fields.SecurityResponseType SecurityResponseType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityResponseType val) 
            { 
                SecurityResponseType = val;
            }
            
            public QuickFix.Fields.SecurityResponseType Get(QuickFix.Fields.SecurityResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityResponseType val) 
            { 
                return IsSetSecurityResponseType();
            }
            
            public bool IsSetSecurityResponseType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityResponseType);
            }
            
            public QuickFix.Fields.TotNoSecurityTypes TotNoSecurityTypes
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotNoSecurityTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoSecurityTypes val) 
            { 
                TotNoSecurityTypes = val;
            }
            
            public QuickFix.Fields.TotNoSecurityTypes Get(QuickFix.Fields.TotNoSecurityTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoSecurityTypes val) 
            { 
                return IsSetTotNoSecurityTypes();
            }
            
            public bool IsSetTotNoSecurityTypes() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotNoSecurityTypes);
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
            
            public QuickFix.Fields.NoSecurityTypes NoSecurityTypes
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoSecurityTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityTypes val) 
            { 
                NoSecurityTypes = val;
            }
            
            public QuickFix.Fields.NoSecurityTypes Get(QuickFix.Fields.NoSecurityTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityTypes val) 
            { 
                return IsSetNoSecurityTypes();
            }
            
            public bool IsSetNoSecurityTypes() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoSecurityTypes);
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
            
            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                SubscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return IsSetSubscriptionRequestType();
            }
            
            public bool IsSetSubscriptionRequestType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SubscriptionRequestType);
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
            
            public class NoSecurityTypesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.SecuritySubType, QuickFix.Fields.Tags.Product, QuickFix.Fields.Tags.CFICode, 0};
            
                public NoSecurityTypesGroup() 
                  :base( QuickFix.Fields.Tags.NoSecurityTypes, QuickFix.Fields.Tags.SecurityType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
            
            }
    }
}

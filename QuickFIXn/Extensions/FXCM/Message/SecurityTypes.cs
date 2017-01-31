// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class SecurityTypes : Message
    {
            public const string MsgType = "w";

            public SecurityTypes() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("w"));
            }

            public SecurityTypes(
                    QuickFix.FXCM.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.FXCM.Fields.SecurityResponseID aSecurityResponseID,
                    QuickFix.FXCM.Fields.SecurityResponseType aSecurityResponseType
                ) : this()
            {
                this.SecurityReqID = aSecurityReqID;
                this.SecurityResponseID = aSecurityResponseID;
                this.SecurityResponseType = aSecurityResponseType;
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
            
            public QuickFix.FXCM.Fields.SecurityResponseID SecurityResponseID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityResponseID val) 
            { 
                SecurityResponseID = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityResponseID Get(QuickFix.FXCM.Fields.SecurityResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityResponseID val) 
            { 
                return IsSetSecurityResponseID();
            }
            
            public bool IsSetSecurityResponseID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityResponseID);
            }
            
            public QuickFix.FXCM.Fields.SecurityResponseType SecurityResponseType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityResponseType val) 
            { 
                SecurityResponseType = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityResponseType Get(QuickFix.FXCM.Fields.SecurityResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityResponseType val) 
            { 
                return IsSetSecurityResponseType();
            }
            
            public bool IsSetSecurityResponseType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityResponseType);
            }
            
            public QuickFix.FXCM.Fields.TotNoSecurityTypes TotNoSecurityTypes
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotNoSecurityTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotNoSecurityTypes val) 
            { 
                TotNoSecurityTypes = val;
            }
            
            public QuickFix.FXCM.Fields.TotNoSecurityTypes Get(QuickFix.FXCM.Fields.TotNoSecurityTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotNoSecurityTypes val) 
            { 
                return IsSetTotNoSecurityTypes();
            }
            
            public bool IsSetTotNoSecurityTypes() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotNoSecurityTypes);
            }
            
            public QuickFix.FXCM.Fields.LastFragment LastFragment
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastFragment val) 
            { 
                LastFragment = val;
            }
            
            public QuickFix.FXCM.Fields.LastFragment Get(QuickFix.FXCM.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastFragment);
            }
            
            public QuickFix.FXCM.Fields.NoSecurityTypes NoSecurityTypes
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoSecurityTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoSecurityTypes val) 
            { 
                NoSecurityTypes = val;
            }
            
            public QuickFix.FXCM.Fields.NoSecurityTypes Get(QuickFix.FXCM.Fields.NoSecurityTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoSecurityTypes val) 
            { 
                return IsSetNoSecurityTypes();
            }
            
            public bool IsSetNoSecurityTypes() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoSecurityTypes);
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
            
            public class NoSecurityTypesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SecurityType, QuickFix.FXCM.Fields.Tags.SecuritySubType, QuickFix.FXCM.Fields.Tags.Product, QuickFix.FXCM.Fields.Tags.CFICode, 0};
            
                public NoSecurityTypesGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoSecurityTypes, QuickFix.FXCM.Fields.Tags.SecurityType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
            
            }
    }
}

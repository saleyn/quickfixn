// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class BidResponse : Message
    {
            public const string MsgType = "l";

            public BidResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("l"));
            }


            public QuickFix.Fields.BidID BidID
            { 
                get 
                {
                    var val = new QuickFix.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidID val) 
            { 
                BidID = val;
            }
            
            public QuickFix.Fields.BidID Get(QuickFix.Fields.BidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidID val) 
            { 
                return IsSetBidID();
            }
            
            public bool IsSetBidID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BidID);
            }
            
            public QuickFix.Fields.ClientBidID ClientBidID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientBidID val) 
            { 
                ClientBidID = val;
            }
            
            public QuickFix.Fields.ClientBidID Get(QuickFix.Fields.ClientBidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientBidID val) 
            { 
                return IsSetClientBidID();
            }
            
            public bool IsSetClientBidID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClientBidID);
            }
            
            public QuickFix.Fields.NoBidComponents NoBidComponents
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoBidComponents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoBidComponents val) 
            { 
                NoBidComponents = val;
            }
            
            public QuickFix.Fields.NoBidComponents Get(QuickFix.Fields.NoBidComponents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoBidComponents val) 
            { 
                return IsSetNoBidComponents();
            }
            
            public bool IsSetNoBidComponents() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoBidComponents);
            }
            
            public class NoBidComponentsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Commission, QuickFix.Fields.Tags.CommType, QuickFix.Fields.Tags.CommCurrency, QuickFix.Fields.Tags.FundRenewWaiv, QuickFix.Fields.Tags.ListID, QuickFix.Fields.Tags.Country, QuickFix.Fields.Tags.Side, QuickFix.Fields.Tags.Price, QuickFix.Fields.Tags.PriceType, QuickFix.Fields.Tags.FairValue, QuickFix.Fields.Tags.NetGrossInd, QuickFix.Fields.Tags.SettlType, QuickFix.Fields.Tags.SettlDate, QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, 0};
            
                public NoBidComponentsGroup() 
                  :base( QuickFix.Fields.Tags.NoBidComponents, QuickFix.Fields.Tags.Commission, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBidComponentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.ListID ListID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ListID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListID val) 
                { 
                    ListID = val;
                }
                
                public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListID val) 
                { 
                    return IsSetListID();
                }
                
                public bool IsSetListID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ListID);
                }
                
                public QuickFix.Fields.Country Country
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Country();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Country val) 
                { 
                    Country = val;
                }
                
                public QuickFix.Fields.Country Get(QuickFix.Fields.Country val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Country val) 
                { 
                    return IsSetCountry();
                }
                
                public bool IsSetCountry() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Country);
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
                
                public QuickFix.Fields.FairValue FairValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FairValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FairValue val) 
                { 
                    FairValue = val;
                }
                
                public QuickFix.Fields.FairValue Get(QuickFix.Fields.FairValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FairValue val) 
                { 
                    return IsSetFairValue();
                }
                
                public bool IsSetFairValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FairValue);
                }
                
                public QuickFix.Fields.NetGrossInd NetGrossInd
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NetGrossInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NetGrossInd val) 
                { 
                    NetGrossInd = val;
                }
                
                public QuickFix.Fields.NetGrossInd Get(QuickFix.Fields.NetGrossInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NetGrossInd val) 
                { 
                    return IsSetNetGrossInd();
                }
                
                public bool IsSetNetGrossInd() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NetGrossInd);
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

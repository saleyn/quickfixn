// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class BidResponse : Message
    {
            public const string MsgType = "l";

            public BidResponse() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("l"));
            }


            public QuickFix.FXCM.Fields.BidID BidID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidID val) 
            { 
                BidID = val;
            }
            
            public QuickFix.FXCM.Fields.BidID Get(QuickFix.FXCM.Fields.BidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidID val) 
            { 
                return IsSetBidID();
            }
            
            public bool IsSetBidID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidID);
            }
            
            public QuickFix.FXCM.Fields.ClientBidID ClientBidID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClientBidID val) 
            { 
                ClientBidID = val;
            }
            
            public QuickFix.FXCM.Fields.ClientBidID Get(QuickFix.FXCM.Fields.ClientBidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClientBidID val) 
            { 
                return IsSetClientBidID();
            }
            
            public bool IsSetClientBidID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClientBidID);
            }
            
            public QuickFix.FXCM.Fields.NoBidComponents NoBidComponents
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoBidComponents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoBidComponents val) 
            { 
                NoBidComponents = val;
            }
            
            public QuickFix.FXCM.Fields.NoBidComponents Get(QuickFix.FXCM.Fields.NoBidComponents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoBidComponents val) 
            { 
                return IsSetNoBidComponents();
            }
            
            public bool IsSetNoBidComponents() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoBidComponents);
            }
            
            public class NoBidComponentsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.Commission, QuickFix.FXCM.Fields.Tags.CommType, QuickFix.FXCM.Fields.Tags.CommCurrency, QuickFix.FXCM.Fields.Tags.FundRenewWaiv, QuickFix.FXCM.Fields.Tags.ListID, QuickFix.FXCM.Fields.Tags.Country, QuickFix.FXCM.Fields.Tags.Side, QuickFix.FXCM.Fields.Tags.Price, QuickFix.FXCM.Fields.Tags.PriceType, QuickFix.FXCM.Fields.Tags.FairValue, QuickFix.FXCM.Fields.Tags.NetGrossInd, QuickFix.FXCM.Fields.Tags.SettlType, QuickFix.FXCM.Fields.Tags.SettlDate, QuickFix.FXCM.Fields.Tags.TradingSessionID, QuickFix.FXCM.Fields.Tags.TradingSessionSubID, QuickFix.FXCM.Fields.Tags.Text, QuickFix.FXCM.Fields.Tags.EncodedTextLen, QuickFix.FXCM.Fields.Tags.EncodedText, 0};
            
                public NoBidComponentsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoBidComponents, QuickFix.FXCM.Fields.Tags.Commission, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBidComponentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.Commission Commission
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Commission();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Commission val) 
                { 
                    Commission = val;
                }
                
                public QuickFix.FXCM.Fields.Commission Get(QuickFix.FXCM.Fields.Commission val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Commission val) 
                { 
                    return IsSetCommission();
                }
                
                public bool IsSetCommission() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Commission);
                }
                
                public QuickFix.FXCM.Fields.CommType CommType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CommType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CommType val) 
                { 
                    CommType = val;
                }
                
                public QuickFix.FXCM.Fields.CommType Get(QuickFix.FXCM.Fields.CommType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CommType val) 
                { 
                    return IsSetCommType();
                }
                
                public bool IsSetCommType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CommType);
                }
                
                public QuickFix.FXCM.Fields.CommCurrency CommCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CommCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CommCurrency val) 
                { 
                    CommCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.CommCurrency Get(QuickFix.FXCM.Fields.CommCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CommCurrency val) 
                { 
                    return IsSetCommCurrency();
                }
                
                public bool IsSetCommCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CommCurrency);
                }
                
                public QuickFix.FXCM.Fields.FundRenewWaiv FundRenewWaiv
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FundRenewWaiv();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FundRenewWaiv val) 
                { 
                    FundRenewWaiv = val;
                }
                
                public QuickFix.FXCM.Fields.FundRenewWaiv Get(QuickFix.FXCM.Fields.FundRenewWaiv val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FundRenewWaiv val) 
                { 
                    return IsSetFundRenewWaiv();
                }
                
                public bool IsSetFundRenewWaiv() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FundRenewWaiv);
                }
                
                public QuickFix.FXCM.Fields.ListID ListID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ListID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ListID val) 
                { 
                    ListID = val;
                }
                
                public QuickFix.FXCM.Fields.ListID Get(QuickFix.FXCM.Fields.ListID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ListID val) 
                { 
                    return IsSetListID();
                }
                
                public bool IsSetListID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ListID);
                }
                
                public QuickFix.FXCM.Fields.Country Country
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Country();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Country val) 
                { 
                    Country = val;
                }
                
                public QuickFix.FXCM.Fields.Country Get(QuickFix.FXCM.Fields.Country val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Country val) 
                { 
                    return IsSetCountry();
                }
                
                public bool IsSetCountry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Country);
                }
                
                public QuickFix.FXCM.Fields.Side Side
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Side val) 
                { 
                    Side = val;
                }
                
                public QuickFix.FXCM.Fields.Side Get(QuickFix.FXCM.Fields.Side val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Side val) 
                { 
                    return IsSetSide();
                }
                
                public bool IsSetSide() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Side);
                }
                
                public QuickFix.FXCM.Fields.Price Price
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Price();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Price val) 
                { 
                    Price = val;
                }
                
                public QuickFix.FXCM.Fields.Price Get(QuickFix.FXCM.Fields.Price val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Price val) 
                { 
                    return IsSetPrice();
                }
                
                public bool IsSetPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Price);
                }
                
                public QuickFix.FXCM.Fields.PriceType PriceType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PriceType val) 
                { 
                    PriceType = val;
                }
                
                public QuickFix.FXCM.Fields.PriceType Get(QuickFix.FXCM.Fields.PriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PriceType val) 
                { 
                    return IsSetPriceType();
                }
                
                public bool IsSetPriceType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PriceType);
                }
                
                public QuickFix.FXCM.Fields.FairValue FairValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FairValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FairValue val) 
                { 
                    FairValue = val;
                }
                
                public QuickFix.FXCM.Fields.FairValue Get(QuickFix.FXCM.Fields.FairValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FairValue val) 
                { 
                    return IsSetFairValue();
                }
                
                public bool IsSetFairValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FairValue);
                }
                
                public QuickFix.FXCM.Fields.NetGrossInd NetGrossInd
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NetGrossInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NetGrossInd val) 
                { 
                    NetGrossInd = val;
                }
                
                public QuickFix.FXCM.Fields.NetGrossInd Get(QuickFix.FXCM.Fields.NetGrossInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NetGrossInd val) 
                { 
                    return IsSetNetGrossInd();
                }
                
                public bool IsSetNetGrossInd() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NetGrossInd);
                }
                
                public QuickFix.FXCM.Fields.SettlType SettlType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SettlType val) 
                { 
                    SettlType = val;
                }
                
                public QuickFix.FXCM.Fields.SettlType Get(QuickFix.FXCM.Fields.SettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SettlType val) 
                { 
                    return IsSetSettlType();
                }
                
                public bool IsSetSettlType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SettlType);
                }
                
                public QuickFix.FXCM.Fields.SettlDate SettlDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SettlDate val) 
                { 
                    SettlDate = val;
                }
                
                public QuickFix.FXCM.Fields.SettlDate Get(QuickFix.FXCM.Fields.SettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SettlDate val) 
                { 
                    return IsSetSettlDate();
                }
                
                public bool IsSetSettlDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SettlDate);
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
                
            
            }
    }
}

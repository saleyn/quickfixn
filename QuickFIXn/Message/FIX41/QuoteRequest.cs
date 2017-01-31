// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class QuoteRequest : Message
    {
            public const string MsgType = "R";

            public QuoteRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("R"));
            }

            public QuoteRequest(
                    QuickFix.Fields.QuoteReqID aQuoteReqID,
                    QuickFix.Fields.Symbol aSymbol
                ) : this()
            {
                this.QuoteReqID = aQuoteReqID;
                this.Symbol = aSymbol;
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
            
            public QuickFix.Fields.PrevClosePx PrevClosePx
            { 
                get 
                {
                    var val = new QuickFix.Fields.PrevClosePx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PrevClosePx val) 
            { 
                PrevClosePx = val;
            }
            
            public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PrevClosePx val) 
            { 
                return IsSetPrevClosePx();
            }
            
            public bool IsSetPrevClosePx() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PrevClosePx);
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
            
            public QuickFix.Fields.OrderQty OrderQty
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderQty val) 
            { 
                OrderQty = val;
            }
            
            public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderQty val) 
            { 
                return IsSetOrderQty();
            }
            
            public bool IsSetOrderQty() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderQty);
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
            

    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class Email : Message
    {
            public const string MsgType = "C";

            public Email() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("C"));
            }

            public Email(
                    QuickFix.Fields.EmailThreadID aEmailThreadID,
                    QuickFix.Fields.EmailType aEmailType,
                    QuickFix.Fields.Subject aSubject
                ) : this()
            {
                this.EmailThreadID = aEmailThreadID;
                this.EmailType = aEmailType;
                this.Subject = aSubject;
            }

            public QuickFix.Fields.EmailThreadID EmailThreadID
            { 
                get 
                {
                    var val = new QuickFix.Fields.EmailThreadID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EmailThreadID val) 
            { 
                EmailThreadID = val;
            }
            
            public QuickFix.Fields.EmailThreadID Get(QuickFix.Fields.EmailThreadID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EmailThreadID val) 
            { 
                return IsSetEmailThreadID();
            }
            
            public bool IsSetEmailThreadID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EmailThreadID);
            }
            
            public QuickFix.Fields.EmailType EmailType
            { 
                get 
                {
                    var val = new QuickFix.Fields.EmailType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EmailType val) 
            { 
                EmailType = val;
            }
            
            public QuickFix.Fields.EmailType Get(QuickFix.Fields.EmailType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EmailType val) 
            { 
                return IsSetEmailType();
            }
            
            public bool IsSetEmailType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EmailType);
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
            
            public QuickFix.Fields.Subject Subject
            { 
                get 
                {
                    var val = new QuickFix.Fields.Subject();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Subject val) 
            { 
                Subject = val;
            }
            
            public QuickFix.Fields.Subject Get(QuickFix.Fields.Subject val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Subject val) 
            { 
                return IsSetSubject();
            }
            
            public bool IsSetSubject() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Subject);
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
            
            public QuickFix.Fields.OrderID OrderID
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderID val) 
            { 
                OrderID = val;
            }
            
            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderID);
            }
            
            public QuickFix.Fields.ClOrdID ClOrdID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdID val) 
            { 
                ClOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClOrdID);
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
            
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatdSym, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.IDSource, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDay, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.SecurityDesc, 0};
            
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
                
            
            }
            public class LinesOfTextGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Text, 0};
            
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
                
            
            }
    }
}

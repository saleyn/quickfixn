// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class IndicationofInterest : Message
    {
            public const string MsgType = "6";

            public IndicationofInterest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("6"));
            }

            public IndicationofInterest(
                    QuickFix.Fields.IOIid aIOIid,
                    QuickFix.Fields.IOITransType aIOITransType,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.IOIShares aIOIShares
                ) : this()
            {
                this.IOIid = aIOIid;
                this.IOITransType = aIOITransType;
                this.Symbol = aSymbol;
                this.Side = aSide;
                this.IOIShares = aIOIShares;
            }

            public QuickFix.Fields.IOIid IOIid
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOIid();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIid val) 
            { 
                IOIid = val;
            }
            
            public QuickFix.Fields.IOIid Get(QuickFix.Fields.IOIid val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIid val) 
            { 
                return IsSetIOIid();
            }
            
            public bool IsSetIOIid() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOIid);
            }
            
            public QuickFix.Fields.IOITransType IOITransType
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOITransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOITransType val) 
            { 
                IOITransType = val;
            }
            
            public QuickFix.Fields.IOITransType Get(QuickFix.Fields.IOITransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOITransType val) 
            { 
                return IsSetIOITransType();
            }
            
            public bool IsSetIOITransType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOITransType);
            }
            
            public QuickFix.Fields.IOIRefID IOIRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOIRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIRefID val) 
            { 
                IOIRefID = val;
            }
            
            public QuickFix.Fields.IOIRefID Get(QuickFix.Fields.IOIRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIRefID val) 
            { 
                return IsSetIOIRefID();
            }
            
            public bool IsSetIOIRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOIRefID);
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
            
            public QuickFix.Fields.IOIShares IOIShares
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOIShares();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIShares val) 
            { 
                IOIShares = val;
            }
            
            public QuickFix.Fields.IOIShares Get(QuickFix.Fields.IOIShares val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIShares val) 
            { 
                return IsSetIOIShares();
            }
            
            public bool IsSetIOIShares() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOIShares);
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
            
            public QuickFix.Fields.IOIQltyInd IOIQltyInd
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOIQltyInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIQltyInd val) 
            { 
                IOIQltyInd = val;
            }
            
            public QuickFix.Fields.IOIQltyInd Get(QuickFix.Fields.IOIQltyInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIQltyInd val) 
            { 
                return IsSetIOIQltyInd();
            }
            
            public bool IsSetIOIQltyInd() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOIQltyInd);
            }
            
            public QuickFix.Fields.IOIOthSvc IOIOthSvc
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOIOthSvc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIOthSvc val) 
            { 
                IOIOthSvc = val;
            }
            
            public QuickFix.Fields.IOIOthSvc Get(QuickFix.Fields.IOIOthSvc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIOthSvc val) 
            { 
                return IsSetIOIOthSvc();
            }
            
            public bool IsSetIOIOthSvc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOIOthSvc);
            }
            
            public QuickFix.Fields.IOINaturalFlag IOINaturalFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOINaturalFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOINaturalFlag val) 
            { 
                IOINaturalFlag = val;
            }
            
            public QuickFix.Fields.IOINaturalFlag Get(QuickFix.Fields.IOINaturalFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOINaturalFlag val) 
            { 
                return IsSetIOINaturalFlag();
            }
            
            public bool IsSetIOINaturalFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOINaturalFlag);
            }
            
            public QuickFix.Fields.IOIQualifier IOIQualifier
            { 
                get 
                {
                    var val = new QuickFix.Fields.IOIQualifier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIQualifier val) 
            { 
                IOIQualifier = val;
            }
            
            public QuickFix.Fields.IOIQualifier Get(QuickFix.Fields.IOIQualifier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIQualifier val) 
            { 
                return IsSetIOIQualifier();
            }
            
            public bool IsSetIOIQualifier() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IOIQualifier);
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

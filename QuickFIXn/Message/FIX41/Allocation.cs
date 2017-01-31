// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class Allocation : Message
    {
            public const string MsgType = "J";

            public Allocation() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("J"));
            }

            public Allocation(
                    QuickFix.Fields.AllocID aAllocID,
                    QuickFix.Fields.AllocTransType aAllocTransType,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Shares aShares,
                    QuickFix.Fields.AvgPx aAvgPx,
                    QuickFix.Fields.TradeDate aTradeDate
                ) : this()
            {
                this.AllocID = aAllocID;
                this.AllocTransType = aAllocTransType;
                this.Side = aSide;
                this.Symbol = aSymbol;
                this.Shares = aShares;
                this.AvgPx = aAvgPx;
                this.TradeDate = aTradeDate;
            }

            public QuickFix.Fields.AllocID AllocID
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocID val) 
            { 
                AllocID = val;
            }
            
            public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocID);
            }
            
            public QuickFix.Fields.AllocTransType AllocTransType
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocTransType val) 
            { 
                AllocTransType = val;
            }
            
            public QuickFix.Fields.AllocTransType Get(QuickFix.Fields.AllocTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocTransType val) 
            { 
                return IsSetAllocTransType();
            }
            
            public bool IsSetAllocTransType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocTransType);
            }
            
            public QuickFix.Fields.RefAllocID RefAllocID
            { 
                get 
                {
                    var val = new QuickFix.Fields.RefAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefAllocID val) 
            { 
                RefAllocID = val;
            }
            
            public QuickFix.Fields.RefAllocID Get(QuickFix.Fields.RefAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefAllocID val) 
            { 
                return IsSetRefAllocID();
            }
            
            public bool IsSetRefAllocID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RefAllocID);
            }
            
            public QuickFix.Fields.AllocLinkID AllocLinkID
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocLinkID val) 
            { 
                AllocLinkID = val;
            }
            
            public QuickFix.Fields.AllocLinkID Get(QuickFix.Fields.AllocLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocLinkID val) 
            { 
                return IsSetAllocLinkID();
            }
            
            public bool IsSetAllocLinkID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocLinkID);
            }
            
            public QuickFix.Fields.AllocLinkType AllocLinkType
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocLinkType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocLinkType val) 
            { 
                AllocLinkType = val;
            }
            
            public QuickFix.Fields.AllocLinkType Get(QuickFix.Fields.AllocLinkType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocLinkType val) 
            { 
                return IsSetAllocLinkType();
            }
            
            public bool IsSetAllocLinkType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocLinkType);
            }
            
            public QuickFix.Fields.NoOrders NoOrders
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrders val) 
            { 
                NoOrders = val;
            }
            
            public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoOrders);
            }
            
            public QuickFix.Fields.NoExecs NoExecs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoExecs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoExecs val) 
            { 
                NoExecs = val;
            }
            
            public QuickFix.Fields.NoExecs Get(QuickFix.Fields.NoExecs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoExecs val) 
            { 
                return IsSetNoExecs();
            }
            
            public bool IsSetNoExecs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoExecs);
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
            
            public QuickFix.Fields.Shares Shares
            { 
                get 
                {
                    var val = new QuickFix.Fields.Shares();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Shares val) 
            { 
                Shares = val;
            }
            
            public QuickFix.Fields.Shares Get(QuickFix.Fields.Shares val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Shares val) 
            { 
                return IsSetShares();
            }
            
            public bool IsSetShares() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Shares);
            }
            
            public QuickFix.Fields.LastMkt LastMkt
            { 
                get 
                {
                    var val = new QuickFix.Fields.LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastMkt val) 
            { 
                LastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LastMkt);
            }
            
            public QuickFix.Fields.AvgPx AvgPx
            { 
                get 
                {
                    var val = new QuickFix.Fields.AvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AvgPx val) 
            { 
                AvgPx = val;
            }
            
            public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AvgPx val) 
            { 
                return IsSetAvgPx();
            }
            
            public bool IsSetAvgPx() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AvgPx);
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
            
            public QuickFix.Fields.AvgPrxPrecision AvgPrxPrecision
            { 
                get 
                {
                    var val = new QuickFix.Fields.AvgPrxPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AvgPrxPrecision val) 
            { 
                AvgPrxPrecision = val;
            }
            
            public QuickFix.Fields.AvgPrxPrecision Get(QuickFix.Fields.AvgPrxPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AvgPrxPrecision val) 
            { 
                return IsSetAvgPrxPrecision();
            }
            
            public bool IsSetAvgPrxPrecision() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AvgPrxPrecision);
            }
            
            public QuickFix.Fields.TradeDate TradeDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                TradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeDate);
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
            
            public QuickFix.Fields.SettlmntTyp SettlmntTyp
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlmntTyp();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlmntTyp val) 
            { 
                SettlmntTyp = val;
            }
            
            public QuickFix.Fields.SettlmntTyp Get(QuickFix.Fields.SettlmntTyp val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlmntTyp val) 
            { 
                return IsSetSettlmntTyp();
            }
            
            public bool IsSetSettlmntTyp() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlmntTyp);
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
            
            public QuickFix.Fields.NetMoney NetMoney
            { 
                get 
                {
                    var val = new QuickFix.Fields.NetMoney();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetMoney val) 
            { 
                NetMoney = val;
            }
            
            public QuickFix.Fields.NetMoney Get(QuickFix.Fields.NetMoney val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetMoney val) 
            { 
                return IsSetNetMoney();
            }
            
            public bool IsSetNetMoney() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NetMoney);
            }
            
            public QuickFix.Fields.OpenClose OpenClose
            { 
                get 
                {
                    var val = new QuickFix.Fields.OpenClose();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OpenClose val) 
            { 
                OpenClose = val;
            }
            
            public QuickFix.Fields.OpenClose Get(QuickFix.Fields.OpenClose val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OpenClose val) 
            { 
                return IsSetOpenClose();
            }
            
            public bool IsSetOpenClose() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OpenClose);
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
            
            public QuickFix.Fields.NumDaysInterest NumDaysInterest
            { 
                get 
                {
                    var val = new QuickFix.Fields.NumDaysInterest();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumDaysInterest val) 
            { 
                NumDaysInterest = val;
            }
            
            public QuickFix.Fields.NumDaysInterest Get(QuickFix.Fields.NumDaysInterest val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumDaysInterest val) 
            { 
                return IsSetNumDaysInterest();
            }
            
            public bool IsSetNumDaysInterest() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NumDaysInterest);
            }
            
            public QuickFix.Fields.AccruedInterestRate AccruedInterestRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.AccruedInterestRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccruedInterestRate val) 
            { 
                AccruedInterestRate = val;
            }
            
            public QuickFix.Fields.AccruedInterestRate Get(QuickFix.Fields.AccruedInterestRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccruedInterestRate val) 
            { 
                return IsSetAccruedInterestRate();
            }
            
            public bool IsSetAccruedInterestRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AccruedInterestRate);
            }
            
            public QuickFix.Fields.NoAllocs NoAllocs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoAllocs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoAllocs val) 
            { 
                NoAllocs = val;
            }
            
            public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoAllocs val) 
            { 
                return IsSetNoAllocs();
            }
            
            public bool IsSetNoAllocs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoAllocs);
            }
            
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.ClOrdID, QuickFix.Fields.Tags.OrderID, QuickFix.Fields.Tags.SecondaryOrderID, QuickFix.Fields.Tags.ListID, QuickFix.Fields.Tags.WaveNo, 0};
            
                public NoOrdersGroup() 
                  :base( QuickFix.Fields.Tags.NoOrders, QuickFix.Fields.Tags.ClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryOrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    SecondaryOrderID = val;
                }
                
                public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryOrderID val) 
                { 
                    return IsSetSecondaryOrderID();
                }
                
                public bool IsSetSecondaryOrderID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryOrderID);
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
                
                public QuickFix.Fields.WaveNo WaveNo
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.WaveNo();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.WaveNo val) 
                { 
                    WaveNo = val;
                }
                
                public QuickFix.Fields.WaveNo Get(QuickFix.Fields.WaveNo val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.WaveNo val) 
                { 
                    return IsSetWaveNo();
                }
                
                public bool IsSetWaveNo() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.WaveNo);
                }
                
            
            }
            public class NoExecsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.LastShares, QuickFix.Fields.Tags.ExecID, QuickFix.Fields.Tags.LastPx, QuickFix.Fields.Tags.LastCapacity, 0};
            
                public NoExecsGroup() 
                  :base( QuickFix.Fields.Tags.NoExecs, QuickFix.Fields.Tags.LastShares, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoExecsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LastShares LastShares
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LastShares();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LastShares val) 
                { 
                    LastShares = val;
                }
                
                public QuickFix.Fields.LastShares Get(QuickFix.Fields.LastShares val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LastShares val) 
                { 
                    return IsSetLastShares();
                }
                
                public bool IsSetLastShares() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LastShares);
                }
                
                public QuickFix.Fields.ExecID ExecID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExecID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecID val) 
                { 
                    ExecID = val;
                }
                
                public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecID val) 
                { 
                    return IsSetExecID();
                }
                
                public bool IsSetExecID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExecID);
                }
                
                public QuickFix.Fields.LastPx LastPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LastPx val) 
                { 
                    LastPx = val;
                }
                
                public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LastPx val) 
                { 
                    return IsSetLastPx();
                }
                
                public bool IsSetLastPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LastPx);
                }
                
                public QuickFix.Fields.LastCapacity LastCapacity
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LastCapacity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LastCapacity val) 
                { 
                    LastCapacity = val;
                }
                
                public QuickFix.Fields.LastCapacity Get(QuickFix.Fields.LastCapacity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LastCapacity val) 
                { 
                    return IsSetLastCapacity();
                }
                
                public bool IsSetLastCapacity() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LastCapacity);
                }
                
            
            }
            public class NoAllocsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.AllocAccount, QuickFix.Fields.Tags.AllocShares, QuickFix.Fields.Tags.ProcessCode, QuickFix.Fields.Tags.BrokerOfCredit, QuickFix.Fields.Tags.NotifyBrokerOfCredit, QuickFix.Fields.Tags.AllocHandlInst, QuickFix.Fields.Tags.AllocText, QuickFix.Fields.Tags.ExecBroker, QuickFix.Fields.Tags.ClientID, QuickFix.Fields.Tags.Commission, QuickFix.Fields.Tags.CommType, QuickFix.Fields.Tags.AllocAvgPx, QuickFix.Fields.Tags.AllocNetMoney, QuickFix.Fields.Tags.SettlCurrAmt, QuickFix.Fields.Tags.SettlCurrency, QuickFix.Fields.Tags.SettlCurrFxRate, QuickFix.Fields.Tags.SettlCurrFxRateCalc, QuickFix.Fields.Tags.AccruedInterestAmt, QuickFix.Fields.Tags.SettlInstMode, QuickFix.Fields.Tags.NoMiscFees, 0};
            
                public NoAllocsGroup() 
                  :base( QuickFix.Fields.Tags.NoAllocs, QuickFix.Fields.Tags.AllocAccount, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoAllocsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.AllocAccount AllocAccount
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocAccount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocAccount val) 
                { 
                    AllocAccount = val;
                }
                
                public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocAccount val) 
                { 
                    return IsSetAllocAccount();
                }
                
                public bool IsSetAllocAccount() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocAccount);
                }
                
                public QuickFix.Fields.AllocShares AllocShares
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocShares();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocShares val) 
                { 
                    AllocShares = val;
                }
                
                public QuickFix.Fields.AllocShares Get(QuickFix.Fields.AllocShares val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocShares val) 
                { 
                    return IsSetAllocShares();
                }
                
                public bool IsSetAllocShares() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocShares);
                }
                
                public QuickFix.Fields.ProcessCode ProcessCode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ProcessCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProcessCode val) 
                { 
                    ProcessCode = val;
                }
                
                public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProcessCode val) 
                { 
                    return IsSetProcessCode();
                }
                
                public bool IsSetProcessCode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ProcessCode);
                }
                
                public QuickFix.Fields.BrokerOfCredit BrokerOfCredit
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BrokerOfCredit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BrokerOfCredit val) 
                { 
                    BrokerOfCredit = val;
                }
                
                public QuickFix.Fields.BrokerOfCredit Get(QuickFix.Fields.BrokerOfCredit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BrokerOfCredit val) 
                { 
                    return IsSetBrokerOfCredit();
                }
                
                public bool IsSetBrokerOfCredit() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BrokerOfCredit);
                }
                
                public QuickFix.Fields.NotifyBrokerOfCredit NotifyBrokerOfCredit
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NotifyBrokerOfCredit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NotifyBrokerOfCredit val) 
                { 
                    NotifyBrokerOfCredit = val;
                }
                
                public QuickFix.Fields.NotifyBrokerOfCredit Get(QuickFix.Fields.NotifyBrokerOfCredit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NotifyBrokerOfCredit val) 
                { 
                    return IsSetNotifyBrokerOfCredit();
                }
                
                public bool IsSetNotifyBrokerOfCredit() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NotifyBrokerOfCredit);
                }
                
                public QuickFix.Fields.AllocHandlInst AllocHandlInst
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocHandlInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocHandlInst val) 
                { 
                    AllocHandlInst = val;
                }
                
                public QuickFix.Fields.AllocHandlInst Get(QuickFix.Fields.AllocHandlInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocHandlInst val) 
                { 
                    return IsSetAllocHandlInst();
                }
                
                public bool IsSetAllocHandlInst() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocHandlInst);
                }
                
                public QuickFix.Fields.AllocText AllocText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocText val) 
                { 
                    AllocText = val;
                }
                
                public QuickFix.Fields.AllocText Get(QuickFix.Fields.AllocText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocText val) 
                { 
                    return IsSetAllocText();
                }
                
                public bool IsSetAllocText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocText);
                }
                
                public QuickFix.Fields.ExecBroker ExecBroker
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExecBroker();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecBroker val) 
                { 
                    ExecBroker = val;
                }
                
                public QuickFix.Fields.ExecBroker Get(QuickFix.Fields.ExecBroker val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecBroker val) 
                { 
                    return IsSetExecBroker();
                }
                
                public bool IsSetExecBroker() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExecBroker);
                }
                
                public QuickFix.Fields.ClientID ClientID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ClientID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClientID val) 
                { 
                    ClientID = val;
                }
                
                public QuickFix.Fields.ClientID Get(QuickFix.Fields.ClientID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClientID val) 
                { 
                    return IsSetClientID();
                }
                
                public bool IsSetClientID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ClientID);
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
                
                public QuickFix.Fields.AllocAvgPx AllocAvgPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocAvgPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocAvgPx val) 
                { 
                    AllocAvgPx = val;
                }
                
                public QuickFix.Fields.AllocAvgPx Get(QuickFix.Fields.AllocAvgPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocAvgPx val) 
                { 
                    return IsSetAllocAvgPx();
                }
                
                public bool IsSetAllocAvgPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocAvgPx);
                }
                
                public QuickFix.Fields.AllocNetMoney AllocNetMoney
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocNetMoney();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocNetMoney val) 
                { 
                    AllocNetMoney = val;
                }
                
                public QuickFix.Fields.AllocNetMoney Get(QuickFix.Fields.AllocNetMoney val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocNetMoney val) 
                { 
                    return IsSetAllocNetMoney();
                }
                
                public bool IsSetAllocNetMoney() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocNetMoney);
                }
                
                public QuickFix.Fields.SettlCurrAmt SettlCurrAmt
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlCurrAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    SettlCurrAmt = val;
                }
                
                public QuickFix.Fields.SettlCurrAmt Get(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    return IsSetSettlCurrAmt();
                }
                
                public bool IsSetSettlCurrAmt() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlCurrAmt);
                }
                
                public QuickFix.Fields.SettlCurrency SettlCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrency val) 
                { 
                    SettlCurrency = val;
                }
                
                public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrency val) 
                { 
                    return IsSetSettlCurrency();
                }
                
                public bool IsSetSettlCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlCurrency);
                }
                
                public QuickFix.Fields.SettlCurrFxRate SettlCurrFxRate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlCurrFxRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    SettlCurrFxRate = val;
                }
                
                public QuickFix.Fields.SettlCurrFxRate Get(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    return IsSetSettlCurrFxRate();
                }
                
                public bool IsSetSettlCurrFxRate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlCurrFxRate);
                }
                
                public QuickFix.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlCurrFxRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrFxRateCalc val) 
                { 
                    SettlCurrFxRateCalc = val;
                }
                
                public QuickFix.Fields.SettlCurrFxRateCalc Get(QuickFix.Fields.SettlCurrFxRateCalc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrFxRateCalc val) 
                { 
                    return IsSetSettlCurrFxRateCalc();
                }
                
                public bool IsSetSettlCurrFxRateCalc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlCurrFxRateCalc);
                }
                
                public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AccruedInterestAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AccruedInterestAmt val) 
                { 
                    AccruedInterestAmt = val;
                }
                
                public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AccruedInterestAmt val) 
                { 
                    return IsSetAccruedInterestAmt();
                }
                
                public bool IsSetAccruedInterestAmt() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AccruedInterestAmt);
                }
                
                public QuickFix.Fields.SettlInstMode SettlInstMode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlInstMode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlInstMode val) 
                { 
                    SettlInstMode = val;
                }
                
                public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlInstMode val) 
                { 
                    return IsSetSettlInstMode();
                }
                
                public bool IsSetSettlInstMode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlInstMode);
                }
                
                public QuickFix.Fields.NoMiscFees NoMiscFees
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoMiscFees();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoMiscFees val) 
                { 
                    NoMiscFees = val;
                }
                
                public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoMiscFees val) 
                { 
                    return IsSetNoMiscFees();
                }
                
                public bool IsSetNoMiscFees() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoMiscFees);
                }
                
                            public class NoMiscFeesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.MiscFeeAmt, QuickFix.Fields.Tags.MiscFeeCurr, QuickFix.Fields.Tags.MiscFeeType, 0};
                
                    public NoMiscFeesGroup() 
                      :base( QuickFix.Fields.Tags.NoMiscFees, QuickFix.Fields.Tags.MiscFeeAmt, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoMiscFeesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MiscFeeAmt();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MiscFeeAmt val) 
                    { 
                        MiscFeeAmt = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MiscFeeAmt val) 
                    { 
                        return IsSetMiscFeeAmt();
                    }
                    
                    public bool IsSetMiscFeeAmt() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MiscFeeAmt);
                    }
                    
                    public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MiscFeeCurr();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MiscFeeCurr val) 
                    { 
                        MiscFeeCurr = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MiscFeeCurr val) 
                    { 
                        return IsSetMiscFeeCurr();
                    }
                    
                    public bool IsSetMiscFeeCurr() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MiscFeeCurr);
                    }
                    
                    public QuickFix.Fields.MiscFeeType MiscFeeType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MiscFeeType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MiscFeeType val) 
                    { 
                        MiscFeeType = val;
                    }
                    
                    public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MiscFeeType val) 
                    { 
                        return IsSetMiscFeeType();
                    }
                    
                    public bool IsSetMiscFeeType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MiscFeeType);
                    }
                    
                
                }
            }
    }
}

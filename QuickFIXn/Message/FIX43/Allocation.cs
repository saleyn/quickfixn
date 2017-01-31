// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX43
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
                    QuickFix.Fields.AllocType aAllocType,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Quantity aQuantity,
                    QuickFix.Fields.AvgPx aAvgPx,
                    QuickFix.Fields.TradeDate aTradeDate
                ) : this()
            {
                this.AllocID = aAllocID;
                this.AllocTransType = aAllocTransType;
                this.AllocType = aAllocType;
                this.Side = aSide;
                this.Symbol = aSymbol;
                this.Quantity = aQuantity;
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
            
            public QuickFix.Fields.AllocType AllocType
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocType val) 
            { 
                AllocType = val;
            }
            
            public QuickFix.Fields.AllocType Get(QuickFix.Fields.AllocType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocType val) 
            { 
                return IsSetAllocType();
            }
            
            public bool IsSetAllocType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocType);
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
            
            public QuickFix.Fields.BookingRefID BookingRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.BookingRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BookingRefID val) 
            { 
                BookingRefID = val;
            }
            
            public QuickFix.Fields.BookingRefID Get(QuickFix.Fields.BookingRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BookingRefID val) 
            { 
                return IsSetBookingRefID();
            }
            
            public bool IsSetBookingRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BookingRefID);
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
            
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                SecurityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityIDSource);
            }
            
            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                NoSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoSecurityAltID);
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
            
            public QuickFix.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                MaturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaturityDate);
            }
            
            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                CouponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CouponPaymentDate);
            }
            
            public QuickFix.Fields.IssueDate IssueDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                IssueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IssueDate);
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                RepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepoCollateralSecurityType);
            }
            
            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                RepurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepurchaseTerm);
            }
            
            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                RepurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepurchaseRate);
            }
            
            public QuickFix.Fields.Factor Factor
            { 
                get 
                {
                    var val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                Factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Factor);
            }
            
            public QuickFix.Fields.CreditRating CreditRating
            { 
                get 
                {
                    var val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                CreditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CreditRating);
            }
            
            public QuickFix.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                InstrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(QuickFix.Fields.Tags.InstrRegistry);
            }
            
            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                CountryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CountryOfIssue);
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StateOrProvinceOfIssue);
            }
            
            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                LocaleOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LocaleOfIssue);
            }
            
            public QuickFix.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                RedemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RedemptionDate);
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
            
            public QuickFix.Fields.Quantity Quantity
            { 
                get 
                {
                    var val = new QuickFix.Fields.Quantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Quantity val) 
            { 
                Quantity = val;
            }
            
            public QuickFix.Fields.Quantity Get(QuickFix.Fields.Quantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Quantity val) 
            { 
                return IsSetQuantity();
            }
            
            public bool IsSetQuantity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Quantity);
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
            
            public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeOriginationDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeOriginationDate val) 
            { 
                TradeOriginationDate = val;
            }
            
            public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeOriginationDate val) 
            { 
                return IsSetTradeOriginationDate();
            }
            
            public bool IsSetTradeOriginationDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeOriginationDate);
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
            
            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyIDs val) 
            { 
                NoPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoPartyIDs);
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
            
            public QuickFix.Fields.GrossTradeAmt GrossTradeAmt
            { 
                get 
                {
                    var val = new QuickFix.Fields.GrossTradeAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GrossTradeAmt val) 
            { 
                GrossTradeAmt = val;
            }
            
            public QuickFix.Fields.GrossTradeAmt Get(QuickFix.Fields.GrossTradeAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GrossTradeAmt val) 
            { 
                return IsSetGrossTradeAmt();
            }
            
            public bool IsSetGrossTradeAmt() 
            { 
                return IsSetField(QuickFix.Fields.Tags.GrossTradeAmt);
            }
            
            public QuickFix.Fields.Concession Concession
            { 
                get 
                {
                    var val = new QuickFix.Fields.Concession();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Concession val) 
            { 
                Concession = val;
            }
            
            public QuickFix.Fields.Concession Get(QuickFix.Fields.Concession val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Concession val) 
            { 
                return IsSetConcession();
            }
            
            public bool IsSetConcession() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Concession);
            }
            
            public QuickFix.Fields.TotalTakedown TotalTakedown
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotalTakedown();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalTakedown val) 
            { 
                TotalTakedown = val;
            }
            
            public QuickFix.Fields.TotalTakedown Get(QuickFix.Fields.TotalTakedown val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalTakedown val) 
            { 
                return IsSetTotalTakedown();
            }
            
            public bool IsSetTotalTakedown() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotalTakedown);
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
            
            public QuickFix.Fields.PositionEffect PositionEffect
            { 
                get 
                {
                    var val = new QuickFix.Fields.PositionEffect();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionEffect val) 
            { 
                PositionEffect = val;
            }
            
            public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionEffect val) 
            { 
                return IsSetPositionEffect();
            }
            
            public bool IsSetPositionEffect() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PositionEffect);
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
            
            public QuickFix.Fields.TotalAccruedInterestAmt TotalAccruedInterestAmt
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotalAccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalAccruedInterestAmt val) 
            { 
                TotalAccruedInterestAmt = val;
            }
            
            public QuickFix.Fields.TotalAccruedInterestAmt Get(QuickFix.Fields.TotalAccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalAccruedInterestAmt val) 
            { 
                return IsSetTotalAccruedInterestAmt();
            }
            
            public bool IsSetTotalAccruedInterestAmt() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotalAccruedInterestAmt);
            }
            
            public QuickFix.Fields.LegalConfirm LegalConfirm
            { 
                get 
                {
                    var val = new QuickFix.Fields.LegalConfirm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LegalConfirm val) 
            { 
                LegalConfirm = val;
            }
            
            public QuickFix.Fields.LegalConfirm Get(QuickFix.Fields.LegalConfirm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LegalConfirm val) 
            { 
                return IsSetLegalConfirm();
            }
            
            public bool IsSetLegalConfirm() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LegalConfirm);
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
                public static int[] fieldOrder = {QuickFix.Fields.Tags.ClOrdID, QuickFix.Fields.Tags.OrderID, QuickFix.Fields.Tags.SecondaryOrderID, QuickFix.Fields.Tags.SecondaryClOrdID, QuickFix.Fields.Tags.ListID, 0};
            
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
                
                public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    SecondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return IsSetSecondaryClOrdID();
                }
                
                public bool IsSetSecondaryClOrdID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryClOrdID);
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
                
            
            }
            public class NoExecsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.LastQty, QuickFix.Fields.Tags.ExecID, QuickFix.Fields.Tags.SecondaryExecID, QuickFix.Fields.Tags.LastPx, QuickFix.Fields.Tags.LastCapacity, 0};
            
                public NoExecsGroup() 
                  :base( QuickFix.Fields.Tags.NoExecs, QuickFix.Fields.Tags.LastQty, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoExecsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LastQty LastQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LastQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LastQty val) 
                { 
                    LastQty = val;
                }
                
                public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LastQty val) 
                { 
                    return IsSetLastQty();
                }
                
                public bool IsSetLastQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LastQty);
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
                
                public QuickFix.Fields.SecondaryExecID SecondaryExecID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecondaryExecID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryExecID val) 
                { 
                    SecondaryExecID = val;
                }
                
                public QuickFix.Fields.SecondaryExecID Get(QuickFix.Fields.SecondaryExecID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryExecID val) 
                { 
                    return IsSetSecondaryExecID();
                }
                
                public bool IsSetSecondaryExecID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecondaryExecID);
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
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.SecurityAltID, QuickFix.Fields.Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    SecurityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityAltID);
                }
                
                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    SecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityAltIDSource);
                }
                
            
            }
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyID, QuickFix.Fields.Tags.PartyIDSource, QuickFix.Fields.Tags.PartyRole, QuickFix.Fields.Tags.PartySubID, 0};
            
                public NoPartyIDsGroup() 
                  :base( QuickFix.Fields.Tags.NoPartyIDs, QuickFix.Fields.Tags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.PartyID PartyID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    PartyID = val;
                }
                
                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartyID);
                }
                
                public QuickFix.Fields.PartyIDSource PartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyIDSource val) 
                { 
                    PartyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartyIDSource);
                }
                
                public QuickFix.Fields.PartyRole PartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRole val) 
                { 
                    PartyRole = val;
                }
                
                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartyRole);
                }
                
                public QuickFix.Fields.PartySubID PartySubID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PartySubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartySubID val) 
                { 
                    PartySubID = val;
                }
                
                public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartySubID val) 
                { 
                    return IsSetPartySubID();
                }
                
                public bool IsSetPartySubID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PartySubID);
                }
                
            
            }
            public class NoAllocsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.AllocAccount, QuickFix.Fields.Tags.AllocPrice, QuickFix.Fields.Tags.AllocQty, QuickFix.Fields.Tags.IndividualAllocID, QuickFix.Fields.Tags.ProcessCode, QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.NotifyBrokerOfCredit, QuickFix.Fields.Tags.AllocHandlInst, QuickFix.Fields.Tags.AllocText, QuickFix.Fields.Tags.EncodedAllocTextLen, QuickFix.Fields.Tags.EncodedAllocText, QuickFix.Fields.Tags.Commission, QuickFix.Fields.Tags.CommType, QuickFix.Fields.Tags.CommCurrency, QuickFix.Fields.Tags.FundRenewWaiv, QuickFix.Fields.Tags.AllocAvgPx, QuickFix.Fields.Tags.AllocNetMoney, QuickFix.Fields.Tags.SettlCurrAmt, QuickFix.Fields.Tags.SettlCurrency, QuickFix.Fields.Tags.SettlCurrFxRate, QuickFix.Fields.Tags.SettlCurrFxRateCalc, QuickFix.Fields.Tags.AccruedInterestAmt, QuickFix.Fields.Tags.SettlInstMode, QuickFix.Fields.Tags.NoMiscFees, 0};
            
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
                
                public QuickFix.Fields.AllocPrice AllocPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocPrice val) 
                { 
                    AllocPrice = val;
                }
                
                public QuickFix.Fields.AllocPrice Get(QuickFix.Fields.AllocPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocPrice val) 
                { 
                    return IsSetAllocPrice();
                }
                
                public bool IsSetAllocPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocPrice);
                }
                
                public QuickFix.Fields.AllocQty AllocQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocQty val) 
                { 
                    AllocQty = val;
                }
                
                public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocQty val) 
                { 
                    return IsSetAllocQty();
                }
                
                public bool IsSetAllocQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocQty);
                }
                
                public QuickFix.Fields.IndividualAllocID IndividualAllocID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.IndividualAllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IndividualAllocID val) 
                { 
                    IndividualAllocID = val;
                }
                
                public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
                { 
                    return IsSetIndividualAllocID();
                }
                
                public bool IsSetIndividualAllocID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.IndividualAllocID);
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
                
                public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    NoNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoNestedPartyIDs);
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
                
                public QuickFix.Fields.EncodedAllocTextLen EncodedAllocTextLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedAllocTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedAllocTextLen val) 
                { 
                    EncodedAllocTextLen = val;
                }
                
                public QuickFix.Fields.EncodedAllocTextLen Get(QuickFix.Fields.EncodedAllocTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedAllocTextLen val) 
                { 
                    return IsSetEncodedAllocTextLen();
                }
                
                public bool IsSetEncodedAllocTextLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedAllocTextLen);
                }
                
                public QuickFix.Fields.EncodedAllocText EncodedAllocText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedAllocText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedAllocText val) 
                { 
                    EncodedAllocText = val;
                }
                
                public QuickFix.Fields.EncodedAllocText Get(QuickFix.Fields.EncodedAllocText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedAllocText val) 
                { 
                    return IsSetEncodedAllocText();
                }
                
                public bool IsSetEncodedAllocText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedAllocText);
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
                
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartyID, QuickFix.Fields.Tags.NestedPartyIDSource, QuickFix.Fields.Tags.NestedPartyRole, QuickFix.Fields.Tags.NestedPartySubID, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        NestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyID);
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyIDSource);
                    }
                    
                    public QuickFix.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        NestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyRole);
                    }
                    
                    public QuickFix.Fields.NestedPartySubID NestedPartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartySubID val) 
                    { 
                        NestedPartySubID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                    { 
                        return IsSetNestedPartySubID();
                    }
                    
                    public bool IsSetNestedPartySubID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartySubID);
                    }
                    
                
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

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class BidRequest : Message
    {
            public const string MsgType = "k";

            public BidRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("k"));
            }

            public BidRequest(
                    QuickFix.FXCM.Fields.ClientBidID aClientBidID,
                    QuickFix.FXCM.Fields.BidRequestTransType aBidRequestTransType,
                    QuickFix.FXCM.Fields.TotNoRelatedSym aTotNoRelatedSym,
                    QuickFix.FXCM.Fields.BidType aBidType,
                    QuickFix.FXCM.Fields.BidTradeType aBidTradeType,
                    QuickFix.FXCM.Fields.BasisPxType aBasisPxType
                ) : this()
            {
                this.ClientBidID = aClientBidID;
                this.BidRequestTransType = aBidRequestTransType;
                this.TotNoRelatedSym = aTotNoRelatedSym;
                this.BidType = aBidType;
                this.BidTradeType = aBidTradeType;
                this.BasisPxType = aBasisPxType;
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
            
            public QuickFix.FXCM.Fields.BidRequestTransType BidRequestTransType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidRequestTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidRequestTransType val) 
            { 
                BidRequestTransType = val;
            }
            
            public QuickFix.FXCM.Fields.BidRequestTransType Get(QuickFix.FXCM.Fields.BidRequestTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidRequestTransType val) 
            { 
                return IsSetBidRequestTransType();
            }
            
            public bool IsSetBidRequestTransType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidRequestTransType);
            }
            
            public QuickFix.FXCM.Fields.ListName ListName
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ListName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ListName val) 
            { 
                ListName = val;
            }
            
            public QuickFix.FXCM.Fields.ListName Get(QuickFix.FXCM.Fields.ListName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ListName val) 
            { 
                return IsSetListName();
            }
            
            public bool IsSetListName() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ListName);
            }
            
            public QuickFix.FXCM.Fields.TotNoRelatedSym TotNoRelatedSym
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotNoRelatedSym val) 
            { 
                TotNoRelatedSym = val;
            }
            
            public QuickFix.FXCM.Fields.TotNoRelatedSym Get(QuickFix.FXCM.Fields.TotNoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotNoRelatedSym val) 
            { 
                return IsSetTotNoRelatedSym();
            }
            
            public bool IsSetTotNoRelatedSym() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotNoRelatedSym);
            }
            
            public QuickFix.FXCM.Fields.BidType BidType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidType val) 
            { 
                BidType = val;
            }
            
            public QuickFix.FXCM.Fields.BidType Get(QuickFix.FXCM.Fields.BidType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidType val) 
            { 
                return IsSetBidType();
            }
            
            public bool IsSetBidType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidType);
            }
            
            public QuickFix.FXCM.Fields.NumTickets NumTickets
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NumTickets();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NumTickets val) 
            { 
                NumTickets = val;
            }
            
            public QuickFix.FXCM.Fields.NumTickets Get(QuickFix.FXCM.Fields.NumTickets val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NumTickets val) 
            { 
                return IsSetNumTickets();
            }
            
            public bool IsSetNumTickets() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NumTickets);
            }
            
            public QuickFix.FXCM.Fields.Currency Currency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Currency val) 
            { 
                Currency = val;
            }
            
            public QuickFix.FXCM.Fields.Currency Get(QuickFix.FXCM.Fields.Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Currency);
            }
            
            public QuickFix.FXCM.Fields.SideValue1 SideValue1
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SideValue1();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SideValue1 val) 
            { 
                SideValue1 = val;
            }
            
            public QuickFix.FXCM.Fields.SideValue1 Get(QuickFix.FXCM.Fields.SideValue1 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SideValue1 val) 
            { 
                return IsSetSideValue1();
            }
            
            public bool IsSetSideValue1() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SideValue1);
            }
            
            public QuickFix.FXCM.Fields.SideValue2 SideValue2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SideValue2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SideValue2 val) 
            { 
                SideValue2 = val;
            }
            
            public QuickFix.FXCM.Fields.SideValue2 Get(QuickFix.FXCM.Fields.SideValue2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SideValue2 val) 
            { 
                return IsSetSideValue2();
            }
            
            public bool IsSetSideValue2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SideValue2);
            }
            
            public QuickFix.FXCM.Fields.NoBidDescriptors NoBidDescriptors
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoBidDescriptors();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoBidDescriptors val) 
            { 
                NoBidDescriptors = val;
            }
            
            public QuickFix.FXCM.Fields.NoBidDescriptors Get(QuickFix.FXCM.Fields.NoBidDescriptors val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoBidDescriptors val) 
            { 
                return IsSetNoBidDescriptors();
            }
            
            public bool IsSetNoBidDescriptors() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoBidDescriptors);
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
            
            public QuickFix.FXCM.Fields.LiquidityIndType LiquidityIndType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LiquidityIndType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LiquidityIndType val) 
            { 
                LiquidityIndType = val;
            }
            
            public QuickFix.FXCM.Fields.LiquidityIndType Get(QuickFix.FXCM.Fields.LiquidityIndType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LiquidityIndType val) 
            { 
                return IsSetLiquidityIndType();
            }
            
            public bool IsSetLiquidityIndType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LiquidityIndType);
            }
            
            public QuickFix.FXCM.Fields.WtAverageLiquidity WtAverageLiquidity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.WtAverageLiquidity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.WtAverageLiquidity val) 
            { 
                WtAverageLiquidity = val;
            }
            
            public QuickFix.FXCM.Fields.WtAverageLiquidity Get(QuickFix.FXCM.Fields.WtAverageLiquidity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.WtAverageLiquidity val) 
            { 
                return IsSetWtAverageLiquidity();
            }
            
            public bool IsSetWtAverageLiquidity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.WtAverageLiquidity);
            }
            
            public QuickFix.FXCM.Fields.ExchangeForPhysical ExchangeForPhysical
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExchangeForPhysical();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExchangeForPhysical val) 
            { 
                ExchangeForPhysical = val;
            }
            
            public QuickFix.FXCM.Fields.ExchangeForPhysical Get(QuickFix.FXCM.Fields.ExchangeForPhysical val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExchangeForPhysical val) 
            { 
                return IsSetExchangeForPhysical();
            }
            
            public bool IsSetExchangeForPhysical() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExchangeForPhysical);
            }
            
            public QuickFix.FXCM.Fields.OutMainCntryUIndex OutMainCntryUIndex
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OutMainCntryUIndex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OutMainCntryUIndex val) 
            { 
                OutMainCntryUIndex = val;
            }
            
            public QuickFix.FXCM.Fields.OutMainCntryUIndex Get(QuickFix.FXCM.Fields.OutMainCntryUIndex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OutMainCntryUIndex val) 
            { 
                return IsSetOutMainCntryUIndex();
            }
            
            public bool IsSetOutMainCntryUIndex() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OutMainCntryUIndex);
            }
            
            public QuickFix.FXCM.Fields.CrossPercent CrossPercent
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CrossPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CrossPercent val) 
            { 
                CrossPercent = val;
            }
            
            public QuickFix.FXCM.Fields.CrossPercent Get(QuickFix.FXCM.Fields.CrossPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CrossPercent val) 
            { 
                return IsSetCrossPercent();
            }
            
            public bool IsSetCrossPercent() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CrossPercent);
            }
            
            public QuickFix.FXCM.Fields.ProgRptReqs ProgRptReqs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ProgRptReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ProgRptReqs val) 
            { 
                ProgRptReqs = val;
            }
            
            public QuickFix.FXCM.Fields.ProgRptReqs Get(QuickFix.FXCM.Fields.ProgRptReqs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ProgRptReqs val) 
            { 
                return IsSetProgRptReqs();
            }
            
            public bool IsSetProgRptReqs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ProgRptReqs);
            }
            
            public QuickFix.FXCM.Fields.ProgPeriodInterval ProgPeriodInterval
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ProgPeriodInterval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ProgPeriodInterval val) 
            { 
                ProgPeriodInterval = val;
            }
            
            public QuickFix.FXCM.Fields.ProgPeriodInterval Get(QuickFix.FXCM.Fields.ProgPeriodInterval val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ProgPeriodInterval val) 
            { 
                return IsSetProgPeriodInterval();
            }
            
            public bool IsSetProgPeriodInterval() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ProgPeriodInterval);
            }
            
            public QuickFix.FXCM.Fields.IncTaxInd IncTaxInd
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.IncTaxInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.IncTaxInd val) 
            { 
                IncTaxInd = val;
            }
            
            public QuickFix.FXCM.Fields.IncTaxInd Get(QuickFix.FXCM.Fields.IncTaxInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.IncTaxInd val) 
            { 
                return IsSetIncTaxInd();
            }
            
            public bool IsSetIncTaxInd() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.IncTaxInd);
            }
            
            public QuickFix.FXCM.Fields.ForexReq ForexReq
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ForexReq();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ForexReq val) 
            { 
                ForexReq = val;
            }
            
            public QuickFix.FXCM.Fields.ForexReq Get(QuickFix.FXCM.Fields.ForexReq val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ForexReq val) 
            { 
                return IsSetForexReq();
            }
            
            public bool IsSetForexReq() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ForexReq);
            }
            
            public QuickFix.FXCM.Fields.NumBidders NumBidders
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NumBidders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NumBidders val) 
            { 
                NumBidders = val;
            }
            
            public QuickFix.FXCM.Fields.NumBidders Get(QuickFix.FXCM.Fields.NumBidders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NumBidders val) 
            { 
                return IsSetNumBidders();
            }
            
            public bool IsSetNumBidders() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NumBidders);
            }
            
            public QuickFix.FXCM.Fields.TradeDate TradeDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                TradeDate = val;
            }
            
            public QuickFix.FXCM.Fields.TradeDate Get(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradeDate);
            }
            
            public QuickFix.FXCM.Fields.BidTradeType BidTradeType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidTradeType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidTradeType val) 
            { 
                BidTradeType = val;
            }
            
            public QuickFix.FXCM.Fields.BidTradeType Get(QuickFix.FXCM.Fields.BidTradeType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidTradeType val) 
            { 
                return IsSetBidTradeType();
            }
            
            public bool IsSetBidTradeType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidTradeType);
            }
            
            public QuickFix.FXCM.Fields.BasisPxType BasisPxType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BasisPxType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BasisPxType val) 
            { 
                BasisPxType = val;
            }
            
            public QuickFix.FXCM.Fields.BasisPxType Get(QuickFix.FXCM.Fields.BasisPxType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BasisPxType val) 
            { 
                return IsSetBasisPxType();
            }
            
            public bool IsSetBasisPxType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BasisPxType);
            }
            
            public QuickFix.FXCM.Fields.StrikeTime StrikeTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikeTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikeTime val) 
            { 
                StrikeTime = val;
            }
            
            public QuickFix.FXCM.Fields.StrikeTime Get(QuickFix.FXCM.Fields.StrikeTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikeTime val) 
            { 
                return IsSetStrikeTime();
            }
            
            public bool IsSetStrikeTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikeTime);
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
            
            public class NoBidDescriptorsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.BidDescriptorType, QuickFix.FXCM.Fields.Tags.BidDescriptor, QuickFix.FXCM.Fields.Tags.SideValueInd, QuickFix.FXCM.Fields.Tags.LiquidityValue, QuickFix.FXCM.Fields.Tags.LiquidityNumSecurities, QuickFix.FXCM.Fields.Tags.LiquidityPctLow, QuickFix.FXCM.Fields.Tags.LiquidityPctHigh, QuickFix.FXCM.Fields.Tags.EFPTrackingError, QuickFix.FXCM.Fields.Tags.FairValue, QuickFix.FXCM.Fields.Tags.OutsideIndexPct, QuickFix.FXCM.Fields.Tags.ValueOfFutures, 0};
            
                public NoBidDescriptorsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoBidDescriptors, QuickFix.FXCM.Fields.Tags.BidDescriptorType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBidDescriptorsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.BidDescriptorType BidDescriptorType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.BidDescriptorType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.BidDescriptorType val) 
                { 
                    BidDescriptorType = val;
                }
                
                public QuickFix.FXCM.Fields.BidDescriptorType Get(QuickFix.FXCM.Fields.BidDescriptorType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.BidDescriptorType val) 
                { 
                    return IsSetBidDescriptorType();
                }
                
                public bool IsSetBidDescriptorType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.BidDescriptorType);
                }
                
                public QuickFix.FXCM.Fields.BidDescriptor BidDescriptor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.BidDescriptor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.BidDescriptor val) 
                { 
                    BidDescriptor = val;
                }
                
                public QuickFix.FXCM.Fields.BidDescriptor Get(QuickFix.FXCM.Fields.BidDescriptor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.BidDescriptor val) 
                { 
                    return IsSetBidDescriptor();
                }
                
                public bool IsSetBidDescriptor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.BidDescriptor);
                }
                
                public QuickFix.FXCM.Fields.SideValueInd SideValueInd
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SideValueInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SideValueInd val) 
                { 
                    SideValueInd = val;
                }
                
                public QuickFix.FXCM.Fields.SideValueInd Get(QuickFix.FXCM.Fields.SideValueInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SideValueInd val) 
                { 
                    return IsSetSideValueInd();
                }
                
                public bool IsSetSideValueInd() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SideValueInd);
                }
                
                public QuickFix.FXCM.Fields.LiquidityValue LiquidityValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LiquidityValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LiquidityValue val) 
                { 
                    LiquidityValue = val;
                }
                
                public QuickFix.FXCM.Fields.LiquidityValue Get(QuickFix.FXCM.Fields.LiquidityValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LiquidityValue val) 
                { 
                    return IsSetLiquidityValue();
                }
                
                public bool IsSetLiquidityValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LiquidityValue);
                }
                
                public QuickFix.FXCM.Fields.LiquidityNumSecurities LiquidityNumSecurities
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LiquidityNumSecurities();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LiquidityNumSecurities val) 
                { 
                    LiquidityNumSecurities = val;
                }
                
                public QuickFix.FXCM.Fields.LiquidityNumSecurities Get(QuickFix.FXCM.Fields.LiquidityNumSecurities val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LiquidityNumSecurities val) 
                { 
                    return IsSetLiquidityNumSecurities();
                }
                
                public bool IsSetLiquidityNumSecurities() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LiquidityNumSecurities);
                }
                
                public QuickFix.FXCM.Fields.LiquidityPctLow LiquidityPctLow
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LiquidityPctLow();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LiquidityPctLow val) 
                { 
                    LiquidityPctLow = val;
                }
                
                public QuickFix.FXCM.Fields.LiquidityPctLow Get(QuickFix.FXCM.Fields.LiquidityPctLow val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LiquidityPctLow val) 
                { 
                    return IsSetLiquidityPctLow();
                }
                
                public bool IsSetLiquidityPctLow() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LiquidityPctLow);
                }
                
                public QuickFix.FXCM.Fields.LiquidityPctHigh LiquidityPctHigh
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LiquidityPctHigh();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LiquidityPctHigh val) 
                { 
                    LiquidityPctHigh = val;
                }
                
                public QuickFix.FXCM.Fields.LiquidityPctHigh Get(QuickFix.FXCM.Fields.LiquidityPctHigh val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LiquidityPctHigh val) 
                { 
                    return IsSetLiquidityPctHigh();
                }
                
                public bool IsSetLiquidityPctHigh() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LiquidityPctHigh);
                }
                
                public QuickFix.FXCM.Fields.EFPTrackingError EFPTrackingError
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EFPTrackingError();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EFPTrackingError val) 
                { 
                    EFPTrackingError = val;
                }
                
                public QuickFix.FXCM.Fields.EFPTrackingError Get(QuickFix.FXCM.Fields.EFPTrackingError val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EFPTrackingError val) 
                { 
                    return IsSetEFPTrackingError();
                }
                
                public bool IsSetEFPTrackingError() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EFPTrackingError);
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
                
                public QuickFix.FXCM.Fields.OutsideIndexPct OutsideIndexPct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OutsideIndexPct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OutsideIndexPct val) 
                { 
                    OutsideIndexPct = val;
                }
                
                public QuickFix.FXCM.Fields.OutsideIndexPct Get(QuickFix.FXCM.Fields.OutsideIndexPct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OutsideIndexPct val) 
                { 
                    return IsSetOutsideIndexPct();
                }
                
                public bool IsSetOutsideIndexPct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OutsideIndexPct);
                }
                
                public QuickFix.FXCM.Fields.ValueOfFutures ValueOfFutures
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ValueOfFutures();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ValueOfFutures val) 
                { 
                    ValueOfFutures = val;
                }
                
                public QuickFix.FXCM.Fields.ValueOfFutures Get(QuickFix.FXCM.Fields.ValueOfFutures val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ValueOfFutures val) 
                { 
                    return IsSetValueOfFutures();
                }
                
                public bool IsSetValueOfFutures() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ValueOfFutures);
                }
                
            
            }
            public class NoBidComponentsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.ListID, QuickFix.FXCM.Fields.Tags.Side, QuickFix.FXCM.Fields.Tags.TradingSessionID, QuickFix.FXCM.Fields.Tags.TradingSessionSubID, QuickFix.FXCM.Fields.Tags.NetGrossInd, QuickFix.FXCM.Fields.Tags.SettlType, QuickFix.FXCM.Fields.Tags.SettlDate, QuickFix.FXCM.Fields.Tags.Account, QuickFix.FXCM.Fields.Tags.AcctIDSource, 0};
            
                public NoBidComponentsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoBidComponents, QuickFix.FXCM.Fields.Tags.ListID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBidComponentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.FXCM.Fields.Account Account
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Account();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Account val) 
                { 
                    Account = val;
                }
                
                public QuickFix.FXCM.Fields.Account Get(QuickFix.FXCM.Fields.Account val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Account val) 
                { 
                    return IsSetAccount();
                }
                
                public bool IsSetAccount() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Account);
                }
                
                public QuickFix.FXCM.Fields.AcctIDSource AcctIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.AcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.AcctIDSource val) 
                { 
                    AcctIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.AcctIDSource Get(QuickFix.FXCM.Fields.AcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.AcctIDSource val) 
                { 
                    return IsSetAcctIDSource();
                }
                
                public bool IsSetAcctIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.AcctIDSource);
                }
                
            
            }
    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class BidRequest : Message
    {
            public const string MsgType = "k";

            public BidRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("k"));
            }

            public BidRequest(
                    QuickFix.Fields.ClientBidID aClientBidID,
                    QuickFix.Fields.BidRequestTransType aBidRequestTransType,
                    QuickFix.Fields.TotNoRelatedSym aTotNoRelatedSym,
                    QuickFix.Fields.BidType aBidType,
                    QuickFix.Fields.BidTradeType aBidTradeType,
                    QuickFix.Fields.BasisPxType aBasisPxType
                ) : this()
            {
                this.ClientBidID = aClientBidID;
                this.BidRequestTransType = aBidRequestTransType;
                this.TotNoRelatedSym = aTotNoRelatedSym;
                this.BidType = aBidType;
                this.BidTradeType = aBidTradeType;
                this.BasisPxType = aBasisPxType;
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
            
            public QuickFix.Fields.BidRequestTransType BidRequestTransType
            { 
                get 
                {
                    var val = new QuickFix.Fields.BidRequestTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidRequestTransType val) 
            { 
                BidRequestTransType = val;
            }
            
            public QuickFix.Fields.BidRequestTransType Get(QuickFix.Fields.BidRequestTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidRequestTransType val) 
            { 
                return IsSetBidRequestTransType();
            }
            
            public bool IsSetBidRequestTransType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BidRequestTransType);
            }
            
            public QuickFix.Fields.ListName ListName
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListName val) 
            { 
                ListName = val;
            }
            
            public QuickFix.Fields.ListName Get(QuickFix.Fields.ListName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListName val) 
            { 
                return IsSetListName();
            }
            
            public bool IsSetListName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListName);
            }
            
            public QuickFix.Fields.TotNoRelatedSym TotNoRelatedSym
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                TotNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym Get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return IsSetTotNoRelatedSym();
            }
            
            public bool IsSetTotNoRelatedSym() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotNoRelatedSym);
            }
            
            public QuickFix.Fields.BidType BidType
            { 
                get 
                {
                    var val = new QuickFix.Fields.BidType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidType val) 
            { 
                BidType = val;
            }
            
            public QuickFix.Fields.BidType Get(QuickFix.Fields.BidType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidType val) 
            { 
                return IsSetBidType();
            }
            
            public bool IsSetBidType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BidType);
            }
            
            public QuickFix.Fields.NumTickets NumTickets
            { 
                get 
                {
                    var val = new QuickFix.Fields.NumTickets();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumTickets val) 
            { 
                NumTickets = val;
            }
            
            public QuickFix.Fields.NumTickets Get(QuickFix.Fields.NumTickets val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumTickets val) 
            { 
                return IsSetNumTickets();
            }
            
            public bool IsSetNumTickets() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NumTickets);
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
            
            public QuickFix.Fields.SideValue1 SideValue1
            { 
                get 
                {
                    var val = new QuickFix.Fields.SideValue1();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SideValue1 val) 
            { 
                SideValue1 = val;
            }
            
            public QuickFix.Fields.SideValue1 Get(QuickFix.Fields.SideValue1 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SideValue1 val) 
            { 
                return IsSetSideValue1();
            }
            
            public bool IsSetSideValue1() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SideValue1);
            }
            
            public QuickFix.Fields.SideValue2 SideValue2
            { 
                get 
                {
                    var val = new QuickFix.Fields.SideValue2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SideValue2 val) 
            { 
                SideValue2 = val;
            }
            
            public QuickFix.Fields.SideValue2 Get(QuickFix.Fields.SideValue2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SideValue2 val) 
            { 
                return IsSetSideValue2();
            }
            
            public bool IsSetSideValue2() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SideValue2);
            }
            
            public QuickFix.Fields.NoBidDescriptors NoBidDescriptors
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoBidDescriptors();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoBidDescriptors val) 
            { 
                NoBidDescriptors = val;
            }
            
            public QuickFix.Fields.NoBidDescriptors Get(QuickFix.Fields.NoBidDescriptors val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoBidDescriptors val) 
            { 
                return IsSetNoBidDescriptors();
            }
            
            public bool IsSetNoBidDescriptors() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoBidDescriptors);
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
            
            public QuickFix.Fields.LiquidityIndType LiquidityIndType
            { 
                get 
                {
                    var val = new QuickFix.Fields.LiquidityIndType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LiquidityIndType val) 
            { 
                LiquidityIndType = val;
            }
            
            public QuickFix.Fields.LiquidityIndType Get(QuickFix.Fields.LiquidityIndType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LiquidityIndType val) 
            { 
                return IsSetLiquidityIndType();
            }
            
            public bool IsSetLiquidityIndType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LiquidityIndType);
            }
            
            public QuickFix.Fields.WtAverageLiquidity WtAverageLiquidity
            { 
                get 
                {
                    var val = new QuickFix.Fields.WtAverageLiquidity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                WtAverageLiquidity = val;
            }
            
            public QuickFix.Fields.WtAverageLiquidity Get(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                return IsSetWtAverageLiquidity();
            }
            
            public bool IsSetWtAverageLiquidity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.WtAverageLiquidity);
            }
            
            public QuickFix.Fields.ExchangeForPhysical ExchangeForPhysical
            { 
                get 
                {
                    var val = new QuickFix.Fields.ExchangeForPhysical();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                ExchangeForPhysical = val;
            }
            
            public QuickFix.Fields.ExchangeForPhysical Get(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                return IsSetExchangeForPhysical();
            }
            
            public bool IsSetExchangeForPhysical() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ExchangeForPhysical);
            }
            
            public QuickFix.Fields.OutMainCntryUIndex OutMainCntryUIndex
            { 
                get 
                {
                    var val = new QuickFix.Fields.OutMainCntryUIndex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                OutMainCntryUIndex = val;
            }
            
            public QuickFix.Fields.OutMainCntryUIndex Get(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                return IsSetOutMainCntryUIndex();
            }
            
            public bool IsSetOutMainCntryUIndex() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OutMainCntryUIndex);
            }
            
            public QuickFix.Fields.CrossPercent CrossPercent
            { 
                get 
                {
                    var val = new QuickFix.Fields.CrossPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossPercent val) 
            { 
                CrossPercent = val;
            }
            
            public QuickFix.Fields.CrossPercent Get(QuickFix.Fields.CrossPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossPercent val) 
            { 
                return IsSetCrossPercent();
            }
            
            public bool IsSetCrossPercent() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CrossPercent);
            }
            
            public QuickFix.Fields.ProgRptReqs ProgRptReqs
            { 
                get 
                {
                    var val = new QuickFix.Fields.ProgRptReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgRptReqs val) 
            { 
                ProgRptReqs = val;
            }
            
            public QuickFix.Fields.ProgRptReqs Get(QuickFix.Fields.ProgRptReqs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgRptReqs val) 
            { 
                return IsSetProgRptReqs();
            }
            
            public bool IsSetProgRptReqs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ProgRptReqs);
            }
            
            public QuickFix.Fields.ProgPeriodInterval ProgPeriodInterval
            { 
                get 
                {
                    var val = new QuickFix.Fields.ProgPeriodInterval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                ProgPeriodInterval = val;
            }
            
            public QuickFix.Fields.ProgPeriodInterval Get(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                return IsSetProgPeriodInterval();
            }
            
            public bool IsSetProgPeriodInterval() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ProgPeriodInterval);
            }
            
            public QuickFix.Fields.IncTaxInd IncTaxInd
            { 
                get 
                {
                    var val = new QuickFix.Fields.IncTaxInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IncTaxInd val) 
            { 
                IncTaxInd = val;
            }
            
            public QuickFix.Fields.IncTaxInd Get(QuickFix.Fields.IncTaxInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IncTaxInd val) 
            { 
                return IsSetIncTaxInd();
            }
            
            public bool IsSetIncTaxInd() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IncTaxInd);
            }
            
            public QuickFix.Fields.ForexReq ForexReq
            { 
                get 
                {
                    var val = new QuickFix.Fields.ForexReq();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ForexReq val) 
            { 
                ForexReq = val;
            }
            
            public QuickFix.Fields.ForexReq Get(QuickFix.Fields.ForexReq val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ForexReq val) 
            { 
                return IsSetForexReq();
            }
            
            public bool IsSetForexReq() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ForexReq);
            }
            
            public QuickFix.Fields.NumBidders NumBidders
            { 
                get 
                {
                    var val = new QuickFix.Fields.NumBidders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumBidders val) 
            { 
                NumBidders = val;
            }
            
            public QuickFix.Fields.NumBidders Get(QuickFix.Fields.NumBidders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumBidders val) 
            { 
                return IsSetNumBidders();
            }
            
            public bool IsSetNumBidders() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NumBidders);
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
            
            public QuickFix.Fields.BidTradeType BidTradeType
            { 
                get 
                {
                    var val = new QuickFix.Fields.BidTradeType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidTradeType val) 
            { 
                BidTradeType = val;
            }
            
            public QuickFix.Fields.BidTradeType Get(QuickFix.Fields.BidTradeType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidTradeType val) 
            { 
                return IsSetBidTradeType();
            }
            
            public bool IsSetBidTradeType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BidTradeType);
            }
            
            public QuickFix.Fields.BasisPxType BasisPxType
            { 
                get 
                {
                    var val = new QuickFix.Fields.BasisPxType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BasisPxType val) 
            { 
                BasisPxType = val;
            }
            
            public QuickFix.Fields.BasisPxType Get(QuickFix.Fields.BasisPxType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BasisPxType val) 
            { 
                return IsSetBasisPxType();
            }
            
            public bool IsSetBasisPxType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.BasisPxType);
            }
            
            public QuickFix.Fields.StrikeTime StrikeTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.StrikeTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeTime val) 
            { 
                StrikeTime = val;
            }
            
            public QuickFix.Fields.StrikeTime Get(QuickFix.Fields.StrikeTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeTime val) 
            { 
                return IsSetStrikeTime();
            }
            
            public bool IsSetStrikeTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StrikeTime);
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
            
            public class NoBidDescriptorsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.BidDescriptorType, QuickFix.Fields.Tags.BidDescriptor, QuickFix.Fields.Tags.SideValueInd, QuickFix.Fields.Tags.LiquidityValue, QuickFix.Fields.Tags.LiquidityNumSecurities, QuickFix.Fields.Tags.LiquidityPctLow, QuickFix.Fields.Tags.LiquidityPctHigh, QuickFix.Fields.Tags.EFPTrackingError, QuickFix.Fields.Tags.FairValue, QuickFix.Fields.Tags.OutsideIndexPct, QuickFix.Fields.Tags.ValueOfFutures, 0};
            
                public NoBidDescriptorsGroup() 
                  :base( QuickFix.Fields.Tags.NoBidDescriptors, QuickFix.Fields.Tags.BidDescriptorType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBidDescriptorsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.BidDescriptorType BidDescriptorType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BidDescriptorType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BidDescriptorType val) 
                { 
                    BidDescriptorType = val;
                }
                
                public QuickFix.Fields.BidDescriptorType Get(QuickFix.Fields.BidDescriptorType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BidDescriptorType val) 
                { 
                    return IsSetBidDescriptorType();
                }
                
                public bool IsSetBidDescriptorType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BidDescriptorType);
                }
                
                public QuickFix.Fields.BidDescriptor BidDescriptor
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BidDescriptor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BidDescriptor val) 
                { 
                    BidDescriptor = val;
                }
                
                public QuickFix.Fields.BidDescriptor Get(QuickFix.Fields.BidDescriptor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BidDescriptor val) 
                { 
                    return IsSetBidDescriptor();
                }
                
                public bool IsSetBidDescriptor() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BidDescriptor);
                }
                
                public QuickFix.Fields.SideValueInd SideValueInd
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SideValueInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SideValueInd val) 
                { 
                    SideValueInd = val;
                }
                
                public QuickFix.Fields.SideValueInd Get(QuickFix.Fields.SideValueInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SideValueInd val) 
                { 
                    return IsSetSideValueInd();
                }
                
                public bool IsSetSideValueInd() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SideValueInd);
                }
                
                public QuickFix.Fields.LiquidityValue LiquidityValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LiquidityValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityValue val) 
                { 
                    LiquidityValue = val;
                }
                
                public QuickFix.Fields.LiquidityValue Get(QuickFix.Fields.LiquidityValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityValue val) 
                { 
                    return IsSetLiquidityValue();
                }
                
                public bool IsSetLiquidityValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LiquidityValue);
                }
                
                public QuickFix.Fields.LiquidityNumSecurities LiquidityNumSecurities
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LiquidityNumSecurities();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    LiquidityNumSecurities = val;
                }
                
                public QuickFix.Fields.LiquidityNumSecurities Get(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    return IsSetLiquidityNumSecurities();
                }
                
                public bool IsSetLiquidityNumSecurities() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LiquidityNumSecurities);
                }
                
                public QuickFix.Fields.LiquidityPctLow LiquidityPctLow
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LiquidityPctLow();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    LiquidityPctLow = val;
                }
                
                public QuickFix.Fields.LiquidityPctLow Get(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    return IsSetLiquidityPctLow();
                }
                
                public bool IsSetLiquidityPctLow() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LiquidityPctLow);
                }
                
                public QuickFix.Fields.LiquidityPctHigh LiquidityPctHigh
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LiquidityPctHigh();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    LiquidityPctHigh = val;
                }
                
                public QuickFix.Fields.LiquidityPctHigh Get(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    return IsSetLiquidityPctHigh();
                }
                
                public bool IsSetLiquidityPctHigh() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LiquidityPctHigh);
                }
                
                public QuickFix.Fields.EFPTrackingError EFPTrackingError
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EFPTrackingError();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EFPTrackingError val) 
                { 
                    EFPTrackingError = val;
                }
                
                public QuickFix.Fields.EFPTrackingError Get(QuickFix.Fields.EFPTrackingError val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EFPTrackingError val) 
                { 
                    return IsSetEFPTrackingError();
                }
                
                public bool IsSetEFPTrackingError() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EFPTrackingError);
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
                
                public QuickFix.Fields.OutsideIndexPct OutsideIndexPct
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OutsideIndexPct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    OutsideIndexPct = val;
                }
                
                public QuickFix.Fields.OutsideIndexPct Get(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    return IsSetOutsideIndexPct();
                }
                
                public bool IsSetOutsideIndexPct() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OutsideIndexPct);
                }
                
                public QuickFix.Fields.ValueOfFutures ValueOfFutures
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ValueOfFutures();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ValueOfFutures val) 
                { 
                    ValueOfFutures = val;
                }
                
                public QuickFix.Fields.ValueOfFutures Get(QuickFix.Fields.ValueOfFutures val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ValueOfFutures val) 
                { 
                    return IsSetValueOfFutures();
                }
                
                public bool IsSetValueOfFutures() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ValueOfFutures);
                }
                
            
            }
            public class NoBidComponentsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.ListID, QuickFix.Fields.Tags.Side, QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.NetGrossInd, QuickFix.Fields.Tags.SettlType, QuickFix.Fields.Tags.SettlDate, QuickFix.Fields.Tags.Account, QuickFix.Fields.Tags.AcctIDSource, 0};
            
                public NoBidComponentsGroup() 
                  :base( QuickFix.Fields.Tags.NoBidComponents, QuickFix.Fields.Tags.ListID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBidComponentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.Account Account
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Account();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Account val) 
                { 
                    Account = val;
                }
                
                public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Account val) 
                { 
                    return IsSetAccount();
                }
                
                public bool IsSetAccount() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Account);
                }
                
                public QuickFix.Fields.AcctIDSource AcctIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AcctIDSource val) 
                { 
                    AcctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return IsSetAcctIDSource();
                }
                
                public bool IsSetAcctIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AcctIDSource);
                }
                
            
            }
    }
}

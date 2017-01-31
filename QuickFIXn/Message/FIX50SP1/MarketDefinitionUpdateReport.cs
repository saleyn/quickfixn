// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MarketDefinitionUpdateReport : Message
    {
            public const string MsgType = "BV";

            public MarketDefinitionUpdateReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BV"));
            }

            public MarketDefinitionUpdateReport(
                    QuickFix.Fields.MarketReportID aMarketReportID,
                    QuickFix.Fields.MarketID aMarketID
                ) : this()
            {
                this.MarketReportID = aMarketReportID;
                this.MarketID = aMarketID;
            }

            public QuickFix.Fields.MarketReportID MarketReportID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketReportID val) 
            { 
                MarketReportID = val;
            }
            
            public QuickFix.Fields.MarketReportID Get(QuickFix.Fields.MarketReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketReportID val) 
            { 
                return IsSetMarketReportID();
            }
            
            public bool IsSetMarketReportID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketReportID);
            }
            
            public QuickFix.Fields.MarketReqID MarketReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketReqID val) 
            { 
                MarketReqID = val;
            }
            
            public QuickFix.Fields.MarketReqID Get(QuickFix.Fields.MarketReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketReqID val) 
            { 
                return IsSetMarketReqID();
            }
            
            public bool IsSetMarketReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketReqID);
            }
            
            public QuickFix.Fields.MarketUpdateAction MarketUpdateAction
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketUpdateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketUpdateAction val) 
            { 
                MarketUpdateAction = val;
            }
            
            public QuickFix.Fields.MarketUpdateAction Get(QuickFix.Fields.MarketUpdateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketUpdateAction val) 
            { 
                return IsSetMarketUpdateAction();
            }
            
            public bool IsSetMarketUpdateAction() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketUpdateAction);
            }
            
            public QuickFix.Fields.MarketID MarketID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketID val) 
            { 
                MarketID = val;
            }
            
            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketID val) 
            { 
                return IsSetMarketID();
            }
            
            public bool IsSetMarketID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketID);
            }
            
            public QuickFix.Fields.MarketSegmentID MarketSegmentID
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentID val) 
            { 
                MarketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return IsSetMarketSegmentID();
            }
            
            public bool IsSetMarketSegmentID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketSegmentID);
            }
            
            public QuickFix.Fields.MarketSegmentDesc MarketSegmentDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.MarketSegmentDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                MarketSegmentDesc = val;
            }
            
            public QuickFix.Fields.MarketSegmentDesc Get(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                return IsSetMarketSegmentDesc();
            }
            
            public bool IsSetMarketSegmentDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MarketSegmentDesc);
            }
            
            public QuickFix.Fields.EncodedMktSegmDescLen EncodedMktSegmDescLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedMktSegmDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                EncodedMktSegmDescLen = val;
            }
            
            public QuickFix.Fields.EncodedMktSegmDescLen Get(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                return IsSetEncodedMktSegmDescLen();
            }
            
            public bool IsSetEncodedMktSegmDescLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedMktSegmDescLen);
            }
            
            public QuickFix.Fields.EncodedMktSegmDesc EncodedMktSegmDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedMktSegmDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                EncodedMktSegmDesc = val;
            }
            
            public QuickFix.Fields.EncodedMktSegmDesc Get(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                return IsSetEncodedMktSegmDesc();
            }
            
            public bool IsSetEncodedMktSegmDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedMktSegmDesc);
            }
            
            public QuickFix.Fields.ParentMktSegmID ParentMktSegmID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ParentMktSegmID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ParentMktSegmID val) 
            { 
                ParentMktSegmID = val;
            }
            
            public QuickFix.Fields.ParentMktSegmID Get(QuickFix.Fields.ParentMktSegmID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ParentMktSegmID val) 
            { 
                return IsSetParentMktSegmID();
            }
            
            public bool IsSetParentMktSegmID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ParentMktSegmID);
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
            
            public QuickFix.Fields.NoTickRules NoTickRules
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoTickRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTickRules val) 
            { 
                NoTickRules = val;
            }
            
            public QuickFix.Fields.NoTickRules Get(QuickFix.Fields.NoTickRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTickRules val) 
            { 
                return IsSetNoTickRules();
            }
            
            public bool IsSetNoTickRules() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoTickRules);
            }
            
            public QuickFix.Fields.NoLotTypeRules NoLotTypeRules
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoLotTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLotTypeRules val) 
            { 
                NoLotTypeRules = val;
            }
            
            public QuickFix.Fields.NoLotTypeRules Get(QuickFix.Fields.NoLotTypeRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLotTypeRules val) 
            { 
                return IsSetNoLotTypeRules();
            }
            
            public bool IsSetNoLotTypeRules() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoLotTypeRules);
            }
            
            public QuickFix.Fields.PriceLimitType PriceLimitType
            { 
                get 
                {
                    var val = new QuickFix.Fields.PriceLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceLimitType val) 
            { 
                PriceLimitType = val;
            }
            
            public QuickFix.Fields.PriceLimitType Get(QuickFix.Fields.PriceLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceLimitType val) 
            { 
                return IsSetPriceLimitType();
            }
            
            public bool IsSetPriceLimitType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PriceLimitType);
            }
            
            public QuickFix.Fields.LowLimitPrice LowLimitPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.LowLimitPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LowLimitPrice val) 
            { 
                LowLimitPrice = val;
            }
            
            public QuickFix.Fields.LowLimitPrice Get(QuickFix.Fields.LowLimitPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LowLimitPrice val) 
            { 
                return IsSetLowLimitPrice();
            }
            
            public bool IsSetLowLimitPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LowLimitPrice);
            }
            
            public QuickFix.Fields.HighLimitPrice HighLimitPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.HighLimitPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HighLimitPrice val) 
            { 
                HighLimitPrice = val;
            }
            
            public QuickFix.Fields.HighLimitPrice Get(QuickFix.Fields.HighLimitPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HighLimitPrice val) 
            { 
                return IsSetHighLimitPrice();
            }
            
            public bool IsSetHighLimitPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.HighLimitPrice);
            }
            
            public QuickFix.Fields.TradingReferencePrice TradingReferencePrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradingReferencePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingReferencePrice val) 
            { 
                TradingReferencePrice = val;
            }
            
            public QuickFix.Fields.TradingReferencePrice Get(QuickFix.Fields.TradingReferencePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingReferencePrice val) 
            { 
                return IsSetTradingReferencePrice();
            }
            
            public bool IsSetTradingReferencePrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradingReferencePrice);
            }
            
            public QuickFix.Fields.ExpirationCycle ExpirationCycle
            { 
                get 
                {
                    var val = new QuickFix.Fields.ExpirationCycle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExpirationCycle val) 
            { 
                ExpirationCycle = val;
            }
            
            public QuickFix.Fields.ExpirationCycle Get(QuickFix.Fields.ExpirationCycle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExpirationCycle val) 
            { 
                return IsSetExpirationCycle();
            }
            
            public bool IsSetExpirationCycle() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ExpirationCycle);
            }
            
            public QuickFix.Fields.MinTradeVol MinTradeVol
            { 
                get 
                {
                    var val = new QuickFix.Fields.MinTradeVol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinTradeVol val) 
            { 
                MinTradeVol = val;
            }
            
            public QuickFix.Fields.MinTradeVol Get(QuickFix.Fields.MinTradeVol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinTradeVol val) 
            { 
                return IsSetMinTradeVol();
            }
            
            public bool IsSetMinTradeVol() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MinTradeVol);
            }
            
            public QuickFix.Fields.MaxTradeVol MaxTradeVol
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaxTradeVol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxTradeVol val) 
            { 
                MaxTradeVol = val;
            }
            
            public QuickFix.Fields.MaxTradeVol Get(QuickFix.Fields.MaxTradeVol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxTradeVol val) 
            { 
                return IsSetMaxTradeVol();
            }
            
            public bool IsSetMaxTradeVol() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaxTradeVol);
            }
            
            public QuickFix.Fields.MaxPriceVariation MaxPriceVariation
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaxPriceVariation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxPriceVariation val) 
            { 
                MaxPriceVariation = val;
            }
            
            public QuickFix.Fields.MaxPriceVariation Get(QuickFix.Fields.MaxPriceVariation val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxPriceVariation val) 
            { 
                return IsSetMaxPriceVariation();
            }
            
            public bool IsSetMaxPriceVariation() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaxPriceVariation);
            }
            
            public QuickFix.Fields.ImpliedMarketIndicator ImpliedMarketIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.ImpliedMarketIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                ImpliedMarketIndicator = val;
            }
            
            public QuickFix.Fields.ImpliedMarketIndicator Get(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                return IsSetImpliedMarketIndicator();
            }
            
            public bool IsSetImpliedMarketIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ImpliedMarketIndicator);
            }
            
            public QuickFix.Fields.TradingCurrency TradingCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradingCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingCurrency val) 
            { 
                TradingCurrency = val;
            }
            
            public QuickFix.Fields.TradingCurrency Get(QuickFix.Fields.TradingCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingCurrency val) 
            { 
                return IsSetTradingCurrency();
            }
            
            public bool IsSetTradingCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradingCurrency);
            }
            
            public QuickFix.Fields.RoundLot RoundLot
            { 
                get 
                {
                    var val = new QuickFix.Fields.RoundLot();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RoundLot val) 
            { 
                RoundLot = val;
            }
            
            public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RoundLot val) 
            { 
                return IsSetRoundLot();
            }
            
            public bool IsSetRoundLot() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RoundLot);
            }
            
            public QuickFix.Fields.MultilegModel MultilegModel
            { 
                get 
                {
                    var val = new QuickFix.Fields.MultilegModel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MultilegModel val) 
            { 
                MultilegModel = val;
            }
            
            public QuickFix.Fields.MultilegModel Get(QuickFix.Fields.MultilegModel val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MultilegModel val) 
            { 
                return IsSetMultilegModel();
            }
            
            public bool IsSetMultilegModel() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MultilegModel);
            }
            
            public QuickFix.Fields.MultilegPriceMethod MultilegPriceMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.MultilegPriceMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                MultilegPriceMethod = val;
            }
            
            public QuickFix.Fields.MultilegPriceMethod Get(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                return IsSetMultilegPriceMethod();
            }
            
            public bool IsSetMultilegPriceMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MultilegPriceMethod);
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
            
            public QuickFix.Fields.NoOrdTypeRules NoOrdTypeRules
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoOrdTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                NoOrdTypeRules = val;
            }
            
            public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                return IsSetNoOrdTypeRules();
            }
            
            public bool IsSetNoOrdTypeRules() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoOrdTypeRules);
            }
            
            public QuickFix.Fields.NoTimeInForceRules NoTimeInForceRules
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoTimeInForceRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                NoTimeInForceRules = val;
            }
            
            public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                return IsSetNoTimeInForceRules();
            }
            
            public bool IsSetNoTimeInForceRules() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoTimeInForceRules);
            }
            
            public QuickFix.Fields.NoExecInstRules NoExecInstRules
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoExecInstRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoExecInstRules val) 
            { 
                NoExecInstRules = val;
            }
            
            public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoExecInstRules val) 
            { 
                return IsSetNoExecInstRules();
            }
            
            public bool IsSetNoExecInstRules() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoExecInstRules);
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
            
            public QuickFix.Fields.ApplID ApplID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                ApplID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplID);
            }
            
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                ApplSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplSeqNum);
            }
            
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                ApplLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplLastSeqNum);
            }
            
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                ApplResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplResendFlag);
            }
            
            public class NoTickRulesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.StartTickPriceRange, QuickFix.Fields.Tags.EndTickPriceRange, QuickFix.Fields.Tags.TickIncrement, QuickFix.Fields.Tags.TickRuleType, 0};
            
                public NoTickRulesGroup() 
                  :base( QuickFix.Fields.Tags.NoTickRules, QuickFix.Fields.Tags.StartTickPriceRange, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTickRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.StartTickPriceRange StartTickPriceRange
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StartTickPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    StartTickPriceRange = val;
                }
                
                public QuickFix.Fields.StartTickPriceRange Get(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    return IsSetStartTickPriceRange();
                }
                
                public bool IsSetStartTickPriceRange() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StartTickPriceRange);
                }
                
                public QuickFix.Fields.EndTickPriceRange EndTickPriceRange
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EndTickPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    EndTickPriceRange = val;
                }
                
                public QuickFix.Fields.EndTickPriceRange Get(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    return IsSetEndTickPriceRange();
                }
                
                public bool IsSetEndTickPriceRange() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EndTickPriceRange);
                }
                
                public QuickFix.Fields.TickIncrement TickIncrement
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TickIncrement();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickIncrement val) 
                { 
                    TickIncrement = val;
                }
                
                public QuickFix.Fields.TickIncrement Get(QuickFix.Fields.TickIncrement val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickIncrement val) 
                { 
                    return IsSetTickIncrement();
                }
                
                public bool IsSetTickIncrement() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TickIncrement);
                }
                
                public QuickFix.Fields.TickRuleType TickRuleType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TickRuleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickRuleType val) 
                { 
                    TickRuleType = val;
                }
                
                public QuickFix.Fields.TickRuleType Get(QuickFix.Fields.TickRuleType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickRuleType val) 
                { 
                    return IsSetTickRuleType();
                }
                
                public bool IsSetTickRuleType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TickRuleType);
                }
                
            
            }
            public class NoLotTypeRulesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.LotType, QuickFix.Fields.Tags.MinLotSize, 0};
            
                public NoLotTypeRulesGroup() 
                  :base( QuickFix.Fields.Tags.NoLotTypeRules, QuickFix.Fields.Tags.LotType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLotTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LotType LotType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LotType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LotType val) 
                { 
                    LotType = val;
                }
                
                public QuickFix.Fields.LotType Get(QuickFix.Fields.LotType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LotType val) 
                { 
                    return IsSetLotType();
                }
                
                public bool IsSetLotType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LotType);
                }
                
                public QuickFix.Fields.MinLotSize MinLotSize
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MinLotSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinLotSize val) 
                { 
                    MinLotSize = val;
                }
                
                public QuickFix.Fields.MinLotSize Get(QuickFix.Fields.MinLotSize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinLotSize val) 
                { 
                    return IsSetMinLotSize();
                }
                
                public bool IsSetMinLotSize() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MinLotSize);
                }
                
            
            }
            public class NoOrdTypeRulesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.OrdType, 0};
            
                public NoOrdTypeRulesGroup() 
                  :base( QuickFix.Fields.Tags.NoOrdTypeRules, QuickFix.Fields.Tags.OrdType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
            
            }
            public class NoTimeInForceRulesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.TimeInForce, 0};
            
                public NoTimeInForceRulesGroup() 
                  :base( QuickFix.Fields.Tags.NoTimeInForceRules, QuickFix.Fields.Tags.TimeInForce, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTimeInForceRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.TimeInForce TimeInForce
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TimeInForce();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TimeInForce val) 
                { 
                    TimeInForce = val;
                }
                
                public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TimeInForce val) 
                { 
                    return IsSetTimeInForce();
                }
                
                public bool IsSetTimeInForce() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TimeInForce);
                }
                
            
            }
            public class NoExecInstRulesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.ExecInstValue, 0};
            
                public NoExecInstRulesGroup() 
                  :base( QuickFix.Fields.Tags.NoExecInstRules, QuickFix.Fields.Tags.ExecInstValue, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoExecInstRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ExecInstValue ExecInstValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExecInstValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecInstValue val) 
                { 
                    ExecInstValue = val;
                }
                
                public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecInstValue val) 
                { 
                    return IsSetExecInstValue();
                }
                
                public bool IsSetExecInstValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExecInstValue);
                }
                
            
            }
    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class SecurityListUpdateReport : Message
    {
            public const string MsgType = "BK";

            public SecurityListUpdateReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BK"));
            }


            public QuickFix.Fields.SecurityReportID SecurityReportID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityReportID val) 
            { 
                SecurityReportID = val;
            }
            
            public QuickFix.Fields.SecurityReportID Get(QuickFix.Fields.SecurityReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityReportID val) 
            { 
                return IsSetSecurityReportID();
            }
            
            public bool IsSetSecurityReportID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityReportID);
            }
            
            public QuickFix.Fields.SecurityReqID SecurityReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityReqID val) 
            { 
                SecurityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityReqID);
            }
            
            public QuickFix.Fields.SecurityResponseID SecurityResponseID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityResponseID val) 
            { 
                SecurityResponseID = val;
            }
            
            public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityResponseID val) 
            { 
                return IsSetSecurityResponseID();
            }
            
            public bool IsSetSecurityResponseID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityResponseID);
            }
            
            public QuickFix.Fields.SecurityRequestResult SecurityRequestResult
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityRequestResult val) 
            { 
                SecurityRequestResult = val;
            }
            
            public QuickFix.Fields.SecurityRequestResult Get(QuickFix.Fields.SecurityRequestResult val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityRequestResult val) 
            { 
                return IsSetSecurityRequestResult();
            }
            
            public bool IsSetSecurityRequestResult() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityRequestResult);
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
            
            public QuickFix.Fields.ClearingBusinessDate ClearingBusinessDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClearingBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                ClearingBusinessDate = val;
            }
            
            public QuickFix.Fields.ClearingBusinessDate Get(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                return IsSetClearingBusinessDate();
            }
            
            public bool IsSetClearingBusinessDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClearingBusinessDate);
            }
            
            public QuickFix.Fields.SecurityUpdateAction SecurityUpdateAction
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityUpdateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                SecurityUpdateAction = val;
            }
            
            public QuickFix.Fields.SecurityUpdateAction Get(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                return IsSetSecurityUpdateAction();
            }
            
            public bool IsSetSecurityUpdateAction() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityUpdateAction);
            }
            
            public QuickFix.Fields.CorporateAction CorporateAction
            { 
                get 
                {
                    var val = new QuickFix.Fields.CorporateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CorporateAction val) 
            { 
                CorporateAction = val;
            }
            
            public QuickFix.Fields.CorporateAction Get(QuickFix.Fields.CorporateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CorporateAction val) 
            { 
                return IsSetCorporateAction();
            }
            
            public bool IsSetCorporateAction() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CorporateAction);
            }
            
            public QuickFix.Fields.LastFragment LastFragment
            { 
                get 
                {
                    var val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                LastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LastFragment);
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
            
            public QuickFix.Fields.SecurityListID SecurityListID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityListID val) 
            { 
                SecurityListID = val;
            }
            
            public QuickFix.Fields.SecurityListID Get(QuickFix.Fields.SecurityListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityListID val) 
            { 
                return IsSetSecurityListID();
            }
            
            public bool IsSetSecurityListID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityListID);
            }
            
            public QuickFix.Fields.SecurityListRefID SecurityListRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityListRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityListRefID val) 
            { 
                SecurityListRefID = val;
            }
            
            public QuickFix.Fields.SecurityListRefID Get(QuickFix.Fields.SecurityListRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityListRefID val) 
            { 
                return IsSetSecurityListRefID();
            }
            
            public bool IsSetSecurityListRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityListRefID);
            }
            
            public QuickFix.Fields.SecurityListDesc SecurityListDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityListDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityListDesc val) 
            { 
                SecurityListDesc = val;
            }
            
            public QuickFix.Fields.SecurityListDesc Get(QuickFix.Fields.SecurityListDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityListDesc val) 
            { 
                return IsSetSecurityListDesc();
            }
            
            public bool IsSetSecurityListDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityListDesc);
            }
            
            public QuickFix.Fields.EncodedSecurityListDescLen EncodedSecurityListDescLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedSecurityListDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityListDescLen val) 
            { 
                EncodedSecurityListDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityListDescLen Get(QuickFix.Fields.EncodedSecurityListDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityListDescLen val) 
            { 
                return IsSetEncodedSecurityListDescLen();
            }
            
            public bool IsSetEncodedSecurityListDescLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedSecurityListDescLen);
            }
            
            public QuickFix.Fields.EncodedSecurityListDesc EncodedSecurityListDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedSecurityListDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityListDesc val) 
            { 
                EncodedSecurityListDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityListDesc Get(QuickFix.Fields.EncodedSecurityListDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityListDesc val) 
            { 
                return IsSetEncodedSecurityListDesc();
            }
            
            public bool IsSetEncodedSecurityListDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedSecurityListDesc);
            }
            
            public QuickFix.Fields.SecurityListType SecurityListType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityListType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityListType val) 
            { 
                SecurityListType = val;
            }
            
            public QuickFix.Fields.SecurityListType Get(QuickFix.Fields.SecurityListType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityListType val) 
            { 
                return IsSetSecurityListType();
            }
            
            public bool IsSetSecurityListType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityListType);
            }
            
            public QuickFix.Fields.SecurityListTypeSource SecurityListTypeSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityListTypeSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityListTypeSource val) 
            { 
                SecurityListTypeSource = val;
            }
            
            public QuickFix.Fields.SecurityListTypeSource Get(QuickFix.Fields.SecurityListTypeSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityListTypeSource val) 
            { 
                return IsSetSecurityListTypeSource();
            }
            
            public bool IsSetSecurityListTypeSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityListTypeSource);
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
            
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Symbol, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.SecurityIDSource, QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.Product, QuickFix.Fields.Tags.CFICode, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.SecuritySubType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDate, QuickFix.Fields.Tags.CouponPaymentDate, QuickFix.Fields.Tags.IssueDate, QuickFix.Fields.Tags.RepoCollateralSecurityType, QuickFix.Fields.Tags.RepurchaseTerm, QuickFix.Fields.Tags.RepurchaseRate, QuickFix.Fields.Tags.Factor, QuickFix.Fields.Tags.CreditRating, QuickFix.Fields.Tags.InstrRegistry, QuickFix.Fields.Tags.CountryOfIssue, QuickFix.Fields.Tags.StateOrProvinceOfIssue, QuickFix.Fields.Tags.LocaleOfIssue, QuickFix.Fields.Tags.RedemptionDate, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.StrikeCurrency, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, QuickFix.Fields.Tags.Pool, QuickFix.Fields.Tags.ContractSettlMonth, QuickFix.Fields.Tags.CPProgram, QuickFix.Fields.Tags.CPRegType, QuickFix.Fields.Tags.NoEvents, QuickFix.Fields.Tags.DatedDate, QuickFix.Fields.Tags.InterestAccrualDate, QuickFix.Fields.Tags.SecurityStatus, QuickFix.Fields.Tags.SettleOnOpenFlag, QuickFix.Fields.Tags.InstrmtAssignmentMethod, QuickFix.Fields.Tags.StrikeMultiplier, QuickFix.Fields.Tags.StrikeValue, QuickFix.Fields.Tags.MinPriceIncrement, QuickFix.Fields.Tags.PositionLimit, QuickFix.Fields.Tags.NTPositionLimit, QuickFix.Fields.Tags.NoInstrumentParties, QuickFix.Fields.Tags.UnitOfMeasure, QuickFix.Fields.Tags.TimeUnit, QuickFix.Fields.Tags.MaturityTime, QuickFix.Fields.Tags.SecurityGroup, QuickFix.Fields.Tags.MinPriceIncrementAmount, QuickFix.Fields.Tags.UnitOfMeasureQty, QuickFix.Fields.Tags.SecurityXMLLen, QuickFix.Fields.Tags.SecurityXML, QuickFix.Fields.Tags.SecurityXMLSchema, QuickFix.Fields.Tags.ProductComplex, QuickFix.Fields.Tags.PriceUnitOfMeasure, QuickFix.Fields.Tags.PriceUnitOfMeasureQty, QuickFix.Fields.Tags.SettlMethod, QuickFix.Fields.Tags.ExerciseStyle, QuickFix.Fields.Tags.OptPayoutAmount, QuickFix.Fields.Tags.PriceQuoteMethod, QuickFix.Fields.Tags.ListMethod, QuickFix.Fields.Tags.CapPrice, QuickFix.Fields.Tags.FloorPrice, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.FlexibleIndicator, QuickFix.Fields.Tags.FlexProductEligibilityIndicator, QuickFix.Fields.Tags.ValuationMethod, QuickFix.Fields.Tags.ContractMultiplierUnit, QuickFix.Fields.Tags.FlowScheduleType, QuickFix.Fields.Tags.RestructuringType, QuickFix.Fields.Tags.Seniority, QuickFix.Fields.Tags.NotionalPercentageOutstanding, QuickFix.Fields.Tags.OriginalNotionalPercentageOutstanding, QuickFix.Fields.Tags.AttachmentPoint, QuickFix.Fields.Tags.DetachmentPoint, QuickFix.Fields.Tags.StrikePriceDeterminationMethod, QuickFix.Fields.Tags.StrikePriceBoundaryMethod, QuickFix.Fields.Tags.StrikePriceBoundaryPrecision, QuickFix.Fields.Tags.UnderlyingPriceDeterminationMethod, QuickFix.Fields.Tags.OptPayoutType, QuickFix.Fields.Tags.NoComplexEvents, QuickFix.Fields.Tags.DeliveryForm, QuickFix.Fields.Tags.PctAtRisk, QuickFix.Fields.Tags.NoInstrAttrib, QuickFix.Fields.Tags.AgreementDesc, QuickFix.Fields.Tags.AgreementID, QuickFix.Fields.Tags.AgreementDate, QuickFix.Fields.Tags.AgreementCurrency, QuickFix.Fields.Tags.TerminationType, QuickFix.Fields.Tags.StartDate, QuickFix.Fields.Tags.EndDate, QuickFix.Fields.Tags.DeliveryType, QuickFix.Fields.Tags.MarginRatio, QuickFix.Fields.Tags.NoLegs, QuickFix.Fields.Tags.Spread, QuickFix.Fields.Tags.BenchmarkCurveCurrency, QuickFix.Fields.Tags.BenchmarkCurveName, QuickFix.Fields.Tags.BenchmarkCurvePoint, QuickFix.Fields.Tags.BenchmarkPrice, QuickFix.Fields.Tags.BenchmarkPriceType, QuickFix.Fields.Tags.BenchmarkSecurityID, QuickFix.Fields.Tags.BenchmarkSecurityIDSource, QuickFix.Fields.Tags.YieldType, QuickFix.Fields.Tags.Yield, QuickFix.Fields.Tags.YieldCalcDate, QuickFix.Fields.Tags.YieldRedemptionDate, QuickFix.Fields.Tags.YieldRedemptionPrice, QuickFix.Fields.Tags.YieldRedemptionPriceType, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, QuickFix.Fields.Tags.NoUnderlyings, QuickFix.Fields.Tags.Currency, QuickFix.Fields.Tags.NoStipulations, QuickFix.Fields.Tags.ListUpdateAction, QuickFix.Fields.Tags.NoTickRules, QuickFix.Fields.Tags.NoLotTypeRules, QuickFix.Fields.Tags.PriceLimitType, QuickFix.Fields.Tags.LowLimitPrice, QuickFix.Fields.Tags.HighLimitPrice, QuickFix.Fields.Tags.TradingReferencePrice, QuickFix.Fields.Tags.ExpirationCycle, QuickFix.Fields.Tags.MinTradeVol, QuickFix.Fields.Tags.MaxTradeVol, QuickFix.Fields.Tags.MaxPriceVariation, QuickFix.Fields.Tags.ImpliedMarketIndicator, QuickFix.Fields.Tags.TradingCurrency, QuickFix.Fields.Tags.RoundLot, QuickFix.Fields.Tags.MultilegModel, QuickFix.Fields.Tags.MultilegPriceMethod, QuickFix.Fields.Tags.PriceType, QuickFix.Fields.Tags.NoTradingSessionRules, QuickFix.Fields.Tags.NoNestedInstrAttrib, QuickFix.Fields.Tags.NoStrikeRules, QuickFix.Fields.Tags.RelSymTransactTime, 0};
            
                public NoRelatedSymGroup() 
                  :base( QuickFix.Fields.Tags.NoRelatedSym, QuickFix.Fields.Tags.Symbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.SecuritySubType SecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecuritySubType val) 
                { 
                    SecuritySubType = val;
                }
                
                public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecuritySubType val) 
                { 
                    return IsSetSecuritySubType();
                }
                
                public bool IsSetSecuritySubType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecuritySubType);
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
                
                public QuickFix.Fields.StrikeCurrency StrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikeCurrency val) 
                { 
                    StrikeCurrency = val;
                }
                
                public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
                { 
                    return IsSetStrikeCurrency();
                }
                
                public bool IsSetStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikeCurrency);
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
                
                public QuickFix.Fields.Pool Pool
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Pool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Pool val) 
                { 
                    Pool = val;
                }
                
                public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Pool val) 
                { 
                    return IsSetPool();
                }
                
                public bool IsSetPool() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Pool);
                }
                
                public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    ContractSettlMonth = val;
                }
                
                public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    return IsSetContractSettlMonth();
                }
                
                public bool IsSetContractSettlMonth() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ContractSettlMonth);
                }
                
                public QuickFix.Fields.CPProgram CPProgram
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CPProgram val) 
                { 
                    CPProgram = val;
                }
                
                public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CPProgram val) 
                { 
                    return IsSetCPProgram();
                }
                
                public bool IsSetCPProgram() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CPProgram);
                }
                
                public QuickFix.Fields.CPRegType CPRegType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CPRegType val) 
                { 
                    CPRegType = val;
                }
                
                public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CPRegType val) 
                { 
                    return IsSetCPRegType();
                }
                
                public bool IsSetCPRegType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CPRegType);
                }
                
                public QuickFix.Fields.NoEvents NoEvents
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoEvents();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoEvents val) 
                { 
                    NoEvents = val;
                }
                
                public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoEvents val) 
                { 
                    return IsSetNoEvents();
                }
                
                public bool IsSetNoEvents() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoEvents);
                }
                
                public QuickFix.Fields.DatedDate DatedDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DatedDate val) 
                { 
                    DatedDate = val;
                }
                
                public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DatedDate val) 
                { 
                    return IsSetDatedDate();
                }
                
                public bool IsSetDatedDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DatedDate);
                }
                
                public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.InterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    InterestAccrualDate = val;
                }
                
                public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    return IsSetInterestAccrualDate();
                }
                
                public bool IsSetInterestAccrualDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.InterestAccrualDate);
                }
                
                public QuickFix.Fields.SecurityStatus SecurityStatus
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityStatus val) 
                { 
                    SecurityStatus = val;
                }
                
                public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityStatus val) 
                { 
                    return IsSetSecurityStatus();
                }
                
                public bool IsSetSecurityStatus() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityStatus);
                }
                
                public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettleOnOpenFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    SettleOnOpenFlag = val;
                }
                
                public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    return IsSetSettleOnOpenFlag();
                }
                
                public bool IsSetSettleOnOpenFlag() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettleOnOpenFlag);
                }
                
                public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.InstrmtAssignmentMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    InstrmtAssignmentMethod = val;
                }
                
                public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    return IsSetInstrmtAssignmentMethod();
                }
                
                public bool IsSetInstrmtAssignmentMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.InstrmtAssignmentMethod);
                }
                
                public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikeMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    StrikeMultiplier = val;
                }
                
                public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    return IsSetStrikeMultiplier();
                }
                
                public bool IsSetStrikeMultiplier() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikeMultiplier);
                }
                
                public QuickFix.Fields.StrikeValue StrikeValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikeValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikeValue val) 
                { 
                    StrikeValue = val;
                }
                
                public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikeValue val) 
                { 
                    return IsSetStrikeValue();
                }
                
                public bool IsSetStrikeValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikeValue);
                }
                
                public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MinPriceIncrement();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    MinPriceIncrement = val;
                }
                
                public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    return IsSetMinPriceIncrement();
                }
                
                public bool IsSetMinPriceIncrement() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MinPriceIncrement);
                }
                
                public QuickFix.Fields.PositionLimit PositionLimit
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PositionLimit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PositionLimit val) 
                { 
                    PositionLimit = val;
                }
                
                public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PositionLimit val) 
                { 
                    return IsSetPositionLimit();
                }
                
                public bool IsSetPositionLimit() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PositionLimit);
                }
                
                public QuickFix.Fields.NTPositionLimit NTPositionLimit
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NTPositionLimit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NTPositionLimit val) 
                { 
                    NTPositionLimit = val;
                }
                
                public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NTPositionLimit val) 
                { 
                    return IsSetNTPositionLimit();
                }
                
                public bool IsSetNTPositionLimit() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NTPositionLimit);
                }
                
                public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoInstrumentParties();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    NoInstrumentParties = val;
                }
                
                public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    return IsSetNoInstrumentParties();
                }
                
                public bool IsSetNoInstrumentParties() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoInstrumentParties);
                }
                
                public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    UnitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    return IsSetUnitOfMeasure();
                }
                
                public bool IsSetUnitOfMeasure() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnitOfMeasure);
                }
                
                public QuickFix.Fields.TimeUnit TimeUnit
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TimeUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TimeUnit val) 
                { 
                    TimeUnit = val;
                }
                
                public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TimeUnit val) 
                { 
                    return IsSetTimeUnit();
                }
                
                public bool IsSetTimeUnit() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TimeUnit);
                }
                
                public QuickFix.Fields.MaturityTime MaturityTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MaturityTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaturityTime val) 
                { 
                    MaturityTime = val;
                }
                
                public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaturityTime val) 
                { 
                    return IsSetMaturityTime();
                }
                
                public bool IsSetMaturityTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MaturityTime);
                }
                
                public QuickFix.Fields.SecurityGroup SecurityGroup
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityGroup();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityGroup val) 
                { 
                    SecurityGroup = val;
                }
                
                public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityGroup val) 
                { 
                    return IsSetSecurityGroup();
                }
                
                public bool IsSetSecurityGroup() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityGroup);
                }
                
                public QuickFix.Fields.MinPriceIncrementAmount MinPriceIncrementAmount
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MinPriceIncrementAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    MinPriceIncrementAmount = val;
                }
                
                public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    return IsSetMinPriceIncrementAmount();
                }
                
                public bool IsSetMinPriceIncrementAmount() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MinPriceIncrementAmount);
                }
                
                public QuickFix.Fields.UnitOfMeasureQty UnitOfMeasureQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnitOfMeasureQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    UnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    return IsSetUnitOfMeasureQty();
                }
                
                public bool IsSetUnitOfMeasureQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnitOfMeasureQty);
                }
                
                public QuickFix.Fields.SecurityXMLLen SecurityXMLLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityXMLLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    SecurityXMLLen = val;
                }
                
                public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    return IsSetSecurityXMLLen();
                }
                
                public bool IsSetSecurityXMLLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityXMLLen);
                }
                
                public QuickFix.Fields.SecurityXML SecurityXML
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityXML();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityXML val) 
                { 
                    SecurityXML = val;
                }
                
                public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityXML val) 
                { 
                    return IsSetSecurityXML();
                }
                
                public bool IsSetSecurityXML() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityXML);
                }
                
                public QuickFix.Fields.SecurityXMLSchema SecurityXMLSchema
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityXMLSchema();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    SecurityXMLSchema = val;
                }
                
                public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    return IsSetSecurityXMLSchema();
                }
                
                public bool IsSetSecurityXMLSchema() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityXMLSchema);
                }
                
                public QuickFix.Fields.ProductComplex ProductComplex
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ProductComplex();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductComplex val) 
                { 
                    ProductComplex = val;
                }
                
                public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductComplex val) 
                { 
                    return IsSetProductComplex();
                }
                
                public bool IsSetProductComplex() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ProductComplex);
                }
                
                public QuickFix.Fields.PriceUnitOfMeasure PriceUnitOfMeasure
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PriceUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    PriceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    return IsSetPriceUnitOfMeasure();
                }
                
                public bool IsSetPriceUnitOfMeasure() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PriceUnitOfMeasure);
                }
                
                public QuickFix.Fields.PriceUnitOfMeasureQty PriceUnitOfMeasureQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    PriceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    return IsSetPriceUnitOfMeasureQty();
                }
                
                public bool IsSetPriceUnitOfMeasureQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PriceUnitOfMeasureQty);
                }
                
                public QuickFix.Fields.SettlMethod SettlMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SettlMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlMethod val) 
                { 
                    SettlMethod = val;
                }
                
                public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlMethod val) 
                { 
                    return IsSetSettlMethod();
                }
                
                public bool IsSetSettlMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SettlMethod);
                }
                
                public QuickFix.Fields.ExerciseStyle ExerciseStyle
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ExerciseStyle();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExerciseStyle val) 
                { 
                    ExerciseStyle = val;
                }
                
                public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExerciseStyle val) 
                { 
                    return IsSetExerciseStyle();
                }
                
                public bool IsSetExerciseStyle() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ExerciseStyle);
                }
                
                public QuickFix.Fields.OptPayoutAmount OptPayoutAmount
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OptPayoutAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OptPayoutAmount val) 
                { 
                    OptPayoutAmount = val;
                }
                
                public QuickFix.Fields.OptPayoutAmount Get(QuickFix.Fields.OptPayoutAmount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OptPayoutAmount val) 
                { 
                    return IsSetOptPayoutAmount();
                }
                
                public bool IsSetOptPayoutAmount() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OptPayoutAmount);
                }
                
                public QuickFix.Fields.PriceQuoteMethod PriceQuoteMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PriceQuoteMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    PriceQuoteMethod = val;
                }
                
                public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    return IsSetPriceQuoteMethod();
                }
                
                public bool IsSetPriceQuoteMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PriceQuoteMethod);
                }
                
                public QuickFix.Fields.ListMethod ListMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ListMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListMethod val) 
                { 
                    ListMethod = val;
                }
                
                public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListMethod val) 
                { 
                    return IsSetListMethod();
                }
                
                public bool IsSetListMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ListMethod);
                }
                
                public QuickFix.Fields.CapPrice CapPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CapPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CapPrice val) 
                { 
                    CapPrice = val;
                }
                
                public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CapPrice val) 
                { 
                    return IsSetCapPrice();
                }
                
                public bool IsSetCapPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CapPrice);
                }
                
                public QuickFix.Fields.FloorPrice FloorPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FloorPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FloorPrice val) 
                { 
                    FloorPrice = val;
                }
                
                public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FloorPrice val) 
                { 
                    return IsSetFloorPrice();
                }
                
                public bool IsSetFloorPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FloorPrice);
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
                
                public QuickFix.Fields.FlexibleIndicator FlexibleIndicator
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FlexibleIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    FlexibleIndicator = val;
                }
                
                public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    return IsSetFlexibleIndicator();
                }
                
                public bool IsSetFlexibleIndicator() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FlexibleIndicator);
                }
                
                public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    FlexProductEligibilityIndicator = val;
                }
                
                public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    return IsSetFlexProductEligibilityIndicator();
                }
                
                public bool IsSetFlexProductEligibilityIndicator() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FlexProductEligibilityIndicator);
                }
                
                public QuickFix.Fields.ValuationMethod ValuationMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ValuationMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ValuationMethod val) 
                { 
                    ValuationMethod = val;
                }
                
                public QuickFix.Fields.ValuationMethod Get(QuickFix.Fields.ValuationMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ValuationMethod val) 
                { 
                    return IsSetValuationMethod();
                }
                
                public bool IsSetValuationMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ValuationMethod);
                }
                
                public QuickFix.Fields.ContractMultiplierUnit ContractMultiplierUnit
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ContractMultiplierUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContractMultiplierUnit val) 
                { 
                    ContractMultiplierUnit = val;
                }
                
                public QuickFix.Fields.ContractMultiplierUnit Get(QuickFix.Fields.ContractMultiplierUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContractMultiplierUnit val) 
                { 
                    return IsSetContractMultiplierUnit();
                }
                
                public bool IsSetContractMultiplierUnit() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ContractMultiplierUnit);
                }
                
                public QuickFix.Fields.FlowScheduleType FlowScheduleType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.FlowScheduleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FlowScheduleType val) 
                { 
                    FlowScheduleType = val;
                }
                
                public QuickFix.Fields.FlowScheduleType Get(QuickFix.Fields.FlowScheduleType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FlowScheduleType val) 
                { 
                    return IsSetFlowScheduleType();
                }
                
                public bool IsSetFlowScheduleType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.FlowScheduleType);
                }
                
                public QuickFix.Fields.RestructuringType RestructuringType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RestructuringType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RestructuringType val) 
                { 
                    RestructuringType = val;
                }
                
                public QuickFix.Fields.RestructuringType Get(QuickFix.Fields.RestructuringType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RestructuringType val) 
                { 
                    return IsSetRestructuringType();
                }
                
                public bool IsSetRestructuringType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RestructuringType);
                }
                
                public QuickFix.Fields.Seniority Seniority
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Seniority();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Seniority val) 
                { 
                    Seniority = val;
                }
                
                public QuickFix.Fields.Seniority Get(QuickFix.Fields.Seniority val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Seniority val) 
                { 
                    return IsSetSeniority();
                }
                
                public bool IsSetSeniority() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Seniority);
                }
                
                public QuickFix.Fields.NotionalPercentageOutstanding NotionalPercentageOutstanding
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NotionalPercentageOutstanding();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NotionalPercentageOutstanding val) 
                { 
                    NotionalPercentageOutstanding = val;
                }
                
                public QuickFix.Fields.NotionalPercentageOutstanding Get(QuickFix.Fields.NotionalPercentageOutstanding val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NotionalPercentageOutstanding val) 
                { 
                    return IsSetNotionalPercentageOutstanding();
                }
                
                public bool IsSetNotionalPercentageOutstanding() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NotionalPercentageOutstanding);
                }
                
                public QuickFix.Fields.OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OriginalNotionalPercentageOutstanding();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                { 
                    OriginalNotionalPercentageOutstanding = val;
                }
                
                public QuickFix.Fields.OriginalNotionalPercentageOutstanding Get(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                { 
                    return IsSetOriginalNotionalPercentageOutstanding();
                }
                
                public bool IsSetOriginalNotionalPercentageOutstanding() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OriginalNotionalPercentageOutstanding);
                }
                
                public QuickFix.Fields.AttachmentPoint AttachmentPoint
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AttachmentPoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AttachmentPoint val) 
                { 
                    AttachmentPoint = val;
                }
                
                public QuickFix.Fields.AttachmentPoint Get(QuickFix.Fields.AttachmentPoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AttachmentPoint val) 
                { 
                    return IsSetAttachmentPoint();
                }
                
                public bool IsSetAttachmentPoint() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AttachmentPoint);
                }
                
                public QuickFix.Fields.DetachmentPoint DetachmentPoint
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DetachmentPoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DetachmentPoint val) 
                { 
                    DetachmentPoint = val;
                }
                
                public QuickFix.Fields.DetachmentPoint Get(QuickFix.Fields.DetachmentPoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DetachmentPoint val) 
                { 
                    return IsSetDetachmentPoint();
                }
                
                public bool IsSetDetachmentPoint() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DetachmentPoint);
                }
                
                public QuickFix.Fields.StrikePriceDeterminationMethod StrikePriceDeterminationMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikePriceDeterminationMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                { 
                    StrikePriceDeterminationMethod = val;
                }
                
                public QuickFix.Fields.StrikePriceDeterminationMethod Get(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                { 
                    return IsSetStrikePriceDeterminationMethod();
                }
                
                public bool IsSetStrikePriceDeterminationMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikePriceDeterminationMethod);
                }
                
                public QuickFix.Fields.StrikePriceBoundaryMethod StrikePriceBoundaryMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikePriceBoundaryMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                { 
                    StrikePriceBoundaryMethod = val;
                }
                
                public QuickFix.Fields.StrikePriceBoundaryMethod Get(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                { 
                    return IsSetStrikePriceBoundaryMethod();
                }
                
                public bool IsSetStrikePriceBoundaryMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikePriceBoundaryMethod);
                }
                
                public QuickFix.Fields.StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StrikePriceBoundaryPrecision();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                { 
                    StrikePriceBoundaryPrecision = val;
                }
                
                public QuickFix.Fields.StrikePriceBoundaryPrecision Get(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                { 
                    return IsSetStrikePriceBoundaryPrecision();
                }
                
                public bool IsSetStrikePriceBoundaryPrecision() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StrikePriceBoundaryPrecision);
                }
                
                public QuickFix.Fields.UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.UnderlyingPriceDeterminationMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                { 
                    UnderlyingPriceDeterminationMethod = val;
                }
                
                public QuickFix.Fields.UnderlyingPriceDeterminationMethod Get(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                { 
                    return IsSetUnderlyingPriceDeterminationMethod();
                }
                
                public bool IsSetUnderlyingPriceDeterminationMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.UnderlyingPriceDeterminationMethod);
                }
                
                public QuickFix.Fields.OptPayoutType OptPayoutType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OptPayoutType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OptPayoutType val) 
                { 
                    OptPayoutType = val;
                }
                
                public QuickFix.Fields.OptPayoutType Get(QuickFix.Fields.OptPayoutType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OptPayoutType val) 
                { 
                    return IsSetOptPayoutType();
                }
                
                public bool IsSetOptPayoutType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OptPayoutType);
                }
                
                public QuickFix.Fields.NoComplexEvents NoComplexEvents
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoComplexEvents();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoComplexEvents val) 
                { 
                    NoComplexEvents = val;
                }
                
                public QuickFix.Fields.NoComplexEvents Get(QuickFix.Fields.NoComplexEvents val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoComplexEvents val) 
                { 
                    return IsSetNoComplexEvents();
                }
                
                public bool IsSetNoComplexEvents() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoComplexEvents);
                }
                
                public QuickFix.Fields.DeliveryForm DeliveryForm
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DeliveryForm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeliveryForm val) 
                { 
                    DeliveryForm = val;
                }
                
                public QuickFix.Fields.DeliveryForm Get(QuickFix.Fields.DeliveryForm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeliveryForm val) 
                { 
                    return IsSetDeliveryForm();
                }
                
                public bool IsSetDeliveryForm() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DeliveryForm);
                }
                
                public QuickFix.Fields.PctAtRisk PctAtRisk
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PctAtRisk();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PctAtRisk val) 
                { 
                    PctAtRisk = val;
                }
                
                public QuickFix.Fields.PctAtRisk Get(QuickFix.Fields.PctAtRisk val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PctAtRisk val) 
                { 
                    return IsSetPctAtRisk();
                }
                
                public bool IsSetPctAtRisk() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PctAtRisk);
                }
                
                public QuickFix.Fields.NoInstrAttrib NoInstrAttrib
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoInstrAttrib();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    NoInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoInstrAttrib Get(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    return IsSetNoInstrAttrib();
                }
                
                public bool IsSetNoInstrAttrib() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoInstrAttrib);
                }
                
                public QuickFix.Fields.AgreementDesc AgreementDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AgreementDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementDesc val) 
                { 
                    AgreementDesc = val;
                }
                
                public QuickFix.Fields.AgreementDesc Get(QuickFix.Fields.AgreementDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementDesc val) 
                { 
                    return IsSetAgreementDesc();
                }
                
                public bool IsSetAgreementDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AgreementDesc);
                }
                
                public QuickFix.Fields.AgreementID AgreementID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AgreementID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementID val) 
                { 
                    AgreementID = val;
                }
                
                public QuickFix.Fields.AgreementID Get(QuickFix.Fields.AgreementID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementID val) 
                { 
                    return IsSetAgreementID();
                }
                
                public bool IsSetAgreementID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AgreementID);
                }
                
                public QuickFix.Fields.AgreementDate AgreementDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AgreementDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementDate val) 
                { 
                    AgreementDate = val;
                }
                
                public QuickFix.Fields.AgreementDate Get(QuickFix.Fields.AgreementDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementDate val) 
                { 
                    return IsSetAgreementDate();
                }
                
                public bool IsSetAgreementDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AgreementDate);
                }
                
                public QuickFix.Fields.AgreementCurrency AgreementCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AgreementCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementCurrency val) 
                { 
                    AgreementCurrency = val;
                }
                
                public QuickFix.Fields.AgreementCurrency Get(QuickFix.Fields.AgreementCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementCurrency val) 
                { 
                    return IsSetAgreementCurrency();
                }
                
                public bool IsSetAgreementCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AgreementCurrency);
                }
                
                public QuickFix.Fields.TerminationType TerminationType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TerminationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TerminationType val) 
                { 
                    TerminationType = val;
                }
                
                public QuickFix.Fields.TerminationType Get(QuickFix.Fields.TerminationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TerminationType val) 
                { 
                    return IsSetTerminationType();
                }
                
                public bool IsSetTerminationType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TerminationType);
                }
                
                public QuickFix.Fields.StartDate StartDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StartDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StartDate val) 
                { 
                    StartDate = val;
                }
                
                public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StartDate val) 
                { 
                    return IsSetStartDate();
                }
                
                public bool IsSetStartDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StartDate);
                }
                
                public QuickFix.Fields.EndDate EndDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EndDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EndDate val) 
                { 
                    EndDate = val;
                }
                
                public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EndDate val) 
                { 
                    return IsSetEndDate();
                }
                
                public bool IsSetEndDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EndDate);
                }
                
                public QuickFix.Fields.DeliveryType DeliveryType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DeliveryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeliveryType val) 
                { 
                    DeliveryType = val;
                }
                
                public QuickFix.Fields.DeliveryType Get(QuickFix.Fields.DeliveryType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeliveryType val) 
                { 
                    return IsSetDeliveryType();
                }
                
                public bool IsSetDeliveryType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DeliveryType);
                }
                
                public QuickFix.Fields.MarginRatio MarginRatio
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MarginRatio();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarginRatio val) 
                { 
                    MarginRatio = val;
                }
                
                public QuickFix.Fields.MarginRatio Get(QuickFix.Fields.MarginRatio val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarginRatio val) 
                { 
                    return IsSetMarginRatio();
                }
                
                public bool IsSetMarginRatio() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MarginRatio);
                }
                
                public QuickFix.Fields.NoLegs NoLegs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoLegs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegs val) 
                { 
                    NoLegs = val;
                }
                
                public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegs val) 
                { 
                    return IsSetNoLegs();
                }
                
                public bool IsSetNoLegs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoLegs);
                }
                
                public QuickFix.Fields.Spread Spread
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Spread();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Spread val) 
                { 
                    Spread = val;
                }
                
                public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Spread val) 
                { 
                    return IsSetSpread();
                }
                
                public bool IsSetSpread() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Spread);
                }
                
                public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkCurveCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    BenchmarkCurveCurrency = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    return IsSetBenchmarkCurveCurrency();
                }
                
                public bool IsSetBenchmarkCurveCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkCurveCurrency);
                }
                
                public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkCurveName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    BenchmarkCurveName = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    return IsSetBenchmarkCurveName();
                }
                
                public bool IsSetBenchmarkCurveName() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkCurveName);
                }
                
                public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkCurvePoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    BenchmarkCurvePoint = val;
                }
                
                public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    return IsSetBenchmarkCurvePoint();
                }
                
                public bool IsSetBenchmarkCurvePoint() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkCurvePoint);
                }
                
                public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    BenchmarkPrice = val;
                }
                
                public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    return IsSetBenchmarkPrice();
                }
                
                public bool IsSetBenchmarkPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkPrice);
                }
                
                public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    BenchmarkPriceType = val;
                }
                
                public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    return IsSetBenchmarkPriceType();
                }
                
                public bool IsSetBenchmarkPriceType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkPriceType);
                }
                
                public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    BenchmarkSecurityID = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    return IsSetBenchmarkSecurityID();
                }
                
                public bool IsSetBenchmarkSecurityID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkSecurityID);
                }
                
                public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    BenchmarkSecurityIDSource = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    return IsSetBenchmarkSecurityIDSource();
                }
                
                public bool IsSetBenchmarkSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.BenchmarkSecurityIDSource);
                }
                
                public QuickFix.Fields.YieldType YieldType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.YieldType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldType val) 
                { 
                    YieldType = val;
                }
                
                public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldType val) 
                { 
                    return IsSetYieldType();
                }
                
                public bool IsSetYieldType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.YieldType);
                }
                
                public QuickFix.Fields.Yield Yield
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.Yield();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Yield val) 
                { 
                    Yield = val;
                }
                
                public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Yield val) 
                { 
                    return IsSetYield();
                }
                
                public bool IsSetYield() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.Yield);
                }
                
                public QuickFix.Fields.YieldCalcDate YieldCalcDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.YieldCalcDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldCalcDate val) 
                { 
                    YieldCalcDate = val;
                }
                
                public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldCalcDate val) 
                { 
                    return IsSetYieldCalcDate();
                }
                
                public bool IsSetYieldCalcDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.YieldCalcDate);
                }
                
                public QuickFix.Fields.YieldRedemptionDate YieldRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.YieldRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    YieldRedemptionDate = val;
                }
                
                public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    return IsSetYieldRedemptionDate();
                }
                
                public bool IsSetYieldRedemptionDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.YieldRedemptionDate);
                }
                
                public QuickFix.Fields.YieldRedemptionPrice YieldRedemptionPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.YieldRedemptionPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    YieldRedemptionPrice = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    return IsSetYieldRedemptionPrice();
                }
                
                public bool IsSetYieldRedemptionPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.YieldRedemptionPrice);
                }
                
                public QuickFix.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.YieldRedemptionPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    YieldRedemptionPriceType = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    return IsSetYieldRedemptionPriceType();
                }
                
                public bool IsSetYieldRedemptionPriceType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.YieldRedemptionPriceType);
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
                
                public QuickFix.Fields.NoUnderlyings NoUnderlyings
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoUnderlyings();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUnderlyings val) 
                { 
                    NoUnderlyings = val;
                }
                
                public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUnderlyings val) 
                { 
                    return IsSetNoUnderlyings();
                }
                
                public bool IsSetNoUnderlyings() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoUnderlyings);
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
                
                public QuickFix.Fields.NoStipulations NoStipulations
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoStipulations val) 
                { 
                    NoStipulations = val;
                }
                
                public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoStipulations val) 
                { 
                    return IsSetNoStipulations();
                }
                
                public bool IsSetNoStipulations() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoStipulations);
                }
                
                public QuickFix.Fields.ListUpdateAction ListUpdateAction
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ListUpdateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListUpdateAction val) 
                { 
                    ListUpdateAction = val;
                }
                
                public QuickFix.Fields.ListUpdateAction Get(QuickFix.Fields.ListUpdateAction val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListUpdateAction val) 
                { 
                    return IsSetListUpdateAction();
                }
                
                public bool IsSetListUpdateAction() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ListUpdateAction);
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
                
                public QuickFix.Fields.NoTradingSessionRules NoTradingSessionRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoTradingSessionRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    NoTradingSessionRules = val;
                }
                
                public QuickFix.Fields.NoTradingSessionRules Get(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    return IsSetNoTradingSessionRules();
                }
                
                public bool IsSetNoTradingSessionRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoTradingSessionRules);
                }
                
                public QuickFix.Fields.NoNestedInstrAttrib NoNestedInstrAttrib
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoNestedInstrAttrib();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    NoNestedInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoNestedInstrAttrib Get(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    return IsSetNoNestedInstrAttrib();
                }
                
                public bool IsSetNoNestedInstrAttrib() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoNestedInstrAttrib);
                }
                
                public QuickFix.Fields.NoStrikeRules NoStrikeRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoStrikeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoStrikeRules val) 
                { 
                    NoStrikeRules = val;
                }
                
                public QuickFix.Fields.NoStrikeRules Get(QuickFix.Fields.NoStrikeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoStrikeRules val) 
                { 
                    return IsSetNoStrikeRules();
                }
                
                public bool IsSetNoStrikeRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoStrikeRules);
                }
                
                public QuickFix.Fields.RelSymTransactTime RelSymTransactTime
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RelSymTransactTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RelSymTransactTime val) 
                { 
                    RelSymTransactTime = val;
                }
                
                public QuickFix.Fields.RelSymTransactTime Get(QuickFix.Fields.RelSymTransactTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RelSymTransactTime val) 
                { 
                    return IsSetRelSymTransactTime();
                }
                
                public bool IsSetRelSymTransactTime() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RelSymTransactTime);
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
                public class NoEventsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.EventType, QuickFix.Fields.Tags.EventDate, QuickFix.Fields.Tags.EventPx, QuickFix.Fields.Tags.EventText, QuickFix.Fields.Tags.EventTime, 0};
                
                    public NoEventsGroup() 
                      :base( QuickFix.Fields.Tags.NoEvents, QuickFix.Fields.Tags.EventType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoEventsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.EventType EventType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EventType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EventType val) 
                    { 
                        EventType = val;
                    }
                    
                    public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EventType val) 
                    { 
                        return IsSetEventType();
                    }
                    
                    public bool IsSetEventType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EventType);
                    }
                    
                    public QuickFix.Fields.EventDate EventDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EventDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EventDate val) 
                    { 
                        EventDate = val;
                    }
                    
                    public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EventDate val) 
                    { 
                        return IsSetEventDate();
                    }
                    
                    public bool IsSetEventDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EventDate);
                    }
                    
                    public QuickFix.Fields.EventPx EventPx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EventPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EventPx val) 
                    { 
                        EventPx = val;
                    }
                    
                    public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EventPx val) 
                    { 
                        return IsSetEventPx();
                    }
                    
                    public bool IsSetEventPx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EventPx);
                    }
                    
                    public QuickFix.Fields.EventText EventText
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EventText();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EventText val) 
                    { 
                        EventText = val;
                    }
                    
                    public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EventText val) 
                    { 
                        return IsSetEventText();
                    }
                    
                    public bool IsSetEventText() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EventText);
                    }
                    
                    public QuickFix.Fields.EventTime EventTime
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EventTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EventTime val) 
                    { 
                        EventTime = val;
                    }
                    
                    public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EventTime val) 
                    { 
                        return IsSetEventTime();
                    }
                    
                    public bool IsSetEventTime() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EventTime);
                    }
                    
                
                }
                public class NoInstrumentPartiesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.InstrumentPartyID, QuickFix.Fields.Tags.InstrumentPartyIDSource, QuickFix.Fields.Tags.InstrumentPartyRole, QuickFix.Fields.Tags.NoInstrumentPartySubIDs, 0};
                
                    public NoInstrumentPartiesGroup() 
                      :base( QuickFix.Fields.Tags.NoInstrumentParties, QuickFix.Fields.Tags.InstrumentPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrumentPartiesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrumentPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        InstrumentPartyID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        return IsSetInstrumentPartyID();
                    }
                    
                    public bool IsSetInstrumentPartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrumentPartyID);
                    }
                    
                    public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrumentPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        InstrumentPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        return IsSetInstrumentPartyIDSource();
                    }
                    
                    public bool IsSetInstrumentPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrumentPartyIDSource);
                    }
                    
                    public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrumentPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        InstrumentPartyRole = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        return IsSetInstrumentPartyRole();
                    }
                    
                    public bool IsSetInstrumentPartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrumentPartyRole);
                    }
                    
                    public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        NoInstrumentPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        return IsSetNoInstrumentPartySubIDs();
                    }
                    
                    public bool IsSetNoInstrumentPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoInstrumentPartySubIDs);
                    }
                    
                                    public class NoInstrumentPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.InstrumentPartySubID, QuickFix.Fields.Tags.InstrumentPartySubIDType, 0};
                    
                        public NoInstrumentPartySubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoInstrumentPartySubIDs, QuickFix.Fields.Tags.InstrumentPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoInstrumentPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.InstrumentPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            InstrumentPartySubID = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            return IsSetInstrumentPartySubID();
                        }
                        
                        public bool IsSetInstrumentPartySubID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.InstrumentPartySubID);
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.InstrumentPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            InstrumentPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            return IsSetInstrumentPartySubIDType();
                        }
                        
                        public bool IsSetInstrumentPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.InstrumentPartySubIDType);
                        }
                        
                    
                    }
                }
                public class NoComplexEventsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.ComplexEventType, QuickFix.Fields.Tags.ComplexOptPayoutAmount, QuickFix.Fields.Tags.ComplexEventPrice, QuickFix.Fields.Tags.ComplexEventPriceBoundaryMethod, QuickFix.Fields.Tags.ComplexEventPriceBoundaryPrecision, QuickFix.Fields.Tags.ComplexEventPriceTimeType, QuickFix.Fields.Tags.ComplexEventCondition, QuickFix.Fields.Tags.NoComplexEventDates, 0};
                
                    public NoComplexEventsGroup() 
                      :base( QuickFix.Fields.Tags.NoComplexEvents, QuickFix.Fields.Tags.ComplexEventType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoComplexEventsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.ComplexEventType ComplexEventType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexEventType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventType val) 
                    { 
                        ComplexEventType = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventType Get(QuickFix.Fields.ComplexEventType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventType val) 
                    { 
                        return IsSetComplexEventType();
                    }
                    
                    public bool IsSetComplexEventType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexEventType);
                    }
                    
                    public QuickFix.Fields.ComplexOptPayoutAmount ComplexOptPayoutAmount
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexOptPayoutAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexOptPayoutAmount val) 
                    { 
                        ComplexOptPayoutAmount = val;
                    }
                    
                    public QuickFix.Fields.ComplexOptPayoutAmount Get(QuickFix.Fields.ComplexOptPayoutAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexOptPayoutAmount val) 
                    { 
                        return IsSetComplexOptPayoutAmount();
                    }
                    
                    public bool IsSetComplexOptPayoutAmount() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexOptPayoutAmount);
                    }
                    
                    public QuickFix.Fields.ComplexEventPrice ComplexEventPrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexEventPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventPrice val) 
                    { 
                        ComplexEventPrice = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPrice Get(QuickFix.Fields.ComplexEventPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventPrice val) 
                    { 
                        return IsSetComplexEventPrice();
                    }
                    
                    public bool IsSetComplexEventPrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexEventPrice);
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexEventPriceBoundaryMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                    { 
                        ComplexEventPriceBoundaryMethod = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceBoundaryMethod Get(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                    { 
                        return IsSetComplexEventPriceBoundaryMethod();
                    }
                    
                    public bool IsSetComplexEventPriceBoundaryMethod() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexEventPriceBoundaryMethod);
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexEventPriceBoundaryPrecision();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                    { 
                        ComplexEventPriceBoundaryPrecision = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceBoundaryPrecision Get(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                    { 
                        return IsSetComplexEventPriceBoundaryPrecision();
                    }
                    
                    public bool IsSetComplexEventPriceBoundaryPrecision() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexEventPriceBoundaryPrecision);
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceTimeType ComplexEventPriceTimeType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexEventPriceTimeType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventPriceTimeType val) 
                    { 
                        ComplexEventPriceTimeType = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceTimeType Get(QuickFix.Fields.ComplexEventPriceTimeType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventPriceTimeType val) 
                    { 
                        return IsSetComplexEventPriceTimeType();
                    }
                    
                    public bool IsSetComplexEventPriceTimeType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexEventPriceTimeType);
                    }
                    
                    public QuickFix.Fields.ComplexEventCondition ComplexEventCondition
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ComplexEventCondition();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventCondition val) 
                    { 
                        ComplexEventCondition = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventCondition Get(QuickFix.Fields.ComplexEventCondition val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventCondition val) 
                    { 
                        return IsSetComplexEventCondition();
                    }
                    
                    public bool IsSetComplexEventCondition() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ComplexEventCondition);
                    }
                    
                    public QuickFix.Fields.NoComplexEventDates NoComplexEventDates
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoComplexEventDates();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoComplexEventDates val) 
                    { 
                        NoComplexEventDates = val;
                    }
                    
                    public QuickFix.Fields.NoComplexEventDates Get(QuickFix.Fields.NoComplexEventDates val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoComplexEventDates val) 
                    { 
                        return IsSetNoComplexEventDates();
                    }
                    
                    public bool IsSetNoComplexEventDates() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoComplexEventDates);
                    }
                    
                                    public class NoComplexEventDatesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.ComplexEventStartDate, QuickFix.Fields.Tags.ComplexEventEndDate, QuickFix.Fields.Tags.NoComplexEventTimes, 0};
                    
                        public NoComplexEventDatesGroup() 
                          :base( QuickFix.Fields.Tags.NoComplexEventDates, QuickFix.Fields.Tags.ComplexEventStartDate, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoComplexEventDatesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.ComplexEventStartDate ComplexEventStartDate
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.ComplexEventStartDate();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventStartDate val) 
                        { 
                            ComplexEventStartDate = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventStartDate Get(QuickFix.Fields.ComplexEventStartDate val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventStartDate val) 
                        { 
                            return IsSetComplexEventStartDate();
                        }
                        
                        public bool IsSetComplexEventStartDate() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.ComplexEventStartDate);
                        }
                        
                        public QuickFix.Fields.ComplexEventEndDate ComplexEventEndDate
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.ComplexEventEndDate();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventEndDate val) 
                        { 
                            ComplexEventEndDate = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventEndDate Get(QuickFix.Fields.ComplexEventEndDate val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventEndDate val) 
                        { 
                            return IsSetComplexEventEndDate();
                        }
                        
                        public bool IsSetComplexEventEndDate() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.ComplexEventEndDate);
                        }
                        
                        public QuickFix.Fields.NoComplexEventTimes NoComplexEventTimes
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoComplexEventTimes();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoComplexEventTimes val) 
                        { 
                            NoComplexEventTimes = val;
                        }
                        
                        public QuickFix.Fields.NoComplexEventTimes Get(QuickFix.Fields.NoComplexEventTimes val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoComplexEventTimes val) 
                        { 
                            return IsSetNoComplexEventTimes();
                        }
                        
                        public bool IsSetNoComplexEventTimes() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoComplexEventTimes);
                        }
                        
                                            public class NoComplexEventTimesGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.ComplexEventStartTime, QuickFix.Fields.Tags.ComplexEventEndTime, 0};
                        
                            public NoComplexEventTimesGroup() 
                              :base( QuickFix.Fields.Tags.NoComplexEventTimes, QuickFix.Fields.Tags.ComplexEventStartTime, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoComplexEventTimesGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.ComplexEventStartTime ComplexEventStartTime
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.ComplexEventStartTime();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.ComplexEventStartTime val) 
                            { 
                                ComplexEventStartTime = val;
                            }
                            
                            public QuickFix.Fields.ComplexEventStartTime Get(QuickFix.Fields.ComplexEventStartTime val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.ComplexEventStartTime val) 
                            { 
                                return IsSetComplexEventStartTime();
                            }
                            
                            public bool IsSetComplexEventStartTime() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.ComplexEventStartTime);
                            }
                            
                            public QuickFix.Fields.ComplexEventEndTime ComplexEventEndTime
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.ComplexEventEndTime();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.ComplexEventEndTime val) 
                            { 
                                ComplexEventEndTime = val;
                            }
                            
                            public QuickFix.Fields.ComplexEventEndTime Get(QuickFix.Fields.ComplexEventEndTime val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.ComplexEventEndTime val) 
                            { 
                                return IsSetComplexEventEndTime();
                            }
                            
                            public bool IsSetComplexEventEndTime() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.ComplexEventEndTime);
                            }
                            
                        
                        }
                    }
                }
                public class NoInstrAttribGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.InstrAttribType, QuickFix.Fields.Tags.InstrAttribValue, 0};
                
                    public NoInstrAttribGroup() 
                      :base( QuickFix.Fields.Tags.NoInstrAttrib, QuickFix.Fields.Tags.InstrAttribType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrAttribGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrAttribType InstrAttribType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrAttribType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrAttribType val) 
                    { 
                        InstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribType Get(QuickFix.Fields.InstrAttribType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrAttribType val) 
                    { 
                        return IsSetInstrAttribType();
                    }
                    
                    public bool IsSetInstrAttribType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrAttribType);
                    }
                    
                    public QuickFix.Fields.InstrAttribValue InstrAttribValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.InstrAttribValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        InstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribValue Get(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        return IsSetInstrAttribValue();
                    }
                    
                    public bool IsSetInstrAttribValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.InstrAttribValue);
                    }
                    
                
                }
                public class NoLegsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSymbol, QuickFix.Fields.Tags.LegSymbolSfx, QuickFix.Fields.Tags.LegSecurityID, QuickFix.Fields.Tags.LegSecurityIDSource, QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegProduct, QuickFix.Fields.Tags.LegCFICode, QuickFix.Fields.Tags.LegSecurityType, QuickFix.Fields.Tags.LegSecuritySubType, QuickFix.Fields.Tags.LegMaturityMonthYear, QuickFix.Fields.Tags.LegMaturityDate, QuickFix.Fields.Tags.LegCouponPaymentDate, QuickFix.Fields.Tags.LegIssueDate, QuickFix.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.Fields.Tags.LegRepurchaseTerm, QuickFix.Fields.Tags.LegRepurchaseRate, QuickFix.Fields.Tags.LegFactor, QuickFix.Fields.Tags.LegCreditRating, QuickFix.Fields.Tags.LegInstrRegistry, QuickFix.Fields.Tags.LegCountryOfIssue, QuickFix.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.Fields.Tags.LegLocaleOfIssue, QuickFix.Fields.Tags.LegRedemptionDate, QuickFix.Fields.Tags.LegStrikePrice, QuickFix.Fields.Tags.LegStrikeCurrency, QuickFix.Fields.Tags.LegOptAttribute, QuickFix.Fields.Tags.LegContractMultiplier, QuickFix.Fields.Tags.LegCouponRate, QuickFix.Fields.Tags.LegSecurityExchange, QuickFix.Fields.Tags.LegIssuer, QuickFix.Fields.Tags.EncodedLegIssuerLen, QuickFix.Fields.Tags.EncodedLegIssuer, QuickFix.Fields.Tags.LegSecurityDesc, QuickFix.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.Fields.Tags.EncodedLegSecurityDesc, QuickFix.Fields.Tags.LegRatioQty, QuickFix.Fields.Tags.LegSide, QuickFix.Fields.Tags.LegCurrency, QuickFix.Fields.Tags.LegPool, QuickFix.Fields.Tags.LegDatedDate, QuickFix.Fields.Tags.LegContractSettlMonth, QuickFix.Fields.Tags.LegInterestAccrualDate, QuickFix.Fields.Tags.LegUnitOfMeasure, QuickFix.Fields.Tags.LegTimeUnit, QuickFix.Fields.Tags.LegOptionRatio, QuickFix.Fields.Tags.LegPrice, QuickFix.Fields.Tags.LegMaturityTime, QuickFix.Fields.Tags.LegPutOrCall, QuickFix.Fields.Tags.LegExerciseStyle, QuickFix.Fields.Tags.LegUnitOfMeasureQty, QuickFix.Fields.Tags.LegPriceUnitOfMeasure, QuickFix.Fields.Tags.LegPriceUnitOfMeasureQty, QuickFix.Fields.Tags.LegContractMultiplierUnit, QuickFix.Fields.Tags.LegFlowScheduleType, QuickFix.Fields.Tags.LegSwapType, QuickFix.Fields.Tags.LegSettlType, QuickFix.Fields.Tags.NoLegStipulations, QuickFix.Fields.Tags.LegBenchmarkCurveCurrency, QuickFix.Fields.Tags.LegBenchmarkCurveName, QuickFix.Fields.Tags.LegBenchmarkCurvePoint, QuickFix.Fields.Tags.LegBenchmarkPrice, QuickFix.Fields.Tags.LegBenchmarkPriceType, 0};
                
                    public NoLegsGroup() 
                      :base( QuickFix.Fields.Tags.NoLegs, QuickFix.Fields.Tags.LegSymbol, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegSymbol LegSymbol
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSymbol();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSymbol val) 
                    { 
                        LegSymbol = val;
                    }
                    
                    public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSymbol val) 
                    { 
                        return IsSetLegSymbol();
                    }
                    
                    public bool IsSetLegSymbol() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSymbol);
                    }
                    
                    public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSymbolSfx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        LegSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        return IsSetLegSymbolSfx();
                    }
                    
                    public bool IsSetLegSymbolSfx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSymbolSfx);
                    }
                    
                    public QuickFix.Fields.LegSecurityID LegSecurityID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityID val) 
                    { 
                        LegSecurityID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                    { 
                        return IsSetLegSecurityID();
                    }
                    
                    public bool IsSetLegSecurityID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityID);
                    }
                    
                    public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        LegSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        return IsSetLegSecurityIDSource();
                    }
                    
                    public bool IsSetLegSecurityIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityIDSource);
                    }
                    
                    public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoLegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        NoLegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        return IsSetNoLegSecurityAltID();
                    }
                    
                    public bool IsSetNoLegSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoLegSecurityAltID);
                    }
                    
                    public QuickFix.Fields.LegProduct LegProduct
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegProduct();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegProduct val) 
                    { 
                        LegProduct = val;
                    }
                    
                    public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegProduct val) 
                    { 
                        return IsSetLegProduct();
                    }
                    
                    public bool IsSetLegProduct() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegProduct);
                    }
                    
                    public QuickFix.Fields.LegCFICode LegCFICode
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegCFICode();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCFICode val) 
                    { 
                        LegCFICode = val;
                    }
                    
                    public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCFICode val) 
                    { 
                        return IsSetLegCFICode();
                    }
                    
                    public bool IsSetLegCFICode() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegCFICode);
                    }
                    
                    public QuickFix.Fields.LegSecurityType LegSecurityType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityType val) 
                    { 
                        LegSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                    { 
                        return IsSetLegSecurityType();
                    }
                    
                    public bool IsSetLegSecurityType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityType);
                    }
                    
                    public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecuritySubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        LegSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        return IsSetLegSecuritySubType();
                    }
                    
                    public bool IsSetLegSecuritySubType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecuritySubType);
                    }
                    
                    public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegMaturityMonthYear();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        LegMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        return IsSetLegMaturityMonthYear();
                    }
                    
                    public bool IsSetLegMaturityMonthYear() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegMaturityMonthYear);
                    }
                    
                    public QuickFix.Fields.LegMaturityDate LegMaturityDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegMaturityDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        LegMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        return IsSetLegMaturityDate();
                    }
                    
                    public bool IsSetLegMaturityDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegMaturityDate);
                    }
                    
                    public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegCouponPaymentDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        LegCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        return IsSetLegCouponPaymentDate();
                    }
                    
                    public bool IsSetLegCouponPaymentDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegCouponPaymentDate);
                    }
                    
                    public QuickFix.Fields.LegIssueDate LegIssueDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegIssueDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIssueDate val) 
                    { 
                        LegIssueDate = val;
                    }
                    
                    public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                    { 
                        return IsSetLegIssueDate();
                    }
                    
                    public bool IsSetLegIssueDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegIssueDate);
                    }
                    
                    public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        LegRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        return IsSetLegRepoCollateralSecurityType();
                    }
                    
                    public bool IsSetLegRepoCollateralSecurityType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegRepoCollateralSecurityType);
                    }
                    
                    public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegRepurchaseTerm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        LegRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        return IsSetLegRepurchaseTerm();
                    }
                    
                    public bool IsSetLegRepurchaseTerm() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegRepurchaseTerm);
                    }
                    
                    public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegRepurchaseRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        LegRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        return IsSetLegRepurchaseRate();
                    }
                    
                    public bool IsSetLegRepurchaseRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegRepurchaseRate);
                    }
                    
                    public QuickFix.Fields.LegFactor LegFactor
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegFactor();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegFactor val) 
                    { 
                        LegFactor = val;
                    }
                    
                    public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegFactor val) 
                    { 
                        return IsSetLegFactor();
                    }
                    
                    public bool IsSetLegFactor() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegFactor);
                    }
                    
                    public QuickFix.Fields.LegCreditRating LegCreditRating
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegCreditRating();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCreditRating val) 
                    { 
                        LegCreditRating = val;
                    }
                    
                    public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                    { 
                        return IsSetLegCreditRating();
                    }
                    
                    public bool IsSetLegCreditRating() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegCreditRating);
                    }
                    
                    public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegInstrRegistry();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        LegInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        return IsSetLegInstrRegistry();
                    }
                    
                    public bool IsSetLegInstrRegistry() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegInstrRegistry);
                    }
                    
                    public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegCountryOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        LegCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        return IsSetLegCountryOfIssue();
                    }
                    
                    public bool IsSetLegCountryOfIssue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegCountryOfIssue);
                    }
                    
                    public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        LegStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        return IsSetLegStateOrProvinceOfIssue();
                    }
                    
                    public bool IsSetLegStateOrProvinceOfIssue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegStateOrProvinceOfIssue);
                    }
                    
                    public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegLocaleOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        LegLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        return IsSetLegLocaleOfIssue();
                    }
                    
                    public bool IsSetLegLocaleOfIssue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegLocaleOfIssue);
                    }
                    
                    public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegRedemptionDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        LegRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        return IsSetLegRedemptionDate();
                    }
                    
                    public bool IsSetLegRedemptionDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegRedemptionDate);
                    }
                    
                    public QuickFix.Fields.LegStrikePrice LegStrikePrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegStrikePrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        LegStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        return IsSetLegStrikePrice();
                    }
                    
                    public bool IsSetLegStrikePrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegStrikePrice);
                    }
                    
                    public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegStrikeCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        LegStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        return IsSetLegStrikeCurrency();
                    }
                    
                    public bool IsSetLegStrikeCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegStrikeCurrency);
                    }
                    
                    public QuickFix.Fields.LegOptAttribute LegOptAttribute
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegOptAttribute();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        LegOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        return IsSetLegOptAttribute();
                    }
                    
                    public bool IsSetLegOptAttribute() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegOptAttribute);
                    }
                    
                    public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegContractMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        LegContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        return IsSetLegContractMultiplier();
                    }
                    
                    public bool IsSetLegContractMultiplier() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegContractMultiplier);
                    }
                    
                    public QuickFix.Fields.LegCouponRate LegCouponRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegCouponRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCouponRate val) 
                    { 
                        LegCouponRate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                    { 
                        return IsSetLegCouponRate();
                    }
                    
                    public bool IsSetLegCouponRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegCouponRate);
                    }
                    
                    public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityExchange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        LegSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        return IsSetLegSecurityExchange();
                    }
                    
                    public bool IsSetLegSecurityExchange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityExchange);
                    }
                    
                    public QuickFix.Fields.LegIssuer LegIssuer
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIssuer val) 
                    { 
                        LegIssuer = val;
                    }
                    
                    public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIssuer val) 
                    { 
                        return IsSetLegIssuer();
                    }
                    
                    public bool IsSetLegIssuer() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegIssuer);
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedLegIssuerLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        EncodedLegIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        return IsSetEncodedLegIssuerLen();
                    }
                    
                    public bool IsSetEncodedLegIssuerLen() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedLegIssuerLen);
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedLegIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        EncodedLegIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        return IsSetEncodedLegIssuer();
                    }
                    
                    public bool IsSetEncodedLegIssuer() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedLegIssuer);
                    }
                    
                    public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        LegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        return IsSetLegSecurityDesc();
                    }
                    
                    public bool IsSetLegSecurityDesc() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityDesc);
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        EncodedLegSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        return IsSetEncodedLegSecurityDescLen();
                    }
                    
                    public bool IsSetEncodedLegSecurityDescLen() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedLegSecurityDescLen);
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedLegSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        EncodedLegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        return IsSetEncodedLegSecurityDesc();
                    }
                    
                    public bool IsSetEncodedLegSecurityDesc() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedLegSecurityDesc);
                    }
                    
                    public QuickFix.Fields.LegRatioQty LegRatioQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegRatioQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRatioQty val) 
                    { 
                        LegRatioQty = val;
                    }
                    
                    public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                    { 
                        return IsSetLegRatioQty();
                    }
                    
                    public bool IsSetLegRatioQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegRatioQty);
                    }
                    
                    public QuickFix.Fields.LegSide LegSide
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSide();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSide val) 
                    { 
                        LegSide = val;
                    }
                    
                    public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSide val) 
                    { 
                        return IsSetLegSide();
                    }
                    
                    public bool IsSetLegSide() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSide);
                    }
                    
                    public QuickFix.Fields.LegCurrency LegCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCurrency val) 
                    { 
                        LegCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCurrency val) 
                    { 
                        return IsSetLegCurrency();
                    }
                    
                    public bool IsSetLegCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegCurrency);
                    }
                    
                    public QuickFix.Fields.LegPool LegPool
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPool();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPool val) 
                    { 
                        LegPool = val;
                    }
                    
                    public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPool val) 
                    { 
                        return IsSetLegPool();
                    }
                    
                    public bool IsSetLegPool() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPool);
                    }
                    
                    public QuickFix.Fields.LegDatedDate LegDatedDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegDatedDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegDatedDate val) 
                    { 
                        LegDatedDate = val;
                    }
                    
                    public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                    { 
                        return IsSetLegDatedDate();
                    }
                    
                    public bool IsSetLegDatedDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegDatedDate);
                    }
                    
                    public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegContractSettlMonth();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        LegContractSettlMonth = val;
                    }
                    
                    public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        return IsSetLegContractSettlMonth();
                    }
                    
                    public bool IsSetLegContractSettlMonth() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegContractSettlMonth);
                    }
                    
                    public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegInterestAccrualDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        LegInterestAccrualDate = val;
                    }
                    
                    public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        return IsSetLegInterestAccrualDate();
                    }
                    
                    public bool IsSetLegInterestAccrualDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegInterestAccrualDate);
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure LegUnitOfMeasure
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        LegUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        return IsSetLegUnitOfMeasure();
                    }
                    
                    public bool IsSetLegUnitOfMeasure() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegUnitOfMeasure);
                    }
                    
                    public QuickFix.Fields.LegTimeUnit LegTimeUnit
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegTimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        LegTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        return IsSetLegTimeUnit();
                    }
                    
                    public bool IsSetLegTimeUnit() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegTimeUnit);
                    }
                    
                    public QuickFix.Fields.LegOptionRatio LegOptionRatio
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegOptionRatio();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        LegOptionRatio = val;
                    }
                    
                    public QuickFix.Fields.LegOptionRatio Get(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        return IsSetLegOptionRatio();
                    }
                    
                    public bool IsSetLegOptionRatio() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegOptionRatio);
                    }
                    
                    public QuickFix.Fields.LegPrice LegPrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPrice val) 
                    { 
                        LegPrice = val;
                    }
                    
                    public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPrice val) 
                    { 
                        return IsSetLegPrice();
                    }
                    
                    public bool IsSetLegPrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPrice);
                    }
                    
                    public QuickFix.Fields.LegMaturityTime LegMaturityTime
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegMaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        LegMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityTime Get(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        return IsSetLegMaturityTime();
                    }
                    
                    public bool IsSetLegMaturityTime() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegMaturityTime);
                    }
                    
                    public QuickFix.Fields.LegPutOrCall LegPutOrCall
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        LegPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.LegPutOrCall Get(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        return IsSetLegPutOrCall();
                    }
                    
                    public bool IsSetLegPutOrCall() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPutOrCall);
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle LegExerciseStyle
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        LegExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle Get(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        return IsSetLegExerciseStyle();
                    }
                    
                    public bool IsSetLegExerciseStyle() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegExerciseStyle);
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty LegUnitOfMeasureQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        LegUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty Get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        return IsSetLegUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegUnitOfMeasureQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegUnitOfMeasureQty);
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure LegPriceUnitOfMeasure
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        LegPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure Get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        return IsSetLegPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasure() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPriceUnitOfMeasure);
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        LegPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty Get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        return IsSetLegPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegPriceUnitOfMeasureQty);
                    }
                    
                    public QuickFix.Fields.LegContractMultiplierUnit LegContractMultiplierUnit
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegContractMultiplierUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractMultiplierUnit val) 
                    { 
                        LegContractMultiplierUnit = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplierUnit Get(QuickFix.Fields.LegContractMultiplierUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractMultiplierUnit val) 
                    { 
                        return IsSetLegContractMultiplierUnit();
                    }
                    
                    public bool IsSetLegContractMultiplierUnit() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegContractMultiplierUnit);
                    }
                    
                    public QuickFix.Fields.LegFlowScheduleType LegFlowScheduleType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegFlowScheduleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegFlowScheduleType val) 
                    { 
                        LegFlowScheduleType = val;
                    }
                    
                    public QuickFix.Fields.LegFlowScheduleType Get(QuickFix.Fields.LegFlowScheduleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegFlowScheduleType val) 
                    { 
                        return IsSetLegFlowScheduleType();
                    }
                    
                    public bool IsSetLegFlowScheduleType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegFlowScheduleType);
                    }
                    
                    public QuickFix.Fields.LegSwapType LegSwapType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSwapType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSwapType val) 
                    { 
                        LegSwapType = val;
                    }
                    
                    public QuickFix.Fields.LegSwapType Get(QuickFix.Fields.LegSwapType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSwapType val) 
                    { 
                        return IsSetLegSwapType();
                    }
                    
                    public bool IsSetLegSwapType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSwapType);
                    }
                    
                    public QuickFix.Fields.LegSettlType LegSettlType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSettlType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSettlType val) 
                    { 
                        LegSettlType = val;
                    }
                    
                    public QuickFix.Fields.LegSettlType Get(QuickFix.Fields.LegSettlType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSettlType val) 
                    { 
                        return IsSetLegSettlType();
                    }
                    
                    public bool IsSetLegSettlType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSettlType);
                    }
                    
                    public QuickFix.Fields.NoLegStipulations NoLegStipulations
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoLegStipulations();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoLegStipulations val) 
                    { 
                        NoLegStipulations = val;
                    }
                    
                    public QuickFix.Fields.NoLegStipulations Get(QuickFix.Fields.NoLegStipulations val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoLegStipulations val) 
                    { 
                        return IsSetNoLegStipulations();
                    }
                    
                    public bool IsSetNoLegStipulations() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoLegStipulations);
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurveCurrency LegBenchmarkCurveCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegBenchmarkCurveCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkCurveCurrency val) 
                    { 
                        LegBenchmarkCurveCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurveCurrency Get(QuickFix.Fields.LegBenchmarkCurveCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkCurveCurrency val) 
                    { 
                        return IsSetLegBenchmarkCurveCurrency();
                    }
                    
                    public bool IsSetLegBenchmarkCurveCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegBenchmarkCurveCurrency);
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurveName LegBenchmarkCurveName
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegBenchmarkCurveName();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkCurveName val) 
                    { 
                        LegBenchmarkCurveName = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurveName Get(QuickFix.Fields.LegBenchmarkCurveName val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkCurveName val) 
                    { 
                        return IsSetLegBenchmarkCurveName();
                    }
                    
                    public bool IsSetLegBenchmarkCurveName() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegBenchmarkCurveName);
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurvePoint LegBenchmarkCurvePoint
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegBenchmarkCurvePoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkCurvePoint val) 
                    { 
                        LegBenchmarkCurvePoint = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurvePoint Get(QuickFix.Fields.LegBenchmarkCurvePoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkCurvePoint val) 
                    { 
                        return IsSetLegBenchmarkCurvePoint();
                    }
                    
                    public bool IsSetLegBenchmarkCurvePoint() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegBenchmarkCurvePoint);
                    }
                    
                    public QuickFix.Fields.LegBenchmarkPrice LegBenchmarkPrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegBenchmarkPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkPrice val) 
                    { 
                        LegBenchmarkPrice = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkPrice Get(QuickFix.Fields.LegBenchmarkPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkPrice val) 
                    { 
                        return IsSetLegBenchmarkPrice();
                    }
                    
                    public bool IsSetLegBenchmarkPrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegBenchmarkPrice);
                    }
                    
                    public QuickFix.Fields.LegBenchmarkPriceType LegBenchmarkPriceType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegBenchmarkPriceType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkPriceType val) 
                    { 
                        LegBenchmarkPriceType = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkPriceType Get(QuickFix.Fields.LegBenchmarkPriceType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkPriceType val) 
                    { 
                        return IsSetLegBenchmarkPriceType();
                    }
                    
                    public bool IsSetLegBenchmarkPriceType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegBenchmarkPriceType);
                    }
                    
                                    public class NoLegSecurityAltIDGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSecurityAltID, QuickFix.Fields.Tags.LegSecurityAltIDSource, 0};
                    
                        public NoLegSecurityAltIDGroup() 
                          :base( QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegSecurityAltID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoLegSecurityAltIDGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.LegSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            LegSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            return IsSetLegSecurityAltID();
                        }
                        
                        public bool IsSetLegSecurityAltID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.LegSecurityAltID);
                        }
                        
                        public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.LegSecurityAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            LegSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            return IsSetLegSecurityAltIDSource();
                        }
                        
                        public bool IsSetLegSecurityAltIDSource() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.LegSecurityAltIDSource);
                        }
                        
                    
                    }
                    public class NoLegStipulationsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.LegStipulationType, QuickFix.Fields.Tags.LegStipulationValue, 0};
                    
                        public NoLegStipulationsGroup() 
                          :base( QuickFix.Fields.Tags.NoLegStipulations, QuickFix.Fields.Tags.LegStipulationType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoLegStipulationsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.LegStipulationType LegStipulationType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.LegStipulationType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegStipulationType val) 
                        { 
                            LegStipulationType = val;
                        }
                        
                        public QuickFix.Fields.LegStipulationType Get(QuickFix.Fields.LegStipulationType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegStipulationType val) 
                        { 
                            return IsSetLegStipulationType();
                        }
                        
                        public bool IsSetLegStipulationType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.LegStipulationType);
                        }
                        
                        public QuickFix.Fields.LegStipulationValue LegStipulationValue
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.LegStipulationValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegStipulationValue val) 
                        { 
                            LegStipulationValue = val;
                        }
                        
                        public QuickFix.Fields.LegStipulationValue Get(QuickFix.Fields.LegStipulationValue val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegStipulationValue val) 
                        { 
                            return IsSetLegStipulationValue();
                        }
                        
                        public bool IsSetLegStipulationValue() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.LegStipulationValue);
                        }
                        
                    
                    }
                }
                public class NoUnderlyingsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingSymbol, QuickFix.Fields.Tags.UnderlyingSymbolSfx, QuickFix.Fields.Tags.UnderlyingSecurityID, QuickFix.Fields.Tags.UnderlyingSecurityIDSource, QuickFix.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingProduct, QuickFix.Fields.Tags.UnderlyingCFICode, QuickFix.Fields.Tags.UnderlyingSecurityType, QuickFix.Fields.Tags.UnderlyingSecuritySubType, QuickFix.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.Fields.Tags.UnderlyingMaturityDate, QuickFix.Fields.Tags.UnderlyingCouponPaymentDate, QuickFix.Fields.Tags.UnderlyingIssueDate, QuickFix.Fields.Tags.UnderlyingRepoCollateralSecurityType, QuickFix.Fields.Tags.UnderlyingRepurchaseTerm, QuickFix.Fields.Tags.UnderlyingRepurchaseRate, QuickFix.Fields.Tags.UnderlyingFactor, QuickFix.Fields.Tags.UnderlyingCreditRating, QuickFix.Fields.Tags.UnderlyingInstrRegistry, QuickFix.Fields.Tags.UnderlyingCountryOfIssue, QuickFix.Fields.Tags.UnderlyingStateOrProvinceOfIssue, QuickFix.Fields.Tags.UnderlyingLocaleOfIssue, QuickFix.Fields.Tags.UnderlyingRedemptionDate, QuickFix.Fields.Tags.UnderlyingStrikePrice, QuickFix.Fields.Tags.UnderlyingStrikeCurrency, QuickFix.Fields.Tags.UnderlyingOptAttribute, QuickFix.Fields.Tags.UnderlyingContractMultiplier, QuickFix.Fields.Tags.UnderlyingCouponRate, QuickFix.Fields.Tags.UnderlyingSecurityExchange, QuickFix.Fields.Tags.UnderlyingIssuer, QuickFix.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.Fields.Tags.UnderlyingSecurityDesc, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.Fields.Tags.UnderlyingCPProgram, QuickFix.Fields.Tags.UnderlyingCPRegType, QuickFix.Fields.Tags.UnderlyingCurrency, QuickFix.Fields.Tags.UnderlyingQty, QuickFix.Fields.Tags.UnderlyingPx, QuickFix.Fields.Tags.UnderlyingDirtyPrice, QuickFix.Fields.Tags.UnderlyingEndPrice, QuickFix.Fields.Tags.UnderlyingStartValue, QuickFix.Fields.Tags.UnderlyingCurrentValue, QuickFix.Fields.Tags.UnderlyingEndValue, QuickFix.Fields.Tags.NoUnderlyingStips, QuickFix.Fields.Tags.UnderlyingAllocationPercent, QuickFix.Fields.Tags.UnderlyingSettlementType, QuickFix.Fields.Tags.UnderlyingCashAmount, QuickFix.Fields.Tags.UnderlyingCashType, QuickFix.Fields.Tags.UnderlyingUnitOfMeasure, QuickFix.Fields.Tags.UnderlyingTimeUnit, QuickFix.Fields.Tags.UnderlyingCapValue, QuickFix.Fields.Tags.NoUndlyInstrumentParties, QuickFix.Fields.Tags.UnderlyingSettlMethod, QuickFix.Fields.Tags.UnderlyingAdjustedQuantity, QuickFix.Fields.Tags.UnderlyingFXRate, QuickFix.Fields.Tags.UnderlyingFXRateCalc, QuickFix.Fields.Tags.UnderlyingMaturityTime, QuickFix.Fields.Tags.UnderlyingPutOrCall, QuickFix.Fields.Tags.UnderlyingExerciseStyle, QuickFix.Fields.Tags.UnderlyingUnitOfMeasureQty, QuickFix.Fields.Tags.UnderlyingPriceUnitOfMeasure, QuickFix.Fields.Tags.UnderlyingPriceUnitOfMeasureQty, QuickFix.Fields.Tags.UnderlyingContractMultiplierUnit, QuickFix.Fields.Tags.UnderlyingFlowScheduleType, QuickFix.Fields.Tags.UnderlyingRestructuringType, QuickFix.Fields.Tags.UnderlyingSeniority, QuickFix.Fields.Tags.UnderlyingNotionalPercentageOutstanding, QuickFix.Fields.Tags.UnderlyingOriginalNotionalPercentageOutstanding, QuickFix.Fields.Tags.UnderlyingAttachmentPoint, QuickFix.Fields.Tags.UnderlyingDetachmentPoint, 0};
                
                    public NoUnderlyingsGroup() 
                      :base( QuickFix.Fields.Tags.NoUnderlyings, QuickFix.Fields.Tags.UnderlyingSymbol, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSymbol();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSymbol val) 
                    { 
                        UnderlyingSymbol = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
                    { 
                        return IsSetUnderlyingSymbol();
                    }
                    
                    public bool IsSetUnderlyingSymbol() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSymbol);
                    }
                    
                    public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSymbolSfx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) 
                    { 
                        UnderlyingSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
                    { 
                        return IsSetUnderlyingSymbolSfx();
                    }
                    
                    public bool IsSetUnderlyingSymbolSfx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSymbolSfx);
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSecurityID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
                    { 
                        UnderlyingSecurityID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
                    { 
                        return IsSetUnderlyingSecurityID();
                    }
                    
                    public bool IsSetUnderlyingSecurityID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityID);
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        UnderlyingSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityIDSource);
                    }
                    
                    public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        NoUnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        return IsSetNoUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetNoUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoUnderlyingSecurityAltID);
                    }
                    
                    public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingProduct();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        UnderlyingProduct = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        return IsSetUnderlyingProduct();
                    }
                    
                    public bool IsSetUnderlyingProduct() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingProduct);
                    }
                    
                    public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCFICode();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        UnderlyingCFICode = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        return IsSetUnderlyingCFICode();
                    }
                    
                    public bool IsSetUnderlyingCFICode() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCFICode);
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityType val) 
                    { 
                        UnderlyingSecurityType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) 
                    { 
                        return IsSetUnderlyingSecurityType();
                    }
                    
                    public bool IsSetUnderlyingSecurityType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityType);
                    }
                    
                    public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSecuritySubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        UnderlyingSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        return IsSetUnderlyingSecuritySubType();
                    }
                    
                    public bool IsSetUnderlyingSecuritySubType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSecuritySubType);
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                    { 
                        UnderlyingMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                    { 
                        return IsSetUnderlyingMaturityMonthYear();
                    }
                    
                    public bool IsSetUnderlyingMaturityMonthYear() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityMonthYear);
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingMaturityDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        UnderlyingMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        return IsSetUnderlyingMaturityDate();
                    }
                    
                    public bool IsSetUnderlyingMaturityDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityDate);
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        UnderlyingCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        return IsSetUnderlyingCouponPaymentDate();
                    }
                    
                    public bool IsSetUnderlyingCouponPaymentDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCouponPaymentDate);
                    }
                    
                    public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingIssueDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        UnderlyingIssueDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        return IsSetUnderlyingIssueDate();
                    }
                    
                    public bool IsSetUnderlyingIssueDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingIssueDate);
                    }
                    
                    public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        UnderlyingRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        return IsSetUnderlyingRepoCollateralSecurityType();
                    }
                    
                    public bool IsSetUnderlyingRepoCollateralSecurityType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingRepoCollateralSecurityType);
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        UnderlyingRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        return IsSetUnderlyingRepurchaseTerm();
                    }
                    
                    public bool IsSetUnderlyingRepurchaseTerm() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingRepurchaseTerm);
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        UnderlyingRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        return IsSetUnderlyingRepurchaseRate();
                    }
                    
                    public bool IsSetUnderlyingRepurchaseRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingRepurchaseRate);
                    }
                    
                    public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingFactor();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        UnderlyingFactor = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        return IsSetUnderlyingFactor();
                    }
                    
                    public bool IsSetUnderlyingFactor() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingFactor);
                    }
                    
                    public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCreditRating();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        UnderlyingCreditRating = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        return IsSetUnderlyingCreditRating();
                    }
                    
                    public bool IsSetUnderlyingCreditRating() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCreditRating);
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingInstrRegistry();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        UnderlyingInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        return IsSetUnderlyingInstrRegistry();
                    }
                    
                    public bool IsSetUnderlyingInstrRegistry() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrRegistry);
                    }
                    
                    public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        UnderlyingCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        return IsSetUnderlyingCountryOfIssue();
                    }
                    
                    public bool IsSetUnderlyingCountryOfIssue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCountryOfIssue);
                    }
                    
                    public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        UnderlyingStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        return IsSetUnderlyingStateOrProvinceOfIssue();
                    }
                    
                    public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingStateOrProvinceOfIssue);
                    }
                    
                    public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        UnderlyingLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        return IsSetUnderlyingLocaleOfIssue();
                    }
                    
                    public bool IsSetUnderlyingLocaleOfIssue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingLocaleOfIssue);
                    }
                    
                    public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingRedemptionDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        UnderlyingRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        return IsSetUnderlyingRedemptionDate();
                    }
                    
                    public bool IsSetUnderlyingRedemptionDate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingRedemptionDate);
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingStrikePrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
                    { 
                        UnderlyingStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
                    { 
                        return IsSetUnderlyingStrikePrice();
                    }
                    
                    public bool IsSetUnderlyingStrikePrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingStrikePrice);
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        UnderlyingStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        return IsSetUnderlyingStrikeCurrency();
                    }
                    
                    public bool IsSetUnderlyingStrikeCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingStrikeCurrency);
                    }
                    
                    public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingOptAttribute();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingOptAttribute val) 
                    { 
                        UnderlyingOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) 
                    { 
                        return IsSetUnderlyingOptAttribute();
                    }
                    
                    public bool IsSetUnderlyingOptAttribute() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingOptAttribute);
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingContractMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
                    { 
                        UnderlyingContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
                    { 
                        return IsSetUnderlyingContractMultiplier();
                    }
                    
                    public bool IsSetUnderlyingContractMultiplier() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingContractMultiplier);
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCouponRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
                    { 
                        UnderlyingCouponRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
                    { 
                        return IsSetUnderlyingCouponRate();
                    }
                    
                    public bool IsSetUnderlyingCouponRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCouponRate);
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSecurityExchange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
                    { 
                        UnderlyingSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
                    { 
                        return IsSetUnderlyingSecurityExchange();
                    }
                    
                    public bool IsSetUnderlyingSecurityExchange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityExchange);
                    }
                    
                    public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingIssuer val) 
                    { 
                        UnderlyingIssuer = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) 
                    { 
                        return IsSetUnderlyingIssuer();
                    }
                    
                    public bool IsSetUnderlyingIssuer() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingIssuer);
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                    { 
                        EncodedUnderlyingIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                    { 
                        return IsSetEncodedUnderlyingIssuerLen();
                    }
                    
                    public bool IsSetEncodedUnderlyingIssuerLen() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingIssuerLen);
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                    { 
                        EncodedUnderlyingIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                    { 
                        return IsSetEncodedUnderlyingIssuer();
                    }
                    
                    public bool IsSetEncodedUnderlyingIssuer() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingIssuer);
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
                    { 
                        UnderlyingSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
                    { 
                        return IsSetUnderlyingSecurityDesc();
                    }
                    
                    public bool IsSetUnderlyingSecurityDesc() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityDesc);
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                    { 
                        EncodedUnderlyingSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                    { 
                        return IsSetEncodedUnderlyingSecurityDescLen();
                    }
                    
                    public bool IsSetEncodedUnderlyingSecurityDescLen() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingSecurityDescLen);
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                    { 
                        EncodedUnderlyingSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                    { 
                        return IsSetEncodedUnderlyingSecurityDesc();
                    }
                    
                    public bool IsSetEncodedUnderlyingSecurityDesc() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EncodedUnderlyingSecurityDesc);
                    }
                    
                    public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCPProgram();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        UnderlyingCPProgram = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        return IsSetUnderlyingCPProgram();
                    }
                    
                    public bool IsSetUnderlyingCPProgram() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCPProgram);
                    }
                    
                    public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCPRegType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        UnderlyingCPRegType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        return IsSetUnderlyingCPRegType();
                    }
                    
                    public bool IsSetUnderlyingCPRegType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCPRegType);
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        UnderlyingCurrency = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        return IsSetUnderlyingCurrency();
                    }
                    
                    public bool IsSetUnderlyingCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCurrency);
                    }
                    
                    public QuickFix.Fields.UnderlyingQty UnderlyingQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        UnderlyingQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        return IsSetUnderlyingQty();
                    }
                    
                    public bool IsSetUnderlyingQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingQty);
                    }
                    
                    public QuickFix.Fields.UnderlyingPx UnderlyingPx
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        UnderlyingPx = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        return IsSetUnderlyingPx();
                    }
                    
                    public bool IsSetUnderlyingPx() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingPx);
                    }
                    
                    public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingDirtyPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        UnderlyingDirtyPrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        return IsSetUnderlyingDirtyPrice();
                    }
                    
                    public bool IsSetUnderlyingDirtyPrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingDirtyPrice);
                    }
                    
                    public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingEndPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        UnderlyingEndPrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        return IsSetUnderlyingEndPrice();
                    }
                    
                    public bool IsSetUnderlyingEndPrice() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingEndPrice);
                    }
                    
                    public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingStartValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        UnderlyingStartValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        return IsSetUnderlyingStartValue();
                    }
                    
                    public bool IsSetUnderlyingStartValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingStartValue);
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCurrentValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        UnderlyingCurrentValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        return IsSetUnderlyingCurrentValue();
                    }
                    
                    public bool IsSetUnderlyingCurrentValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCurrentValue);
                    }
                    
                    public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingEndValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        UnderlyingEndValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        return IsSetUnderlyingEndValue();
                    }
                    
                    public bool IsSetUnderlyingEndValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingEndValue);
                    }
                    
                    public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoUnderlyingStips();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        NoUnderlyingStips = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        return IsSetNoUnderlyingStips();
                    }
                    
                    public bool IsSetNoUnderlyingStips() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoUnderlyingStips);
                    }
                    
                    public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingAllocationPercent();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        UnderlyingAllocationPercent = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        return IsSetUnderlyingAllocationPercent();
                    }
                    
                    public bool IsSetUnderlyingAllocationPercent() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingAllocationPercent);
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSettlementType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        UnderlyingSettlementType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        return IsSetUnderlyingSettlementType();
                    }
                    
                    public bool IsSetUnderlyingSettlementType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSettlementType);
                    }
                    
                    public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCashAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        UnderlyingCashAmount = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        return IsSetUnderlyingCashAmount();
                    }
                    
                    public bool IsSetUnderlyingCashAmount() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCashAmount);
                    }
                    
                    public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCashType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        UnderlyingCashType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        return IsSetUnderlyingCashType();
                    }
                    
                    public bool IsSetUnderlyingCashType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCashType);
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        UnderlyingUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        return IsSetUnderlyingUnitOfMeasure();
                    }
                    
                    public bool IsSetUnderlyingUnitOfMeasure() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingUnitOfMeasure);
                    }
                    
                    public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingTimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        UnderlyingTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        return IsSetUnderlyingTimeUnit();
                    }
                    
                    public bool IsSetUnderlyingTimeUnit() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingTimeUnit);
                    }
                    
                    public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingCapValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        UnderlyingCapValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        return IsSetUnderlyingCapValue();
                    }
                    
                    public bool IsSetUnderlyingCapValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingCapValue);
                    }
                    
                    public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoUndlyInstrumentParties();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        NoUndlyInstrumentParties = val;
                    }
                    
                    public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        return IsSetNoUndlyInstrumentParties();
                    }
                    
                    public bool IsSetNoUndlyInstrumentParties() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoUndlyInstrumentParties);
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSettlMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        UnderlyingSettlMethod = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        return IsSetUnderlyingSettlMethod();
                    }
                    
                    public bool IsSetUnderlyingSettlMethod() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSettlMethod);
                    }
                    
                    public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        UnderlyingAdjustedQuantity = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        return IsSetUnderlyingAdjustedQuantity();
                    }
                    
                    public bool IsSetUnderlyingAdjustedQuantity() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingAdjustedQuantity);
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingFXRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        UnderlyingFXRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        return IsSetUnderlyingFXRate();
                    }
                    
                    public bool IsSetUnderlyingFXRate() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingFXRate);
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingFXRateCalc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        UnderlyingFXRateCalc = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        return IsSetUnderlyingFXRateCalc();
                    }
                    
                    public bool IsSetUnderlyingFXRateCalc() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingFXRateCalc);
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityTime UnderlyingMaturityTime
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingMaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        UnderlyingMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        return IsSetUnderlyingMaturityTime();
                    }
                    
                    public bool IsSetUnderlyingMaturityTime() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingMaturityTime);
                    }
                    
                    public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingPutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPutOrCall val) 
                    { 
                        UnderlyingPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) 
                    { 
                        return IsSetUnderlyingPutOrCall();
                    }
                    
                    public bool IsSetUnderlyingPutOrCall() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingPutOrCall);
                    }
                    
                    public QuickFix.Fields.UnderlyingExerciseStyle UnderlyingExerciseStyle
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        UnderlyingExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        return IsSetUnderlyingExerciseStyle();
                    }
                    
                    public bool IsSetUnderlyingExerciseStyle() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingExerciseStyle);
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        UnderlyingUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        return IsSetUnderlyingUnitOfMeasureQty();
                    }
                    
                    public bool IsSetUnderlyingUnitOfMeasureQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingUnitOfMeasureQty);
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        UnderlyingPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        return IsSetUnderlyingPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetUnderlyingPriceUnitOfMeasure() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingPriceUnitOfMeasure);
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        UnderlyingPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        return IsSetUnderlyingPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetUnderlyingPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingPriceUnitOfMeasureQty);
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplierUnit UnderlyingContractMultiplierUnit
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingContractMultiplierUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        UnderlyingContractMultiplierUnit = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplierUnit Get(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        return IsSetUnderlyingContractMultiplierUnit();
                    }
                    
                    public bool IsSetUnderlyingContractMultiplierUnit() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingContractMultiplierUnit);
                    }
                    
                    public QuickFix.Fields.UnderlyingFlowScheduleType UnderlyingFlowScheduleType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingFlowScheduleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        UnderlyingFlowScheduleType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFlowScheduleType Get(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        return IsSetUnderlyingFlowScheduleType();
                    }
                    
                    public bool IsSetUnderlyingFlowScheduleType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingFlowScheduleType);
                    }
                    
                    public QuickFix.Fields.UnderlyingRestructuringType UnderlyingRestructuringType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingRestructuringType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        UnderlyingRestructuringType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRestructuringType Get(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        return IsSetUnderlyingRestructuringType();
                    }
                    
                    public bool IsSetUnderlyingRestructuringType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingRestructuringType);
                    }
                    
                    public QuickFix.Fields.UnderlyingSeniority UnderlyingSeniority
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingSeniority();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        UnderlyingSeniority = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSeniority Get(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        return IsSetUnderlyingSeniority();
                    }
                    
                    public bool IsSetUnderlyingSeniority() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingSeniority);
                    }
                    
                    public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding UnderlyingNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingNotionalPercentageOutstanding();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        UnderlyingNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        return IsSetUnderlyingNotionalPercentageOutstanding();
                    }
                    
                    public bool IsSetUnderlyingNotionalPercentageOutstanding() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingNotionalPercentageOutstanding);
                    }
                    
                    public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding UnderlyingOriginalNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        UnderlyingOriginalNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        return IsSetUnderlyingOriginalNotionalPercentageOutstanding();
                    }
                    
                    public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingOriginalNotionalPercentageOutstanding);
                    }
                    
                    public QuickFix.Fields.UnderlyingAttachmentPoint UnderlyingAttachmentPoint
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingAttachmentPoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        UnderlyingAttachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAttachmentPoint Get(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        return IsSetUnderlyingAttachmentPoint();
                    }
                    
                    public bool IsSetUnderlyingAttachmentPoint() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingAttachmentPoint);
                    }
                    
                    public QuickFix.Fields.UnderlyingDetachmentPoint UnderlyingDetachmentPoint
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.UnderlyingDetachmentPoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        UnderlyingDetachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingDetachmentPoint Get(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        return IsSetUnderlyingDetachmentPoint();
                    }
                    
                    public bool IsSetUnderlyingDetachmentPoint() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.UnderlyingDetachmentPoint);
                    }
                    
                                    public class NoUnderlyingSecurityAltIDGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingSecurityAltIDSource, 0};
                    
                        public NoUnderlyingSecurityAltIDGroup() 
                          :base( QuickFix.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.Fields.Tags.UnderlyingSecurityAltID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoUnderlyingSecurityAltIDGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            UnderlyingSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            return IsSetUnderlyingSecurityAltID();
                        }
                        
                        public bool IsSetUnderlyingSecurityAltID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityAltID);
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            UnderlyingSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            return IsSetUnderlyingSecurityAltIDSource();
                        }
                        
                        public bool IsSetUnderlyingSecurityAltIDSource() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingSecurityAltIDSource);
                        }
                        
                    
                    }
                    public class NoUnderlyingStipsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingStipType, QuickFix.Fields.Tags.UnderlyingStipValue, 0};
                    
                        public NoUnderlyingStipsGroup() 
                          :base( QuickFix.Fields.Tags.NoUnderlyingStips, QuickFix.Fields.Tags.UnderlyingStipType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoUnderlyingStipsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingStipType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            UnderlyingStipType = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            return IsSetUnderlyingStipType();
                        }
                        
                        public bool IsSetUnderlyingStipType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingStipType);
                        }
                        
                        public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingStipValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            UnderlyingStipValue = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            return IsSetUnderlyingStipValue();
                        }
                        
                        public bool IsSetUnderlyingStipValue() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingStipValue);
                        }
                        
                    
                    }
                    public class NoUndlyInstrumentPartiesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingInstrumentPartyID, QuickFix.Fields.Tags.UnderlyingInstrumentPartyIDSource, QuickFix.Fields.Tags.UnderlyingInstrumentPartyRole, QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs, 0};
                    
                        public NoUndlyInstrumentPartiesGroup() 
                          :base( QuickFix.Fields.Tags.NoUndlyInstrumentParties, QuickFix.Fields.Tags.UnderlyingInstrumentPartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoUndlyInstrumentPartiesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.UnderlyingInstrumentPartyID UnderlyingInstrumentPartyID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingInstrumentPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            UnderlyingInstrumentPartyID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyID Get(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            return IsSetUnderlyingInstrumentPartyID();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartyID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrumentPartyID);
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource UnderlyingInstrumentPartyIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingInstrumentPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            UnderlyingInstrumentPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource Get(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            return IsSetUnderlyingInstrumentPartyIDSource();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartyIDSource() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrumentPartyIDSource);
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyRole UnderlyingInstrumentPartyRole
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.UnderlyingInstrumentPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            UnderlyingInstrumentPartyRole = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyRole Get(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            return IsSetUnderlyingInstrumentPartyRole();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartyRole() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrumentPartyRole);
                        }
                        
                        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            NoUndlyInstrumentPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            return IsSetNoUndlyInstrumentPartySubIDs();
                        }
                        
                        public bool IsSetNoUndlyInstrumentPartySubIDs() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs);
                        }
                        
                                            public class NoUndlyInstrumentPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.UnderlyingInstrumentPartySubID, QuickFix.Fields.Tags.UnderlyingInstrumentPartySubIDType, 0};
                        
                            public NoUndlyInstrumentPartySubIDsGroup() 
                              :base( QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs, QuickFix.Fields.Tags.UnderlyingInstrumentPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.UnderlyingInstrumentPartySubID UnderlyingInstrumentPartySubID
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.UnderlyingInstrumentPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                UnderlyingInstrumentPartySubID = val;
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubID Get(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                return IsSetUnderlyingInstrumentPartySubID();
                            }
                            
                            public bool IsSetUnderlyingInstrumentPartySubID() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrumentPartySubID);
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubIDType UnderlyingInstrumentPartySubIDType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.UnderlyingInstrumentPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                UnderlyingInstrumentPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubIDType Get(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                return IsSetUnderlyingInstrumentPartySubIDType();
                            }
                            
                            public bool IsSetUnderlyingInstrumentPartySubIDType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.UnderlyingInstrumentPartySubIDType);
                            }
                            
                        
                        }
                    }
                }
                public class NoStipulationsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.StipulationType, QuickFix.Fields.Tags.StipulationValue, 0};
                
                    public NoStipulationsGroup() 
                      :base( QuickFix.Fields.Tags.NoStipulations, QuickFix.Fields.Tags.StipulationType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoStipulationsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StipulationType StipulationType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StipulationType val) 
                    { 
                        StipulationType = val;
                    }
                    
                    public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StipulationType val) 
                    { 
                        return IsSetStipulationType();
                    }
                    
                    public bool IsSetStipulationType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StipulationType);
                    }
                    
                    public QuickFix.Fields.StipulationValue StipulationValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StipulationValue val) 
                    { 
                        StipulationValue = val;
                    }
                    
                    public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StipulationValue val) 
                    { 
                        return IsSetStipulationValue();
                    }
                    
                    public bool IsSetStipulationValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StipulationValue);
                    }
                    
                
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
                public class NoTradingSessionRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.NoOrdTypeRules, QuickFix.Fields.Tags.NoTimeInForceRules, QuickFix.Fields.Tags.NoExecInstRules, QuickFix.Fields.Tags.NoMatchRules, QuickFix.Fields.Tags.NoMDFeedTypes, 0};
                
                    public NoTradingSessionRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoTradingSessionRules, QuickFix.Fields.Tags.TradingSessionID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTradingSessionRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
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
                    
                    public QuickFix.Fields.NoMatchRules NoMatchRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoMatchRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMatchRules val) 
                    { 
                        NoMatchRules = val;
                    }
                    
                    public QuickFix.Fields.NoMatchRules Get(QuickFix.Fields.NoMatchRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMatchRules val) 
                    { 
                        return IsSetNoMatchRules();
                    }
                    
                    public bool IsSetNoMatchRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoMatchRules);
                    }
                    
                    public QuickFix.Fields.NoMDFeedTypes NoMDFeedTypes
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoMDFeedTypes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        NoMDFeedTypes = val;
                    }
                    
                    public QuickFix.Fields.NoMDFeedTypes Get(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        return IsSetNoMDFeedTypes();
                    }
                    
                    public bool IsSetNoMDFeedTypes() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoMDFeedTypes);
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
                    public class NoMatchRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.MatchAlgorithm, QuickFix.Fields.Tags.MatchType, 0};
                    
                        public NoMatchRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoMatchRules, QuickFix.Fields.Tags.MatchAlgorithm, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMatchRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MatchAlgorithm MatchAlgorithm
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MatchAlgorithm();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            MatchAlgorithm = val;
                        }
                        
                        public QuickFix.Fields.MatchAlgorithm Get(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            return IsSetMatchAlgorithm();
                        }
                        
                        public bool IsSetMatchAlgorithm() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MatchAlgorithm);
                        }
                        
                        public QuickFix.Fields.MatchType MatchType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MatchType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MatchType val) 
                        { 
                            MatchType = val;
                        }
                        
                        public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MatchType val) 
                        { 
                            return IsSetMatchType();
                        }
                        
                        public bool IsSetMatchType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MatchType);
                        }
                        
                    
                    }
                    public class NoMDFeedTypesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.MDFeedType, QuickFix.Fields.Tags.MarketDepth, QuickFix.Fields.Tags.MDBookType, 0};
                    
                        public NoMDFeedTypesGroup() 
                          :base( QuickFix.Fields.Tags.NoMDFeedTypes, QuickFix.Fields.Tags.MDFeedType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMDFeedTypesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MDFeedType MDFeedType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MDFeedType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MDFeedType val) 
                        { 
                            MDFeedType = val;
                        }
                        
                        public QuickFix.Fields.MDFeedType Get(QuickFix.Fields.MDFeedType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MDFeedType val) 
                        { 
                            return IsSetMDFeedType();
                        }
                        
                        public bool IsSetMDFeedType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MDFeedType);
                        }
                        
                        public QuickFix.Fields.MarketDepth MarketDepth
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MarketDepth();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MarketDepth val) 
                        { 
                            MarketDepth = val;
                        }
                        
                        public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MarketDepth val) 
                        { 
                            return IsSetMarketDepth();
                        }
                        
                        public bool IsSetMarketDepth() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MarketDepth);
                        }
                        
                        public QuickFix.Fields.MDBookType MDBookType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MDBookType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MDBookType val) 
                        { 
                            MDBookType = val;
                        }
                        
                        public QuickFix.Fields.MDBookType Get(QuickFix.Fields.MDBookType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MDBookType val) 
                        { 
                            return IsSetMDBookType();
                        }
                        
                        public bool IsSetMDBookType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MDBookType);
                        }
                        
                    
                    }
                }
                public class NoNestedInstrAttribGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedInstrAttribType, QuickFix.Fields.Tags.NestedInstrAttribValue, 0};
                
                    public NoNestedInstrAttribGroup() 
                      :base( QuickFix.Fields.Tags.NoNestedInstrAttrib, QuickFix.Fields.Tags.NestedInstrAttribType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedInstrAttribGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedInstrAttribType NestedInstrAttribType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedInstrAttribType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        NestedInstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribType Get(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        return IsSetNestedInstrAttribType();
                    }
                    
                    public bool IsSetNestedInstrAttribType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedInstrAttribType);
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribValue NestedInstrAttribValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedInstrAttribValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        NestedInstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribValue Get(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        return IsSetNestedInstrAttribValue();
                    }
                    
                    public bool IsSetNestedInstrAttribValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedInstrAttribValue);
                    }
                    
                
                }
                public class NoStrikeRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.StrikeRuleID, QuickFix.Fields.Tags.StartStrikePxRange, QuickFix.Fields.Tags.EndStrikePxRange, QuickFix.Fields.Tags.StrikeIncrement, QuickFix.Fields.Tags.StrikeExerciseStyle, QuickFix.Fields.Tags.NoMaturityRules, 0};
                
                    public NoStrikeRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoStrikeRules, QuickFix.Fields.Tags.StrikeRuleID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoStrikeRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StrikeRuleID StrikeRuleID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StrikeRuleID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        StrikeRuleID = val;
                    }
                    
                    public QuickFix.Fields.StrikeRuleID Get(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        return IsSetStrikeRuleID();
                    }
                    
                    public bool IsSetStrikeRuleID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StrikeRuleID);
                    }
                    
                    public QuickFix.Fields.StartStrikePxRange StartStrikePxRange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StartStrikePxRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        StartStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.StartStrikePxRange Get(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        return IsSetStartStrikePxRange();
                    }
                    
                    public bool IsSetStartStrikePxRange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StartStrikePxRange);
                    }
                    
                    public QuickFix.Fields.EndStrikePxRange EndStrikePxRange
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.EndStrikePxRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        EndStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.EndStrikePxRange Get(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        return IsSetEndStrikePxRange();
                    }
                    
                    public bool IsSetEndStrikePxRange() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.EndStrikePxRange);
                    }
                    
                    public QuickFix.Fields.StrikeIncrement StrikeIncrement
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StrikeIncrement();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        StrikeIncrement = val;
                    }
                    
                    public QuickFix.Fields.StrikeIncrement Get(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        return IsSetStrikeIncrement();
                    }
                    
                    public bool IsSetStrikeIncrement() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StrikeIncrement);
                    }
                    
                    public QuickFix.Fields.StrikeExerciseStyle StrikeExerciseStyle
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.StrikeExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        StrikeExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.StrikeExerciseStyle Get(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        return IsSetStrikeExerciseStyle();
                    }
                    
                    public bool IsSetStrikeExerciseStyle() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.StrikeExerciseStyle);
                    }
                    
                    public QuickFix.Fields.NoMaturityRules NoMaturityRules
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoMaturityRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        NoMaturityRules = val;
                    }
                    
                    public QuickFix.Fields.NoMaturityRules Get(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        return IsSetNoMaturityRules();
                    }
                    
                    public bool IsSetNoMaturityRules() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoMaturityRules);
                    }
                    
                                    public class NoMaturityRulesGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.MaturityRuleID, QuickFix.Fields.Tags.MaturityMonthYearFormat, QuickFix.Fields.Tags.MaturityMonthYearIncrementUnits, QuickFix.Fields.Tags.StartMaturityMonthYear, QuickFix.Fields.Tags.EndMaturityMonthYear, QuickFix.Fields.Tags.MaturityMonthYearIncrement, 0};
                    
                        public NoMaturityRulesGroup() 
                          :base( QuickFix.Fields.Tags.NoMaturityRules, QuickFix.Fields.Tags.MaturityRuleID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMaturityRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MaturityRuleID MaturityRuleID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityRuleID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            MaturityRuleID = val;
                        }
                        
                        public QuickFix.Fields.MaturityRuleID Get(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            return IsSetMaturityRuleID();
                        }
                        
                        public bool IsSetMaturityRuleID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityRuleID);
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearFormat MaturityMonthYearFormat
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityMonthYearFormat();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            MaturityMonthYearFormat = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearFormat Get(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            return IsSetMaturityMonthYearFormat();
                        }
                        
                        public bool IsSetMaturityMonthYearFormat() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityMonthYearFormat);
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits MaturityMonthYearIncrementUnits
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityMonthYearIncrementUnits();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            MaturityMonthYearIncrementUnits = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits Get(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            return IsSetMaturityMonthYearIncrementUnits();
                        }
                        
                        public bool IsSetMaturityMonthYearIncrementUnits() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityMonthYearIncrementUnits);
                        }
                        
                        public QuickFix.Fields.StartMaturityMonthYear StartMaturityMonthYear
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.StartMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            StartMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.StartMaturityMonthYear Get(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            return IsSetStartMaturityMonthYear();
                        }
                        
                        public bool IsSetStartMaturityMonthYear() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.StartMaturityMonthYear);
                        }
                        
                        public QuickFix.Fields.EndMaturityMonthYear EndMaturityMonthYear
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.EndMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            EndMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.EndMaturityMonthYear Get(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            return IsSetEndMaturityMonthYear();
                        }
                        
                        public bool IsSetEndMaturityMonthYear() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.EndMaturityMonthYear);
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrement MaturityMonthYearIncrement
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.MaturityMonthYearIncrement();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            MaturityMonthYearIncrement = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrement Get(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            return IsSetMaturityMonthYearIncrement();
                        }
                        
                        public bool IsSetMaturityMonthYearIncrement() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.MaturityMonthYearIncrement);
                        }
                        
                    
                    }
                }
            }
    }
}

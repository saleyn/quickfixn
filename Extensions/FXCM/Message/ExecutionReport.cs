// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class ExecutionReport : Message
    {
            public const string MsgType = "8";

            public ExecutionReport() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("8"));
            }

            public ExecutionReport(
                    QuickFix.FXCM.Fields.OrderID aOrderID,
                    QuickFix.FXCM.Fields.ExecID aExecID,
                    QuickFix.FXCM.Fields.ExecType aExecType,
                    QuickFix.FXCM.Fields.OrdStatus aOrdStatus,
                    QuickFix.FXCM.Fields.Symbol aSymbol,
                    QuickFix.FXCM.Fields.Side aSide,
                    QuickFix.FXCM.Fields.LeavesQty aLeavesQty,
                    QuickFix.FXCM.Fields.CumQty aCumQty,
                    QuickFix.FXCM.Fields.AvgPx aAvgPx
                ) : this()
            {
                this.OrderID = aOrderID;
                this.ExecID = aExecID;
                this.ExecType = aExecType;
                this.OrdStatus = aOrdStatus;
                this.Symbol = aSymbol;
                this.Side = aSide;
                this.LeavesQty = aLeavesQty;
                this.CumQty = aCumQty;
                this.AvgPx = aAvgPx;
            }

            public QuickFix.FXCM.Fields.OrderID OrderID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderID val) 
            { 
                OrderID = val;
            }
            
            public QuickFix.FXCM.Fields.OrderID Get(QuickFix.FXCM.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryOrderID SecondaryOrderID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryOrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryOrderID val) 
            { 
                SecondaryOrderID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryOrderID Get(QuickFix.FXCM.Fields.SecondaryOrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryOrderID val) 
            { 
                return IsSetSecondaryOrderID();
            }
            
            public bool IsSetSecondaryOrderID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryOrderID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryClOrdID SecondaryClOrdID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
            { 
                SecondaryClOrdID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryClOrdID Get(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
            { 
                return IsSetSecondaryClOrdID();
            }
            
            public bool IsSetSecondaryClOrdID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryClOrdID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryExecID SecondaryExecID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryExecID val) 
            { 
                SecondaryExecID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryExecID Get(QuickFix.FXCM.Fields.SecondaryExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryExecID val) 
            { 
                return IsSetSecondaryExecID();
            }
            
            public bool IsSetSecondaryExecID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryExecID);
            }
            
            public QuickFix.FXCM.Fields.ClOrdID ClOrdID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClOrdID val) 
            { 
                ClOrdID = val;
            }
            
            public QuickFix.FXCM.Fields.ClOrdID Get(QuickFix.FXCM.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClOrdID);
            }
            
            public QuickFix.FXCM.Fields.OrigClOrdID OrigClOrdID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrigClOrdID val) 
            { 
                OrigClOrdID = val;
            }
            
            public QuickFix.FXCM.Fields.OrigClOrdID Get(QuickFix.FXCM.Fields.OrigClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrigClOrdID val) 
            { 
                return IsSetOrigClOrdID();
            }
            
            public bool IsSetOrigClOrdID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrigClOrdID);
            }
            
            public QuickFix.FXCM.Fields.ClOrdLinkID ClOrdLinkID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClOrdLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClOrdLinkID val) 
            { 
                ClOrdLinkID = val;
            }
            
            public QuickFix.FXCM.Fields.ClOrdLinkID Get(QuickFix.FXCM.Fields.ClOrdLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClOrdLinkID val) 
            { 
                return IsSetClOrdLinkID();
            }
            
            public bool IsSetClOrdLinkID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClOrdLinkID);
            }
            
            public QuickFix.FXCM.Fields.QuoteRespID QuoteRespID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QuoteRespID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QuoteRespID val) 
            { 
                QuoteRespID = val;
            }
            
            public QuickFix.FXCM.Fields.QuoteRespID Get(QuickFix.FXCM.Fields.QuoteRespID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QuoteRespID val) 
            { 
                return IsSetQuoteRespID();
            }
            
            public bool IsSetQuoteRespID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QuoteRespID);
            }
            
            public QuickFix.FXCM.Fields.OrdStatusReqID OrdStatusReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrdStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrdStatusReqID val) 
            { 
                OrdStatusReqID = val;
            }
            
            public QuickFix.FXCM.Fields.OrdStatusReqID Get(QuickFix.FXCM.Fields.OrdStatusReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrdStatusReqID val) 
            { 
                return IsSetOrdStatusReqID();
            }
            
            public bool IsSetOrdStatusReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrdStatusReqID);
            }
            
            public QuickFix.FXCM.Fields.MassStatusReqID MassStatusReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MassStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MassStatusReqID val) 
            { 
                MassStatusReqID = val;
            }
            
            public QuickFix.FXCM.Fields.MassStatusReqID Get(QuickFix.FXCM.Fields.MassStatusReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MassStatusReqID val) 
            { 
                return IsSetMassStatusReqID();
            }
            
            public bool IsSetMassStatusReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MassStatusReqID);
            }
            
            public QuickFix.FXCM.Fields.TotNumReports TotNumReports
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotNumReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotNumReports val) 
            { 
                TotNumReports = val;
            }
            
            public QuickFix.FXCM.Fields.TotNumReports Get(QuickFix.FXCM.Fields.TotNumReports val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotNumReports val) 
            { 
                return IsSetTotNumReports();
            }
            
            public bool IsSetTotNumReports() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotNumReports);
            }
            
            public QuickFix.FXCM.Fields.LastRptRequested LastRptRequested
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastRptRequested();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastRptRequested val) 
            { 
                LastRptRequested = val;
            }
            
            public QuickFix.FXCM.Fields.LastRptRequested Get(QuickFix.FXCM.Fields.LastRptRequested val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastRptRequested val) 
            { 
                return IsSetLastRptRequested();
            }
            
            public bool IsSetLastRptRequested() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastRptRequested);
            }
            
            public QuickFix.FXCM.Fields.NoPartyIDs NoPartyIDs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoPartyIDs val) 
            { 
                NoPartyIDs = val;
            }
            
            public QuickFix.FXCM.Fields.NoPartyIDs Get(QuickFix.FXCM.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoPartyIDs);
            }
            
            public QuickFix.FXCM.Fields.TradeOriginationDate TradeOriginationDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradeOriginationDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradeOriginationDate val) 
            { 
                TradeOriginationDate = val;
            }
            
            public QuickFix.FXCM.Fields.TradeOriginationDate Get(QuickFix.FXCM.Fields.TradeOriginationDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradeOriginationDate val) 
            { 
                return IsSetTradeOriginationDate();
            }
            
            public bool IsSetTradeOriginationDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradeOriginationDate);
            }
            
            public QuickFix.FXCM.Fields.NoContraBrokers NoContraBrokers
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoContraBrokers();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoContraBrokers val) 
            { 
                NoContraBrokers = val;
            }
            
            public QuickFix.FXCM.Fields.NoContraBrokers Get(QuickFix.FXCM.Fields.NoContraBrokers val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoContraBrokers val) 
            { 
                return IsSetNoContraBrokers();
            }
            
            public bool IsSetNoContraBrokers() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoContraBrokers);
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
            
            public QuickFix.FXCM.Fields.CrossID CrossID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CrossID val) 
            { 
                CrossID = val;
            }
            
            public QuickFix.FXCM.Fields.CrossID Get(QuickFix.FXCM.Fields.CrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CrossID val) 
            { 
                return IsSetCrossID();
            }
            
            public bool IsSetCrossID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CrossID);
            }
            
            public QuickFix.FXCM.Fields.OrigCrossID OrigCrossID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrigCrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrigCrossID val) 
            { 
                OrigCrossID = val;
            }
            
            public QuickFix.FXCM.Fields.OrigCrossID Get(QuickFix.FXCM.Fields.OrigCrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrigCrossID val) 
            { 
                return IsSetOrigCrossID();
            }
            
            public bool IsSetOrigCrossID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrigCrossID);
            }
            
            public QuickFix.FXCM.Fields.CrossType CrossType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CrossType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CrossType val) 
            { 
                CrossType = val;
            }
            
            public QuickFix.FXCM.Fields.CrossType Get(QuickFix.FXCM.Fields.CrossType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CrossType val) 
            { 
                return IsSetCrossType();
            }
            
            public bool IsSetCrossType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CrossType);
            }
            
            public QuickFix.FXCM.Fields.ExecID ExecID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecID val) 
            { 
                ExecID = val;
            }
            
            public QuickFix.FXCM.Fields.ExecID Get(QuickFix.FXCM.Fields.ExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecID val) 
            { 
                return IsSetExecID();
            }
            
            public bool IsSetExecID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecID);
            }
            
            public QuickFix.FXCM.Fields.ExecRefID ExecRefID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecRefID val) 
            { 
                ExecRefID = val;
            }
            
            public QuickFix.FXCM.Fields.ExecRefID Get(QuickFix.FXCM.Fields.ExecRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecRefID val) 
            { 
                return IsSetExecRefID();
            }
            
            public bool IsSetExecRefID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecRefID);
            }
            
            public QuickFix.FXCM.Fields.ExecType ExecType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecType val) 
            { 
                ExecType = val;
            }
            
            public QuickFix.FXCM.Fields.ExecType Get(QuickFix.FXCM.Fields.ExecType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecType val) 
            { 
                return IsSetExecType();
            }
            
            public bool IsSetExecType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecType);
            }
            
            public QuickFix.FXCM.Fields.OrdStatus OrdStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrdStatus val) 
            { 
                OrdStatus = val;
            }
            
            public QuickFix.FXCM.Fields.OrdStatus Get(QuickFix.FXCM.Fields.OrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrdStatus val) 
            { 
                return IsSetOrdStatus();
            }
            
            public bool IsSetOrdStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrdStatus);
            }
            
            public QuickFix.FXCM.Fields.WorkingIndicator WorkingIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.WorkingIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.WorkingIndicator val) 
            { 
                WorkingIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.WorkingIndicator Get(QuickFix.FXCM.Fields.WorkingIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.WorkingIndicator val) 
            { 
                return IsSetWorkingIndicator();
            }
            
            public bool IsSetWorkingIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.WorkingIndicator);
            }
            
            public QuickFix.FXCM.Fields.OrdRejReason OrdRejReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrdRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrdRejReason val) 
            { 
                OrdRejReason = val;
            }
            
            public QuickFix.FXCM.Fields.OrdRejReason Get(QuickFix.FXCM.Fields.OrdRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrdRejReason val) 
            { 
                return IsSetOrdRejReason();
            }
            
            public bool IsSetOrdRejReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrdRejReason);
            }
            
            public QuickFix.FXCM.Fields.ExecRestatementReason ExecRestatementReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecRestatementReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecRestatementReason val) 
            { 
                ExecRestatementReason = val;
            }
            
            public QuickFix.FXCM.Fields.ExecRestatementReason Get(QuickFix.FXCM.Fields.ExecRestatementReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecRestatementReason val) 
            { 
                return IsSetExecRestatementReason();
            }
            
            public bool IsSetExecRestatementReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecRestatementReason);
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
            
            public QuickFix.FXCM.Fields.AccountType AccountType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccountType val) 
            { 
                AccountType = val;
            }
            
            public QuickFix.FXCM.Fields.AccountType Get(QuickFix.FXCM.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccountType);
            }
            
            public QuickFix.FXCM.Fields.DayBookingInst DayBookingInst
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DayBookingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DayBookingInst val) 
            { 
                DayBookingInst = val;
            }
            
            public QuickFix.FXCM.Fields.DayBookingInst Get(QuickFix.FXCM.Fields.DayBookingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DayBookingInst val) 
            { 
                return IsSetDayBookingInst();
            }
            
            public bool IsSetDayBookingInst() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DayBookingInst);
            }
            
            public QuickFix.FXCM.Fields.BookingUnit BookingUnit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BookingUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BookingUnit val) 
            { 
                BookingUnit = val;
            }
            
            public QuickFix.FXCM.Fields.BookingUnit Get(QuickFix.FXCM.Fields.BookingUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BookingUnit val) 
            { 
                return IsSetBookingUnit();
            }
            
            public bool IsSetBookingUnit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BookingUnit);
            }
            
            public QuickFix.FXCM.Fields.PreallocMethod PreallocMethod
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PreallocMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PreallocMethod val) 
            { 
                PreallocMethod = val;
            }
            
            public QuickFix.FXCM.Fields.PreallocMethod Get(QuickFix.FXCM.Fields.PreallocMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PreallocMethod val) 
            { 
                return IsSetPreallocMethod();
            }
            
            public bool IsSetPreallocMethod() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PreallocMethod);
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
            
            public QuickFix.FXCM.Fields.CashMargin CashMargin
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CashMargin();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CashMargin val) 
            { 
                CashMargin = val;
            }
            
            public QuickFix.FXCM.Fields.CashMargin Get(QuickFix.FXCM.Fields.CashMargin val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CashMargin val) 
            { 
                return IsSetCashMargin();
            }
            
            public bool IsSetCashMargin() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CashMargin);
            }
            
            public QuickFix.FXCM.Fields.ClearingFeeIndicator ClearingFeeIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClearingFeeIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClearingFeeIndicator val) 
            { 
                ClearingFeeIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.ClearingFeeIndicator Get(QuickFix.FXCM.Fields.ClearingFeeIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClearingFeeIndicator val) 
            { 
                return IsSetClearingFeeIndicator();
            }
            
            public bool IsSetClearingFeeIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClearingFeeIndicator);
            }
            
            public QuickFix.FXCM.Fields.Symbol Symbol
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Symbol val) 
            { 
                Symbol = val;
            }
            
            public QuickFix.FXCM.Fields.Symbol Get(QuickFix.FXCM.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Symbol);
            }
            
            public QuickFix.FXCM.Fields.SymbolSfx SymbolSfx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                SymbolSfx = val;
            }
            
            public QuickFix.FXCM.Fields.SymbolSfx Get(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SymbolSfx);
            }
            
            public QuickFix.FXCM.Fields.SecurityID SecurityID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                SecurityID = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityID Get(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityID);
            }
            
            public QuickFix.FXCM.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                SecurityIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityIDSource Get(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityIDSource);
            }
            
            public QuickFix.FXCM.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                NoSecurityAltID = val;
            }
            
            public QuickFix.FXCM.Fields.NoSecurityAltID Get(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoSecurityAltID);
            }
            
            public QuickFix.FXCM.Fields.Product Product
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Product val) 
            { 
                Product = val;
            }
            
            public QuickFix.FXCM.Fields.Product Get(QuickFix.FXCM.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Product);
            }
            
            public QuickFix.FXCM.Fields.CFICode CFICode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CFICode val) 
            { 
                CFICode = val;
            }
            
            public QuickFix.FXCM.Fields.CFICode Get(QuickFix.FXCM.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CFICode);
            }
            
            public QuickFix.FXCM.Fields.SecurityType SecurityType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityType val) 
            { 
                SecurityType = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityType Get(QuickFix.FXCM.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityType);
            }
            
            public QuickFix.FXCM.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                SecuritySubType = val;
            }
            
            public QuickFix.FXCM.Fields.SecuritySubType Get(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecuritySubType);
            }
            
            public QuickFix.FXCM.Fields.MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                MaturityMonthYear = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityMonthYear Get(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityMonthYear);
            }
            
            public QuickFix.FXCM.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                MaturityDate = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityDate Get(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityDate);
            }
            
            public QuickFix.FXCM.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                CouponPaymentDate = val;
            }
            
            public QuickFix.FXCM.Fields.CouponPaymentDate Get(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CouponPaymentDate);
            }
            
            public QuickFix.FXCM.Fields.IssueDate IssueDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                IssueDate = val;
            }
            
            public QuickFix.FXCM.Fields.IssueDate Get(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.IssueDate);
            }
            
            public QuickFix.FXCM.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                RepoCollateralSecurityType = val;
            }
            
            public QuickFix.FXCM.Fields.RepoCollateralSecurityType Get(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepoCollateralSecurityType);
            }
            
            public QuickFix.FXCM.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                RepurchaseTerm = val;
            }
            
            public QuickFix.FXCM.Fields.RepurchaseTerm Get(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepurchaseTerm);
            }
            
            public QuickFix.FXCM.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                RepurchaseRate = val;
            }
            
            public QuickFix.FXCM.Fields.RepurchaseRate Get(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepurchaseRate);
            }
            
            public QuickFix.FXCM.Fields.Factor Factor
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Factor val) 
            { 
                Factor = val;
            }
            
            public QuickFix.FXCM.Fields.Factor Get(QuickFix.FXCM.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Factor);
            }
            
            public QuickFix.FXCM.Fields.CreditRating CreditRating
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                CreditRating = val;
            }
            
            public QuickFix.FXCM.Fields.CreditRating Get(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CreditRating);
            }
            
            public QuickFix.FXCM.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                InstrRegistry = val;
            }
            
            public QuickFix.FXCM.Fields.InstrRegistry Get(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InstrRegistry);
            }
            
            public QuickFix.FXCM.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                CountryOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.CountryOfIssue Get(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CountryOfIssue);
            }
            
            public QuickFix.FXCM.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.StateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StateOrProvinceOfIssue);
            }
            
            public QuickFix.FXCM.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                LocaleOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.LocaleOfIssue Get(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LocaleOfIssue);
            }
            
            public QuickFix.FXCM.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                RedemptionDate = val;
            }
            
            public QuickFix.FXCM.Fields.RedemptionDate Get(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RedemptionDate);
            }
            
            public QuickFix.FXCM.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                StrikePrice = val;
            }
            
            public QuickFix.FXCM.Fields.StrikePrice Get(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikePrice);
            }
            
            public QuickFix.FXCM.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                StrikeCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.StrikeCurrency Get(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikeCurrency);
            }
            
            public QuickFix.FXCM.Fields.OptAttribute OptAttribute
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                OptAttribute = val;
            }
            
            public QuickFix.FXCM.Fields.OptAttribute Get(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OptAttribute);
            }
            
            public QuickFix.FXCM.Fields.ContractMultiplier ContractMultiplier
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                ContractMultiplier = val;
            }
            
            public QuickFix.FXCM.Fields.ContractMultiplier Get(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContractMultiplier);
            }
            
            public QuickFix.FXCM.Fields.CouponRate CouponRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                CouponRate = val;
            }
            
            public QuickFix.FXCM.Fields.CouponRate Get(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CouponRate);
            }
            
            public QuickFix.FXCM.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                SecurityExchange = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityExchange Get(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityExchange);
            }
            
            public QuickFix.FXCM.Fields.Issuer Issuer
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Issuer val) 
            { 
                Issuer = val;
            }
            
            public QuickFix.FXCM.Fields.Issuer Get(QuickFix.FXCM.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Issuer);
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuerLen EncodedIssuerLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                EncodedIssuerLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuerLen Get(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedIssuerLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuer EncodedIssuer
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                EncodedIssuer = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuer Get(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedIssuer);
            }
            
            public QuickFix.FXCM.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                SecurityDesc = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityDesc Get(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityDesc);
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                EncodedSecurityDescLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedSecurityDescLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDesc EncodedSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                EncodedSecurityDesc = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDesc Get(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedSecurityDesc);
            }
            
            public QuickFix.FXCM.Fields.Pool Pool
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Pool val) 
            { 
                Pool = val;
            }
            
            public QuickFix.FXCM.Fields.Pool Get(QuickFix.FXCM.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Pool);
            }
            
            public QuickFix.FXCM.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                ContractSettlMonth = val;
            }
            
            public QuickFix.FXCM.Fields.ContractSettlMonth Get(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContractSettlMonth);
            }
            
            public QuickFix.FXCM.Fields.CPProgram CPProgram
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                CPProgram = val;
            }
            
            public QuickFix.FXCM.Fields.CPProgram Get(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CPProgram);
            }
            
            public QuickFix.FXCM.Fields.CPRegType CPRegType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                CPRegType = val;
            }
            
            public QuickFix.FXCM.Fields.CPRegType Get(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CPRegType);
            }
            
            public QuickFix.FXCM.Fields.NoEvents NoEvents
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                NoEvents = val;
            }
            
            public QuickFix.FXCM.Fields.NoEvents Get(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoEvents);
            }
            
            public QuickFix.FXCM.Fields.DatedDate DatedDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                DatedDate = val;
            }
            
            public QuickFix.FXCM.Fields.DatedDate Get(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DatedDate);
            }
            
            public QuickFix.FXCM.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                InterestAccrualDate = val;
            }
            
            public QuickFix.FXCM.Fields.InterestAccrualDate Get(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InterestAccrualDate);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymID FXCMSymID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                FXCMSymID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymID Get(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                return IsSetFXCMSymID();
            }
            
            public bool IsSetFXCMSymID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymID);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPrecision FXCMSymPrecision
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                FXCMSymPrecision = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPrecision Get(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                return IsSetFXCMSymPrecision();
            }
            
            public bool IsSetFXCMSymPrecision() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymPrecision);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPointSize FXCMSymPointSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymPointSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                FXCMSymPointSize = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPointSize Get(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                return IsSetFXCMSymPointSize();
            }
            
            public bool IsSetFXCMSymPointSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymPointSize);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymSortOrder FXCMSymSortOrder
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymSortOrder();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                FXCMSymSortOrder = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymSortOrder Get(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                return IsSetFXCMSymSortOrder();
            }
            
            public bool IsSetFXCMSymSortOrder() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymSortOrder);
            }
            
            public QuickFix.FXCM.Fields.FXCMProductID FXCMProductID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMProductID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                FXCMProductID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMProductID Get(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                return IsSetFXCMProductID();
            }
            
            public bool IsSetFXCMProductID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMProductID);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymMarginRatio FXCMSymMarginRatio
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymMarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                FXCMSymMarginRatio = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymMarginRatio Get(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                return IsSetFXCMSymMarginRatio();
            }
            
            public bool IsSetFXCMSymMarginRatio() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymMarginRatio);
            }
            
            public QuickFix.FXCM.Fields.Ccy Ccy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Ccy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Ccy val) 
            { 
                Ccy = val;
            }
            
            public QuickFix.FXCM.Fields.Ccy Get(QuickFix.FXCM.Fields.Ccy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Ccy val) 
            { 
                return IsSetCcy();
            }
            
            public bool IsSetCcy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Ccy);
            }
            
            public QuickFix.FXCM.Fields.RndLot RndLot
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RndLot();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RndLot val) 
            { 
                RndLot = val;
            }
            
            public QuickFix.FXCM.Fields.RndLot Get(QuickFix.FXCM.Fields.RndLot val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RndLot val) 
            { 
                return IsSetRndLot();
            }
            
            public bool IsSetRndLot() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RndLot);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestBuy FXCMSymInterestBuy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymInterestBuy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                FXCMSymInterestBuy = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestBuy Get(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                return IsSetFXCMSymInterestBuy();
            }
            
            public bool IsSetFXCMSymInterestBuy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymInterestBuy);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestSell FXCMSymInterestSell
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymInterestSell();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                FXCMSymInterestSell = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestSell Get(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                return IsSetFXCMSymInterestSell();
            }
            
            public bool IsSetFXCMSymInterestSell() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymInterestSell);
            }
            
            public QuickFix.FXCM.Fields.FXCMSubscriptionStatus FXCMSubscriptionStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSubscriptionStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                FXCMSubscriptionStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSubscriptionStatus Get(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                return IsSetFXCMSubscriptionStatus();
            }
            
            public bool IsSetFXCMSubscriptionStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSubscriptionStatus);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistStop FXCMCondDistStop
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistStop();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                FXCMCondDistStop = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistStop Get(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                return IsSetFXCMCondDistStop();
            }
            
            public bool IsSetFXCMCondDistStop() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistStop);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistLimit FXCMCondDistLimit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                FXCMCondDistLimit = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistLimit Get(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                return IsSetFXCMCondDistLimit();
            }
            
            public bool IsSetFXCMCondDistLimit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistLimit);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryStop FXCMCondDistEntryStop
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistEntryStop();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                FXCMCondDistEntryStop = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryStop Get(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                return IsSetFXCMCondDistEntryStop();
            }
            
            public bool IsSetFXCMCondDistEntryStop() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistEntryStop);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryLimit FXCMCondDistEntryLimit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistEntryLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                FXCMCondDistEntryLimit = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryLimit Get(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                return IsSetFXCMCondDistEntryLimit();
            }
            
            public bool IsSetFXCMCondDistEntryLimit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistEntryLimit);
            }
            
            public QuickFix.FXCM.Fields.FXCMMaxQuantity FXCMMaxQuantity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMMaxQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                FXCMMaxQuantity = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMMaxQuantity Get(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                return IsSetFXCMMaxQuantity();
            }
            
            public bool IsSetFXCMMaxQuantity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMMaxQuantity);
            }
            
            public QuickFix.FXCM.Fields.FXCMMinQuantity FXCMMinQuantity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMMinQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                FXCMMinQuantity = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMMinQuantity Get(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                return IsSetFXCMMinQuantity();
            }
            
            public bool IsSetFXCMMinQuantity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMMinQuantity);
            }
            
            public QuickFix.FXCM.Fields.FXCMTradingStatus FXCMTradingStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMTradingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                FXCMTradingStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMTradingStatus Get(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                return IsSetFXCMTradingStatus();
            }
            
            public bool IsSetFXCMTradingStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMTradingStatus);
            }
            
            public QuickFix.FXCM.Fields.AgreementDesc AgreementDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                AgreementDesc = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementDesc Get(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                return IsSetAgreementDesc();
            }
            
            public bool IsSetAgreementDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementDesc);
            }
            
            public QuickFix.FXCM.Fields.AgreementID AgreementID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                AgreementID = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementID Get(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                return IsSetAgreementID();
            }
            
            public bool IsSetAgreementID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementID);
            }
            
            public QuickFix.FXCM.Fields.AgreementDate AgreementDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                AgreementDate = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementDate Get(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                return IsSetAgreementDate();
            }
            
            public bool IsSetAgreementDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementDate);
            }
            
            public QuickFix.FXCM.Fields.AgreementCurrency AgreementCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                AgreementCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementCurrency Get(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                return IsSetAgreementCurrency();
            }
            
            public bool IsSetAgreementCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementCurrency);
            }
            
            public QuickFix.FXCM.Fields.TerminationType TerminationType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TerminationType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                TerminationType = val;
            }
            
            public QuickFix.FXCM.Fields.TerminationType Get(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                return IsSetTerminationType();
            }
            
            public bool IsSetTerminationType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TerminationType);
            }
            
            public QuickFix.FXCM.Fields.StartDate StartDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StartDate val) 
            { 
                StartDate = val;
            }
            
            public QuickFix.FXCM.Fields.StartDate Get(QuickFix.FXCM.Fields.StartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StartDate val) 
            { 
                return IsSetStartDate();
            }
            
            public bool IsSetStartDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StartDate);
            }
            
            public QuickFix.FXCM.Fields.EndDate EndDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndDate val) 
            { 
                EndDate = val;
            }
            
            public QuickFix.FXCM.Fields.EndDate Get(QuickFix.FXCM.Fields.EndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndDate val) 
            { 
                return IsSetEndDate();
            }
            
            public bool IsSetEndDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndDate);
            }
            
            public QuickFix.FXCM.Fields.DeliveryType DeliveryType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                DeliveryType = val;
            }
            
            public QuickFix.FXCM.Fields.DeliveryType Get(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                return IsSetDeliveryType();
            }
            
            public bool IsSetDeliveryType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DeliveryType);
            }
            
            public QuickFix.FXCM.Fields.MarginRatio MarginRatio
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                MarginRatio = val;
            }
            
            public QuickFix.FXCM.Fields.MarginRatio Get(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                return IsSetMarginRatio();
            }
            
            public bool IsSetMarginRatio() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MarginRatio);
            }
            
            public QuickFix.FXCM.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                NoUnderlyings = val;
            }
            
            public QuickFix.FXCM.Fields.NoUnderlyings Get(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyings);
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
            
            public QuickFix.FXCM.Fields.NoStipulations NoStipulations
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoStipulations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                NoStipulations = val;
            }
            
            public QuickFix.FXCM.Fields.NoStipulations Get(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                return IsSetNoStipulations();
            }
            
            public bool IsSetNoStipulations() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoStipulations);
            }
            
            public QuickFix.FXCM.Fields.QtyType QtyType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QtyType val) 
            { 
                QtyType = val;
            }
            
            public QuickFix.FXCM.Fields.QtyType Get(QuickFix.FXCM.Fields.QtyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QtyType val) 
            { 
                return IsSetQtyType();
            }
            
            public bool IsSetQtyType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QtyType);
            }
            
            public QuickFix.FXCM.Fields.OrderQty OrderQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderQty val) 
            { 
                OrderQty = val;
            }
            
            public QuickFix.FXCM.Fields.OrderQty Get(QuickFix.FXCM.Fields.OrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderQty val) 
            { 
                return IsSetOrderQty();
            }
            
            public bool IsSetOrderQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderQty);
            }
            
            public QuickFix.FXCM.Fields.CashOrderQty CashOrderQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CashOrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CashOrderQty val) 
            { 
                CashOrderQty = val;
            }
            
            public QuickFix.FXCM.Fields.CashOrderQty Get(QuickFix.FXCM.Fields.CashOrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CashOrderQty val) 
            { 
                return IsSetCashOrderQty();
            }
            
            public bool IsSetCashOrderQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CashOrderQty);
            }
            
            public QuickFix.FXCM.Fields.OrderPercent OrderPercent
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderPercent val) 
            { 
                OrderPercent = val;
            }
            
            public QuickFix.FXCM.Fields.OrderPercent Get(QuickFix.FXCM.Fields.OrderPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderPercent val) 
            { 
                return IsSetOrderPercent();
            }
            
            public bool IsSetOrderPercent() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderPercent);
            }
            
            public QuickFix.FXCM.Fields.RoundingDirection RoundingDirection
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RoundingDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RoundingDirection val) 
            { 
                RoundingDirection = val;
            }
            
            public QuickFix.FXCM.Fields.RoundingDirection Get(QuickFix.FXCM.Fields.RoundingDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RoundingDirection val) 
            { 
                return IsSetRoundingDirection();
            }
            
            public bool IsSetRoundingDirection() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RoundingDirection);
            }
            
            public QuickFix.FXCM.Fields.RoundingModulus RoundingModulus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RoundingModulus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RoundingModulus val) 
            { 
                RoundingModulus = val;
            }
            
            public QuickFix.FXCM.Fields.RoundingModulus Get(QuickFix.FXCM.Fields.RoundingModulus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RoundingModulus val) 
            { 
                return IsSetRoundingModulus();
            }
            
            public bool IsSetRoundingModulus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RoundingModulus);
            }
            
            public QuickFix.FXCM.Fields.OrdType OrdType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrdType val) 
            { 
                OrdType = val;
            }
            
            public QuickFix.FXCM.Fields.OrdType Get(QuickFix.FXCM.Fields.OrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrdType val) 
            { 
                return IsSetOrdType();
            }
            
            public bool IsSetOrdType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrdType);
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
            
            public QuickFix.FXCM.Fields.StopPx StopPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StopPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StopPx val) 
            { 
                StopPx = val;
            }
            
            public QuickFix.FXCM.Fields.StopPx Get(QuickFix.FXCM.Fields.StopPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StopPx val) 
            { 
                return IsSetStopPx();
            }
            
            public bool IsSetStopPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StopPx);
            }
            
            public QuickFix.FXCM.Fields.PegOffsetValue PegOffsetValue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegOffsetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegOffsetValue val) 
            { 
                PegOffsetValue = val;
            }
            
            public QuickFix.FXCM.Fields.PegOffsetValue Get(QuickFix.FXCM.Fields.PegOffsetValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegOffsetValue val) 
            { 
                return IsSetPegOffsetValue();
            }
            
            public bool IsSetPegOffsetValue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegOffsetValue);
            }
            
            public QuickFix.FXCM.Fields.PegMoveType PegMoveType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegMoveType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegMoveType val) 
            { 
                PegMoveType = val;
            }
            
            public QuickFix.FXCM.Fields.PegMoveType Get(QuickFix.FXCM.Fields.PegMoveType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegMoveType val) 
            { 
                return IsSetPegMoveType();
            }
            
            public bool IsSetPegMoveType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegMoveType);
            }
            
            public QuickFix.FXCM.Fields.PegOffsetType PegOffsetType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegOffsetType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegOffsetType val) 
            { 
                PegOffsetType = val;
            }
            
            public QuickFix.FXCM.Fields.PegOffsetType Get(QuickFix.FXCM.Fields.PegOffsetType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegOffsetType val) 
            { 
                return IsSetPegOffsetType();
            }
            
            public bool IsSetPegOffsetType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegOffsetType);
            }
            
            public QuickFix.FXCM.Fields.PegLimitType PegLimitType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegLimitType val) 
            { 
                PegLimitType = val;
            }
            
            public QuickFix.FXCM.Fields.PegLimitType Get(QuickFix.FXCM.Fields.PegLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegLimitType val) 
            { 
                return IsSetPegLimitType();
            }
            
            public bool IsSetPegLimitType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegLimitType);
            }
            
            public QuickFix.FXCM.Fields.PegRoundDirection PegRoundDirection
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegRoundDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegRoundDirection val) 
            { 
                PegRoundDirection = val;
            }
            
            public QuickFix.FXCM.Fields.PegRoundDirection Get(QuickFix.FXCM.Fields.PegRoundDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegRoundDirection val) 
            { 
                return IsSetPegRoundDirection();
            }
            
            public bool IsSetPegRoundDirection() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegRoundDirection);
            }
            
            public QuickFix.FXCM.Fields.PegScope PegScope
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegScope val) 
            { 
                PegScope = val;
            }
            
            public QuickFix.FXCM.Fields.PegScope Get(QuickFix.FXCM.Fields.PegScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegScope val) 
            { 
                return IsSetPegScope();
            }
            
            public bool IsSetPegScope() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegScope);
            }
            
            public QuickFix.FXCM.Fields.PegPriceType PegPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PegPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PegPriceType val) 
            { 
                PegPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.PegPriceType Get(QuickFix.FXCM.Fields.PegPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PegPriceType val) 
            { 
                return IsSetPegPriceType();
            }
            
            public bool IsSetPegPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PegPriceType);
            }
            
            public QuickFix.FXCM.Fields.FXCMPegFluctPts FXCMPegFluctPts
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMPegFluctPts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMPegFluctPts val) 
            { 
                FXCMPegFluctPts = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMPegFluctPts Get(QuickFix.FXCM.Fields.FXCMPegFluctPts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMPegFluctPts val) 
            { 
                return IsSetFXCMPegFluctPts();
            }
            
            public bool IsSetFXCMPegFluctPts() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMPegFluctPts);
            }
            
            public QuickFix.FXCM.Fields.DiscretionInst DiscretionInst
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionInst val) 
            { 
                DiscretionInst = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionInst Get(QuickFix.FXCM.Fields.DiscretionInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionInst val) 
            { 
                return IsSetDiscretionInst();
            }
            
            public bool IsSetDiscretionInst() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionInst);
            }
            
            public QuickFix.FXCM.Fields.DiscretionOffsetValue DiscretionOffsetValue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionOffsetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionOffsetValue val) 
            { 
                DiscretionOffsetValue = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionOffsetValue Get(QuickFix.FXCM.Fields.DiscretionOffsetValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionOffsetValue val) 
            { 
                return IsSetDiscretionOffsetValue();
            }
            
            public bool IsSetDiscretionOffsetValue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionOffsetValue);
            }
            
            public QuickFix.FXCM.Fields.DiscretionMoveType DiscretionMoveType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionMoveType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionMoveType val) 
            { 
                DiscretionMoveType = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionMoveType Get(QuickFix.FXCM.Fields.DiscretionMoveType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionMoveType val) 
            { 
                return IsSetDiscretionMoveType();
            }
            
            public bool IsSetDiscretionMoveType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionMoveType);
            }
            
            public QuickFix.FXCM.Fields.DiscretionOffsetType DiscretionOffsetType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionOffsetType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionOffsetType val) 
            { 
                DiscretionOffsetType = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionOffsetType Get(QuickFix.FXCM.Fields.DiscretionOffsetType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionOffsetType val) 
            { 
                return IsSetDiscretionOffsetType();
            }
            
            public bool IsSetDiscretionOffsetType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionOffsetType);
            }
            
            public QuickFix.FXCM.Fields.DiscretionLimitType DiscretionLimitType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionLimitType val) 
            { 
                DiscretionLimitType = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionLimitType Get(QuickFix.FXCM.Fields.DiscretionLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionLimitType val) 
            { 
                return IsSetDiscretionLimitType();
            }
            
            public bool IsSetDiscretionLimitType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionLimitType);
            }
            
            public QuickFix.FXCM.Fields.DiscretionRoundDirection DiscretionRoundDirection
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionRoundDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionRoundDirection val) 
            { 
                DiscretionRoundDirection = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionRoundDirection Get(QuickFix.FXCM.Fields.DiscretionRoundDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionRoundDirection val) 
            { 
                return IsSetDiscretionRoundDirection();
            }
            
            public bool IsSetDiscretionRoundDirection() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionRoundDirection);
            }
            
            public QuickFix.FXCM.Fields.DiscretionScope DiscretionScope
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionScope val) 
            { 
                DiscretionScope = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionScope Get(QuickFix.FXCM.Fields.DiscretionScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionScope val) 
            { 
                return IsSetDiscretionScope();
            }
            
            public bool IsSetDiscretionScope() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionScope);
            }
            
            public QuickFix.FXCM.Fields.PeggedPrice PeggedPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PeggedPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PeggedPrice val) 
            { 
                PeggedPrice = val;
            }
            
            public QuickFix.FXCM.Fields.PeggedPrice Get(QuickFix.FXCM.Fields.PeggedPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PeggedPrice val) 
            { 
                return IsSetPeggedPrice();
            }
            
            public bool IsSetPeggedPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PeggedPrice);
            }
            
            public QuickFix.FXCM.Fields.DiscretionPrice DiscretionPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DiscretionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DiscretionPrice val) 
            { 
                DiscretionPrice = val;
            }
            
            public QuickFix.FXCM.Fields.DiscretionPrice Get(QuickFix.FXCM.Fields.DiscretionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DiscretionPrice val) 
            { 
                return IsSetDiscretionPrice();
            }
            
            public bool IsSetDiscretionPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DiscretionPrice);
            }
            
            public QuickFix.FXCM.Fields.TargetStrategy TargetStrategy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TargetStrategy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TargetStrategy val) 
            { 
                TargetStrategy = val;
            }
            
            public QuickFix.FXCM.Fields.TargetStrategy Get(QuickFix.FXCM.Fields.TargetStrategy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TargetStrategy val) 
            { 
                return IsSetTargetStrategy();
            }
            
            public bool IsSetTargetStrategy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TargetStrategy);
            }
            
            public QuickFix.FXCM.Fields.TargetStrategyParameters TargetStrategyParameters
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TargetStrategyParameters();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TargetStrategyParameters val) 
            { 
                TargetStrategyParameters = val;
            }
            
            public QuickFix.FXCM.Fields.TargetStrategyParameters Get(QuickFix.FXCM.Fields.TargetStrategyParameters val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TargetStrategyParameters val) 
            { 
                return IsSetTargetStrategyParameters();
            }
            
            public bool IsSetTargetStrategyParameters() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TargetStrategyParameters);
            }
            
            public QuickFix.FXCM.Fields.ParticipationRate ParticipationRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ParticipationRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ParticipationRate val) 
            { 
                ParticipationRate = val;
            }
            
            public QuickFix.FXCM.Fields.ParticipationRate Get(QuickFix.FXCM.Fields.ParticipationRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ParticipationRate val) 
            { 
                return IsSetParticipationRate();
            }
            
            public bool IsSetParticipationRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ParticipationRate);
            }
            
            public QuickFix.FXCM.Fields.TargetStrategyPerformance TargetStrategyPerformance
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TargetStrategyPerformance();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TargetStrategyPerformance val) 
            { 
                TargetStrategyPerformance = val;
            }
            
            public QuickFix.FXCM.Fields.TargetStrategyPerformance Get(QuickFix.FXCM.Fields.TargetStrategyPerformance val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TargetStrategyPerformance val) 
            { 
                return IsSetTargetStrategyPerformance();
            }
            
            public bool IsSetTargetStrategyPerformance() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TargetStrategyPerformance);
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
            
            public QuickFix.FXCM.Fields.ComplianceID ComplianceID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ComplianceID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ComplianceID val) 
            { 
                ComplianceID = val;
            }
            
            public QuickFix.FXCM.Fields.ComplianceID Get(QuickFix.FXCM.Fields.ComplianceID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ComplianceID val) 
            { 
                return IsSetComplianceID();
            }
            
            public bool IsSetComplianceID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ComplianceID);
            }
            
            public QuickFix.FXCM.Fields.SolicitedFlag SolicitedFlag
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SolicitedFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SolicitedFlag val) 
            { 
                SolicitedFlag = val;
            }
            
            public QuickFix.FXCM.Fields.SolicitedFlag Get(QuickFix.FXCM.Fields.SolicitedFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SolicitedFlag val) 
            { 
                return IsSetSolicitedFlag();
            }
            
            public bool IsSetSolicitedFlag() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SolicitedFlag);
            }
            
            public QuickFix.FXCM.Fields.TimeInForce TimeInForce
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TimeInForce();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TimeInForce val) 
            { 
                TimeInForce = val;
            }
            
            public QuickFix.FXCM.Fields.TimeInForce Get(QuickFix.FXCM.Fields.TimeInForce val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TimeInForce val) 
            { 
                return IsSetTimeInForce();
            }
            
            public bool IsSetTimeInForce() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TimeInForce);
            }
            
            public QuickFix.FXCM.Fields.EffectiveTime EffectiveTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EffectiveTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EffectiveTime val) 
            { 
                EffectiveTime = val;
            }
            
            public QuickFix.FXCM.Fields.EffectiveTime Get(QuickFix.FXCM.Fields.EffectiveTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EffectiveTime val) 
            { 
                return IsSetEffectiveTime();
            }
            
            public bool IsSetEffectiveTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EffectiveTime);
            }
            
            public QuickFix.FXCM.Fields.ExpireDate ExpireDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExpireDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExpireDate val) 
            { 
                ExpireDate = val;
            }
            
            public QuickFix.FXCM.Fields.ExpireDate Get(QuickFix.FXCM.Fields.ExpireDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExpireDate val) 
            { 
                return IsSetExpireDate();
            }
            
            public bool IsSetExpireDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExpireDate);
            }
            
            public QuickFix.FXCM.Fields.ExpireTime ExpireTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExpireTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExpireTime val) 
            { 
                ExpireTime = val;
            }
            
            public QuickFix.FXCM.Fields.ExpireTime Get(QuickFix.FXCM.Fields.ExpireTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExpireTime val) 
            { 
                return IsSetExpireTime();
            }
            
            public bool IsSetExpireTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExpireTime);
            }
            
            public QuickFix.FXCM.Fields.ExecInst ExecInst
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecInst val) 
            { 
                ExecInst = val;
            }
            
            public QuickFix.FXCM.Fields.ExecInst Get(QuickFix.FXCM.Fields.ExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecInst val) 
            { 
                return IsSetExecInst();
            }
            
            public bool IsSetExecInst() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecInst);
            }
            
            public QuickFix.FXCM.Fields.OrderCapacity OrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderCapacity val) 
            { 
                OrderCapacity = val;
            }
            
            public QuickFix.FXCM.Fields.OrderCapacity Get(QuickFix.FXCM.Fields.OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderCapacity);
            }
            
            public QuickFix.FXCM.Fields.OrderRestrictions OrderRestrictions
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderRestrictions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderRestrictions val) 
            { 
                OrderRestrictions = val;
            }
            
            public QuickFix.FXCM.Fields.OrderRestrictions Get(QuickFix.FXCM.Fields.OrderRestrictions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderRestrictions val) 
            { 
                return IsSetOrderRestrictions();
            }
            
            public bool IsSetOrderRestrictions() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderRestrictions);
            }
            
            public QuickFix.FXCM.Fields.CustOrderCapacity CustOrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CustOrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CustOrderCapacity val) 
            { 
                CustOrderCapacity = val;
            }
            
            public QuickFix.FXCM.Fields.CustOrderCapacity Get(QuickFix.FXCM.Fields.CustOrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CustOrderCapacity val) 
            { 
                return IsSetCustOrderCapacity();
            }
            
            public bool IsSetCustOrderCapacity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CustOrderCapacity);
            }
            
            public QuickFix.FXCM.Fields.LastQty LastQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastQty val) 
            { 
                LastQty = val;
            }
            
            public QuickFix.FXCM.Fields.LastQty Get(QuickFix.FXCM.Fields.LastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastQty val) 
            { 
                return IsSetLastQty();
            }
            
            public bool IsSetLastQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastQty);
            }
            
            public QuickFix.FXCM.Fields.UnderlyingLastQty UnderlyingLastQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UnderlyingLastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UnderlyingLastQty val) 
            { 
                UnderlyingLastQty = val;
            }
            
            public QuickFix.FXCM.Fields.UnderlyingLastQty Get(QuickFix.FXCM.Fields.UnderlyingLastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UnderlyingLastQty val) 
            { 
                return IsSetUnderlyingLastQty();
            }
            
            public bool IsSetUnderlyingLastQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingLastQty);
            }
            
            public QuickFix.FXCM.Fields.LastPx LastPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastPx val) 
            { 
                LastPx = val;
            }
            
            public QuickFix.FXCM.Fields.LastPx Get(QuickFix.FXCM.Fields.LastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastPx val) 
            { 
                return IsSetLastPx();
            }
            
            public bool IsSetLastPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastPx);
            }
            
            public QuickFix.FXCM.Fields.UnderlyingLastPx UnderlyingLastPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UnderlyingLastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UnderlyingLastPx val) 
            { 
                UnderlyingLastPx = val;
            }
            
            public QuickFix.FXCM.Fields.UnderlyingLastPx Get(QuickFix.FXCM.Fields.UnderlyingLastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UnderlyingLastPx val) 
            { 
                return IsSetUnderlyingLastPx();
            }
            
            public bool IsSetUnderlyingLastPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingLastPx);
            }
            
            public QuickFix.FXCM.Fields.LastParPx LastParPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastParPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastParPx val) 
            { 
                LastParPx = val;
            }
            
            public QuickFix.FXCM.Fields.LastParPx Get(QuickFix.FXCM.Fields.LastParPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastParPx val) 
            { 
                return IsSetLastParPx();
            }
            
            public bool IsSetLastParPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastParPx);
            }
            
            public QuickFix.FXCM.Fields.LastSpotRate LastSpotRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastSpotRate val) 
            { 
                LastSpotRate = val;
            }
            
            public QuickFix.FXCM.Fields.LastSpotRate Get(QuickFix.FXCM.Fields.LastSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastSpotRate val) 
            { 
                return IsSetLastSpotRate();
            }
            
            public bool IsSetLastSpotRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastSpotRate);
            }
            
            public QuickFix.FXCM.Fields.LastForwardPoints LastForwardPoints
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastForwardPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastForwardPoints val) 
            { 
                LastForwardPoints = val;
            }
            
            public QuickFix.FXCM.Fields.LastForwardPoints Get(QuickFix.FXCM.Fields.LastForwardPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastForwardPoints val) 
            { 
                return IsSetLastForwardPoints();
            }
            
            public bool IsSetLastForwardPoints() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastForwardPoints);
            }
            
            public QuickFix.FXCM.Fields.LastMkt LastMkt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastMkt val) 
            { 
                LastMkt = val;
            }
            
            public QuickFix.FXCM.Fields.LastMkt Get(QuickFix.FXCM.Fields.LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastMkt);
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
            
            public QuickFix.FXCM.Fields.TimeBracket TimeBracket
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TimeBracket();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TimeBracket val) 
            { 
                TimeBracket = val;
            }
            
            public QuickFix.FXCM.Fields.TimeBracket Get(QuickFix.FXCM.Fields.TimeBracket val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TimeBracket val) 
            { 
                return IsSetTimeBracket();
            }
            
            public bool IsSetTimeBracket() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TimeBracket);
            }
            
            public QuickFix.FXCM.Fields.LastCapacity LastCapacity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastCapacity val) 
            { 
                LastCapacity = val;
            }
            
            public QuickFix.FXCM.Fields.LastCapacity Get(QuickFix.FXCM.Fields.LastCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastCapacity val) 
            { 
                return IsSetLastCapacity();
            }
            
            public bool IsSetLastCapacity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastCapacity);
            }
            
            public QuickFix.FXCM.Fields.LeavesQty LeavesQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LeavesQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LeavesQty val) 
            { 
                LeavesQty = val;
            }
            
            public QuickFix.FXCM.Fields.LeavesQty Get(QuickFix.FXCM.Fields.LeavesQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LeavesQty val) 
            { 
                return IsSetLeavesQty();
            }
            
            public bool IsSetLeavesQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LeavesQty);
            }
            
            public QuickFix.FXCM.Fields.CumQty CumQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CumQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CumQty val) 
            { 
                CumQty = val;
            }
            
            public QuickFix.FXCM.Fields.CumQty Get(QuickFix.FXCM.Fields.CumQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CumQty val) 
            { 
                return IsSetCumQty();
            }
            
            public bool IsSetCumQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CumQty);
            }
            
            public QuickFix.FXCM.Fields.AvgPx AvgPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AvgPx val) 
            { 
                AvgPx = val;
            }
            
            public QuickFix.FXCM.Fields.AvgPx Get(QuickFix.FXCM.Fields.AvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AvgPx val) 
            { 
                return IsSetAvgPx();
            }
            
            public bool IsSetAvgPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AvgPx);
            }
            
            public QuickFix.FXCM.Fields.DayOrderQty DayOrderQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DayOrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DayOrderQty val) 
            { 
                DayOrderQty = val;
            }
            
            public QuickFix.FXCM.Fields.DayOrderQty Get(QuickFix.FXCM.Fields.DayOrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DayOrderQty val) 
            { 
                return IsSetDayOrderQty();
            }
            
            public bool IsSetDayOrderQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DayOrderQty);
            }
            
            public QuickFix.FXCM.Fields.DayCumQty DayCumQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DayCumQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DayCumQty val) 
            { 
                DayCumQty = val;
            }
            
            public QuickFix.FXCM.Fields.DayCumQty Get(QuickFix.FXCM.Fields.DayCumQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DayCumQty val) 
            { 
                return IsSetDayCumQty();
            }
            
            public bool IsSetDayCumQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DayCumQty);
            }
            
            public QuickFix.FXCM.Fields.DayAvgPx DayAvgPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DayAvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DayAvgPx val) 
            { 
                DayAvgPx = val;
            }
            
            public QuickFix.FXCM.Fields.DayAvgPx Get(QuickFix.FXCM.Fields.DayAvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DayAvgPx val) 
            { 
                return IsSetDayAvgPx();
            }
            
            public bool IsSetDayAvgPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DayAvgPx);
            }
            
            public QuickFix.FXCM.Fields.GTBookingInst GTBookingInst
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.GTBookingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.GTBookingInst val) 
            { 
                GTBookingInst = val;
            }
            
            public QuickFix.FXCM.Fields.GTBookingInst Get(QuickFix.FXCM.Fields.GTBookingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.GTBookingInst val) 
            { 
                return IsSetGTBookingInst();
            }
            
            public bool IsSetGTBookingInst() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.GTBookingInst);
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
            
            public QuickFix.FXCM.Fields.TransactTime TransactTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                TransactTime = val;
            }
            
            public QuickFix.FXCM.Fields.TransactTime Get(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TransactTime);
            }
            
            public QuickFix.FXCM.Fields.ReportToExch ReportToExch
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ReportToExch();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ReportToExch val) 
            { 
                ReportToExch = val;
            }
            
            public QuickFix.FXCM.Fields.ReportToExch Get(QuickFix.FXCM.Fields.ReportToExch val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ReportToExch val) 
            { 
                return IsSetReportToExch();
            }
            
            public bool IsSetReportToExch() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ReportToExch);
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
            
            public QuickFix.FXCM.Fields.Spread Spread
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Spread();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Spread val) 
            { 
                Spread = val;
            }
            
            public QuickFix.FXCM.Fields.Spread Get(QuickFix.FXCM.Fields.Spread val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Spread val) 
            { 
                return IsSetSpread();
            }
            
            public bool IsSetSpread() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Spread);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurveCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                BenchmarkCurveCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveCurrency Get(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                return IsSetBenchmarkCurveCurrency();
            }
            
            public bool IsSetBenchmarkCurveCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurveCurrency);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveName BenchmarkCurveName
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurveName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                BenchmarkCurveName = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveName Get(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                return IsSetBenchmarkCurveName();
            }
            
            public bool IsSetBenchmarkCurveName() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurveName);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurvePoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                BenchmarkCurvePoint = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurvePoint Get(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                return IsSetBenchmarkCurvePoint();
            }
            
            public bool IsSetBenchmarkCurvePoint() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurvePoint);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPrice BenchmarkPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                BenchmarkPrice = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPrice Get(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                return IsSetBenchmarkPrice();
            }
            
            public bool IsSetBenchmarkPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkPrice);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPriceType BenchmarkPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                BenchmarkPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPriceType Get(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                return IsSetBenchmarkPriceType();
            }
            
            public bool IsSetBenchmarkPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkPriceType);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityID BenchmarkSecurityID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                BenchmarkSecurityID = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityID Get(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                return IsSetBenchmarkSecurityID();
            }
            
            public bool IsSetBenchmarkSecurityID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkSecurityID);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                BenchmarkSecurityIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityIDSource Get(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                return IsSetBenchmarkSecurityIDSource();
            }
            
            public bool IsSetBenchmarkSecurityIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkSecurityIDSource);
            }
            
            public QuickFix.FXCM.Fields.YieldType YieldType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldType val) 
            { 
                YieldType = val;
            }
            
            public QuickFix.FXCM.Fields.YieldType Get(QuickFix.FXCM.Fields.YieldType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldType val) 
            { 
                return IsSetYieldType();
            }
            
            public bool IsSetYieldType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldType);
            }
            
            public QuickFix.FXCM.Fields.Yield Yield
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Yield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Yield val) 
            { 
                Yield = val;
            }
            
            public QuickFix.FXCM.Fields.Yield Get(QuickFix.FXCM.Fields.Yield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Yield val) 
            { 
                return IsSetYield();
            }
            
            public bool IsSetYield() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Yield);
            }
            
            public QuickFix.FXCM.Fields.YieldCalcDate YieldCalcDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldCalcDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                YieldCalcDate = val;
            }
            
            public QuickFix.FXCM.Fields.YieldCalcDate Get(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                return IsSetYieldCalcDate();
            }
            
            public bool IsSetYieldCalcDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldCalcDate);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionDate YieldRedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                YieldRedemptionDate = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionDate Get(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                return IsSetYieldRedemptionDate();
            }
            
            public bool IsSetYieldRedemptionDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionDate);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPrice YieldRedemptionPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                YieldRedemptionPrice = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPrice Get(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                return IsSetYieldRedemptionPrice();
            }
            
            public bool IsSetYieldRedemptionPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionPrice);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                YieldRedemptionPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPriceType Get(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                return IsSetYieldRedemptionPriceType();
            }
            
            public bool IsSetYieldRedemptionPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionPriceType);
            }
            
            public QuickFix.FXCM.Fields.GrossTradeAmt GrossTradeAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.GrossTradeAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.GrossTradeAmt val) 
            { 
                GrossTradeAmt = val;
            }
            
            public QuickFix.FXCM.Fields.GrossTradeAmt Get(QuickFix.FXCM.Fields.GrossTradeAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.GrossTradeAmt val) 
            { 
                return IsSetGrossTradeAmt();
            }
            
            public bool IsSetGrossTradeAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.GrossTradeAmt);
            }
            
            public QuickFix.FXCM.Fields.NumDaysInterest NumDaysInterest
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NumDaysInterest();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NumDaysInterest val) 
            { 
                NumDaysInterest = val;
            }
            
            public QuickFix.FXCM.Fields.NumDaysInterest Get(QuickFix.FXCM.Fields.NumDaysInterest val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NumDaysInterest val) 
            { 
                return IsSetNumDaysInterest();
            }
            
            public bool IsSetNumDaysInterest() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NumDaysInterest);
            }
            
            public QuickFix.FXCM.Fields.ExDate ExDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExDate val) 
            { 
                ExDate = val;
            }
            
            public QuickFix.FXCM.Fields.ExDate Get(QuickFix.FXCM.Fields.ExDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExDate val) 
            { 
                return IsSetExDate();
            }
            
            public bool IsSetExDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExDate);
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestRate AccruedInterestRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccruedInterestRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccruedInterestRate val) 
            { 
                AccruedInterestRate = val;
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestRate Get(QuickFix.FXCM.Fields.AccruedInterestRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccruedInterestRate val) 
            { 
                return IsSetAccruedInterestRate();
            }
            
            public bool IsSetAccruedInterestRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccruedInterestRate);
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestAmt AccruedInterestAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccruedInterestAmt val) 
            { 
                AccruedInterestAmt = val;
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestAmt Get(QuickFix.FXCM.Fields.AccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccruedInterestAmt val) 
            { 
                return IsSetAccruedInterestAmt();
            }
            
            public bool IsSetAccruedInterestAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccruedInterestAmt);
            }
            
            public QuickFix.FXCM.Fields.InterestAtMaturity InterestAtMaturity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InterestAtMaturity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InterestAtMaturity val) 
            { 
                InterestAtMaturity = val;
            }
            
            public QuickFix.FXCM.Fields.InterestAtMaturity Get(QuickFix.FXCM.Fields.InterestAtMaturity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InterestAtMaturity val) 
            { 
                return IsSetInterestAtMaturity();
            }
            
            public bool IsSetInterestAtMaturity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InterestAtMaturity);
            }
            
            public QuickFix.FXCM.Fields.EndAccruedInterestAmt EndAccruedInterestAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndAccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndAccruedInterestAmt val) 
            { 
                EndAccruedInterestAmt = val;
            }
            
            public QuickFix.FXCM.Fields.EndAccruedInterestAmt Get(QuickFix.FXCM.Fields.EndAccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndAccruedInterestAmt val) 
            { 
                return IsSetEndAccruedInterestAmt();
            }
            
            public bool IsSetEndAccruedInterestAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndAccruedInterestAmt);
            }
            
            public QuickFix.FXCM.Fields.StartCash StartCash
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StartCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StartCash val) 
            { 
                StartCash = val;
            }
            
            public QuickFix.FXCM.Fields.StartCash Get(QuickFix.FXCM.Fields.StartCash val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StartCash val) 
            { 
                return IsSetStartCash();
            }
            
            public bool IsSetStartCash() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StartCash);
            }
            
            public QuickFix.FXCM.Fields.EndCash EndCash
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndCash val) 
            { 
                EndCash = val;
            }
            
            public QuickFix.FXCM.Fields.EndCash Get(QuickFix.FXCM.Fields.EndCash val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndCash val) 
            { 
                return IsSetEndCash();
            }
            
            public bool IsSetEndCash() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndCash);
            }
            
            public QuickFix.FXCM.Fields.TradedFlatSwitch TradedFlatSwitch
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradedFlatSwitch();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradedFlatSwitch val) 
            { 
                TradedFlatSwitch = val;
            }
            
            public QuickFix.FXCM.Fields.TradedFlatSwitch Get(QuickFix.FXCM.Fields.TradedFlatSwitch val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradedFlatSwitch val) 
            { 
                return IsSetTradedFlatSwitch();
            }
            
            public bool IsSetTradedFlatSwitch() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradedFlatSwitch);
            }
            
            public QuickFix.FXCM.Fields.BasisFeatureDate BasisFeatureDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BasisFeatureDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BasisFeatureDate val) 
            { 
                BasisFeatureDate = val;
            }
            
            public QuickFix.FXCM.Fields.BasisFeatureDate Get(QuickFix.FXCM.Fields.BasisFeatureDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BasisFeatureDate val) 
            { 
                return IsSetBasisFeatureDate();
            }
            
            public bool IsSetBasisFeatureDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BasisFeatureDate);
            }
            
            public QuickFix.FXCM.Fields.BasisFeaturePrice BasisFeaturePrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BasisFeaturePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BasisFeaturePrice val) 
            { 
                BasisFeaturePrice = val;
            }
            
            public QuickFix.FXCM.Fields.BasisFeaturePrice Get(QuickFix.FXCM.Fields.BasisFeaturePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BasisFeaturePrice val) 
            { 
                return IsSetBasisFeaturePrice();
            }
            
            public bool IsSetBasisFeaturePrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BasisFeaturePrice);
            }
            
            public QuickFix.FXCM.Fields.Concession Concession
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Concession();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Concession val) 
            { 
                Concession = val;
            }
            
            public QuickFix.FXCM.Fields.Concession Get(QuickFix.FXCM.Fields.Concession val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Concession val) 
            { 
                return IsSetConcession();
            }
            
            public bool IsSetConcession() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Concession);
            }
            
            public QuickFix.FXCM.Fields.TotalTakedown TotalTakedown
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotalTakedown();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotalTakedown val) 
            { 
                TotalTakedown = val;
            }
            
            public QuickFix.FXCM.Fields.TotalTakedown Get(QuickFix.FXCM.Fields.TotalTakedown val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotalTakedown val) 
            { 
                return IsSetTotalTakedown();
            }
            
            public bool IsSetTotalTakedown() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotalTakedown);
            }
            
            public QuickFix.FXCM.Fields.NetMoney NetMoney
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NetMoney();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NetMoney val) 
            { 
                NetMoney = val;
            }
            
            public QuickFix.FXCM.Fields.NetMoney Get(QuickFix.FXCM.Fields.NetMoney val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NetMoney val) 
            { 
                return IsSetNetMoney();
            }
            
            public bool IsSetNetMoney() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NetMoney);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrAmt SettlCurrAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrAmt val) 
            { 
                SettlCurrAmt = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrAmt Get(QuickFix.FXCM.Fields.SettlCurrAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrAmt val) 
            { 
                return IsSetSettlCurrAmt();
            }
            
            public bool IsSetSettlCurrAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrAmt);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrency SettlCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrency val) 
            { 
                SettlCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrency Get(QuickFix.FXCM.Fields.SettlCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrency val) 
            { 
                return IsSetSettlCurrency();
            }
            
            public bool IsSetSettlCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrency);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRate SettlCurrFxRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrFxRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrFxRate val) 
            { 
                SettlCurrFxRate = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRate Get(QuickFix.FXCM.Fields.SettlCurrFxRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrFxRate val) 
            { 
                return IsSetSettlCurrFxRate();
            }
            
            public bool IsSetSettlCurrFxRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrFxRate);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrFxRateCalc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                SettlCurrFxRateCalc = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRateCalc Get(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                return IsSetSettlCurrFxRateCalc();
            }
            
            public bool IsSetSettlCurrFxRateCalc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrFxRateCalc);
            }
            
            public QuickFix.FXCM.Fields.HandlInst HandlInst
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.HandlInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.HandlInst val) 
            { 
                HandlInst = val;
            }
            
            public QuickFix.FXCM.Fields.HandlInst Get(QuickFix.FXCM.Fields.HandlInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.HandlInst val) 
            { 
                return IsSetHandlInst();
            }
            
            public bool IsSetHandlInst() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.HandlInst);
            }
            
            public QuickFix.FXCM.Fields.MinQty MinQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MinQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MinQty val) 
            { 
                MinQty = val;
            }
            
            public QuickFix.FXCM.Fields.MinQty Get(QuickFix.FXCM.Fields.MinQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MinQty val) 
            { 
                return IsSetMinQty();
            }
            
            public bool IsSetMinQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MinQty);
            }
            
            public QuickFix.FXCM.Fields.MaxFloor MaxFloor
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaxFloor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaxFloor val) 
            { 
                MaxFloor = val;
            }
            
            public QuickFix.FXCM.Fields.MaxFloor Get(QuickFix.FXCM.Fields.MaxFloor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaxFloor val) 
            { 
                return IsSetMaxFloor();
            }
            
            public bool IsSetMaxFloor() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaxFloor);
            }
            
            public QuickFix.FXCM.Fields.PositionEffect PositionEffect
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PositionEffect();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PositionEffect val) 
            { 
                PositionEffect = val;
            }
            
            public QuickFix.FXCM.Fields.PositionEffect Get(QuickFix.FXCM.Fields.PositionEffect val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PositionEffect val) 
            { 
                return IsSetPositionEffect();
            }
            
            public bool IsSetPositionEffect() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PositionEffect);
            }
            
            public QuickFix.FXCM.Fields.MaxShow MaxShow
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaxShow();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaxShow val) 
            { 
                MaxShow = val;
            }
            
            public QuickFix.FXCM.Fields.MaxShow Get(QuickFix.FXCM.Fields.MaxShow val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaxShow val) 
            { 
                return IsSetMaxShow();
            }
            
            public bool IsSetMaxShow() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaxShow);
            }
            
            public QuickFix.FXCM.Fields.BookingType BookingType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BookingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BookingType val) 
            { 
                BookingType = val;
            }
            
            public QuickFix.FXCM.Fields.BookingType Get(QuickFix.FXCM.Fields.BookingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BookingType val) 
            { 
                return IsSetBookingType();
            }
            
            public bool IsSetBookingType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BookingType);
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
            
            public QuickFix.FXCM.Fields.SettlDate2 SettlDate2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlDate2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlDate2 val) 
            { 
                SettlDate2 = val;
            }
            
            public QuickFix.FXCM.Fields.SettlDate2 Get(QuickFix.FXCM.Fields.SettlDate2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlDate2 val) 
            { 
                return IsSetSettlDate2();
            }
            
            public bool IsSetSettlDate2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlDate2);
            }
            
            public QuickFix.FXCM.Fields.OrderQty2 OrderQty2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderQty2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderQty2 val) 
            { 
                OrderQty2 = val;
            }
            
            public QuickFix.FXCM.Fields.OrderQty2 Get(QuickFix.FXCM.Fields.OrderQty2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderQty2 val) 
            { 
                return IsSetOrderQty2();
            }
            
            public bool IsSetOrderQty2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderQty2);
            }
            
            public QuickFix.FXCM.Fields.LastForwardPoints2 LastForwardPoints2
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastForwardPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastForwardPoints2 val) 
            { 
                LastForwardPoints2 = val;
            }
            
            public QuickFix.FXCM.Fields.LastForwardPoints2 Get(QuickFix.FXCM.Fields.LastForwardPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastForwardPoints2 val) 
            { 
                return IsSetLastForwardPoints2();
            }
            
            public bool IsSetLastForwardPoints2() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastForwardPoints2);
            }
            
            public QuickFix.FXCM.Fields.MultiLegReportingType MultiLegReportingType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MultiLegReportingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MultiLegReportingType val) 
            { 
                MultiLegReportingType = val;
            }
            
            public QuickFix.FXCM.Fields.MultiLegReportingType Get(QuickFix.FXCM.Fields.MultiLegReportingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MultiLegReportingType val) 
            { 
                return IsSetMultiLegReportingType();
            }
            
            public bool IsSetMultiLegReportingType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MultiLegReportingType);
            }
            
            public QuickFix.FXCM.Fields.CancellationRights CancellationRights
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CancellationRights();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CancellationRights val) 
            { 
                CancellationRights = val;
            }
            
            public QuickFix.FXCM.Fields.CancellationRights Get(QuickFix.FXCM.Fields.CancellationRights val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CancellationRights val) 
            { 
                return IsSetCancellationRights();
            }
            
            public bool IsSetCancellationRights() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CancellationRights);
            }
            
            public QuickFix.FXCM.Fields.MoneyLaunderingStatus MoneyLaunderingStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MoneyLaunderingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MoneyLaunderingStatus val) 
            { 
                MoneyLaunderingStatus = val;
            }
            
            public QuickFix.FXCM.Fields.MoneyLaunderingStatus Get(QuickFix.FXCM.Fields.MoneyLaunderingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MoneyLaunderingStatus val) 
            { 
                return IsSetMoneyLaunderingStatus();
            }
            
            public bool IsSetMoneyLaunderingStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MoneyLaunderingStatus);
            }
            
            public QuickFix.FXCM.Fields.RegistID RegistID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistID val) 
            { 
                RegistID = val;
            }
            
            public QuickFix.FXCM.Fields.RegistID Get(QuickFix.FXCM.Fields.RegistID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistID val) 
            { 
                return IsSetRegistID();
            }
            
            public bool IsSetRegistID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistID);
            }
            
            public QuickFix.FXCM.Fields.Designation Designation
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Designation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Designation val) 
            { 
                Designation = val;
            }
            
            public QuickFix.FXCM.Fields.Designation Get(QuickFix.FXCM.Fields.Designation val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Designation val) 
            { 
                return IsSetDesignation();
            }
            
            public bool IsSetDesignation() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Designation);
            }
            
            public QuickFix.FXCM.Fields.TransBkdTime TransBkdTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TransBkdTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TransBkdTime val) 
            { 
                TransBkdTime = val;
            }
            
            public QuickFix.FXCM.Fields.TransBkdTime Get(QuickFix.FXCM.Fields.TransBkdTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TransBkdTime val) 
            { 
                return IsSetTransBkdTime();
            }
            
            public bool IsSetTransBkdTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TransBkdTime);
            }
            
            public QuickFix.FXCM.Fields.ExecValuationPoint ExecValuationPoint
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecValuationPoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecValuationPoint val) 
            { 
                ExecValuationPoint = val;
            }
            
            public QuickFix.FXCM.Fields.ExecValuationPoint Get(QuickFix.FXCM.Fields.ExecValuationPoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecValuationPoint val) 
            { 
                return IsSetExecValuationPoint();
            }
            
            public bool IsSetExecValuationPoint() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecValuationPoint);
            }
            
            public QuickFix.FXCM.Fields.ExecPriceType ExecPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecPriceType val) 
            { 
                ExecPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.ExecPriceType Get(QuickFix.FXCM.Fields.ExecPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecPriceType val) 
            { 
                return IsSetExecPriceType();
            }
            
            public bool IsSetExecPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecPriceType);
            }
            
            public QuickFix.FXCM.Fields.ExecPriceAdjustment ExecPriceAdjustment
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExecPriceAdjustment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExecPriceAdjustment val) 
            { 
                ExecPriceAdjustment = val;
            }
            
            public QuickFix.FXCM.Fields.ExecPriceAdjustment Get(QuickFix.FXCM.Fields.ExecPriceAdjustment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExecPriceAdjustment val) 
            { 
                return IsSetExecPriceAdjustment();
            }
            
            public bool IsSetExecPriceAdjustment() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExecPriceAdjustment);
            }
            
            public QuickFix.FXCM.Fields.PriorityIndicator PriorityIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PriorityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PriorityIndicator val) 
            { 
                PriorityIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.PriorityIndicator Get(QuickFix.FXCM.Fields.PriorityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PriorityIndicator val) 
            { 
                return IsSetPriorityIndicator();
            }
            
            public bool IsSetPriorityIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PriorityIndicator);
            }
            
            public QuickFix.FXCM.Fields.PriceImprovement PriceImprovement
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PriceImprovement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PriceImprovement val) 
            { 
                PriceImprovement = val;
            }
            
            public QuickFix.FXCM.Fields.PriceImprovement Get(QuickFix.FXCM.Fields.PriceImprovement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PriceImprovement val) 
            { 
                return IsSetPriceImprovement();
            }
            
            public bool IsSetPriceImprovement() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PriceImprovement);
            }
            
            public QuickFix.FXCM.Fields.LastLiquidityInd LastLiquidityInd
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastLiquidityInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastLiquidityInd val) 
            { 
                LastLiquidityInd = val;
            }
            
            public QuickFix.FXCM.Fields.LastLiquidityInd Get(QuickFix.FXCM.Fields.LastLiquidityInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastLiquidityInd val) 
            { 
                return IsSetLastLiquidityInd();
            }
            
            public bool IsSetLastLiquidityInd() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastLiquidityInd);
            }
            
            public QuickFix.FXCM.Fields.NoContAmts NoContAmts
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoContAmts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoContAmts val) 
            { 
                NoContAmts = val;
            }
            
            public QuickFix.FXCM.Fields.NoContAmts Get(QuickFix.FXCM.Fields.NoContAmts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoContAmts val) 
            { 
                return IsSetNoContAmts();
            }
            
            public bool IsSetNoContAmts() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoContAmts);
            }
            
            public QuickFix.FXCM.Fields.NoLegs NoLegs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                NoLegs = val;
            }
            
            public QuickFix.FXCM.Fields.NoLegs Get(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegs);
            }
            
            public QuickFix.FXCM.Fields.CopyMsgIndicator CopyMsgIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CopyMsgIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CopyMsgIndicator val) 
            { 
                CopyMsgIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.CopyMsgIndicator Get(QuickFix.FXCM.Fields.CopyMsgIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CopyMsgIndicator val) 
            { 
                return IsSetCopyMsgIndicator();
            }
            
            public bool IsSetCopyMsgIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CopyMsgIndicator);
            }
            
            public QuickFix.FXCM.Fields.NoMiscFees NoMiscFees
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoMiscFees();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoMiscFees val) 
            { 
                NoMiscFees = val;
            }
            
            public QuickFix.FXCM.Fields.NoMiscFees Get(QuickFix.FXCM.Fields.NoMiscFees val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoMiscFees val) 
            { 
                return IsSetNoMiscFees();
            }
            
            public bool IsSetNoMiscFees() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoMiscFees);
            }
            
            public QuickFix.FXCM.Fields.FXCMPosID FXCMPosID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMPosID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMPosID val) 
            { 
                FXCMPosID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMPosID Get(QuickFix.FXCM.Fields.FXCMPosID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMPosID val) 
            { 
                return IsSetFXCMPosID();
            }
            
            public bool IsSetFXCMPosID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMPosID);
            }
            
            public QuickFix.FXCM.Fields.FXCMOrdStatus FXCMOrdStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMOrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMOrdStatus val) 
            { 
                FXCMOrdStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMOrdStatus Get(QuickFix.FXCM.Fields.FXCMOrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMOrdStatus val) 
            { 
                return IsSetFXCMOrdStatus();
            }
            
            public bool IsSetFXCMOrdStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMOrdStatus);
            }
            
            public QuickFix.FXCM.Fields.FXCMOrdType FXCMOrdType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMOrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMOrdType val) 
            { 
                FXCMOrdType = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMOrdType Get(QuickFix.FXCM.Fields.FXCMOrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMOrdType val) 
            { 
                return IsSetFXCMOrdType();
            }
            
            public bool IsSetFXCMOrdType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMOrdType);
            }
            
            public QuickFix.FXCM.Fields.FXCMRequestRejectReason FXCMRequestRejectReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMRequestRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMRequestRejectReason val) 
            { 
                FXCMRequestRejectReason = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMRequestRejectReason Get(QuickFix.FXCM.Fields.FXCMRequestRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMRequestRejectReason val) 
            { 
                return IsSetFXCMRequestRejectReason();
            }
            
            public bool IsSetFXCMRequestRejectReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMRequestRejectReason);
            }
            
            public QuickFix.FXCM.Fields.FXCMErrorDetails FXCMErrorDetails
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMErrorDetails();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMErrorDetails val) 
            { 
                FXCMErrorDetails = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMErrorDetails Get(QuickFix.FXCM.Fields.FXCMErrorDetails val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMErrorDetails val) 
            { 
                return IsSetFXCMErrorDetails();
            }
            
            public bool IsSetFXCMErrorDetails() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMErrorDetails);
            }
            
            public QuickFix.FXCM.Fields.FXCMContingencyID FXCMContingencyID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMContingencyID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMContingencyID val) 
            { 
                FXCMContingencyID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMContingencyID Get(QuickFix.FXCM.Fields.FXCMContingencyID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMContingencyID val) 
            { 
                return IsSetFXCMContingencyID();
            }
            
            public bool IsSetFXCMContingencyID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMContingencyID);
            }
            
            public QuickFix.FXCM.Fields.ContingencyType ContingencyType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContingencyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContingencyType val) 
            { 
                ContingencyType = val;
            }
            
            public QuickFix.FXCM.Fields.ContingencyType Get(QuickFix.FXCM.Fields.ContingencyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContingencyType val) 
            { 
                return IsSetContingencyType();
            }
            
            public bool IsSetContingencyType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContingencyType);
            }
            
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.PartyID, QuickFix.FXCM.Fields.Tags.PartyIDSource, QuickFix.FXCM.Fields.Tags.PartyRole, QuickFix.FXCM.Fields.Tags.NoPartySubIDs, 0};
            
                public NoPartyIDsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoPartyIDs, QuickFix.FXCM.Fields.Tags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.PartyID PartyID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PartyID val) 
                { 
                    PartyID = val;
                }
                
                public QuickFix.FXCM.Fields.PartyID Get(QuickFix.FXCM.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PartyID);
                }
                
                public QuickFix.FXCM.Fields.PartyIDSource PartyIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PartyIDSource val) 
                { 
                    PartyIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.PartyIDSource Get(QuickFix.FXCM.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PartyIDSource);
                }
                
                public QuickFix.FXCM.Fields.PartyRole PartyRole
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PartyRole val) 
                { 
                    PartyRole = val;
                }
                
                public QuickFix.FXCM.Fields.PartyRole Get(QuickFix.FXCM.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PartyRole);
                }
                
                public QuickFix.FXCM.Fields.NoPartySubIDs NoPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoPartySubIDs val) 
                { 
                    NoPartySubIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoPartySubIDs Get(QuickFix.FXCM.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoPartySubIDs);
                }
                
                            public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.PartySubID, QuickFix.FXCM.Fields.Tags.PartySubIDType, 0};
                
                    public NoPartySubIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoPartySubIDs, QuickFix.FXCM.Fields.Tags.PartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.PartySubID PartySubID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.PartySubID val) 
                    { 
                        PartySubID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.PartySubID Get(QuickFix.FXCM.Fields.PartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.PartySubID val) 
                    { 
                        return IsSetPartySubID();
                    }
                    
                    public bool IsSetPartySubID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.PartySubID);
                    }
                    
                    public QuickFix.FXCM.Fields.PartySubIDType PartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.PartySubIDType val) 
                    { 
                        PartySubIDType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.PartySubIDType Get(QuickFix.FXCM.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.PartySubIDType);
                    }
                    
                
                }
            }
            public class NoContraBrokersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.ContraBroker, QuickFix.FXCM.Fields.Tags.ContraTrader, QuickFix.FXCM.Fields.Tags.ContraTradeQty, QuickFix.FXCM.Fields.Tags.ContraTradeTime, QuickFix.FXCM.Fields.Tags.ContraLegRefID, 0};
            
                public NoContraBrokersGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoContraBrokers, QuickFix.FXCM.Fields.Tags.ContraBroker, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoContraBrokersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.ContraBroker ContraBroker
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContraBroker();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContraBroker val) 
                { 
                    ContraBroker = val;
                }
                
                public QuickFix.FXCM.Fields.ContraBroker Get(QuickFix.FXCM.Fields.ContraBroker val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContraBroker val) 
                { 
                    return IsSetContraBroker();
                }
                
                public bool IsSetContraBroker() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContraBroker);
                }
                
                public QuickFix.FXCM.Fields.ContraTrader ContraTrader
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContraTrader();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContraTrader val) 
                { 
                    ContraTrader = val;
                }
                
                public QuickFix.FXCM.Fields.ContraTrader Get(QuickFix.FXCM.Fields.ContraTrader val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContraTrader val) 
                { 
                    return IsSetContraTrader();
                }
                
                public bool IsSetContraTrader() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContraTrader);
                }
                
                public QuickFix.FXCM.Fields.ContraTradeQty ContraTradeQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContraTradeQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContraTradeQty val) 
                { 
                    ContraTradeQty = val;
                }
                
                public QuickFix.FXCM.Fields.ContraTradeQty Get(QuickFix.FXCM.Fields.ContraTradeQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContraTradeQty val) 
                { 
                    return IsSetContraTradeQty();
                }
                
                public bool IsSetContraTradeQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContraTradeQty);
                }
                
                public QuickFix.FXCM.Fields.ContraTradeTime ContraTradeTime
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContraTradeTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContraTradeTime val) 
                { 
                    ContraTradeTime = val;
                }
                
                public QuickFix.FXCM.Fields.ContraTradeTime Get(QuickFix.FXCM.Fields.ContraTradeTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContraTradeTime val) 
                { 
                    return IsSetContraTradeTime();
                }
                
                public bool IsSetContraTradeTime() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContraTradeTime);
                }
                
                public QuickFix.FXCM.Fields.ContraLegRefID ContraLegRefID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContraLegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContraLegRefID val) 
                { 
                    ContraLegRefID = val;
                }
                
                public QuickFix.FXCM.Fields.ContraLegRefID Get(QuickFix.FXCM.Fields.ContraLegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContraLegRefID val) 
                { 
                    return IsSetContraLegRefID();
                }
                
                public bool IsSetContraLegRefID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContraLegRefID);
                }
                
            
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SecurityAltID, QuickFix.FXCM.Fields.Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoSecurityAltID, QuickFix.FXCM.Fields.Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    SecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityAltID Get(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    SecurityAltIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityAltIDSource Get(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityAltIDSource);
                }
                
            
            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.EventType, QuickFix.FXCM.Fields.Tags.EventDate, QuickFix.FXCM.Fields.Tags.EventPx, QuickFix.FXCM.Fields.Tags.EventText, 0};
            
                public NoEventsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoEvents, QuickFix.FXCM.Fields.Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.EventType EventType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventType val) 
                { 
                    EventType = val;
                }
                
                public QuickFix.FXCM.Fields.EventType Get(QuickFix.FXCM.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventType);
                }
                
                public QuickFix.FXCM.Fields.EventDate EventDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    EventDate = val;
                }
                
                public QuickFix.FXCM.Fields.EventDate Get(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventDate);
                }
                
                public QuickFix.FXCM.Fields.EventPx EventPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    EventPx = val;
                }
                
                public QuickFix.FXCM.Fields.EventPx Get(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventPx);
                }
                
                public QuickFix.FXCM.Fields.EventText EventText
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventText val) 
                { 
                    EventText = val;
                }
                
                public QuickFix.FXCM.Fields.EventText Get(QuickFix.FXCM.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventText);
                }
                
            
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingSymbol, QuickFix.FXCM.Fields.Tags.UnderlyingSymbolSfx, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityIDSource, QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingProduct, QuickFix.FXCM.Fields.Tags.UnderlyingCFICode, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityType, QuickFix.FXCM.Fields.Tags.UnderlyingSecuritySubType, QuickFix.FXCM.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.FXCM.Fields.Tags.UnderlyingMaturityDate, QuickFix.FXCM.Fields.Tags.UnderlyingCouponPaymentDate, QuickFix.FXCM.Fields.Tags.UnderlyingIssueDate, QuickFix.FXCM.Fields.Tags.UnderlyingRepoCollateralSecurityType, QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseTerm, QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseRate, QuickFix.FXCM.Fields.Tags.UnderlyingFactor, QuickFix.FXCM.Fields.Tags.UnderlyingCreditRating, QuickFix.FXCM.Fields.Tags.UnderlyingInstrRegistry, QuickFix.FXCM.Fields.Tags.UnderlyingCountryOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingStateOrProvinceOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingLocaleOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingRedemptionDate, QuickFix.FXCM.Fields.Tags.UnderlyingStrikePrice, QuickFix.FXCM.Fields.Tags.UnderlyingStrikeCurrency, QuickFix.FXCM.Fields.Tags.UnderlyingOptAttribute, QuickFix.FXCM.Fields.Tags.UnderlyingContractMultiplier, QuickFix.FXCM.Fields.Tags.UnderlyingCouponRate, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityExchange, QuickFix.FXCM.Fields.Tags.UnderlyingIssuer, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityDesc, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.FXCM.Fields.Tags.UnderlyingCPProgram, QuickFix.FXCM.Fields.Tags.UnderlyingCPRegType, QuickFix.FXCM.Fields.Tags.UnderlyingCurrency, QuickFix.FXCM.Fields.Tags.UnderlyingQty, QuickFix.FXCM.Fields.Tags.UnderlyingPx, QuickFix.FXCM.Fields.Tags.UnderlyingDirtyPrice, QuickFix.FXCM.Fields.Tags.UnderlyingEndPrice, QuickFix.FXCM.Fields.Tags.UnderlyingStartValue, QuickFix.FXCM.Fields.Tags.UnderlyingCurrentValue, QuickFix.FXCM.Fields.Tags.UnderlyingEndValue, QuickFix.FXCM.Fields.Tags.NoUnderlyingStips, 0};
            
                public NoUnderlyingsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoUnderlyings, QuickFix.FXCM.Fields.Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.UnderlyingSymbol UnderlyingSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    UnderlyingSymbol = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbol Get(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    return IsSetUnderlyingSymbol();
                }
                
                public bool IsSetUnderlyingSymbol() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSymbol);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    UnderlyingSymbolSfx = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbolSfx Get(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    return IsSetUnderlyingSymbolSfx();
                }
                
                public bool IsSetUnderlyingSymbolSfx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSymbolSfx);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityID UnderlyingSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    UnderlyingSecurityID = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityID Get(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    return IsSetUnderlyingSecurityID();
                }
                
                public bool IsSetUnderlyingSecurityID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityID);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    UnderlyingSecurityIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityIDSource Get(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return IsSetUnderlyingSecurityIDSource();
                }
                
                public bool IsSetUnderlyingSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityIDSource);
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    NoUnderlyingSecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID Get(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    return IsSetNoUnderlyingSecurityAltID();
                }
                
                public bool IsSetNoUnderlyingSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingProduct UnderlyingProduct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    UnderlyingProduct = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingProduct Get(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    return IsSetUnderlyingProduct();
                }
                
                public bool IsSetUnderlyingProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingProduct);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCFICode UnderlyingCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    UnderlyingCFICode = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCFICode Get(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    return IsSetUnderlyingCFICode();
                }
                
                public bool IsSetUnderlyingCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCFICode);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityType UnderlyingSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    UnderlyingSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityType Get(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    return IsSetUnderlyingSecurityType();
                }
                
                public bool IsSetUnderlyingSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    UnderlyingSecuritySubType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecuritySubType Get(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    return IsSetUnderlyingSecuritySubType();
                }
                
                public bool IsSetUnderlyingSecuritySubType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecuritySubType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    UnderlyingMaturityMonthYear = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear Get(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    return IsSetUnderlyingMaturityMonthYear();
                }
                
                public bool IsSetUnderlyingMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingMaturityMonthYear);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    UnderlyingMaturityDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityDate Get(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    return IsSetUnderlyingMaturityDate();
                }
                
                public bool IsSetUnderlyingMaturityDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingMaturityDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    UnderlyingCouponPaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate Get(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    return IsSetUnderlyingCouponPaymentDate();
                }
                
                public bool IsSetUnderlyingCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCouponPaymentDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssueDate UnderlyingIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    UnderlyingIssueDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssueDate Get(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    return IsSetUnderlyingIssueDate();
                }
                
                public bool IsSetUnderlyingIssueDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingIssueDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    UnderlyingRepoCollateralSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    return IsSetUnderlyingRepoCollateralSecurityType();
                }
                
                public bool IsSetUnderlyingRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepoCollateralSecurityType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    UnderlyingRepurchaseTerm = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm Get(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    return IsSetUnderlyingRepurchaseTerm();
                }
                
                public bool IsSetUnderlyingRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseTerm);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    UnderlyingRepurchaseRate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseRate Get(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return IsSetUnderlyingRepurchaseRate();
                }
                
                public bool IsSetUnderlyingRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseRate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingFactor UnderlyingFactor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    UnderlyingFactor = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingFactor Get(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    return IsSetUnderlyingFactor();
                }
                
                public bool IsSetUnderlyingFactor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingFactor);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCreditRating UnderlyingCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    UnderlyingCreditRating = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCreditRating Get(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    return IsSetUnderlyingCreditRating();
                }
                
                public bool IsSetUnderlyingCreditRating() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCreditRating);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    UnderlyingInstrRegistry = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingInstrRegistry Get(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    return IsSetUnderlyingInstrRegistry();
                }
                
                public bool IsSetUnderlyingInstrRegistry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingInstrRegistry);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    UnderlyingCountryOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCountryOfIssue Get(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    return IsSetUnderlyingCountryOfIssue();
                }
                
                public bool IsSetUnderlyingCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCountryOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    UnderlyingStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    return IsSetUnderlyingStateOrProvinceOfIssue();
                }
                
                public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStateOrProvinceOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    UnderlyingLocaleOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue Get(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    return IsSetUnderlyingLocaleOfIssue();
                }
                
                public bool IsSetUnderlyingLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingLocaleOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    UnderlyingRedemptionDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRedemptionDate Get(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    return IsSetUnderlyingRedemptionDate();
                }
                
                public bool IsSetUnderlyingRedemptionDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRedemptionDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    UnderlyingStrikePrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikePrice Get(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    return IsSetUnderlyingStrikePrice();
                }
                
                public bool IsSetUnderlyingStrikePrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStrikePrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    UnderlyingStrikeCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikeCurrency Get(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    return IsSetUnderlyingStrikeCurrency();
                }
                
                public bool IsSetUnderlyingStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStrikeCurrency);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    UnderlyingOptAttribute = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingOptAttribute Get(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    return IsSetUnderlyingOptAttribute();
                }
                
                public bool IsSetUnderlyingOptAttribute() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingOptAttribute);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    UnderlyingContractMultiplier = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingContractMultiplier Get(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    return IsSetUnderlyingContractMultiplier();
                }
                
                public bool IsSetUnderlyingContractMultiplier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingContractMultiplier);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponRate UnderlyingCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    UnderlyingCouponRate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponRate Get(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    return IsSetUnderlyingCouponRate();
                }
                
                public bool IsSetUnderlyingCouponRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCouponRate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    UnderlyingSecurityExchange = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityExchange Get(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    return IsSetUnderlyingSecurityExchange();
                }
                
                public bool IsSetUnderlyingSecurityExchange() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityExchange);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssuer UnderlyingIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    UnderlyingIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssuer Get(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    return IsSetUnderlyingIssuer();
                }
                
                public bool IsSetUnderlyingIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingIssuer);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    EncodedUnderlyingIssuerLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    return IsSetEncodedUnderlyingIssuerLen();
                }
                
                public bool IsSetEncodedUnderlyingIssuerLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuerLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    EncodedUnderlyingIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuer Get(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    return IsSetEncodedUnderlyingIssuer();
                }
                
                public bool IsSetEncodedUnderlyingIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuer);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    UnderlyingSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityDesc Get(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    return IsSetUnderlyingSecurityDesc();
                }
                
                public bool IsSetUnderlyingSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    EncodedUnderlyingSecurityDescLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDescLen();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDescLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    EncodedUnderlyingSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDesc();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPProgram UnderlyingCPProgram
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    UnderlyingCPProgram = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPProgram Get(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    return IsSetUnderlyingCPProgram();
                }
                
                public bool IsSetUnderlyingCPProgram() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCPProgram);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPRegType UnderlyingCPRegType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    UnderlyingCPRegType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPRegType Get(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    return IsSetUnderlyingCPRegType();
                }
                
                public bool IsSetUnderlyingCPRegType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCPRegType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrency UnderlyingCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    UnderlyingCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrency Get(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    return IsSetUnderlyingCurrency();
                }
                
                public bool IsSetUnderlyingCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCurrency);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingQty UnderlyingQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    UnderlyingQty = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingQty Get(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    return IsSetUnderlyingQty();
                }
                
                public bool IsSetUnderlyingQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingQty);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingPx UnderlyingPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    UnderlyingPx = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingPx Get(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    return IsSetUnderlyingPx();
                }
                
                public bool IsSetUnderlyingPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingPx);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingDirtyPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    UnderlyingDirtyPrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingDirtyPrice Get(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    return IsSetUnderlyingDirtyPrice();
                }
                
                public bool IsSetUnderlyingDirtyPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingDirtyPrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndPrice UnderlyingEndPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingEndPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    UnderlyingEndPrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndPrice Get(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    return IsSetUnderlyingEndPrice();
                }
                
                public bool IsSetUnderlyingEndPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingEndPrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStartValue UnderlyingStartValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStartValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    UnderlyingStartValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStartValue Get(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    return IsSetUnderlyingStartValue();
                }
                
                public bool IsSetUnderlyingStartValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStartValue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCurrentValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    UnderlyingCurrentValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrentValue Get(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    return IsSetUnderlyingCurrentValue();
                }
                
                public bool IsSetUnderlyingCurrentValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCurrentValue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndValue UnderlyingEndValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingEndValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    UnderlyingEndValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndValue Get(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    return IsSetUnderlyingEndValue();
                }
                
                public bool IsSetUnderlyingEndValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingEndValue);
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingStips NoUnderlyingStips
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoUnderlyingStips();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    NoUnderlyingStips = val;
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingStips Get(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    return IsSetNoUnderlyingStips();
                }
                
                public bool IsSetNoUnderlyingStips() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyingStips);
                }
                
                            public class NoUnderlyingSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltIDSource, 0};
                
                    public NoUnderlyingSecurityAltIDGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        UnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltID Get(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        return IsSetUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID);
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        UnderlyingSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityAltIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltIDSource);
                    }
                    
                
                }
                public class NoUnderlyingStipsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingStipType, QuickFix.FXCM.Fields.Tags.UnderlyingStipValue, 0};
                
                    public NoUnderlyingStipsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoUnderlyingStips, QuickFix.FXCM.Fields.Tags.UnderlyingStipType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingStipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.UnderlyingStipType UnderlyingStipType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingStipType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        UnderlyingStipType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipType Get(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        return IsSetUnderlyingStipType();
                    }
                    
                    public bool IsSetUnderlyingStipType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStipType);
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipValue UnderlyingStipValue
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingStipValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        UnderlyingStipValue = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipValue Get(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        return IsSetUnderlyingStipValue();
                    }
                    
                    public bool IsSetUnderlyingStipValue() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStipValue);
                    }
                    
                
                }
            }
            public class NoStipulationsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.StipulationType, QuickFix.FXCM.Fields.Tags.StipulationValue, 0};
            
                public NoStipulationsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoStipulations, QuickFix.FXCM.Fields.Tags.StipulationType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStipulationsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.StipulationType StipulationType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StipulationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    StipulationType = val;
                }
                
                public QuickFix.FXCM.Fields.StipulationType Get(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    return IsSetStipulationType();
                }
                
                public bool IsSetStipulationType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StipulationType);
                }
                
                public QuickFix.FXCM.Fields.StipulationValue StipulationValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StipulationValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    StipulationValue = val;
                }
                
                public QuickFix.FXCM.Fields.StipulationValue Get(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    return IsSetStipulationValue();
                }
                
                public bool IsSetStipulationValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StipulationValue);
                }
                
            
            }
            public class NoContAmtsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.ContAmtType, QuickFix.FXCM.Fields.Tags.ContAmtValue, QuickFix.FXCM.Fields.Tags.ContAmtCurr, 0};
            
                public NoContAmtsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoContAmts, QuickFix.FXCM.Fields.Tags.ContAmtType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoContAmtsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.ContAmtType ContAmtType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContAmtType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContAmtType val) 
                { 
                    ContAmtType = val;
                }
                
                public QuickFix.FXCM.Fields.ContAmtType Get(QuickFix.FXCM.Fields.ContAmtType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContAmtType val) 
                { 
                    return IsSetContAmtType();
                }
                
                public bool IsSetContAmtType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContAmtType);
                }
                
                public QuickFix.FXCM.Fields.ContAmtValue ContAmtValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContAmtValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContAmtValue val) 
                { 
                    ContAmtValue = val;
                }
                
                public QuickFix.FXCM.Fields.ContAmtValue Get(QuickFix.FXCM.Fields.ContAmtValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContAmtValue val) 
                { 
                    return IsSetContAmtValue();
                }
                
                public bool IsSetContAmtValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContAmtValue);
                }
                
                public QuickFix.FXCM.Fields.ContAmtCurr ContAmtCurr
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ContAmtCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ContAmtCurr val) 
                { 
                    ContAmtCurr = val;
                }
                
                public QuickFix.FXCM.Fields.ContAmtCurr Get(QuickFix.FXCM.Fields.ContAmtCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ContAmtCurr val) 
                { 
                    return IsSetContAmtCurr();
                }
                
                public bool IsSetContAmtCurr() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ContAmtCurr);
                }
                
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegSymbol, QuickFix.FXCM.Fields.Tags.LegSymbolSfx, QuickFix.FXCM.Fields.Tags.LegSecurityID, QuickFix.FXCM.Fields.Tags.LegSecurityIDSource, QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegProduct, QuickFix.FXCM.Fields.Tags.LegCFICode, QuickFix.FXCM.Fields.Tags.LegSecurityType, QuickFix.FXCM.Fields.Tags.LegSecuritySubType, QuickFix.FXCM.Fields.Tags.LegMaturityMonthYear, QuickFix.FXCM.Fields.Tags.LegMaturityDate, QuickFix.FXCM.Fields.Tags.LegCouponPaymentDate, QuickFix.FXCM.Fields.Tags.LegIssueDate, QuickFix.FXCM.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.FXCM.Fields.Tags.LegRepurchaseTerm, QuickFix.FXCM.Fields.Tags.LegRepurchaseRate, QuickFix.FXCM.Fields.Tags.LegFactor, QuickFix.FXCM.Fields.Tags.LegCreditRating, QuickFix.FXCM.Fields.Tags.LegInstrRegistry, QuickFix.FXCM.Fields.Tags.LegCountryOfIssue, QuickFix.FXCM.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.FXCM.Fields.Tags.LegLocaleOfIssue, QuickFix.FXCM.Fields.Tags.LegRedemptionDate, QuickFix.FXCM.Fields.Tags.LegStrikePrice, QuickFix.FXCM.Fields.Tags.LegStrikeCurrency, QuickFix.FXCM.Fields.Tags.LegOptAttribute, QuickFix.FXCM.Fields.Tags.LegContractMultiplier, QuickFix.FXCM.Fields.Tags.LegCouponRate, QuickFix.FXCM.Fields.Tags.LegSecurityExchange, QuickFix.FXCM.Fields.Tags.LegIssuer, QuickFix.FXCM.Fields.Tags.EncodedLegIssuerLen, QuickFix.FXCM.Fields.Tags.EncodedLegIssuer, QuickFix.FXCM.Fields.Tags.LegSecurityDesc, QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDesc, QuickFix.FXCM.Fields.Tags.LegRatioQty, QuickFix.FXCM.Fields.Tags.LegSide, QuickFix.FXCM.Fields.Tags.LegCurrency, QuickFix.FXCM.Fields.Tags.LegPool, QuickFix.FXCM.Fields.Tags.LegDatedDate, QuickFix.FXCM.Fields.Tags.LegContractSettlMonth, QuickFix.FXCM.Fields.Tags.LegInterestAccrualDate, QuickFix.FXCM.Fields.Tags.LegQty, QuickFix.FXCM.Fields.Tags.LegSwapType, QuickFix.FXCM.Fields.Tags.NoLegStipulations, QuickFix.FXCM.Fields.Tags.LegPositionEffect, QuickFix.FXCM.Fields.Tags.LegCoveredOrUncovered, QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, QuickFix.FXCM.Fields.Tags.LegRefID, QuickFix.FXCM.Fields.Tags.LegPrice, QuickFix.FXCM.Fields.Tags.LegSettlType, QuickFix.FXCM.Fields.Tags.LegSettlDate, QuickFix.FXCM.Fields.Tags.LegLastPx, 0};
            
                public NoLegsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoLegs, QuickFix.FXCM.Fields.Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    LegSymbol = val;
                }
                
                public QuickFix.FXCM.Fields.LegSymbol Get(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSymbol);
                }
                
                public QuickFix.FXCM.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    LegSymbolSfx = val;
                }
                
                public QuickFix.FXCM.Fields.LegSymbolSfx Get(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSymbolSfx);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    LegSecurityID = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityID Get(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityID);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    LegSecurityIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityIDSource Get(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityIDSource);
                }
                
                public QuickFix.FXCM.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    NoLegSecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.NoLegSecurityAltID Get(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    LegProduct = val;
                }
                
                public QuickFix.FXCM.Fields.LegProduct Get(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegProduct);
                }
                
                public QuickFix.FXCM.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    LegCFICode = val;
                }
                
                public QuickFix.FXCM.Fields.LegCFICode Get(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCFICode);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    LegSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityType Get(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityType);
                }
                
                public QuickFix.FXCM.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    LegSecuritySubType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecuritySubType Get(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecuritySubType);
                }
                
                public QuickFix.FXCM.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    LegMaturityMonthYear = val;
                }
                
                public QuickFix.FXCM.Fields.LegMaturityMonthYear Get(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegMaturityMonthYear);
                }
                
                public QuickFix.FXCM.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    LegMaturityDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegMaturityDate Get(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegMaturityDate);
                }
                
                public QuickFix.FXCM.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    LegCouponPaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegCouponPaymentDate Get(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCouponPaymentDate);
                }
                
                public QuickFix.FXCM.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    LegIssueDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegIssueDate Get(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegIssueDate);
                }
                
                public QuickFix.FXCM.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepoCollateralSecurityType Get(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepoCollateralSecurityType);
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    LegRepurchaseTerm = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseTerm Get(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepurchaseTerm);
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    LegRepurchaseRate = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseRate Get(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepurchaseRate);
                }
                
                public QuickFix.FXCM.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    LegFactor = val;
                }
                
                public QuickFix.FXCM.Fields.LegFactor Get(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegFactor);
                }
                
                public QuickFix.FXCM.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    LegCreditRating = val;
                }
                
                public QuickFix.FXCM.Fields.LegCreditRating Get(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCreditRating);
                }
                
                public QuickFix.FXCM.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    LegInstrRegistry = val;
                }
                
                public QuickFix.FXCM.Fields.LegInstrRegistry Get(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegInstrRegistry);
                }
                
                public QuickFix.FXCM.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    LegCountryOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegCountryOfIssue Get(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCountryOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStateOrProvinceOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    LegLocaleOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegLocaleOfIssue Get(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegLocaleOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    LegRedemptionDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegRedemptionDate Get(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRedemptionDate);
                }
                
                public QuickFix.FXCM.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    LegStrikePrice = val;
                }
                
                public QuickFix.FXCM.Fields.LegStrikePrice Get(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStrikePrice);
                }
                
                public QuickFix.FXCM.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    LegStrikeCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegStrikeCurrency Get(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStrikeCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    LegOptAttribute = val;
                }
                
                public QuickFix.FXCM.Fields.LegOptAttribute Get(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegOptAttribute);
                }
                
                public QuickFix.FXCM.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    LegContractMultiplier = val;
                }
                
                public QuickFix.FXCM.Fields.LegContractMultiplier Get(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegContractMultiplier);
                }
                
                public QuickFix.FXCM.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    LegCouponRate = val;
                }
                
                public QuickFix.FXCM.Fields.LegCouponRate Get(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCouponRate);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    LegSecurityExchange = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityExchange Get(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityExchange);
                }
                
                public QuickFix.FXCM.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    LegIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.LegIssuer Get(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegIssuer);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    EncodedLegIssuerLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuerLen Get(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegIssuerLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    EncodedLegIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuer Get(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegIssuer);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    LegSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityDesc Get(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDescLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDesc Get(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    LegRatioQty = val;
                }
                
                public QuickFix.FXCM.Fields.LegRatioQty Get(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRatioQty);
                }
                
                public QuickFix.FXCM.Fields.LegSide LegSide
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    LegSide = val;
                }
                
                public QuickFix.FXCM.Fields.LegSide Get(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSide);
                }
                
                public QuickFix.FXCM.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    LegCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegCurrency Get(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegPool LegPool
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    LegPool = val;
                }
                
                public QuickFix.FXCM.Fields.LegPool Get(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegPool);
                }
                
                public QuickFix.FXCM.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    LegDatedDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegDatedDate Get(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegDatedDate);
                }
                
                public QuickFix.FXCM.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    LegContractSettlMonth = val;
                }
                
                public QuickFix.FXCM.Fields.LegContractSettlMonth Get(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegContractSettlMonth);
                }
                
                public QuickFix.FXCM.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    LegInterestAccrualDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegInterestAccrualDate Get(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegInterestAccrualDate);
                }
                
                public QuickFix.FXCM.Fields.LegQty LegQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegQty val) 
                { 
                    LegQty = val;
                }
                
                public QuickFix.FXCM.Fields.LegQty Get(QuickFix.FXCM.Fields.LegQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegQty val) 
                { 
                    return IsSetLegQty();
                }
                
                public bool IsSetLegQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegQty);
                }
                
                public QuickFix.FXCM.Fields.LegSwapType LegSwapType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSwapType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSwapType val) 
                { 
                    LegSwapType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSwapType Get(QuickFix.FXCM.Fields.LegSwapType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSwapType val) 
                { 
                    return IsSetLegSwapType();
                }
                
                public bool IsSetLegSwapType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSwapType);
                }
                
                public QuickFix.FXCM.Fields.NoLegStipulations NoLegStipulations
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoLegStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoLegStipulations val) 
                { 
                    NoLegStipulations = val;
                }
                
                public QuickFix.FXCM.Fields.NoLegStipulations Get(QuickFix.FXCM.Fields.NoLegStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoLegStipulations val) 
                { 
                    return IsSetNoLegStipulations();
                }
                
                public bool IsSetNoLegStipulations() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegStipulations);
                }
                
                public QuickFix.FXCM.Fields.LegPositionEffect LegPositionEffect
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegPositionEffect();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegPositionEffect val) 
                { 
                    LegPositionEffect = val;
                }
                
                public QuickFix.FXCM.Fields.LegPositionEffect Get(QuickFix.FXCM.Fields.LegPositionEffect val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegPositionEffect val) 
                { 
                    return IsSetLegPositionEffect();
                }
                
                public bool IsSetLegPositionEffect() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegPositionEffect);
                }
                
                public QuickFix.FXCM.Fields.LegCoveredOrUncovered LegCoveredOrUncovered
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCoveredOrUncovered();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCoveredOrUncovered val) 
                { 
                    LegCoveredOrUncovered = val;
                }
                
                public QuickFix.FXCM.Fields.LegCoveredOrUncovered Get(QuickFix.FXCM.Fields.LegCoveredOrUncovered val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCoveredOrUncovered val) 
                { 
                    return IsSetLegCoveredOrUncovered();
                }
                
                public bool IsSetLegCoveredOrUncovered() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCoveredOrUncovered);
                }
                
                public QuickFix.FXCM.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    NoNestedPartyIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoNestedPartyIDs Get(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs);
                }
                
                public QuickFix.FXCM.Fields.LegRefID LegRefID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRefID val) 
                { 
                    LegRefID = val;
                }
                
                public QuickFix.FXCM.Fields.LegRefID Get(QuickFix.FXCM.Fields.LegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRefID val) 
                { 
                    return IsSetLegRefID();
                }
                
                public bool IsSetLegRefID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRefID);
                }
                
                public QuickFix.FXCM.Fields.LegPrice LegPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegPrice val) 
                { 
                    LegPrice = val;
                }
                
                public QuickFix.FXCM.Fields.LegPrice Get(QuickFix.FXCM.Fields.LegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegPrice val) 
                { 
                    return IsSetLegPrice();
                }
                
                public bool IsSetLegPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegPrice);
                }
                
                public QuickFix.FXCM.Fields.LegSettlType LegSettlType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSettlType val) 
                { 
                    LegSettlType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSettlType Get(QuickFix.FXCM.Fields.LegSettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSettlType val) 
                { 
                    return IsSetLegSettlType();
                }
                
                public bool IsSetLegSettlType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSettlType);
                }
                
                public QuickFix.FXCM.Fields.LegSettlDate LegSettlDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSettlDate val) 
                { 
                    LegSettlDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegSettlDate Get(QuickFix.FXCM.Fields.LegSettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSettlDate val) 
                { 
                    return IsSetLegSettlDate();
                }
                
                public bool IsSetLegSettlDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSettlDate);
                }
                
                public QuickFix.FXCM.Fields.LegLastPx LegLastPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegLastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegLastPx val) 
                { 
                    LegLastPx = val;
                }
                
                public QuickFix.FXCM.Fields.LegLastPx Get(QuickFix.FXCM.Fields.LegLastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegLastPx val) 
                { 
                    return IsSetLegLastPx();
                }
                
                public bool IsSetLegLastPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegLastPx);
                }
                
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        LegSecurityAltID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltID Get(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityAltID);
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltIDSource Get(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityAltIDSource);
                    }
                    
                
                }
                public class NoLegStipulationsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegStipulationType, QuickFix.FXCM.Fields.Tags.LegStipulationValue, 0};
                
                    public NoLegStipulationsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoLegStipulations, QuickFix.FXCM.Fields.Tags.LegStipulationType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegStipulationsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.LegStipulationType LegStipulationType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegStipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegStipulationType val) 
                    { 
                        LegStipulationType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegStipulationType Get(QuickFix.FXCM.Fields.LegStipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegStipulationType val) 
                    { 
                        return IsSetLegStipulationType();
                    }
                    
                    public bool IsSetLegStipulationType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegStipulationType);
                    }
                    
                    public QuickFix.FXCM.Fields.LegStipulationValue LegStipulationValue
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegStipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegStipulationValue val) 
                    { 
                        LegStipulationValue = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegStipulationValue Get(QuickFix.FXCM.Fields.LegStipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegStipulationValue val) 
                    { 
                        return IsSetLegStipulationValue();
                    }
                    
                    public bool IsSetLegStipulationValue() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegStipulationValue);
                    }
                    
                
                }
                public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.NestedPartyID, QuickFix.FXCM.Fields.Tags.NestedPartyIDSource, QuickFix.FXCM.Fields.Tags.NestedPartyRole, QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, QuickFix.FXCM.Fields.Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        NestedPartyID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyID Get(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyID);
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyIDSource Get(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyIDSource);
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        NestedPartyRole = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyRole Get(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyRole);
                    }
                    
                    public QuickFix.FXCM.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NoNestedPartySubIDs Get(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs);
                    }
                    
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.NestedPartySubID, QuickFix.FXCM.Fields.Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs, QuickFix.FXCM.Fields.Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.FXCM.Fields.NestedPartySubID NestedPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NestedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            NestedPartySubID = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubID Get(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            return IsSetNestedPartySubID();
                        }
                        
                        public bool IsSetNestedPartySubID() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartySubID);
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubIDType Get(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartySubIDType);
                        }
                        
                    
                    }
                }
            }
            public class NoMiscFeesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.MiscFeeAmt, QuickFix.FXCM.Fields.Tags.MiscFeeCurr, QuickFix.FXCM.Fields.Tags.MiscFeeType, QuickFix.FXCM.Fields.Tags.MiscFeeBasis, 0};
            
                public NoMiscFeesGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoMiscFees, QuickFix.FXCM.Fields.Tags.MiscFeeAmt, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMiscFeesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.MiscFeeAmt MiscFeeAmt
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeAmt val) 
                { 
                    MiscFeeAmt = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeAmt Get(QuickFix.FXCM.Fields.MiscFeeAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeAmt val) 
                { 
                    return IsSetMiscFeeAmt();
                }
                
                public bool IsSetMiscFeeAmt() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeAmt);
                }
                
                public QuickFix.FXCM.Fields.MiscFeeCurr MiscFeeCurr
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeCurr val) 
                { 
                    MiscFeeCurr = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeCurr Get(QuickFix.FXCM.Fields.MiscFeeCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeCurr val) 
                { 
                    return IsSetMiscFeeCurr();
                }
                
                public bool IsSetMiscFeeCurr() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeCurr);
                }
                
                public QuickFix.FXCM.Fields.MiscFeeType MiscFeeType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeType val) 
                { 
                    MiscFeeType = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeType Get(QuickFix.FXCM.Fields.MiscFeeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeType val) 
                { 
                    return IsSetMiscFeeType();
                }
                
                public bool IsSetMiscFeeType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeType);
                }
                
                public QuickFix.FXCM.Fields.MiscFeeBasis MiscFeeBasis
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeBasis();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeBasis val) 
                { 
                    MiscFeeBasis = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeBasis Get(QuickFix.FXCM.Fields.MiscFeeBasis val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeBasis val) 
                { 
                    return IsSetMiscFeeBasis();
                }
                
                public bool IsSetMiscFeeBasis() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeBasis);
                }
                
            
            }
    }
}

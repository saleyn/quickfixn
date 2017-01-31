// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class ListStatus : Message
    {
            public const string MsgType = "N";

            public ListStatus() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("N"));
            }

            public ListStatus(
                    QuickFix.Fields.ListID aListID,
                    QuickFix.Fields.ListStatusType aListStatusType,
                    QuickFix.Fields.NoRpts aNoRpts,
                    QuickFix.Fields.ListOrderStatus aListOrderStatus,
                    QuickFix.Fields.RptSeq aRptSeq,
                    QuickFix.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.ListID = aListID;
                this.ListStatusType = aListStatusType;
                this.NoRpts = aNoRpts;
                this.ListOrderStatus = aListOrderStatus;
                this.RptSeq = aRptSeq;
                this.TotNoOrders = aTotNoOrders;
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
            
            public QuickFix.Fields.ListStatusType ListStatusType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListStatusType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListStatusType val) 
            { 
                ListStatusType = val;
            }
            
            public QuickFix.Fields.ListStatusType Get(QuickFix.Fields.ListStatusType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListStatusType val) 
            { 
                return IsSetListStatusType();
            }
            
            public bool IsSetListStatusType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListStatusType);
            }
            
            public QuickFix.Fields.NoRpts NoRpts
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoRpts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRpts val) 
            { 
                NoRpts = val;
            }
            
            public QuickFix.Fields.NoRpts Get(QuickFix.Fields.NoRpts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRpts val) 
            { 
                return IsSetNoRpts();
            }
            
            public bool IsSetNoRpts() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoRpts);
            }
            
            public QuickFix.Fields.ListOrderStatus ListOrderStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListOrderStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListOrderStatus val) 
            { 
                ListOrderStatus = val;
            }
            
            public QuickFix.Fields.ListOrderStatus Get(QuickFix.Fields.ListOrderStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListOrderStatus val) 
            { 
                return IsSetListOrderStatus();
            }
            
            public bool IsSetListOrderStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListOrderStatus);
            }
            
            public QuickFix.Fields.RptSeq RptSeq
            { 
                get 
                {
                    var val = new QuickFix.Fields.RptSeq();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RptSeq val) 
            { 
                RptSeq = val;
            }
            
            public QuickFix.Fields.RptSeq Get(QuickFix.Fields.RptSeq val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RptSeq val) 
            { 
                return IsSetRptSeq();
            }
            
            public bool IsSetRptSeq() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RptSeq);
            }
            
            public QuickFix.Fields.ListStatusText ListStatusText
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListStatusText val) 
            { 
                ListStatusText = val;
            }
            
            public QuickFix.Fields.ListStatusText Get(QuickFix.Fields.ListStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListStatusText val) 
            { 
                return IsSetListStatusText();
            }
            
            public bool IsSetListStatusText() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListStatusText);
            }
            
            public QuickFix.Fields.EncodedListStatusTextLen EncodedListStatusTextLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedListStatusTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                EncodedListStatusTextLen = val;
            }
            
            public QuickFix.Fields.EncodedListStatusTextLen Get(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListStatusTextLen val) 
            { 
                return IsSetEncodedListStatusTextLen();
            }
            
            public bool IsSetEncodedListStatusTextLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedListStatusTextLen);
            }
            
            public QuickFix.Fields.EncodedListStatusText EncodedListStatusText
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedListStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedListStatusText val) 
            { 
                EncodedListStatusText = val;
            }
            
            public QuickFix.Fields.EncodedListStatusText Get(QuickFix.Fields.EncodedListStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedListStatusText val) 
            { 
                return IsSetEncodedListStatusText();
            }
            
            public bool IsSetEncodedListStatusText() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedListStatusText);
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
            
            public QuickFix.Fields.TotNoOrders TotNoOrders
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotNoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoOrders val) 
            { 
                TotNoOrders = val;
            }
            
            public QuickFix.Fields.TotNoOrders Get(QuickFix.Fields.TotNoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoOrders val) 
            { 
                return IsSetTotNoOrders();
            }
            
            public bool IsSetTotNoOrders() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotNoOrders);
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
            
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.ClOrdID, QuickFix.Fields.Tags.SecondaryClOrdID, QuickFix.Fields.Tags.CumQty, QuickFix.Fields.Tags.OrdStatus, QuickFix.Fields.Tags.WorkingIndicator, QuickFix.Fields.Tags.LeavesQty, QuickFix.Fields.Tags.CxlQty, QuickFix.Fields.Tags.AvgPx, QuickFix.Fields.Tags.OrdRejReason, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, 0};
            
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
                
                public QuickFix.Fields.CumQty CumQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CumQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CumQty val) 
                { 
                    CumQty = val;
                }
                
                public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CumQty val) 
                { 
                    return IsSetCumQty();
                }
                
                public bool IsSetCumQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CumQty);
                }
                
                public QuickFix.Fields.OrdStatus OrdStatus
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OrdStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdStatus val) 
                { 
                    OrdStatus = val;
                }
                
                public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrdStatus val) 
                { 
                    return IsSetOrdStatus();
                }
                
                public bool IsSetOrdStatus() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OrdStatus);
                }
                
                public QuickFix.Fields.WorkingIndicator WorkingIndicator
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.WorkingIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.WorkingIndicator val) 
                { 
                    WorkingIndicator = val;
                }
                
                public QuickFix.Fields.WorkingIndicator Get(QuickFix.Fields.WorkingIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.WorkingIndicator val) 
                { 
                    return IsSetWorkingIndicator();
                }
                
                public bool IsSetWorkingIndicator() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.WorkingIndicator);
                }
                
                public QuickFix.Fields.LeavesQty LeavesQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LeavesQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LeavesQty val) 
                { 
                    LeavesQty = val;
                }
                
                public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LeavesQty val) 
                { 
                    return IsSetLeavesQty();
                }
                
                public bool IsSetLeavesQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LeavesQty);
                }
                
                public QuickFix.Fields.CxlQty CxlQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CxlQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CxlQty val) 
                { 
                    CxlQty = val;
                }
                
                public QuickFix.Fields.CxlQty Get(QuickFix.Fields.CxlQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CxlQty val) 
                { 
                    return IsSetCxlQty();
                }
                
                public bool IsSetCxlQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CxlQty);
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
                
                public QuickFix.Fields.OrdRejReason OrdRejReason
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OrdRejReason();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdRejReason val) 
                { 
                    OrdRejReason = val;
                }
                
                public QuickFix.Fields.OrdRejReason Get(QuickFix.Fields.OrdRejReason val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrdRejReason val) 
                { 
                    return IsSetOrdRejReason();
                }
                
                public bool IsSetOrdRejReason() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OrdRejReason);
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
                
            
            }
    }
}

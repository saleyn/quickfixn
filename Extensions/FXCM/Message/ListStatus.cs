// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class ListStatus : Message
    {
            public const string MsgType = "N";

            public ListStatus() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("N"));
            }

            public ListStatus(
                    QuickFix.FXCM.Fields.ListID aListID,
                    QuickFix.FXCM.Fields.ListStatusType aListStatusType,
                    QuickFix.FXCM.Fields.NoRpts aNoRpts,
                    QuickFix.FXCM.Fields.ListOrderStatus aListOrderStatus,
                    QuickFix.FXCM.Fields.RptSeq aRptSeq,
                    QuickFix.FXCM.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.ListID = aListID;
                this.ListStatusType = aListStatusType;
                this.NoRpts = aNoRpts;
                this.ListOrderStatus = aListOrderStatus;
                this.RptSeq = aRptSeq;
                this.TotNoOrders = aTotNoOrders;
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
            
            public QuickFix.FXCM.Fields.ListStatusType ListStatusType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ListStatusType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ListStatusType val) 
            { 
                ListStatusType = val;
            }
            
            public QuickFix.FXCM.Fields.ListStatusType Get(QuickFix.FXCM.Fields.ListStatusType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ListStatusType val) 
            { 
                return IsSetListStatusType();
            }
            
            public bool IsSetListStatusType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ListStatusType);
            }
            
            public QuickFix.FXCM.Fields.NoRpts NoRpts
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoRpts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoRpts val) 
            { 
                NoRpts = val;
            }
            
            public QuickFix.FXCM.Fields.NoRpts Get(QuickFix.FXCM.Fields.NoRpts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoRpts val) 
            { 
                return IsSetNoRpts();
            }
            
            public bool IsSetNoRpts() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoRpts);
            }
            
            public QuickFix.FXCM.Fields.ListOrderStatus ListOrderStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ListOrderStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ListOrderStatus val) 
            { 
                ListOrderStatus = val;
            }
            
            public QuickFix.FXCM.Fields.ListOrderStatus Get(QuickFix.FXCM.Fields.ListOrderStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ListOrderStatus val) 
            { 
                return IsSetListOrderStatus();
            }
            
            public bool IsSetListOrderStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ListOrderStatus);
            }
            
            public QuickFix.FXCM.Fields.RptSeq RptSeq
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RptSeq();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RptSeq val) 
            { 
                RptSeq = val;
            }
            
            public QuickFix.FXCM.Fields.RptSeq Get(QuickFix.FXCM.Fields.RptSeq val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RptSeq val) 
            { 
                return IsSetRptSeq();
            }
            
            public bool IsSetRptSeq() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RptSeq);
            }
            
            public QuickFix.FXCM.Fields.ListStatusText ListStatusText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ListStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ListStatusText val) 
            { 
                ListStatusText = val;
            }
            
            public QuickFix.FXCM.Fields.ListStatusText Get(QuickFix.FXCM.Fields.ListStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ListStatusText val) 
            { 
                return IsSetListStatusText();
            }
            
            public bool IsSetListStatusText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ListStatusText);
            }
            
            public QuickFix.FXCM.Fields.EncodedListStatusTextLen EncodedListStatusTextLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedListStatusTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedListStatusTextLen val) 
            { 
                EncodedListStatusTextLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedListStatusTextLen Get(QuickFix.FXCM.Fields.EncodedListStatusTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedListStatusTextLen val) 
            { 
                return IsSetEncodedListStatusTextLen();
            }
            
            public bool IsSetEncodedListStatusTextLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedListStatusTextLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedListStatusText EncodedListStatusText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedListStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedListStatusText val) 
            { 
                EncodedListStatusText = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedListStatusText Get(QuickFix.FXCM.Fields.EncodedListStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedListStatusText val) 
            { 
                return IsSetEncodedListStatusText();
            }
            
            public bool IsSetEncodedListStatusText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedListStatusText);
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
            
            public QuickFix.FXCM.Fields.TotNoOrders TotNoOrders
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotNoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotNoOrders val) 
            { 
                TotNoOrders = val;
            }
            
            public QuickFix.FXCM.Fields.TotNoOrders Get(QuickFix.FXCM.Fields.TotNoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotNoOrders val) 
            { 
                return IsSetTotNoOrders();
            }
            
            public bool IsSetTotNoOrders() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotNoOrders);
            }
            
            public QuickFix.FXCM.Fields.LastFragment LastFragment
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastFragment val) 
            { 
                LastFragment = val;
            }
            
            public QuickFix.FXCM.Fields.LastFragment Get(QuickFix.FXCM.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastFragment);
            }
            
            public QuickFix.FXCM.Fields.NoOrders NoOrders
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoOrders val) 
            { 
                NoOrders = val;
            }
            
            public QuickFix.FXCM.Fields.NoOrders Get(QuickFix.FXCM.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoOrders);
            }
            
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.ClOrdID, QuickFix.FXCM.Fields.Tags.SecondaryClOrdID, QuickFix.FXCM.Fields.Tags.CumQty, QuickFix.FXCM.Fields.Tags.OrdStatus, QuickFix.FXCM.Fields.Tags.WorkingIndicator, QuickFix.FXCM.Fields.Tags.LeavesQty, QuickFix.FXCM.Fields.Tags.CxlQty, QuickFix.FXCM.Fields.Tags.AvgPx, QuickFix.FXCM.Fields.Tags.OrdRejReason, QuickFix.FXCM.Fields.Tags.Text, QuickFix.FXCM.Fields.Tags.EncodedTextLen, QuickFix.FXCM.Fields.Tags.EncodedText, 0};
            
                public NoOrdersGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoOrders, QuickFix.FXCM.Fields.Tags.ClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.FXCM.Fields.CxlQty CxlQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CxlQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CxlQty val) 
                { 
                    CxlQty = val;
                }
                
                public QuickFix.FXCM.Fields.CxlQty Get(QuickFix.FXCM.Fields.CxlQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CxlQty val) 
                { 
                    return IsSetCxlQty();
                }
                
                public bool IsSetCxlQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CxlQty);
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
                
            
            }
    }
}

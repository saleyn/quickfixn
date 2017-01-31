// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class ConfirmationRequest : Message
    {
            public const string MsgType = "BH";

            public ConfirmationRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("BH"));
            }

            public ConfirmationRequest(
                    QuickFix.FXCM.Fields.ConfirmReqID aConfirmReqID,
                    QuickFix.FXCM.Fields.ConfirmType aConfirmType,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.ConfirmReqID = aConfirmReqID;
                this.ConfirmType = aConfirmType;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.FXCM.Fields.ConfirmReqID ConfirmReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmReqID val) 
            { 
                ConfirmReqID = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmReqID Get(QuickFix.FXCM.Fields.ConfirmReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmReqID val) 
            { 
                return IsSetConfirmReqID();
            }
            
            public bool IsSetConfirmReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmReqID);
            }
            
            public QuickFix.FXCM.Fields.ConfirmType ConfirmType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmType val) 
            { 
                ConfirmType = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmType Get(QuickFix.FXCM.Fields.ConfirmType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmType val) 
            { 
                return IsSetConfirmType();
            }
            
            public bool IsSetConfirmType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmType);
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
            
            public QuickFix.FXCM.Fields.AllocID AllocID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocID val) 
            { 
                AllocID = val;
            }
            
            public QuickFix.FXCM.Fields.AllocID Get(QuickFix.FXCM.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryAllocID SecondaryAllocID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryAllocID val) 
            { 
                SecondaryAllocID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryAllocID Get(QuickFix.FXCM.Fields.SecondaryAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryAllocID val) 
            { 
                return IsSetSecondaryAllocID();
            }
            
            public bool IsSetSecondaryAllocID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryAllocID);
            }
            
            public QuickFix.FXCM.Fields.IndividualAllocID IndividualAllocID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.IndividualAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.IndividualAllocID val) 
            { 
                IndividualAllocID = val;
            }
            
            public QuickFix.FXCM.Fields.IndividualAllocID Get(QuickFix.FXCM.Fields.IndividualAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.IndividualAllocID val) 
            { 
                return IsSetIndividualAllocID();
            }
            
            public bool IsSetIndividualAllocID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.IndividualAllocID);
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
            
            public QuickFix.FXCM.Fields.AllocAccount AllocAccount
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocAccount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocAccount val) 
            { 
                AllocAccount = val;
            }
            
            public QuickFix.FXCM.Fields.AllocAccount Get(QuickFix.FXCM.Fields.AllocAccount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocAccount val) 
            { 
                return IsSetAllocAccount();
            }
            
            public bool IsSetAllocAccount() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocAccount);
            }
            
            public QuickFix.FXCM.Fields.AllocAcctIDSource AllocAcctIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocAcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocAcctIDSource val) 
            { 
                AllocAcctIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.AllocAcctIDSource Get(QuickFix.FXCM.Fields.AllocAcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocAcctIDSource val) 
            { 
                return IsSetAllocAcctIDSource();
            }
            
            public bool IsSetAllocAcctIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocAcctIDSource);
            }
            
            public QuickFix.FXCM.Fields.AllocAccountType AllocAccountType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocAccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocAccountType val) 
            { 
                AllocAccountType = val;
            }
            
            public QuickFix.FXCM.Fields.AllocAccountType Get(QuickFix.FXCM.Fields.AllocAccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocAccountType val) 
            { 
                return IsSetAllocAccountType();
            }
            
            public bool IsSetAllocAccountType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocAccountType);
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
            
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.ClOrdID, QuickFix.FXCM.Fields.Tags.OrderID, QuickFix.FXCM.Fields.Tags.SecondaryOrderID, QuickFix.FXCM.Fields.Tags.SecondaryClOrdID, QuickFix.FXCM.Fields.Tags.ListID, QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs, QuickFix.FXCM.Fields.Tags.OrderQty, QuickFix.FXCM.Fields.Tags.OrderAvgPx, QuickFix.FXCM.Fields.Tags.OrderBookingQty, 0};
            
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
                
                public QuickFix.FXCM.Fields.NoNested2PartyIDs NoNested2PartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoNested2PartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoNested2PartyIDs val) 
                { 
                    NoNested2PartyIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoNested2PartyIDs Get(QuickFix.FXCM.Fields.NoNested2PartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoNested2PartyIDs val) 
                { 
                    return IsSetNoNested2PartyIDs();
                }
                
                public bool IsSetNoNested2PartyIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs);
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
                
                public QuickFix.FXCM.Fields.OrderAvgPx OrderAvgPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderAvgPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderAvgPx val) 
                { 
                    OrderAvgPx = val;
                }
                
                public QuickFix.FXCM.Fields.OrderAvgPx Get(QuickFix.FXCM.Fields.OrderAvgPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderAvgPx val) 
                { 
                    return IsSetOrderAvgPx();
                }
                
                public bool IsSetOrderAvgPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderAvgPx);
                }
                
                public QuickFix.FXCM.Fields.OrderBookingQty OrderBookingQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderBookingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderBookingQty val) 
                { 
                    OrderBookingQty = val;
                }
                
                public QuickFix.FXCM.Fields.OrderBookingQty Get(QuickFix.FXCM.Fields.OrderBookingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderBookingQty val) 
                { 
                    return IsSetOrderBookingQty();
                }
                
                public bool IsSetOrderBookingQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderBookingQty);
                }
                
                            public class NoNested2PartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.Nested2PartyID, QuickFix.FXCM.Fields.Tags.Nested2PartyIDSource, QuickFix.FXCM.Fields.Tags.Nested2PartyRole, QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs, 0};
                
                    public NoNested2PartyIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs, QuickFix.FXCM.Fields.Tags.Nested2PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNested2PartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.Nested2PartyID Nested2PartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.Nested2PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.Nested2PartyID val) 
                    { 
                        Nested2PartyID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyID Get(QuickFix.FXCM.Fields.Nested2PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.Nested2PartyID val) 
                    { 
                        return IsSetNested2PartyID();
                    }
                    
                    public bool IsSetNested2PartyID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartyID);
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyIDSource Nested2PartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.Nested2PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.Nested2PartyIDSource val) 
                    { 
                        Nested2PartyIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyIDSource Get(QuickFix.FXCM.Fields.Nested2PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.Nested2PartyIDSource val) 
                    { 
                        return IsSetNested2PartyIDSource();
                    }
                    
                    public bool IsSetNested2PartyIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartyIDSource);
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyRole Nested2PartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.Nested2PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.Nested2PartyRole val) 
                    { 
                        Nested2PartyRole = val;
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyRole Get(QuickFix.FXCM.Fields.Nested2PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.Nested2PartyRole val) 
                    { 
                        return IsSetNested2PartyRole();
                    }
                    
                    public bool IsSetNested2PartyRole() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartyRole);
                    }
                    
                    public QuickFix.FXCM.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NoNested2PartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NoNested2PartySubIDs val) 
                    { 
                        NoNested2PartySubIDs = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NoNested2PartySubIDs Get(QuickFix.FXCM.Fields.NoNested2PartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NoNested2PartySubIDs val) 
                    { 
                        return IsSetNoNested2PartySubIDs();
                    }
                    
                    public bool IsSetNoNested2PartySubIDs() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs);
                    }
                    
                                    public class NoNested2PartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.Nested2PartySubID, QuickFix.FXCM.Fields.Tags.Nested2PartySubIDType, 0};
                    
                        public NoNested2PartySubIDsGroup() 
                          :base( QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs, QuickFix.FXCM.Fields.Tags.Nested2PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested2PartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.FXCM.Fields.Nested2PartySubID Nested2PartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.Nested2PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.Nested2PartySubID val) 
                        { 
                            Nested2PartySubID = val;
                        }
                        
                        public QuickFix.FXCM.Fields.Nested2PartySubID Get(QuickFix.FXCM.Fields.Nested2PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.Nested2PartySubID val) 
                        { 
                            return IsSetNested2PartySubID();
                        }
                        
                        public bool IsSetNested2PartySubID() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartySubID);
                        }
                        
                        public QuickFix.FXCM.Fields.Nested2PartySubIDType Nested2PartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.Nested2PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.Nested2PartySubIDType val) 
                        { 
                            Nested2PartySubIDType = val;
                        }
                        
                        public QuickFix.FXCM.Fields.Nested2PartySubIDType Get(QuickFix.FXCM.Fields.Nested2PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.Nested2PartySubIDType val) 
                        { 
                            return IsSetNested2PartySubIDType();
                        }
                        
                        public bool IsSetNested2PartySubIDType() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartySubIDType);
                        }
                        
                    
                    }
                }
            }
    }
}

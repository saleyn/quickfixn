// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class AdjustedPositionReport : Message
    {
            public const string MsgType = "BL";

            public AdjustedPositionReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BL"));
            }

            public AdjustedPositionReport(
                    QuickFix.Fields.PosMaintRptID aPosMaintRptID,
                    QuickFix.Fields.ClearingBusinessDate aClearingBusinessDate
                ) : this()
            {
                this.PosMaintRptID = aPosMaintRptID;
                this.ClearingBusinessDate = aClearingBusinessDate;
            }

            public QuickFix.Fields.PosMaintRptID PosMaintRptID
            { 
                get 
                {
                    var val = new QuickFix.Fields.PosMaintRptID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PosMaintRptID val) 
            { 
                PosMaintRptID = val;
            }
            
            public QuickFix.Fields.PosMaintRptID Get(QuickFix.Fields.PosMaintRptID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PosMaintRptID val) 
            { 
                return IsSetPosMaintRptID();
            }
            
            public bool IsSetPosMaintRptID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PosMaintRptID);
            }
            
            public QuickFix.Fields.PosReqType PosReqType
            { 
                get 
                {
                    var val = new QuickFix.Fields.PosReqType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PosReqType val) 
            { 
                PosReqType = val;
            }
            
            public QuickFix.Fields.PosReqType Get(QuickFix.Fields.PosReqType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PosReqType val) 
            { 
                return IsSetPosReqType();
            }
            
            public bool IsSetPosReqType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PosReqType);
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
            
            public QuickFix.Fields.SettlSessID SettlSessID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlSessID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlSessID val) 
            { 
                SettlSessID = val;
            }
            
            public QuickFix.Fields.SettlSessID Get(QuickFix.Fields.SettlSessID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlSessID val) 
            { 
                return IsSetSettlSessID();
            }
            
            public bool IsSetSettlSessID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlSessID);
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
            
            public QuickFix.Fields.NoPositions NoPositions
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoPositions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPositions val) 
            { 
                NoPositions = val;
            }
            
            public QuickFix.Fields.NoPositions Get(QuickFix.Fields.NoPositions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPositions val) 
            { 
                return IsSetNoPositions();
            }
            
            public bool IsSetNoPositions() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoPositions);
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
            
            public QuickFix.Fields.SettlPrice SettlPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlPrice val) 
            { 
                SettlPrice = val;
            }
            
            public QuickFix.Fields.SettlPrice Get(QuickFix.Fields.SettlPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlPrice val) 
            { 
                return IsSetSettlPrice();
            }
            
            public bool IsSetSettlPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlPrice);
            }
            
            public QuickFix.Fields.PriorSettlPrice PriorSettlPrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.PriorSettlPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriorSettlPrice val) 
            { 
                PriorSettlPrice = val;
            }
            
            public QuickFix.Fields.PriorSettlPrice Get(QuickFix.Fields.PriorSettlPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriorSettlPrice val) 
            { 
                return IsSetPriorSettlPrice();
            }
            
            public bool IsSetPriorSettlPrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PriorSettlPrice);
            }
            
            public QuickFix.Fields.PosMaintRptRefID PosMaintRptRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.PosMaintRptRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PosMaintRptRefID val) 
            { 
                PosMaintRptRefID = val;
            }
            
            public QuickFix.Fields.PosMaintRptRefID Get(QuickFix.Fields.PosMaintRptRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PosMaintRptRefID val) 
            { 
                return IsSetPosMaintRptRefID();
            }
            
            public bool IsSetPosMaintRptRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PosMaintRptRefID);
            }
            
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyID, QuickFix.Fields.Tags.PartyIDSource, QuickFix.Fields.Tags.PartyRole, QuickFix.Fields.Tags.NoPartySubIDs, 0};
            
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
                
                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    NoPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoPartySubIDs);
                }
                
                            public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.PartySubID, QuickFix.Fields.Tags.PartySubIDType, 0};
                
                    public NoPartySubIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoPartySubIDs, QuickFix.Fields.Tags.PartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
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
                    
                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        PartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.PartySubIDType);
                    }
                    
                
                }
            }
            public class NoPositionsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.PosType, QuickFix.Fields.Tags.LongQty, QuickFix.Fields.Tags.ShortQty, QuickFix.Fields.Tags.PosQtyStatus, QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.QuantityDate, 0};
            
                public NoPositionsGroup() 
                  :base( QuickFix.Fields.Tags.NoPositions, QuickFix.Fields.Tags.PosType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPositionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.PosType PosType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PosType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PosType val) 
                { 
                    PosType = val;
                }
                
                public QuickFix.Fields.PosType Get(QuickFix.Fields.PosType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PosType val) 
                { 
                    return IsSetPosType();
                }
                
                public bool IsSetPosType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PosType);
                }
                
                public QuickFix.Fields.LongQty LongQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LongQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LongQty val) 
                { 
                    LongQty = val;
                }
                
                public QuickFix.Fields.LongQty Get(QuickFix.Fields.LongQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LongQty val) 
                { 
                    return IsSetLongQty();
                }
                
                public bool IsSetLongQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LongQty);
                }
                
                public QuickFix.Fields.ShortQty ShortQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ShortQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ShortQty val) 
                { 
                    ShortQty = val;
                }
                
                public QuickFix.Fields.ShortQty Get(QuickFix.Fields.ShortQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ShortQty val) 
                { 
                    return IsSetShortQty();
                }
                
                public bool IsSetShortQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ShortQty);
                }
                
                public QuickFix.Fields.PosQtyStatus PosQtyStatus
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.PosQtyStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PosQtyStatus val) 
                { 
                    PosQtyStatus = val;
                }
                
                public QuickFix.Fields.PosQtyStatus Get(QuickFix.Fields.PosQtyStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PosQtyStatus val) 
                { 
                    return IsSetPosQtyStatus();
                }
                
                public bool IsSetPosQtyStatus() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.PosQtyStatus);
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
                
                public QuickFix.Fields.QuantityDate QuantityDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.QuantityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuantityDate val) 
                { 
                    QuantityDate = val;
                }
                
                public QuickFix.Fields.QuantityDate Get(QuickFix.Fields.QuantityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuantityDate val) 
                { 
                    return IsSetQuantityDate();
                }
                
                public bool IsSetQuantityDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.QuantityDate);
                }
                
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartyID, QuickFix.Fields.Tags.NestedPartyIDSource, QuickFix.Fields.Tags.NestedPartyRole, QuickFix.Fields.Tags.NoNestedPartySubIDs, 0};
                
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
                    
                    public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoNestedPartySubIDs);
                    }
                    
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartySubID, QuickFix.Fields.Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoNestedPartySubIDs, QuickFix.Fields.Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
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
                        
                        public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NestedPartySubIDType);
                        }
                        
                    
                    }
                }
            }
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.Symbol, QuickFix.Fields.Tags.SymbolSfx, QuickFix.Fields.Tags.SecurityID, QuickFix.Fields.Tags.SecurityIDSource, QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.Product, QuickFix.Fields.Tags.CFICode, QuickFix.Fields.Tags.SecurityType, QuickFix.Fields.Tags.SecuritySubType, QuickFix.Fields.Tags.MaturityMonthYear, QuickFix.Fields.Tags.MaturityDate, QuickFix.Fields.Tags.CouponPaymentDate, QuickFix.Fields.Tags.IssueDate, QuickFix.Fields.Tags.RepoCollateralSecurityType, QuickFix.Fields.Tags.RepurchaseTerm, QuickFix.Fields.Tags.RepurchaseRate, QuickFix.Fields.Tags.Factor, QuickFix.Fields.Tags.CreditRating, QuickFix.Fields.Tags.InstrRegistry, QuickFix.Fields.Tags.CountryOfIssue, QuickFix.Fields.Tags.StateOrProvinceOfIssue, QuickFix.Fields.Tags.LocaleOfIssue, QuickFix.Fields.Tags.RedemptionDate, QuickFix.Fields.Tags.StrikePrice, QuickFix.Fields.Tags.StrikeCurrency, QuickFix.Fields.Tags.OptAttribute, QuickFix.Fields.Tags.ContractMultiplier, QuickFix.Fields.Tags.CouponRate, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.Issuer, QuickFix.Fields.Tags.EncodedIssuerLen, QuickFix.Fields.Tags.EncodedIssuer, QuickFix.Fields.Tags.SecurityDesc, QuickFix.Fields.Tags.EncodedSecurityDescLen, QuickFix.Fields.Tags.EncodedSecurityDesc, QuickFix.Fields.Tags.Pool, QuickFix.Fields.Tags.ContractSettlMonth, QuickFix.Fields.Tags.CPProgram, QuickFix.Fields.Tags.CPRegType, QuickFix.Fields.Tags.NoEvents, QuickFix.Fields.Tags.DatedDate, QuickFix.Fields.Tags.InterestAccrualDate, QuickFix.Fields.Tags.SecurityStatus, QuickFix.Fields.Tags.SettleOnOpenFlag, QuickFix.Fields.Tags.InstrmtAssignmentMethod, QuickFix.Fields.Tags.StrikeMultiplier, QuickFix.Fields.Tags.StrikeValue, QuickFix.Fields.Tags.MinPriceIncrement, QuickFix.Fields.Tags.PositionLimit, QuickFix.Fields.Tags.NTPositionLimit, QuickFix.Fields.Tags.NoInstrumentParties, QuickFix.Fields.Tags.UnitOfMeasure, QuickFix.Fields.Tags.TimeUnit, QuickFix.Fields.Tags.MaturityTime, QuickFix.Fields.Tags.SecurityGroup, QuickFix.Fields.Tags.MinPriceIncrementAmount, QuickFix.Fields.Tags.UnitOfMeasureQty, QuickFix.Fields.Tags.SecurityXMLLen, QuickFix.Fields.Tags.SecurityXML, QuickFix.Fields.Tags.SecurityXMLSchema, QuickFix.Fields.Tags.ProductComplex, QuickFix.Fields.Tags.PriceUnitOfMeasure, QuickFix.Fields.Tags.PriceUnitOfMeasureQty, QuickFix.Fields.Tags.SettlMethod, QuickFix.Fields.Tags.ExerciseStyle, QuickFix.Fields.Tags.OptPayoutAmount, QuickFix.Fields.Tags.PriceQuoteMethod, QuickFix.Fields.Tags.ListMethod, QuickFix.Fields.Tags.CapPrice, QuickFix.Fields.Tags.FloorPrice, QuickFix.Fields.Tags.PutOrCall, QuickFix.Fields.Tags.FlexibleIndicator, QuickFix.Fields.Tags.FlexProductEligibilityIndicator, QuickFix.Fields.Tags.ValuationMethod, QuickFix.Fields.Tags.ContractMultiplierUnit, QuickFix.Fields.Tags.FlowScheduleType, QuickFix.Fields.Tags.RestructuringType, QuickFix.Fields.Tags.Seniority, QuickFix.Fields.Tags.NotionalPercentageOutstanding, QuickFix.Fields.Tags.OriginalNotionalPercentageOutstanding, QuickFix.Fields.Tags.AttachmentPoint, QuickFix.Fields.Tags.DetachmentPoint, QuickFix.Fields.Tags.StrikePriceDeterminationMethod, QuickFix.Fields.Tags.StrikePriceBoundaryMethod, QuickFix.Fields.Tags.StrikePriceBoundaryPrecision, QuickFix.Fields.Tags.UnderlyingPriceDeterminationMethod, QuickFix.Fields.Tags.OptPayoutType, QuickFix.Fields.Tags.NoComplexEvents, 0};
            
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
            }
    }
}

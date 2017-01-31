// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class AllocationInstructionAck : Message
    {
            public const string MsgType = "P";

            public AllocationInstructionAck() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("P"));
            }

            public AllocationInstructionAck(
                    QuickFix.FXCM.Fields.AllocID aAllocID,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime,
                    QuickFix.FXCM.Fields.AllocStatus aAllocStatus
                ) : this()
            {
                this.AllocID = aAllocID;
                this.TransactTime = aTransactTime;
                this.AllocStatus = aAllocStatus;
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
            
            public QuickFix.FXCM.Fields.AllocStatus AllocStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocStatus val) 
            { 
                AllocStatus = val;
            }
            
            public QuickFix.FXCM.Fields.AllocStatus Get(QuickFix.FXCM.Fields.AllocStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocStatus val) 
            { 
                return IsSetAllocStatus();
            }
            
            public bool IsSetAllocStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocStatus);
            }
            
            public QuickFix.FXCM.Fields.AllocRejCode AllocRejCode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocRejCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocRejCode val) 
            { 
                AllocRejCode = val;
            }
            
            public QuickFix.FXCM.Fields.AllocRejCode Get(QuickFix.FXCM.Fields.AllocRejCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocRejCode val) 
            { 
                return IsSetAllocRejCode();
            }
            
            public bool IsSetAllocRejCode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocRejCode);
            }
            
            public QuickFix.FXCM.Fields.AllocType AllocType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocType val) 
            { 
                AllocType = val;
            }
            
            public QuickFix.FXCM.Fields.AllocType Get(QuickFix.FXCM.Fields.AllocType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocType val) 
            { 
                return IsSetAllocType();
            }
            
            public bool IsSetAllocType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocType);
            }
            
            public QuickFix.FXCM.Fields.AllocIntermedReqType AllocIntermedReqType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocIntermedReqType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocIntermedReqType val) 
            { 
                AllocIntermedReqType = val;
            }
            
            public QuickFix.FXCM.Fields.AllocIntermedReqType Get(QuickFix.FXCM.Fields.AllocIntermedReqType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocIntermedReqType val) 
            { 
                return IsSetAllocIntermedReqType();
            }
            
            public bool IsSetAllocIntermedReqType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocIntermedReqType);
            }
            
            public QuickFix.FXCM.Fields.MatchStatus MatchStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MatchStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MatchStatus val) 
            { 
                MatchStatus = val;
            }
            
            public QuickFix.FXCM.Fields.MatchStatus Get(QuickFix.FXCM.Fields.MatchStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MatchStatus val) 
            { 
                return IsSetMatchStatus();
            }
            
            public bool IsSetMatchStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MatchStatus);
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
            
            public QuickFix.FXCM.Fields.NoAllocs NoAllocs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoAllocs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoAllocs val) 
            { 
                NoAllocs = val;
            }
            
            public QuickFix.FXCM.Fields.NoAllocs Get(QuickFix.FXCM.Fields.NoAllocs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoAllocs val) 
            { 
                return IsSetNoAllocs();
            }
            
            public bool IsSetNoAllocs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoAllocs);
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
            public class NoAllocsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.AllocAccount, QuickFix.FXCM.Fields.Tags.AllocAcctIDSource, QuickFix.FXCM.Fields.Tags.AllocPrice, QuickFix.FXCM.Fields.Tags.IndividualAllocID, QuickFix.FXCM.Fields.Tags.IndividualAllocRejCode, QuickFix.FXCM.Fields.Tags.AllocText, QuickFix.FXCM.Fields.Tags.EncodedAllocTextLen, QuickFix.FXCM.Fields.Tags.EncodedAllocText, 0};
            
                public NoAllocsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoAllocs, QuickFix.FXCM.Fields.Tags.AllocAccount, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoAllocsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.FXCM.Fields.AllocPrice AllocPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.AllocPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.AllocPrice val) 
                { 
                    AllocPrice = val;
                }
                
                public QuickFix.FXCM.Fields.AllocPrice Get(QuickFix.FXCM.Fields.AllocPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.AllocPrice val) 
                { 
                    return IsSetAllocPrice();
                }
                
                public bool IsSetAllocPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.AllocPrice);
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
                
                public QuickFix.FXCM.Fields.IndividualAllocRejCode IndividualAllocRejCode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.IndividualAllocRejCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.IndividualAllocRejCode val) 
                { 
                    IndividualAllocRejCode = val;
                }
                
                public QuickFix.FXCM.Fields.IndividualAllocRejCode Get(QuickFix.FXCM.Fields.IndividualAllocRejCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.IndividualAllocRejCode val) 
                { 
                    return IsSetIndividualAllocRejCode();
                }
                
                public bool IsSetIndividualAllocRejCode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.IndividualAllocRejCode);
                }
                
                public QuickFix.FXCM.Fields.AllocText AllocText
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.AllocText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.AllocText val) 
                { 
                    AllocText = val;
                }
                
                public QuickFix.FXCM.Fields.AllocText Get(QuickFix.FXCM.Fields.AllocText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.AllocText val) 
                { 
                    return IsSetAllocText();
                }
                
                public bool IsSetAllocText() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.AllocText);
                }
                
                public QuickFix.FXCM.Fields.EncodedAllocTextLen EncodedAllocTextLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedAllocTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedAllocTextLen val) 
                { 
                    EncodedAllocTextLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedAllocTextLen Get(QuickFix.FXCM.Fields.EncodedAllocTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedAllocTextLen val) 
                { 
                    return IsSetEncodedAllocTextLen();
                }
                
                public bool IsSetEncodedAllocTextLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedAllocTextLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedAllocText EncodedAllocText
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedAllocText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedAllocText val) 
                { 
                    EncodedAllocText = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedAllocText Get(QuickFix.FXCM.Fields.EncodedAllocText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedAllocText val) 
                { 
                    return IsSetEncodedAllocText();
                }
                
                public bool IsSetEncodedAllocText() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedAllocText);
                }
                
            
            }
    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class SettlementInstructionRequest : Message
    {
            public const string MsgType = "AV";

            public SettlementInstructionRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("AV"));
            }

            public SettlementInstructionRequest(
                    QuickFix.FXCM.Fields.SettlInstReqID aSettlInstReqID,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.SettlInstReqID = aSettlInstReqID;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.FXCM.Fields.SettlInstReqID SettlInstReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlInstReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlInstReqID val) 
            { 
                SettlInstReqID = val;
            }
            
            public QuickFix.FXCM.Fields.SettlInstReqID Get(QuickFix.FXCM.Fields.SettlInstReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlInstReqID val) 
            { 
                return IsSetSettlInstReqID();
            }
            
            public bool IsSetSettlInstReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstReqID);
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
            
            public QuickFix.FXCM.Fields.LastUpdateTime LastUpdateTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastUpdateTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastUpdateTime val) 
            { 
                LastUpdateTime = val;
            }
            
            public QuickFix.FXCM.Fields.LastUpdateTime Get(QuickFix.FXCM.Fields.LastUpdateTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastUpdateTime val) 
            { 
                return IsSetLastUpdateTime();
            }
            
            public bool IsSetLastUpdateTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastUpdateTime);
            }
            
            public QuickFix.FXCM.Fields.StandInstDbType StandInstDbType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StandInstDbType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StandInstDbType val) 
            { 
                StandInstDbType = val;
            }
            
            public QuickFix.FXCM.Fields.StandInstDbType Get(QuickFix.FXCM.Fields.StandInstDbType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StandInstDbType val) 
            { 
                return IsSetStandInstDbType();
            }
            
            public bool IsSetStandInstDbType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StandInstDbType);
            }
            
            public QuickFix.FXCM.Fields.StandInstDbName StandInstDbName
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StandInstDbName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StandInstDbName val) 
            { 
                StandInstDbName = val;
            }
            
            public QuickFix.FXCM.Fields.StandInstDbName Get(QuickFix.FXCM.Fields.StandInstDbName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StandInstDbName val) 
            { 
                return IsSetStandInstDbName();
            }
            
            public bool IsSetStandInstDbName() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StandInstDbName);
            }
            
            public QuickFix.FXCM.Fields.StandInstDbID StandInstDbID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StandInstDbID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StandInstDbID val) 
            { 
                StandInstDbID = val;
            }
            
            public QuickFix.FXCM.Fields.StandInstDbID Get(QuickFix.FXCM.Fields.StandInstDbID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StandInstDbID val) 
            { 
                return IsSetStandInstDbID();
            }
            
            public bool IsSetStandInstDbID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StandInstDbID);
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
    }
}

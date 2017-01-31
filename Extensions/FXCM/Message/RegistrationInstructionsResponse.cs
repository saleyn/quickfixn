// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class RegistrationInstructionsResponse : Message
    {
            public const string MsgType = "p";

            public RegistrationInstructionsResponse() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("p"));
            }

            public RegistrationInstructionsResponse(
                    QuickFix.FXCM.Fields.RegistID aRegistID,
                    QuickFix.FXCM.Fields.RegistTransType aRegistTransType,
                    QuickFix.FXCM.Fields.RegistRefID aRegistRefID,
                    QuickFix.FXCM.Fields.RegistStatus aRegistStatus
                ) : this()
            {
                this.RegistID = aRegistID;
                this.RegistTransType = aRegistTransType;
                this.RegistRefID = aRegistRefID;
                this.RegistStatus = aRegistStatus;
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
            
            public QuickFix.FXCM.Fields.RegistTransType RegistTransType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistTransType val) 
            { 
                RegistTransType = val;
            }
            
            public QuickFix.FXCM.Fields.RegistTransType Get(QuickFix.FXCM.Fields.RegistTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistTransType val) 
            { 
                return IsSetRegistTransType();
            }
            
            public bool IsSetRegistTransType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistTransType);
            }
            
            public QuickFix.FXCM.Fields.RegistRefID RegistRefID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistRefID val) 
            { 
                RegistRefID = val;
            }
            
            public QuickFix.FXCM.Fields.RegistRefID Get(QuickFix.FXCM.Fields.RegistRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistRefID val) 
            { 
                return IsSetRegistRefID();
            }
            
            public bool IsSetRegistRefID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistRefID);
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
            
            public QuickFix.FXCM.Fields.RegistStatus RegistStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistStatus val) 
            { 
                RegistStatus = val;
            }
            
            public QuickFix.FXCM.Fields.RegistStatus Get(QuickFix.FXCM.Fields.RegistStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistStatus val) 
            { 
                return IsSetRegistStatus();
            }
            
            public bool IsSetRegistStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistStatus);
            }
            
            public QuickFix.FXCM.Fields.RegistRejReasonCode RegistRejReasonCode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistRejReasonCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistRejReasonCode val) 
            { 
                RegistRejReasonCode = val;
            }
            
            public QuickFix.FXCM.Fields.RegistRejReasonCode Get(QuickFix.FXCM.Fields.RegistRejReasonCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistRejReasonCode val) 
            { 
                return IsSetRegistRejReasonCode();
            }
            
            public bool IsSetRegistRejReasonCode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistRejReasonCode);
            }
            
            public QuickFix.FXCM.Fields.RegistRejReasonText RegistRejReasonText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistRejReasonText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistRejReasonText val) 
            { 
                RegistRejReasonText = val;
            }
            
            public QuickFix.FXCM.Fields.RegistRejReasonText Get(QuickFix.FXCM.Fields.RegistRejReasonText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistRejReasonText val) 
            { 
                return IsSetRegistRejReasonText();
            }
            
            public bool IsSetRegistRejReasonText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistRejReasonText);
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

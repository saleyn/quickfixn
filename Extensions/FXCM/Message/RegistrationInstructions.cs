// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class RegistrationInstructions : Message
    {
            public const string MsgType = "o";

            public RegistrationInstructions() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("o"));
            }

            public RegistrationInstructions(
                    QuickFix.FXCM.Fields.RegistID aRegistID,
                    QuickFix.FXCM.Fields.RegistTransType aRegistTransType,
                    QuickFix.FXCM.Fields.RegistRefID aRegistRefID
                ) : this()
            {
                this.RegistID = aRegistID;
                this.RegistTransType = aRegistTransType;
                this.RegistRefID = aRegistRefID;
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
            
            public QuickFix.FXCM.Fields.RegistAcctType RegistAcctType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RegistAcctType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RegistAcctType val) 
            { 
                RegistAcctType = val;
            }
            
            public QuickFix.FXCM.Fields.RegistAcctType Get(QuickFix.FXCM.Fields.RegistAcctType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RegistAcctType val) 
            { 
                return IsSetRegistAcctType();
            }
            
            public bool IsSetRegistAcctType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RegistAcctType);
            }
            
            public QuickFix.FXCM.Fields.TaxAdvantageType TaxAdvantageType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TaxAdvantageType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TaxAdvantageType val) 
            { 
                TaxAdvantageType = val;
            }
            
            public QuickFix.FXCM.Fields.TaxAdvantageType Get(QuickFix.FXCM.Fields.TaxAdvantageType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TaxAdvantageType val) 
            { 
                return IsSetTaxAdvantageType();
            }
            
            public bool IsSetTaxAdvantageType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TaxAdvantageType);
            }
            
            public QuickFix.FXCM.Fields.OwnershipType OwnershipType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OwnershipType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OwnershipType val) 
            { 
                OwnershipType = val;
            }
            
            public QuickFix.FXCM.Fields.OwnershipType Get(QuickFix.FXCM.Fields.OwnershipType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OwnershipType val) 
            { 
                return IsSetOwnershipType();
            }
            
            public bool IsSetOwnershipType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OwnershipType);
            }
            
            public QuickFix.FXCM.Fields.NoRegistDtls NoRegistDtls
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoRegistDtls();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoRegistDtls val) 
            { 
                NoRegistDtls = val;
            }
            
            public QuickFix.FXCM.Fields.NoRegistDtls Get(QuickFix.FXCM.Fields.NoRegistDtls val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoRegistDtls val) 
            { 
                return IsSetNoRegistDtls();
            }
            
            public bool IsSetNoRegistDtls() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoRegistDtls);
            }
            
            public QuickFix.FXCM.Fields.NoDistribInsts NoDistribInsts
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoDistribInsts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoDistribInsts val) 
            { 
                NoDistribInsts = val;
            }
            
            public QuickFix.FXCM.Fields.NoDistribInsts Get(QuickFix.FXCM.Fields.NoDistribInsts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoDistribInsts val) 
            { 
                return IsSetNoDistribInsts();
            }
            
            public bool IsSetNoDistribInsts() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoDistribInsts);
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
            public class NoRegistDtlsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.RegistDtls, QuickFix.FXCM.Fields.Tags.RegistEmail, QuickFix.FXCM.Fields.Tags.MailingDtls, QuickFix.FXCM.Fields.Tags.MailingInst, QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, QuickFix.FXCM.Fields.Tags.OwnerType, QuickFix.FXCM.Fields.Tags.DateOfBirth, QuickFix.FXCM.Fields.Tags.InvestorCountryOfResidence, 0};
            
                public NoRegistDtlsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoRegistDtls, QuickFix.FXCM.Fields.Tags.RegistDtls, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRegistDtlsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.RegistDtls RegistDtls
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.RegistDtls();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.RegistDtls val) 
                { 
                    RegistDtls = val;
                }
                
                public QuickFix.FXCM.Fields.RegistDtls Get(QuickFix.FXCM.Fields.RegistDtls val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.RegistDtls val) 
                { 
                    return IsSetRegistDtls();
                }
                
                public bool IsSetRegistDtls() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.RegistDtls);
                }
                
                public QuickFix.FXCM.Fields.RegistEmail RegistEmail
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.RegistEmail();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.RegistEmail val) 
                { 
                    RegistEmail = val;
                }
                
                public QuickFix.FXCM.Fields.RegistEmail Get(QuickFix.FXCM.Fields.RegistEmail val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.RegistEmail val) 
                { 
                    return IsSetRegistEmail();
                }
                
                public bool IsSetRegistEmail() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.RegistEmail);
                }
                
                public QuickFix.FXCM.Fields.MailingDtls MailingDtls
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MailingDtls();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MailingDtls val) 
                { 
                    MailingDtls = val;
                }
                
                public QuickFix.FXCM.Fields.MailingDtls Get(QuickFix.FXCM.Fields.MailingDtls val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MailingDtls val) 
                { 
                    return IsSetMailingDtls();
                }
                
                public bool IsSetMailingDtls() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MailingDtls);
                }
                
                public QuickFix.FXCM.Fields.MailingInst MailingInst
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MailingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MailingInst val) 
                { 
                    MailingInst = val;
                }
                
                public QuickFix.FXCM.Fields.MailingInst Get(QuickFix.FXCM.Fields.MailingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MailingInst val) 
                { 
                    return IsSetMailingInst();
                }
                
                public bool IsSetMailingInst() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MailingInst);
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
                
                public QuickFix.FXCM.Fields.OwnerType OwnerType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OwnerType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OwnerType val) 
                { 
                    OwnerType = val;
                }
                
                public QuickFix.FXCM.Fields.OwnerType Get(QuickFix.FXCM.Fields.OwnerType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OwnerType val) 
                { 
                    return IsSetOwnerType();
                }
                
                public bool IsSetOwnerType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OwnerType);
                }
                
                public QuickFix.FXCM.Fields.DateOfBirth DateOfBirth
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.DateOfBirth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.DateOfBirth val) 
                { 
                    DateOfBirth = val;
                }
                
                public QuickFix.FXCM.Fields.DateOfBirth Get(QuickFix.FXCM.Fields.DateOfBirth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.DateOfBirth val) 
                { 
                    return IsSetDateOfBirth();
                }
                
                public bool IsSetDateOfBirth() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.DateOfBirth);
                }
                
                public QuickFix.FXCM.Fields.InvestorCountryOfResidence InvestorCountryOfResidence
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.InvestorCountryOfResidence();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.InvestorCountryOfResidence val) 
                { 
                    InvestorCountryOfResidence = val;
                }
                
                public QuickFix.FXCM.Fields.InvestorCountryOfResidence Get(QuickFix.FXCM.Fields.InvestorCountryOfResidence val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.InvestorCountryOfResidence val) 
                { 
                    return IsSetInvestorCountryOfResidence();
                }
                
                public bool IsSetInvestorCountryOfResidence() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.InvestorCountryOfResidence);
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
            public class NoDistribInstsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.DistribPaymentMethod, QuickFix.FXCM.Fields.Tags.DistribPercentage, QuickFix.FXCM.Fields.Tags.CashDistribCurr, QuickFix.FXCM.Fields.Tags.CashDistribAgentName, QuickFix.FXCM.Fields.Tags.CashDistribAgentCode, QuickFix.FXCM.Fields.Tags.CashDistribAgentAcctNumber, QuickFix.FXCM.Fields.Tags.CashDistribPayRef, QuickFix.FXCM.Fields.Tags.CashDistribAgentAcctName, 0};
            
                public NoDistribInstsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoDistribInsts, QuickFix.FXCM.Fields.Tags.DistribPaymentMethod, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDistribInstsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.DistribPaymentMethod DistribPaymentMethod
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.DistribPaymentMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.DistribPaymentMethod val) 
                { 
                    DistribPaymentMethod = val;
                }
                
                public QuickFix.FXCM.Fields.DistribPaymentMethod Get(QuickFix.FXCM.Fields.DistribPaymentMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.DistribPaymentMethod val) 
                { 
                    return IsSetDistribPaymentMethod();
                }
                
                public bool IsSetDistribPaymentMethod() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.DistribPaymentMethod);
                }
                
                public QuickFix.FXCM.Fields.DistribPercentage DistribPercentage
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.DistribPercentage();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.DistribPercentage val) 
                { 
                    DistribPercentage = val;
                }
                
                public QuickFix.FXCM.Fields.DistribPercentage Get(QuickFix.FXCM.Fields.DistribPercentage val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.DistribPercentage val) 
                { 
                    return IsSetDistribPercentage();
                }
                
                public bool IsSetDistribPercentage() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.DistribPercentage);
                }
                
                public QuickFix.FXCM.Fields.CashDistribCurr CashDistribCurr
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CashDistribCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CashDistribCurr val) 
                { 
                    CashDistribCurr = val;
                }
                
                public QuickFix.FXCM.Fields.CashDistribCurr Get(QuickFix.FXCM.Fields.CashDistribCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CashDistribCurr val) 
                { 
                    return IsSetCashDistribCurr();
                }
                
                public bool IsSetCashDistribCurr() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CashDistribCurr);
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentName CashDistribAgentName
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CashDistribAgentName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CashDistribAgentName val) 
                { 
                    CashDistribAgentName = val;
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentName Get(QuickFix.FXCM.Fields.CashDistribAgentName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CashDistribAgentName val) 
                { 
                    return IsSetCashDistribAgentName();
                }
                
                public bool IsSetCashDistribAgentName() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CashDistribAgentName);
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentCode CashDistribAgentCode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CashDistribAgentCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CashDistribAgentCode val) 
                { 
                    CashDistribAgentCode = val;
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentCode Get(QuickFix.FXCM.Fields.CashDistribAgentCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CashDistribAgentCode val) 
                { 
                    return IsSetCashDistribAgentCode();
                }
                
                public bool IsSetCashDistribAgentCode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CashDistribAgentCode);
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentAcctNumber CashDistribAgentAcctNumber
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CashDistribAgentAcctNumber();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CashDistribAgentAcctNumber val) 
                { 
                    CashDistribAgentAcctNumber = val;
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentAcctNumber Get(QuickFix.FXCM.Fields.CashDistribAgentAcctNumber val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CashDistribAgentAcctNumber val) 
                { 
                    return IsSetCashDistribAgentAcctNumber();
                }
                
                public bool IsSetCashDistribAgentAcctNumber() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CashDistribAgentAcctNumber);
                }
                
                public QuickFix.FXCM.Fields.CashDistribPayRef CashDistribPayRef
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CashDistribPayRef();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CashDistribPayRef val) 
                { 
                    CashDistribPayRef = val;
                }
                
                public QuickFix.FXCM.Fields.CashDistribPayRef Get(QuickFix.FXCM.Fields.CashDistribPayRef val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CashDistribPayRef val) 
                { 
                    return IsSetCashDistribPayRef();
                }
                
                public bool IsSetCashDistribPayRef() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CashDistribPayRef);
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentAcctName CashDistribAgentAcctName
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CashDistribAgentAcctName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CashDistribAgentAcctName val) 
                { 
                    CashDistribAgentAcctName = val;
                }
                
                public QuickFix.FXCM.Fields.CashDistribAgentAcctName Get(QuickFix.FXCM.Fields.CashDistribAgentAcctName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CashDistribAgentAcctName val) 
                { 
                    return IsSetCashDistribAgentAcctName();
                }
                
                public bool IsSetCashDistribAgentAcctName() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CashDistribAgentAcctName);
                }
                
            
            }
    }
}

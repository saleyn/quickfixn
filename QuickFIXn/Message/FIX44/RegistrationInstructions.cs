// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class RegistrationInstructions : Message
    {
            public const string MsgType = "o";

            public RegistrationInstructions() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("o"));
            }

            public RegistrationInstructions(
                    QuickFix.Fields.RegistID aRegistID,
                    QuickFix.Fields.RegistTransType aRegistTransType,
                    QuickFix.Fields.RegistRefID aRegistRefID
                ) : this()
            {
                this.RegistID = aRegistID;
                this.RegistTransType = aRegistTransType;
                this.RegistRefID = aRegistRefID;
            }

            public QuickFix.Fields.RegistID RegistID
            { 
                get 
                {
                    var val = new QuickFix.Fields.RegistID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistID val) 
            { 
                RegistID = val;
            }
            
            public QuickFix.Fields.RegistID Get(QuickFix.Fields.RegistID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistID val) 
            { 
                return IsSetRegistID();
            }
            
            public bool IsSetRegistID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RegistID);
            }
            
            public QuickFix.Fields.RegistTransType RegistTransType
            { 
                get 
                {
                    var val = new QuickFix.Fields.RegistTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistTransType val) 
            { 
                RegistTransType = val;
            }
            
            public QuickFix.Fields.RegistTransType Get(QuickFix.Fields.RegistTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistTransType val) 
            { 
                return IsSetRegistTransType();
            }
            
            public bool IsSetRegistTransType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RegistTransType);
            }
            
            public QuickFix.Fields.RegistRefID RegistRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.RegistRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistRefID val) 
            { 
                RegistRefID = val;
            }
            
            public QuickFix.Fields.RegistRefID Get(QuickFix.Fields.RegistRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistRefID val) 
            { 
                return IsSetRegistRefID();
            }
            
            public bool IsSetRegistRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RegistRefID);
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
            
            public QuickFix.Fields.Account Account
            { 
                get 
                {
                    var val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Account val) 
            { 
                Account = val;
            }
            
            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Account);
            }
            
            public QuickFix.Fields.AcctIDSource AcctIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.AcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AcctIDSource val) 
            { 
                AcctIDSource = val;
            }
            
            public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AcctIDSource val) 
            { 
                return IsSetAcctIDSource();
            }
            
            public bool IsSetAcctIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AcctIDSource);
            }
            
            public QuickFix.Fields.RegistAcctType RegistAcctType
            { 
                get 
                {
                    var val = new QuickFix.Fields.RegistAcctType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistAcctType val) 
            { 
                RegistAcctType = val;
            }
            
            public QuickFix.Fields.RegistAcctType Get(QuickFix.Fields.RegistAcctType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistAcctType val) 
            { 
                return IsSetRegistAcctType();
            }
            
            public bool IsSetRegistAcctType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RegistAcctType);
            }
            
            public QuickFix.Fields.TaxAdvantageType TaxAdvantageType
            { 
                get 
                {
                    var val = new QuickFix.Fields.TaxAdvantageType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TaxAdvantageType val) 
            { 
                TaxAdvantageType = val;
            }
            
            public QuickFix.Fields.TaxAdvantageType Get(QuickFix.Fields.TaxAdvantageType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TaxAdvantageType val) 
            { 
                return IsSetTaxAdvantageType();
            }
            
            public bool IsSetTaxAdvantageType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TaxAdvantageType);
            }
            
            public QuickFix.Fields.OwnershipType OwnershipType
            { 
                get 
                {
                    var val = new QuickFix.Fields.OwnershipType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OwnershipType val) 
            { 
                OwnershipType = val;
            }
            
            public QuickFix.Fields.OwnershipType Get(QuickFix.Fields.OwnershipType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OwnershipType val) 
            { 
                return IsSetOwnershipType();
            }
            
            public bool IsSetOwnershipType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OwnershipType);
            }
            
            public QuickFix.Fields.NoRegistDtls NoRegistDtls
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoRegistDtls();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRegistDtls val) 
            { 
                NoRegistDtls = val;
            }
            
            public QuickFix.Fields.NoRegistDtls Get(QuickFix.Fields.NoRegistDtls val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRegistDtls val) 
            { 
                return IsSetNoRegistDtls();
            }
            
            public bool IsSetNoRegistDtls() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoRegistDtls);
            }
            
            public QuickFix.Fields.NoDistribInsts NoDistribInsts
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoDistribInsts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDistribInsts val) 
            { 
                NoDistribInsts = val;
            }
            
            public QuickFix.Fields.NoDistribInsts Get(QuickFix.Fields.NoDistribInsts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDistribInsts val) 
            { 
                return IsSetNoDistribInsts();
            }
            
            public bool IsSetNoDistribInsts() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoDistribInsts);
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
            public class NoRegistDtlsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RegistDtls, QuickFix.Fields.Tags.RegistEmail, QuickFix.Fields.Tags.MailingDtls, QuickFix.Fields.Tags.MailingInst, QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.OwnerType, QuickFix.Fields.Tags.DateOfBirth, QuickFix.Fields.Tags.InvestorCountryOfResidence, 0};
            
                public NoRegistDtlsGroup() 
                  :base( QuickFix.Fields.Tags.NoRegistDtls, QuickFix.Fields.Tags.RegistDtls, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRegistDtlsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RegistDtls RegistDtls
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RegistDtls();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RegistDtls val) 
                { 
                    RegistDtls = val;
                }
                
                public QuickFix.Fields.RegistDtls Get(QuickFix.Fields.RegistDtls val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RegistDtls val) 
                { 
                    return IsSetRegistDtls();
                }
                
                public bool IsSetRegistDtls() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RegistDtls);
                }
                
                public QuickFix.Fields.RegistEmail RegistEmail
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RegistEmail();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RegistEmail val) 
                { 
                    RegistEmail = val;
                }
                
                public QuickFix.Fields.RegistEmail Get(QuickFix.Fields.RegistEmail val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RegistEmail val) 
                { 
                    return IsSetRegistEmail();
                }
                
                public bool IsSetRegistEmail() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RegistEmail);
                }
                
                public QuickFix.Fields.MailingDtls MailingDtls
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MailingDtls();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MailingDtls val) 
                { 
                    MailingDtls = val;
                }
                
                public QuickFix.Fields.MailingDtls Get(QuickFix.Fields.MailingDtls val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MailingDtls val) 
                { 
                    return IsSetMailingDtls();
                }
                
                public bool IsSetMailingDtls() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MailingDtls);
                }
                
                public QuickFix.Fields.MailingInst MailingInst
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MailingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MailingInst val) 
                { 
                    MailingInst = val;
                }
                
                public QuickFix.Fields.MailingInst Get(QuickFix.Fields.MailingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MailingInst val) 
                { 
                    return IsSetMailingInst();
                }
                
                public bool IsSetMailingInst() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MailingInst);
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
                
                public QuickFix.Fields.OwnerType OwnerType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.OwnerType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OwnerType val) 
                { 
                    OwnerType = val;
                }
                
                public QuickFix.Fields.OwnerType Get(QuickFix.Fields.OwnerType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OwnerType val) 
                { 
                    return IsSetOwnerType();
                }
                
                public bool IsSetOwnerType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.OwnerType);
                }
                
                public QuickFix.Fields.DateOfBirth DateOfBirth
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DateOfBirth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DateOfBirth val) 
                { 
                    DateOfBirth = val;
                }
                
                public QuickFix.Fields.DateOfBirth Get(QuickFix.Fields.DateOfBirth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DateOfBirth val) 
                { 
                    return IsSetDateOfBirth();
                }
                
                public bool IsSetDateOfBirth() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DateOfBirth);
                }
                
                public QuickFix.Fields.InvestorCountryOfResidence InvestorCountryOfResidence
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.InvestorCountryOfResidence();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InvestorCountryOfResidence val) 
                { 
                    InvestorCountryOfResidence = val;
                }
                
                public QuickFix.Fields.InvestorCountryOfResidence Get(QuickFix.Fields.InvestorCountryOfResidence val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InvestorCountryOfResidence val) 
                { 
                    return IsSetInvestorCountryOfResidence();
                }
                
                public bool IsSetInvestorCountryOfResidence() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.InvestorCountryOfResidence);
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
            public class NoDistribInstsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.DistribPaymentMethod, QuickFix.Fields.Tags.DistribPercentage, QuickFix.Fields.Tags.CashDistribCurr, QuickFix.Fields.Tags.CashDistribAgentName, QuickFix.Fields.Tags.CashDistribAgentCode, QuickFix.Fields.Tags.CashDistribAgentAcctNumber, QuickFix.Fields.Tags.CashDistribPayRef, QuickFix.Fields.Tags.CashDistribAgentAcctName, 0};
            
                public NoDistribInstsGroup() 
                  :base( QuickFix.Fields.Tags.NoDistribInsts, QuickFix.Fields.Tags.DistribPaymentMethod, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDistribInstsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.DistribPaymentMethod DistribPaymentMethod
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DistribPaymentMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DistribPaymentMethod val) 
                { 
                    DistribPaymentMethod = val;
                }
                
                public QuickFix.Fields.DistribPaymentMethod Get(QuickFix.Fields.DistribPaymentMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DistribPaymentMethod val) 
                { 
                    return IsSetDistribPaymentMethod();
                }
                
                public bool IsSetDistribPaymentMethod() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DistribPaymentMethod);
                }
                
                public QuickFix.Fields.DistribPercentage DistribPercentage
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DistribPercentage();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DistribPercentage val) 
                { 
                    DistribPercentage = val;
                }
                
                public QuickFix.Fields.DistribPercentage Get(QuickFix.Fields.DistribPercentage val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DistribPercentage val) 
                { 
                    return IsSetDistribPercentage();
                }
                
                public bool IsSetDistribPercentage() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DistribPercentage);
                }
                
                public QuickFix.Fields.CashDistribCurr CashDistribCurr
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashDistribCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashDistribCurr val) 
                { 
                    CashDistribCurr = val;
                }
                
                public QuickFix.Fields.CashDistribCurr Get(QuickFix.Fields.CashDistribCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashDistribCurr val) 
                { 
                    return IsSetCashDistribCurr();
                }
                
                public bool IsSetCashDistribCurr() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashDistribCurr);
                }
                
                public QuickFix.Fields.CashDistribAgentName CashDistribAgentName
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashDistribAgentName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashDistribAgentName val) 
                { 
                    CashDistribAgentName = val;
                }
                
                public QuickFix.Fields.CashDistribAgentName Get(QuickFix.Fields.CashDistribAgentName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashDistribAgentName val) 
                { 
                    return IsSetCashDistribAgentName();
                }
                
                public bool IsSetCashDistribAgentName() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashDistribAgentName);
                }
                
                public QuickFix.Fields.CashDistribAgentCode CashDistribAgentCode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashDistribAgentCode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashDistribAgentCode val) 
                { 
                    CashDistribAgentCode = val;
                }
                
                public QuickFix.Fields.CashDistribAgentCode Get(QuickFix.Fields.CashDistribAgentCode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashDistribAgentCode val) 
                { 
                    return IsSetCashDistribAgentCode();
                }
                
                public bool IsSetCashDistribAgentCode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashDistribAgentCode);
                }
                
                public QuickFix.Fields.CashDistribAgentAcctNumber CashDistribAgentAcctNumber
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashDistribAgentAcctNumber();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashDistribAgentAcctNumber val) 
                { 
                    CashDistribAgentAcctNumber = val;
                }
                
                public QuickFix.Fields.CashDistribAgentAcctNumber Get(QuickFix.Fields.CashDistribAgentAcctNumber val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashDistribAgentAcctNumber val) 
                { 
                    return IsSetCashDistribAgentAcctNumber();
                }
                
                public bool IsSetCashDistribAgentAcctNumber() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashDistribAgentAcctNumber);
                }
                
                public QuickFix.Fields.CashDistribPayRef CashDistribPayRef
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashDistribPayRef();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashDistribPayRef val) 
                { 
                    CashDistribPayRef = val;
                }
                
                public QuickFix.Fields.CashDistribPayRef Get(QuickFix.Fields.CashDistribPayRef val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashDistribPayRef val) 
                { 
                    return IsSetCashDistribPayRef();
                }
                
                public bool IsSetCashDistribPayRef() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashDistribPayRef);
                }
                
                public QuickFix.Fields.CashDistribAgentAcctName CashDistribAgentAcctName
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.CashDistribAgentAcctName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashDistribAgentAcctName val) 
                { 
                    CashDistribAgentAcctName = val;
                }
                
                public QuickFix.Fields.CashDistribAgentAcctName Get(QuickFix.Fields.CashDistribAgentAcctName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashDistribAgentAcctName val) 
                { 
                    return IsSetCashDistribAgentAcctName();
                }
                
                public bool IsSetCashDistribAgentAcctName() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.CashDistribAgentAcctName);
                }
                
            
            }
    }
}

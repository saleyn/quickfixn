// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class PartyDetailsListReport : Message
    {
            public const string MsgType = "CG";

            public PartyDetailsListReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CG"));
            }

            public PartyDetailsListReport(
                    QuickFix.Fields.PartyDetailsListReportID aPartyDetailsListReportID
                ) : this()
            {
                this.PartyDetailsListReportID = aPartyDetailsListReportID;
            }

            public QuickFix.Fields.ApplID ApplID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                ApplID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplID);
            }
            
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                ApplSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplSeqNum);
            }
            
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                ApplLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplLastSeqNum);
            }
            
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                ApplResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplResendFlag);
            }
            
            public QuickFix.Fields.PartyDetailsListReportID PartyDetailsListReportID
            { 
                get 
                {
                    var val = new QuickFix.Fields.PartyDetailsListReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                PartyDetailsListReportID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListReportID Get(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                return IsSetPartyDetailsListReportID();
            }
            
            public bool IsSetPartyDetailsListReportID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PartyDetailsListReportID);
            }
            
            public QuickFix.Fields.PartyDetailsListRequestID PartyDetailsListRequestID
            { 
                get 
                {
                    var val = new QuickFix.Fields.PartyDetailsListRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                PartyDetailsListRequestID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListRequestID Get(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                return IsSetPartyDetailsListRequestID();
            }
            
            public bool IsSetPartyDetailsListRequestID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PartyDetailsListRequestID);
            }
            
            public QuickFix.Fields.PartyDetailsRequestResult PartyDetailsRequestResult
            { 
                get 
                {
                    var val = new QuickFix.Fields.PartyDetailsRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                PartyDetailsRequestResult = val;
            }
            
            public QuickFix.Fields.PartyDetailsRequestResult Get(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                return IsSetPartyDetailsRequestResult();
            }
            
            public bool IsSetPartyDetailsRequestResult() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PartyDetailsRequestResult);
            }
            
            public QuickFix.Fields.TotNoPartyList TotNoPartyList
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotNoPartyList();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoPartyList val) 
            { 
                TotNoPartyList = val;
            }
            
            public QuickFix.Fields.TotNoPartyList Get(QuickFix.Fields.TotNoPartyList val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoPartyList val) 
            { 
                return IsSetTotNoPartyList();
            }
            
            public bool IsSetTotNoPartyList() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotNoPartyList);
            }
            
            public QuickFix.Fields.LastFragment LastFragment
            { 
                get 
                {
                    var val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                LastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LastFragment);
            }
            
            public QuickFix.Fields.NoPartyList NoPartyList
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoPartyList();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyList val) 
            { 
                NoPartyList = val;
            }
            
            public QuickFix.Fields.NoPartyList Get(QuickFix.Fields.NoPartyList val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyList val) 
            { 
                return IsSetNoPartyList();
            }
            
            public bool IsSetNoPartyList() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoPartyList);
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
            
            public class NoPartyListGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyID, QuickFix.Fields.Tags.PartyIDSource, QuickFix.Fields.Tags.PartyRole, QuickFix.Fields.Tags.NoPartySubIDs, QuickFix.Fields.Tags.NoPartyAltIDs, QuickFix.Fields.Tags.NoContextPartyIDs, QuickFix.Fields.Tags.NoRiskLimits, QuickFix.Fields.Tags.NoRelatedPartyIDs, 0};
            
                public NoPartyListGroup() 
                  :base( QuickFix.Fields.Tags.NoPartyList, QuickFix.Fields.Tags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyListGroup();
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
                
                public QuickFix.Fields.NoPartyAltIDs NoPartyAltIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoPartyAltIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    NoPartyAltIDs = val;
                }
                
                public QuickFix.Fields.NoPartyAltIDs Get(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    return IsSetNoPartyAltIDs();
                }
                
                public bool IsSetNoPartyAltIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoPartyAltIDs);
                }
                
                public QuickFix.Fields.NoContextPartyIDs NoContextPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoContextPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    NoContextPartyIDs = val;
                }
                
                public QuickFix.Fields.NoContextPartyIDs Get(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    return IsSetNoContextPartyIDs();
                }
                
                public bool IsSetNoContextPartyIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoContextPartyIDs);
                }
                
                public QuickFix.Fields.NoRiskLimits NoRiskLimits
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoRiskLimits();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoRiskLimits val) 
                { 
                    NoRiskLimits = val;
                }
                
                public QuickFix.Fields.NoRiskLimits Get(QuickFix.Fields.NoRiskLimits val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoRiskLimits val) 
                { 
                    return IsSetNoRiskLimits();
                }
                
                public bool IsSetNoRiskLimits() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoRiskLimits);
                }
                
                public QuickFix.Fields.NoRelatedPartyIDs NoRelatedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoRelatedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    NoRelatedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoRelatedPartyIDs Get(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    return IsSetNoRelatedPartyIDs();
                }
                
                public bool IsSetNoRelatedPartyIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoRelatedPartyIDs);
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
                public class NoPartyAltIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyAltID, QuickFix.Fields.Tags.PartyAltIDSource, QuickFix.Fields.Tags.NoPartyAltSubIDs, 0};
                
                    public NoPartyAltIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoPartyAltIDs, QuickFix.Fields.Tags.PartyAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartyAltIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.PartyAltID PartyAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.PartyAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyAltID val) 
                    { 
                        PartyAltID = val;
                    }
                    
                    public QuickFix.Fields.PartyAltID Get(QuickFix.Fields.PartyAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyAltID val) 
                    { 
                        return IsSetPartyAltID();
                    }
                    
                    public bool IsSetPartyAltID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.PartyAltID);
                    }
                    
                    public QuickFix.Fields.PartyAltIDSource PartyAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.PartyAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        PartyAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyAltIDSource Get(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        return IsSetPartyAltIDSource();
                    }
                    
                    public bool IsSetPartyAltIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.PartyAltIDSource);
                    }
                    
                    public QuickFix.Fields.NoPartyAltSubIDs NoPartyAltSubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoPartyAltSubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        NoPartyAltSubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartyAltSubIDs Get(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        return IsSetNoPartyAltSubIDs();
                    }
                    
                    public bool IsSetNoPartyAltSubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoPartyAltSubIDs);
                    }
                    
                                    public class NoPartyAltSubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyAltSubID, QuickFix.Fields.Tags.PartyAltSubIDType, 0};
                    
                        public NoPartyAltSubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoPartyAltSubIDs, QuickFix.Fields.Tags.PartyAltSubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoPartyAltSubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.PartyAltSubID PartyAltSubID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.PartyAltSubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            PartyAltSubID = val;
                        }
                        
                        public QuickFix.Fields.PartyAltSubID Get(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            return IsSetPartyAltSubID();
                        }
                        
                        public bool IsSetPartyAltSubID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.PartyAltSubID);
                        }
                        
                        public QuickFix.Fields.PartyAltSubIDType PartyAltSubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.PartyAltSubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            PartyAltSubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartyAltSubIDType Get(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            return IsSetPartyAltSubIDType();
                        }
                        
                        public bool IsSetPartyAltSubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.PartyAltSubIDType);
                        }
                        
                    
                    }
                }
                public class NoContextPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.ContextPartyID, QuickFix.Fields.Tags.ContextPartyIDSource, QuickFix.Fields.Tags.ContextPartyRole, QuickFix.Fields.Tags.NoContextPartySubIDs, 0};
                
                    public NoContextPartyIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoContextPartyIDs, QuickFix.Fields.Tags.ContextPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoContextPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.ContextPartyID ContextPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ContextPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContextPartyID val) 
                    { 
                        ContextPartyID = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyID Get(QuickFix.Fields.ContextPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContextPartyID val) 
                    { 
                        return IsSetContextPartyID();
                    }
                    
                    public bool IsSetContextPartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ContextPartyID);
                    }
                    
                    public QuickFix.Fields.ContextPartyIDSource ContextPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ContextPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        ContextPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyIDSource Get(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        return IsSetContextPartyIDSource();
                    }
                    
                    public bool IsSetContextPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ContextPartyIDSource);
                    }
                    
                    public QuickFix.Fields.ContextPartyRole ContextPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ContextPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        ContextPartyRole = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyRole Get(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        return IsSetContextPartyRole();
                    }
                    
                    public bool IsSetContextPartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ContextPartyRole);
                    }
                    
                    public QuickFix.Fields.NoContextPartySubIDs NoContextPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoContextPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        NoContextPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoContextPartySubIDs Get(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        return IsSetNoContextPartySubIDs();
                    }
                    
                    public bool IsSetNoContextPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoContextPartySubIDs);
                    }
                    
                                    public class NoContextPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.ContextPartySubID, QuickFix.Fields.Tags.ContextPartySubIDType, 0};
                    
                        public NoContextPartySubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoContextPartySubIDs, QuickFix.Fields.Tags.ContextPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoContextPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.ContextPartySubID ContextPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.ContextPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            ContextPartySubID = val;
                        }
                        
                        public QuickFix.Fields.ContextPartySubID Get(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            return IsSetContextPartySubID();
                        }
                        
                        public bool IsSetContextPartySubID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.ContextPartySubID);
                        }
                        
                        public QuickFix.Fields.ContextPartySubIDType ContextPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.ContextPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            ContextPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.ContextPartySubIDType Get(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            return IsSetContextPartySubIDType();
                        }
                        
                        public bool IsSetContextPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.ContextPartySubIDType);
                        }
                        
                    
                    }
                }
                public class NoRiskLimitsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.RiskLimitType, QuickFix.Fields.Tags.RiskLimitAmount, QuickFix.Fields.Tags.RiskLimitCurrency, QuickFix.Fields.Tags.RiskLimitPlatform, QuickFix.Fields.Tags.NoRiskInstruments, QuickFix.Fields.Tags.NoRiskWarningLevels, 0};
                
                    public NoRiskLimitsGroup() 
                      :base( QuickFix.Fields.Tags.NoRiskLimits, QuickFix.Fields.Tags.RiskLimitType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoRiskLimitsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.RiskLimitType RiskLimitType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RiskLimitType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitType val) 
                    { 
                        RiskLimitType = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitType Get(QuickFix.Fields.RiskLimitType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitType val) 
                    { 
                        return IsSetRiskLimitType();
                    }
                    
                    public bool IsSetRiskLimitType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RiskLimitType);
                    }
                    
                    public QuickFix.Fields.RiskLimitAmount RiskLimitAmount
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RiskLimitAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        RiskLimitAmount = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitAmount Get(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        return IsSetRiskLimitAmount();
                    }
                    
                    public bool IsSetRiskLimitAmount() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RiskLimitAmount);
                    }
                    
                    public QuickFix.Fields.RiskLimitCurrency RiskLimitCurrency
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RiskLimitCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        RiskLimitCurrency = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitCurrency Get(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        return IsSetRiskLimitCurrency();
                    }
                    
                    public bool IsSetRiskLimitCurrency() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RiskLimitCurrency);
                    }
                    
                    public QuickFix.Fields.RiskLimitPlatform RiskLimitPlatform
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RiskLimitPlatform();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        RiskLimitPlatform = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitPlatform Get(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        return IsSetRiskLimitPlatform();
                    }
                    
                    public bool IsSetRiskLimitPlatform() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RiskLimitPlatform);
                    }
                    
                    public QuickFix.Fields.NoRiskInstruments NoRiskInstruments
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoRiskInstruments();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        NoRiskInstruments = val;
                    }
                    
                    public QuickFix.Fields.NoRiskInstruments Get(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        return IsSetNoRiskInstruments();
                    }
                    
                    public bool IsSetNoRiskInstruments() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoRiskInstruments);
                    }
                    
                    public QuickFix.Fields.NoRiskWarningLevels NoRiskWarningLevels
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoRiskWarningLevels();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        NoRiskWarningLevels = val;
                    }
                    
                    public QuickFix.Fields.NoRiskWarningLevels Get(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        return IsSetNoRiskWarningLevels();
                    }
                    
                    public bool IsSetNoRiskWarningLevels() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoRiskWarningLevels);
                    }
                    
                                    public class NoRiskInstrumentsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.RiskInstrumentOperator, QuickFix.Fields.Tags.RiskSymbol, QuickFix.Fields.Tags.RiskSymbolSfx, QuickFix.Fields.Tags.RiskSecurityID, QuickFix.Fields.Tags.RiskSecurityIDSource, QuickFix.Fields.Tags.NoRiskSecurityAltID, QuickFix.Fields.Tags.RiskProduct, QuickFix.Fields.Tags.RiskProductComplex, QuickFix.Fields.Tags.RiskSecurityGroup, QuickFix.Fields.Tags.RiskCFICode, QuickFix.Fields.Tags.RiskSecurityType, QuickFix.Fields.Tags.RiskSecuritySubType, QuickFix.Fields.Tags.RiskMaturityMonthYear, QuickFix.Fields.Tags.RiskMaturityTime, QuickFix.Fields.Tags.RiskRestructuringType, QuickFix.Fields.Tags.RiskSeniority, QuickFix.Fields.Tags.RiskPutOrCall, QuickFix.Fields.Tags.RiskFlexibleIndicator, QuickFix.Fields.Tags.RiskCouponRate, QuickFix.Fields.Tags.RiskSecurityExchange, QuickFix.Fields.Tags.RiskSecurityDesc, QuickFix.Fields.Tags.RiskEncodedSecurityDescLen, QuickFix.Fields.Tags.RiskEncodedSecurityDesc, QuickFix.Fields.Tags.RiskInstrumentSettlType, QuickFix.Fields.Tags.RiskInstrumentMultiplier, 0};
                    
                        public NoRiskInstrumentsGroup() 
                          :base( QuickFix.Fields.Tags.NoRiskInstruments, QuickFix.Fields.Tags.RiskInstrumentOperator, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoRiskInstrumentsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.RiskInstrumentOperator RiskInstrumentOperator
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskInstrumentOperator();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            RiskInstrumentOperator = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentOperator Get(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            return IsSetRiskInstrumentOperator();
                        }
                        
                        public bool IsSetRiskInstrumentOperator() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskInstrumentOperator);
                        }
                        
                        public QuickFix.Fields.RiskSymbol RiskSymbol
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSymbol();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSymbol val) 
                        { 
                            RiskSymbol = val;
                        }
                        
                        public QuickFix.Fields.RiskSymbol Get(QuickFix.Fields.RiskSymbol val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSymbol val) 
                        { 
                            return IsSetRiskSymbol();
                        }
                        
                        public bool IsSetRiskSymbol() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSymbol);
                        }
                        
                        public QuickFix.Fields.RiskSymbolSfx RiskSymbolSfx
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSymbolSfx();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            RiskSymbolSfx = val;
                        }
                        
                        public QuickFix.Fields.RiskSymbolSfx Get(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            return IsSetRiskSymbolSfx();
                        }
                        
                        public bool IsSetRiskSymbolSfx() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSymbolSfx);
                        }
                        
                        public QuickFix.Fields.RiskSecurityID RiskSecurityID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecurityID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            RiskSecurityID = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityID Get(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            return IsSetRiskSecurityID();
                        }
                        
                        public bool IsSetRiskSecurityID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecurityID);
                        }
                        
                        public QuickFix.Fields.RiskSecurityIDSource RiskSecurityIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecurityIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            RiskSecurityIDSource = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityIDSource Get(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            return IsSetRiskSecurityIDSource();
                        }
                        
                        public bool IsSetRiskSecurityIDSource() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecurityIDSource);
                        }
                        
                        public QuickFix.Fields.NoRiskSecurityAltID NoRiskSecurityAltID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoRiskSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            NoRiskSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.NoRiskSecurityAltID Get(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            return IsSetNoRiskSecurityAltID();
                        }
                        
                        public bool IsSetNoRiskSecurityAltID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoRiskSecurityAltID);
                        }
                        
                        public QuickFix.Fields.RiskProduct RiskProduct
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskProduct();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskProduct val) 
                        { 
                            RiskProduct = val;
                        }
                        
                        public QuickFix.Fields.RiskProduct Get(QuickFix.Fields.RiskProduct val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskProduct val) 
                        { 
                            return IsSetRiskProduct();
                        }
                        
                        public bool IsSetRiskProduct() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskProduct);
                        }
                        
                        public QuickFix.Fields.RiskProductComplex RiskProductComplex
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskProductComplex();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            RiskProductComplex = val;
                        }
                        
                        public QuickFix.Fields.RiskProductComplex Get(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            return IsSetRiskProductComplex();
                        }
                        
                        public bool IsSetRiskProductComplex() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskProductComplex);
                        }
                        
                        public QuickFix.Fields.RiskSecurityGroup RiskSecurityGroup
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecurityGroup();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            RiskSecurityGroup = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityGroup Get(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            return IsSetRiskSecurityGroup();
                        }
                        
                        public bool IsSetRiskSecurityGroup() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecurityGroup);
                        }
                        
                        public QuickFix.Fields.RiskCFICode RiskCFICode
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskCFICode();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskCFICode val) 
                        { 
                            RiskCFICode = val;
                        }
                        
                        public QuickFix.Fields.RiskCFICode Get(QuickFix.Fields.RiskCFICode val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskCFICode val) 
                        { 
                            return IsSetRiskCFICode();
                        }
                        
                        public bool IsSetRiskCFICode() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskCFICode);
                        }
                        
                        public QuickFix.Fields.RiskSecurityType RiskSecurityType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecurityType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            RiskSecurityType = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityType Get(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            return IsSetRiskSecurityType();
                        }
                        
                        public bool IsSetRiskSecurityType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecurityType);
                        }
                        
                        public QuickFix.Fields.RiskSecuritySubType RiskSecuritySubType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecuritySubType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            RiskSecuritySubType = val;
                        }
                        
                        public QuickFix.Fields.RiskSecuritySubType Get(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            return IsSetRiskSecuritySubType();
                        }
                        
                        public bool IsSetRiskSecuritySubType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecuritySubType);
                        }
                        
                        public QuickFix.Fields.RiskMaturityMonthYear RiskMaturityMonthYear
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            RiskMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.RiskMaturityMonthYear Get(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            return IsSetRiskMaturityMonthYear();
                        }
                        
                        public bool IsSetRiskMaturityMonthYear() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskMaturityMonthYear);
                        }
                        
                        public QuickFix.Fields.RiskMaturityTime RiskMaturityTime
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskMaturityTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            RiskMaturityTime = val;
                        }
                        
                        public QuickFix.Fields.RiskMaturityTime Get(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            return IsSetRiskMaturityTime();
                        }
                        
                        public bool IsSetRiskMaturityTime() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskMaturityTime);
                        }
                        
                        public QuickFix.Fields.RiskRestructuringType RiskRestructuringType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskRestructuringType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            RiskRestructuringType = val;
                        }
                        
                        public QuickFix.Fields.RiskRestructuringType Get(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            return IsSetRiskRestructuringType();
                        }
                        
                        public bool IsSetRiskRestructuringType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskRestructuringType);
                        }
                        
                        public QuickFix.Fields.RiskSeniority RiskSeniority
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSeniority();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSeniority val) 
                        { 
                            RiskSeniority = val;
                        }
                        
                        public QuickFix.Fields.RiskSeniority Get(QuickFix.Fields.RiskSeniority val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSeniority val) 
                        { 
                            return IsSetRiskSeniority();
                        }
                        
                        public bool IsSetRiskSeniority() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSeniority);
                        }
                        
                        public QuickFix.Fields.RiskPutOrCall RiskPutOrCall
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskPutOrCall();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            RiskPutOrCall = val;
                        }
                        
                        public QuickFix.Fields.RiskPutOrCall Get(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            return IsSetRiskPutOrCall();
                        }
                        
                        public bool IsSetRiskPutOrCall() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskPutOrCall);
                        }
                        
                        public QuickFix.Fields.RiskFlexibleIndicator RiskFlexibleIndicator
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskFlexibleIndicator();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            RiskFlexibleIndicator = val;
                        }
                        
                        public QuickFix.Fields.RiskFlexibleIndicator Get(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            return IsSetRiskFlexibleIndicator();
                        }
                        
                        public bool IsSetRiskFlexibleIndicator() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskFlexibleIndicator);
                        }
                        
                        public QuickFix.Fields.RiskCouponRate RiskCouponRate
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskCouponRate();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            RiskCouponRate = val;
                        }
                        
                        public QuickFix.Fields.RiskCouponRate Get(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            return IsSetRiskCouponRate();
                        }
                        
                        public bool IsSetRiskCouponRate() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskCouponRate);
                        }
                        
                        public QuickFix.Fields.RiskSecurityExchange RiskSecurityExchange
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecurityExchange();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            RiskSecurityExchange = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityExchange Get(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            return IsSetRiskSecurityExchange();
                        }
                        
                        public bool IsSetRiskSecurityExchange() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecurityExchange);
                        }
                        
                        public QuickFix.Fields.RiskSecurityDesc RiskSecurityDesc
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskSecurityDesc();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            RiskSecurityDesc = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityDesc Get(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            return IsSetRiskSecurityDesc();
                        }
                        
                        public bool IsSetRiskSecurityDesc() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskSecurityDesc);
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDescLen RiskEncodedSecurityDescLen
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskEncodedSecurityDescLen();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            RiskEncodedSecurityDescLen = val;
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDescLen Get(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            return IsSetRiskEncodedSecurityDescLen();
                        }
                        
                        public bool IsSetRiskEncodedSecurityDescLen() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskEncodedSecurityDescLen);
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDesc RiskEncodedSecurityDesc
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskEncodedSecurityDesc();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            RiskEncodedSecurityDesc = val;
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDesc Get(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            return IsSetRiskEncodedSecurityDesc();
                        }
                        
                        public bool IsSetRiskEncodedSecurityDesc() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskEncodedSecurityDesc);
                        }
                        
                        public QuickFix.Fields.RiskInstrumentSettlType RiskInstrumentSettlType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskInstrumentSettlType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            RiskInstrumentSettlType = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentSettlType Get(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            return IsSetRiskInstrumentSettlType();
                        }
                        
                        public bool IsSetRiskInstrumentSettlType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskInstrumentSettlType);
                        }
                        
                        public QuickFix.Fields.RiskInstrumentMultiplier RiskInstrumentMultiplier
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskInstrumentMultiplier();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            RiskInstrumentMultiplier = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentMultiplier Get(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            return IsSetRiskInstrumentMultiplier();
                        }
                        
                        public bool IsSetRiskInstrumentMultiplier() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskInstrumentMultiplier);
                        }
                        
                                            public class NoRiskSecurityAltIDGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.RiskSecurityAltID, QuickFix.Fields.Tags.RiskSecurityAltIDSource, 0};
                        
                            public NoRiskSecurityAltIDGroup() 
                              :base( QuickFix.Fields.Tags.NoRiskSecurityAltID, QuickFix.Fields.Tags.RiskSecurityAltID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoRiskSecurityAltIDGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.RiskSecurityAltID RiskSecurityAltID
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RiskSecurityAltID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                RiskSecurityAltID = val;
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltID Get(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                return IsSetRiskSecurityAltID();
                            }
                            
                            public bool IsSetRiskSecurityAltID() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RiskSecurityAltID);
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltIDSource RiskSecurityAltIDSource
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RiskSecurityAltIDSource();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                RiskSecurityAltIDSource = val;
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltIDSource Get(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                return IsSetRiskSecurityAltIDSource();
                            }
                            
                            public bool IsSetRiskSecurityAltIDSource() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RiskSecurityAltIDSource);
                            }
                            
                        
                        }
                    }
                    public class NoRiskWarningLevelsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.RiskWarningLevelPercent, QuickFix.Fields.Tags.RiskWarningLevelName, 0};
                    
                        public NoRiskWarningLevelsGroup() 
                          :base( QuickFix.Fields.Tags.NoRiskWarningLevels, QuickFix.Fields.Tags.RiskWarningLevelPercent, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoRiskWarningLevelsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.RiskWarningLevelPercent RiskWarningLevelPercent
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskWarningLevelPercent();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            RiskWarningLevelPercent = val;
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelPercent Get(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            return IsSetRiskWarningLevelPercent();
                        }
                        
                        public bool IsSetRiskWarningLevelPercent() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskWarningLevelPercent);
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelName RiskWarningLevelName
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RiskWarningLevelName();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            RiskWarningLevelName = val;
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelName Get(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            return IsSetRiskWarningLevelName();
                        }
                        
                        public bool IsSetRiskWarningLevelName() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RiskWarningLevelName);
                        }
                        
                    
                    }
                }
                public class NoRelatedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatedPartyID, QuickFix.Fields.Tags.RelatedPartyIDSource, QuickFix.Fields.Tags.RelatedPartyRole, QuickFix.Fields.Tags.NoRelatedPartySubIDs, QuickFix.Fields.Tags.NoRelatedPartyAltIDs, QuickFix.Fields.Tags.NoRelatedContextPartyIDs, QuickFix.Fields.Tags.NoRelationshipRiskLimits, QuickFix.Fields.Tags.NoPartyRelationships, 0};
                
                    public NoRelatedPartyIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoRelatedPartyIDs, QuickFix.Fields.Tags.RelatedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoRelatedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.RelatedPartyID RelatedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RelatedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        RelatedPartyID = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyID Get(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        return IsSetRelatedPartyID();
                    }
                    
                    public bool IsSetRelatedPartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RelatedPartyID);
                    }
                    
                    public QuickFix.Fields.RelatedPartyIDSource RelatedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RelatedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        RelatedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyIDSource Get(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        return IsSetRelatedPartyIDSource();
                    }
                    
                    public bool IsSetRelatedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RelatedPartyIDSource);
                    }
                    
                    public QuickFix.Fields.RelatedPartyRole RelatedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.RelatedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        RelatedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyRole Get(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        return IsSetRelatedPartyRole();
                    }
                    
                    public bool IsSetRelatedPartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.RelatedPartyRole);
                    }
                    
                    public QuickFix.Fields.NoRelatedPartySubIDs NoRelatedPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoRelatedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        NoRelatedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedPartySubIDs Get(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        return IsSetNoRelatedPartySubIDs();
                    }
                    
                    public bool IsSetNoRelatedPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoRelatedPartySubIDs);
                    }
                    
                    public QuickFix.Fields.NoRelatedPartyAltIDs NoRelatedPartyAltIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoRelatedPartyAltIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        NoRelatedPartyAltIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedPartyAltIDs Get(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        return IsSetNoRelatedPartyAltIDs();
                    }
                    
                    public bool IsSetNoRelatedPartyAltIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoRelatedPartyAltIDs);
                    }
                    
                    public QuickFix.Fields.NoRelatedContextPartyIDs NoRelatedContextPartyIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoRelatedContextPartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        NoRelatedContextPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedContextPartyIDs Get(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        return IsSetNoRelatedContextPartyIDs();
                    }
                    
                    public bool IsSetNoRelatedContextPartyIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoRelatedContextPartyIDs);
                    }
                    
                    public QuickFix.Fields.NoRelationshipRiskLimits NoRelationshipRiskLimits
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoRelationshipRiskLimits();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        NoRelationshipRiskLimits = val;
                    }
                    
                    public QuickFix.Fields.NoRelationshipRiskLimits Get(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        return IsSetNoRelationshipRiskLimits();
                    }
                    
                    public bool IsSetNoRelationshipRiskLimits() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoRelationshipRiskLimits);
                    }
                    
                    public QuickFix.Fields.NoPartyRelationships NoPartyRelationships
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoPartyRelationships();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        NoPartyRelationships = val;
                    }
                    
                    public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        return IsSetNoPartyRelationships();
                    }
                    
                    public bool IsSetNoPartyRelationships() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoPartyRelationships);
                    }
                    
                                    public class NoRelatedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatedPartySubID, QuickFix.Fields.Tags.RelatedPartySubIDType, 0};
                    
                        public NoRelatedPartySubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoRelatedPartySubIDs, QuickFix.Fields.Tags.RelatedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoRelatedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.RelatedPartySubID RelatedPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            RelatedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartySubID Get(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            return IsSetRelatedPartySubID();
                        }
                        
                        public bool IsSetRelatedPartySubID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedPartySubID);
                        }
                        
                        public QuickFix.Fields.RelatedPartySubIDType RelatedPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            RelatedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartySubIDType Get(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            return IsSetRelatedPartySubIDType();
                        }
                        
                        public bool IsSetRelatedPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedPartySubIDType);
                        }
                        
                    
                    }
                    public class NoRelatedPartyAltIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatedPartyAltID, QuickFix.Fields.Tags.RelatedPartyAltIDSource, QuickFix.Fields.Tags.NoRelatedPartyAltSubIDs, 0};
                    
                        public NoRelatedPartyAltIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoRelatedPartyAltIDs, QuickFix.Fields.Tags.RelatedPartyAltID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoRelatedPartyAltIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.RelatedPartyAltID RelatedPartyAltID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedPartyAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            RelatedPartyAltID = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltID Get(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            return IsSetRelatedPartyAltID();
                        }
                        
                        public bool IsSetRelatedPartyAltID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedPartyAltID);
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltIDSource RelatedPartyAltIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedPartyAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            RelatedPartyAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltIDSource Get(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            return IsSetRelatedPartyAltIDSource();
                        }
                        
                        public bool IsSetRelatedPartyAltIDSource() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedPartyAltIDSource);
                        }
                        
                        public QuickFix.Fields.NoRelatedPartyAltSubIDs NoRelatedPartyAltSubIDs
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoRelatedPartyAltSubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            NoRelatedPartyAltSubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoRelatedPartyAltSubIDs Get(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            return IsSetNoRelatedPartyAltSubIDs();
                        }
                        
                        public bool IsSetNoRelatedPartyAltSubIDs() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoRelatedPartyAltSubIDs);
                        }
                        
                                            public class NoRelatedPartyAltSubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatedPartyAltSubID, QuickFix.Fields.Tags.RelatedPartyAltSubIDType, 0};
                        
                            public NoRelatedPartyAltSubIDsGroup() 
                              :base( QuickFix.Fields.Tags.NoRelatedPartyAltSubIDs, QuickFix.Fields.Tags.RelatedPartyAltSubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoRelatedPartyAltSubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.RelatedPartyAltSubID RelatedPartyAltSubID
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelatedPartyAltSubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                RelatedPartyAltSubID = val;
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubID Get(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                return IsSetRelatedPartyAltSubID();
                            }
                            
                            public bool IsSetRelatedPartyAltSubID() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelatedPartyAltSubID);
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubIDType RelatedPartyAltSubIDType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelatedPartyAltSubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                RelatedPartyAltSubIDType = val;
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubIDType Get(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                return IsSetRelatedPartyAltSubIDType();
                            }
                            
                            public bool IsSetRelatedPartyAltSubIDType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelatedPartyAltSubIDType);
                            }
                            
                        
                        }
                    }
                    public class NoRelatedContextPartyIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatedContextPartyID, QuickFix.Fields.Tags.RelatedContextPartyIDSource, QuickFix.Fields.Tags.RelatedContextPartyRole, QuickFix.Fields.Tags.NoRelatedContextPartySubIDs, 0};
                    
                        public NoRelatedContextPartyIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoRelatedContextPartyIDs, QuickFix.Fields.Tags.RelatedContextPartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoRelatedContextPartyIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.RelatedContextPartyID RelatedContextPartyID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedContextPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            RelatedContextPartyID = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyID Get(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            return IsSetRelatedContextPartyID();
                        }
                        
                        public bool IsSetRelatedContextPartyID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedContextPartyID);
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyIDSource RelatedContextPartyIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedContextPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            RelatedContextPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyIDSource Get(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            return IsSetRelatedContextPartyIDSource();
                        }
                        
                        public bool IsSetRelatedContextPartyIDSource() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedContextPartyIDSource);
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyRole RelatedContextPartyRole
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelatedContextPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            RelatedContextPartyRole = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyRole Get(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            return IsSetRelatedContextPartyRole();
                        }
                        
                        public bool IsSetRelatedContextPartyRole() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelatedContextPartyRole);
                        }
                        
                        public QuickFix.Fields.NoRelatedContextPartySubIDs NoRelatedContextPartySubIDs
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoRelatedContextPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            NoRelatedContextPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoRelatedContextPartySubIDs Get(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            return IsSetNoRelatedContextPartySubIDs();
                        }
                        
                        public bool IsSetNoRelatedContextPartySubIDs() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoRelatedContextPartySubIDs);
                        }
                        
                                            public class NoRelatedContextPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.RelatedContextPartySubID, QuickFix.Fields.Tags.RelatedContextPartySubIDType, 0};
                        
                            public NoRelatedContextPartySubIDsGroup() 
                              :base( QuickFix.Fields.Tags.NoRelatedContextPartySubIDs, QuickFix.Fields.Tags.RelatedContextPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoRelatedContextPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.RelatedContextPartySubID RelatedContextPartySubID
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelatedContextPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                RelatedContextPartySubID = val;
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubID Get(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                return IsSetRelatedContextPartySubID();
                            }
                            
                            public bool IsSetRelatedContextPartySubID() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelatedContextPartySubID);
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubIDType RelatedContextPartySubIDType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelatedContextPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                RelatedContextPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubIDType Get(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                return IsSetRelatedContextPartySubIDType();
                            }
                            
                            public bool IsSetRelatedContextPartySubIDType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelatedContextPartySubIDType);
                            }
                            
                        
                        }
                    }
                    public class NoRelationshipRiskLimitsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.RelationshipRiskLimitType, QuickFix.Fields.Tags.RelationshipRiskLimitAmount, QuickFix.Fields.Tags.RelationshipRiskLimitCurrency, QuickFix.Fields.Tags.RelationshipRiskLimitPlatform, QuickFix.Fields.Tags.NoRelationshipRiskInstruments, QuickFix.Fields.Tags.NoRelationshipRiskWarningLevels, 0};
                    
                        public NoRelationshipRiskLimitsGroup() 
                          :base( QuickFix.Fields.Tags.NoRelationshipRiskLimits, QuickFix.Fields.Tags.RelationshipRiskLimitType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoRelationshipRiskLimitsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.RelationshipRiskLimitType RelationshipRiskLimitType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelationshipRiskLimitType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            RelationshipRiskLimitType = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitType Get(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            return IsSetRelationshipRiskLimitType();
                        }
                        
                        public bool IsSetRelationshipRiskLimitType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelationshipRiskLimitType);
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitAmount RelationshipRiskLimitAmount
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelationshipRiskLimitAmount();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            RelationshipRiskLimitAmount = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitAmount Get(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            return IsSetRelationshipRiskLimitAmount();
                        }
                        
                        public bool IsSetRelationshipRiskLimitAmount() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelationshipRiskLimitAmount);
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitCurrency RelationshipRiskLimitCurrency
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelationshipRiskLimitCurrency();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            RelationshipRiskLimitCurrency = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitCurrency Get(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            return IsSetRelationshipRiskLimitCurrency();
                        }
                        
                        public bool IsSetRelationshipRiskLimitCurrency() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelationshipRiskLimitCurrency);
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitPlatform RelationshipRiskLimitPlatform
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.RelationshipRiskLimitPlatform();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            RelationshipRiskLimitPlatform = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitPlatform Get(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            return IsSetRelationshipRiskLimitPlatform();
                        }
                        
                        public bool IsSetRelationshipRiskLimitPlatform() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.RelationshipRiskLimitPlatform);
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskInstruments NoRelationshipRiskInstruments
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoRelationshipRiskInstruments();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            NoRelationshipRiskInstruments = val;
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskInstruments Get(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            return IsSetNoRelationshipRiskInstruments();
                        }
                        
                        public bool IsSetNoRelationshipRiskInstruments() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoRelationshipRiskInstruments);
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskWarningLevels NoRelationshipRiskWarningLevels
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NoRelationshipRiskWarningLevels();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            NoRelationshipRiskWarningLevels = val;
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskWarningLevels Get(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            return IsSetNoRelationshipRiskWarningLevels();
                        }
                        
                        public bool IsSetNoRelationshipRiskWarningLevels() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NoRelationshipRiskWarningLevels);
                        }
                        
                                            public class NoRelationshipRiskInstrumentsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.RelationshipRiskInstrumentOperator, QuickFix.Fields.Tags.RelationshipRiskSymbol, QuickFix.Fields.Tags.RelationshipRiskSymbolSfx, QuickFix.Fields.Tags.RelationshipRiskSecurityID, QuickFix.Fields.Tags.RelationshipRiskSecurityIDSource, QuickFix.Fields.Tags.NoRelationshipRiskSecurityAltID, QuickFix.Fields.Tags.RelationshipRiskProduct, QuickFix.Fields.Tags.RelationshipRiskProductComplex, QuickFix.Fields.Tags.RelationshipRiskSecurityGroup, QuickFix.Fields.Tags.RelationshipRiskCFICode, QuickFix.Fields.Tags.RelationshipRiskSecurityType, QuickFix.Fields.Tags.RelationshipRiskSecuritySubType, QuickFix.Fields.Tags.RelationshipRiskMaturityMonthYear, QuickFix.Fields.Tags.RelationshipRiskMaturityTime, QuickFix.Fields.Tags.RelationshipRiskRestructuringType, QuickFix.Fields.Tags.RelationshipRiskSeniority, QuickFix.Fields.Tags.RelationshipRiskPutOrCall, QuickFix.Fields.Tags.RelationshipRiskFlexibleIndicator, QuickFix.Fields.Tags.RelationshipRiskCouponRate, QuickFix.Fields.Tags.RelationshipRiskSecurityExchange, QuickFix.Fields.Tags.RelationshipRiskSecurityDesc, QuickFix.Fields.Tags.RelationshipRiskEncodedSecurityDescLen, QuickFix.Fields.Tags.RelationshipRiskEncodedSecurityDesc, QuickFix.Fields.Tags.RelationshipRiskInstrumentSettlType, QuickFix.Fields.Tags.RelationshipRiskInstrumentMultiplier, 0};
                        
                            public NoRelationshipRiskInstrumentsGroup() 
                              :base( QuickFix.Fields.Tags.NoRelationshipRiskInstruments, QuickFix.Fields.Tags.RelationshipRiskInstrumentOperator, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoRelationshipRiskInstrumentsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.RelationshipRiskInstrumentOperator RelationshipRiskInstrumentOperator
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskInstrumentOperator();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                RelationshipRiskInstrumentOperator = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentOperator Get(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                return IsSetRelationshipRiskInstrumentOperator();
                            }
                            
                            public bool IsSetRelationshipRiskInstrumentOperator() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskInstrumentOperator);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbol RelationshipRiskSymbol
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSymbol();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                RelationshipRiskSymbol = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbol Get(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                return IsSetRelationshipRiskSymbol();
                            }
                            
                            public bool IsSetRelationshipRiskSymbol() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSymbol);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbolSfx RelationshipRiskSymbolSfx
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSymbolSfx();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                RelationshipRiskSymbolSfx = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbolSfx Get(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                return IsSetRelationshipRiskSymbolSfx();
                            }
                            
                            public bool IsSetRelationshipRiskSymbolSfx() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSymbolSfx);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityID RelationshipRiskSecurityID
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecurityID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                RelationshipRiskSecurityID = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityID Get(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                return IsSetRelationshipRiskSecurityID();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityID() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityID);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityIDSource RelationshipRiskSecurityIDSource
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecurityIDSource();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                RelationshipRiskSecurityIDSource = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityIDSource Get(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                return IsSetRelationshipRiskSecurityIDSource();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityIDSource() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityIDSource);
                            }
                            
                            public QuickFix.Fields.NoRelationshipRiskSecurityAltID NoRelationshipRiskSecurityAltID
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.NoRelationshipRiskSecurityAltID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                NoRelationshipRiskSecurityAltID = val;
                            }
                            
                            public QuickFix.Fields.NoRelationshipRiskSecurityAltID Get(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                return IsSetNoRelationshipRiskSecurityAltID();
                            }
                            
                            public bool IsSetNoRelationshipRiskSecurityAltID() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.NoRelationshipRiskSecurityAltID);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProduct RelationshipRiskProduct
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskProduct();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                RelationshipRiskProduct = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProduct Get(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                return IsSetRelationshipRiskProduct();
                            }
                            
                            public bool IsSetRelationshipRiskProduct() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskProduct);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProductComplex RelationshipRiskProductComplex
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskProductComplex();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                RelationshipRiskProductComplex = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProductComplex Get(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                return IsSetRelationshipRiskProductComplex();
                            }
                            
                            public bool IsSetRelationshipRiskProductComplex() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskProductComplex);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityGroup RelationshipRiskSecurityGroup
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecurityGroup();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                RelationshipRiskSecurityGroup = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityGroup Get(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                return IsSetRelationshipRiskSecurityGroup();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityGroup() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityGroup);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCFICode RelationshipRiskCFICode
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskCFICode();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                RelationshipRiskCFICode = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCFICode Get(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                return IsSetRelationshipRiskCFICode();
                            }
                            
                            public bool IsSetRelationshipRiskCFICode() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskCFICode);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityType RelationshipRiskSecurityType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecurityType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                RelationshipRiskSecurityType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityType Get(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                return IsSetRelationshipRiskSecurityType();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityType);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecuritySubType RelationshipRiskSecuritySubType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecuritySubType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                RelationshipRiskSecuritySubType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecuritySubType Get(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                return IsSetRelationshipRiskSecuritySubType();
                            }
                            
                            public bool IsSetRelationshipRiskSecuritySubType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecuritySubType);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityMonthYear RelationshipRiskMaturityMonthYear
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskMaturityMonthYear();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                RelationshipRiskMaturityMonthYear = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityMonthYear Get(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                return IsSetRelationshipRiskMaturityMonthYear();
                            }
                            
                            public bool IsSetRelationshipRiskMaturityMonthYear() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskMaturityMonthYear);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityTime RelationshipRiskMaturityTime
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskMaturityTime();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                RelationshipRiskMaturityTime = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityTime Get(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                return IsSetRelationshipRiskMaturityTime();
                            }
                            
                            public bool IsSetRelationshipRiskMaturityTime() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskMaturityTime);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskRestructuringType RelationshipRiskRestructuringType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskRestructuringType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                RelationshipRiskRestructuringType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskRestructuringType Get(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                return IsSetRelationshipRiskRestructuringType();
                            }
                            
                            public bool IsSetRelationshipRiskRestructuringType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskRestructuringType);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSeniority RelationshipRiskSeniority
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSeniority();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                RelationshipRiskSeniority = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSeniority Get(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                return IsSetRelationshipRiskSeniority();
                            }
                            
                            public bool IsSetRelationshipRiskSeniority() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSeniority);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskPutOrCall RelationshipRiskPutOrCall
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskPutOrCall();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                RelationshipRiskPutOrCall = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskPutOrCall Get(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                return IsSetRelationshipRiskPutOrCall();
                            }
                            
                            public bool IsSetRelationshipRiskPutOrCall() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskPutOrCall);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskFlexibleIndicator RelationshipRiskFlexibleIndicator
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskFlexibleIndicator();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                RelationshipRiskFlexibleIndicator = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskFlexibleIndicator Get(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                return IsSetRelationshipRiskFlexibleIndicator();
                            }
                            
                            public bool IsSetRelationshipRiskFlexibleIndicator() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskFlexibleIndicator);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCouponRate RelationshipRiskCouponRate
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskCouponRate();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                RelationshipRiskCouponRate = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCouponRate Get(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                return IsSetRelationshipRiskCouponRate();
                            }
                            
                            public bool IsSetRelationshipRiskCouponRate() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskCouponRate);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityExchange RelationshipRiskSecurityExchange
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecurityExchange();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                RelationshipRiskSecurityExchange = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityExchange Get(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                return IsSetRelationshipRiskSecurityExchange();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityExchange() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityExchange);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityDesc RelationshipRiskSecurityDesc
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskSecurityDesc();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                RelationshipRiskSecurityDesc = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityDesc Get(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                return IsSetRelationshipRiskSecurityDesc();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityDesc() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityDesc);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen RelationshipRiskEncodedSecurityDescLen
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                RelationshipRiskEncodedSecurityDescLen = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen Get(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                return IsSetRelationshipRiskEncodedSecurityDescLen();
                            }
                            
                            public bool IsSetRelationshipRiskEncodedSecurityDescLen() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskEncodedSecurityDescLen);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc RelationshipRiskEncodedSecurityDesc
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDesc();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                RelationshipRiskEncodedSecurityDesc = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc Get(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                return IsSetRelationshipRiskEncodedSecurityDesc();
                            }
                            
                            public bool IsSetRelationshipRiskEncodedSecurityDesc() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskEncodedSecurityDesc);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentSettlType RelationshipRiskInstrumentSettlType
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskInstrumentSettlType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                RelationshipRiskInstrumentSettlType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentSettlType Get(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                return IsSetRelationshipRiskInstrumentSettlType();
                            }
                            
                            public bool IsSetRelationshipRiskInstrumentSettlType() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskInstrumentSettlType);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentMultiplier RelationshipRiskInstrumentMultiplier
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskInstrumentMultiplier();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                RelationshipRiskInstrumentMultiplier = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentMultiplier Get(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                return IsSetRelationshipRiskInstrumentMultiplier();
                            }
                            
                            public bool IsSetRelationshipRiskInstrumentMultiplier() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskInstrumentMultiplier);
                            }
                            
                                                    public class NoRelationshipRiskSecurityAltIDGroup : Group
                            {
                                public static int[] fieldOrder = {QuickFix.Fields.Tags.RelationshipRiskSecurityAltID, QuickFix.Fields.Tags.RelationshipRiskSecurityAltIDSource, 0};
                            
                                public NoRelationshipRiskSecurityAltIDGroup() 
                                  :base( QuickFix.Fields.Tags.NoRelationshipRiskSecurityAltID, QuickFix.Fields.Tags.RelationshipRiskSecurityAltID, fieldOrder)
                                {
                                }
                            
                                public override Group Clone()
                                {
                                    var clone = new NoRelationshipRiskSecurityAltIDGroup();
                                    clone.CopyStateFrom(this);
                                    return clone;
                                }
                            
                                                            public QuickFix.Fields.RelationshipRiskSecurityAltID RelationshipRiskSecurityAltID
                                { 
                                    get 
                                    {
                                        var val = new QuickFix.Fields.RelationshipRiskSecurityAltID();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }
                                
                                public void Set(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    RelationshipRiskSecurityAltID = val;
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltID Get(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    GetField(val);
                                    return val;
                                }
                                
                                public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    return IsSetRelationshipRiskSecurityAltID();
                                }
                                
                                public bool IsSetRelationshipRiskSecurityAltID() 
                                { 
                                    return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityAltID);
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltIDSource RelationshipRiskSecurityAltIDSource
                                { 
                                    get 
                                    {
                                        var val = new QuickFix.Fields.RelationshipRiskSecurityAltIDSource();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }
                                
                                public void Set(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    RelationshipRiskSecurityAltIDSource = val;
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltIDSource Get(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    GetField(val);
                                    return val;
                                }
                                
                                public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    return IsSetRelationshipRiskSecurityAltIDSource();
                                }
                                
                                public bool IsSetRelationshipRiskSecurityAltIDSource() 
                                { 
                                    return IsSetField(QuickFix.Fields.Tags.RelationshipRiskSecurityAltIDSource);
                                }
                                
                            
                            }
                        }
                        public class NoRelationshipRiskWarningLevelsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.Fields.Tags.RelationshipRiskWarningLevelPercent, QuickFix.Fields.Tags.RelationshipRiskWarningLevelName, 0};
                        
                            public NoRelationshipRiskWarningLevelsGroup() 
                              :base( QuickFix.Fields.Tags.NoRelationshipRiskWarningLevels, QuickFix.Fields.Tags.RelationshipRiskWarningLevelPercent, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoRelationshipRiskWarningLevelsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.RelationshipRiskWarningLevelPercent RelationshipRiskWarningLevelPercent
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskWarningLevelPercent();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                RelationshipRiskWarningLevelPercent = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelPercent Get(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                return IsSetRelationshipRiskWarningLevelPercent();
                            }
                            
                            public bool IsSetRelationshipRiskWarningLevelPercent() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskWarningLevelPercent);
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelName RelationshipRiskWarningLevelName
                            { 
                                get 
                                {
                                    var val = new QuickFix.Fields.RelationshipRiskWarningLevelName();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                RelationshipRiskWarningLevelName = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelName Get(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                return IsSetRelationshipRiskWarningLevelName();
                            }
                            
                            public bool IsSetRelationshipRiskWarningLevelName() 
                            { 
                                return IsSetField(QuickFix.Fields.Tags.RelationshipRiskWarningLevelName);
                            }
                            
                        
                        }
                    }
                    public class NoPartyRelationshipsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.PartyRelationship, 0};
                    
                        public NoPartyRelationshipsGroup() 
                          :base( QuickFix.Fields.Tags.NoPartyRelationships, QuickFix.Fields.Tags.PartyRelationship, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoPartyRelationshipsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.PartyRelationship PartyRelationship
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.PartyRelationship();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartyRelationship val) 
                        { 
                            PartyRelationship = val;
                        }
                        
                        public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartyRelationship val) 
                        { 
                            return IsSetPartyRelationship();
                        }
                        
                        public bool IsSetPartyRelationship() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.PartyRelationship);
                        }
                        
                    
                    }
                }
            }
    }
}

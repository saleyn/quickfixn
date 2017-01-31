// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class NetworkStatusResponse : Message
    {
            public const string MsgType = "BD";

            public NetworkStatusResponse() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("BD"));
            }

            public NetworkStatusResponse(
                    QuickFix.FXCM.Fields.NetworkStatusResponseType aNetworkStatusResponseType
                ) : this()
            {
                this.NetworkStatusResponseType = aNetworkStatusResponseType;
            }

            public QuickFix.FXCM.Fields.NetworkStatusResponseType NetworkStatusResponseType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NetworkStatusResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NetworkStatusResponseType val) 
            { 
                NetworkStatusResponseType = val;
            }
            
            public QuickFix.FXCM.Fields.NetworkStatusResponseType Get(QuickFix.FXCM.Fields.NetworkStatusResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NetworkStatusResponseType val) 
            { 
                return IsSetNetworkStatusResponseType();
            }
            
            public bool IsSetNetworkStatusResponseType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NetworkStatusResponseType);
            }
            
            public QuickFix.FXCM.Fields.NetworkRequestID NetworkRequestID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NetworkRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NetworkRequestID val) 
            { 
                NetworkRequestID = val;
            }
            
            public QuickFix.FXCM.Fields.NetworkRequestID Get(QuickFix.FXCM.Fields.NetworkRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NetworkRequestID val) 
            { 
                return IsSetNetworkRequestID();
            }
            
            public bool IsSetNetworkRequestID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NetworkRequestID);
            }
            
            public QuickFix.FXCM.Fields.NetworkResponseID NetworkResponseID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NetworkResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NetworkResponseID val) 
            { 
                NetworkResponseID = val;
            }
            
            public QuickFix.FXCM.Fields.NetworkResponseID Get(QuickFix.FXCM.Fields.NetworkResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NetworkResponseID val) 
            { 
                return IsSetNetworkResponseID();
            }
            
            public bool IsSetNetworkResponseID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NetworkResponseID);
            }
            
            public QuickFix.FXCM.Fields.LastNetworkResponseID LastNetworkResponseID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastNetworkResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastNetworkResponseID val) 
            { 
                LastNetworkResponseID = val;
            }
            
            public QuickFix.FXCM.Fields.LastNetworkResponseID Get(QuickFix.FXCM.Fields.LastNetworkResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastNetworkResponseID val) 
            { 
                return IsSetLastNetworkResponseID();
            }
            
            public bool IsSetLastNetworkResponseID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastNetworkResponseID);
            }
            
            public QuickFix.FXCM.Fields.NoCompIDs NoCompIDs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoCompIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoCompIDs val) 
            { 
                NoCompIDs = val;
            }
            
            public QuickFix.FXCM.Fields.NoCompIDs Get(QuickFix.FXCM.Fields.NoCompIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoCompIDs val) 
            { 
                return IsSetNoCompIDs();
            }
            
            public bool IsSetNoCompIDs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoCompIDs);
            }
            
            public class NoCompIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.RefCompID, QuickFix.FXCM.Fields.Tags.RefSubID, QuickFix.FXCM.Fields.Tags.LocationID, QuickFix.FXCM.Fields.Tags.DeskID, QuickFix.FXCM.Fields.Tags.StatusValue, QuickFix.FXCM.Fields.Tags.StatusText, 0};
            
                public NoCompIDsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoCompIDs, QuickFix.FXCM.Fields.Tags.RefCompID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoCompIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.RefCompID RefCompID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.RefCompID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.RefCompID val) 
                { 
                    RefCompID = val;
                }
                
                public QuickFix.FXCM.Fields.RefCompID Get(QuickFix.FXCM.Fields.RefCompID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.RefCompID val) 
                { 
                    return IsSetRefCompID();
                }
                
                public bool IsSetRefCompID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.RefCompID);
                }
                
                public QuickFix.FXCM.Fields.RefSubID RefSubID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.RefSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.RefSubID val) 
                { 
                    RefSubID = val;
                }
                
                public QuickFix.FXCM.Fields.RefSubID Get(QuickFix.FXCM.Fields.RefSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.RefSubID val) 
                { 
                    return IsSetRefSubID();
                }
                
                public bool IsSetRefSubID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.RefSubID);
                }
                
                public QuickFix.FXCM.Fields.LocationID LocationID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LocationID val) 
                { 
                    LocationID = val;
                }
                
                public QuickFix.FXCM.Fields.LocationID Get(QuickFix.FXCM.Fields.LocationID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LocationID val) 
                { 
                    return IsSetLocationID();
                }
                
                public bool IsSetLocationID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LocationID);
                }
                
                public QuickFix.FXCM.Fields.DeskID DeskID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.DeskID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.DeskID val) 
                { 
                    DeskID = val;
                }
                
                public QuickFix.FXCM.Fields.DeskID Get(QuickFix.FXCM.Fields.DeskID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.DeskID val) 
                { 
                    return IsSetDeskID();
                }
                
                public bool IsSetDeskID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.DeskID);
                }
                
                public QuickFix.FXCM.Fields.StatusValue StatusValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StatusValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StatusValue val) 
                { 
                    StatusValue = val;
                }
                
                public QuickFix.FXCM.Fields.StatusValue Get(QuickFix.FXCM.Fields.StatusValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StatusValue val) 
                { 
                    return IsSetStatusValue();
                }
                
                public bool IsSetStatusValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StatusValue);
                }
                
                public QuickFix.FXCM.Fields.StatusText StatusText
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StatusText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StatusText val) 
                { 
                    StatusText = val;
                }
                
                public QuickFix.FXCM.Fields.StatusText Get(QuickFix.FXCM.Fields.StatusText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StatusText val) 
                { 
                    return IsSetStatusText();
                }
                
                public bool IsSetStatusText() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StatusText);
                }
                
            
            }
    }
}

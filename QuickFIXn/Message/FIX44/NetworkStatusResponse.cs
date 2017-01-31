// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class NetworkStatusResponse : Message
    {
            public const string MsgType = "BD";

            public NetworkStatusResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BD"));
            }

            public NetworkStatusResponse(
                    QuickFix.Fields.NetworkStatusResponseType aNetworkStatusResponseType
                ) : this()
            {
                this.NetworkStatusResponseType = aNetworkStatusResponseType;
            }

            public QuickFix.Fields.NetworkStatusResponseType NetworkStatusResponseType
            { 
                get 
                {
                    var val = new QuickFix.Fields.NetworkStatusResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                NetworkStatusResponseType = val;
            }
            
            public QuickFix.Fields.NetworkStatusResponseType Get(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                return IsSetNetworkStatusResponseType();
            }
            
            public bool IsSetNetworkStatusResponseType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NetworkStatusResponseType);
            }
            
            public QuickFix.Fields.NetworkRequestID NetworkRequestID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NetworkRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkRequestID val) 
            { 
                NetworkRequestID = val;
            }
            
            public QuickFix.Fields.NetworkRequestID Get(QuickFix.Fields.NetworkRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkRequestID val) 
            { 
                return IsSetNetworkRequestID();
            }
            
            public bool IsSetNetworkRequestID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NetworkRequestID);
            }
            
            public QuickFix.Fields.NetworkResponseID NetworkResponseID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NetworkResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkResponseID val) 
            { 
                NetworkResponseID = val;
            }
            
            public QuickFix.Fields.NetworkResponseID Get(QuickFix.Fields.NetworkResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkResponseID val) 
            { 
                return IsSetNetworkResponseID();
            }
            
            public bool IsSetNetworkResponseID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NetworkResponseID);
            }
            
            public QuickFix.Fields.LastNetworkResponseID LastNetworkResponseID
            { 
                get 
                {
                    var val = new QuickFix.Fields.LastNetworkResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                LastNetworkResponseID = val;
            }
            
            public QuickFix.Fields.LastNetworkResponseID Get(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                return IsSetLastNetworkResponseID();
            }
            
            public bool IsSetLastNetworkResponseID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LastNetworkResponseID);
            }
            
            public QuickFix.Fields.NoCompIDs NoCompIDs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoCompIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoCompIDs val) 
            { 
                NoCompIDs = val;
            }
            
            public QuickFix.Fields.NoCompIDs Get(QuickFix.Fields.NoCompIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoCompIDs val) 
            { 
                return IsSetNoCompIDs();
            }
            
            public bool IsSetNoCompIDs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoCompIDs);
            }
            
            public class NoCompIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RefCompID, QuickFix.Fields.Tags.RefSubID, QuickFix.Fields.Tags.LocationID, QuickFix.Fields.Tags.DeskID, QuickFix.Fields.Tags.StatusValue, QuickFix.Fields.Tags.StatusText, 0};
            
                public NoCompIDsGroup() 
                  :base( QuickFix.Fields.Tags.NoCompIDs, QuickFix.Fields.Tags.RefCompID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoCompIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RefCompID RefCompID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RefCompID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefCompID val) 
                { 
                    RefCompID = val;
                }
                
                public QuickFix.Fields.RefCompID Get(QuickFix.Fields.RefCompID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefCompID val) 
                { 
                    return IsSetRefCompID();
                }
                
                public bool IsSetRefCompID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RefCompID);
                }
                
                public QuickFix.Fields.RefSubID RefSubID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RefSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefSubID val) 
                { 
                    RefSubID = val;
                }
                
                public QuickFix.Fields.RefSubID Get(QuickFix.Fields.RefSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefSubID val) 
                { 
                    return IsSetRefSubID();
                }
                
                public bool IsSetRefSubID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RefSubID);
                }
                
                public QuickFix.Fields.LocationID LocationID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocationID val) 
                { 
                    LocationID = val;
                }
                
                public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocationID val) 
                { 
                    return IsSetLocationID();
                }
                
                public bool IsSetLocationID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LocationID);
                }
                
                public QuickFix.Fields.DeskID DeskID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.DeskID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskID val) 
                { 
                    DeskID = val;
                }
                
                public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskID val) 
                { 
                    return IsSetDeskID();
                }
                
                public bool IsSetDeskID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.DeskID);
                }
                
                public QuickFix.Fields.StatusValue StatusValue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StatusValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StatusValue val) 
                { 
                    StatusValue = val;
                }
                
                public QuickFix.Fields.StatusValue Get(QuickFix.Fields.StatusValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StatusValue val) 
                { 
                    return IsSetStatusValue();
                }
                
                public bool IsSetStatusValue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StatusValue);
                }
                
                public QuickFix.Fields.StatusText StatusText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.StatusText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StatusText val) 
                { 
                    StatusText = val;
                }
                
                public QuickFix.Fields.StatusText Get(QuickFix.Fields.StatusText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StatusText val) 
                { 
                    return IsSetStatusText();
                }
                
                public bool IsSetStatusText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.StatusText);
                }
                
            
            }
    }
}

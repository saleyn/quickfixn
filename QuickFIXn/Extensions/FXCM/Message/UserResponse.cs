// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class UserResponse : Message
    {
            public const string MsgType = "BF";

            public UserResponse() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("BF"));
            }

            public UserResponse(
                    QuickFix.FXCM.Fields.UserRequestID aUserRequestID,
                    QuickFix.FXCM.Fields.Username aUsername
                ) : this()
            {
                this.UserRequestID = aUserRequestID;
                this.Username = aUsername;
            }

            public QuickFix.FXCM.Fields.UserRequestID UserRequestID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UserRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UserRequestID val) 
            { 
                UserRequestID = val;
            }
            
            public QuickFix.FXCM.Fields.UserRequestID Get(QuickFix.FXCM.Fields.UserRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UserRequestID val) 
            { 
                return IsSetUserRequestID();
            }
            
            public bool IsSetUserRequestID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UserRequestID);
            }
            
            public QuickFix.FXCM.Fields.Username Username
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Username();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Username val) 
            { 
                Username = val;
            }
            
            public QuickFix.FXCM.Fields.Username Get(QuickFix.FXCM.Fields.Username val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Username val) 
            { 
                return IsSetUsername();
            }
            
            public bool IsSetUsername() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Username);
            }
            
            public QuickFix.FXCM.Fields.UserStatus UserStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UserStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UserStatus val) 
            { 
                UserStatus = val;
            }
            
            public QuickFix.FXCM.Fields.UserStatus Get(QuickFix.FXCM.Fields.UserStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UserStatus val) 
            { 
                return IsSetUserStatus();
            }
            
            public bool IsSetUserStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UserStatus);
            }
            
            public QuickFix.FXCM.Fields.UserStatusText UserStatusText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UserStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UserStatusText val) 
            { 
                UserStatusText = val;
            }
            
            public QuickFix.FXCM.Fields.UserStatusText Get(QuickFix.FXCM.Fields.UserStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UserStatusText val) 
            { 
                return IsSetUserStatusText();
            }
            
            public bool IsSetUserStatusText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UserStatusText);
            }
            
            public QuickFix.FXCM.Fields.NoTradingSessions NoTradingSessions
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoTradingSessions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoTradingSessions val) 
            { 
                NoTradingSessions = val;
            }
            
            public QuickFix.FXCM.Fields.NoTradingSessions Get(QuickFix.FXCM.Fields.NoTradingSessions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoTradingSessions val) 
            { 
                return IsSetNoTradingSessions();
            }
            
            public bool IsSetNoTradingSessions() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoTradingSessions);
            }
            
            public QuickFix.FXCM.Fields.FXCMNoParam FXCMNoParam
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMNoParam();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMNoParam val) 
            { 
                FXCMNoParam = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMNoParam Get(QuickFix.FXCM.Fields.FXCMNoParam val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMNoParam val) 
            { 
                return IsSetFXCMNoParam();
            }
            
            public bool IsSetFXCMNoParam() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMNoParam);
            }
            
            public class NoTradingSessionsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.TradingSessionID, QuickFix.FXCM.Fields.Tags.TradingSessionSubID, 0};
            
                public NoTradingSessionsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoTradingSessions, QuickFix.FXCM.Fields.Tags.TradingSessionID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTradingSessionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.TradingSessionID TradingSessionID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.TradingSessionID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.TradingSessionID val) 
                { 
                    TradingSessionID = val;
                }
                
                public QuickFix.FXCM.Fields.TradingSessionID Get(QuickFix.FXCM.Fields.TradingSessionID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.TradingSessionID val) 
                { 
                    return IsSetTradingSessionID();
                }
                
                public bool IsSetTradingSessionID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.TradingSessionID);
                }
                
                public QuickFix.FXCM.Fields.TradingSessionSubID TradingSessionSubID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.TradingSessionSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.TradingSessionSubID val) 
                { 
                    TradingSessionSubID = val;
                }
                
                public QuickFix.FXCM.Fields.TradingSessionSubID Get(QuickFix.FXCM.Fields.TradingSessionSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.TradingSessionSubID val) 
                { 
                    return IsSetTradingSessionSubID();
                }
                
                public bool IsSetTradingSessionSubID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.TradingSessionSubID);
                }
                
            
            }
            public class FXCMNoParamGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.FXCMParamName, QuickFix.FXCM.Fields.Tags.FXCMParamValue, 0};
            
                public FXCMNoParamGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.FXCMNoParam, QuickFix.FXCM.Fields.Tags.FXCMParamName, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new FXCMNoParamGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.FXCMParamName FXCMParamName
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FXCMParamName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FXCMParamName val) 
                { 
                    FXCMParamName = val;
                }
                
                public QuickFix.FXCM.Fields.FXCMParamName Get(QuickFix.FXCM.Fields.FXCMParamName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FXCMParamName val) 
                { 
                    return IsSetFXCMParamName();
                }
                
                public bool IsSetFXCMParamName() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMParamName);
                }
                
                public QuickFix.FXCM.Fields.FXCMParamValue FXCMParamValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FXCMParamValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FXCMParamValue val) 
                { 
                    FXCMParamValue = val;
                }
                
                public QuickFix.FXCM.Fields.FXCMParamValue Get(QuickFix.FXCM.Fields.FXCMParamValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FXCMParamValue val) 
                { 
                    return IsSetFXCMParamValue();
                }
                
                public bool IsSetFXCMParamValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMParamValue);
                }
                
            
            }
    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class UserRequest : Message
    {
            public const string MsgType = "BE";

            public UserRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("BE"));
            }

            public UserRequest(
                    QuickFix.FXCM.Fields.UserRequestID aUserRequestID,
                    QuickFix.FXCM.Fields.UserRequestType aUserRequestType,
                    QuickFix.FXCM.Fields.Username aUsername
                ) : this()
            {
                this.UserRequestID = aUserRequestID;
                this.UserRequestType = aUserRequestType;
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
            
            public QuickFix.FXCM.Fields.UserRequestType UserRequestType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UserRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UserRequestType val) 
            { 
                UserRequestType = val;
            }
            
            public QuickFix.FXCM.Fields.UserRequestType Get(QuickFix.FXCM.Fields.UserRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UserRequestType val) 
            { 
                return IsSetUserRequestType();
            }
            
            public bool IsSetUserRequestType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UserRequestType);
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
            
            public QuickFix.FXCM.Fields.Password Password
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Password();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Password val) 
            { 
                Password = val;
            }
            
            public QuickFix.FXCM.Fields.Password Get(QuickFix.FXCM.Fields.Password val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Password val) 
            { 
                return IsSetPassword();
            }
            
            public bool IsSetPassword() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Password);
            }
            
            public QuickFix.FXCM.Fields.NewPassword NewPassword
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NewPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NewPassword val) 
            { 
                NewPassword = val;
            }
            
            public QuickFix.FXCM.Fields.NewPassword Get(QuickFix.FXCM.Fields.NewPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NewPassword val) 
            { 
                return IsSetNewPassword();
            }
            
            public bool IsSetNewPassword() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NewPassword);
            }
            
            public QuickFix.FXCM.Fields.RawDataLength RawDataLength
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RawDataLength val) 
            { 
                RawDataLength = val;
            }
            
            public QuickFix.FXCM.Fields.RawDataLength Get(QuickFix.FXCM.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RawDataLength);
            }
            
            public QuickFix.FXCM.Fields.RawData RawData
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RawData val) 
            { 
                RawData = val;
            }
            
            public QuickFix.FXCM.Fields.RawData Get(QuickFix.FXCM.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RawData);
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

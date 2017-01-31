// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class UserRequest : Message
    {
            public const string MsgType = "BE";

            public UserRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BE"));
            }

            public UserRequest(
                    QuickFix.Fields.UserRequestID aUserRequestID,
                    QuickFix.Fields.UserRequestType aUserRequestType,
                    QuickFix.Fields.Username aUsername
                ) : this()
            {
                this.UserRequestID = aUserRequestID;
                this.UserRequestType = aUserRequestType;
                this.Username = aUsername;
            }

            public QuickFix.Fields.UserRequestID UserRequestID
            { 
                get 
                {
                    var val = new QuickFix.Fields.UserRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserRequestID val) 
            { 
                UserRequestID = val;
            }
            
            public QuickFix.Fields.UserRequestID Get(QuickFix.Fields.UserRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserRequestID val) 
            { 
                return IsSetUserRequestID();
            }
            
            public bool IsSetUserRequestID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UserRequestID);
            }
            
            public QuickFix.Fields.UserRequestType UserRequestType
            { 
                get 
                {
                    var val = new QuickFix.Fields.UserRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserRequestType val) 
            { 
                UserRequestType = val;
            }
            
            public QuickFix.Fields.UserRequestType Get(QuickFix.Fields.UserRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserRequestType val) 
            { 
                return IsSetUserRequestType();
            }
            
            public bool IsSetUserRequestType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UserRequestType);
            }
            
            public QuickFix.Fields.Username Username
            { 
                get 
                {
                    var val = new QuickFix.Fields.Username();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Username val) 
            { 
                Username = val;
            }
            
            public QuickFix.Fields.Username Get(QuickFix.Fields.Username val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Username val) 
            { 
                return IsSetUsername();
            }
            
            public bool IsSetUsername() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Username);
            }
            
            public QuickFix.Fields.Password Password
            { 
                get 
                {
                    var val = new QuickFix.Fields.Password();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Password val) 
            { 
                Password = val;
            }
            
            public QuickFix.Fields.Password Get(QuickFix.Fields.Password val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Password val) 
            { 
                return IsSetPassword();
            }
            
            public bool IsSetPassword() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Password);
            }
            
            public QuickFix.Fields.NewPassword NewPassword
            { 
                get 
                {
                    var val = new QuickFix.Fields.NewPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NewPassword val) 
            { 
                NewPassword = val;
            }
            
            public QuickFix.Fields.NewPassword Get(QuickFix.Fields.NewPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NewPassword val) 
            { 
                return IsSetNewPassword();
            }
            
            public bool IsSetNewPassword() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NewPassword);
            }
            
            public QuickFix.Fields.RawDataLength RawDataLength
            { 
                get 
                {
                    var val = new QuickFix.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawDataLength val) 
            { 
                RawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RawDataLength);
            }
            
            public QuickFix.Fields.RawData RawData
            { 
                get 
                {
                    var val = new QuickFix.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawData val) 
            { 
                RawData = val;
            }
            
            public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RawData);
            }
            
            public QuickFix.Fields.EncryptedPasswordMethod EncryptedPasswordMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncryptedPasswordMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedPasswordMethod val) 
            { 
                EncryptedPasswordMethod = val;
            }
            
            public QuickFix.Fields.EncryptedPasswordMethod Get(QuickFix.Fields.EncryptedPasswordMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedPasswordMethod val) 
            { 
                return IsSetEncryptedPasswordMethod();
            }
            
            public bool IsSetEncryptedPasswordMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncryptedPasswordMethod);
            }
            
            public QuickFix.Fields.EncryptedPasswordLen EncryptedPasswordLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncryptedPasswordLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedPasswordLen val) 
            { 
                EncryptedPasswordLen = val;
            }
            
            public QuickFix.Fields.EncryptedPasswordLen Get(QuickFix.Fields.EncryptedPasswordLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedPasswordLen val) 
            { 
                return IsSetEncryptedPasswordLen();
            }
            
            public bool IsSetEncryptedPasswordLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncryptedPasswordLen);
            }
            
            public QuickFix.Fields.EncryptedPassword EncryptedPassword
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncryptedPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedPassword val) 
            { 
                EncryptedPassword = val;
            }
            
            public QuickFix.Fields.EncryptedPassword Get(QuickFix.Fields.EncryptedPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedPassword val) 
            { 
                return IsSetEncryptedPassword();
            }
            
            public bool IsSetEncryptedPassword() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncryptedPassword);
            }
            
            public QuickFix.Fields.EncryptedNewPasswordLen EncryptedNewPasswordLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncryptedNewPasswordLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedNewPasswordLen val) 
            { 
                EncryptedNewPasswordLen = val;
            }
            
            public QuickFix.Fields.EncryptedNewPasswordLen Get(QuickFix.Fields.EncryptedNewPasswordLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedNewPasswordLen val) 
            { 
                return IsSetEncryptedNewPasswordLen();
            }
            
            public bool IsSetEncryptedNewPasswordLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncryptedNewPasswordLen);
            }
            
            public QuickFix.Fields.EncryptedNewPassword EncryptedNewPassword
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncryptedNewPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedNewPassword val) 
            { 
                EncryptedNewPassword = val;
            }
            
            public QuickFix.Fields.EncryptedNewPassword Get(QuickFix.Fields.EncryptedNewPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedNewPassword val) 
            { 
                return IsSetEncryptedNewPassword();
            }
            
            public bool IsSetEncryptedNewPassword() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncryptedNewPassword);
            }
            

    }
}

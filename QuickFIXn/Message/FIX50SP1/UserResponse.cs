// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class UserResponse : Message
    {
            public const string MsgType = "BF";

            public UserResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BF"));
            }

            public UserResponse(
                    QuickFix.Fields.UserRequestID aUserRequestID,
                    QuickFix.Fields.Username aUsername
                ) : this()
            {
                this.UserRequestID = aUserRequestID;
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
            
            public QuickFix.Fields.UserStatus UserStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.UserStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserStatus val) 
            { 
                UserStatus = val;
            }
            
            public QuickFix.Fields.UserStatus Get(QuickFix.Fields.UserStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserStatus val) 
            { 
                return IsSetUserStatus();
            }
            
            public bool IsSetUserStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UserStatus);
            }
            
            public QuickFix.Fields.UserStatusText UserStatusText
            { 
                get 
                {
                    var val = new QuickFix.Fields.UserStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserStatusText val) 
            { 
                UserStatusText = val;
            }
            
            public QuickFix.Fields.UserStatusText Get(QuickFix.Fields.UserStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserStatusText val) 
            { 
                return IsSetUserStatusText();
            }
            
            public bool IsSetUserStatusText() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UserStatusText);
            }
            

    }
}

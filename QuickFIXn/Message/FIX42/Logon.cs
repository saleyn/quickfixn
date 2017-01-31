// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class Logon : Message
    {
            public const string MsgType = "A";

            public Logon() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("A"));
            }

            public Logon(
                    QuickFix.Fields.EncryptMethod aEncryptMethod,
                    QuickFix.Fields.HeartBtInt aHeartBtInt
                ) : this()
            {
                this.EncryptMethod = aEncryptMethod;
                this.HeartBtInt = aHeartBtInt;
            }

            public QuickFix.Fields.EncryptMethod EncryptMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncryptMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptMethod val) 
            { 
                EncryptMethod = val;
            }
            
            public QuickFix.Fields.EncryptMethod Get(QuickFix.Fields.EncryptMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptMethod val) 
            { 
                return IsSetEncryptMethod();
            }
            
            public bool IsSetEncryptMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncryptMethod);
            }
            
            public QuickFix.Fields.HeartBtInt HeartBtInt
            { 
                get 
                {
                    var val = new QuickFix.Fields.HeartBtInt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HeartBtInt val) 
            { 
                HeartBtInt = val;
            }
            
            public QuickFix.Fields.HeartBtInt Get(QuickFix.Fields.HeartBtInt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HeartBtInt val) 
            { 
                return IsSetHeartBtInt();
            }
            
            public bool IsSetHeartBtInt() 
            { 
                return IsSetField(QuickFix.Fields.Tags.HeartBtInt);
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
            
            public QuickFix.Fields.ResetSeqNumFlag ResetSeqNumFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.ResetSeqNumFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                ResetSeqNumFlag = val;
            }
            
            public QuickFix.Fields.ResetSeqNumFlag Get(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                return IsSetResetSeqNumFlag();
            }
            
            public bool IsSetResetSeqNumFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ResetSeqNumFlag);
            }
            
            public QuickFix.Fields.MaxMessageSize MaxMessageSize
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaxMessageSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxMessageSize val) 
            { 
                MaxMessageSize = val;
            }
            
            public QuickFix.Fields.MaxMessageSize Get(QuickFix.Fields.MaxMessageSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxMessageSize val) 
            { 
                return IsSetMaxMessageSize();
            }
            
            public bool IsSetMaxMessageSize() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaxMessageSize);
            }
            
            public QuickFix.Fields.NoMsgTypes NoMsgTypes
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoMsgTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMsgTypes val) 
            { 
                NoMsgTypes = val;
            }
            
            public QuickFix.Fields.NoMsgTypes Get(QuickFix.Fields.NoMsgTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMsgTypes val) 
            { 
                return IsSetNoMsgTypes();
            }
            
            public bool IsSetNoMsgTypes() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoMsgTypes);
            }
            
            public class NoMsgTypesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RefMsgType, QuickFix.Fields.Tags.MsgDirection, 0};
            
                public NoMsgTypesGroup() 
                  :base( QuickFix.Fields.Tags.NoMsgTypes, QuickFix.Fields.Tags.RefMsgType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMsgTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RefMsgType RefMsgType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RefMsgType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefMsgType val) 
                { 
                    RefMsgType = val;
                }
                
                public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefMsgType val) 
                { 
                    return IsSetRefMsgType();
                }
                
                public bool IsSetRefMsgType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RefMsgType);
                }
                
                public QuickFix.Fields.MsgDirection MsgDirection
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MsgDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MsgDirection val) 
                { 
                    MsgDirection = val;
                }
                
                public QuickFix.Fields.MsgDirection Get(QuickFix.Fields.MsgDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MsgDirection val) 
                { 
                    return IsSetMsgDirection();
                }
                
                public bool IsSetMsgDirection() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MsgDirection);
                }
                
            
            }
    }
}

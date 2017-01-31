// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class SettlementInstructions : Message
    {
            public const string MsgType = "T";

            public SettlementInstructions() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("T"));
            }

            public SettlementInstructions(
                    QuickFix.FXCM.Fields.SettlInstMsgID aSettlInstMsgID,
                    QuickFix.FXCM.Fields.SettlInstMode aSettlInstMode,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.SettlInstMsgID = aSettlInstMsgID;
                this.SettlInstMode = aSettlInstMode;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.FXCM.Fields.SettlInstMsgID SettlInstMsgID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlInstMsgID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlInstMsgID val) 
            { 
                SettlInstMsgID = val;
            }
            
            public QuickFix.FXCM.Fields.SettlInstMsgID Get(QuickFix.FXCM.Fields.SettlInstMsgID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlInstMsgID val) 
            { 
                return IsSetSettlInstMsgID();
            }
            
            public bool IsSetSettlInstMsgID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstMsgID);
            }
            
            public QuickFix.FXCM.Fields.SettlInstReqID SettlInstReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlInstReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlInstReqID val) 
            { 
                SettlInstReqID = val;
            }
            
            public QuickFix.FXCM.Fields.SettlInstReqID Get(QuickFix.FXCM.Fields.SettlInstReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlInstReqID val) 
            { 
                return IsSetSettlInstReqID();
            }
            
            public bool IsSetSettlInstReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstReqID);
            }
            
            public QuickFix.FXCM.Fields.SettlInstMode SettlInstMode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlInstMode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlInstMode val) 
            { 
                SettlInstMode = val;
            }
            
            public QuickFix.FXCM.Fields.SettlInstMode Get(QuickFix.FXCM.Fields.SettlInstMode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlInstMode val) 
            { 
                return IsSetSettlInstMode();
            }
            
            public bool IsSetSettlInstMode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstMode);
            }
            
            public QuickFix.FXCM.Fields.SettlInstReqRejCode SettlInstReqRejCode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlInstReqRejCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlInstReqRejCode val) 
            { 
                SettlInstReqRejCode = val;
            }
            
            public QuickFix.FXCM.Fields.SettlInstReqRejCode Get(QuickFix.FXCM.Fields.SettlInstReqRejCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlInstReqRejCode val) 
            { 
                return IsSetSettlInstReqRejCode();
            }
            
            public bool IsSetSettlInstReqRejCode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstReqRejCode);
            }
            
            public QuickFix.FXCM.Fields.Text Text
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Text val) 
            { 
                Text = val;
            }
            
            public QuickFix.FXCM.Fields.Text Get(QuickFix.FXCM.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Text);
            }
            
            public QuickFix.FXCM.Fields.EncodedTextLen EncodedTextLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                EncodedTextLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedTextLen Get(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedTextLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedText EncodedText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                EncodedText = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedText Get(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedText);
            }
            
            public QuickFix.FXCM.Fields.SettlInstSource SettlInstSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlInstSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlInstSource val) 
            { 
                SettlInstSource = val;
            }
            
            public QuickFix.FXCM.Fields.SettlInstSource Get(QuickFix.FXCM.Fields.SettlInstSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlInstSource val) 
            { 
                return IsSetSettlInstSource();
            }
            
            public bool IsSetSettlInstSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstSource);
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
            
            public QuickFix.FXCM.Fields.TransactTime TransactTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                TransactTime = val;
            }
            
            public QuickFix.FXCM.Fields.TransactTime Get(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TransactTime);
            }
            
            public QuickFix.FXCM.Fields.NoSettlInst NoSettlInst
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoSettlInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoSettlInst val) 
            { 
                NoSettlInst = val;
            }
            
            public QuickFix.FXCM.Fields.NoSettlInst Get(QuickFix.FXCM.Fields.NoSettlInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoSettlInst val) 
            { 
                return IsSetNoSettlInst();
            }
            
            public bool IsSetNoSettlInst() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoSettlInst);
            }
            
            public class NoSettlInstGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SettlInstID, QuickFix.FXCM.Fields.Tags.SettlInstTransType, QuickFix.FXCM.Fields.Tags.SettlInstRefID, QuickFix.FXCM.Fields.Tags.NoPartyIDs, QuickFix.FXCM.Fields.Tags.Side, QuickFix.FXCM.Fields.Tags.Product, QuickFix.FXCM.Fields.Tags.SecurityType, QuickFix.FXCM.Fields.Tags.CFICode, QuickFix.FXCM.Fields.Tags.EffectiveTime, QuickFix.FXCM.Fields.Tags.ExpireTime, QuickFix.FXCM.Fields.Tags.LastUpdateTime, QuickFix.FXCM.Fields.Tags.SettlDeliveryType, QuickFix.FXCM.Fields.Tags.StandInstDbType, QuickFix.FXCM.Fields.Tags.StandInstDbName, QuickFix.FXCM.Fields.Tags.StandInstDbID, QuickFix.FXCM.Fields.Tags.NoDlvyInst, QuickFix.FXCM.Fields.Tags.PaymentMethod, QuickFix.FXCM.Fields.Tags.PaymentRef, QuickFix.FXCM.Fields.Tags.CardHolderName, QuickFix.FXCM.Fields.Tags.CardNumber, QuickFix.FXCM.Fields.Tags.CardStartDate, QuickFix.FXCM.Fields.Tags.CardExpDate, QuickFix.FXCM.Fields.Tags.CardIssNum, QuickFix.FXCM.Fields.Tags.PaymentDate, QuickFix.FXCM.Fields.Tags.PaymentRemitterID, 0};
            
                public NoSettlInstGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoSettlInst, QuickFix.FXCM.Fields.Tags.SettlInstID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSettlInstGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.SettlInstID SettlInstID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SettlInstID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SettlInstID val) 
                { 
                    SettlInstID = val;
                }
                
                public QuickFix.FXCM.Fields.SettlInstID Get(QuickFix.FXCM.Fields.SettlInstID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SettlInstID val) 
                { 
                    return IsSetSettlInstID();
                }
                
                public bool IsSetSettlInstID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstID);
                }
                
                public QuickFix.FXCM.Fields.SettlInstTransType SettlInstTransType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SettlInstTransType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SettlInstTransType val) 
                { 
                    SettlInstTransType = val;
                }
                
                public QuickFix.FXCM.Fields.SettlInstTransType Get(QuickFix.FXCM.Fields.SettlInstTransType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SettlInstTransType val) 
                { 
                    return IsSetSettlInstTransType();
                }
                
                public bool IsSetSettlInstTransType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstTransType);
                }
                
                public QuickFix.FXCM.Fields.SettlInstRefID SettlInstRefID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SettlInstRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SettlInstRefID val) 
                { 
                    SettlInstRefID = val;
                }
                
                public QuickFix.FXCM.Fields.SettlInstRefID Get(QuickFix.FXCM.Fields.SettlInstRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SettlInstRefID val) 
                { 
                    return IsSetSettlInstRefID();
                }
                
                public bool IsSetSettlInstRefID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstRefID);
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
                
                public QuickFix.FXCM.Fields.Side Side
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Side val) 
                { 
                    Side = val;
                }
                
                public QuickFix.FXCM.Fields.Side Get(QuickFix.FXCM.Fields.Side val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Side val) 
                { 
                    return IsSetSide();
                }
                
                public bool IsSetSide() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Side);
                }
                
                public QuickFix.FXCM.Fields.Product Product
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Product();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Product val) 
                { 
                    Product = val;
                }
                
                public QuickFix.FXCM.Fields.Product Get(QuickFix.FXCM.Fields.Product val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Product val) 
                { 
                    return IsSetProduct();
                }
                
                public bool IsSetProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Product);
                }
                
                public QuickFix.FXCM.Fields.SecurityType SecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityType val) 
                { 
                    SecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityType Get(QuickFix.FXCM.Fields.SecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityType val) 
                { 
                    return IsSetSecurityType();
                }
                
                public bool IsSetSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityType);
                }
                
                public QuickFix.FXCM.Fields.CFICode CFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CFICode val) 
                { 
                    CFICode = val;
                }
                
                public QuickFix.FXCM.Fields.CFICode Get(QuickFix.FXCM.Fields.CFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CFICode val) 
                { 
                    return IsSetCFICode();
                }
                
                public bool IsSetCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CFICode);
                }
                
                public QuickFix.FXCM.Fields.EffectiveTime EffectiveTime
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EffectiveTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EffectiveTime val) 
                { 
                    EffectiveTime = val;
                }
                
                public QuickFix.FXCM.Fields.EffectiveTime Get(QuickFix.FXCM.Fields.EffectiveTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EffectiveTime val) 
                { 
                    return IsSetEffectiveTime();
                }
                
                public bool IsSetEffectiveTime() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EffectiveTime);
                }
                
                public QuickFix.FXCM.Fields.ExpireTime ExpireTime
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ExpireTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ExpireTime val) 
                { 
                    ExpireTime = val;
                }
                
                public QuickFix.FXCM.Fields.ExpireTime Get(QuickFix.FXCM.Fields.ExpireTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ExpireTime val) 
                { 
                    return IsSetExpireTime();
                }
                
                public bool IsSetExpireTime() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ExpireTime);
                }
                
                public QuickFix.FXCM.Fields.LastUpdateTime LastUpdateTime
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LastUpdateTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LastUpdateTime val) 
                { 
                    LastUpdateTime = val;
                }
                
                public QuickFix.FXCM.Fields.LastUpdateTime Get(QuickFix.FXCM.Fields.LastUpdateTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LastUpdateTime val) 
                { 
                    return IsSetLastUpdateTime();
                }
                
                public bool IsSetLastUpdateTime() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LastUpdateTime);
                }
                
                public QuickFix.FXCM.Fields.SettlDeliveryType SettlDeliveryType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SettlDeliveryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SettlDeliveryType val) 
                { 
                    SettlDeliveryType = val;
                }
                
                public QuickFix.FXCM.Fields.SettlDeliveryType Get(QuickFix.FXCM.Fields.SettlDeliveryType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SettlDeliveryType val) 
                { 
                    return IsSetSettlDeliveryType();
                }
                
                public bool IsSetSettlDeliveryType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SettlDeliveryType);
                }
                
                public QuickFix.FXCM.Fields.StandInstDbType StandInstDbType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StandInstDbType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StandInstDbType val) 
                { 
                    StandInstDbType = val;
                }
                
                public QuickFix.FXCM.Fields.StandInstDbType Get(QuickFix.FXCM.Fields.StandInstDbType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StandInstDbType val) 
                { 
                    return IsSetStandInstDbType();
                }
                
                public bool IsSetStandInstDbType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StandInstDbType);
                }
                
                public QuickFix.FXCM.Fields.StandInstDbName StandInstDbName
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StandInstDbName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StandInstDbName val) 
                { 
                    StandInstDbName = val;
                }
                
                public QuickFix.FXCM.Fields.StandInstDbName Get(QuickFix.FXCM.Fields.StandInstDbName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StandInstDbName val) 
                { 
                    return IsSetStandInstDbName();
                }
                
                public bool IsSetStandInstDbName() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StandInstDbName);
                }
                
                public QuickFix.FXCM.Fields.StandInstDbID StandInstDbID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StandInstDbID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StandInstDbID val) 
                { 
                    StandInstDbID = val;
                }
                
                public QuickFix.FXCM.Fields.StandInstDbID Get(QuickFix.FXCM.Fields.StandInstDbID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StandInstDbID val) 
                { 
                    return IsSetStandInstDbID();
                }
                
                public bool IsSetStandInstDbID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StandInstDbID);
                }
                
                public QuickFix.FXCM.Fields.NoDlvyInst NoDlvyInst
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoDlvyInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoDlvyInst val) 
                { 
                    NoDlvyInst = val;
                }
                
                public QuickFix.FXCM.Fields.NoDlvyInst Get(QuickFix.FXCM.Fields.NoDlvyInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoDlvyInst val) 
                { 
                    return IsSetNoDlvyInst();
                }
                
                public bool IsSetNoDlvyInst() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoDlvyInst);
                }
                
                public QuickFix.FXCM.Fields.PaymentMethod PaymentMethod
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PaymentMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PaymentMethod val) 
                { 
                    PaymentMethod = val;
                }
                
                public QuickFix.FXCM.Fields.PaymentMethod Get(QuickFix.FXCM.Fields.PaymentMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PaymentMethod val) 
                { 
                    return IsSetPaymentMethod();
                }
                
                public bool IsSetPaymentMethod() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PaymentMethod);
                }
                
                public QuickFix.FXCM.Fields.PaymentRef PaymentRef
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PaymentRef();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PaymentRef val) 
                { 
                    PaymentRef = val;
                }
                
                public QuickFix.FXCM.Fields.PaymentRef Get(QuickFix.FXCM.Fields.PaymentRef val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PaymentRef val) 
                { 
                    return IsSetPaymentRef();
                }
                
                public bool IsSetPaymentRef() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PaymentRef);
                }
                
                public QuickFix.FXCM.Fields.CardHolderName CardHolderName
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CardHolderName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CardHolderName val) 
                { 
                    CardHolderName = val;
                }
                
                public QuickFix.FXCM.Fields.CardHolderName Get(QuickFix.FXCM.Fields.CardHolderName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CardHolderName val) 
                { 
                    return IsSetCardHolderName();
                }
                
                public bool IsSetCardHolderName() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CardHolderName);
                }
                
                public QuickFix.FXCM.Fields.CardNumber CardNumber
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CardNumber();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CardNumber val) 
                { 
                    CardNumber = val;
                }
                
                public QuickFix.FXCM.Fields.CardNumber Get(QuickFix.FXCM.Fields.CardNumber val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CardNumber val) 
                { 
                    return IsSetCardNumber();
                }
                
                public bool IsSetCardNumber() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CardNumber);
                }
                
                public QuickFix.FXCM.Fields.CardStartDate CardStartDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CardStartDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CardStartDate val) 
                { 
                    CardStartDate = val;
                }
                
                public QuickFix.FXCM.Fields.CardStartDate Get(QuickFix.FXCM.Fields.CardStartDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CardStartDate val) 
                { 
                    return IsSetCardStartDate();
                }
                
                public bool IsSetCardStartDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CardStartDate);
                }
                
                public QuickFix.FXCM.Fields.CardExpDate CardExpDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CardExpDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CardExpDate val) 
                { 
                    CardExpDate = val;
                }
                
                public QuickFix.FXCM.Fields.CardExpDate Get(QuickFix.FXCM.Fields.CardExpDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CardExpDate val) 
                { 
                    return IsSetCardExpDate();
                }
                
                public bool IsSetCardExpDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CardExpDate);
                }
                
                public QuickFix.FXCM.Fields.CardIssNum CardIssNum
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.CardIssNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.CardIssNum val) 
                { 
                    CardIssNum = val;
                }
                
                public QuickFix.FXCM.Fields.CardIssNum Get(QuickFix.FXCM.Fields.CardIssNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.CardIssNum val) 
                { 
                    return IsSetCardIssNum();
                }
                
                public bool IsSetCardIssNum() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.CardIssNum);
                }
                
                public QuickFix.FXCM.Fields.PaymentDate PaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PaymentDate val) 
                { 
                    PaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.PaymentDate Get(QuickFix.FXCM.Fields.PaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PaymentDate val) 
                { 
                    return IsSetPaymentDate();
                }
                
                public bool IsSetPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PaymentDate);
                }
                
                public QuickFix.FXCM.Fields.PaymentRemitterID PaymentRemitterID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PaymentRemitterID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PaymentRemitterID val) 
                { 
                    PaymentRemitterID = val;
                }
                
                public QuickFix.FXCM.Fields.PaymentRemitterID Get(QuickFix.FXCM.Fields.PaymentRemitterID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PaymentRemitterID val) 
                { 
                    return IsSetPaymentRemitterID();
                }
                
                public bool IsSetPaymentRemitterID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PaymentRemitterID);
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
                public class NoDlvyInstGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SettlInstSource, QuickFix.FXCM.Fields.Tags.DlvyInstType, QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs, 0};
                
                    public NoDlvyInstGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoDlvyInst, QuickFix.FXCM.Fields.Tags.SettlInstSource, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoDlvyInstGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.SettlInstSource SettlInstSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.SettlInstSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.SettlInstSource val) 
                    { 
                        SettlInstSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.SettlInstSource Get(QuickFix.FXCM.Fields.SettlInstSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.SettlInstSource val) 
                    { 
                        return IsSetSettlInstSource();
                    }
                    
                    public bool IsSetSettlInstSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.SettlInstSource);
                    }
                    
                    public QuickFix.FXCM.Fields.DlvyInstType DlvyInstType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.DlvyInstType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.DlvyInstType val) 
                    { 
                        DlvyInstType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.DlvyInstType Get(QuickFix.FXCM.Fields.DlvyInstType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.DlvyInstType val) 
                    { 
                        return IsSetDlvyInstType();
                    }
                    
                    public bool IsSetDlvyInstType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.DlvyInstType);
                    }
                    
                    public QuickFix.FXCM.Fields.NoSettlPartyIDs NoSettlPartyIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NoSettlPartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NoSettlPartyIDs val) 
                    { 
                        NoSettlPartyIDs = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NoSettlPartyIDs Get(QuickFix.FXCM.Fields.NoSettlPartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NoSettlPartyIDs val) 
                    { 
                        return IsSetNoSettlPartyIDs();
                    }
                    
                    public bool IsSetNoSettlPartyIDs() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs);
                    }
                    
                                    public class NoSettlPartyIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SettlPartyID, QuickFix.FXCM.Fields.Tags.SettlPartyIDSource, QuickFix.FXCM.Fields.Tags.SettlPartyRole, QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs, 0};
                    
                        public NoSettlPartyIDsGroup() 
                          :base( QuickFix.FXCM.Fields.Tags.NoSettlPartyIDs, QuickFix.FXCM.Fields.Tags.SettlPartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoSettlPartyIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.FXCM.Fields.SettlPartyID SettlPartyID
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.SettlPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.SettlPartyID val) 
                        { 
                            SettlPartyID = val;
                        }
                        
                        public QuickFix.FXCM.Fields.SettlPartyID Get(QuickFix.FXCM.Fields.SettlPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.SettlPartyID val) 
                        { 
                            return IsSetSettlPartyID();
                        }
                        
                        public bool IsSetSettlPartyID() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPartyID);
                        }
                        
                        public QuickFix.FXCM.Fields.SettlPartyIDSource SettlPartyIDSource
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.SettlPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.SettlPartyIDSource val) 
                        { 
                            SettlPartyIDSource = val;
                        }
                        
                        public QuickFix.FXCM.Fields.SettlPartyIDSource Get(QuickFix.FXCM.Fields.SettlPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.SettlPartyIDSource val) 
                        { 
                            return IsSetSettlPartyIDSource();
                        }
                        
                        public bool IsSetSettlPartyIDSource() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPartyIDSource);
                        }
                        
                        public QuickFix.FXCM.Fields.SettlPartyRole SettlPartyRole
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.SettlPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.SettlPartyRole val) 
                        { 
                            SettlPartyRole = val;
                        }
                        
                        public QuickFix.FXCM.Fields.SettlPartyRole Get(QuickFix.FXCM.Fields.SettlPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.SettlPartyRole val) 
                        { 
                            return IsSetSettlPartyRole();
                        }
                        
                        public bool IsSetSettlPartyRole() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPartyRole);
                        }
                        
                        public QuickFix.FXCM.Fields.NoSettlPartySubIDs NoSettlPartySubIDs
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NoSettlPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NoSettlPartySubIDs val) 
                        { 
                            NoSettlPartySubIDs = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NoSettlPartySubIDs Get(QuickFix.FXCM.Fields.NoSettlPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NoSettlPartySubIDs val) 
                        { 
                            return IsSetNoSettlPartySubIDs();
                        }
                        
                        public bool IsSetNoSettlPartySubIDs() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs);
                        }
                        
                                            public class NoSettlPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SettlPartySubID, QuickFix.FXCM.Fields.Tags.SettlPartySubIDType, 0};
                        
                            public NoSettlPartySubIDsGroup() 
                              :base( QuickFix.FXCM.Fields.Tags.NoSettlPartySubIDs, QuickFix.FXCM.Fields.Tags.SettlPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoSettlPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.FXCM.Fields.SettlPartySubID SettlPartySubID
                            { 
                                get 
                                {
                                    var val = new QuickFix.FXCM.Fields.SettlPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.FXCM.Fields.SettlPartySubID val) 
                            { 
                                SettlPartySubID = val;
                            }
                            
                            public QuickFix.FXCM.Fields.SettlPartySubID Get(QuickFix.FXCM.Fields.SettlPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.FXCM.Fields.SettlPartySubID val) 
                            { 
                                return IsSetSettlPartySubID();
                            }
                            
                            public bool IsSetSettlPartySubID() 
                            { 
                                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPartySubID);
                            }
                            
                            public QuickFix.FXCM.Fields.SettlPartySubIDType SettlPartySubIDType
                            { 
                                get 
                                {
                                    var val = new QuickFix.FXCM.Fields.SettlPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.FXCM.Fields.SettlPartySubIDType val) 
                            { 
                                SettlPartySubIDType = val;
                            }
                            
                            public QuickFix.FXCM.Fields.SettlPartySubIDType Get(QuickFix.FXCM.Fields.SettlPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.FXCM.Fields.SettlPartySubIDType val) 
                            { 
                                return IsSetSettlPartySubIDType();
                            }
                            
                            public bool IsSetSettlPartySubIDType() 
                            { 
                                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPartySubIDType);
                            }
                            
                        
                        }
                    }
                }
            }
    }
}

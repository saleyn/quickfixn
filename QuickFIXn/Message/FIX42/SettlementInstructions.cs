// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class SettlementInstructions : Message
    {
            public const string MsgType = "T";

            public SettlementInstructions() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("T"));
            }

            public SettlementInstructions(
                    QuickFix.Fields.SettlInstID aSettlInstID,
                    QuickFix.Fields.SettlInstTransType aSettlInstTransType,
                    QuickFix.Fields.SettlInstRefID aSettlInstRefID,
                    QuickFix.Fields.SettlInstMode aSettlInstMode,
                    QuickFix.Fields.SettlInstSource aSettlInstSource,
                    QuickFix.Fields.AllocAccount aAllocAccount,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.SettlInstID = aSettlInstID;
                this.SettlInstTransType = aSettlInstTransType;
                this.SettlInstRefID = aSettlInstRefID;
                this.SettlInstMode = aSettlInstMode;
                this.SettlInstSource = aSettlInstSource;
                this.AllocAccount = aAllocAccount;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.Fields.SettlInstID SettlInstID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlInstID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstID val) 
            { 
                SettlInstID = val;
            }
            
            public QuickFix.Fields.SettlInstID Get(QuickFix.Fields.SettlInstID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstID val) 
            { 
                return IsSetSettlInstID();
            }
            
            public bool IsSetSettlInstID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlInstID);
            }
            
            public QuickFix.Fields.SettlInstTransType SettlInstTransType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlInstTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstTransType val) 
            { 
                SettlInstTransType = val;
            }
            
            public QuickFix.Fields.SettlInstTransType Get(QuickFix.Fields.SettlInstTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstTransType val) 
            { 
                return IsSetSettlInstTransType();
            }
            
            public bool IsSetSettlInstTransType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlInstTransType);
            }
            
            public QuickFix.Fields.SettlInstRefID SettlInstRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlInstRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstRefID val) 
            { 
                SettlInstRefID = val;
            }
            
            public QuickFix.Fields.SettlInstRefID Get(QuickFix.Fields.SettlInstRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstRefID val) 
            { 
                return IsSetSettlInstRefID();
            }
            
            public bool IsSetSettlInstRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlInstRefID);
            }
            
            public QuickFix.Fields.SettlInstMode SettlInstMode
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlInstMode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstMode val) 
            { 
                SettlInstMode = val;
            }
            
            public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstMode val) 
            { 
                return IsSetSettlInstMode();
            }
            
            public bool IsSetSettlInstMode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlInstMode);
            }
            
            public QuickFix.Fields.SettlInstSource SettlInstSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlInstSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstSource val) 
            { 
                SettlInstSource = val;
            }
            
            public QuickFix.Fields.SettlInstSource Get(QuickFix.Fields.SettlInstSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstSource val) 
            { 
                return IsSetSettlInstSource();
            }
            
            public bool IsSetSettlInstSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlInstSource);
            }
            
            public QuickFix.Fields.AllocAccount AllocAccount
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocAccount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocAccount val) 
            { 
                AllocAccount = val;
            }
            
            public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocAccount val) 
            { 
                return IsSetAllocAccount();
            }
            
            public bool IsSetAllocAccount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocAccount);
            }
            
            public QuickFix.Fields.SettlLocation SettlLocation
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlLocation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlLocation val) 
            { 
                SettlLocation = val;
            }
            
            public QuickFix.Fields.SettlLocation Get(QuickFix.Fields.SettlLocation val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlLocation val) 
            { 
                return IsSetSettlLocation();
            }
            
            public bool IsSetSettlLocation() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlLocation);
            }
            
            public QuickFix.Fields.TradeDate TradeDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                TradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeDate);
            }
            
            public QuickFix.Fields.AllocID AllocID
            { 
                get 
                {
                    var val = new QuickFix.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocID val) 
            { 
                AllocID = val;
            }
            
            public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AllocID);
            }
            
            public QuickFix.Fields.LastMkt LastMkt
            { 
                get 
                {
                    var val = new QuickFix.Fields.LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastMkt val) 
            { 
                LastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LastMkt);
            }
            
            public QuickFix.Fields.TradingSessionID TradingSessionID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSessionID val) 
            { 
                TradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return IsSetTradingSessionID();
            }
            
            public bool IsSetTradingSessionID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradingSessionID);
            }
            
            public QuickFix.Fields.Side Side
            { 
                get 
                {
                    var val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Side val) 
            { 
                Side = val;
            }
            
            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Side val) 
            { 
                return IsSetSide();
            }
            
            public bool IsSetSide() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Side);
            }
            
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityType);
            }
            
            public QuickFix.Fields.EffectiveTime EffectiveTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.EffectiveTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EffectiveTime val) 
            { 
                EffectiveTime = val;
            }
            
            public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EffectiveTime val) 
            { 
                return IsSetEffectiveTime();
            }
            
            public bool IsSetEffectiveTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EffectiveTime);
            }
            
            public QuickFix.Fields.TransactTime TransactTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                TransactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TransactTime);
            }
            
            public QuickFix.Fields.ClientID ClientID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClientID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientID val) 
            { 
                ClientID = val;
            }
            
            public QuickFix.Fields.ClientID Get(QuickFix.Fields.ClientID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientID val) 
            { 
                return IsSetClientID();
            }
            
            public bool IsSetClientID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClientID);
            }
            
            public QuickFix.Fields.ExecBroker ExecBroker
            { 
                get 
                {
                    var val = new QuickFix.Fields.ExecBroker();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecBroker val) 
            { 
                ExecBroker = val;
            }
            
            public QuickFix.Fields.ExecBroker Get(QuickFix.Fields.ExecBroker val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecBroker val) 
            { 
                return IsSetExecBroker();
            }
            
            public bool IsSetExecBroker() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ExecBroker);
            }
            
            public QuickFix.Fields.StandInstDbType StandInstDbType
            { 
                get 
                {
                    var val = new QuickFix.Fields.StandInstDbType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StandInstDbType val) 
            { 
                StandInstDbType = val;
            }
            
            public QuickFix.Fields.StandInstDbType Get(QuickFix.Fields.StandInstDbType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StandInstDbType val) 
            { 
                return IsSetStandInstDbType();
            }
            
            public bool IsSetStandInstDbType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StandInstDbType);
            }
            
            public QuickFix.Fields.StandInstDbName StandInstDbName
            { 
                get 
                {
                    var val = new QuickFix.Fields.StandInstDbName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StandInstDbName val) 
            { 
                StandInstDbName = val;
            }
            
            public QuickFix.Fields.StandInstDbName Get(QuickFix.Fields.StandInstDbName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StandInstDbName val) 
            { 
                return IsSetStandInstDbName();
            }
            
            public bool IsSetStandInstDbName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StandInstDbName);
            }
            
            public QuickFix.Fields.StandInstDbID StandInstDbID
            { 
                get 
                {
                    var val = new QuickFix.Fields.StandInstDbID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StandInstDbID val) 
            { 
                StandInstDbID = val;
            }
            
            public QuickFix.Fields.StandInstDbID Get(QuickFix.Fields.StandInstDbID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StandInstDbID val) 
            { 
                return IsSetStandInstDbID();
            }
            
            public bool IsSetStandInstDbID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StandInstDbID);
            }
            
            public QuickFix.Fields.SettlDeliveryType SettlDeliveryType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlDeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDeliveryType val) 
            { 
                SettlDeliveryType = val;
            }
            
            public QuickFix.Fields.SettlDeliveryType Get(QuickFix.Fields.SettlDeliveryType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDeliveryType val) 
            { 
                return IsSetSettlDeliveryType();
            }
            
            public bool IsSetSettlDeliveryType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlDeliveryType);
            }
            
            public QuickFix.Fields.SettlDepositoryCode SettlDepositoryCode
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlDepositoryCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                SettlDepositoryCode = val;
            }
            
            public QuickFix.Fields.SettlDepositoryCode Get(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDepositoryCode val) 
            { 
                return IsSetSettlDepositoryCode();
            }
            
            public bool IsSetSettlDepositoryCode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlDepositoryCode);
            }
            
            public QuickFix.Fields.SettlBrkrCode SettlBrkrCode
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlBrkrCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlBrkrCode val) 
            { 
                SettlBrkrCode = val;
            }
            
            public QuickFix.Fields.SettlBrkrCode Get(QuickFix.Fields.SettlBrkrCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlBrkrCode val) 
            { 
                return IsSetSettlBrkrCode();
            }
            
            public bool IsSetSettlBrkrCode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlBrkrCode);
            }
            
            public QuickFix.Fields.SettlInstCode SettlInstCode
            { 
                get 
                {
                    var val = new QuickFix.Fields.SettlInstCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlInstCode val) 
            { 
                SettlInstCode = val;
            }
            
            public QuickFix.Fields.SettlInstCode Get(QuickFix.Fields.SettlInstCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlInstCode val) 
            { 
                return IsSetSettlInstCode();
            }
            
            public bool IsSetSettlInstCode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SettlInstCode);
            }
            
            public QuickFix.Fields.SecuritySettlAgentName SecuritySettlAgentName
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySettlAgentName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                SecuritySettlAgentName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentName Get(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentName val) 
            { 
                return IsSetSecuritySettlAgentName();
            }
            
            public bool IsSetSecuritySettlAgentName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySettlAgentName);
            }
            
            public QuickFix.Fields.SecuritySettlAgentCode SecuritySettlAgentCode
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySettlAgentCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                SecuritySettlAgentCode = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentCode Get(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentCode val) 
            { 
                return IsSetSecuritySettlAgentCode();
            }
            
            public bool IsSetSecuritySettlAgentCode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySettlAgentCode);
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctNum SecuritySettlAgentAcctNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySettlAgentAcctNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                SecuritySettlAgentAcctNum = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctNum Get(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentAcctNum val) 
            { 
                return IsSetSecuritySettlAgentAcctNum();
            }
            
            public bool IsSetSecuritySettlAgentAcctNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySettlAgentAcctNum);
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctName SecuritySettlAgentAcctName
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySettlAgentAcctName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                SecuritySettlAgentAcctName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentAcctName Get(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentAcctName val) 
            { 
                return IsSetSecuritySettlAgentAcctName();
            }
            
            public bool IsSetSecuritySettlAgentAcctName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySettlAgentAcctName);
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactName SecuritySettlAgentContactName
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySettlAgentContactName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                SecuritySettlAgentContactName = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactName Get(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentContactName val) 
            { 
                return IsSetSecuritySettlAgentContactName();
            }
            
            public bool IsSetSecuritySettlAgentContactName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySettlAgentContactName);
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactPhone SecuritySettlAgentContactPhone
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySettlAgentContactPhone();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                SecuritySettlAgentContactPhone = val;
            }
            
            public QuickFix.Fields.SecuritySettlAgentContactPhone Get(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySettlAgentContactPhone val) 
            { 
                return IsSetSecuritySettlAgentContactPhone();
            }
            
            public bool IsSetSecuritySettlAgentContactPhone() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySettlAgentContactPhone);
            }
            
            public QuickFix.Fields.CashSettlAgentName CashSettlAgentName
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashSettlAgentName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentName val) 
            { 
                CashSettlAgentName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentName Get(QuickFix.Fields.CashSettlAgentName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentName val) 
            { 
                return IsSetCashSettlAgentName();
            }
            
            public bool IsSetCashSettlAgentName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashSettlAgentName);
            }
            
            public QuickFix.Fields.CashSettlAgentCode CashSettlAgentCode
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashSettlAgentCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                CashSettlAgentCode = val;
            }
            
            public QuickFix.Fields.CashSettlAgentCode Get(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentCode val) 
            { 
                return IsSetCashSettlAgentCode();
            }
            
            public bool IsSetCashSettlAgentCode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashSettlAgentCode);
            }
            
            public QuickFix.Fields.CashSettlAgentAcctNum CashSettlAgentAcctNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashSettlAgentAcctNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                CashSettlAgentAcctNum = val;
            }
            
            public QuickFix.Fields.CashSettlAgentAcctNum Get(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentAcctNum val) 
            { 
                return IsSetCashSettlAgentAcctNum();
            }
            
            public bool IsSetCashSettlAgentAcctNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashSettlAgentAcctNum);
            }
            
            public QuickFix.Fields.CashSettlAgentAcctName CashSettlAgentAcctName
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashSettlAgentAcctName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                CashSettlAgentAcctName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentAcctName Get(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentAcctName val) 
            { 
                return IsSetCashSettlAgentAcctName();
            }
            
            public bool IsSetCashSettlAgentAcctName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashSettlAgentAcctName);
            }
            
            public QuickFix.Fields.CashSettlAgentContactName CashSettlAgentContactName
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashSettlAgentContactName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                CashSettlAgentContactName = val;
            }
            
            public QuickFix.Fields.CashSettlAgentContactName Get(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentContactName val) 
            { 
                return IsSetCashSettlAgentContactName();
            }
            
            public bool IsSetCashSettlAgentContactName() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashSettlAgentContactName);
            }
            
            public QuickFix.Fields.CashSettlAgentContactPhone CashSettlAgentContactPhone
            { 
                get 
                {
                    var val = new QuickFix.Fields.CashSettlAgentContactPhone();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                CashSettlAgentContactPhone = val;
            }
            
            public QuickFix.Fields.CashSettlAgentContactPhone Get(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashSettlAgentContactPhone val) 
            { 
                return IsSetCashSettlAgentContactPhone();
            }
            
            public bool IsSetCashSettlAgentContactPhone() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CashSettlAgentContactPhone);
            }
            

    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class Confirmation : Message
    {
            public const string MsgType = "AK";

            public Confirmation() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("AK"));
            }

            public Confirmation(
                    QuickFix.FXCM.Fields.ConfirmID aConfirmID,
                    QuickFix.FXCM.Fields.ConfirmTransType aConfirmTransType,
                    QuickFix.FXCM.Fields.ConfirmType aConfirmType,
                    QuickFix.FXCM.Fields.ConfirmStatus aConfirmStatus,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime,
                    QuickFix.FXCM.Fields.TradeDate aTradeDate,
                    QuickFix.FXCM.Fields.Symbol aSymbol,
                    QuickFix.FXCM.Fields.AllocQty aAllocQty,
                    QuickFix.FXCM.Fields.Side aSide,
                    QuickFix.FXCM.Fields.AllocAccount aAllocAccount,
                    QuickFix.FXCM.Fields.AvgPx aAvgPx,
                    QuickFix.FXCM.Fields.GrossTradeAmt aGrossTradeAmt,
                    QuickFix.FXCM.Fields.NetMoney aNetMoney
                ) : this()
            {
                this.ConfirmID = aConfirmID;
                this.ConfirmTransType = aConfirmTransType;
                this.ConfirmType = aConfirmType;
                this.ConfirmStatus = aConfirmStatus;
                this.TransactTime = aTransactTime;
                this.TradeDate = aTradeDate;
                this.Symbol = aSymbol;
                this.AllocQty = aAllocQty;
                this.Side = aSide;
                this.AllocAccount = aAllocAccount;
                this.AvgPx = aAvgPx;
                this.GrossTradeAmt = aGrossTradeAmt;
                this.NetMoney = aNetMoney;
            }

            public QuickFix.FXCM.Fields.ConfirmID ConfirmID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmID val) 
            { 
                ConfirmID = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmID Get(QuickFix.FXCM.Fields.ConfirmID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmID val) 
            { 
                return IsSetConfirmID();
            }
            
            public bool IsSetConfirmID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmID);
            }
            
            public QuickFix.FXCM.Fields.ConfirmRefID ConfirmRefID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmRefID val) 
            { 
                ConfirmRefID = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmRefID Get(QuickFix.FXCM.Fields.ConfirmRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmRefID val) 
            { 
                return IsSetConfirmRefID();
            }
            
            public bool IsSetConfirmRefID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmRefID);
            }
            
            public QuickFix.FXCM.Fields.ConfirmReqID ConfirmReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmReqID val) 
            { 
                ConfirmReqID = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmReqID Get(QuickFix.FXCM.Fields.ConfirmReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmReqID val) 
            { 
                return IsSetConfirmReqID();
            }
            
            public bool IsSetConfirmReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmReqID);
            }
            
            public QuickFix.FXCM.Fields.ConfirmTransType ConfirmTransType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmTransType val) 
            { 
                ConfirmTransType = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmTransType Get(QuickFix.FXCM.Fields.ConfirmTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmTransType val) 
            { 
                return IsSetConfirmTransType();
            }
            
            public bool IsSetConfirmTransType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmTransType);
            }
            
            public QuickFix.FXCM.Fields.ConfirmType ConfirmType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmType val) 
            { 
                ConfirmType = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmType Get(QuickFix.FXCM.Fields.ConfirmType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmType val) 
            { 
                return IsSetConfirmType();
            }
            
            public bool IsSetConfirmType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmType);
            }
            
            public QuickFix.FXCM.Fields.CopyMsgIndicator CopyMsgIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CopyMsgIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CopyMsgIndicator val) 
            { 
                CopyMsgIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.CopyMsgIndicator Get(QuickFix.FXCM.Fields.CopyMsgIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CopyMsgIndicator val) 
            { 
                return IsSetCopyMsgIndicator();
            }
            
            public bool IsSetCopyMsgIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CopyMsgIndicator);
            }
            
            public QuickFix.FXCM.Fields.LegalConfirm LegalConfirm
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LegalConfirm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LegalConfirm val) 
            { 
                LegalConfirm = val;
            }
            
            public QuickFix.FXCM.Fields.LegalConfirm Get(QuickFix.FXCM.Fields.LegalConfirm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LegalConfirm val) 
            { 
                return IsSetLegalConfirm();
            }
            
            public bool IsSetLegalConfirm() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LegalConfirm);
            }
            
            public QuickFix.FXCM.Fields.ConfirmStatus ConfirmStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmStatus val) 
            { 
                ConfirmStatus = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmStatus Get(QuickFix.FXCM.Fields.ConfirmStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmStatus val) 
            { 
                return IsSetConfirmStatus();
            }
            
            public bool IsSetConfirmStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmStatus);
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
            
            public QuickFix.FXCM.Fields.NoOrders NoOrders
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoOrders val) 
            { 
                NoOrders = val;
            }
            
            public QuickFix.FXCM.Fields.NoOrders Get(QuickFix.FXCM.Fields.NoOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoOrders val) 
            { 
                return IsSetNoOrders();
            }
            
            public bool IsSetNoOrders() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoOrders);
            }
            
            public QuickFix.FXCM.Fields.AllocID AllocID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocID val) 
            { 
                AllocID = val;
            }
            
            public QuickFix.FXCM.Fields.AllocID Get(QuickFix.FXCM.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryAllocID SecondaryAllocID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryAllocID val) 
            { 
                SecondaryAllocID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryAllocID Get(QuickFix.FXCM.Fields.SecondaryAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryAllocID val) 
            { 
                return IsSetSecondaryAllocID();
            }
            
            public bool IsSetSecondaryAllocID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryAllocID);
            }
            
            public QuickFix.FXCM.Fields.IndividualAllocID IndividualAllocID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.IndividualAllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.IndividualAllocID val) 
            { 
                IndividualAllocID = val;
            }
            
            public QuickFix.FXCM.Fields.IndividualAllocID Get(QuickFix.FXCM.Fields.IndividualAllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.IndividualAllocID val) 
            { 
                return IsSetIndividualAllocID();
            }
            
            public bool IsSetIndividualAllocID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.IndividualAllocID);
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
            
            public QuickFix.FXCM.Fields.TradeDate TradeDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                TradeDate = val;
            }
            
            public QuickFix.FXCM.Fields.TradeDate Get(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradeDate);
            }
            
            public QuickFix.FXCM.Fields.NoTrdRegTimestamps NoTrdRegTimestamps
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoTrdRegTimestamps();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoTrdRegTimestamps val) 
            { 
                NoTrdRegTimestamps = val;
            }
            
            public QuickFix.FXCM.Fields.NoTrdRegTimestamps Get(QuickFix.FXCM.Fields.NoTrdRegTimestamps val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoTrdRegTimestamps val) 
            { 
                return IsSetNoTrdRegTimestamps();
            }
            
            public bool IsSetNoTrdRegTimestamps() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps);
            }
            
            public QuickFix.FXCM.Fields.Symbol Symbol
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Symbol val) 
            { 
                Symbol = val;
            }
            
            public QuickFix.FXCM.Fields.Symbol Get(QuickFix.FXCM.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Symbol);
            }
            
            public QuickFix.FXCM.Fields.SymbolSfx SymbolSfx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                SymbolSfx = val;
            }
            
            public QuickFix.FXCM.Fields.SymbolSfx Get(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SymbolSfx);
            }
            
            public QuickFix.FXCM.Fields.SecurityID SecurityID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                SecurityID = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityID Get(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityID);
            }
            
            public QuickFix.FXCM.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                SecurityIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityIDSource Get(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityIDSource);
            }
            
            public QuickFix.FXCM.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                NoSecurityAltID = val;
            }
            
            public QuickFix.FXCM.Fields.NoSecurityAltID Get(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoSecurityAltID);
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
            
            public QuickFix.FXCM.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                SecuritySubType = val;
            }
            
            public QuickFix.FXCM.Fields.SecuritySubType Get(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecuritySubType);
            }
            
            public QuickFix.FXCM.Fields.MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                MaturityMonthYear = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityMonthYear Get(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityMonthYear);
            }
            
            public QuickFix.FXCM.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                MaturityDate = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityDate Get(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityDate);
            }
            
            public QuickFix.FXCM.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                CouponPaymentDate = val;
            }
            
            public QuickFix.FXCM.Fields.CouponPaymentDate Get(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CouponPaymentDate);
            }
            
            public QuickFix.FXCM.Fields.IssueDate IssueDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                IssueDate = val;
            }
            
            public QuickFix.FXCM.Fields.IssueDate Get(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.IssueDate);
            }
            
            public QuickFix.FXCM.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                RepoCollateralSecurityType = val;
            }
            
            public QuickFix.FXCM.Fields.RepoCollateralSecurityType Get(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepoCollateralSecurityType);
            }
            
            public QuickFix.FXCM.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                RepurchaseTerm = val;
            }
            
            public QuickFix.FXCM.Fields.RepurchaseTerm Get(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepurchaseTerm);
            }
            
            public QuickFix.FXCM.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                RepurchaseRate = val;
            }
            
            public QuickFix.FXCM.Fields.RepurchaseRate Get(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RepurchaseRate);
            }
            
            public QuickFix.FXCM.Fields.Factor Factor
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Factor val) 
            { 
                Factor = val;
            }
            
            public QuickFix.FXCM.Fields.Factor Get(QuickFix.FXCM.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Factor);
            }
            
            public QuickFix.FXCM.Fields.CreditRating CreditRating
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                CreditRating = val;
            }
            
            public QuickFix.FXCM.Fields.CreditRating Get(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CreditRating);
            }
            
            public QuickFix.FXCM.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                InstrRegistry = val;
            }
            
            public QuickFix.FXCM.Fields.InstrRegistry Get(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InstrRegistry);
            }
            
            public QuickFix.FXCM.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                CountryOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.CountryOfIssue Get(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CountryOfIssue);
            }
            
            public QuickFix.FXCM.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.StateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StateOrProvinceOfIssue);
            }
            
            public QuickFix.FXCM.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                LocaleOfIssue = val;
            }
            
            public QuickFix.FXCM.Fields.LocaleOfIssue Get(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LocaleOfIssue);
            }
            
            public QuickFix.FXCM.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                RedemptionDate = val;
            }
            
            public QuickFix.FXCM.Fields.RedemptionDate Get(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RedemptionDate);
            }
            
            public QuickFix.FXCM.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                StrikePrice = val;
            }
            
            public QuickFix.FXCM.Fields.StrikePrice Get(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikePrice);
            }
            
            public QuickFix.FXCM.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                StrikeCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.StrikeCurrency Get(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StrikeCurrency);
            }
            
            public QuickFix.FXCM.Fields.OptAttribute OptAttribute
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                OptAttribute = val;
            }
            
            public QuickFix.FXCM.Fields.OptAttribute Get(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OptAttribute);
            }
            
            public QuickFix.FXCM.Fields.ContractMultiplier ContractMultiplier
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                ContractMultiplier = val;
            }
            
            public QuickFix.FXCM.Fields.ContractMultiplier Get(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContractMultiplier);
            }
            
            public QuickFix.FXCM.Fields.CouponRate CouponRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                CouponRate = val;
            }
            
            public QuickFix.FXCM.Fields.CouponRate Get(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CouponRate);
            }
            
            public QuickFix.FXCM.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                SecurityExchange = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityExchange Get(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityExchange);
            }
            
            public QuickFix.FXCM.Fields.Issuer Issuer
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Issuer val) 
            { 
                Issuer = val;
            }
            
            public QuickFix.FXCM.Fields.Issuer Get(QuickFix.FXCM.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Issuer);
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuerLen EncodedIssuerLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                EncodedIssuerLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuerLen Get(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedIssuerLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuer EncodedIssuer
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                EncodedIssuer = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedIssuer Get(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedIssuer);
            }
            
            public QuickFix.FXCM.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                SecurityDesc = val;
            }
            
            public QuickFix.FXCM.Fields.SecurityDesc Get(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityDesc);
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                EncodedSecurityDescLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedSecurityDescLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDesc EncodedSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                EncodedSecurityDesc = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedSecurityDesc Get(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedSecurityDesc);
            }
            
            public QuickFix.FXCM.Fields.Pool Pool
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Pool val) 
            { 
                Pool = val;
            }
            
            public QuickFix.FXCM.Fields.Pool Get(QuickFix.FXCM.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Pool);
            }
            
            public QuickFix.FXCM.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                ContractSettlMonth = val;
            }
            
            public QuickFix.FXCM.Fields.ContractSettlMonth Get(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ContractSettlMonth);
            }
            
            public QuickFix.FXCM.Fields.CPProgram CPProgram
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                CPProgram = val;
            }
            
            public QuickFix.FXCM.Fields.CPProgram Get(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CPProgram);
            }
            
            public QuickFix.FXCM.Fields.CPRegType CPRegType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                CPRegType = val;
            }
            
            public QuickFix.FXCM.Fields.CPRegType Get(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CPRegType);
            }
            
            public QuickFix.FXCM.Fields.NoEvents NoEvents
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                NoEvents = val;
            }
            
            public QuickFix.FXCM.Fields.NoEvents Get(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoEvents);
            }
            
            public QuickFix.FXCM.Fields.DatedDate DatedDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                DatedDate = val;
            }
            
            public QuickFix.FXCM.Fields.DatedDate Get(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DatedDate);
            }
            
            public QuickFix.FXCM.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                InterestAccrualDate = val;
            }
            
            public QuickFix.FXCM.Fields.InterestAccrualDate Get(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InterestAccrualDate);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymID FXCMSymID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                FXCMSymID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymID Get(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymID val) 
            { 
                return IsSetFXCMSymID();
            }
            
            public bool IsSetFXCMSymID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymID);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPrecision FXCMSymPrecision
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                FXCMSymPrecision = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPrecision Get(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymPrecision val) 
            { 
                return IsSetFXCMSymPrecision();
            }
            
            public bool IsSetFXCMSymPrecision() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymPrecision);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPointSize FXCMSymPointSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymPointSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                FXCMSymPointSize = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymPointSize Get(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymPointSize val) 
            { 
                return IsSetFXCMSymPointSize();
            }
            
            public bool IsSetFXCMSymPointSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymPointSize);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymSortOrder FXCMSymSortOrder
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymSortOrder();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                FXCMSymSortOrder = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymSortOrder Get(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymSortOrder val) 
            { 
                return IsSetFXCMSymSortOrder();
            }
            
            public bool IsSetFXCMSymSortOrder() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymSortOrder);
            }
            
            public QuickFix.FXCM.Fields.FXCMProductID FXCMProductID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMProductID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                FXCMProductID = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMProductID Get(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMProductID val) 
            { 
                return IsSetFXCMProductID();
            }
            
            public bool IsSetFXCMProductID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMProductID);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymMarginRatio FXCMSymMarginRatio
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymMarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                FXCMSymMarginRatio = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymMarginRatio Get(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymMarginRatio val) 
            { 
                return IsSetFXCMSymMarginRatio();
            }
            
            public bool IsSetFXCMSymMarginRatio() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymMarginRatio);
            }
            
            public QuickFix.FXCM.Fields.Ccy Ccy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Ccy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Ccy val) 
            { 
                Ccy = val;
            }
            
            public QuickFix.FXCM.Fields.Ccy Get(QuickFix.FXCM.Fields.Ccy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Ccy val) 
            { 
                return IsSetCcy();
            }
            
            public bool IsSetCcy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Ccy);
            }
            
            public QuickFix.FXCM.Fields.RndLot RndLot
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RndLot();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RndLot val) 
            { 
                RndLot = val;
            }
            
            public QuickFix.FXCM.Fields.RndLot Get(QuickFix.FXCM.Fields.RndLot val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RndLot val) 
            { 
                return IsSetRndLot();
            }
            
            public bool IsSetRndLot() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RndLot);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestBuy FXCMSymInterestBuy
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymInterestBuy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                FXCMSymInterestBuy = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestBuy Get(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymInterestBuy val) 
            { 
                return IsSetFXCMSymInterestBuy();
            }
            
            public bool IsSetFXCMSymInterestBuy() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymInterestBuy);
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestSell FXCMSymInterestSell
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSymInterestSell();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                FXCMSymInterestSell = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSymInterestSell Get(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSymInterestSell val) 
            { 
                return IsSetFXCMSymInterestSell();
            }
            
            public bool IsSetFXCMSymInterestSell() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSymInterestSell);
            }
            
            public QuickFix.FXCM.Fields.FXCMSubscriptionStatus FXCMSubscriptionStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMSubscriptionStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                FXCMSubscriptionStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMSubscriptionStatus Get(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMSubscriptionStatus val) 
            { 
                return IsSetFXCMSubscriptionStatus();
            }
            
            public bool IsSetFXCMSubscriptionStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMSubscriptionStatus);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistStop FXCMCondDistStop
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistStop();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                FXCMCondDistStop = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistStop Get(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistStop val) 
            { 
                return IsSetFXCMCondDistStop();
            }
            
            public bool IsSetFXCMCondDistStop() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistStop);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistLimit FXCMCondDistLimit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                FXCMCondDistLimit = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistLimit Get(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistLimit val) 
            { 
                return IsSetFXCMCondDistLimit();
            }
            
            public bool IsSetFXCMCondDistLimit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistLimit);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryStop FXCMCondDistEntryStop
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistEntryStop();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                FXCMCondDistEntryStop = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryStop Get(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistEntryStop val) 
            { 
                return IsSetFXCMCondDistEntryStop();
            }
            
            public bool IsSetFXCMCondDistEntryStop() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistEntryStop);
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryLimit FXCMCondDistEntryLimit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMCondDistEntryLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                FXCMCondDistEntryLimit = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMCondDistEntryLimit Get(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMCondDistEntryLimit val) 
            { 
                return IsSetFXCMCondDistEntryLimit();
            }
            
            public bool IsSetFXCMCondDistEntryLimit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMCondDistEntryLimit);
            }
            
            public QuickFix.FXCM.Fields.FXCMMaxQuantity FXCMMaxQuantity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMMaxQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                FXCMMaxQuantity = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMMaxQuantity Get(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMMaxQuantity val) 
            { 
                return IsSetFXCMMaxQuantity();
            }
            
            public bool IsSetFXCMMaxQuantity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMMaxQuantity);
            }
            
            public QuickFix.FXCM.Fields.FXCMMinQuantity FXCMMinQuantity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMMinQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                FXCMMinQuantity = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMMinQuantity Get(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMMinQuantity val) 
            { 
                return IsSetFXCMMinQuantity();
            }
            
            public bool IsSetFXCMMinQuantity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMMinQuantity);
            }
            
            public QuickFix.FXCM.Fields.FXCMTradingStatus FXCMTradingStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMTradingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                FXCMTradingStatus = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMTradingStatus Get(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMTradingStatus val) 
            { 
                return IsSetFXCMTradingStatus();
            }
            
            public bool IsSetFXCMTradingStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMTradingStatus);
            }
            
            public QuickFix.FXCM.Fields.DeliveryForm DeliveryForm
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DeliveryForm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DeliveryForm val) 
            { 
                DeliveryForm = val;
            }
            
            public QuickFix.FXCM.Fields.DeliveryForm Get(QuickFix.FXCM.Fields.DeliveryForm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DeliveryForm val) 
            { 
                return IsSetDeliveryForm();
            }
            
            public bool IsSetDeliveryForm() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DeliveryForm);
            }
            
            public QuickFix.FXCM.Fields.PctAtRisk PctAtRisk
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PctAtRisk();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PctAtRisk val) 
            { 
                PctAtRisk = val;
            }
            
            public QuickFix.FXCM.Fields.PctAtRisk Get(QuickFix.FXCM.Fields.PctAtRisk val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PctAtRisk val) 
            { 
                return IsSetPctAtRisk();
            }
            
            public bool IsSetPctAtRisk() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PctAtRisk);
            }
            
            public QuickFix.FXCM.Fields.NoInstrAttrib NoInstrAttrib
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoInstrAttrib();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoInstrAttrib val) 
            { 
                NoInstrAttrib = val;
            }
            
            public QuickFix.FXCM.Fields.NoInstrAttrib Get(QuickFix.FXCM.Fields.NoInstrAttrib val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoInstrAttrib val) 
            { 
                return IsSetNoInstrAttrib();
            }
            
            public bool IsSetNoInstrAttrib() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoInstrAttrib);
            }
            
            public QuickFix.FXCM.Fields.AgreementDesc AgreementDesc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                AgreementDesc = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementDesc Get(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementDesc val) 
            { 
                return IsSetAgreementDesc();
            }
            
            public bool IsSetAgreementDesc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementDesc);
            }
            
            public QuickFix.FXCM.Fields.AgreementID AgreementID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                AgreementID = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementID Get(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementID val) 
            { 
                return IsSetAgreementID();
            }
            
            public bool IsSetAgreementID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementID);
            }
            
            public QuickFix.FXCM.Fields.AgreementDate AgreementDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                AgreementDate = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementDate Get(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementDate val) 
            { 
                return IsSetAgreementDate();
            }
            
            public bool IsSetAgreementDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementDate);
            }
            
            public QuickFix.FXCM.Fields.AgreementCurrency AgreementCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AgreementCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                AgreementCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.AgreementCurrency Get(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AgreementCurrency val) 
            { 
                return IsSetAgreementCurrency();
            }
            
            public bool IsSetAgreementCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AgreementCurrency);
            }
            
            public QuickFix.FXCM.Fields.TerminationType TerminationType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TerminationType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                TerminationType = val;
            }
            
            public QuickFix.FXCM.Fields.TerminationType Get(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TerminationType val) 
            { 
                return IsSetTerminationType();
            }
            
            public bool IsSetTerminationType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TerminationType);
            }
            
            public QuickFix.FXCM.Fields.StartDate StartDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StartDate val) 
            { 
                StartDate = val;
            }
            
            public QuickFix.FXCM.Fields.StartDate Get(QuickFix.FXCM.Fields.StartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StartDate val) 
            { 
                return IsSetStartDate();
            }
            
            public bool IsSetStartDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StartDate);
            }
            
            public QuickFix.FXCM.Fields.EndDate EndDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndDate val) 
            { 
                EndDate = val;
            }
            
            public QuickFix.FXCM.Fields.EndDate Get(QuickFix.FXCM.Fields.EndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndDate val) 
            { 
                return IsSetEndDate();
            }
            
            public bool IsSetEndDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndDate);
            }
            
            public QuickFix.FXCM.Fields.DeliveryType DeliveryType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.DeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                DeliveryType = val;
            }
            
            public QuickFix.FXCM.Fields.DeliveryType Get(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.DeliveryType val) 
            { 
                return IsSetDeliveryType();
            }
            
            public bool IsSetDeliveryType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.DeliveryType);
            }
            
            public QuickFix.FXCM.Fields.MarginRatio MarginRatio
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                MarginRatio = val;
            }
            
            public QuickFix.FXCM.Fields.MarginRatio Get(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MarginRatio val) 
            { 
                return IsSetMarginRatio();
            }
            
            public bool IsSetMarginRatio() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MarginRatio);
            }
            
            public QuickFix.FXCM.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                NoUnderlyings = val;
            }
            
            public QuickFix.FXCM.Fields.NoUnderlyings Get(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyings);
            }
            
            public QuickFix.FXCM.Fields.NoLegs NoLegs
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                NoLegs = val;
            }
            
            public QuickFix.FXCM.Fields.NoLegs Get(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegs);
            }
            
            public QuickFix.FXCM.Fields.YieldType YieldType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldType val) 
            { 
                YieldType = val;
            }
            
            public QuickFix.FXCM.Fields.YieldType Get(QuickFix.FXCM.Fields.YieldType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldType val) 
            { 
                return IsSetYieldType();
            }
            
            public bool IsSetYieldType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldType);
            }
            
            public QuickFix.FXCM.Fields.Yield Yield
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Yield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Yield val) 
            { 
                Yield = val;
            }
            
            public QuickFix.FXCM.Fields.Yield Get(QuickFix.FXCM.Fields.Yield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Yield val) 
            { 
                return IsSetYield();
            }
            
            public bool IsSetYield() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Yield);
            }
            
            public QuickFix.FXCM.Fields.YieldCalcDate YieldCalcDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldCalcDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                YieldCalcDate = val;
            }
            
            public QuickFix.FXCM.Fields.YieldCalcDate Get(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldCalcDate val) 
            { 
                return IsSetYieldCalcDate();
            }
            
            public bool IsSetYieldCalcDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldCalcDate);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionDate YieldRedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                YieldRedemptionDate = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionDate Get(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionDate val) 
            { 
                return IsSetYieldRedemptionDate();
            }
            
            public bool IsSetYieldRedemptionDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionDate);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPrice YieldRedemptionPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                YieldRedemptionPrice = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPrice Get(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionPrice val) 
            { 
                return IsSetYieldRedemptionPrice();
            }
            
            public bool IsSetYieldRedemptionPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionPrice);
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.YieldRedemptionPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                YieldRedemptionPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.YieldRedemptionPriceType Get(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.YieldRedemptionPriceType val) 
            { 
                return IsSetYieldRedemptionPriceType();
            }
            
            public bool IsSetYieldRedemptionPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.YieldRedemptionPriceType);
            }
            
            public QuickFix.FXCM.Fields.AllocQty AllocQty
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocQty val) 
            { 
                AllocQty = val;
            }
            
            public QuickFix.FXCM.Fields.AllocQty Get(QuickFix.FXCM.Fields.AllocQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocQty val) 
            { 
                return IsSetAllocQty();
            }
            
            public bool IsSetAllocQty() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocQty);
            }
            
            public QuickFix.FXCM.Fields.QtyType QtyType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.QtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.QtyType val) 
            { 
                QtyType = val;
            }
            
            public QuickFix.FXCM.Fields.QtyType Get(QuickFix.FXCM.Fields.QtyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.QtyType val) 
            { 
                return IsSetQtyType();
            }
            
            public bool IsSetQtyType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.QtyType);
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
            
            public QuickFix.FXCM.Fields.Currency Currency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Currency val) 
            { 
                Currency = val;
            }
            
            public QuickFix.FXCM.Fields.Currency Get(QuickFix.FXCM.Fields.Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Currency);
            }
            
            public QuickFix.FXCM.Fields.LastMkt LastMkt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastMkt val) 
            { 
                LastMkt = val;
            }
            
            public QuickFix.FXCM.Fields.LastMkt Get(QuickFix.FXCM.Fields.LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastMkt);
            }
            
            public QuickFix.FXCM.Fields.NoCapacities NoCapacities
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoCapacities();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoCapacities val) 
            { 
                NoCapacities = val;
            }
            
            public QuickFix.FXCM.Fields.NoCapacities Get(QuickFix.FXCM.Fields.NoCapacities val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoCapacities val) 
            { 
                return IsSetNoCapacities();
            }
            
            public bool IsSetNoCapacities() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoCapacities);
            }
            
            public QuickFix.FXCM.Fields.AllocAccount AllocAccount
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocAccount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocAccount val) 
            { 
                AllocAccount = val;
            }
            
            public QuickFix.FXCM.Fields.AllocAccount Get(QuickFix.FXCM.Fields.AllocAccount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocAccount val) 
            { 
                return IsSetAllocAccount();
            }
            
            public bool IsSetAllocAccount() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocAccount);
            }
            
            public QuickFix.FXCM.Fields.AllocAcctIDSource AllocAcctIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocAcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocAcctIDSource val) 
            { 
                AllocAcctIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.AllocAcctIDSource Get(QuickFix.FXCM.Fields.AllocAcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocAcctIDSource val) 
            { 
                return IsSetAllocAcctIDSource();
            }
            
            public bool IsSetAllocAcctIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocAcctIDSource);
            }
            
            public QuickFix.FXCM.Fields.AllocAccountType AllocAccountType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AllocAccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AllocAccountType val) 
            { 
                AllocAccountType = val;
            }
            
            public QuickFix.FXCM.Fields.AllocAccountType Get(QuickFix.FXCM.Fields.AllocAccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AllocAccountType val) 
            { 
                return IsSetAllocAccountType();
            }
            
            public bool IsSetAllocAccountType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AllocAccountType);
            }
            
            public QuickFix.FXCM.Fields.AvgPx AvgPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AvgPx val) 
            { 
                AvgPx = val;
            }
            
            public QuickFix.FXCM.Fields.AvgPx Get(QuickFix.FXCM.Fields.AvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AvgPx val) 
            { 
                return IsSetAvgPx();
            }
            
            public bool IsSetAvgPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AvgPx);
            }
            
            public QuickFix.FXCM.Fields.AvgPxPrecision AvgPxPrecision
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AvgPxPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AvgPxPrecision val) 
            { 
                AvgPxPrecision = val;
            }
            
            public QuickFix.FXCM.Fields.AvgPxPrecision Get(QuickFix.FXCM.Fields.AvgPxPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AvgPxPrecision val) 
            { 
                return IsSetAvgPxPrecision();
            }
            
            public bool IsSetAvgPxPrecision() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AvgPxPrecision);
            }
            
            public QuickFix.FXCM.Fields.PriceType PriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.PriceType val) 
            { 
                PriceType = val;
            }
            
            public QuickFix.FXCM.Fields.PriceType Get(QuickFix.FXCM.Fields.PriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.PriceType val) 
            { 
                return IsSetPriceType();
            }
            
            public bool IsSetPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.PriceType);
            }
            
            public QuickFix.FXCM.Fields.AvgParPx AvgParPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AvgParPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AvgParPx val) 
            { 
                AvgParPx = val;
            }
            
            public QuickFix.FXCM.Fields.AvgParPx Get(QuickFix.FXCM.Fields.AvgParPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AvgParPx val) 
            { 
                return IsSetAvgParPx();
            }
            
            public bool IsSetAvgParPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AvgParPx);
            }
            
            public QuickFix.FXCM.Fields.Spread Spread
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Spread();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Spread val) 
            { 
                Spread = val;
            }
            
            public QuickFix.FXCM.Fields.Spread Get(QuickFix.FXCM.Fields.Spread val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Spread val) 
            { 
                return IsSetSpread();
            }
            
            public bool IsSetSpread() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Spread);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurveCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                BenchmarkCurveCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveCurrency Get(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurveCurrency val) 
            { 
                return IsSetBenchmarkCurveCurrency();
            }
            
            public bool IsSetBenchmarkCurveCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurveCurrency);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveName BenchmarkCurveName
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurveName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                BenchmarkCurveName = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurveName Get(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurveName val) 
            { 
                return IsSetBenchmarkCurveName();
            }
            
            public bool IsSetBenchmarkCurveName() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurveName);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkCurvePoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                BenchmarkCurvePoint = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkCurvePoint Get(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkCurvePoint val) 
            { 
                return IsSetBenchmarkCurvePoint();
            }
            
            public bool IsSetBenchmarkCurvePoint() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkCurvePoint);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPrice BenchmarkPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                BenchmarkPrice = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPrice Get(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkPrice val) 
            { 
                return IsSetBenchmarkPrice();
            }
            
            public bool IsSetBenchmarkPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkPrice);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPriceType BenchmarkPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                BenchmarkPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkPriceType Get(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkPriceType val) 
            { 
                return IsSetBenchmarkPriceType();
            }
            
            public bool IsSetBenchmarkPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkPriceType);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityID BenchmarkSecurityID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                BenchmarkSecurityID = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityID Get(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkSecurityID val) 
            { 
                return IsSetBenchmarkSecurityID();
            }
            
            public bool IsSetBenchmarkSecurityID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkSecurityID);
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BenchmarkSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                BenchmarkSecurityIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.BenchmarkSecurityIDSource Get(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BenchmarkSecurityIDSource val) 
            { 
                return IsSetBenchmarkSecurityIDSource();
            }
            
            public bool IsSetBenchmarkSecurityIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BenchmarkSecurityIDSource);
            }
            
            public QuickFix.FXCM.Fields.ReportedPx ReportedPx
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ReportedPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ReportedPx val) 
            { 
                ReportedPx = val;
            }
            
            public QuickFix.FXCM.Fields.ReportedPx Get(QuickFix.FXCM.Fields.ReportedPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ReportedPx val) 
            { 
                return IsSetReportedPx();
            }
            
            public bool IsSetReportedPx() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ReportedPx);
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
            
            public QuickFix.FXCM.Fields.ProcessCode ProcessCode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ProcessCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ProcessCode val) 
            { 
                ProcessCode = val;
            }
            
            public QuickFix.FXCM.Fields.ProcessCode Get(QuickFix.FXCM.Fields.ProcessCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ProcessCode val) 
            { 
                return IsSetProcessCode();
            }
            
            public bool IsSetProcessCode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ProcessCode);
            }
            
            public QuickFix.FXCM.Fields.GrossTradeAmt GrossTradeAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.GrossTradeAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.GrossTradeAmt val) 
            { 
                GrossTradeAmt = val;
            }
            
            public QuickFix.FXCM.Fields.GrossTradeAmt Get(QuickFix.FXCM.Fields.GrossTradeAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.GrossTradeAmt val) 
            { 
                return IsSetGrossTradeAmt();
            }
            
            public bool IsSetGrossTradeAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.GrossTradeAmt);
            }
            
            public QuickFix.FXCM.Fields.NumDaysInterest NumDaysInterest
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NumDaysInterest();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NumDaysInterest val) 
            { 
                NumDaysInterest = val;
            }
            
            public QuickFix.FXCM.Fields.NumDaysInterest Get(QuickFix.FXCM.Fields.NumDaysInterest val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NumDaysInterest val) 
            { 
                return IsSetNumDaysInterest();
            }
            
            public bool IsSetNumDaysInterest() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NumDaysInterest);
            }
            
            public QuickFix.FXCM.Fields.ExDate ExDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExDate val) 
            { 
                ExDate = val;
            }
            
            public QuickFix.FXCM.Fields.ExDate Get(QuickFix.FXCM.Fields.ExDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExDate val) 
            { 
                return IsSetExDate();
            }
            
            public bool IsSetExDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExDate);
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestRate AccruedInterestRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccruedInterestRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccruedInterestRate val) 
            { 
                AccruedInterestRate = val;
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestRate Get(QuickFix.FXCM.Fields.AccruedInterestRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccruedInterestRate val) 
            { 
                return IsSetAccruedInterestRate();
            }
            
            public bool IsSetAccruedInterestRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccruedInterestRate);
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestAmt AccruedInterestAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccruedInterestAmt val) 
            { 
                AccruedInterestAmt = val;
            }
            
            public QuickFix.FXCM.Fields.AccruedInterestAmt Get(QuickFix.FXCM.Fields.AccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccruedInterestAmt val) 
            { 
                return IsSetAccruedInterestAmt();
            }
            
            public bool IsSetAccruedInterestAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccruedInterestAmt);
            }
            
            public QuickFix.FXCM.Fields.InterestAtMaturity InterestAtMaturity
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.InterestAtMaturity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.InterestAtMaturity val) 
            { 
                InterestAtMaturity = val;
            }
            
            public QuickFix.FXCM.Fields.InterestAtMaturity Get(QuickFix.FXCM.Fields.InterestAtMaturity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.InterestAtMaturity val) 
            { 
                return IsSetInterestAtMaturity();
            }
            
            public bool IsSetInterestAtMaturity() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.InterestAtMaturity);
            }
            
            public QuickFix.FXCM.Fields.EndAccruedInterestAmt EndAccruedInterestAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndAccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndAccruedInterestAmt val) 
            { 
                EndAccruedInterestAmt = val;
            }
            
            public QuickFix.FXCM.Fields.EndAccruedInterestAmt Get(QuickFix.FXCM.Fields.EndAccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndAccruedInterestAmt val) 
            { 
                return IsSetEndAccruedInterestAmt();
            }
            
            public bool IsSetEndAccruedInterestAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndAccruedInterestAmt);
            }
            
            public QuickFix.FXCM.Fields.StartCash StartCash
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.StartCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.StartCash val) 
            { 
                StartCash = val;
            }
            
            public QuickFix.FXCM.Fields.StartCash Get(QuickFix.FXCM.Fields.StartCash val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.StartCash val) 
            { 
                return IsSetStartCash();
            }
            
            public bool IsSetStartCash() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.StartCash);
            }
            
            public QuickFix.FXCM.Fields.EndCash EndCash
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndCash val) 
            { 
                EndCash = val;
            }
            
            public QuickFix.FXCM.Fields.EndCash Get(QuickFix.FXCM.Fields.EndCash val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndCash val) 
            { 
                return IsSetEndCash();
            }
            
            public bool IsSetEndCash() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndCash);
            }
            
            public QuickFix.FXCM.Fields.Concession Concession
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Concession();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Concession val) 
            { 
                Concession = val;
            }
            
            public QuickFix.FXCM.Fields.Concession Get(QuickFix.FXCM.Fields.Concession val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Concession val) 
            { 
                return IsSetConcession();
            }
            
            public bool IsSetConcession() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Concession);
            }
            
            public QuickFix.FXCM.Fields.TotalTakedown TotalTakedown
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotalTakedown();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotalTakedown val) 
            { 
                TotalTakedown = val;
            }
            
            public QuickFix.FXCM.Fields.TotalTakedown Get(QuickFix.FXCM.Fields.TotalTakedown val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotalTakedown val) 
            { 
                return IsSetTotalTakedown();
            }
            
            public bool IsSetTotalTakedown() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotalTakedown);
            }
            
            public QuickFix.FXCM.Fields.NetMoney NetMoney
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NetMoney();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NetMoney val) 
            { 
                NetMoney = val;
            }
            
            public QuickFix.FXCM.Fields.NetMoney Get(QuickFix.FXCM.Fields.NetMoney val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NetMoney val) 
            { 
                return IsSetNetMoney();
            }
            
            public bool IsSetNetMoney() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NetMoney);
            }
            
            public QuickFix.FXCM.Fields.MaturityNetMoney MaturityNetMoney
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaturityNetMoney();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaturityNetMoney val) 
            { 
                MaturityNetMoney = val;
            }
            
            public QuickFix.FXCM.Fields.MaturityNetMoney Get(QuickFix.FXCM.Fields.MaturityNetMoney val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaturityNetMoney val) 
            { 
                return IsSetMaturityNetMoney();
            }
            
            public bool IsSetMaturityNetMoney() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaturityNetMoney);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrAmt SettlCurrAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrAmt val) 
            { 
                SettlCurrAmt = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrAmt Get(QuickFix.FXCM.Fields.SettlCurrAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrAmt val) 
            { 
                return IsSetSettlCurrAmt();
            }
            
            public bool IsSetSettlCurrAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrAmt);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrency SettlCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrency val) 
            { 
                SettlCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrency Get(QuickFix.FXCM.Fields.SettlCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrency val) 
            { 
                return IsSetSettlCurrency();
            }
            
            public bool IsSetSettlCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrency);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRate SettlCurrFxRate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrFxRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrFxRate val) 
            { 
                SettlCurrFxRate = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRate Get(QuickFix.FXCM.Fields.SettlCurrFxRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrFxRate val) 
            { 
                return IsSetSettlCurrFxRate();
            }
            
            public bool IsSetSettlCurrFxRate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrFxRate);
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlCurrFxRateCalc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                SettlCurrFxRateCalc = val;
            }
            
            public QuickFix.FXCM.Fields.SettlCurrFxRateCalc Get(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlCurrFxRateCalc val) 
            { 
                return IsSetSettlCurrFxRateCalc();
            }
            
            public bool IsSetSettlCurrFxRateCalc() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlCurrFxRateCalc);
            }
            
            public QuickFix.FXCM.Fields.SettlType SettlType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlType val) 
            { 
                SettlType = val;
            }
            
            public QuickFix.FXCM.Fields.SettlType Get(QuickFix.FXCM.Fields.SettlType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlType val) 
            { 
                return IsSetSettlType();
            }
            
            public bool IsSetSettlType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlType);
            }
            
            public QuickFix.FXCM.Fields.SettlDate SettlDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlDate val) 
            { 
                SettlDate = val;
            }
            
            public QuickFix.FXCM.Fields.SettlDate Get(QuickFix.FXCM.Fields.SettlDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlDate val) 
            { 
                return IsSetSettlDate();
            }
            
            public bool IsSetSettlDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlDate);
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
            
            public QuickFix.FXCM.Fields.Commission Commission
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Commission();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Commission val) 
            { 
                Commission = val;
            }
            
            public QuickFix.FXCM.Fields.Commission Get(QuickFix.FXCM.Fields.Commission val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Commission val) 
            { 
                return IsSetCommission();
            }
            
            public bool IsSetCommission() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Commission);
            }
            
            public QuickFix.FXCM.Fields.CommType CommType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CommType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CommType val) 
            { 
                CommType = val;
            }
            
            public QuickFix.FXCM.Fields.CommType Get(QuickFix.FXCM.Fields.CommType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CommType val) 
            { 
                return IsSetCommType();
            }
            
            public bool IsSetCommType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CommType);
            }
            
            public QuickFix.FXCM.Fields.CommCurrency CommCurrency
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CommCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CommCurrency val) 
            { 
                CommCurrency = val;
            }
            
            public QuickFix.FXCM.Fields.CommCurrency Get(QuickFix.FXCM.Fields.CommCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CommCurrency val) 
            { 
                return IsSetCommCurrency();
            }
            
            public bool IsSetCommCurrency() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CommCurrency);
            }
            
            public QuickFix.FXCM.Fields.FundRenewWaiv FundRenewWaiv
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FundRenewWaiv();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FundRenewWaiv val) 
            { 
                FundRenewWaiv = val;
            }
            
            public QuickFix.FXCM.Fields.FundRenewWaiv Get(QuickFix.FXCM.Fields.FundRenewWaiv val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FundRenewWaiv val) 
            { 
                return IsSetFundRenewWaiv();
            }
            
            public bool IsSetFundRenewWaiv() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FundRenewWaiv);
            }
            
            public QuickFix.FXCM.Fields.SharedCommission SharedCommission
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SharedCommission();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SharedCommission val) 
            { 
                SharedCommission = val;
            }
            
            public QuickFix.FXCM.Fields.SharedCommission Get(QuickFix.FXCM.Fields.SharedCommission val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SharedCommission val) 
            { 
                return IsSetSharedCommission();
            }
            
            public bool IsSetSharedCommission() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SharedCommission);
            }
            
            public QuickFix.FXCM.Fields.NoStipulations NoStipulations
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoStipulations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                NoStipulations = val;
            }
            
            public QuickFix.FXCM.Fields.NoStipulations Get(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoStipulations val) 
            { 
                return IsSetNoStipulations();
            }
            
            public bool IsSetNoStipulations() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoStipulations);
            }
            
            public QuickFix.FXCM.Fields.NoMiscFees NoMiscFees
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoMiscFees();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoMiscFees val) 
            { 
                NoMiscFees = val;
            }
            
            public QuickFix.FXCM.Fields.NoMiscFees Get(QuickFix.FXCM.Fields.NoMiscFees val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoMiscFees val) 
            { 
                return IsSetNoMiscFees();
            }
            
            public bool IsSetNoMiscFees() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoMiscFees);
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
            public class NoOrdersGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.ClOrdID, QuickFix.FXCM.Fields.Tags.OrderID, QuickFix.FXCM.Fields.Tags.SecondaryOrderID, QuickFix.FXCM.Fields.Tags.SecondaryClOrdID, QuickFix.FXCM.Fields.Tags.ListID, QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs, QuickFix.FXCM.Fields.Tags.OrderQty, QuickFix.FXCM.Fields.Tags.OrderAvgPx, QuickFix.FXCM.Fields.Tags.OrderBookingQty, 0};
            
                public NoOrdersGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoOrders, QuickFix.FXCM.Fields.Tags.ClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.FXCM.Fields.OrderID OrderID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderID val) 
                { 
                    OrderID = val;
                }
                
                public QuickFix.FXCM.Fields.OrderID Get(QuickFix.FXCM.Fields.OrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderID val) 
                { 
                    return IsSetOrderID();
                }
                
                public bool IsSetOrderID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderID);
                }
                
                public QuickFix.FXCM.Fields.SecondaryOrderID SecondaryOrderID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecondaryOrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecondaryOrderID val) 
                { 
                    SecondaryOrderID = val;
                }
                
                public QuickFix.FXCM.Fields.SecondaryOrderID Get(QuickFix.FXCM.Fields.SecondaryOrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecondaryOrderID val) 
                { 
                    return IsSetSecondaryOrderID();
                }
                
                public bool IsSetSecondaryOrderID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryOrderID);
                }
                
                public QuickFix.FXCM.Fields.SecondaryClOrdID SecondaryClOrdID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecondaryClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
                { 
                    SecondaryClOrdID = val;
                }
                
                public QuickFix.FXCM.Fields.SecondaryClOrdID Get(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
                { 
                    return IsSetSecondaryClOrdID();
                }
                
                public bool IsSetSecondaryClOrdID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryClOrdID);
                }
                
                public QuickFix.FXCM.Fields.ListID ListID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ListID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ListID val) 
                { 
                    ListID = val;
                }
                
                public QuickFix.FXCM.Fields.ListID Get(QuickFix.FXCM.Fields.ListID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ListID val) 
                { 
                    return IsSetListID();
                }
                
                public bool IsSetListID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ListID);
                }
                
                public QuickFix.FXCM.Fields.NoNested2PartyIDs NoNested2PartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoNested2PartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoNested2PartyIDs val) 
                { 
                    NoNested2PartyIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoNested2PartyIDs Get(QuickFix.FXCM.Fields.NoNested2PartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoNested2PartyIDs val) 
                { 
                    return IsSetNoNested2PartyIDs();
                }
                
                public bool IsSetNoNested2PartyIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs);
                }
                
                public QuickFix.FXCM.Fields.OrderQty OrderQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderQty val) 
                { 
                    OrderQty = val;
                }
                
                public QuickFix.FXCM.Fields.OrderQty Get(QuickFix.FXCM.Fields.OrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderQty val) 
                { 
                    return IsSetOrderQty();
                }
                
                public bool IsSetOrderQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderQty);
                }
                
                public QuickFix.FXCM.Fields.OrderAvgPx OrderAvgPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderAvgPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderAvgPx val) 
                { 
                    OrderAvgPx = val;
                }
                
                public QuickFix.FXCM.Fields.OrderAvgPx Get(QuickFix.FXCM.Fields.OrderAvgPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderAvgPx val) 
                { 
                    return IsSetOrderAvgPx();
                }
                
                public bool IsSetOrderAvgPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderAvgPx);
                }
                
                public QuickFix.FXCM.Fields.OrderBookingQty OrderBookingQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderBookingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderBookingQty val) 
                { 
                    OrderBookingQty = val;
                }
                
                public QuickFix.FXCM.Fields.OrderBookingQty Get(QuickFix.FXCM.Fields.OrderBookingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderBookingQty val) 
                { 
                    return IsSetOrderBookingQty();
                }
                
                public bool IsSetOrderBookingQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderBookingQty);
                }
                
                            public class NoNested2PartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.Nested2PartyID, QuickFix.FXCM.Fields.Tags.Nested2PartyIDSource, QuickFix.FXCM.Fields.Tags.Nested2PartyRole, QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs, 0};
                
                    public NoNested2PartyIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoNested2PartyIDs, QuickFix.FXCM.Fields.Tags.Nested2PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNested2PartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.Nested2PartyID Nested2PartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.Nested2PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.Nested2PartyID val) 
                    { 
                        Nested2PartyID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyID Get(QuickFix.FXCM.Fields.Nested2PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.Nested2PartyID val) 
                    { 
                        return IsSetNested2PartyID();
                    }
                    
                    public bool IsSetNested2PartyID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartyID);
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyIDSource Nested2PartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.Nested2PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.Nested2PartyIDSource val) 
                    { 
                        Nested2PartyIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyIDSource Get(QuickFix.FXCM.Fields.Nested2PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.Nested2PartyIDSource val) 
                    { 
                        return IsSetNested2PartyIDSource();
                    }
                    
                    public bool IsSetNested2PartyIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartyIDSource);
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyRole Nested2PartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.Nested2PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.Nested2PartyRole val) 
                    { 
                        Nested2PartyRole = val;
                    }
                    
                    public QuickFix.FXCM.Fields.Nested2PartyRole Get(QuickFix.FXCM.Fields.Nested2PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.Nested2PartyRole val) 
                    { 
                        return IsSetNested2PartyRole();
                    }
                    
                    public bool IsSetNested2PartyRole() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartyRole);
                    }
                    
                    public QuickFix.FXCM.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NoNested2PartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NoNested2PartySubIDs val) 
                    { 
                        NoNested2PartySubIDs = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NoNested2PartySubIDs Get(QuickFix.FXCM.Fields.NoNested2PartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NoNested2PartySubIDs val) 
                    { 
                        return IsSetNoNested2PartySubIDs();
                    }
                    
                    public bool IsSetNoNested2PartySubIDs() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs);
                    }
                    
                                    public class NoNested2PartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.Nested2PartySubID, QuickFix.FXCM.Fields.Tags.Nested2PartySubIDType, 0};
                    
                        public NoNested2PartySubIDsGroup() 
                          :base( QuickFix.FXCM.Fields.Tags.NoNested2PartySubIDs, QuickFix.FXCM.Fields.Tags.Nested2PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested2PartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.FXCM.Fields.Nested2PartySubID Nested2PartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.Nested2PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.Nested2PartySubID val) 
                        { 
                            Nested2PartySubID = val;
                        }
                        
                        public QuickFix.FXCM.Fields.Nested2PartySubID Get(QuickFix.FXCM.Fields.Nested2PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.Nested2PartySubID val) 
                        { 
                            return IsSetNested2PartySubID();
                        }
                        
                        public bool IsSetNested2PartySubID() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartySubID);
                        }
                        
                        public QuickFix.FXCM.Fields.Nested2PartySubIDType Nested2PartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.Nested2PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.Nested2PartySubIDType val) 
                        { 
                            Nested2PartySubIDType = val;
                        }
                        
                        public QuickFix.FXCM.Fields.Nested2PartySubIDType Get(QuickFix.FXCM.Fields.Nested2PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.Nested2PartySubIDType val) 
                        { 
                            return IsSetNested2PartySubIDType();
                        }
                        
                        public bool IsSetNested2PartySubIDType() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.Nested2PartySubIDType);
                        }
                        
                    
                    }
                }
            }
            public class NoTrdRegTimestampsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.TrdRegTimestamp, QuickFix.FXCM.Fields.Tags.TrdRegTimestampType, QuickFix.FXCM.Fields.Tags.TrdRegTimestampOrigin, 0};
            
                public NoTrdRegTimestampsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoTrdRegTimestamps, QuickFix.FXCM.Fields.Tags.TrdRegTimestamp, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTrdRegTimestampsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.TrdRegTimestamp TrdRegTimestamp
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.TrdRegTimestamp();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.TrdRegTimestamp val) 
                { 
                    TrdRegTimestamp = val;
                }
                
                public QuickFix.FXCM.Fields.TrdRegTimestamp Get(QuickFix.FXCM.Fields.TrdRegTimestamp val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.TrdRegTimestamp val) 
                { 
                    return IsSetTrdRegTimestamp();
                }
                
                public bool IsSetTrdRegTimestamp() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.TrdRegTimestamp);
                }
                
                public QuickFix.FXCM.Fields.TrdRegTimestampType TrdRegTimestampType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.TrdRegTimestampType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.TrdRegTimestampType val) 
                { 
                    TrdRegTimestampType = val;
                }
                
                public QuickFix.FXCM.Fields.TrdRegTimestampType Get(QuickFix.FXCM.Fields.TrdRegTimestampType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.TrdRegTimestampType val) 
                { 
                    return IsSetTrdRegTimestampType();
                }
                
                public bool IsSetTrdRegTimestampType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.TrdRegTimestampType);
                }
                
                public QuickFix.FXCM.Fields.TrdRegTimestampOrigin TrdRegTimestampOrigin
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.TrdRegTimestampOrigin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.TrdRegTimestampOrigin val) 
                { 
                    TrdRegTimestampOrigin = val;
                }
                
                public QuickFix.FXCM.Fields.TrdRegTimestampOrigin Get(QuickFix.FXCM.Fields.TrdRegTimestampOrigin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.TrdRegTimestampOrigin val) 
                { 
                    return IsSetTrdRegTimestampOrigin();
                }
                
                public bool IsSetTrdRegTimestampOrigin() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.TrdRegTimestampOrigin);
                }
                
            
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.SecurityAltID, QuickFix.FXCM.Fields.Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoSecurityAltID, QuickFix.FXCM.Fields.Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    SecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityAltID Get(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    SecurityAltIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.SecurityAltIDSource Get(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.SecurityAltIDSource);
                }
                
            
            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.EventType, QuickFix.FXCM.Fields.Tags.EventDate, QuickFix.FXCM.Fields.Tags.EventPx, QuickFix.FXCM.Fields.Tags.EventText, 0};
            
                public NoEventsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoEvents, QuickFix.FXCM.Fields.Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.EventType EventType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventType val) 
                { 
                    EventType = val;
                }
                
                public QuickFix.FXCM.Fields.EventType Get(QuickFix.FXCM.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventType);
                }
                
                public QuickFix.FXCM.Fields.EventDate EventDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    EventDate = val;
                }
                
                public QuickFix.FXCM.Fields.EventDate Get(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventDate);
                }
                
                public QuickFix.FXCM.Fields.EventPx EventPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    EventPx = val;
                }
                
                public QuickFix.FXCM.Fields.EventPx Get(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventPx);
                }
                
                public QuickFix.FXCM.Fields.EventText EventText
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EventText val) 
                { 
                    EventText = val;
                }
                
                public QuickFix.FXCM.Fields.EventText Get(QuickFix.FXCM.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EventText);
                }
                
            
            }
            public class NoInstrAttribGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.InstrAttribType, QuickFix.FXCM.Fields.Tags.InstrAttribValue, 0};
            
                public NoInstrAttribGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoInstrAttrib, QuickFix.FXCM.Fields.Tags.InstrAttribType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoInstrAttribGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.InstrAttribType InstrAttribType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.InstrAttribType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.InstrAttribType val) 
                { 
                    InstrAttribType = val;
                }
                
                public QuickFix.FXCM.Fields.InstrAttribType Get(QuickFix.FXCM.Fields.InstrAttribType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.InstrAttribType val) 
                { 
                    return IsSetInstrAttribType();
                }
                
                public bool IsSetInstrAttribType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.InstrAttribType);
                }
                
                public QuickFix.FXCM.Fields.InstrAttribValue InstrAttribValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.InstrAttribValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.InstrAttribValue val) 
                { 
                    InstrAttribValue = val;
                }
                
                public QuickFix.FXCM.Fields.InstrAttribValue Get(QuickFix.FXCM.Fields.InstrAttribValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.InstrAttribValue val) 
                { 
                    return IsSetInstrAttribValue();
                }
                
                public bool IsSetInstrAttribValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.InstrAttribValue);
                }
                
            
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingSymbol, QuickFix.FXCM.Fields.Tags.UnderlyingSymbolSfx, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityIDSource, QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingProduct, QuickFix.FXCM.Fields.Tags.UnderlyingCFICode, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityType, QuickFix.FXCM.Fields.Tags.UnderlyingSecuritySubType, QuickFix.FXCM.Fields.Tags.UnderlyingMaturityMonthYear, QuickFix.FXCM.Fields.Tags.UnderlyingMaturityDate, QuickFix.FXCM.Fields.Tags.UnderlyingCouponPaymentDate, QuickFix.FXCM.Fields.Tags.UnderlyingIssueDate, QuickFix.FXCM.Fields.Tags.UnderlyingRepoCollateralSecurityType, QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseTerm, QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseRate, QuickFix.FXCM.Fields.Tags.UnderlyingFactor, QuickFix.FXCM.Fields.Tags.UnderlyingCreditRating, QuickFix.FXCM.Fields.Tags.UnderlyingInstrRegistry, QuickFix.FXCM.Fields.Tags.UnderlyingCountryOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingStateOrProvinceOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingLocaleOfIssue, QuickFix.FXCM.Fields.Tags.UnderlyingRedemptionDate, QuickFix.FXCM.Fields.Tags.UnderlyingStrikePrice, QuickFix.FXCM.Fields.Tags.UnderlyingStrikeCurrency, QuickFix.FXCM.Fields.Tags.UnderlyingOptAttribute, QuickFix.FXCM.Fields.Tags.UnderlyingContractMultiplier, QuickFix.FXCM.Fields.Tags.UnderlyingCouponRate, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityExchange, QuickFix.FXCM.Fields.Tags.UnderlyingIssuer, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuerLen, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuer, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityDesc, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDescLen, QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDesc, QuickFix.FXCM.Fields.Tags.UnderlyingCPProgram, QuickFix.FXCM.Fields.Tags.UnderlyingCPRegType, QuickFix.FXCM.Fields.Tags.UnderlyingCurrency, QuickFix.FXCM.Fields.Tags.UnderlyingQty, QuickFix.FXCM.Fields.Tags.UnderlyingPx, QuickFix.FXCM.Fields.Tags.UnderlyingDirtyPrice, QuickFix.FXCM.Fields.Tags.UnderlyingEndPrice, QuickFix.FXCM.Fields.Tags.UnderlyingStartValue, QuickFix.FXCM.Fields.Tags.UnderlyingCurrentValue, QuickFix.FXCM.Fields.Tags.UnderlyingEndValue, QuickFix.FXCM.Fields.Tags.NoUnderlyingStips, 0};
            
                public NoUnderlyingsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoUnderlyings, QuickFix.FXCM.Fields.Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.UnderlyingSymbol UnderlyingSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    UnderlyingSymbol = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbol Get(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSymbol val) 
                { 
                    return IsSetUnderlyingSymbol();
                }
                
                public bool IsSetUnderlyingSymbol() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSymbol);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    UnderlyingSymbolSfx = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSymbolSfx Get(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSymbolSfx val) 
                { 
                    return IsSetUnderlyingSymbolSfx();
                }
                
                public bool IsSetUnderlyingSymbolSfx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSymbolSfx);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityID UnderlyingSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    UnderlyingSecurityID = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityID Get(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityID val) 
                { 
                    return IsSetUnderlyingSecurityID();
                }
                
                public bool IsSetUnderlyingSecurityID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityID);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    UnderlyingSecurityIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityIDSource Get(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return IsSetUnderlyingSecurityIDSource();
                }
                
                public bool IsSetUnderlyingSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityIDSource);
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    NoUnderlyingSecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID Get(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    return IsSetNoUnderlyingSecurityAltID();
                }
                
                public bool IsSetNoUnderlyingSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingProduct UnderlyingProduct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    UnderlyingProduct = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingProduct Get(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingProduct val) 
                { 
                    return IsSetUnderlyingProduct();
                }
                
                public bool IsSetUnderlyingProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingProduct);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCFICode UnderlyingCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    UnderlyingCFICode = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCFICode Get(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCFICode val) 
                { 
                    return IsSetUnderlyingCFICode();
                }
                
                public bool IsSetUnderlyingCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCFICode);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityType UnderlyingSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    UnderlyingSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityType Get(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityType val) 
                { 
                    return IsSetUnderlyingSecurityType();
                }
                
                public bool IsSetUnderlyingSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    UnderlyingSecuritySubType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecuritySubType Get(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecuritySubType val) 
                { 
                    return IsSetUnderlyingSecuritySubType();
                }
                
                public bool IsSetUnderlyingSecuritySubType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecuritySubType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    UnderlyingMaturityMonthYear = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear Get(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    return IsSetUnderlyingMaturityMonthYear();
                }
                
                public bool IsSetUnderlyingMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingMaturityMonthYear);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    UnderlyingMaturityDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingMaturityDate Get(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingMaturityDate val) 
                { 
                    return IsSetUnderlyingMaturityDate();
                }
                
                public bool IsSetUnderlyingMaturityDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingMaturityDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    UnderlyingCouponPaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate Get(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    return IsSetUnderlyingCouponPaymentDate();
                }
                
                public bool IsSetUnderlyingCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCouponPaymentDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssueDate UnderlyingIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    UnderlyingIssueDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssueDate Get(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingIssueDate val) 
                { 
                    return IsSetUnderlyingIssueDate();
                }
                
                public bool IsSetUnderlyingIssueDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingIssueDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    UnderlyingRepoCollateralSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    return IsSetUnderlyingRepoCollateralSecurityType();
                }
                
                public bool IsSetUnderlyingRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepoCollateralSecurityType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    UnderlyingRepurchaseTerm = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm Get(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    return IsSetUnderlyingRepurchaseTerm();
                }
                
                public bool IsSetUnderlyingRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseTerm);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    UnderlyingRepurchaseRate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRepurchaseRate Get(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return IsSetUnderlyingRepurchaseRate();
                }
                
                public bool IsSetUnderlyingRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRepurchaseRate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingFactor UnderlyingFactor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    UnderlyingFactor = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingFactor Get(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingFactor val) 
                { 
                    return IsSetUnderlyingFactor();
                }
                
                public bool IsSetUnderlyingFactor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingFactor);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCreditRating UnderlyingCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    UnderlyingCreditRating = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCreditRating Get(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCreditRating val) 
                { 
                    return IsSetUnderlyingCreditRating();
                }
                
                public bool IsSetUnderlyingCreditRating() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCreditRating);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    UnderlyingInstrRegistry = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingInstrRegistry Get(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingInstrRegistry val) 
                { 
                    return IsSetUnderlyingInstrRegistry();
                }
                
                public bool IsSetUnderlyingInstrRegistry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingInstrRegistry);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    UnderlyingCountryOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCountryOfIssue Get(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCountryOfIssue val) 
                { 
                    return IsSetUnderlyingCountryOfIssue();
                }
                
                public bool IsSetUnderlyingCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCountryOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    UnderlyingStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    return IsSetUnderlyingStateOrProvinceOfIssue();
                }
                
                public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStateOrProvinceOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    UnderlyingLocaleOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue Get(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    return IsSetUnderlyingLocaleOfIssue();
                }
                
                public bool IsSetUnderlyingLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingLocaleOfIssue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    UnderlyingRedemptionDate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingRedemptionDate Get(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingRedemptionDate val) 
                { 
                    return IsSetUnderlyingRedemptionDate();
                }
                
                public bool IsSetUnderlyingRedemptionDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingRedemptionDate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    UnderlyingStrikePrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikePrice Get(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStrikePrice val) 
                { 
                    return IsSetUnderlyingStrikePrice();
                }
                
                public bool IsSetUnderlyingStrikePrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStrikePrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    UnderlyingStrikeCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStrikeCurrency Get(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStrikeCurrency val) 
                { 
                    return IsSetUnderlyingStrikeCurrency();
                }
                
                public bool IsSetUnderlyingStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStrikeCurrency);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    UnderlyingOptAttribute = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingOptAttribute Get(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingOptAttribute val) 
                { 
                    return IsSetUnderlyingOptAttribute();
                }
                
                public bool IsSetUnderlyingOptAttribute() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingOptAttribute);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    UnderlyingContractMultiplier = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingContractMultiplier Get(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingContractMultiplier val) 
                { 
                    return IsSetUnderlyingContractMultiplier();
                }
                
                public bool IsSetUnderlyingContractMultiplier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingContractMultiplier);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponRate UnderlyingCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    UnderlyingCouponRate = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCouponRate Get(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCouponRate val) 
                { 
                    return IsSetUnderlyingCouponRate();
                }
                
                public bool IsSetUnderlyingCouponRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCouponRate);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    UnderlyingSecurityExchange = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityExchange Get(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityExchange val) 
                { 
                    return IsSetUnderlyingSecurityExchange();
                }
                
                public bool IsSetUnderlyingSecurityExchange() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityExchange);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssuer UnderlyingIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    UnderlyingIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingIssuer Get(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingIssuer val) 
                { 
                    return IsSetUnderlyingIssuer();
                }
                
                public bool IsSetUnderlyingIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingIssuer);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    EncodedUnderlyingIssuerLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    return IsSetEncodedUnderlyingIssuerLen();
                }
                
                public bool IsSetEncodedUnderlyingIssuerLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuerLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    EncodedUnderlyingIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingIssuer Get(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingIssuer val) 
                { 
                    return IsSetEncodedUnderlyingIssuer();
                }
                
                public bool IsSetEncodedUnderlyingIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingIssuer);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    UnderlyingSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingSecurityDesc Get(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityDesc val) 
                { 
                    return IsSetUnderlyingSecurityDesc();
                }
                
                public bool IsSetUnderlyingSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    EncodedUnderlyingSecurityDescLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDescLen();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDescLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    EncodedUnderlyingSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDesc();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedUnderlyingSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPProgram UnderlyingCPProgram
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    UnderlyingCPProgram = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPProgram Get(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCPProgram val) 
                { 
                    return IsSetUnderlyingCPProgram();
                }
                
                public bool IsSetUnderlyingCPProgram() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCPProgram);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPRegType UnderlyingCPRegType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    UnderlyingCPRegType = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCPRegType Get(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCPRegType val) 
                { 
                    return IsSetUnderlyingCPRegType();
                }
                
                public bool IsSetUnderlyingCPRegType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCPRegType);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrency UnderlyingCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    UnderlyingCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrency Get(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCurrency val) 
                { 
                    return IsSetUnderlyingCurrency();
                }
                
                public bool IsSetUnderlyingCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCurrency);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingQty UnderlyingQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    UnderlyingQty = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingQty Get(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingQty val) 
                { 
                    return IsSetUnderlyingQty();
                }
                
                public bool IsSetUnderlyingQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingQty);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingPx UnderlyingPx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    UnderlyingPx = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingPx Get(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingPx val) 
                { 
                    return IsSetUnderlyingPx();
                }
                
                public bool IsSetUnderlyingPx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingPx);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingDirtyPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    UnderlyingDirtyPrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingDirtyPrice Get(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingDirtyPrice val) 
                { 
                    return IsSetUnderlyingDirtyPrice();
                }
                
                public bool IsSetUnderlyingDirtyPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingDirtyPrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndPrice UnderlyingEndPrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingEndPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    UnderlyingEndPrice = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndPrice Get(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingEndPrice val) 
                { 
                    return IsSetUnderlyingEndPrice();
                }
                
                public bool IsSetUnderlyingEndPrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingEndPrice);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStartValue UnderlyingStartValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingStartValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    UnderlyingStartValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingStartValue Get(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStartValue val) 
                { 
                    return IsSetUnderlyingStartValue();
                }
                
                public bool IsSetUnderlyingStartValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStartValue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingCurrentValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    UnderlyingCurrentValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingCurrentValue Get(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingCurrentValue val) 
                { 
                    return IsSetUnderlyingCurrentValue();
                }
                
                public bool IsSetUnderlyingCurrentValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingCurrentValue);
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndValue UnderlyingEndValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.UnderlyingEndValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    UnderlyingEndValue = val;
                }
                
                public QuickFix.FXCM.Fields.UnderlyingEndValue Get(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.UnderlyingEndValue val) 
                { 
                    return IsSetUnderlyingEndValue();
                }
                
                public bool IsSetUnderlyingEndValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingEndValue);
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingStips NoUnderlyingStips
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoUnderlyingStips();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    NoUnderlyingStips = val;
                }
                
                public QuickFix.FXCM.Fields.NoUnderlyingStips Get(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoUnderlyingStips val) 
                { 
                    return IsSetNoUnderlyingStips();
                }
                
                public bool IsSetNoUnderlyingStips() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoUnderlyingStips);
                }
                
                            public class NoUnderlyingSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltIDSource, 0};
                
                    public NoUnderlyingSecurityAltIDGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoUnderlyingSecurityAltID, QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        UnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltID Get(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityAltID val) 
                    { 
                        return IsSetUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltID);
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        UnderlyingSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityAltIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSecurityAltIDSource);
                    }
                    
                
                }
                public class NoUnderlyingStipsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.UnderlyingStipType, QuickFix.FXCM.Fields.Tags.UnderlyingStipValue, 0};
                
                    public NoUnderlyingStipsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoUnderlyingStips, QuickFix.FXCM.Fields.Tags.UnderlyingStipType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingStipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.UnderlyingStipType UnderlyingStipType
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingStipType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        UnderlyingStipType = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipType Get(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStipType val) 
                    { 
                        return IsSetUnderlyingStipType();
                    }
                    
                    public bool IsSetUnderlyingStipType() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStipType);
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipValue UnderlyingStipValue
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.UnderlyingStipValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        UnderlyingStipValue = val;
                    }
                    
                    public QuickFix.FXCM.Fields.UnderlyingStipValue Get(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.UnderlyingStipValue val) 
                    { 
                        return IsSetUnderlyingStipValue();
                    }
                    
                    public bool IsSetUnderlyingStipValue() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingStipValue);
                    }
                    
                
                }
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegSymbol, QuickFix.FXCM.Fields.Tags.LegSymbolSfx, QuickFix.FXCM.Fields.Tags.LegSecurityID, QuickFix.FXCM.Fields.Tags.LegSecurityIDSource, QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegProduct, QuickFix.FXCM.Fields.Tags.LegCFICode, QuickFix.FXCM.Fields.Tags.LegSecurityType, QuickFix.FXCM.Fields.Tags.LegSecuritySubType, QuickFix.FXCM.Fields.Tags.LegMaturityMonthYear, QuickFix.FXCM.Fields.Tags.LegMaturityDate, QuickFix.FXCM.Fields.Tags.LegCouponPaymentDate, QuickFix.FXCM.Fields.Tags.LegIssueDate, QuickFix.FXCM.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.FXCM.Fields.Tags.LegRepurchaseTerm, QuickFix.FXCM.Fields.Tags.LegRepurchaseRate, QuickFix.FXCM.Fields.Tags.LegFactor, QuickFix.FXCM.Fields.Tags.LegCreditRating, QuickFix.FXCM.Fields.Tags.LegInstrRegistry, QuickFix.FXCM.Fields.Tags.LegCountryOfIssue, QuickFix.FXCM.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.FXCM.Fields.Tags.LegLocaleOfIssue, QuickFix.FXCM.Fields.Tags.LegRedemptionDate, QuickFix.FXCM.Fields.Tags.LegStrikePrice, QuickFix.FXCM.Fields.Tags.LegStrikeCurrency, QuickFix.FXCM.Fields.Tags.LegOptAttribute, QuickFix.FXCM.Fields.Tags.LegContractMultiplier, QuickFix.FXCM.Fields.Tags.LegCouponRate, QuickFix.FXCM.Fields.Tags.LegSecurityExchange, QuickFix.FXCM.Fields.Tags.LegIssuer, QuickFix.FXCM.Fields.Tags.EncodedLegIssuerLen, QuickFix.FXCM.Fields.Tags.EncodedLegIssuer, QuickFix.FXCM.Fields.Tags.LegSecurityDesc, QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDesc, QuickFix.FXCM.Fields.Tags.LegRatioQty, QuickFix.FXCM.Fields.Tags.LegSide, QuickFix.FXCM.Fields.Tags.LegCurrency, QuickFix.FXCM.Fields.Tags.LegPool, QuickFix.FXCM.Fields.Tags.LegDatedDate, QuickFix.FXCM.Fields.Tags.LegContractSettlMonth, QuickFix.FXCM.Fields.Tags.LegInterestAccrualDate, 0};
            
                public NoLegsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoLegs, QuickFix.FXCM.Fields.Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    LegSymbol = val;
                }
                
                public QuickFix.FXCM.Fields.LegSymbol Get(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSymbol);
                }
                
                public QuickFix.FXCM.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    LegSymbolSfx = val;
                }
                
                public QuickFix.FXCM.Fields.LegSymbolSfx Get(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSymbolSfx);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    LegSecurityID = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityID Get(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityID);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    LegSecurityIDSource = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityIDSource Get(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityIDSource);
                }
                
                public QuickFix.FXCM.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    NoLegSecurityAltID = val;
                }
                
                public QuickFix.FXCM.Fields.NoLegSecurityAltID Get(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID);
                }
                
                public QuickFix.FXCM.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    LegProduct = val;
                }
                
                public QuickFix.FXCM.Fields.LegProduct Get(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegProduct);
                }
                
                public QuickFix.FXCM.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    LegCFICode = val;
                }
                
                public QuickFix.FXCM.Fields.LegCFICode Get(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCFICode);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    LegSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityType Get(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityType);
                }
                
                public QuickFix.FXCM.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    LegSecuritySubType = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecuritySubType Get(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecuritySubType);
                }
                
                public QuickFix.FXCM.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    LegMaturityMonthYear = val;
                }
                
                public QuickFix.FXCM.Fields.LegMaturityMonthYear Get(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegMaturityMonthYear);
                }
                
                public QuickFix.FXCM.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    LegMaturityDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegMaturityDate Get(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegMaturityDate);
                }
                
                public QuickFix.FXCM.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    LegCouponPaymentDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegCouponPaymentDate Get(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCouponPaymentDate);
                }
                
                public QuickFix.FXCM.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    LegIssueDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegIssueDate Get(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegIssueDate);
                }
                
                public QuickFix.FXCM.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepoCollateralSecurityType Get(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepoCollateralSecurityType);
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    LegRepurchaseTerm = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseTerm Get(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepurchaseTerm);
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    LegRepurchaseRate = val;
                }
                
                public QuickFix.FXCM.Fields.LegRepurchaseRate Get(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRepurchaseRate);
                }
                
                public QuickFix.FXCM.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    LegFactor = val;
                }
                
                public QuickFix.FXCM.Fields.LegFactor Get(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegFactor);
                }
                
                public QuickFix.FXCM.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    LegCreditRating = val;
                }
                
                public QuickFix.FXCM.Fields.LegCreditRating Get(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCreditRating);
                }
                
                public QuickFix.FXCM.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    LegInstrRegistry = val;
                }
                
                public QuickFix.FXCM.Fields.LegInstrRegistry Get(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegInstrRegistry);
                }
                
                public QuickFix.FXCM.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    LegCountryOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegCountryOfIssue Get(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCountryOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue Get(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStateOrProvinceOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    LegLocaleOfIssue = val;
                }
                
                public QuickFix.FXCM.Fields.LegLocaleOfIssue Get(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegLocaleOfIssue);
                }
                
                public QuickFix.FXCM.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    LegRedemptionDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegRedemptionDate Get(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRedemptionDate);
                }
                
                public QuickFix.FXCM.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    LegStrikePrice = val;
                }
                
                public QuickFix.FXCM.Fields.LegStrikePrice Get(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStrikePrice);
                }
                
                public QuickFix.FXCM.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    LegStrikeCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegStrikeCurrency Get(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegStrikeCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    LegOptAttribute = val;
                }
                
                public QuickFix.FXCM.Fields.LegOptAttribute Get(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegOptAttribute);
                }
                
                public QuickFix.FXCM.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    LegContractMultiplier = val;
                }
                
                public QuickFix.FXCM.Fields.LegContractMultiplier Get(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegContractMultiplier);
                }
                
                public QuickFix.FXCM.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    LegCouponRate = val;
                }
                
                public QuickFix.FXCM.Fields.LegCouponRate Get(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCouponRate);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    LegSecurityExchange = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityExchange Get(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityExchange);
                }
                
                public QuickFix.FXCM.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    LegIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.LegIssuer Get(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegIssuer);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    EncodedLegIssuerLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuerLen Get(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegIssuerLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    EncodedLegIssuer = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegIssuer Get(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegIssuer);
                }
                
                public QuickFix.FXCM.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    LegSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.LegSecurityDesc Get(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDescLen Get(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDescLen);
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.FXCM.Fields.EncodedLegSecurityDesc Get(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedLegSecurityDesc);
                }
                
                public QuickFix.FXCM.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    LegRatioQty = val;
                }
                
                public QuickFix.FXCM.Fields.LegRatioQty Get(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegRatioQty);
                }
                
                public QuickFix.FXCM.Fields.LegSide LegSide
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    LegSide = val;
                }
                
                public QuickFix.FXCM.Fields.LegSide Get(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegSide);
                }
                
                public QuickFix.FXCM.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    LegCurrency = val;
                }
                
                public QuickFix.FXCM.Fields.LegCurrency Get(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegCurrency);
                }
                
                public QuickFix.FXCM.Fields.LegPool LegPool
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    LegPool = val;
                }
                
                public QuickFix.FXCM.Fields.LegPool Get(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegPool);
                }
                
                public QuickFix.FXCM.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    LegDatedDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegDatedDate Get(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegDatedDate);
                }
                
                public QuickFix.FXCM.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    LegContractSettlMonth = val;
                }
                
                public QuickFix.FXCM.Fields.LegContractSettlMonth Get(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegContractSettlMonth);
                }
                
                public QuickFix.FXCM.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    LegInterestAccrualDate = val;
                }
                
                public QuickFix.FXCM.Fields.LegInterestAccrualDate Get(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LegInterestAccrualDate);
                }
                
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.LegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoLegSecurityAltID, QuickFix.FXCM.Fields.Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        LegSecurityAltID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltID Get(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityAltID);
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.LegSecurityAltIDSource Get(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.LegSecurityAltIDSource);
                    }
                    
                
                }
            }
            public class NoCapacitiesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.OrderCapacity, QuickFix.FXCM.Fields.Tags.OrderRestrictions, QuickFix.FXCM.Fields.Tags.OrderCapacityQty, 0};
            
                public NoCapacitiesGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoCapacities, QuickFix.FXCM.Fields.Tags.OrderCapacity, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoCapacitiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.OrderCapacity OrderCapacity
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderCapacity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderCapacity val) 
                { 
                    OrderCapacity = val;
                }
                
                public QuickFix.FXCM.Fields.OrderCapacity Get(QuickFix.FXCM.Fields.OrderCapacity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderCapacity val) 
                { 
                    return IsSetOrderCapacity();
                }
                
                public bool IsSetOrderCapacity() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderCapacity);
                }
                
                public QuickFix.FXCM.Fields.OrderRestrictions OrderRestrictions
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderRestrictions();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderRestrictions val) 
                { 
                    OrderRestrictions = val;
                }
                
                public QuickFix.FXCM.Fields.OrderRestrictions Get(QuickFix.FXCM.Fields.OrderRestrictions val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderRestrictions val) 
                { 
                    return IsSetOrderRestrictions();
                }
                
                public bool IsSetOrderRestrictions() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderRestrictions);
                }
                
                public QuickFix.FXCM.Fields.OrderCapacityQty OrderCapacityQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.OrderCapacityQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.OrderCapacityQty val) 
                { 
                    OrderCapacityQty = val;
                }
                
                public QuickFix.FXCM.Fields.OrderCapacityQty Get(QuickFix.FXCM.Fields.OrderCapacityQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.OrderCapacityQty val) 
                { 
                    return IsSetOrderCapacityQty();
                }
                
                public bool IsSetOrderCapacityQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.OrderCapacityQty);
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
            public class NoStipulationsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.StipulationType, QuickFix.FXCM.Fields.Tags.StipulationValue, 0};
            
                public NoStipulationsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoStipulations, QuickFix.FXCM.Fields.Tags.StipulationType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStipulationsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.StipulationType StipulationType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StipulationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    StipulationType = val;
                }
                
                public QuickFix.FXCM.Fields.StipulationType Get(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StipulationType val) 
                { 
                    return IsSetStipulationType();
                }
                
                public bool IsSetStipulationType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StipulationType);
                }
                
                public QuickFix.FXCM.Fields.StipulationValue StipulationValue
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.StipulationValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    StipulationValue = val;
                }
                
                public QuickFix.FXCM.Fields.StipulationValue Get(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.StipulationValue val) 
                { 
                    return IsSetStipulationValue();
                }
                
                public bool IsSetStipulationValue() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.StipulationValue);
                }
                
            
            }
            public class NoMiscFeesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.MiscFeeAmt, QuickFix.FXCM.Fields.Tags.MiscFeeCurr, QuickFix.FXCM.Fields.Tags.MiscFeeType, QuickFix.FXCM.Fields.Tags.MiscFeeBasis, 0};
            
                public NoMiscFeesGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoMiscFees, QuickFix.FXCM.Fields.Tags.MiscFeeAmt, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMiscFeesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.MiscFeeAmt MiscFeeAmt
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeAmt val) 
                { 
                    MiscFeeAmt = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeAmt Get(QuickFix.FXCM.Fields.MiscFeeAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeAmt val) 
                { 
                    return IsSetMiscFeeAmt();
                }
                
                public bool IsSetMiscFeeAmt() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeAmt);
                }
                
                public QuickFix.FXCM.Fields.MiscFeeCurr MiscFeeCurr
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeCurr val) 
                { 
                    MiscFeeCurr = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeCurr Get(QuickFix.FXCM.Fields.MiscFeeCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeCurr val) 
                { 
                    return IsSetMiscFeeCurr();
                }
                
                public bool IsSetMiscFeeCurr() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeCurr);
                }
                
                public QuickFix.FXCM.Fields.MiscFeeType MiscFeeType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeType val) 
                { 
                    MiscFeeType = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeType Get(QuickFix.FXCM.Fields.MiscFeeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeType val) 
                { 
                    return IsSetMiscFeeType();
                }
                
                public bool IsSetMiscFeeType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeType);
                }
                
                public QuickFix.FXCM.Fields.MiscFeeBasis MiscFeeBasis
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MiscFeeBasis();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MiscFeeBasis val) 
                { 
                    MiscFeeBasis = val;
                }
                
                public QuickFix.FXCM.Fields.MiscFeeBasis Get(QuickFix.FXCM.Fields.MiscFeeBasis val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MiscFeeBasis val) 
                { 
                    return IsSetMiscFeeBasis();
                }
                
                public bool IsSetMiscFeeBasis() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MiscFeeBasis);
                }
                
            
            }
    }
}

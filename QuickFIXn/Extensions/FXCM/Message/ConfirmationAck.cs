// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class ConfirmationAck : Message
    {
            public const string MsgType = "AU";

            public ConfirmationAck() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("AU"));
            }

            public ConfirmationAck(
                    QuickFix.FXCM.Fields.ConfirmID aConfirmID,
                    QuickFix.FXCM.Fields.TradeDate aTradeDate,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime,
                    QuickFix.FXCM.Fields.AffirmStatus aAffirmStatus
                ) : this()
            {
                this.ConfirmID = aConfirmID;
                this.TradeDate = aTradeDate;
                this.TransactTime = aTransactTime;
                this.AffirmStatus = aAffirmStatus;
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
            
            public QuickFix.FXCM.Fields.AffirmStatus AffirmStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AffirmStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AffirmStatus val) 
            { 
                AffirmStatus = val;
            }
            
            public QuickFix.FXCM.Fields.AffirmStatus Get(QuickFix.FXCM.Fields.AffirmStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AffirmStatus val) 
            { 
                return IsSetAffirmStatus();
            }
            
            public bool IsSetAffirmStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AffirmStatus);
            }
            
            public QuickFix.FXCM.Fields.ConfirmRejReason ConfirmRejReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ConfirmRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ConfirmRejReason val) 
            { 
                ConfirmRejReason = val;
            }
            
            public QuickFix.FXCM.Fields.ConfirmRejReason Get(QuickFix.FXCM.Fields.ConfirmRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ConfirmRejReason val) 
            { 
                return IsSetConfirmRejReason();
            }
            
            public bool IsSetConfirmRejReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ConfirmRejReason);
            }
            
            public QuickFix.FXCM.Fields.MatchStatus MatchStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MatchStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MatchStatus val) 
            { 
                MatchStatus = val;
            }
            
            public QuickFix.FXCM.Fields.MatchStatus Get(QuickFix.FXCM.Fields.MatchStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MatchStatus val) 
            { 
                return IsSetMatchStatus();
            }
            
            public bool IsSetMatchStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MatchStatus);
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
            

    }
}

// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class AssignmentReport : Message
    {
            public const string MsgType = "AW";

            public AssignmentReport() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("AW"));
            }

            public AssignmentReport(
                    QuickFix.FXCM.Fields.AsgnRptID aAsgnRptID,
                    QuickFix.FXCM.Fields.AccountType aAccountType,
                    QuickFix.FXCM.Fields.SettlPrice aSettlPrice,
                    QuickFix.FXCM.Fields.SettlPriceType aSettlPriceType,
                    QuickFix.FXCM.Fields.UnderlyingSettlPrice aUnderlyingSettlPrice,
                    QuickFix.FXCM.Fields.AssignmentMethod aAssignmentMethod,
                    QuickFix.FXCM.Fields.OpenInterest aOpenInterest,
                    QuickFix.FXCM.Fields.ExerciseMethod aExerciseMethod,
                    QuickFix.FXCM.Fields.SettlSessID aSettlSessID,
                    QuickFix.FXCM.Fields.SettlSessSubID aSettlSessSubID,
                    QuickFix.FXCM.Fields.ClearingBusinessDate aClearingBusinessDate
                ) : this()
            {
                this.AsgnRptID = aAsgnRptID;
                this.AccountType = aAccountType;
                this.SettlPrice = aSettlPrice;
                this.SettlPriceType = aSettlPriceType;
                this.UnderlyingSettlPrice = aUnderlyingSettlPrice;
                this.AssignmentMethod = aAssignmentMethod;
                this.OpenInterest = aOpenInterest;
                this.ExerciseMethod = aExerciseMethod;
                this.SettlSessID = aSettlSessID;
                this.SettlSessSubID = aSettlSessSubID;
                this.ClearingBusinessDate = aClearingBusinessDate;
            }

            public QuickFix.FXCM.Fields.AsgnRptID AsgnRptID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AsgnRptID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AsgnRptID val) 
            { 
                AsgnRptID = val;
            }
            
            public QuickFix.FXCM.Fields.AsgnRptID Get(QuickFix.FXCM.Fields.AsgnRptID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AsgnRptID val) 
            { 
                return IsSetAsgnRptID();
            }
            
            public bool IsSetAsgnRptID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AsgnRptID);
            }
            
            public QuickFix.FXCM.Fields.TotNumAssignmentReports TotNumAssignmentReports
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TotNumAssignmentReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TotNumAssignmentReports val) 
            { 
                TotNumAssignmentReports = val;
            }
            
            public QuickFix.FXCM.Fields.TotNumAssignmentReports Get(QuickFix.FXCM.Fields.TotNumAssignmentReports val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TotNumAssignmentReports val) 
            { 
                return IsSetTotNumAssignmentReports();
            }
            
            public bool IsSetTotNumAssignmentReports() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TotNumAssignmentReports);
            }
            
            public QuickFix.FXCM.Fields.LastRptRequested LastRptRequested
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.LastRptRequested();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.LastRptRequested val) 
            { 
                LastRptRequested = val;
            }
            
            public QuickFix.FXCM.Fields.LastRptRequested Get(QuickFix.FXCM.Fields.LastRptRequested val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.LastRptRequested val) 
            { 
                return IsSetLastRptRequested();
            }
            
            public bool IsSetLastRptRequested() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.LastRptRequested);
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
            
            public QuickFix.FXCM.Fields.Account Account
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Account val) 
            { 
                Account = val;
            }
            
            public QuickFix.FXCM.Fields.Account Get(QuickFix.FXCM.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Account);
            }
            
            public QuickFix.FXCM.Fields.AccountType AccountType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccountType val) 
            { 
                AccountType = val;
            }
            
            public QuickFix.FXCM.Fields.AccountType Get(QuickFix.FXCM.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccountType);
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
            
            public QuickFix.FXCM.Fields.NoPositions NoPositions
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoPositions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoPositions val) 
            { 
                NoPositions = val;
            }
            
            public QuickFix.FXCM.Fields.NoPositions Get(QuickFix.FXCM.Fields.NoPositions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoPositions val) 
            { 
                return IsSetNoPositions();
            }
            
            public bool IsSetNoPositions() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoPositions);
            }
            
            public QuickFix.FXCM.Fields.NoPosAmt NoPosAmt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoPosAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoPosAmt val) 
            { 
                NoPosAmt = val;
            }
            
            public QuickFix.FXCM.Fields.NoPosAmt Get(QuickFix.FXCM.Fields.NoPosAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoPosAmt val) 
            { 
                return IsSetNoPosAmt();
            }
            
            public bool IsSetNoPosAmt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoPosAmt);
            }
            
            public QuickFix.FXCM.Fields.ThresholdAmount ThresholdAmount
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ThresholdAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ThresholdAmount val) 
            { 
                ThresholdAmount = val;
            }
            
            public QuickFix.FXCM.Fields.ThresholdAmount Get(QuickFix.FXCM.Fields.ThresholdAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ThresholdAmount val) 
            { 
                return IsSetThresholdAmount();
            }
            
            public bool IsSetThresholdAmount() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ThresholdAmount);
            }
            
            public QuickFix.FXCM.Fields.SettlPrice SettlPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlPrice val) 
            { 
                SettlPrice = val;
            }
            
            public QuickFix.FXCM.Fields.SettlPrice Get(QuickFix.FXCM.Fields.SettlPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlPrice val) 
            { 
                return IsSetSettlPrice();
            }
            
            public bool IsSetSettlPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPrice);
            }
            
            public QuickFix.FXCM.Fields.SettlPriceType SettlPriceType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlPriceType val) 
            { 
                SettlPriceType = val;
            }
            
            public QuickFix.FXCM.Fields.SettlPriceType Get(QuickFix.FXCM.Fields.SettlPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlPriceType val) 
            { 
                return IsSetSettlPriceType();
            }
            
            public bool IsSetSettlPriceType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlPriceType);
            }
            
            public QuickFix.FXCM.Fields.UnderlyingSettlPrice UnderlyingSettlPrice
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.UnderlyingSettlPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.UnderlyingSettlPrice val) 
            { 
                UnderlyingSettlPrice = val;
            }
            
            public QuickFix.FXCM.Fields.UnderlyingSettlPrice Get(QuickFix.FXCM.Fields.UnderlyingSettlPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.UnderlyingSettlPrice val) 
            { 
                return IsSetUnderlyingSettlPrice();
            }
            
            public bool IsSetUnderlyingSettlPrice() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.UnderlyingSettlPrice);
            }
            
            public QuickFix.FXCM.Fields.ExpireDate ExpireDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExpireDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExpireDate val) 
            { 
                ExpireDate = val;
            }
            
            public QuickFix.FXCM.Fields.ExpireDate Get(QuickFix.FXCM.Fields.ExpireDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExpireDate val) 
            { 
                return IsSetExpireDate();
            }
            
            public bool IsSetExpireDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExpireDate);
            }
            
            public QuickFix.FXCM.Fields.AssignmentMethod AssignmentMethod
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AssignmentMethod val) 
            { 
                AssignmentMethod = val;
            }
            
            public QuickFix.FXCM.Fields.AssignmentMethod Get(QuickFix.FXCM.Fields.AssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AssignmentMethod val) 
            { 
                return IsSetAssignmentMethod();
            }
            
            public bool IsSetAssignmentMethod() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AssignmentMethod);
            }
            
            public QuickFix.FXCM.Fields.AssignmentUnit AssignmentUnit
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AssignmentUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AssignmentUnit val) 
            { 
                AssignmentUnit = val;
            }
            
            public QuickFix.FXCM.Fields.AssignmentUnit Get(QuickFix.FXCM.Fields.AssignmentUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AssignmentUnit val) 
            { 
                return IsSetAssignmentUnit();
            }
            
            public bool IsSetAssignmentUnit() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AssignmentUnit);
            }
            
            public QuickFix.FXCM.Fields.OpenInterest OpenInterest
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OpenInterest();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OpenInterest val) 
            { 
                OpenInterest = val;
            }
            
            public QuickFix.FXCM.Fields.OpenInterest Get(QuickFix.FXCM.Fields.OpenInterest val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OpenInterest val) 
            { 
                return IsSetOpenInterest();
            }
            
            public bool IsSetOpenInterest() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OpenInterest);
            }
            
            public QuickFix.FXCM.Fields.ExerciseMethod ExerciseMethod
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ExerciseMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ExerciseMethod val) 
            { 
                ExerciseMethod = val;
            }
            
            public QuickFix.FXCM.Fields.ExerciseMethod Get(QuickFix.FXCM.Fields.ExerciseMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ExerciseMethod val) 
            { 
                return IsSetExerciseMethod();
            }
            
            public bool IsSetExerciseMethod() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ExerciseMethod);
            }
            
            public QuickFix.FXCM.Fields.SettlSessID SettlSessID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlSessID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlSessID val) 
            { 
                SettlSessID = val;
            }
            
            public QuickFix.FXCM.Fields.SettlSessID Get(QuickFix.FXCM.Fields.SettlSessID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlSessID val) 
            { 
                return IsSetSettlSessID();
            }
            
            public bool IsSetSettlSessID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlSessID);
            }
            
            public QuickFix.FXCM.Fields.SettlSessSubID SettlSessSubID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SettlSessSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SettlSessSubID val) 
            { 
                SettlSessSubID = val;
            }
            
            public QuickFix.FXCM.Fields.SettlSessSubID Get(QuickFix.FXCM.Fields.SettlSessSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SettlSessSubID val) 
            { 
                return IsSetSettlSessSubID();
            }
            
            public bool IsSetSettlSessSubID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SettlSessSubID);
            }
            
            public QuickFix.FXCM.Fields.ClearingBusinessDate ClearingBusinessDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClearingBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClearingBusinessDate val) 
            { 
                ClearingBusinessDate = val;
            }
            
            public QuickFix.FXCM.Fields.ClearingBusinessDate Get(QuickFix.FXCM.Fields.ClearingBusinessDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClearingBusinessDate val) 
            { 
                return IsSetClearingBusinessDate();
            }
            
            public bool IsSetClearingBusinessDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClearingBusinessDate);
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
            public class NoPositionsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.PosType, QuickFix.FXCM.Fields.Tags.LongQty, QuickFix.FXCM.Fields.Tags.ShortQty, QuickFix.FXCM.Fields.Tags.PosQtyStatus, QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, 0};
            
                public NoPositionsGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoPositions, QuickFix.FXCM.Fields.Tags.PosType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPositionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.PosType PosType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PosType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PosType val) 
                { 
                    PosType = val;
                }
                
                public QuickFix.FXCM.Fields.PosType Get(QuickFix.FXCM.Fields.PosType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PosType val) 
                { 
                    return IsSetPosType();
                }
                
                public bool IsSetPosType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PosType);
                }
                
                public QuickFix.FXCM.Fields.LongQty LongQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.LongQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.LongQty val) 
                { 
                    LongQty = val;
                }
                
                public QuickFix.FXCM.Fields.LongQty Get(QuickFix.FXCM.Fields.LongQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.LongQty val) 
                { 
                    return IsSetLongQty();
                }
                
                public bool IsSetLongQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.LongQty);
                }
                
                public QuickFix.FXCM.Fields.ShortQty ShortQty
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.ShortQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.ShortQty val) 
                { 
                    ShortQty = val;
                }
                
                public QuickFix.FXCM.Fields.ShortQty Get(QuickFix.FXCM.Fields.ShortQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.ShortQty val) 
                { 
                    return IsSetShortQty();
                }
                
                public bool IsSetShortQty() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.ShortQty);
                }
                
                public QuickFix.FXCM.Fields.PosQtyStatus PosQtyStatus
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PosQtyStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PosQtyStatus val) 
                { 
                    PosQtyStatus = val;
                }
                
                public QuickFix.FXCM.Fields.PosQtyStatus Get(QuickFix.FXCM.Fields.PosQtyStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PosQtyStatus val) 
                { 
                    return IsSetPosQtyStatus();
                }
                
                public bool IsSetPosQtyStatus() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PosQtyStatus);
                }
                
                public QuickFix.FXCM.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    NoNestedPartyIDs = val;
                }
                
                public QuickFix.FXCM.Fields.NoNestedPartyIDs Get(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs);
                }
                
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.NestedPartyID, QuickFix.FXCM.Fields.Tags.NestedPartyIDSource, QuickFix.FXCM.Fields.Tags.NestedPartyRole, QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( QuickFix.FXCM.Fields.Tags.NoNestedPartyIDs, QuickFix.FXCM.Fields.Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.FXCM.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        NestedPartyID = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyID Get(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyID);
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyIDSource Get(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyIDSource);
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        NestedPartyRole = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NestedPartyRole Get(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartyRole);
                    }
                    
                    public QuickFix.FXCM.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.FXCM.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.FXCM.Fields.NoNestedPartySubIDs Get(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.FXCM.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs);
                    }
                    
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.NestedPartySubID, QuickFix.FXCM.Fields.Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( QuickFix.FXCM.Fields.Tags.NoNestedPartySubIDs, QuickFix.FXCM.Fields.Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.FXCM.Fields.NestedPartySubID NestedPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NestedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            NestedPartySubID = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubID Get(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NestedPartySubID val) 
                        { 
                            return IsSetNestedPartySubID();
                        }
                        
                        public bool IsSetNestedPartySubID() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartySubID);
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.FXCM.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.FXCM.Fields.NestedPartySubIDType Get(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.FXCM.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.FXCM.Fields.Tags.NestedPartySubIDType);
                        }
                        
                    
                    }
                }
            }
            public class NoPosAmtGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.PosAmtType, QuickFix.FXCM.Fields.Tags.PosAmt, 0};
            
                public NoPosAmtGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoPosAmt, QuickFix.FXCM.Fields.Tags.PosAmtType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPosAmtGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.PosAmtType PosAmtType
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PosAmtType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PosAmtType val) 
                { 
                    PosAmtType = val;
                }
                
                public QuickFix.FXCM.Fields.PosAmtType Get(QuickFix.FXCM.Fields.PosAmtType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PosAmtType val) 
                { 
                    return IsSetPosAmtType();
                }
                
                public bool IsSetPosAmtType() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PosAmtType);
                }
                
                public QuickFix.FXCM.Fields.PosAmt PosAmt
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.PosAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.PosAmt val) 
                { 
                    PosAmt = val;
                }
                
                public QuickFix.FXCM.Fields.PosAmt Get(QuickFix.FXCM.Fields.PosAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.PosAmt val) 
                { 
                    return IsSetPosAmt();
                }
                
                public bool IsSetPosAmt() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.PosAmt);
                }
                
            
            }
    }
}

    public class PaymentEntryScreen
    {
        public string errorMessage { get; set; }
        public Batch myBatch { get; set; }
        public ARDoc myARDoc { get; set; }
        public List<ARTran> myARTran { get; set; }
        public Note batchNote { get; set; }
        public Note documentNote { get; set; }
    }

    public class Batch
    {
        private System.String _errorMessage = "";
        private System.String _notes = "";
        private System.Int32 _resultCode = 0;
        private System.String _Acct = "";
        private System.Int16 _AutoRev = 0;
        private System.Int16 _AutoRevCopy = 0;
        private System.String _BalanceType = "";
        private System.String _BankAcct = "";
        private System.String _BankSub = "";
        private System.String _BaseCuryID = "";
        private System.String _BatNbr = "";
        private System.String _BatType = "";
        private System.Double _clearamt = 0;
        private System.Int16 _Cleared = 0;
        private System.String _CpnyID = "";
        private System.DateTime _Crtd_DateTime = new System.DateTime(1900, 1, 1);
        private System.String _Crtd_Prog = "";
        private System.String _Crtd_User = "";
        private System.Double _CrTot = 0;
        private System.Double _CtrlTot = 0;
        private System.Double _CuryCrTot = 0;
        private System.Double _CuryCtrlTot = 0;
        private System.Double _CuryDepositAmt = 0;
        private System.Double _CuryDrTot = 0;
        private System.DateTime _CuryEffDate = new System.DateTime(1900, 1, 1);
        private System.String _CuryId = "";
        private System.String _CuryMultDiv = "";
        private System.Double _CuryRate = 0;
        private System.String _CuryRateType = "";
        private System.Int16 _Cycle = 0;
        private System.DateTime _DateClr = new System.DateTime(1900, 1, 1);
        private System.DateTime _DateEnt = new System.DateTime(1900, 1, 1);
        private System.Double _DepositAmt = 0;
        private System.String _Descr = "";
        private System.Double _DrTot = 0;
        private System.String _EditScrnNbr = "";
        private System.String _GLPostOpt = "";
        private System.String _JrnlType = "";
        private System.String _LedgerID = "";
        private System.DateTime _LUpd_DateTime = new System.DateTime(1900, 1, 1);
        private System.String _LUpd_Prog = "";
        private System.String _LUpd_User = "";
        private System.String _Module = "";
        private System.Int16 _NbrCycle = 0;
        private System.Int32 _NoteID = 0;
        private System.String _OrigBatNbr = "";
        private System.String _OrigCpnyID = "";
        private System.String _OrigScrnNbr = "";
        private System.String _PerEnt = "";
        private System.String _PerPost = "";
        private System.Int16 _Rlsed = 0;
        private System.String _S4Future01 = "";
        private System.String _S4Future02 = "";
        private System.Double _S4Future03 = 0;
        private System.Double _S4Future04 = 0;
        private System.Double _S4Future05 = 0;
        private System.Double _S4Future06 = 0;
        private System.DateTime _S4Future07 = new System.DateTime(1900, 1, 1);
        private System.DateTime _S4Future08 = new System.DateTime(1900, 1, 1);
        private System.Int32 _S4Future09 = 0;
        private System.Int32 _S4Future10 = 0;
        private System.String _S4Future11 = "";
        private System.String _S4Future12 = "";
        private System.String _Status = "";
        private System.String _Sub = "";
        private System.String _User1 = "";
        private System.String _User2 = "";
        private System.Double _User3 = 0;
        private System.Double _User4 = 0;
        private System.String _User5 = "";
        private System.String _User6 = "";
        private System.DateTime _User7 = new System.DateTime(1900, 1, 1);
        private System.DateTime _User8 = new System.DateTime(1900, 1, 1);

        public System.String errorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                try
                {
                    _errorMessage = value;
                }
                catch
                {
                    _errorMessage = value;
                }
            }
        }
        public System.String notes
        {
            get
            {
                return _notes;
            }
            set
            {
                try
                {
                    _notes = value;
                }
                catch
                {
                    _notes = value;
                }
            }
        }
        public System.Int32 resultCode
        {
            get
            {
                return _resultCode;
            }
            set
            {
                _resultCode = value;
            }
        }
        public System.String Acct
        {
            get
            {
                return _Acct;
            }
            set
            {
                try
                {
                    _Acct = value.Substring(0, 10);
                }
                catch
                {
                    _Acct = value;
                }
            }
        }
        public System.Int16 AutoRev
        {
            get
            {
                return _AutoRev;
            }
            set
            {
                _AutoRev = value;
            }
        }
        public System.Int16 AutoRevCopy
        {
            get
            {
                return _AutoRevCopy;
            }
            set
            {
                _AutoRevCopy = value;
            }
        }
        public System.String BalanceType
        {
            get
            {
                return _BalanceType;
            }
            set
            {
                try
                {
                    _BalanceType = value.Substring(0, 1);
                }
                catch
                {
                    _BalanceType = value;
                }
            }
        }
        public System.String BankAcct
        {
            get
            {
                return _BankAcct;
            }
            set
            {
                try
                {
                    _BankAcct = value.Substring(0, 10);
                }
                catch
                {
                    _BankAcct = value;
                }
            }
        }
        public System.String BankSub
        {
            get
            {
                return _BankSub;
            }
            set
            {
                try
                {
                    _BankSub = value.Substring(0, 24);
                }
                catch
                {
                    _BankSub = value;
                }
            }
        }
        public System.String BaseCuryID
        {
            get
            {
                return _BaseCuryID;
            }
            set
            {
                try
                {
                    _BaseCuryID = value.Substring(0, 4);
                }
                catch
                {
                    _BaseCuryID = value;
                }
            }
        }
        public System.String BatNbr
        {
            get
            {
                return _BatNbr;
            }
            set
            {
                try
                {
                    _BatNbr = value.Substring(0, 10);
                }
                catch
                {
                    _BatNbr = value;
                }
            }
        }
        public System.String BatType
        {
            get
            {
                return _BatType;
            }
            set
            {
                try
                {
                    _BatType = value.Substring(0, 1);
                }
                catch
                {
                    _BatType = value;
                }
            }
        }
        public System.Double clearamt
        {
            get
            {
                return _clearamt;
            }
            set
            {
                _clearamt = value;
            }
        }
        public System.Int16 Cleared
        {
            get
            {
                return _Cleared;
            }
            set
            {
                _Cleared = value;
            }
        }
        public System.String CpnyID
        {
            get
            {
                return _CpnyID;
            }
            set
            {
                try
                {
                    _CpnyID = value.Substring(0, 10);
                }
                catch
                {
                    _CpnyID = value;
                }
            }
        }
        public System.DateTime Crtd_DateTime
        {
            get
            {
                if (_Crtd_DateTime.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _Crtd_DateTime;
                }
            }
            set
            {
                _Crtd_DateTime = value;
            }
        }
        public System.String Crtd_Prog
        {
            get
            {
                return _Crtd_Prog;
            }
            set
            {
                try
                {
                    _Crtd_Prog = value.Substring(0, 8);
                }
                catch
                {
                    _Crtd_Prog = value;
                }
            }
        }
        public System.String Crtd_User
        {
            get
            {
                return _Crtd_User;
            }
            set
            {
                try
                {
                    _Crtd_User = value.Substring(0, 10);
                }
                catch
                {
                    _Crtd_User = value;
                }
            }
        }
        public System.Double CrTot
        {
            get
            {
                return _CrTot;
            }
            set
            {
                _CrTot = value;
            }
        }
        public System.Double CtrlTot
        {
            get
            {
                return _CtrlTot;
            }
            set
            {
                _CtrlTot = value;
            }
        }
        public System.Double CuryCrTot
        {
            get
            {
                return _CuryCrTot;
            }
            set
            {
                _CuryCrTot = value;
            }
        }
        public System.Double CuryCtrlTot
        {
            get
            {
                return _CuryCtrlTot;
            }
            set
            {
                _CuryCtrlTot = value;
            }
        }
        public System.Double CuryDepositAmt
        {
            get
            {
                return _CuryDepositAmt;
            }
            set
            {
                _CuryDepositAmt = value;
            }
        }
        public System.Double CuryDrTot
        {
            get
            {
                return _CuryDrTot;
            }
            set
            {
                _CuryDrTot = value;
            }
        }
        public System.DateTime CuryEffDate
        {
            get
            {
                if (_CuryEffDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _CuryEffDate;
                }
            }
            set
            {
                _CuryEffDate = value;
            }
        }
        public System.String CuryId
        {
            get
            {
                return _CuryId;
            }
            set
            {
                try
                {
                    _CuryId = value.Substring(0, 4);
                }
                catch
                {
                    _CuryId = value;
                }
            }
        }
        public System.String CuryMultDiv
        {
            get
            {
                return _CuryMultDiv;
            }
            set
            {
                try
                {
                    _CuryMultDiv = value.Substring(0, 1);
                }
                catch
                {
                    _CuryMultDiv = value;
                }
            }
        }
        public System.Double CuryRate
        {
            get
            {
                return _CuryRate;
            }
            set
            {
                _CuryRate = value;
            }
        }
        public System.String CuryRateType
        {
            get
            {
                return _CuryRateType;
            }
            set
            {
                try
                {
                    _CuryRateType = value.Substring(0, 6);
                }
                catch
                {
                    _CuryRateType = value;
                }
            }
        }
        public System.Int16 Cycle
        {
            get
            {
                return _Cycle;
            }
            set
            {
                _Cycle = value;
            }
        }
        public System.DateTime DateClr
        {
            get
            {
                if (_DateClr.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _DateClr;
                }
            }
            set
            {
                _DateClr = value;
            }
        }
        public System.DateTime DateEnt
        {
            get
            {
                if (_DateEnt.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _DateEnt;
                }
            }
            set
            {
                _DateEnt = value;
            }
        }
        public System.Double DepositAmt
        {
            get
            {
                return _DepositAmt;
            }
            set
            {
                _DepositAmt = value;
            }
        }
        public System.String Descr
        {
            get
            {
                return _Descr;
            }
            set
            {
                try
                {
                    _Descr = value.Substring(0, 30);
                }
                catch
                {
                    _Descr = value;
                }
            }
        }
        public System.Double DrTot
        {
            get
            {
                return _DrTot;
            }
            set
            {
                _DrTot = value;
            }
        }
        public System.String EditScrnNbr
        {
            get
            {
                return _EditScrnNbr;
            }
            set
            {
                try
                {
                    _EditScrnNbr = value.Substring(0, 5);
                }
                catch
                {
                    _EditScrnNbr = value;
                }
            }
        }
        public System.String GLPostOpt
        {
            get
            {
                return _GLPostOpt;
            }
            set
            {
                try
                {
                    _GLPostOpt = value.Substring(0, 1);
                }
                catch
                {
                    _GLPostOpt = value;
                }
            }
        }
        public System.String JrnlType
        {
            get
            {
                return _JrnlType;
            }
            set
            {
                try
                {
                    _JrnlType = value.Substring(0, 3);
                }
                catch
                {
                    _JrnlType = value;
                }
            }
        }
        public System.String LedgerID
        {
            get
            {
                return _LedgerID;
            }
            set
            {
                try
                {
                    _LedgerID = value.Substring(0, 10);
                }
                catch
                {
                    _LedgerID = value;
                }
            }
        }
        public System.DateTime LUpd_DateTime
        {
            get
            {
                if (_LUpd_DateTime.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _LUpd_DateTime;
                }
            }
            set
            {
                _LUpd_DateTime = value;
            }
        }
        public System.String LUpd_Prog
        {
            get
            {
                return _LUpd_Prog;
            }
            set
            {
                try
                {
                    _LUpd_Prog = value.Substring(0, 8);
                }
                catch
                {
                    _LUpd_Prog = value;
                }
            }
        }
        public System.String LUpd_User
        {
            get
            {
                return _LUpd_User;
            }
            set
            {
                try
                {
                    _LUpd_User = value.Substring(0, 10);
                }
                catch
                {
                    _LUpd_User = value;
                }
            }
        }
        public System.String Module
        {
            get
            {
                return _Module;
            }
            set
            {
                try
                {
                    _Module = value.Substring(0, 2);
                }
                catch
                {
                    _Module = value;
                }
            }
        }
        public System.Int16 NbrCycle
        {
            get
            {
                return _NbrCycle;
            }
            set
            {
                _NbrCycle = value;
            }
        }
        public System.Int32 NoteID
        {
            get
            {
                return _NoteID;
            }
            set
            {
                _NoteID = value;
            }
        }
        public System.String OrigBatNbr
        {
            get
            {
                return _OrigBatNbr;
            }
            set
            {
                try
                {
                    _OrigBatNbr = value.Substring(0, 10);
                }
                catch
                {
                    _OrigBatNbr = value;
                }
            }
        }
        public System.String OrigCpnyID
        {
            get
            {
                return _OrigCpnyID;
            }
            set
            {
                try
                {
                    _OrigCpnyID = value.Substring(0, 10);
                }
                catch
                {
                    _OrigCpnyID = value;
                }
            }
        }
        public System.String OrigScrnNbr
        {
            get
            {
                return _OrigScrnNbr;
            }
            set
            {
                try
                {
                    _OrigScrnNbr = value.Substring(0, 5);
                }
                catch
                {
                    _OrigScrnNbr = value;
                }
            }
        }
        public System.String PerEnt
        {
            get
            {
                return _PerEnt;
            }
            set
            {
                try
                {
                    _PerEnt = value.Substring(0, 6);
                }
                catch
                {
                    _PerEnt = value;
                }
            }
        }
        public System.String PerPost
        {
            get
            {
                return _PerPost;
            }
            set
            {
                try
                {
                    _PerPost = value.Substring(0, 6);
                }
                catch
                {
                    _PerPost = value;
                }
            }
        }
        public System.Int16 Rlsed
        {
            get
            {
                return _Rlsed;
            }
            set
            {
                _Rlsed = value;
            }
        }
        public System.String S4Future01
        {
            get
            {
                return _S4Future01;
            }
            set
            {
                try
                {
                    _S4Future01 = value.Substring(0, 30);
                }
                catch
                {
                    _S4Future01 = value;
                }
            }
        }
        public System.String S4Future02
        {
            get
            {
                return _S4Future02;
            }
            set
            {
                try
                {
                    _S4Future02 = value.Substring(0, 30);
                }
                catch
                {
                    _S4Future02 = value;
                }
            }
        }
        public System.Double S4Future03
        {
            get
            {
                return _S4Future03;
            }
            set
            {
                _S4Future03 = value;
            }
        }
        public System.Double S4Future04
        {
            get
            {
                return _S4Future04;
            }
            set
            {
                _S4Future04 = value;
            }
        }
        public System.Double S4Future05
        {
            get
            {
                return _S4Future05;
            }
            set
            {
                _S4Future05 = value;
            }
        }
        public System.Double S4Future06
        {
            get
            {
                return _S4Future06;
            }
            set
            {
                _S4Future06 = value;
            }
        }
        public System.DateTime S4Future07
        {
            get
            {
                if (_S4Future07.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _S4Future07;
                }
            }
            set
            {
                _S4Future07 = value;
            }
        }
        public System.DateTime S4Future08
        {
            get
            {
                if (_S4Future08.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _S4Future08;
                }
            }
            set
            {
                _S4Future08 = value;
            }
        }
        public System.Int32 S4Future09
        {
            get
            {
                return _S4Future09;
            }
            set
            {
                _S4Future09 = value;
            }
        }
        public System.Int32 S4Future10
        {
            get
            {
                return _S4Future10;
            }
            set
            {
                _S4Future10 = value;
            }
        }
        public System.String S4Future11
        {
            get
            {
                return _S4Future11;
            }
            set
            {
                try
                {
                    _S4Future11 = value.Substring(0, 10);
                }
                catch
                {
                    _S4Future11 = value;
                }
            }
        }
        public System.String S4Future12
        {
            get
            {
                return _S4Future12;
            }
            set
            {
                try
                {
                    _S4Future12 = value.Substring(0, 10);
                }
                catch
                {
                    _S4Future12 = value;
                }
            }
        }
        public System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                try
                {
                    _Status = value.Substring(0, 1);
                }
                catch
                {
                    _Status = value;
                }
            }
        }
        public System.String Sub
        {
            get
            {
                return _Sub;
            }
            set
            {
                try
                {
                    _Sub = value.Substring(0, 24);
                }
                catch
                {
                    _Sub = value;
                }
            }
        }
        public System.String User1
        {
            get
            {
                return _User1;
            }
            set
            {
                try
                {
                    _User1 = value.Substring(0, 30);
                }
                catch
                {
                    _User1 = value;
                }
            }
        }
        public System.String User2
        {
            get
            {
                return _User2;
            }
            set
            {
                try
                {
                    _User2 = value.Substring(0, 30);
                }
                catch
                {
                    _User2 = value;
                }
            }
        }
        public System.Double User3
        {
            get
            {
                return _User3;
            }
            set
            {
                _User3 = value;
            }
        }
        public System.Double User4
        {
            get
            {
                return _User4;
            }
            set
            {
                _User4 = value;
            }
        }
        public System.String User5
        {
            get
            {
                return _User5;
            }
            set
            {
                try
                {
                    _User5 = value.Substring(0, 10);
                }
                catch
                {
                    _User5 = value;
                }
            }
        }
        public System.String User6
        {
            get
            {
                return _User6;
            }
            set
            {
                try
                {
                    _User6 = value.Substring(0, 10);
                }
                catch
                {
                    _User6 = value;
                }
            }
        }
        public System.DateTime User7
        {
            get
            {
                if (_User7.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _User7;
                }
            }
            set
            {
                _User7 = value;
            }
        }
        public System.DateTime User8
        {
            get
            {
                if (_User8.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _User8;
                }
            }
            set
            {
                _User8 = value;
            }
        }
    }

    public class ARDoc
    {
        private System.String _errorMessage = "";
        private System.String _notes = "";
        private System.Int32 _resultCode = 0;
        private System.String _AcctNbr = "";
        private System.String _AgentID = "";
        private System.Double _ApplAmt = 0;
        private System.String _ApplBatNbr = "";
        private System.Int32 _ApplBatSeq = 0;
        private System.Int32 _ASID = 0;
        private System.String _BankAcct = "";
        private System.String _BankID = "";
        private System.String _BankSub = "";
        private System.String _BatNbr = "";
        private System.Int32 _BatSeq = 0;
        private System.DateTime _Cleardate = new System.DateTime(1900, 1, 1);
        private System.Double _CmmnAmt = 0;
        private System.Double _CmmnPct = 0;
        private System.String _ContractID = "";
        private System.String _CpnyID = "";
        private System.DateTime _Crtd_DateTime = new System.DateTime(1900, 1, 1);
        private System.String _Crtd_Prog = "";
        private System.String _Crtd_User = "";
        private System.Int16 _CurrentNbr = 0;
        private System.Double _CuryApplAmt = 0;
        private System.Double _CuryClearAmt = 0;
        private System.Double _CuryCmmnAmt = 0;
        private System.Double _CuryDiscApplAmt = 0;
        private System.Double _CuryDiscBal = 0;
        private System.Double _CuryDocBal = 0;
        private System.DateTime _CuryEffDate = new System.DateTime(1900, 1, 1);
        private System.String _CuryId = "";
        private System.String _CuryMultDiv = "";
        private System.Double _CuryOrigDocAmt = 0;
        private System.Double _CuryRate = 0;
        private System.String _CuryRateType = "";
        private System.Double _CuryStmtBal = 0;
        private System.Double _CuryTaxTot00 = 0;
        private System.Double _CuryTaxTot01 = 0;
        private System.Double _CuryTaxTot02 = 0;
        private System.Double _CuryTaxTot03 = 0;
        private System.Double _CuryTxblTot00 = 0;
        private System.Double _CuryTxblTot01 = 0;
        private System.Double _CuryTxblTot02 = 0;
        private System.Double _CuryTxblTot03 = 0;
        private System.String _CustId = "";
        private System.String _CustOrdNbr = "";
        private System.Int16 _Cycle = 0;
        private System.Double _DiscApplAmt = 0;
        private System.Double _DiscBal = 0;
        private System.DateTime _DiscDate = new System.DateTime(1900, 1, 1);
        private System.Double _DocBal = 0;
        private System.String _DocClass = "";
        private System.DateTime _DocDate = new System.DateTime(1900, 1, 1);
        private System.String _DocDesc = "";
        private System.String _DocType = "";
        private System.Int16 _DraftIssued = 0;
        private System.DateTime _DueDate = new System.DateTime(1900, 1, 1);
        private System.Int16 _InstallNbr = 0;
        private System.Int16 _JobCntr = 0;
        private System.Int32 _LineCntr = 0;
        private System.DateTime _LUpd_DateTime = new System.DateTime(1900, 1, 1);
        private System.String _LUpd_Prog = "";
        private System.String _LUpd_User = "";
        private System.String _MasterDocNbr = "";
        private System.Int16 _NbrCycle = 0;
        private System.Int16 _NoPrtStmt = 0;
        private System.Int32 _NoteId = 0;
        private System.Int16 _OpenDoc = 0;
        private System.String _OrdNbr = "";
        private System.String _OrigBankAcct = "";
        private System.String _OrigBankSub = "";
        private System.String _OrigCpnyID = "";
        private System.Double _OrigDocAmt = 0;
        private System.String _OrigDocNbr = "";
        private System.String _PC_Status = "";
        private System.String _PerClosed = "";
        private System.String _PerEnt = "";
        private System.String _PerPost = "";
        private System.String _PmtMethod = "";
        private System.String _ProjectID = "";
        private System.String _RefNbr = "";
        private System.Double _RGOLAmt = 0;
        private System.Int16 _Rlsed = 0;
        private System.String _S4Future01 = "";
        private System.String _S4Future02 = "";
        private System.Double _S4Future03 = 0;
        private System.Double _S4Future04 = 0;
        private System.Double _S4Future05 = 0;
        private System.Double _S4Future06 = 0;
        private System.DateTime _S4Future07 = new System.DateTime(1900, 1, 1);
        private System.DateTime _S4Future08 = new System.DateTime(1900, 1, 1);
        private System.Int32 _S4Future09 = 0;
        private System.Int32 _S4Future10 = 0;
        private System.String _S4Future11 = "";
        private System.String _S4Future12 = "";
        private System.String _ServiceCallID = "";
        private System.Int16 _ShipmentNbr = 0;
        private System.String _SlsperId = "";
        private System.String _Status = "";
        private System.Double _StmtBal = 0;
        private System.DateTime _StmtDate = new System.DateTime(1900, 1, 1);
        private System.String _TaskID = "";
        private System.Int16 _TaxCntr00 = 0;
        private System.Int16 _TaxCntr01 = 0;
        private System.Int16 _TaxCntr02 = 0;
        private System.Int16 _TaxCntr03 = 0;
        private System.String _TaxId00 = "";
        private System.String _TaxId01 = "";
        private System.String _TaxId02 = "";
        private System.String _TaxId03 = "";
        private System.Double _TaxTot00 = 0;
        private System.Double _TaxTot01 = 0;
        private System.Double _TaxTot02 = 0;
        private System.Double _TaxTot03 = 0;
        private System.String _Terms = "";
        private System.Double _TxblTot00 = 0;
        private System.Double _TxblTot01 = 0;
        private System.Double _TxblTot02 = 0;
        private System.Double _TxblTot03 = 0;
        private System.String _User1 = "";
        private System.String _User2 = "";
        private System.Double _User3 = 0;
        private System.Double _User4 = 0;
        private System.String _User5 = "";
        private System.String _User6 = "";
        private System.DateTime _User7 = new System.DateTime(1900, 1, 1);
        private System.DateTime _User8 = new System.DateTime(1900, 1, 1);
        private System.Int32 _WSID = 0;

        public System.String errorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                try
                {
                    _errorMessage = value;
                }
                catch
                {
                    _errorMessage = value;
                }
            }
        }
        public System.String notes
        {
            get
            {
                return _notes;
            }
            set
            {
                try
                {
                    _notes = value;
                }
                catch
                {
                    _notes = value;
                }
            }
        }
        public System.Int32 resultCode
        {
            get
            {
                return _resultCode;
            }
            set
            {
                _resultCode = value;
            }
        }
        public System.String AcctNbr
        {
            get
            {
                return _AcctNbr;
            }
            set
            {
                try
                {
                    _AcctNbr = value.Substring(0, 30);
                }
                catch
                {
                    _AcctNbr = value;
                }
            }
        }
        public System.String AgentID
        {
            get
            {
                return _AgentID;
            }
            set
            {
                try
                {
                    _AgentID = value.Substring(0, 10);
                }
                catch
                {
                    _AgentID = value;
                }
            }
        }
        public System.Double ApplAmt
        {
            get
            {
                return _ApplAmt;
            }
            set
            {
                _ApplAmt = value;
            }
        }
        public System.String ApplBatNbr
        {
            get
            {
                return _ApplBatNbr;
            }
            set
            {
                try
                {
                    _ApplBatNbr = value.Substring(0, 10);
                }
                catch
                {
                    _ApplBatNbr = value;
                }
            }
        }
        public System.Int32 ApplBatSeq
        {
            get
            {
                return _ApplBatSeq;
            }
            set
            {
                _ApplBatSeq = value;
            }
        }
        public System.Int32 ASID
        {
            get
            {
                return _ASID;
            }
            set
            {
                _ASID = value;
            }
        }
        public System.String BankAcct
        {
            get
            {
                return _BankAcct;
            }
            set
            {
                try
                {
                    _BankAcct = value.Substring(0, 10);
                }
                catch
                {
                    _BankAcct = value;
                }
            }
        }
        public System.String BankID
        {
            get
            {
                return _BankID;
            }
            set
            {
                try
                {
                    _BankID = value.Substring(0, 10);
                }
                catch
                {
                    _BankID = value;
                }
            }
        }
        public System.String BankSub
        {
            get
            {
                return _BankSub;
            }
            set
            {
                try
                {
                    _BankSub = value.Substring(0, 24);
                }
                catch
                {
                    _BankSub = value;
                }
            }
        }
        public System.String BatNbr
        {
            get
            {
                return _BatNbr;
            }
            set
            {
                try
                {
                    _BatNbr = value.Substring(0, 10);
                }
                catch
                {
                    _BatNbr = value;
                }
            }
        }
        public System.Int32 BatSeq
        {
            get
            {
                return _BatSeq;
            }
            set
            {
                _BatSeq = value;
            }
        }
        public System.DateTime Cleardate
        {
            get
            {
                if (_Cleardate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _Cleardate;
                }
            }
            set
            {
                _Cleardate = value;
            }
        }
        public System.Double CmmnAmt
        {
            get
            {
                return _CmmnAmt;
            }
            set
            {
                _CmmnAmt = value;
            }
        }
        public System.Double CmmnPct
        {
            get
            {
                return _CmmnPct;
            }
            set
            {
                _CmmnPct = value;
            }
        }
        public System.String ContractID
        {
            get
            {
                return _ContractID;
            }
            set
            {
                try
                {
                    _ContractID = value.Substring(0, 10);
                }
                catch
                {
                    _ContractID = value;
                }
            }
        }
        public System.String CpnyID
        {
            get
            {
                return _CpnyID;
            }
            set
            {
                try
                {
                    _CpnyID = value.Substring(0, 10);
                }
                catch
                {
                    _CpnyID = value;
                }
            }
        }
        public System.DateTime Crtd_DateTime
        {
            get
            {
                if (_Crtd_DateTime.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _Crtd_DateTime;
                }
            }
            set
            {
                _Crtd_DateTime = value;
            }
        }
        public System.String Crtd_Prog
        {
            get
            {
                return _Crtd_Prog;
            }
            set
            {
                try
                {
                    _Crtd_Prog = value.Substring(0, 8);
                }
                catch
                {
                    _Crtd_Prog = value;
                }
            }
        }
        public System.String Crtd_User
        {
            get
            {
                return _Crtd_User;
            }
            set
            {
                try
                {
                    _Crtd_User = value.Substring(0, 10);
                }
                catch
                {
                    _Crtd_User = value;
                }
            }
        }
        public System.Int16 CurrentNbr
        {
            get
            {
                return _CurrentNbr;
            }
            set
            {
                _CurrentNbr = value;
            }
        }
        public System.Double CuryApplAmt
        {
            get
            {
                return _CuryApplAmt;
            }
            set
            {
                _CuryApplAmt = value;
            }
        }
        public System.Double CuryClearAmt
        {
            get
            {
                return _CuryClearAmt;
            }
            set
            {
                _CuryClearAmt = value;
            }
        }
        public System.Double CuryCmmnAmt
        {
            get
            {
                return _CuryCmmnAmt;
            }
            set
            {
                _CuryCmmnAmt = value;
            }
        }
        public System.Double CuryDiscApplAmt
        {
            get
            {
                return _CuryDiscApplAmt;
            }
            set
            {
                _CuryDiscApplAmt = value;
            }
        }
        public System.Double CuryDiscBal
        {
            get
            {
                return _CuryDiscBal;
            }
            set
            {
                _CuryDiscBal = value;
            }
        }
        public System.Double CuryDocBal
        {
            get
            {
                return _CuryDocBal;
            }
            set
            {
                _CuryDocBal = value;
            }
        }
        public System.DateTime CuryEffDate
        {
            get
            {
                if (_CuryEffDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _CuryEffDate;
                }
            }
            set
            {
                _CuryEffDate = value;
            }
        }
        public System.String CuryId
        {
            get
            {
                return _CuryId;
            }
            set
            {
                try
                {
                    _CuryId = value.Substring(0, 4);
                }
                catch
                {
                    _CuryId = value;
                }
            }
        }
        public System.String CuryMultDiv
        {
            get
            {
                return _CuryMultDiv;
            }
            set
            {
                try
                {
                    _CuryMultDiv = value.Substring(0, 1);
                }
                catch
                {
                    _CuryMultDiv = value;
                }
            }
        }
        public System.Double CuryOrigDocAmt
        {
            get
            {
                return _CuryOrigDocAmt;
            }
            set
            {
                _CuryOrigDocAmt = value;
            }
        }
        public System.Double CuryRate
        {
            get
            {
                return _CuryRate;
            }
            set
            {
                _CuryRate = value;
            }
        }
        public System.String CuryRateType
        {
            get
            {
                return _CuryRateType;
            }
            set
            {
                try
                {
                    _CuryRateType = value.Substring(0, 6);
                }
                catch
                {
                    _CuryRateType = value;
                }
            }
        }
        public System.Double CuryStmtBal
        {
            get
            {
                return _CuryStmtBal;
            }
            set
            {
                _CuryStmtBal = value;
            }
        }
        public System.Double CuryTaxTot00
        {
            get
            {
                return _CuryTaxTot00;
            }
            set
            {
                _CuryTaxTot00 = value;
            }
        }
        public System.Double CuryTaxTot01
        {
            get
            {
                return _CuryTaxTot01;
            }
            set
            {
                _CuryTaxTot01 = value;
            }
        }
        public System.Double CuryTaxTot02
        {
            get
            {
                return _CuryTaxTot02;
            }
            set
            {
                _CuryTaxTot02 = value;
            }
        }
        public System.Double CuryTaxTot03
        {
            get
            {
                return _CuryTaxTot03;
            }
            set
            {
                _CuryTaxTot03 = value;
            }
        }
        public System.Double CuryTxblTot00
        {
            get
            {
                return _CuryTxblTot00;
            }
            set
            {
                _CuryTxblTot00 = value;
            }
        }
        public System.Double CuryTxblTot01
        {
            get
            {
                return _CuryTxblTot01;
            }
            set
            {
                _CuryTxblTot01 = value;
            }
        }
        public System.Double CuryTxblTot02
        {
            get
            {
                return _CuryTxblTot02;
            }
            set
            {
                _CuryTxblTot02 = value;
            }
        }
        public System.Double CuryTxblTot03
        {
            get
            {
                return _CuryTxblTot03;
            }
            set
            {
                _CuryTxblTot03 = value;
            }
        }
        public System.String CustId
        {
            get
            {
                return _CustId;
            }
            set
            {
                try
                {
                    _CustId = value.Substring(0, 15);
                }
                catch
                {
                    _CustId = value;
                }
            }
        }
        public System.String CustOrdNbr
        {
            get
            {
                return _CustOrdNbr;
            }
            set
            {
                try
                {
                    _CustOrdNbr = value.Substring(0, 25);
                }
                catch
                {
                    _CustOrdNbr = value;
                }
            }
        }
        public System.Int16 Cycle
        {
            get
            {
                return _Cycle;
            }
            set
            {
                _Cycle = value;
            }
        }
        public System.Double DiscApplAmt
        {
            get
            {
                return _DiscApplAmt;
            }
            set
            {
                _DiscApplAmt = value;
            }
        }
        public System.Double DiscBal
        {
            get
            {
                return _DiscBal;
            }
            set
            {
                _DiscBal = value;
            }
        }
        public System.DateTime DiscDate
        {
            get
            {
                if (_DiscDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _DiscDate;
                }
            }
            set
            {
                _DiscDate = value;
            }
        }
        public System.Double DocBal
        {
            get
            {
                return _DocBal;
            }
            set
            {
                _DocBal = value;
            }
        }
        public System.String DocClass
        {
            get
            {
                return _DocClass;
            }
            set
            {
                try
                {
                    _DocClass = value.Substring(0, 1);
                }
                catch
                {
                    _DocClass = value;
                }
            }
        }
        public System.DateTime DocDate
        {
            get
            {
                if (_DocDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _DocDate;
                }
            }
            set
            {
                _DocDate = value;
            }
        }
        public System.String DocDesc
        {
            get
            {
                return _DocDesc;
            }
            set
            {
                try
                {
                    _DocDesc = value.Substring(0, 30);
                }
                catch
                {
                    _DocDesc = value;
                }
            }
        }
        public System.String DocType
        {
            get
            {
                return _DocType;
            }
            set
            {
                try
                {
                    _DocType = value.Substring(0, 2);
                }
                catch
                {
                    _DocType = value;
                }
            }
        }
        public System.Int16 DraftIssued
        {
            get
            {
                return _DraftIssued;
            }
            set
            {
                _DraftIssued = value;
            }
        }
        public System.DateTime DueDate
        {
            get
            {
                if (_DueDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _DueDate;
                }
            }
            set
            {
                _DueDate = value;
            }
        }
        public System.Int16 InstallNbr
        {
            get
            {
                return _InstallNbr;
            }
            set
            {
                _InstallNbr = value;
            }
        }
        public System.Int16 JobCntr
        {
            get
            {
                return _JobCntr;
            }
            set
            {
                _JobCntr = value;
            }
        }
        public System.Int32 LineCntr
        {
            get
            {
                return _LineCntr;
            }
            set
            {
                _LineCntr = value;
            }
        }
        public System.DateTime LUpd_DateTime
        {
            get
            {
                if (_LUpd_DateTime.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _LUpd_DateTime;
                }
            }
            set
            {
                _LUpd_DateTime = value;
            }
        }
        public System.String LUpd_Prog
        {
            get
            {
                return _LUpd_Prog;
            }
            set
            {
                try
                {
                    _LUpd_Prog = value.Substring(0, 8);
                }
                catch
                {
                    _LUpd_Prog = value;
                }
            }
        }
        public System.String LUpd_User
        {
            get
            {
                return _LUpd_User;
            }
            set
            {
                try
                {
                    _LUpd_User = value.Substring(0, 10);
                }
                catch
                {
                    _LUpd_User = value;
                }
            }
        }
        public System.String MasterDocNbr
        {
            get
            {
                return _MasterDocNbr;
            }
            set
            {
                try
                {
                    _MasterDocNbr = value.Substring(0, 10);
                }
                catch
                {
                    _MasterDocNbr = value;
                }
            }
        }
        public System.Int16 NbrCycle
        {
            get
            {
                return _NbrCycle;
            }
            set
            {
                _NbrCycle = value;
            }
        }
        public System.Int16 NoPrtStmt
        {
            get
            {
                return _NoPrtStmt;
            }
            set
            {
                _NoPrtStmt = value;
            }
        }
        public System.Int32 NoteId
        {
            get
            {
                return _NoteId;
            }
            set
            {
                _NoteId = value;
            }
        }
        public System.Int16 OpenDoc
        {
            get
            {
                return _OpenDoc;
            }
            set
            {
                _OpenDoc = value;
            }
        }
        public System.String OrdNbr
        {
            get
            {
                return _OrdNbr;
            }
            set
            {
                try
                {
                    _OrdNbr = value.Substring(0, 15);
                }
                catch
                {
                    _OrdNbr = value;
                }
            }
        }
        public System.String OrigBankAcct
        {
            get
            {
                return _OrigBankAcct;
            }
            set
            {
                try
                {
                    _OrigBankAcct = value.Substring(0, 10);
                }
                catch
                {
                    _OrigBankAcct = value;
                }
            }
        }
        public System.String OrigBankSub
        {
            get
            {
                return _OrigBankSub;
            }
            set
            {
                try
                {
                    _OrigBankSub = value.Substring(0, 24);
                }
                catch
                {
                    _OrigBankSub = value;
                }
            }
        }
        public System.String OrigCpnyID
        {
            get
            {
                return _OrigCpnyID;
            }
            set
            {
                try
                {
                    _OrigCpnyID = value.Substring(0, 10);
                }
                catch
                {
                    _OrigCpnyID = value;
                }
            }
        }
        public System.Double OrigDocAmt
        {
            get
            {
                return _OrigDocAmt;
            }
            set
            {
                _OrigDocAmt = value;
            }
        }
        public System.String OrigDocNbr
        {
            get
            {
                return _OrigDocNbr;
            }
            set
            {
                try
                {
                    _OrigDocNbr = value.Substring(0, 10);
                }
                catch
                {
                    _OrigDocNbr = value;
                }
            }
        }
        public System.String PC_Status
        {
            get
            {
                return _PC_Status;
            }
            set
            {
                try
                {
                    _PC_Status = value.Substring(0, 1);
                }
                catch
                {
                    _PC_Status = value;
                }
            }
        }
        public System.String PerClosed
        {
            get
            {
                return _PerClosed;
            }
            set
            {
                try
                {
                    _PerClosed = value.Substring(0, 6);
                }
                catch
                {
                    _PerClosed = value;
                }
            }
        }
        public System.String PerEnt
        {
            get
            {
                return _PerEnt;
            }
            set
            {
                try
                {
                    _PerEnt = value.Substring(0, 6);
                }
                catch
                {
                    _PerEnt = value;
                }
            }
        }
        public System.String PerPost
        {
            get
            {
                return _PerPost;
            }
            set
            {
                try
                {
                    _PerPost = value.Substring(0, 6);
                }
                catch
                {
                    _PerPost = value;
                }
            }
        }
        public System.String PmtMethod
        {
            get
            {
                return _PmtMethod;
            }
            set
            {
                try
                {
                    _PmtMethod = value.Substring(0, 1);
                }
                catch
                {
                    _PmtMethod = value;
                }
            }
        }
        public System.String ProjectID
        {
            get
            {
                return _ProjectID;
            }
            set
            {
                try
                {
                    _ProjectID = value.Substring(0, 16);
                }
                catch
                {
                    _ProjectID = value;
                }
            }
        }
        public System.String RefNbr
        {
            get
            {
                return _RefNbr;
            }
            set
            {
                try
                {
                    _RefNbr = value.Substring(0, 10);
                }
                catch
                {
                    _RefNbr = value;
                }
            }
        }
        public System.Double RGOLAmt
        {
            get
            {
                return _RGOLAmt;
            }
            set
            {
                _RGOLAmt = value;
            }
        }
        public System.Int16 Rlsed
        {
            get
            {
                return _Rlsed;
            }
            set
            {
                _Rlsed = value;
            }
        }
        public System.String S4Future01
        {
            get
            {
                return _S4Future01;
            }
            set
            {
                try
                {
                    _S4Future01 = value.Substring(0, 30);
                }
                catch
                {
                    _S4Future01 = value;
                }
            }
        }
        public System.String S4Future02
        {
            get
            {
                return _S4Future02;
            }
            set
            {
                try
                {
                    _S4Future02 = value.Substring(0, 30);
                }
                catch
                {
                    _S4Future02 = value;
                }
            }
        }
        public System.Double S4Future03
        {
            get
            {
                return _S4Future03;
            }
            set
            {
                _S4Future03 = value;
            }
        }
        public System.Double S4Future04
        {
            get
            {
                return _S4Future04;
            }
            set
            {
                _S4Future04 = value;
            }
        }
        public System.Double S4Future05
        {
            get
            {
                return _S4Future05;
            }
            set
            {
                _S4Future05 = value;
            }
        }
        public System.Double S4Future06
        {
            get
            {
                return _S4Future06;
            }
            set
            {
                _S4Future06 = value;
            }
        }
        public System.DateTime S4Future07
        {
            get
            {
                if (_S4Future07.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _S4Future07;
                }
            }
            set
            {
                _S4Future07 = value;
            }
        }
        public System.DateTime S4Future08
        {
            get
            {
                if (_S4Future08.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _S4Future08;
                }
            }
            set
            {
                _S4Future08 = value;
            }
        }
        public System.Int32 S4Future09
        {
            get
            {
                return _S4Future09;
            }
            set
            {
                _S4Future09 = value;
            }
        }
        public System.Int32 S4Future10
        {
            get
            {
                return _S4Future10;
            }
            set
            {
                _S4Future10 = value;
            }
        }
        public System.String S4Future11
        {
            get
            {
                return _S4Future11;
            }
            set
            {
                try
                {
                    _S4Future11 = value.Substring(0, 10);
                }
                catch
                {
                    _S4Future11 = value;
                }
            }
        }
        public System.String S4Future12
        {
            get
            {
                return _S4Future12;
            }
            set
            {
                try
                {
                    _S4Future12 = value.Substring(0, 10);
                }
                catch
                {
                    _S4Future12 = value;
                }
            }
        }
        public System.String ServiceCallID
        {
            get
            {
                return _ServiceCallID;
            }
            set
            {
                try
                {
                    _ServiceCallID = value.Substring(0, 10);
                }
                catch
                {
                    _ServiceCallID = value;
                }
            }
        }
        public System.Int16 ShipmentNbr
        {
            get
            {
                return _ShipmentNbr;
            }
            set
            {
                _ShipmentNbr = value;
            }
        }
        public System.String SlsperId
        {
            get
            {
                return _SlsperId;
            }
            set
            {
                try
                {
                    _SlsperId = value.Substring(0, 10);
                }
                catch
                {
                    _SlsperId = value;
                }
            }
        }
        public System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                try
                {
                    _Status = value.Substring(0, 1);
                }
                catch
                {
                    _Status = value;
                }
            }
        }
        public System.Double StmtBal
        {
            get
            {
                return _StmtBal;
            }
            set
            {
                _StmtBal = value;
            }
        }
        public System.DateTime StmtDate
        {
            get
            {
                if (_StmtDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _StmtDate;
                }
            }
            set
            {
                _StmtDate = value;
            }
        }
        public System.String TaskID
        {
            get
            {
                return _TaskID;
            }
            set
            {
                try
                {
                    _TaskID = value.Substring(0, 32);
                }
                catch
                {
                    _TaskID = value;
                }
            }
        }
        public System.Int16 TaxCntr00
        {
            get
            {
                return _TaxCntr00;
            }
            set
            {
                _TaxCntr00 = value;
            }
        }
        public System.Int16 TaxCntr01
        {
            get
            {
                return _TaxCntr01;
            }
            set
            {
                _TaxCntr01 = value;
            }
        }
        public System.Int16 TaxCntr02
        {
            get
            {
                return _TaxCntr02;
            }
            set
            {
                _TaxCntr02 = value;
            }
        }
        public System.Int16 TaxCntr03
        {
            get
            {
                return _TaxCntr03;
            }
            set
            {
                _TaxCntr03 = value;
            }
        }
        public System.String TaxId00
        {
            get
            {
                return _TaxId00;
            }
            set
            {
                try
                {
                    _TaxId00 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId00 = value;
                }
            }
        }
        public System.String TaxId01
        {
            get
            {
                return _TaxId01;
            }
            set
            {
                try
                {
                    _TaxId01 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId01 = value;
                }
            }
        }
        public System.String TaxId02
        {
            get
            {
                return _TaxId02;
            }
            set
            {
                try
                {
                    _TaxId02 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId02 = value;
                }
            }
        }
        public System.String TaxId03
        {
            get
            {
                return _TaxId03;
            }
            set
            {
                try
                {
                    _TaxId03 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId03 = value;
                }
            }
        }
        public System.Double TaxTot00
        {
            get
            {
                return _TaxTot00;
            }
            set
            {
                _TaxTot00 = value;
            }
        }
        public System.Double TaxTot01
        {
            get
            {
                return _TaxTot01;
            }
            set
            {
                _TaxTot01 = value;
            }
        }
        public System.Double TaxTot02
        {
            get
            {
                return _TaxTot02;
            }
            set
            {
                _TaxTot02 = value;
            }
        }
        public System.Double TaxTot03
        {
            get
            {
                return _TaxTot03;
            }
            set
            {
                _TaxTot03 = value;
            }
        }
        public System.String Terms
        {
            get
            {
                return _Terms;
            }
            set
            {
                try
                {
                    _Terms = value.Substring(0, 2);
                }
                catch
                {
                    _Terms = value;
                }
            }
        }
        public System.Double TxblTot00
        {
            get
            {
                return _TxblTot00;
            }
            set
            {
                _TxblTot00 = value;
            }
        }
        public System.Double TxblTot01
        {
            get
            {
                return _TxblTot01;
            }
            set
            {
                _TxblTot01 = value;
            }
        }
        public System.Double TxblTot02
        {
            get
            {
                return _TxblTot02;
            }
            set
            {
                _TxblTot02 = value;
            }
        }
        public System.Double TxblTot03
        {
            get
            {
                return _TxblTot03;
            }
            set
            {
                _TxblTot03 = value;
            }
        }
        public System.String User1
        {
            get
            {
                return _User1;
            }
            set
            {
                try
                {
                    _User1 = value.Substring(0, 30);
                }
                catch
                {
                    _User1 = value;
                }
            }
        }
        public System.String User2
        {
            get
            {
                return _User2;
            }
            set
            {
                try
                {
                    _User2 = value.Substring(0, 30);
                }
                catch
                {
                    _User2 = value;
                }
            }
        }
        public System.Double User3
        {
            get
            {
                return _User3;
            }
            set
            {
                _User3 = value;
            }
        }
        public System.Double User4
        {
            get
            {
                return _User4;
            }
            set
            {
                _User4 = value;
            }
        }
        public System.String User5
        {
            get
            {
                return _User5;
            }
            set
            {
                try
                {
                    _User5 = value.Substring(0, 10);
                }
                catch
                {
                    _User5 = value;
                }
            }
        }
        public System.String User6
        {
            get
            {
                return _User6;
            }
            set
            {
                try
                {
                    _User6 = value.Substring(0, 10);
                }
                catch
                {
                    _User6 = value;
                }
            }
        }
        public System.DateTime User7
        {
            get
            {
                if (_User7.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _User7;
                }
            }
            set
            {
                _User7 = value;
            }
        }
        public System.DateTime User8
        {
            get
            {
                if (_User8.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _User8;
                }
            }
            set
            {
                _User8 = value;
            }
        }
        public System.Int32 WSID
        {
            get
            {
                return _WSID;
            }
            set
            {
                _WSID = value;
            }
        }
    }

    public class Note
    {
        public string errorMessage { get; set; }
        public int resultCode { get; set; }
        public DateTime dtRevisedDate { get; set; }
        public int nID { get; set; }
        public string sLevelName { get; set; }
        public string sTableName { get; set; }
        public string sNoteText { get; set; }
    }

    public class ARTran
    {
        private System.String _errorMessage = "";
        private System.String _notes = "";
        private System.Int32 _resultCode = 0;
        private System.String _Acct = "";
        private System.Int16 _AcctDist = 0;
        private System.String _BatNbr = "";
        private System.Double _CmmnPct = 0;
        private System.Double _CnvFact = 0;
        private System.String _ContractID = "";
        private System.String _CostType = "";
        private System.String _CpnyID = "";
        private System.DateTime _Crtd_DateTime = new System.DateTime(1900, 1, 1);
        private System.String _Crtd_Prog = "";
        private System.String _Crtd_User = "";
        private System.Double _CuryExtCost = 0;
        private System.String _CuryId = "";
        private System.String _CuryMultDiv = "";
        private System.Double _CuryRate = 0;
        private System.Double _CuryTaxAmt00 = 0;
        private System.Double _CuryTaxAmt01 = 0;
        private System.Double _CuryTaxAmt02 = 0;
        private System.Double _CuryTaxAmt03 = 0;
        private System.Double _CuryTranAmt = 0;
        private System.Double _CuryTxblAmt00 = 0;
        private System.Double _CuryTxblAmt01 = 0;
        private System.Double _CuryTxblAmt02 = 0;
        private System.Double _CuryTxblAmt03 = 0;
        private System.Double _CuryUnitPrice = 0;
        private System.String _CustId = "";
        private System.String _DrCr = "";
        private System.Int16 _Excpt = 0;
        private System.Double _ExtCost = 0;
        private System.String _ExtRefNbr = "";
        private System.String _FiscYr = "";
        private System.Int16 _FlatRateLineNbr = 0;
        private System.Int16 _InstallNbr = 0;
        private System.String _InvtId = "";
        private System.Double _JobRate = 0;
        private System.String _JrnlType = "";
        private System.Int32 _LineId = 0;
        private System.Int16 _LineNbr = 0;
        private System.String _LineRef = "";
        private System.DateTime _LUpd_DateTime = new System.DateTime(1900, 1, 1);
        private System.String _LUpd_Prog = "";
        private System.String _LUpd_User = "";
        private System.String _MasterDocNbr = "";
        private System.Int32 _NoteId = 0;
        private System.String _OrdNbr = "";
        private System.String _PC_Flag = "";
        private System.String _PC_ID = "";
        private System.String _PC_Status = "";
        private System.String _PerEnt = "";
        private System.String _PerPost = "";
        private System.String _ProjectID = "";
        private System.Double _Qty = 0;
        private System.Int32 _RecordID = 0;
        private System.String _RefNbr = "";
        private System.Int16 _Rlsed = 0;
        private System.String _S4Future01 = "";
        private System.String _S4Future02 = "";
        private System.Double _S4Future03 = 0;
        private System.Double _S4Future04 = 0;
        private System.Double _S4Future05 = 0;
        private System.Double _S4Future06 = 0;
        private System.DateTime _S4Future07 = new System.DateTime(1900, 1, 1);
        private System.DateTime _S4Future08 = new System.DateTime(1900, 1, 1);
        private System.Int32 _S4Future09 = 0;
        private System.Int32 _S4Future10 = 0;
        private System.String _S4Future11 = "";
        private System.String _S4Future12 = "";
        private System.String _ServiceCallID = "";
        private System.Int16 _ServiceCallLineNbr = 0;
        private System.DateTime _ServiceDate = new System.DateTime(1900, 1, 1);
        private System.String _ShipperCpnyID = "";
        private System.String _ShipperID = "";
        private System.String _ShipperLineRef = "";
        private System.String _SiteId = "";
        private System.String _SlsperId = "";
        private System.String _SpecificCostID = "";
        private System.String _Sub = "";
        private System.String _TaskID = "";
        private System.Double _TaxAmt00 = 0;
        private System.Double _TaxAmt01 = 0;
        private System.Double _TaxAmt02 = 0;
        private System.Double _TaxAmt03 = 0;
        private System.String _TaxCalced = "";
        private System.String _TaxCat = "";
        private System.String _TaxId00 = "";
        private System.String _TaxId01 = "";
        private System.String _TaxId02 = "";
        private System.String _TaxId03 = "";
        private System.String _TaxIdDflt = "";
        private System.Double _TranAmt = 0;
        private System.String _TranClass = "";
        private System.DateTime _TranDate = new System.DateTime(1900, 1, 1);
        private System.String _TranDesc = "";
        private System.String _TranType = "";
        private System.Double _TxblAmt00 = 0;
        private System.Double _TxblAmt01 = 0;
        private System.Double _TxblAmt02 = 0;
        private System.Double _TxblAmt03 = 0;
        private System.String _UnitDesc = "";
        private System.Double _UnitPrice = 0;
        private System.String _User1 = "";
        private System.String _User2 = "";
        private System.Double _User3 = 0;
        private System.Double _User4 = 0;
        private System.String _User5 = "";
        private System.String _User6 = "";
        private System.DateTime _User7 = new System.DateTime(1900, 1, 1);
        private System.DateTime _User8 = new System.DateTime(1900, 1, 1);
        private System.String _WhseLoc = "";

        public System.String errorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                try
                {
                    _errorMessage = value;
                }
                catch
                {
                    _errorMessage = value;
                }
            }
        }
        public System.String notes
        {
            get
            {
                return _notes;
            }
            set
            {
                try
                {
                    _notes = value;
                }
                catch
                {
                    _notes = value;
                }
            }
        }
        public System.Int32 resultCode
        {
            get
            {
                return _resultCode;
            }
            set
            {
                _resultCode = value;
            }
        }
        public System.String Acct
        {
            get
            {
                return _Acct;
            }
            set
            {
                try
                {
                    _Acct = value.Substring(0, 10);
                }
                catch
                {
                    _Acct = value;
                }
            }
        }
        public System.Int16 AcctDist
        {
            get
            {
                return _AcctDist;
            }
            set
            {
                _AcctDist = value;
            }
        }
        public System.String BatNbr
        {
            get
            {
                return _BatNbr;
            }
            set
            {
                try
                {
                    _BatNbr = value.Substring(0, 10);
                }
                catch
                {
                    _BatNbr = value;
                }
            }
        }
        public System.Double CmmnPct
        {
            get
            {
                return _CmmnPct;
            }
            set
            {
                _CmmnPct = value;
            }
        }
        public System.Double CnvFact
        {
            get
            {
                return _CnvFact;
            }
            set
            {
                _CnvFact = value;
            }
        }
        public System.String ContractID
        {
            get
            {
                return _ContractID;
            }
            set
            {
                try
                {
                    _ContractID = value.Substring(0, 10);
                }
                catch
                {
                    _ContractID = value;
                }
            }
        }
        public System.String CostType
        {
            get
            {
                return _CostType;
            }
            set
            {
                try
                {
                    _CostType = value.Substring(0, 8);
                }
                catch
                {
                    _CostType = value;
                }
            }
        }
        public System.String CpnyID
        {
            get
            {
                return _CpnyID;
            }
            set
            {
                try
                {
                    _CpnyID = value.Substring(0, 10);
                }
                catch
                {
                    _CpnyID = value;
                }
            }
        }
        public System.DateTime Crtd_DateTime
        {
            get
            {
                if (_Crtd_DateTime.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _Crtd_DateTime;
                }
            }
            set
            {
                _Crtd_DateTime = value;
            }
        }
        public System.String Crtd_Prog
        {
            get
            {
                return _Crtd_Prog;
            }
            set
            {
                try
                {
                    _Crtd_Prog = value.Substring(0, 8);
                }
                catch
                {
                    _Crtd_Prog = value;
                }
            }
        }
        public System.String Crtd_User
        {
            get
            {
                return _Crtd_User;
            }
            set
            {
                try
                {
                    _Crtd_User = value.Substring(0, 10);
                }
                catch
                {
                    _Crtd_User = value;
                }
            }
        }
        public System.Double CuryExtCost
        {
            get
            {
                return _CuryExtCost;
            }
            set
            {
                _CuryExtCost = value;
            }
        }
        public System.String CuryId
        {
            get
            {
                return _CuryId;
            }
            set
            {
                try
                {
                    _CuryId = value.Substring(0, 4);
                }
                catch
                {
                    _CuryId = value;
                }
            }
        }
        public System.String CuryMultDiv
        {
            get
            {
                return _CuryMultDiv;
            }
            set
            {
                try
                {
                    _CuryMultDiv = value.Substring(0, 1);
                }
                catch
                {
                    _CuryMultDiv = value;
                }
            }
        }
        public System.Double CuryRate
        {
            get
            {
                return _CuryRate;
            }
            set
            {
                _CuryRate = value;
            }
        }
        public System.Double CuryTaxAmt00
        {
            get
            {
                return _CuryTaxAmt00;
            }
            set
            {
                _CuryTaxAmt00 = value;
            }
        }
        public System.Double CuryTaxAmt01
        {
            get
            {
                return _CuryTaxAmt01;
            }
            set
            {
                _CuryTaxAmt01 = value;
            }
        }
        public System.Double CuryTaxAmt02
        {
            get
            {
                return _CuryTaxAmt02;
            }
            set
            {
                _CuryTaxAmt02 = value;
            }
        }
        public System.Double CuryTaxAmt03
        {
            get
            {
                return _CuryTaxAmt03;
            }
            set
            {
                _CuryTaxAmt03 = value;
            }
        }
        public System.Double CuryTranAmt
        {
            get
            {
                return _CuryTranAmt;
            }
            set
            {
                _CuryTranAmt = value;
            }
        }
        public System.Double CuryTxblAmt00
        {
            get
            {
                return _CuryTxblAmt00;
            }
            set
            {
                _CuryTxblAmt00 = value;
            }
        }
        public System.Double CuryTxblAmt01
        {
            get
            {
                return _CuryTxblAmt01;
            }
            set
            {
                _CuryTxblAmt01 = value;
            }
        }
        public System.Double CuryTxblAmt02
        {
            get
            {
                return _CuryTxblAmt02;
            }
            set
            {
                _CuryTxblAmt02 = value;
            }
        }
        public System.Double CuryTxblAmt03
        {
            get
            {
                return _CuryTxblAmt03;
            }
            set
            {
                _CuryTxblAmt03 = value;
            }
        }
        public System.Double CuryUnitPrice
        {
            get
            {
                return _CuryUnitPrice;
            }
            set
            {
                _CuryUnitPrice = value;
            }
        }
        public System.String CustId
        {
            get
            {
                return _CustId;
            }
            set
            {
                try
                {
                    _CustId = value.Substring(0, 15);
                }
                catch
                {
                    _CustId = value;
                }
            }
        }
        public System.String DrCr
        {
            get
            {
                return _DrCr;
            }
            set
            {
                try
                {
                    _DrCr = value.Substring(0, 1);
                }
                catch
                {
                    _DrCr = value;
                }
            }
        }
        public System.Int16 Excpt
        {
            get
            {
                return _Excpt;
            }
            set
            {
                _Excpt = value;
            }
        }
        public System.Double ExtCost
        {
            get
            {
                return _ExtCost;
            }
            set
            {
                _ExtCost = value;
            }
        }
        public System.String ExtRefNbr
        {
            get
            {
                return _ExtRefNbr;
            }
            set
            {
                try
                {
                    _ExtRefNbr = value.Substring(0, 15);
                }
                catch
                {
                    _ExtRefNbr = value;
                }
            }
        }
        public System.String FiscYr
        {
            get
            {
                return _FiscYr;
            }
            set
            {
                try
                {
                    _FiscYr = value.Substring(0, 4);
                }
                catch
                {
                    _FiscYr = value;
                }
            }
        }
        public System.Int16 FlatRateLineNbr
        {
            get
            {
                return _FlatRateLineNbr;
            }
            set
            {
                _FlatRateLineNbr = value;
            }
        }
        public System.Int16 InstallNbr
        {
            get
            {
                return _InstallNbr;
            }
            set
            {
                _InstallNbr = value;
            }
        }
        public System.String InvtId
        {
            get
            {
                return _InvtId;
            }
            set
            {
                try
                {
                    _InvtId = value.Substring(0, 30);
                }
                catch
                {
                    _InvtId = value;
                }
            }
        }
        public System.Double JobRate
        {
            get
            {
                return _JobRate;
            }
            set
            {
                _JobRate = value;
            }
        }
        public System.String JrnlType
        {
            get
            {
                return _JrnlType;
            }
            set
            {
                try
                {
                    _JrnlType = value.Substring(0, 3);
                }
                catch
                {
                    _JrnlType = value;
                }
            }
        }
        public System.Int32 LineId
        {
            get
            {
                return _LineId;
            }
            set
            {
                _LineId = value;
            }
        }
        public System.Int16 LineNbr
        {
            get
            {
                return _LineNbr;
            }
            set
            {
                _LineNbr = value;
            }
        }
        public System.String LineRef
        {
            get
            {
                return _LineRef;
            }
            set
            {
                try
                {
                    _LineRef = value.Substring(0, 5);
                }
                catch
                {
                    _LineRef = value;
                }
            }
        }
        public System.DateTime LUpd_DateTime
        {
            get
            {
                if (_LUpd_DateTime.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _LUpd_DateTime;
                }
            }
            set
            {
                _LUpd_DateTime = value;
            }
        }
        public System.String LUpd_Prog
        {
            get
            {
                return _LUpd_Prog;
            }
            set
            {
                try
                {
                    _LUpd_Prog = value.Substring(0, 8);
                }
                catch
                {
                    _LUpd_Prog = value;
                }
            }
        }
        public System.String LUpd_User
        {
            get
            {
                return _LUpd_User;
            }
            set
            {
                try
                {
                    _LUpd_User = value.Substring(0, 10);
                }
                catch
                {
                    _LUpd_User = value;
                }
            }
        }
        public System.String MasterDocNbr
        {
            get
            {
                return _MasterDocNbr;
            }
            set
            {
                try
                {
                    _MasterDocNbr = value.Substring(0, 10);
                }
                catch
                {
                    _MasterDocNbr = value;
                }
            }
        }
        public System.Int32 NoteId
        {
            get
            {
                return _NoteId;
            }
            set
            {
                _NoteId = value;
            }
        }
        public System.String OrdNbr
        {
            get
            {
                return _OrdNbr;
            }
            set
            {
                try
                {
                    _OrdNbr = value.Substring(0, 15);
                }
                catch
                {
                    _OrdNbr = value;
                }
            }
        }
        public System.String PC_Flag
        {
            get
            {
                return _PC_Flag;
            }
            set
            {
                try
                {
                    _PC_Flag = value.Substring(0, 1);
                }
                catch
                {
                    _PC_Flag = value;
                }
            }
        }
        public System.String PC_ID
        {
            get
            {
                return _PC_ID;
            }
            set
            {
                try
                {
                    _PC_ID = value.Substring(0, 20);
                }
                catch
                {
                    _PC_ID = value;
                }
            }
        }
        public System.String PC_Status
        {
            get
            {
                return _PC_Status;
            }
            set
            {
                try
                {
                    _PC_Status = value.Substring(0, 1);
                }
                catch
                {
                    _PC_Status = value;
                }
            }
        }
        public System.String PerEnt
        {
            get
            {
                return _PerEnt;
            }
            set
            {
                try
                {
                    _PerEnt = value.Substring(0, 6);
                }
                catch
                {
                    _PerEnt = value;
                }
            }
        }
        public System.String PerPost
        {
            get
            {
                return _PerPost;
            }
            set
            {
                try
                {
                    _PerPost = value.Substring(0, 6);
                }
                catch
                {
                    _PerPost = value;
                }
            }
        }
        public System.String ProjectID
        {
            get
            {
                return _ProjectID;
            }
            set
            {
                try
                {
                    _ProjectID = value.Substring(0, 16);
                }
                catch
                {
                    _ProjectID = value;
                }
            }
        }
        public System.Double Qty
        {
            get
            {
                return _Qty;
            }
            set
            {
                _Qty = value;
            }
        }
        public System.Int32 RecordID
        {
            get
            {
                return _RecordID;
            }
            set
            {
                _RecordID = value;
            }
        }
        public System.String RefNbr
        {
            get
            {
                return _RefNbr;
            }
            set
            {
                try
                {
                    _RefNbr = value.Substring(0, 10);
                }
                catch
                {
                    _RefNbr = value;
                }
            }
        }
        public System.Int16 Rlsed
        {
            get
            {
                return _Rlsed;
            }
            set
            {
                _Rlsed = value;
            }
        }
        public System.String S4Future01
        {
            get
            {
                return _S4Future01;
            }
            set
            {
                try
                {
                    _S4Future01 = value.Substring(0, 30);
                }
                catch
                {
                    _S4Future01 = value;
                }
            }
        }
        public System.String S4Future02
        {
            get
            {
                return _S4Future02;
            }
            set
            {
                try
                {
                    _S4Future02 = value.Substring(0, 30);
                }
                catch
                {
                    _S4Future02 = value;
                }
            }
        }
        public System.Double S4Future03
        {
            get
            {
                return _S4Future03;
            }
            set
            {
                _S4Future03 = value;
            }
        }
        public System.Double S4Future04
        {
            get
            {
                return _S4Future04;
            }
            set
            {
                _S4Future04 = value;
            }
        }
        public System.Double S4Future05
        {
            get
            {
                return _S4Future05;
            }
            set
            {
                _S4Future05 = value;
            }
        }
        public System.Double S4Future06
        {
            get
            {
                return _S4Future06;
            }
            set
            {
                _S4Future06 = value;
            }
        }
        public System.DateTime S4Future07
        {
            get
            {
                if (_S4Future07.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _S4Future07;
                }
            }
            set
            {
                _S4Future07 = value;
            }
        }
        public System.DateTime S4Future08
        {
            get
            {
                if (_S4Future08.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _S4Future08;
                }
            }
            set
            {
                _S4Future08 = value;
            }
        }
        public System.Int32 S4Future09
        {
            get
            {
                return _S4Future09;
            }
            set
            {
                _S4Future09 = value;
            }
        }
        public System.Int32 S4Future10
        {
            get
            {
                return _S4Future10;
            }
            set
            {
                _S4Future10 = value;
            }
        }
        public System.String S4Future11
        {
            get
            {
                return _S4Future11;
            }
            set
            {
                try
                {
                    _S4Future11 = value.Substring(0, 10);
                }
                catch
                {
                    _S4Future11 = value;
                }
            }
        }
        public System.String S4Future12
        {
            get
            {
                return _S4Future12;
            }
            set
            {
                try
                {
                    _S4Future12 = value.Substring(0, 10);
                }
                catch
                {
                    _S4Future12 = value;
                }
            }
        }
        public System.String ServiceCallID
        {
            get
            {
                return _ServiceCallID;
            }
            set
            {
                try
                {
                    _ServiceCallID = value.Substring(0, 10);
                }
                catch
                {
                    _ServiceCallID = value;
                }
            }
        }
        public System.Int16 ServiceCallLineNbr
        {
            get
            {
                return _ServiceCallLineNbr;
            }
            set
            {
                _ServiceCallLineNbr = value;
            }
        }
        public System.DateTime ServiceDate
        {
            get
            {
                if (_ServiceDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _ServiceDate;
                }
            }
            set
            {
                _ServiceDate = value;
            }
        }
        public System.String ShipperCpnyID
        {
            get
            {
                return _ShipperCpnyID;
            }
            set
            {
                try
                {
                    _ShipperCpnyID = value.Substring(0, 10);
                }
                catch
                {
                    _ShipperCpnyID = value;
                }
            }
        }
        public System.String ShipperID
        {
            get
            {
                return _ShipperID;
            }
            set
            {
                try
                {
                    _ShipperID = value.Substring(0, 15);
                }
                catch
                {
                    _ShipperID = value;
                }
            }
        }
        public System.String ShipperLineRef
        {
            get
            {
                return _ShipperLineRef;
            }
            set
            {
                try
                {
                    _ShipperLineRef = value.Substring(0, 5);
                }
                catch
                {
                    _ShipperLineRef = value;
                }
            }
        }
        public System.String SiteId
        {
            get
            {
                return _SiteId;
            }
            set
            {
                try
                {
                    _SiteId = value.Substring(0, 10);
                }
                catch
                {
                    _SiteId = value;
                }
            }
        }
        public System.String SlsperId
        {
            get
            {
                return _SlsperId;
            }
            set
            {
                try
                {
                    _SlsperId = value.Substring(0, 10);
                }
                catch
                {
                    _SlsperId = value;
                }
            }
        }
        public System.String SpecificCostID
        {
            get
            {
                return _SpecificCostID;
            }
            set
            {
                try
                {
                    _SpecificCostID = value.Substring(0, 25);
                }
                catch
                {
                    _SpecificCostID = value;
                }
            }
        }
        public System.String Sub
        {
            get
            {
                return _Sub;
            }
            set
            {
                try
                {
                    _Sub = value.Substring(0, 24);
                }
                catch
                {
                    _Sub = value;
                }
            }
        }
        public System.String TaskID
        {
            get
            {
                return _TaskID;
            }
            set
            {
                try
                {
                    _TaskID = value.Substring(0, 32);
                }
                catch
                {
                    _TaskID = value;
                }
            }
        }
        public System.Double TaxAmt00
        {
            get
            {
                return _TaxAmt00;
            }
            set
            {
                _TaxAmt00 = value;
            }
        }
        public System.Double TaxAmt01
        {
            get
            {
                return _TaxAmt01;
            }
            set
            {
                _TaxAmt01 = value;
            }
        }
        public System.Double TaxAmt02
        {
            get
            {
                return _TaxAmt02;
            }
            set
            {
                _TaxAmt02 = value;
            }
        }
        public System.Double TaxAmt03
        {
            get
            {
                return _TaxAmt03;
            }
            set
            {
                _TaxAmt03 = value;
            }
        }
        public System.String TaxCalced
        {
            get
            {
                return _TaxCalced;
            }
            set
            {
                try
                {
                    _TaxCalced = value.Substring(0, 1);
                }
                catch
                {
                    _TaxCalced = value;
                }
            }
        }
        public System.String TaxCat
        {
            get
            {
                return _TaxCat;
            }
            set
            {
                try
                {
                    _TaxCat = value.Substring(0, 10);
                }
                catch
                {
                    _TaxCat = value;
                }
            }
        }
        public System.String TaxId00
        {
            get
            {
                return _TaxId00;
            }
            set
            {
                try
                {
                    _TaxId00 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId00 = value;
                }
            }
        }
        public System.String TaxId01
        {
            get
            {
                return _TaxId01;
            }
            set
            {
                try
                {
                    _TaxId01 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId01 = value;
                }
            }
        }
        public System.String TaxId02
        {
            get
            {
                return _TaxId02;
            }
            set
            {
                try
                {
                    _TaxId02 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId02 = value;
                }
            }
        }
        public System.String TaxId03
        {
            get
            {
                return _TaxId03;
            }
            set
            {
                try
                {
                    _TaxId03 = value.Substring(0, 10);
                }
                catch
                {
                    _TaxId03 = value;
                }
            }
        }
        public System.String TaxIdDflt
        {
            get
            {
                return _TaxIdDflt;
            }
            set
            {
                try
                {
                    _TaxIdDflt = value.Substring(0, 10);
                }
                catch
                {
                    _TaxIdDflt = value;
                }
            }
        }
        public System.Double TranAmt
        {
            get
            {
                return _TranAmt;
            }
            set
            {
                _TranAmt = value;
            }
        }
        public System.String TranClass
        {
            get
            {
                return _TranClass;
            }
            set
            {
                try
                {
                    _TranClass = value.Substring(0, 1);
                }
                catch
                {
                    _TranClass = value;
                }
            }
        }
        public System.DateTime TranDate
        {
            get
            {
                if (_TranDate.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _TranDate;
                }
            }
            set
            {
                _TranDate = value;
            }
        }
        public System.String TranDesc
        {
            get
            {
                return _TranDesc;
            }
            set
            {
                try
                {
                    _TranDesc = value.Substring(0, 30);
                }
                catch
                {
                    _TranDesc = value;
                }
            }
        }
        public System.String TranType
        {
            get
            {
                return _TranType;
            }
            set
            {
                try
                {
                    _TranType = value.Substring(0, 2);
                }
                catch
                {
                    _TranType = value;
                }
            }
        }
        public System.Double TxblAmt00
        {
            get
            {
                return _TxblAmt00;
            }
            set
            {
                _TxblAmt00 = value;
            }
        }
        public System.Double TxblAmt01
        {
            get
            {
                return _TxblAmt01;
            }
            set
            {
                _TxblAmt01 = value;
            }
        }
        public System.Double TxblAmt02
        {
            get
            {
                return _TxblAmt02;
            }
            set
            {
                _TxblAmt02 = value;
            }
        }
        public System.Double TxblAmt03
        {
            get
            {
                return _TxblAmt03;
            }
            set
            {
                _TxblAmt03 = value;
            }
        }
        public System.String UnitDesc
        {
            get
            {
                return _UnitDesc;
            }
            set
            {
                try
                {
                    _UnitDesc = value.Substring(0, 6);
                }
                catch
                {
                    _UnitDesc = value;
                }
            }
        }
        public System.Double UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                _UnitPrice = value;
            }
        }
        public System.String User1
        {
            get
            {
                return _User1;
            }
            set
            {
                try
                {
                    _User1 = value.Substring(0, 30);
                }
                catch
                {
                    _User1 = value;
                }
            }
        }
        public System.String User2
        {
            get
            {
                return _User2;
            }
            set
            {
                try
                {
                    _User2 = value.Substring(0, 30);
                }
                catch
                {
                    _User2 = value;
                }
            }
        }
        public System.Double User3
        {
            get
            {
                return _User3;
            }
            set
            {
                _User3 = value;
            }
        }
        public System.Double User4
        {
            get
            {
                return _User4;
            }
            set
            {
                _User4 = value;
            }
        }
        public System.String User5
        {
            get
            {
                return _User5;
            }
            set
            {
                try
                {
                    _User5 = value.Substring(0, 10);
                }
                catch
                {
                    _User5 = value;
                }
            }
        }
        public System.String User6
        {
            get
            {
                return _User6;
            }
            set
            {
                try
                {
                    _User6 = value.Substring(0, 10);
                }
                catch
                {
                    _User6 = value;
                }
            }
        }
        public System.DateTime User7
        {
            get
            {
                if (_User7.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _User7;
                }
            }
            set
            {
                _User7 = value;
            }
        }
        public System.DateTime User8
        {
            get
            {
                if (_User8.Year < 1900)
                {
                    return new DateTime(1900, 1, 1);
                }
                else
                {
                    return _User8;
                }
            }
            set
            {
                _User8 = value;
            }
        }
        public System.String WhseLoc
        {
            get
            {
                return _WhseLoc;
            }
            set
            {
                try
                {
                    _WhseLoc = value.Substring(0, 10);
                }
                catch
                {
                    _WhseLoc = value;
                }
            }
        }

    }

    
    public class SubXRef
    {
        public string errorMessage { get; set; }
        public string notes { get; set; }
        public int resultCode { get; set; }
        public int Active { get; set; }
        public string CpnyID { get; set; }
        public string Descr { get; set; }
        public string Sub { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public double User3 { get; set; }
        public double User4 { get; set; }
    }
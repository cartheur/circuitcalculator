using System;
using System.Collections.Generic;
using System.Text;

namespace CircuitCalculator
{
    /// <summary>
    /// The Investor parent class.
    /// </summary>
    public class Investor
    {
        private int _investorID = 0;
        private string _investorLocation = "";
        private string _investorCurrency = "";
        private string _investorGroupName = "";
        private string _investorGroupWebAddress = "";
        private string _contactName = "";
        private string _contactEmail = "";
        private string _skinMargin = "";
        private string _referringNetwork = "";
        private bool _docSent = false;
        private string _dateDocSent = "";
        private bool _receivedReply = false;

        public int InvestorID { get { return _investorID; } set { _investorID = value; } }
        public string InvestorLocation { get { return _investorLocation; } set { _investorLocation = value; } }
        public string InvestorCurrency { get { return _investorCurrency; } set { _investorCurrency = value; } }
        public string InvestorGroupName { get { return _investorGroupName; } set { _investorGroupName = value; } }
        public string InvestorGroupWebAddress { get { return _investorGroupWebAddress; } set { _investorGroupWebAddress = value; } }
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        public string ContactEmail { get { return _contactEmail; } set { _contactEmail = value; } }
        public string SkinMargin { get { return _skinMargin; } set { _skinMargin = value; } }
        public string ReferringNetwork { get { return _referringNetwork; } set { _referringNetwork = value; } }
        public bool DocSent { get { return _docSent; } set { _docSent = value; } }
        public string DateDocSent { get { return _dateDocSent; } set { _dateDocSent = value; } }
        public bool ReceivedReply { get { return _receivedReply; } set { _receivedReply = value; } }

        public Investor() { }

        public Investor(int investorID, string investorLocation, string investorCurrency, string investorGroupName, string investorGroupWebAddress, 
            string contactName, string contactEmail, string skinMargin, string referringNetwork, bool docSent, string dateDocSent, bool receivedReply)
        {
            InvestorID = investorID;
            InvestorLocation = investorLocation;
            InvestorCurrency = investorCurrency;
            InvestorGroupName = investorGroupName;
            InvestorGroupWebAddress = investorGroupWebAddress;
            ContactName = contactName;
            ContactEmail = contactEmail;
            SkinMargin = skinMargin;
            ReferringNetwork = referringNetwork;
            DocSent = docSent;
            DateDocSent = dateDocSent;
            ReceivedReply = receivedReply;
        }
    }
}

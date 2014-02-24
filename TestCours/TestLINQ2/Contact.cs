using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLINQ2
{
    class Contact
    {
        public enum EStatus
        {
            Available,
            Away,
            Busy,
            Disconnected
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        private EStatus _status;
        public EStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private bool _isVIP;
        public bool IsVIP
        {
            get { return _isVIP; }
            set { _isVIP = value; }
        }

        public Contact(string inAddress, string inDisplayName, EStatus inStatus, bool inIsVIP)
        {
            Address = inAddress;
            DisplayName = inDisplayName;
            Status = inStatus;
            IsVIP = inIsVIP;
        }

    }
}

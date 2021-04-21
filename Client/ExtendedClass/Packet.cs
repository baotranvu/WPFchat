using System.Net;
using System.Collections.Generic;
namespace ExtendedClass
{
    //Packet send to server
    public class Packet
    {
        //Private members of Packet class
        #region Private Members 
        private DataIdentifier dataIdentifier;
        private string _clientname;
        private string _receiver;
        private string _password;
        private string _message;
        #endregion
        #region Getter/Setter

        

        public string ClientName
        {
            get { return _clientname; }
            set { _clientname = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

       public string Receiver
        {
            get { return _receiver; }
            set { _receiver = value; }
        }
        #endregion
        #region Public Methods
        public Packet()
        {
            dataIdentifier = DataIdentifier.Null;
            _clientname = null;
            _password = null;
            _receiver = null;
            _message = null; 
        }

        public Packet(byte[] data)
        {
            
        }

        public byte[] GetDataStream()
        {
            List<byte> data = new List<byte>();

            return data.ToArray();
        }
       
        #endregion
        #region Other Methods
        #endregion
    }
}

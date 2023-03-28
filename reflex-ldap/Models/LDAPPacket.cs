using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflex_ldap.Models
{
    public class LDAPPacket
    {
        private List<LDAPPacket> packets;
        public string Name { get; set; }

        public LDAPPacket(string Name)
        {
            packets = new List<LDAPPacket>();
        }

        public List<LDAPPacket> GetPackets()
        {
            return packets;
        }
    }
}

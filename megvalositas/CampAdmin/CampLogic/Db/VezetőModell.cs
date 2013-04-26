using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Borders;



namespace Db
{
    public class VezetőModell
    {
        DbConnection conn = new DbConnection();  

        public Vezető VezetőUserPassz(string user, string pass)
        {
            return (from v in conn.Vezetök where (v.Nev == user) && (v.Jelszo == pass) select v).FirstOrDefault();
        }
    }
}

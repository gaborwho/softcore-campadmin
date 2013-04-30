using System.Linq;
using CampLogic.Borders;
using System.Diagnostics;



namespace CampLogic.Db
{
    public class VezetoModell
    {
        MyDbConnection conn = new MyDbConnection();

        public Vezető VezetőUserPassz(string user, string pass)
        {
            return (from v in conn.Vezetök where (v.Nev.ToUpper() == user.ToUpper()) && (v.Jelszo == pass) select v).FirstOrDefault();
        }


        [Conditional("DEBUG")]
        public void TesztCreateVezetőIfDontExists(Vezető vezető)
        {

            var vez = (from v in conn.Vezetök 
                       where (v.Nev.ToUpper() == vezető.Nev.ToUpper()) && (v.Jelszo == vezető.Jelszo) 
                       select v).FirstOrDefault();

            if (vez == null)
            {
                conn.Vezetök.Add(vezető);
                conn.SaveChanges();
            }

        }
    }
}

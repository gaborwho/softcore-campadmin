using System.Linq;
using CampLogic.Borders;
using System.Diagnostics;



namespace CampLogic.Db
{
    public class VezetoModell
    {
        static MyDbConnection conn = new MyDbConnection();

        public Vezetö VezetőUserPassz(string user, string pass)
        {
            return (from v in conn.Vezetök where (v.Nev.ToUpper() == user.ToUpper()) && (v.Jelszo == pass) select v).FirstOrDefault();
        }


        [Conditional("DEBUG")]
        public void TesztCreateVezetőIfDontExists(Vezetö vezető)
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

        public static Vezetö[] GetIfiVezetok()
        {
            
            var vez = from v in conn.Vezetök where v.TipusSzam == 0 select v;

            return vez.ToArray<Vezetö>();
        }
    }
}

using System.Linq;
using CampLogic.Borders;
using System.Diagnostics;



namespace CampLogic.Db
{
    public class VezetoModell
    {
        static MyDbConnection conn = new MyDbConnection();

        public Vezeto VezetoUserPass(string user, string pass)
        {
            var vez  = (from v in conn.Vezetok where (v.Nev.ToUpper() == user.ToUpper()) && (v.Jelszo == pass) select v).FirstOrDefault();

            if (vez!=null)
            {
                if (vez.Jelszo != pass)
                {
                    return null;
                }
            }

            return vez;
        }


        [Conditional("DEBUG")]
        public void TesztCreateVezetoIfDontExists(Vezeto vezeto)
        {
            //Ha megváltozott az adatbázis, és emitatt elszáll, ezzel tötölheted és újra létrehozheto (nem fog a program elindulni, de ha újra kikommenteled működni fog)
            //conn.Database.Delete();
            //conn.Database.CreateIfNotExists();

            var vez = (from v in conn.Vezetok 
                       where (v.Nev.ToUpper() == vezeto.Nev.ToUpper()) && (v.Jelszo == vezeto.Jelszo) 
                       select v).FirstOrDefault();

            if (vez == null)
            {
                conn.Vezetok.Add(vezeto);
                conn.SaveChanges();
            }

        }

        public static Vezeto[] GetIfiVezetok()
        {
            
            var vez = from v in conn.Vezetok where v.TipusSzam == 0 select v;

            return vez.ToArray<Vezeto>();
        }
    }
}

///////////////////////////////////////////////////////////
//  StatisztikaKazel�.cs
//  Implementation of the Class StatisztikaKazel�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:01:56
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using CampLogic.TaborvezetoFunkciok;
using CampLogic.Db;
namespace CampLogic.TaborvezetoFunkciok
{
    public class StatisztikaKezelo
    {

        MyDbConnection conn = new MyDbConnection();

        public StatisztikaKezelo()
        {

        }

        public Statisztika HanyOrszagPerTurnus()
        {
            Statisztika ret = new Statisztika();

            ret.Oszlopnevek.Add("Turnusok");
            ret.Oszlopnevek.Add("Orsz�g sz�m");

            var turnusok = (from t in conn.Turnusok select t);

            foreach (var turnus in turnusok)
            {
                int orsz�gsz�m = (from k in conn.Korcsoportok
                                  where k.TurnusId == turnus.TurnusId
                                  group k by k.Orszag).Count();

                List<string> sor = new List<string>();
                sor.Add(turnus.Nev);
                sor.Add(orsz�gsz�m.ToString());

                ret.Sorok.Add(sor);

            }

            return ret;
        }

        public Statisztika HanyTaboroz�PerTurnus()
        {
            Statisztika ret = new Statisztika();

            var turnusok = (from t in conn.Turnusok select t);

            foreach (var turnus in turnusok)
            {

                int t�boroz�sz�m = (from t� in conn.Taborozok 
                                  join cs in conn.Csoportok on t�.CsoportId equals cs.CoportId
                                  join kcs in conn.Korcsoportok on cs.Korcsoport equals kcs
                                  where kcs.TurnusId == turnus.TurnusId
                                  select t�).Count();


                List<string> sor = new List<string>();
                sor.Add(turnus.Nev);
                sor.Add(t�boroz�sz�m.ToString());

                ret.Sorok.Add(sor);
               
            }

            return ret;
        }

    }//end StatisztikaKazel�

}//end namespace T�borvezet�Funkci�k
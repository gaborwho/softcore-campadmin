///////////////////////////////////////////////////////////
//  T�boroz�Kezel�.cs
//  Implementation of the Class T�boroz�Kezel�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:00:05
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using CampLogic.KorcsoportVezetoFunkciok;
using CampLogic.TaborvezetoFunkciok;
using CampLogic.IfjusagiVezetoFunkciok;
using CampLogic.Db;
namespace CampLogic.IfjusagiVezetoFunkciok {
	public class TaborozoKezelo {

		public MyDbConnection conn = new MyDbConnection();

		public TaborozoKezelo(){

		}

		/// 
		/// <param name="Taborozo"></param>
		/// <param name="csoport"></param>
		public bool CsoporthozRendeles(Taborozo taborozo, Csoport csoport){
            taborozo.Csoport = csoport;
            conn.SaveChanges();
			return true;
		}

		public List<Taborozo> TaborozoListazas(){
            return conn.Taborozok.ToList<Taborozo>();
		}

		/// 
		/// <param name="taborozo"></param>
		public bool TaborozoModositasa(Taborozo taborozo){
            conn.SaveChanges();
            return true;
		}

		/// 
		/// <param name="T�boroz�"></param>
		/// <param name="Szoba"></param>
		public void TaborozoSzobahozRendeles(Taborozo Taborozo, Szoba Szoba){
            Taborozo.Szoba = Szoba;
            conn.SaveChanges();
		}

		/// 
		/// <param name="taborozo"></param>
		public bool TaborozoTorles(Taborozo taborozo){
            conn.Taborozok.Remove(taborozo);
            conn.SaveChanges();
            return true;
		}

		/// 
		/// <param name="ujTaborozo"></param>
		public bool UjTaborozo(Taborozo ujTaborozo){
            conn.Taborozok.Add(ujTaborozo);
            conn.SaveChanges();
			return true;
		}

	}//end T�boroz�Kezel�

}//end namespace Ifj�s�giVezet�Funkci�k
﻿///////////////////////////////////////////////////////////
//  Táborozó.cs
//  Implementation of the Class Táborozó
//  Generated by Enterprise Architect
//  Created on:      26-ápr.-2013 20:00:04
//  Original author: Danikk
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CampLogic.KorcsoportVezetoFunkciok;
using CampLogic.TaborvezetoFunkciok;


namespace CampLogic.IfjusagiVezetoFunkciok {
	public class Taborozo {


		public Taborozo(){

		}

        #region Adat kapcsolati tulajdonságok

        [Key]
        public int TaborozoId { get; set; }

        public virtual Csoport Csoport { get; set; }
        public int CsoportId { get; set; }

        #endregion

        public string Betegsegek{ get; set; }

		public string Elerhetosegek{ get; set; }

		public string Megjegyzes{ get; set; }

		public string Nev{ get; set; }

		public string Orszag{ get; set; }

		public virtual Szoba Szoba{ get; set; }

        // Amikor létrehozzuk, nem rendeljük szobához,
        // a kérdőjeltől nullable lesz, így már el tudja tárolni
		public int? SzobaId{ get; set; }

		public DateTime SzuletesiDatum{ get; set; }

        public override string ToString()
        {
            return Nev;
        }

	}//end Táborozó

}//end namespace IfjúságiVezetõFunkciók
///////////////////////////////////////////////////////////
//  Csoport.cs
//  Implementation of the Class Csoport
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:01:00
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

using CampLogic.Borders;
using CampLogic.IfjusagiVezetoFunkciok;

namespace CampLogic.KorcsoportVezetoFunkciok {
	public class Csoport {

		public Csoport(){

		}

        
        #region Adat kapcsolati tulajdons�gok

        [Key]
        public int CoportId { get; set; }

        public int KorcsoportId { get; set; }

       
        public virtual Korcsoport Korcsoport { get; set; }

        #endregion


        

		public virtual List<Taborozo> CsoportTagok{ get; set; }

		public Vezeto IfiVezeto1{ get; set; }

		public Vezeto IfiVezeto2{ get; set; }

		

		public string Nev{ get; set; }

        public override string ToString()
        {
            return this.Nev+"( "+this.IfiVezeto1+", "+this.IfiVezeto2+" )";
        }

	}//end Csoport

}//end namespace KorcsoportVezet�Funkci�k
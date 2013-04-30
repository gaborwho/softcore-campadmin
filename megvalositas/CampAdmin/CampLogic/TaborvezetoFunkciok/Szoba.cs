///////////////////////////////////////////////////////////
//  Szoba.cs
//  Implementation of the Class Szoba
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:01:56
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


using CampLogic.T�borvezet�Funkci�k;
using CampLogic.Ifj�s�giVezet�Funkci�k;
namespace CampLogic.T�borvezet�Funkci�k
{
    public class Szoba
    {

        public Szoba()
        {

        }


        #region Adat kapcsolati tulajdons�gok
       
        [Key]
        public int SzobaId { get; set; }

        public virtual H�z H�z { get; set; }


        #endregion


        public int Ferohely { get; set; }

        public string Szobaszam { get; set; }

        public virtual List<T�boroz�> T�boroz�k { get; set; }

        public override string ToString()
        {
            return Szobaszam + " ( " + Ferohely + " ) H�z: "+ H�z.N�v;
        }

    }//end Szoba

}//end namespace T�borvezet�Funkci�k
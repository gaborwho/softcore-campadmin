///////////////////////////////////////////////////////////
//  Vezet�.cs
//  Implementation of the Class Vezet�
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 19:57:23
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Borders;
using System.ComponentModel.DataAnnotations;
namespace Borders
{
    public class Vezet� : IVezet�
    {

        public Vezet�()
        {

        }


        #region Adat kapcsolati tulajdons�gok

        [Key]
        public int Vezet�Id { get; set; }

        #endregion


        public string Jelszo { get; set; }

        public string Nev { get; set; }


        public int TipusSzam { get; set; }

        public Vezet�T�pus Tipus
        {
            get
            {
                return (Vezet�T�pus)TipusSzam;
            }
            set
            {
                TipusSzam = (int)value;
            }
        }


        public override string ToString()
        {
            return Nev;
        }

    }//end Vezet�

}//end namespace Borders
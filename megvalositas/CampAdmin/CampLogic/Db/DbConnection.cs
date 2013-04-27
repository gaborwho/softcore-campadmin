///////////////////////////////////////////////////////////
//  DbConnection.cs
//  Implementation of the Class DbConnection
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 20:08:10
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using KorcsoportVezet�Funkci�k;
using T�borvezet�Funkci�k;
using Ifj�s�giVezet�Funkci�k;
using Borders;


namespace Db
{
    public class DbConnection : DbContext
    {

        public DbConnection()
        {

        }


        public DbSet<Csoport> Csoportok { get; set; }

        public DbSet<H�z> H�zak { get; set; }

        public DbSet<Korcsoport> Korcsoportok { get; set; }

        public DbSet<Szoba> Szob�k { get; set; }

        public DbSet<T�boroz�> T�boroz�k { get; set; }

        public DbSet<Turnus> Turnusok { get; set; }

        public DbSet<Vezet�> Vezet�k { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Vezet�>()
        //        .Property
        //}

    }//end DbConnection

}//end namespace Db
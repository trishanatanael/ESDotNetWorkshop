﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ESDotNetWorkshop
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DafestyEntities2 : DbContext
{
    public DafestyEntities2()
        : base("name=DafestyEntities2")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Movie> Movies1 { get; set; }

    public virtual DbSet<Producer> Producers { get; set; }

}

}


﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MachineParametersContext : DbContext
    {
        public MachineParametersContext()
            : base("name=MachineParametersContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<coolant_tank> coolant_tank { get; set; }
        public virtual DbSet<guaging_amplifier> guaging_amplifier { get; set; }
        public virtual DbSet<guaging_dia_types> guaging_dia_types { get; set; }
        public virtual DbSet<guaging_dia_types_guaging_machines_mapping> guaging_dia_types_guaging_machines_mapping { get; set; }
        public virtual DbSet<guaging_machines> guaging_machines { get; set; }
        public virtual DbSet<guaging_machines_guaging_amplifier_mapping> guaging_machines_guaging_amplifier_mapping { get; set; }
        public virtual DbSet<guaging_make> guaging_make { get; set; }
        public virtual DbSet<guaging_slide_stroke> guaging_slide_stroke { get; set; }
        public virtual DbSet<machine_param_names> machine_param_names { get; set; }
        public virtual DbSet<machine_param_values> machine_param_values { get; set; }
        public virtual DbSet<machine> machines { get; set; }
        public virtual DbSet<saved_summary> saved_summary { get; set; }
        public virtual DbSet<tailstock_action> tailstock_action { get; set; }
        public virtual DbSet<tailstock_center> tailstock_center { get; set; }
        public virtual DbSet<tailstock_stroke> tailstock_stroke { get; set; }
        public virtual DbSet<wheel_head_dia> wheel_head_dia { get; set; }
        public virtual DbSet<wheel_head_motor> wheel_head_motor { get; set; }
    }
}

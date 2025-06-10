using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NorthwindDemo.Entities;

namespace NorthwindDemo.Context;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NewEmployeeEntry> NewEmployeeEntries { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseSqlServer("Data Source=10.132.36.114;Initial Catalog=test;User ID=sa;Password=lok@nic;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<NewEmployeeEntry>(entity =>
        {
            entity.Property(e => e.AttachVerifiedByCmho).IsFixedLength();
            entity.Property(e => e.AyushClearedObj).IsFixedLength();
            entity.Property(e => e.AyushEmpVerified).IsFixedLength();
            entity.Property(e => e.AyushRejectEmp).IsFixedLength();
            entity.Property(e => e.Ayushverify).IsFixedLength();
            entity.Property(e => e.BankDetVerifyByHosp).IsFixedLength();
            entity.Property(e => e.ClientIp).IsFixedLength();
            entity.Property(e => e.CmhoClearedObjection).IsFixedLength();
            entity.Property(e => e.CmhoEmpVerified).IsFixedLength();
            entity.Property(e => e.CmhoRejectEmp).IsFixedLength();
            entity.Property(e => e.ContactNoVerifyByCmho).IsFixedLength();
            entity.Property(e => e.ContactNoVerifyBySelf).IsFixedLength();
            entity.Property(e => e.DetachApply).IsFixedLength();
            entity.Property(e => e.DetachApproveByCmho).IsFixedLength();
            entity.Property(e => e.DhsClearedObj).IsFixedLength();
            entity.Property(e => e.DhsEmpVerified).IsFixedLength();
            entity.Property(e => e.DhsRejectEmp).IsFixedLength();
            entity.Property(e => e.Dhsverify).IsFixedLength();
            entity.Property(e => e.DmeClearedObj).IsFixedLength();
            entity.Property(e => e.DmeEmpVerified).IsFixedLength();
            entity.Property(e => e.DmeRejectEmp).IsFixedLength();
            entity.Property(e => e.Dmeverify).IsFixedLength();
            entity.Property(e => e.EarlierPosting).IsFixedLength();
            entity.Property(e => e.EmocTraineddoctors).IsFixedLength();
            entity.Property(e => e.FoodClearedObj).IsFixedLength();
            entity.Property(e => e.FoodEmpVerified).IsFixedLength();
            entity.Property(e => e.FoodRejectEmp).IsFixedLength();
            entity.Property(e => e.Foodverify).IsFixedLength();
            entity.Property(e => e.IsActive).IsFixedLength();
            entity.Property(e => e.IsExService).IsFixedLength();
            entity.Property(e => e.IsHandi).IsFixedLength();
            entity.Property(e => e.IsPromote).IsFixedLength();
            entity.Property(e => e.IsPwdChange).IsFixedLength();
            entity.Property(e => e.IsSpouseGov).IsFixedLength();
            entity.Property(e => e.IsSpousegovNongov).IsFixedLength();
            entity.Property(e => e.IsTransfer).IsFixedLength();
            entity.Property(e => e.IsTresuryVerify).IsFixedLength();
            entity.Property(e => e.LsasTrainenddoctors).IsFixedLength();
            entity.Property(e => e.NhmAckExp).IsFixedLength();
            entity.Property(e => e.NhmAckNoc).IsFixedLength();
            entity.Property(e => e.NhmAckNocExp).IsFixedLength();
            entity.Property(e => e.NhmClearedObj).IsFixedLength();
            entity.Property(e => e.NhmEmpVerified).IsFixedLength();
            entity.Property(e => e.NhmRejectEmp).IsFixedLength();
            entity.Property(e => e.Nhmverify).IsFixedLength();
            entity.Property(e => e.NuhmClearedObj).IsFixedLength();
            entity.Property(e => e.NuhmEmpReject).IsFixedLength();
            entity.Property(e => e.NuhmEmpVerified).IsFixedLength();
            entity.Property(e => e.Nuhmverify).IsFixedLength();
            entity.Property(e => e.RaisedObjection).IsFixedLength();
            entity.Property(e => e.RoleId).IsFixedLength();
            entity.Property(e => e.UserAckExp).IsFixedLength();
            entity.Property(e => e.UserAckExpNoc).IsFixedLength();
            entity.Property(e => e.UserAckNoc).IsFixedLength();
            entity.Property(e => e.UserApplyExp).IsFixedLength();
            entity.Property(e => e.UserApplyNoc).IsFixedLength();
            entity.Property(e => e.UserApplyNocExp).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

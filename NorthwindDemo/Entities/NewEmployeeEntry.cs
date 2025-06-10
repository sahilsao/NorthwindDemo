using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NorthwindDemo.Entities;

[PrimaryKey("Empcode", "WorkingStatus")]
[Table("NewEmployeeEntry")]
public partial class NewEmployeeEntry
{
    [Key]
    [Column("EMPCODE")]
    [StringLength(50)]
    public string Empcode { get; set; } = null!;

    [Column("DDOCODE")]
    [StringLength(50)]
    public string? Ddocode { get; set; }

    [Column("EMPNAME")]
    public string? Empname { get; set; }

    [Column("MOTHERNAME")]
    public string? Mothername { get; set; }

    [Column("FATHERNAME")]
    public string? Fathername { get; set; }

    [Column("SEX")]
    [StringLength(1)]
    public string? Sex { get; set; }

    [Column("DOB", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [Column("JOINDATE", TypeName = "datetime")]
    public DateTime? Joindate { get; set; }

    [Column("DistrictID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DistrictId { get; set; }

    [Column("HOMESTATE")]
    public string? Homestate { get; set; }

    [Column("HOMEDIST")]
    public string? Homedist { get; set; }

    [Column("HC_ID")]
    [StringLength(50)]
    public string? HcId { get; set; }

    [Column("HC_Type")]
    [StringLength(3)]
    public string? HcType { get; set; }

    [StringLength(50)]
    public string? PostCode { get; set; }

    [Column("PSCALE")]
    [StringLength(50)]
    public string? Pscale { get; set; }

    [Column("isPromote")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsPromote { get; set; }

    [Column("isTransfer")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsTransfer { get; set; }

    [Column("ETYPE")]
    [StringLength(2)]
    public string? Etype { get; set; }

    [Column("ESUBTYPE")]
    [StringLength(50)]
    public string? Esubtype { get; set; }

    [Column("ECLASS")]
    [StringLength(3)]
    public string? Eclass { get; set; }

    [Column("CATEGORY")]
    public int? Category { get; set; }

    [Column("isActive")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    [Column("TransDDO")]
    [StringLength(7)]
    public string? TransDdo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [StringLength(10)]
    public string? Reason { get; set; }

    [StringLength(50)]
    public string? JoiningTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDate { get; set; }

    [StringLength(50)]
    public string? QualiCode { get; set; }

    [Column("CourseID")]
    [StringLength(50)]
    public string? CourseId { get; set; }

    [Column("PGSubCode")]
    [StringLength(50)]
    public string? PgsubCode { get; set; }

    [StringLength(6)]
    public string? PgYear { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSpouseGov { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSpousegovNongov { get; set; }

    public string? SpouseName { get; set; }

    public string? SpouseDept { get; set; }

    [StringLength(50)]
    public string? SpouseDesig { get; set; }

    [StringLength(50)]
    public string? SpouseDist { get; set; }

    [StringLength(50)]
    public string? SpouseBlock { get; set; }

    [StringLength(200)]
    public string? Location { get; set; }

    public int? PostType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [StringLength(255)]
    public string? Remarks { get; set; }

    public int? AppCategory { get; set; }

    public string? AppOrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppOrderDate { get; set; }

    [StringLength(250)]
    public string? AppAuth { get; set; }

    [StringLength(250)]
    public string? OtherAuth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractTo { get; set; }

    [Column("isHandi")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsHandi { get; set; }

    [Column("isExService")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsExService { get; set; }

    [Column("EMPNAMEEng")]
    public string? Empnameeng { get; set; }

    [Column("lastUpDate", TypeName = "datetime")]
    public DateTime? LastUpDate { get; set; }

    [Key]
    [Column("workingStatus")]
    [StringLength(50)]
    public string WorkingStatus { get; set; } = null!;

    [Column("workingStatusDate", TypeName = "datetime")]
    public DateTime? WorkingStatusDate { get; set; }

    [StringLength(50)]
    public string? Contactnumber { get; set; }

    public string? PermanentAddress { get; set; }

    public string? PresentAddress { get; set; }

    public string? Email { get; set; }

    [StringLength(50)]
    public string? Isupdated { get; set; }

    [Column("DDOCODE_UPDATE", TypeName = "datetime")]
    public DateTime? DdocodeUpdate { get; set; }

    [Column("password")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("Traning_details")]
    public string? TraningDetails { get; set; }

    [Column("Traning_location")]
    public string? TraningLocation { get; set; }

    [Column("Training_fromdate")]
    public DateOnly? TrainingFromdate { get; set; }

    [Column("Traning_todate")]
    public DateOnly? TraningTodate { get; set; }

    public int? BankId { get; set; }

    [StringLength(50)]
    public string? BankAccno { get; set; }

    public string? Branchname { get; set; }

    [Column("BankIFSCcode")]
    [StringLength(50)]
    public string? BankIfsccode { get; set; }

    [StringLength(50)]
    public string? Bankdist { get; set; }

    [StringLength(350)]
    public string? ImagePath { get; set; }

    [StringLength(50)]
    public string? Adharcardno { get; set; }

    [StringLength(50)]
    public string? Drivinglicno { get; set; }

    [StringLength(50)]
    public string? Passportno { get; set; }

    [StringLength(50)]
    public string? Voteridno { get; set; }

    [StringLength(50)]
    public string? Bloodgrp { get; set; }

    public string? DeathReason { get; set; }

    public string? Resignationreason { get; set; }

    [Column("Posted_at_name")]
    public string? PostedAtName { get; set; }

    [StringLength(150)]
    public string? Contractnotexten { get; set; }

    [StringLength(1)]
    public string? Alreadyloginflag { get; set; }

    [Column("drivinglic")]
    [StringLength(50)]
    public string? Drivinglic { get; set; }

    [StringLength(50)]
    public string? Pancardno { get; set; }

    [Column("reporting_officer_id")]
    [StringLength(50)]
    public string? ReportingOfficerId { get; set; }

    [StringLength(50)]
    public string? UserUpdateFlag { get; set; }

    [Column("CMHOverify")]
    [StringLength(1)]
    public string? Cmhoverify { get; set; }

    [Column("photo")]
    [StringLength(350)]
    public string? Photo { get; set; }

    [StringLength(10)]
    public string? RaisedObjection { get; set; }

    [Column("RaisedObjection_Date")]
    public DateTime? RaisedObjectionDate { get; set; }

    [Column("CMHO_CLEARED_OBJECTION")]
    [StringLength(10)]
    public string? CmhoClearedObjection { get; set; }

    [Column("CMHO_CLEARED_OBJECTION_TIME")]
    public DateTime? CmhoClearedObjectionTime { get; set; }

    [Column("CMHO_Emp_verified")]
    [StringLength(1)]
    public string? CmhoEmpVerified { get; set; }

    [Column("CMHO_Emp_verified_date", TypeName = "datetime")]
    public DateTime? CmhoEmpVerifiedDate { get; set; }

    [Column("ReferenceID")]
    [StringLength(50)]
    public string? ReferenceId { get; set; }

    [Column("DHSverify")]
    [StringLength(1)]
    public string? Dhsverify { get; set; }

    [Column("NHMverify")]
    [StringLength(1)]
    public string? Nhmverify { get; set; }

    [Column("DHS_Forward_date")]
    public DateOnly? DhsForwardDate { get; set; }

    [Column("NHM_Forward_date")]
    public DateOnly? NhmForwardDate { get; set; }

    [Column("DMEverify")]
    [StringLength(1)]
    public string? Dmeverify { get; set; }

    [Column("DME_Forward_date", TypeName = "datetime")]
    public DateTime? DmeForwardDate { get; set; }

    [Column("DHS_Emp_verified")]
    [StringLength(1)]
    public string? DhsEmpVerified { get; set; }

    [Column("DHS_Emp_verified_date", TypeName = "datetime")]
    public DateTime? DhsEmpVerifiedDate { get; set; }

    [Column("DHS_Reject_Reason")]
    [StringLength(300)]
    [Unicode(false)]
    public string? DhsRejectReason { get; set; }

    [Column("DHS_CLEARED_OBJ")]
    [StringLength(1)]
    public string? DhsClearedObj { get; set; }

    [Column("DHS_CLEARED_OBJ_TIME", TypeName = "datetime")]
    public DateTime? DhsClearedObjTime { get; set; }

    [Column("DME_Emp_Verified")]
    [StringLength(1)]
    public string? DmeEmpVerified { get; set; }

    [Column("DME_Emp_Verified_Date", TypeName = "datetime")]
    public DateTime? DmeEmpVerifiedDate { get; set; }

    [Column("DME_CLEARED_OBJ")]
    [StringLength(1)]
    public string? DmeClearedObj { get; set; }

    [Column("DME_CLEARED_OBJ_TIME", TypeName = "datetime")]
    public DateTime? DmeClearedObjTime { get; set; }

    [Column("NHM_CLEARED_OBJ")]
    [StringLength(1)]
    public string? NhmClearedObj { get; set; }

    [Column("NHM_CLEARED_OBJ_TIME", TypeName = "datetime")]
    public DateTime? NhmClearedObjTime { get; set; }

    [Column("NHM_Emp_Verified")]
    [StringLength(1)]
    public string? NhmEmpVerified { get; set; }

    [Column("NHM_Emp_Verified_Date", TypeName = "datetime")]
    public DateTime? NhmEmpVerifiedDate { get; set; }

    [Column("CMHO_reject_emp")]
    [StringLength(1)]
    public string? CmhoRejectEmp { get; set; }

    [Column("NHM_reject_emp")]
    [StringLength(1)]
    public string? NhmRejectEmp { get; set; }

    [Column("DME_reject_emp")]
    [StringLength(1)]
    public string? DmeRejectEmp { get; set; }

    [Column("DHS_reject_emp")]
    [StringLength(1)]
    public string? DhsRejectEmp { get; set; }

    [StringLength(1)]
    public string? Ayushverify { get; set; }

    [Column("Ayush_Emp_Verified")]
    [StringLength(1)]
    public string? AyushEmpVerified { get; set; }

    [Column("Ayush_Emp_Verified_Date", TypeName = "datetime")]
    public DateTime? AyushEmpVerifiedDate { get; set; }

    [Column("AYUSH_CLEARED_OBJ")]
    [StringLength(1)]
    public string? AyushClearedObj { get; set; }

    [Column("AYUSH_CLEARED_OBJ_TIME", TypeName = "datetime")]
    public DateTime? AyushClearedObjTime { get; set; }

    [Column("Ayush_reject_emp")]
    [StringLength(1)]
    public string? AyushRejectEmp { get; set; }

    [Column("REJECT_REMARK")]
    public string? RejectRemark { get; set; }

    [Column("FOODverify")]
    [StringLength(1)]
    public string? Foodverify { get; set; }

    [Column("FOOD_Forward_date", TypeName = "datetime")]
    public DateTime? FoodForwardDate { get; set; }

    [Column("FOOD_Emp_Verified")]
    [StringLength(1)]
    public string? FoodEmpVerified { get; set; }

    [Column("FOOD_Emp_Verified_Date", TypeName = "datetime")]
    public DateTime? FoodEmpVerifiedDate { get; set; }

    [Column("FOOD_CLEARED_OBJ")]
    [StringLength(1)]
    public string? FoodClearedObj { get; set; }

    [Column("FOOD_CLEARED_OBJ_TIME", TypeName = "datetime")]
    public DateTime? FoodClearedObjTime { get; set; }

    [Column("FOOD_reject_emp")]
    [StringLength(1)]
    public string? FoodRejectEmp { get; set; }

    [Column("Dept_Code")]
    [StringLength(50)]
    public string? DeptCode { get; set; }

    [Column("reporting_officer")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReportingOfficer { get; set; }

    [Column("role_id")]
    [StringLength(3)]
    public string? RoleId { get; set; }

    [Column("client_ip")]
    [StringLength(15)]
    public string? ClientIp { get; set; }

    [Column("reporting_officer_cl")]
    [StringLength(11)]
    public string? ReportingOfficerCl { get; set; }

    [Column("reporting_officer_el")]
    [StringLength(11)]
    public string? ReportingOfficerEl { get; set; }

    [Column("Approving_Auth_Leave_cl")]
    [StringLength(11)]
    public string? ApprovingAuthLeaveCl { get; set; }

    [Column("Approving_Auth_Leave_el")]
    [StringLength(11)]
    public string? ApprovingAuthLeaveEl { get; set; }

    [Column("reporting_officer_ol")]
    [StringLength(50)]
    public string? ReportingOfficerOl { get; set; }

    [Column("reporting_officer_hpl")]
    [StringLength(50)]
    public string? ReportingOfficerHpl { get; set; }

    [Column("reporting_officer_commuted")]
    [StringLength(50)]
    public string? ReportingOfficerCommuted { get; set; }

    [Column("reporting_officer_extraordinary")]
    [StringLength(50)]
    public string? ReportingOfficerExtraordinary { get; set; }

    [Column("reporting_officer_maternity")]
    [StringLength(50)]
    public string? ReportingOfficerMaternity { get; set; }

    [Column("reporting_officer_paternity")]
    [StringLength(50)]
    public string? ReportingOfficerPaternity { get; set; }

    [Column("reporting_officer_childcare")]
    [StringLength(50)]
    public string? ReportingOfficerChildcare { get; set; }

    [Column("Approving_Auth_Leave_ol")]
    [StringLength(50)]
    public string? ApprovingAuthLeaveOl { get; set; }

    [Column("Approving_Auth_Leave_hpl")]
    [StringLength(50)]
    public string? ApprovingAuthLeaveHpl { get; set; }

    [Column("Approving_Auth_Leave_commuted")]
    [StringLength(50)]
    public string? ApprovingAuthLeaveCommuted { get; set; }

    [Column("Approving_Auth_Leave_extraordinary")]
    [StringLength(50)]
    public string? ApprovingAuthLeaveExtraordinary { get; set; }

    [Column("Approving_Auth_Leave_maternity")]
    [StringLength(50)]
    public string? ApprovingAuthLeaveMaternity { get; set; }

    [Column("Approving_Auth_Leave_paternity")]
    [StringLength(50)]
    public string? ApprovingAuthLeavePaternity { get; set; }

    [Column("Approving_Auth_Leave_childcare")]
    [StringLength(50)]
    public string? ApprovingAuthLeaveChildcare { get; set; }

    [Column("LSAS_trainenddoctors")]
    [StringLength(1)]
    public string? LsasTrainenddoctors { get; set; }

    [Column("EMOC_traineddoctors")]
    [StringLength(1)]
    public string? EmocTraineddoctors { get; set; }

    [Column("SubProgramme_ID")]
    [StringLength(50)]
    public string? SubProgrammeId { get; set; }

    [Column("NUHMVerify")]
    [StringLength(1)]
    public string? Nuhmverify { get; set; }

    [Column("NUHM_Forward_date", TypeName = "datetime")]
    public DateTime? NuhmForwardDate { get; set; }

    [Column("NUHM_CLEARED_OBJ")]
    [StringLength(1)]
    public string? NuhmClearedObj { get; set; }

    [Column("NUHM_CLEARED_OBJ_TIME", TypeName = "datetime")]
    public DateTime? NuhmClearedObjTime { get; set; }

    [Column("NUHM_Emp_Verified")]
    [StringLength(1)]
    public string? NuhmEmpVerified { get; set; }

    [Column("NUHM_Emp_Verified_Date", TypeName = "datetime")]
    public DateTime? NuhmEmpVerifiedDate { get; set; }

    [Column("NUHM_Emp_Reject")]
    [StringLength(1)]
    public string? NuhmEmpReject { get; set; }

    [Column("User_apply_exp")]
    [StringLength(1)]
    public string? UserApplyExp { get; set; }

    [Column("Applied_exp")]
    [StringLength(50)]
    public string? AppliedExp { get; set; }

    [Column("User_apply_noc")]
    [StringLength(1)]
    public string? UserApplyNoc { get; set; }

    [Column("Applied_noc")]
    [StringLength(50)]
    public string? AppliedNoc { get; set; }

    [Column("User_apply_noc_exp")]
    [StringLength(1)]
    public string? UserApplyNocExp { get; set; }

    [Column("Applied_noc_exp")]
    [StringLength(50)]
    public string? AppliedNocExp { get; set; }

    [Column("User_ack_noc")]
    [StringLength(1)]
    public string? UserAckNoc { get; set; }

    [Column("User_ack_exp")]
    [StringLength(1)]
    public string? UserAckExp { get; set; }

    [Column("User_ack_exp_noc")]
    [StringLength(1)]
    public string? UserAckExpNoc { get; set; }

    [Column("User_apply_date", TypeName = "datetime")]
    public DateTime? UserApplyDate { get; set; }

    [Column("nhm_ack_exp")]
    [StringLength(1)]
    public string? NhmAckExp { get; set; }

    [Column("nhm_ack_noc")]
    [StringLength(1)]
    public string? NhmAckNoc { get; set; }

    [Column("nhm_ack_noc_exp")]
    [StringLength(1)]
    public string? NhmAckNocExp { get; set; }

    [Column("noc_pdf")]
    [StringLength(350)]
    public string? NocPdf { get; set; }

    [Column("pdfdatetime", TypeName = "datetime")]
    public DateTime? Pdfdatetime { get; set; }

    [Column("noc_cer_regno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NocCerRegno { get; set; }

    [Column("exp_cer_regno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ExpCerRegno { get; set; }

    public int? InPostCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecordUpdateFrom { get; set; }

    public DateOnly? RecordUpdateDate { get; set; }

    [Column("attachment_id")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AttachmentId { get; set; }

    [Column("attach_district_id")]
    [StringLength(5)]
    [Unicode(false)]
    public string? AttachDistrictId { get; set; }

    [Column("attach_hc_id")]
    [StringLength(15)]
    [Unicode(false)]
    public string? AttachHcId { get; set; }

    [Column("attach_hc_type")]
    [StringLength(3)]
    [Unicode(false)]
    public string? AttachHcType { get; set; }

    [Column("attach_orderNo")]
    public string? AttachOrderNo { get; set; }

    [Column("attach_date")]
    public DateOnly? AttachDate { get; set; }

    [Column("attach_verified_by_cmho")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AttachVerifiedByCmho { get; set; }

    [Column("attach_verified_by_cmho_date", TypeName = "datetime")]
    public DateTime? AttachVerifiedByCmhoDate { get; set; }

    [Column("attach_Apply_date", TypeName = "datetime")]
    public DateTime? AttachApplyDate { get; set; }

    [Column("detach_apply")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DetachApply { get; set; }

    [Column("detach_apply_date", TypeName = "datetime")]
    public DateTime? DetachApplyDate { get; set; }

    [Column("detach_ApproveByCMHO")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DetachApproveByCmho { get; set; }

    [Column("detach_ApproveDateByCMHO", TypeName = "datetime")]
    public DateTime? DetachApproveDateByCmho { get; set; }

    [Column("ContactNoVerifyByCMHO")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContactNoVerifyByCmho { get; set; }

    [Column("ContactNoVerifyByCMHODate", TypeName = "datetime")]
    public DateTime? ContactNoVerifyByCmhodate { get; set; }

    [Column("GrdDeg_Code")]
    public int? GrdDegCode { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? MulVibhag { get; set; }

    [Column("deputation_id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeputationId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("LoginTypeID")]
    public int? LoginTypeId { get; set; }

    public int CheckId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BankDetVerifyByHosp { get; set; }

    [Column("BankDetVerifyByHosp_date", TypeName = "datetime")]
    public DateTime? BankDetVerifyByHospDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ContactNoVerifyBySelf { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContactNoVerifyBySelfDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsTresuryVerify { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsPwdChange { get; set; }

    [Column("pwdupdate", TypeName = "datetime")]
    public DateTime? Pwdupdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EarlierPosting { get; set; }
}

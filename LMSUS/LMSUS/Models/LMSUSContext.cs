using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMSUS.Models
{
    public partial class LMSUSContext : DbContext
    {
        public LMSUSContext()
        {
        }

        public LMSUSContext(DbContextOptions<LMSUSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aclresults> Aclresults { get; set; }
        public virtual DbSet<AclresultsTmp> AclresultsTmp { get; set; }
        public virtual DbSet<AmagrAntiAgent> AmagrAntiAgent { get; set; }
        public virtual DbSet<AmaGroup> AmaGroup { get; set; }
        public virtual DbSet<AntiMicroAgent> AntiMicroAgent { get; set; }
        public virtual DbSet<AuditAction> AuditAction { get; set; }
        public virtual DbSet<AuditCustom> AuditCustom { get; set; }
        public virtual DbSet<BarcodeLoacationType> BarcodeLoacationType { get; set; }
        public virtual DbSet<BarcodeLocation> BarcodeLocation { get; set; }
        public virtual DbSet<BatchMaster> BatchMaster { get; set; }
        public virtual DbSet<BComments> BComments { get; set; }
        public virtual DbSet<BDiagnosis> BDiagnosis { get; set; }
        public virtual DbSet<BDiagnosis10> BDiagnosis10 { get; set; }
        public virtual DbSet<BDoctor> BDoctor { get; set; }
        public virtual DbSet<BillOnlyTest> BillOnlyTest { get; set; }
        public virtual DbSet<BInsurance> BInsurance { get; set; }
        public virtual DbSet<BodyParts> BodyParts { get; set; }
        public virtual DbSet<BPatient> BPatient { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Celldyndata> Celldyndata { get; set; }
        public virtual DbSet<CelldyndataTmp> CelldyndataTmp { get; set; }
        public virtual DbSet<Celldyninterface> Celldyninterface { get; set; }
        public virtual DbSet<CentaurResults> CentaurResults { get; set; }
        public virtual DbSet<CentaurResultsCopy> CentaurResultsCopy { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientInvoices> ClientInvoices { get; set; }
        public virtual DbSet<ClientTranMaster> ClientTranMaster { get; set; }
        public virtual DbSet<ClinicalResult> ClinicalResult { get; set; }
        public virtual DbSet<ClinicalResultComm> ClinicalResultComm { get; set; }
        public virtual DbSet<ClinicalResultUnspecfied> ClinicalResultUnspecfied { get; set; }
        public virtual DbSet<ClinicalTest> ClinicalTest { get; set; }
        public virtual DbSet<ClinicalTestAutoVerificationTypes> ClinicalTestAutoVerificationTypes { get; set; }
        public virtual DbSet<ClinicalTestBackup> ClinicalTestBackup { get; set; }
        public virtual DbSet<ClinicalTestBackupBackup> ClinicalTestBackupBackup { get; set; }
        public virtual DbSet<ClinicalTestRefLabMapping> ClinicalTestRefLabMapping { get; set; }
        public virtual DbSet<Cobase411results> Cobase411results { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<CommentType> CommentType { get; set; }
        public virtual DbSet<CompanyInformation> CompanyInformation { get; set; }
        public virtual DbSet<CompanyProviderId> CompanyProviderId { get; set; }
        public virtual DbSet<CompletedReport> CompletedReport { get; set; }
        public virtual DbSet<Cptcodes> Cptcodes { get; set; }
        public virtual DbSet<CytoCatagory> CytoCatagory { get; set; }
        public virtual DbSet<CytologyTest> CytologyTest { get; set; }
        public virtual DbSet<CytoParameters> CytoParameters { get; set; }
        public virtual DbSet<CytoSpeciality> CytoSpeciality { get; set; }
        public virtual DbSet<DeletedTest> DeletedTest { get; set; }
        public virtual DbSet<Deletelog> Deletelog { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<Diagnosis10> Diagnosis10 { get; set; }
        public virtual DbSet<Diagnosis10new> Diagnosis10new { get; set; }
        public virtual DbSet<DocReview> DocReview { get; set; }
        public virtual DbSet<DocReviewMicroCodes> DocReviewMicroCodes { get; set; }
        public virtual DbSet<Edicomments> Edicomments { get; set; }
        public virtual DbSet<Edicontrols> Edicontrols { get; set; }
        public virtual DbSet<Edisubmission> Edisubmission { get; set; }
        public virtual DbSet<EdisubmissionDetail> EdisubmissionDetail { get; set; }
        public virtual DbSet<ElegibiltyError> ElegibiltyError { get; set; }
        public virtual DbSet<EligibilityInsurance> EligibilityInsurance { get; set; }
        public virtual DbSet<EligibilityMapping> EligibilityMapping { get; set; }
        public virtual DbSet<Emdeon> Emdeon { get; set; }
        public virtual DbSet<EmdeonReports> EmdeonReports { get; set; }
        public virtual DbSet<FaxCoverPageInfo> FaxCoverPageInfo { get; set; }
        public virtual DbSet<FaxLog> FaxLog { get; set; }
        public virtual DbSet<FaxReportCriteria> FaxReportCriteria { get; set; }
        public virtual DbSet<FaxReportCriteriaAccessions> FaxReportCriteriaAccessions { get; set; }
        public virtual DbSet<Fix> Fix { get; set; }
        public virtual DbSet<FormDescription> FormDescription { get; set; }
        public virtual DbSet<Frequency> Frequency { get; set; }
        public virtual DbSet<Grossing> Grossing { get; set; }
        public virtual DbSet<GrossResults> GrossResults { get; set; }
        public virtual DbSet<GroupDetail> GroupDetail { get; set; }
        public virtual DbSet<GroupRights> GroupRights { get; set; }
        public virtual DbSet<GroupTest> GroupTest { get; set; }
        public virtual DbSet<GroupTestDetail> GroupTestDetail { get; set; }
        public virtual DbSet<GroupTestRefLabMapping> GroupTestRefLabMapping { get; set; }
        public virtual DbSet<Hl7interface> Hl7interface { get; set; }
        public virtual DbSet<Hl7log> Hl7log { get; set; }
        public virtual DbSet<Hl7Zef> Hl7Zef { get; set; }
        public virtual DbSet<Hl7Zps> Hl7Zps { get; set; }
        public virtual DbSet<Indications> Indications { get; set; }
        public virtual DbSet<InfoSheet> InfoSheet { get; set; }
        public virtual DbSet<InhouseLabTestMapping> InhouseLabTestMapping { get; set; }
        public virtual DbSet<InsSpecificBill> InsSpecificBill { get; set; }
        public virtual DbSet<InsTranMaster> InsTranMaster { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<InsuranceProviderOrganization> InsuranceProviderOrganization { get; set; }
        public virtual DbSet<InsuranceRequestMain> InsuranceRequestMain { get; set; }
        public virtual DbSet<InsuranceRequestPhysician> InsuranceRequestPhysician { get; set; }
        public virtual DbSet<InsuranceResponseDetail> InsuranceResponseDetail { get; set; }
        public virtual DbSet<InsuranceResponseEbadditionalInfo> InsuranceResponseEbadditionalInfo { get; set; }
        public virtual DbSet<InsuranceResponseEbdates> InsuranceResponseEbdates { get; set; }
        public virtual DbSet<InsuranceResponseEbidentification> InsuranceResponseEbidentification { get; set; }
        public virtual DbSet<InsuranceResponseEbmessages> InsuranceResponseEbmessages { get; set; }
        public virtual DbSet<InsuranceResponseEbprocedures> InsuranceResponseEbprocedures { get; set; }
        public virtual DbSet<InsuranceResponseMain> InsuranceResponseMain { get; set; }
        public virtual DbSet<InsuranceResponsePhysician> InsuranceResponsePhysician { get; set; }
        public virtual DbSet<InsuranceResponseSubscriber> InsuranceResponseSubscriber { get; set; }
        public virtual DbSet<InsuranceResponseSubscriberDates> InsuranceResponseSubscriberDates { get; set; }
        public virtual DbSet<InsuranceResponseSubscriberEb> InsuranceResponseSubscriberEb { get; set; }
        public virtual DbSet<InsuranceResponseSubscriberEbmain> InsuranceResponseSubscriberEbmain { get; set; }
        public virtual DbSet<InsuranceResponseSubscriberIdentification> InsuranceResponseSubscriberIdentification { get; set; }
        public virtual DbSet<InsuranceResponseValidations> InsuranceResponseValidations { get; set; }
        public virtual DbSet<InsurnaceRequestSubscriber> InsurnaceRequestSubscriber { get; set; }
        public virtual DbSet<InvoiceInsurance> InvoiceInsurance { get; set; }
        public virtual DbSet<InvoiceMaster> InvoiceMaster { get; set; }
        public virtual DbSet<InvoicePatientInsurance> InvoicePatientInsurance { get; set; }
        public virtual DbSet<InvoiceTest> InvoiceTest { get; set; }
        public virtual DbSet<InvoiceTestForGroupedCpt> InvoiceTestForGroupedCpt { get; set; }
        public virtual DbSet<Labcorptest> Labcorptest { get; set; }
        public virtual DbSet<Labcorptest1> Labcorptest1 { get; set; }
        public virtual DbSet<LabPro> LabPro { get; set; }
        public virtual DbSet<LabProLog> LabProLog { get; set; }
        public virtual DbSet<LabTestMapping> LabTestMapping { get; set; }
        public virtual DbSet<LetterTemplate> LetterTemplate { get; set; }
        public virtual DbSet<LmsauditOther> LmsauditOther { get; set; }
        public virtual DbSet<LmsauditTrial> LmsauditTrial { get; set; }
        public virtual DbSet<LmsUser> LmsUser { get; set; }
        public virtual DbSet<MachineTests> MachineTests { get; set; }
        public virtual DbSet<MicrobialMapping> MicrobialMapping { get; set; }
        public virtual DbSet<MicroBiologyResult> MicroBiologyResult { get; set; }
        public virtual DbSet<MicrobiologyTest> MicrobiologyTest { get; set; }
        public virtual DbSet<MicroCodes> MicroCodes { get; set; }
        public virtual DbSet<MicroHl7Result> MicroHl7Result { get; set; }
        public virtual DbSet<MicroResultIsolate> MicroResultIsolate { get; set; }
        public virtual DbSet<MicroResultOrganism> MicroResultOrganism { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<NowCategory> NowCategory { get; set; }
        public virtual DbSet<NowCategorymodule> NowCategorymodule { get; set; }
        public virtual DbSet<NowCategorytype> NowCategorytype { get; set; }
        public virtual DbSet<NowClient> NowClient { get; set; }
        public virtual DbSet<NowClientmodule> NowClientmodule { get; set; }
        public virtual DbSet<NowCompany> NowCompany { get; set; }
        public virtual DbSet<NowCountry> NowCountry { get; set; }
        public virtual DbSet<NowFilestatus> NowFilestatus { get; set; }
        public virtual DbSet<NowFiletype> NowFiletype { get; set; }
        public virtual DbSet<NowFileuploadPatient> NowFileuploadPatient { get; set; }
        public virtual DbSet<NowLabitem> NowLabitem { get; set; }
        public virtual DbSet<NowLabitemcategory> NowLabitemcategory { get; set; }
        public virtual DbSet<NowLabitemclientaddress> NowLabitemclientaddress { get; set; }
        public virtual DbSet<NowLabitemrequest> NowLabitemrequest { get; set; }
        public virtual DbSet<NowLabitemrequestdetail> NowLabitemrequestdetail { get; set; }
        public virtual DbSet<NowLabitemrequestshipmentcomany> NowLabitemrequestshipmentcomany { get; set; }
        public virtual DbSet<NowLabitemrequestshipmentdetail> NowLabitemrequestshipmentdetail { get; set; }
        public virtual DbSet<NowLabitemrequeststatus> NowLabitemrequeststatus { get; set; }
        public virtual DbSet<NowLabitemsupplier> NowLabitemsupplier { get; set; }
        public virtual DbSet<NowLabitemsupplierdetail> NowLabitemsupplierdetail { get; set; }
        public virtual DbSet<NowLabitemunittype> NowLabitemunittype { get; set; }
        public virtual DbSet<NowModule> NowModule { get; set; }
        public virtual DbSet<NowPatwebreq> NowPatwebreq { get; set; }
        public virtual DbSet<NowPatwebreqbatch> NowPatwebreqbatch { get; set; }
        public virtual DbSet<NowPatwebtest> NowPatwebtest { get; set; }
        public virtual DbSet<NowProduct> NowProduct { get; set; }
        public virtual DbSet<NowProductcategory> NowProductcategory { get; set; }
        public virtual DbSet<NowProductcategoryspec> NowProductcategoryspec { get; set; }
        public virtual DbSet<NowProductcatspecvalue> NowProductcatspecvalue { get; set; }
        public virtual DbSet<NowProductcompany> NowProductcompany { get; set; }
        public virtual DbSet<NowProductcustomeraddress> NowProductcustomeraddress { get; set; }
        public virtual DbSet<NowState> NowState { get; set; }
        public virtual DbSet<Olympusdata> Olympusdata { get; set; }
        public virtual DbSet<OlympusdataCopy> OlympusdataCopy { get; set; }
        public virtual DbSet<Olympusdatanew> Olympusdatanew { get; set; }
        public virtual DbSet<Organism> Organism { get; set; }
        public virtual DbSet<OrgnismMapping> OrgnismMapping { get; set; }
        public virtual DbSet<PatCyto> PatCyto { get; set; }
        public virtual DbSet<Pathologist> Pathologist { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientE> PatientE { get; set; }
        public virtual DbSet<PatientReq> PatientReq { get; set; }
        public virtual DbSet<PatientReqAddnBillInfo> PatientReqAddnBillInfo { get; set; }
        public virtual DbSet<PatientReqBillTests> PatientReqBillTests { get; set; }
        public virtual DbSet<PatientReqDiag> PatientReqDiag { get; set; }
        public virtual DbSet<PatientReqDiagE> PatientReqDiagE { get; set; }
        public virtual DbSet<PatientReqDocuments> PatientReqDocuments { get; set; }
        public virtual DbSet<PatientReqE> PatientReqE { get; set; }
        public virtual DbSet<PatientReqOtherInfo> PatientReqOtherInfo { get; set; }
        public virtual DbSet<PatientReqTest> PatientReqTest { get; set; }
        public virtual DbSet<PatientReqTestE> PatientReqTestE { get; set; }
        public virtual DbSet<PatientReqTestU> PatientReqTestU { get; set; }
        public virtual DbSet<PatientReqTestUnMap> PatientReqTestUnMap { get; set; }
        public virtual DbSet<PatientUnSpecefied> PatientUnSpecefied { get; set; }
        public virtual DbSet<PatSchedule> PatSchedule { get; set; }
        public virtual DbSet<PatScheduleTest> PatScheduleTest { get; set; }
        public virtual DbSet<PayerDictionaryUpdate> PayerDictionaryUpdate { get; set; }
        public virtual DbSet<PracAdditionalTest> PracAdditionalTest { get; set; }
        public virtual DbSet<PracCat> PracCat { get; set; }
        public virtual DbSet<PracDoc> PracDoc { get; set; }
        public virtual DbSet<Practice> Practice { get; set; }
        public virtual DbSet<PracticeAutoRemotePrintLog> PracticeAutoRemotePrintLog { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<PrintLog> PrintLog { get; set; }
        public virtual DbSet<Procedures> Procedures { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfileDetail> ProfileDetail { get; set; }
        public virtual DbSet<ProfileTestRefLabMapping> ProfileTestRefLabMapping { get; set; }
        public virtual DbSet<Qcmain> Qcmain { get; set; }
        public virtual DbSet<Qctest> Qctest { get; set; }
        public virtual DbSet<QctestResult> QctestResult { get; set; }
        public virtual DbSet<QuestResultLabCodes> QuestResultLabCodes { get; set; }
        public virtual DbSet<QuestTests> QuestTests { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<RefClinicLab> RefClinicLab { get; set; }
        public virtual DbSet<RefDocSpIns> RefDocSpIns { get; set; }
        public virtual DbSet<RefDocSpTest> RefDocSpTest { get; set; }
        public virtual DbSet<RefDoctor> RefDoctor { get; set; }
        public virtual DbSet<RefDoctorAdditionalTest> RefDoctorAdditionalTest { get; set; }
        public virtual DbSet<RefDoctorOld> RefDoctorOld { get; set; }
        public virtual DbSet<RefDoctorOld2> RefDoctorOld2 { get; set; }
        public virtual DbSet<Reflab> Reflab { get; set; }
        public virtual DbSet<Relations> Relations { get; set; }
        public virtual DbSet<RemotePrintingData> RemotePrintingData { get; set; }
        public virtual DbSet<ReportSetup> ReportSetup { get; set; }
        public virtual DbSet<ReportTest> ReportTest { get; set; }
        public virtual DbSet<SalesMan> SalesMan { get; set; }
        public virtual DbSet<Shape> Shape { get; set; }
        public virtual DbSet<ShielCompendiumT> ShielCompendiumT { get; set; }
        public virtual DbSet<ShortcutKeys> ShortcutKeys { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<SiteIdentifier> SiteIdentifier { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<Specimen> Specimen { get; set; }
        public virtual DbSet<SpecimenType> SpecimenType { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SuperProfile> SuperProfile { get; set; }
        public virtual DbSet<SuperProfileDetail> SuperProfileDetail { get; set; }
        public virtual DbSet<SuperProfileTestRefLabMapping> SuperProfileTestRefLabMapping { get; set; }
        public virtual DbSet<SysForms> SysForms { get; set; }
        public virtual DbSet<SysUserForms> SysUserForms { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TempPrice> TempPrice { get; set; }
        public virtual DbSet<Temprecdate> Temprecdate { get; set; }
        public virtual DbSet<TestBilling> TestBilling { get; set; }
        public virtual DbSet<TestRelatedDiag> TestRelatedDiag { get; set; }
        public virtual DbSet<TestRelatedDiag10> TestRelatedDiag10 { get; set; }
        public virtual DbSet<TestRelatedDiag101> TestRelatedDiag101 { get; set; }
        public virtual DbSet<TestResultRange> TestResultRange { get; set; }
        public virtual DbSet<TestType> TestType { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<TransmittingJob> TransmittingJob { get; set; }
        public virtual DbSet<UltimatePatient> UltimatePatient { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Vitek> Vitek { get; set; }
        public virtual DbSet<WorkSheet> WorkSheet { get; set; }
        public virtual DbSet<WorkSheetTest> WorkSheetTest { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }
        public virtual DbSet<ZipCodenew> ZipCodenew { get; set; }

        // Unable to generate entity type for table 'dbo.event_id'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.earange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Log_Register'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.test1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.form_log_register'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Ins_Tran_Master1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BillAudit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bkp_20022013_Comments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sheet1$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Variant2Results'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TestRanges'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.testing1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LabCorpSheet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_Results_All'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InsuranceCompanyTest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MICROCODES1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AOE_QTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.now_indtest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.B_CompanyInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OLYMPUSTESTS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Invoice_Diag'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.INDTEST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_LabTestMapping'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'realtime (6)$''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InsuranceTmpLC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ClientInvoicePayment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Invoice_Detail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LMS_DocRequisitionNos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LMS_System'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DOCTOR_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EligibilityInsurance07132017'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InsuranceFox'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NSMLCompendium'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_LabInsCMapping'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Questcompendium2192016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PatTest_Fox'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sheet2_Qdx$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_Results'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cobasC311Results'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sheet2$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_TestComments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cobase6000results'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_TestMapping_NotUsing'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_TestOrder'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.doctor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.userinfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.city_old'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.'SearchEra (2)$''. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.state_old'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.userinfo_copy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OLYMPUSTESTS_ForTesting'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zipcode_old'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AutoGenValues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Quest_Micro'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.erange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.olympusdate_copy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NewProviderQDX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temprecdatedata'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ICD10'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_TestComments_All'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zipcodeup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Invoice_Diag10'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Clinical_Result_bk04222016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.testdiag'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.insbill'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Ref_Doctor_Additionaltest12'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OLYMPUSDATA$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.newPractice$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Map$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sheetCC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.repset'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TestBillAmount$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sheet13$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PatientReq_SpecRecvd'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Practice5102016$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HL7_LabTestMapping_04022016_Backup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NSMLCompendium1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Clinical_test_backupnew'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Org$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUDIT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Order_QTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NewPractice5-17-2016$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AtlasInterfaceResults'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VenderInformation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.5-23-2016Practice$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.5-28-2016$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Client_Previous'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Clinical_Result_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.doctor_Fox'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5N1SE0R;Initial Catalog=LMSUS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aclresults>(entity =>
            {
                entity.HasKey(e => e.Aclid);

                entity.ToTable("ACLResults");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.AccDate).HasColumnType("datetime");

                entity.Property(e => e.AccessionNumber)
                    .HasColumnName("Accession Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result1)
                    .HasColumnName("Result 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result2)
                    .HasColumnName("Result 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AclresultsTmp>(entity =>
            {
                entity.HasKey(e => e.Aclid);

                entity.ToTable("ACLResults_tmp");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.AccessionNumber)
                    .HasColumnName("Accession Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result1)
                    .HasColumnName("Result 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result2)
                    .HasColumnName("Result 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmagrAntiAgent>(entity =>
            {
                entity.HasKey(e => e.AmaGrDetailId);

                entity.ToTable("AMAGr_AntiAgent");

                entity.Property(e => e.AmaGrDetailId).HasColumnName("AMA_GrDetail_Id");

                entity.Property(e => e.AgId).HasColumnName("Ag_Id");

                entity.Property(e => e.AmaGrId).HasColumnName("AMA_gr_Id");

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.AmagrAntiAgent)
                    .HasForeignKey(d => d.AgId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AMAGr_AntiAgent_Anti_Micro_Agent");

                entity.HasOne(d => d.AmaGr)
                    .WithMany(p => p.AmagrAntiAgent)
                    .HasForeignKey(d => d.AmaGrId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AMAGr_AntiAgent_AMA_Group");
            });

            modelBuilder.Entity<AmaGroup>(entity =>
            {
                entity.HasKey(e => e.AmaGrId);

                entity.ToTable("AMA_Group");

                entity.Property(e => e.AmaGrId).HasColumnName("AMA_Gr_Id");

                entity.Property(e => e.AmaGrCode).HasColumnName("AMA_Gr_Code");

                entity.Property(e => e.AmaGrName)
                    .HasColumnName("AMA_Gr_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AntiMicroAgent>(entity =>
            {
                entity.HasKey(e => e.AgId);

                entity.ToTable("Anti_Micro_Agent");

                entity.Property(e => e.AgId).HasColumnName("Ag_Id");

                entity.Property(e => e.AgCode).HasColumnName("Ag_Code");

                entity.Property(e => e.AgMin)
                    .HasColumnName("Ag_Min")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("Ag_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgShortCode)
                    .HasColumnName("Ag_ShortCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AgStr)
                    .HasColumnName("Ag_Str")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgWorkSheet)
                    .HasColumnName("Ag_WorkSheet")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditAction>(entity =>
            {
                entity.Property(e => e.AuditActionId).HasColumnName("AuditActionID");

                entity.Property(e => e.AuditActionDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditCustom>(entity =>
            {
                entity.ToTable("Audit_Custom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Naudid)
                    .HasColumnName("NAudid")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pk)
                    .HasColumnName("PK")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BarcodeLoacationType>(entity =>
            {
                entity.HasKey(e => e.BarcodeLocationTypeId);

                entity.Property(e => e.BarcodeLocationTypeId).HasColumnName("BarcodeLocationTypeID");

                entity.Property(e => e.BarcodeLocationType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BarcodeLocation>(entity =>
            {
                entity.HasKey(e => e.BarcodeLoactionId);

                entity.Property(e => e.BarcodeLoactionId).HasColumnName("BarcodeLoactionID");

                entity.Property(e => e.BarcodeAngle).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.BarcodeAngleTolerance).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.X).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.Y).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.DocumentTypeNavigation)
                    .WithMany(p => p.BarcodeLocation)
                    .HasForeignKey(d => d.DocumentType)
                    .HasConstraintName("FK_BarcodeLocation_BarcodeLoacationType");
            });

            modelBuilder.Entity<BatchMaster>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("Batch_Master");

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.BatchNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BatchType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Icn)
                    .HasColumnName("ICN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BComments>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("B_Comments");

                entity.Property(e => e.ComId).HasColumnName("Com_Id");

                entity.Property(e => e.ComCode)
                    .HasColumnName("Com_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComDesc)
                    .HasColumnName("Com_Desc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BDiagnosis>(entity =>
            {
                entity.HasKey(e => e.DiaId);

                entity.ToTable("B_Diagnosis");

                entity.Property(e => e.DiaId)
                    .HasColumnName("Dia_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DiaCode)
                    .IsRequired()
                    .HasColumnName("Dia_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaName)
                    .HasColumnName("Dia_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BDiagnosis10>(entity =>
            {
                entity.HasKey(e => e.DiaId);

                entity.ToTable("B_Diagnosis_10");

                entity.Property(e => e.DiaId)
                    .HasColumnName("Dia_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DiaCode)
                    .HasColumnName("Dia_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaName)
                    .HasColumnName("Dia_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BDoctor>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("B_Doctor");

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.AterNo)
                    .HasColumnName("Ater_No")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BeeperNo)
                    .HasColumnName("Beeper_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompRp).HasColumnName("Comp_Rp");

                entity.Property(e => e.DocAddress)
                    .HasColumnName("Doc_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocCode)
                    .HasColumnName("Doc_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocDescription)
                    .HasColumnName("Doc_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocEmail)
                    .HasColumnName("Doc_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocFax)
                    .HasColumnName("Doc_Fax")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocMobileNo)
                    .HasColumnName("Doc_MobileNo")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocSex)
                    .HasColumnName("Doc_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocSsn)
                    .HasColumnName("Doc_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IniRepSet)
                    .HasColumnName("Ini_Rep_Set")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicenceNo)
                    .HasColumnName("Licence_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaIdNo)
                    .HasColumnName("MedicaId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareIdNo)
                    .HasColumnName("MedicareId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModemNo)
                    .HasColumnName("Modem_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nipnumber)
                    .HasColumnName("NIPNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemPrinterNo)
                    .HasColumnName("Rem_Printer_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RemotePrinter).HasColumnName("Remote_Printer");

                entity.Property(e => e.RouteNo)
                    .HasColumnName("Route_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalId)
                    .HasColumnName("Sal_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpOption)
                    .HasColumnName("Sp_Option")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest)
                    .HasColumnName("Special_Test")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StName)
                    .HasColumnName("St_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpinNo)
                    .HasColumnName("UPIN_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .HasColumnName("Zip_Id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BillOnlyTest>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.Property(e => e.TestId).HasColumnName("Test_Id");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.TestCode).HasColumnName("Test_Code");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BInsurance>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.ToTable("B_Insurance");

                entity.Property(e => e.InsId)
                    .HasColumnName("Ins_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Emc)
                    .HasColumnName("EMC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Emc1)
                    .HasColumnName("EMC1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ForceHoldNdr).HasColumnName("Force_Hold_NDR");

                entity.Property(e => e.FormType).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsAddress)
                    .HasColumnName("Ins_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode)
                    .HasColumnName("Ins_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsContactPerson)
                    .HasColumnName("Ins_ContactPerson")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsEmail)
                    .HasColumnName("Ins_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsFax)
                    .HasColumnName("Ins_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsName)
                    .HasColumnName("Ins_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsPhone)
                    .HasColumnName("Ins_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("Other_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayorOrgId)
                    .HasColumnName("Payor_OrgId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceIndex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReAddress).HasColumnName("Re_Address");

                entity.Property(e => e.ReDiag).HasColumnName("Re_Diag");

                entity.Property(e => e.ReDob).HasColumnName("Re_DOB");

                entity.Property(e => e.ReDocLic).HasColumnName("Re_Doc_LIC");

                entity.Property(e => e.ReDocMcd).HasColumnName("Re_Doc_MCD");

                entity.Property(e => e.ReDocMcr).HasColumnName("Re_Doc_MCR");

                entity.Property(e => e.ReDocUpin).HasColumnName("Re_Doc_UPIN");

                entity.Property(e => e.ReDosCollege)
                    .HasColumnName("Re_DOS_College")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReFname).HasColumnName("Re_FName");

                entity.Property(e => e.ReGroup).HasColumnName("Re_Group");

                entity.Property(e => e.ReGroupLen)
                    .HasColumnName("Re_Group_Len")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReInsId).HasColumnName("Re_InsID");

                entity.Property(e => e.ReInsIdLen)
                    .HasColumnName("Re_InsID_len")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReLname).HasColumnName("Re_LName");

                entity.Property(e => e.RePatSignText)
                    .HasColumnName("Re_Pat_SignText")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReSex).HasColumnName("Re_Sex");

                entity.Property(e => e.RelatDcode).HasColumnName("Relat_DCode");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("Submitter_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tos)
                    .HasColumnName("TOS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ucf)
                    .HasColumnName("UCF")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ucf1)
                    .HasColumnName("UCF1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .HasColumnName("Zip_Id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<BodyParts>(entity =>
            {
                entity.HasKey(e => e.BodyId);

                entity.Property(e => e.BodyId).HasColumnName("Body_Id");

                entity.Property(e => e.BodyCode)
                    .HasColumnName("Body_Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BodyImage)
                    .HasColumnName("Body_Image")
                    .HasColumnType("image");

                entity.Property(e => e.BodyName)
                    .HasColumnName("Body_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpId).HasColumnName("SP_ID");
            });

            modelBuilder.Entity<BPatient>(entity =>
            {
                entity.HasKey(e => e.PaId);

                entity.ToTable("B_Patient");

                entity.Property(e => e.PaId).HasColumnName("Pa_Id");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaAddress)
                    .HasColumnName("Pa_Address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaChartNo)
                    .HasColumnName("Pa_ChartNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaEmail)
                    .HasColumnName("Pa_Email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaFax)
                    .HasColumnName("Pa_Fax")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaPhone)
                    .HasColumnName("Pa_Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PaSex)
                    .HasColumnName("Pa_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaSsn)
                    .HasColumnName("Pa_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StName)
                    .HasColumnName("ST_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.CatCode).HasColumnName("Cat_Code");

                entity.Property(e => e.CatName)
                    .HasColumnName("Cat_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CatSymbol)
                    .HasColumnName("Cat_Symbol")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Celldyndata>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("CELLDYNDATA");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasError)
                    .HasColumnName("hasError")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferred).HasColumnName("isTransferred");

                entity.Property(e => e.Orders).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestResult)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CelldyndataTmp>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("CELLDYNDATA_tmp");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasError)
                    .HasColumnName("hasError")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferred).HasColumnName("isTransferred");

                entity.Property(e => e.Orders).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestResult)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Celldyninterface>(entity =>
            {
                entity.HasKey(e => e.ISeed);

                entity.ToTable("celldyninterface");

                entity.Property(e => e.ISeed)
                    .HasColumnName("iSeed")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Channel102Data)
                    .HasColumnName("channel_102_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel106Data)
                    .HasColumnName("channel_106_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel10Data)
                    .HasColumnName("channel_10_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel110Data)
                    .HasColumnName("channel_110_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel114Data)
                    .HasColumnName("channel_114_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel118Data)
                    .HasColumnName("channel_118_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel122Data)
                    .HasColumnName("channel_122_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel126Data)
                    .HasColumnName("channel_126_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel130Data)
                    .HasColumnName("channel_130_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel134Data)
                    .HasColumnName("channel_134_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel138Data)
                    .HasColumnName("channel_138_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel142Data)
                    .HasColumnName("channel_142_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel146Data)
                    .HasColumnName("channel_146_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel14Data)
                    .HasColumnName("channel_14_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel150Data)
                    .HasColumnName("channel_150_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel154Data)
                    .HasColumnName("channel_154_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel158Data)
                    .HasColumnName("channel_158_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel162Data)
                    .HasColumnName("channel_162_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel166Data)
                    .HasColumnName("channel_166_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel170Data)
                    .HasColumnName("channel_170_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel174Data)
                    .HasColumnName("channel_174_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel178Data)
                    .HasColumnName("channel_178_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel182Data)
                    .HasColumnName("channel_182_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel186Data)
                    .HasColumnName("channel_186_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel18Data)
                    .HasColumnName("channel_18_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel190Data)
                    .HasColumnName("channel_190_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel194Data)
                    .HasColumnName("channel_194_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel198Data)
                    .HasColumnName("channel_198_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel202Data)
                    .HasColumnName("channel_202_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel206Data)
                    .HasColumnName("channel_206_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel210Data)
                    .HasColumnName("channel_210_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel214Data)
                    .HasColumnName("channel_214_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel218Data)
                    .HasColumnName("channel_218_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel222Data)
                    .HasColumnName("channel_222_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel226Data)
                    .HasColumnName("channel_226_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel22Data)
                    .HasColumnName("channel_22_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel230Data)
                    .HasColumnName("channel_230_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel234Data)
                    .HasColumnName("channel_234_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel238Data)
                    .HasColumnName("channel_238_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel242Data)
                    .HasColumnName("channel_242_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel246Data)
                    .HasColumnName("channel_246_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel250Data)
                    .HasColumnName("channel_250_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel254Data)
                    .HasColumnName("channel_254_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel26Data)
                    .HasColumnName("channel_26_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel2Data)
                    .HasColumnName("channel_2_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel30Data)
                    .HasColumnName("channel_30_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel34Data)
                    .HasColumnName("channel_34_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel38Data)
                    .HasColumnName("channel_38_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel42Data)
                    .HasColumnName("channel_42_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel46Data)
                    .HasColumnName("channel_46_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel50Data)
                    .HasColumnName("channel_50_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel54Data)
                    .HasColumnName("channel_54_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel58Data)
                    .HasColumnName("channel_58_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel62Data)
                    .HasColumnName("channel_62_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel66Data)
                    .HasColumnName("channel_66_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel6Data)
                    .HasColumnName("channel_6_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel70Data)
                    .HasColumnName("channel_70_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel74Data)
                    .HasColumnName("channel_74_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel78Data)
                    .HasColumnName("channel_78_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel82Data)
                    .HasColumnName("channel_82_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel86Data)
                    .HasColumnName("channel_86_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel90Data)
                    .HasColumnName("channel_90_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel94Data)
                    .HasColumnName("channel_94_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Channel98Data)
                    .HasColumnName("channel_98_data")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Messagetype)
                    .HasColumnName("messagetype")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operator_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ScaleFactor)
                    .HasColumnName("scale_factor")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Sequenceno)
                    .HasColumnName("sequenceno")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.SpecimenDate)
                    .HasColumnName("specimen_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecimenId)
                    .HasColumnName("specimen_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenName)
                    .HasColumnName("specimen_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenTime)
                    .HasColumnName("specimen_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecimenType)
                    .HasColumnName("specimen_type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VetpackageOnOff)
                    .HasColumnName("vetpackage_on_off")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CentaurResults>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId).HasColumnName("pk_id");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orders).HasDefaultValueSql("((0))");

                entity.Property(e => e.Results)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CentaurResultsCopy>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("CentaurResults_copy");

                entity.Property(e => e.PkId).HasColumnName("pk_id");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orders).HasDefaultValueSql("((0))");

                entity.Property(e => e.Results)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.StId)
                    .HasName("IX_CityState");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StId).HasColumnName("St_Id");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StId)
                    .HasConstraintName("FK_City_State");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ClientAddress)
                    .HasColumnName("Client_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCode).HasColumnName("Client_Code");

                entity.Property(e => e.ClientContactPerson)
                    .HasColumnName("Client_ContactPerson")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientDescription)
                    .HasColumnName("Client_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientEmail)
                    .HasColumnName("Client_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientFax)
                    .HasColumnName("Client_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientFirstName)
                    .HasColumnName("Client_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLastName)
                    .HasColumnName("Client_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLogo)
                    .HasColumnName("Client_Logo")
                    .HasColumnType("image");

                entity.Property(e => e.ClientPhone)
                    .HasColumnName("Client_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientWeb)
                    .HasColumnName("Client_Web")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .HasColumnName("Zip_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientInvoices>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("Client_Invoices");

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BalanceDue).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.NewCharges).HasDefaultValueSql("((0))");

                entity.Property(e => e.Payments).HasDefaultValueSql("((0))");

                entity.Property(e => e.PreBalance).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.ClientInvoices)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK_Client_Invoices_B_Doctor");
            });

            modelBuilder.Entity<ClientTranMaster>(entity =>
            {
                entity.HasKey(e => e.CtmId);

                entity.ToTable("Client_Tran_Master");

                entity.Property(e => e.CtmId)
                    .HasColumnName("CTM_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApplyMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceTestId)
                    .HasColumnName("Invoice_Test_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Payment).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecDate).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.ClientTranMaster)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Tran_Master_Batch_Master");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.ClientTranMaster)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK_Client_Tran_Master_Client_Invoices");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.ClientTranMaster)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Tran_Master_B_Doctor");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.ClientTranMaster)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Client_Tran_Master_TransactionType");
            });

            modelBuilder.Entity<ClinicalResult>(entity =>
            {
                entity.HasKey(e => e.CrId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Clinical_Result");

                entity.HasIndex(e => e.PreAccNo)
                    .HasName("IX_Clinical_Result_4");

                entity.HasIndex(e => e.PrtId)
                    .HasName("IX_Clinical_Result_tmp");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_Clinical_Result_TestID_tmpx");

                entity.HasIndex(e => new { e.PreAccNo, e.TestId })
                    .HasName("IX_Clinical_Result_5");

                entity.HasIndex(e => new { e.PreId, e.TestId })
                    .HasName("IX_Clinical_Result_tmp_PreIDs")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.PrtId, e.TestId })
                    .HasName("IX_Clinical_Result_3_tmp");

                entity.Property(e => e.CrId).HasColumnName("CR_Id");

                entity.Property(e => e.Assayvalue)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommentIds)
                    .HasColumnName("CommentIDs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.FaxDate).HasColumnType("datetime");

                entity.Property(e => e.HighRange)
                    .HasColumnName("High_Range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7date)
                    .HasColumnName("HL7Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsHl7).HasColumnName("IsHL7");

                entity.Property(e => e.Isorder).HasColumnName("ISOrder");

                entity.Property(e => e.Lab)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lab2)
                    .HasColumnName("lab2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabPerformed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.LowRange)
                    .HasColumnName("Low_Range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NormalRange)
                    .HasColumnName("Normal_Range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderby).HasColumnName("orderby");

                entity.Property(e => e.PreAccDate)
                    .HasColumnName("Pre_AccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreAccNo).HasColumnName("Pre_AccNo");

                entity.Property(e => e.PreId).HasColumnName("Pre_ID");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.PrtIds)
                    .HasColumnName("PRT_IDs")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("Report_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultDate)
                    .HasColumnName("Result_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResultTestCode)
                    .HasColumnName("ResultTest_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultTestName)
                    .HasColumnName("ResultTest_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Resultunit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.TestPrintDate).HasColumnType("datetime");

                entity.Property(e => e.TestResult)
                    .HasColumnName("Test_Result")
                    .IsUnicode(false);

                entity.Property(e => e.TestResultTodelelete)
                    .HasColumnName("test_result_todelelete")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestStatus)
                    .HasColumnName("Test_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Verified).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ClinicalResultComm>(entity =>
            {
                entity.HasKey(e => e.CrcId);

                entity.ToTable("Clinical_Result_Comm");

                entity.HasIndex(e => e.ComId)
                    .HasName("IX_Clinical_Result_ComID");

                entity.HasIndex(e => e.CrId)
                    .HasName("IX_Clinical_Result_CRID");

                entity.HasIndex(e => new { e.CrId, e.ComId })
                    .HasName("IX_Clinical_Result_Comm");

                entity.Property(e => e.CrcId).HasColumnName("CRC_Id");

                entity.Property(e => e.ComDescription)
                    .HasColumnName("Com_Description")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("Com_Id");

                entity.Property(e => e.CrId).HasColumnName("CR_Id");

                entity.HasOne(d => d.Com)
                    .WithMany(p => p.ClinicalResultComm)
                    .HasForeignKey(d => d.ComId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clinical_Result_Comm_Comments");

                entity.HasOne(d => d.Cr)
                    .WithMany(p => p.ClinicalResultComm)
                    .HasForeignKey(d => d.CrId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clinical_Result_Comm_Clinical_Result");
            });

            modelBuilder.Entity<ClinicalResultUnspecfied>(entity =>
            {
                entity.HasKey(e => e.CrId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Clinical_Result_Unspecfied");

                entity.Property(e => e.CrId).HasColumnName("CR_Id");

                entity.Property(e => e.CommentIds)
                    .HasColumnName("CommentIDs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.HighRange)
                    .HasColumnName("High_Range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lab)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lab2)
                    .HasColumnName("lab2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabPerformed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.LowRange)
                    .HasColumnName("Low_Range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NormalRange)
                    .HasColumnName("Normal_Range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderby).HasColumnName("orderby");

                entity.Property(e => e.PreAccDate)
                    .HasColumnName("Pre_AccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreAccNo).HasColumnName("Pre_AccNo");

                entity.Property(e => e.PreId).HasColumnName("Pre_ID");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.PrtIds)
                    .HasColumnName("PRT_IDs")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("Report_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultDate)
                    .HasColumnName("Result_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResultTestCode)
                    .HasColumnName("ResultTest_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResultTestName)
                    .HasColumnName("ResultTest_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResultUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.TestResult)
                    .HasColumnName("Test_Result")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestResultTodelelete)
                    .HasColumnName("test_result_todelelete")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestStatus)
                    .HasColumnName("Test_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Verified).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ClinicalTest>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("Clinical_Test");

                entity.HasIndex(e => e.ClId)
                    .HasName("IX_Clinical_TestRefLab");

                entity.HasIndex(e => e.TestCode)
                    .HasName("IX_Clinical_TestCode");

                entity.HasIndex(e => new { e.TestCode, e.TestId })
                    .HasName("IX_ClinicalTest_Code_ID");

                entity.HasIndex(e => new { e.TestId, e.ClId })
                    .HasName("IX_Clinical_Test");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.AdditionalInfoReq).HasDefaultValueSql("((0))");

                entity.Property(e => e.AgeRange).HasColumnName("Age_Range");

                entity.Property(e => e.AutoTest1)
                    .HasColumnName("Auto_Test1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AutoTest2)
                    .HasColumnName("Auto_Test2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CalFormulaActive).HasColumnName("Cal_Formula_Active");

                entity.Property(e => e.CalFormulaFrom)
                    .HasColumnName("Cal_Formula_From")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalFormulaTo)
                    .HasColumnName("Cal_Formula_To")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalculationFormula)
                    .HasColumnName("Calculation_Formula")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRange).HasColumnName("Check_Range");

                entity.Property(e => e.ClId)
                    .HasColumnName("CL_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Commissionable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cond1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cond2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Days).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DefaultVal)
                    .HasColumnName("Default_Val")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaCheckValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExtRange).HasColumnName("Ext_Range");

                entity.Property(e => e.ExtRangeDesc)
                    .HasColumnName("Ext_Range_Desc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtRangeDescTmp)
                    .HasColumnName("Ext_Range_Desc_Tmp")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayHigh)
                    .HasColumnName("F_Assay_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayLow)
                    .HasColumnName("F_Assay_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayNormal)
                    .HasColumnName("F_Assay_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCHigh)
                    .HasColumnName("F_C_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCLow)
                    .HasColumnName("F_C_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCNormal)
                    .HasColumnName("F_C_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FHigh)
                    .HasColumnName("F_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FLow)
                    .HasColumnName("F_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNormal)
                    .HasColumnName("F_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsGrouped)
                    .HasColumnName("isGrouped")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoincCode)
                    .HasColumnName("Loinc_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayHigh)
                    .HasColumnName("M_Assay_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayLow)
                    .HasColumnName("M_Assay_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayNormal)
                    .HasColumnName("M_Assay_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCHigh)
                    .HasColumnName("M_C_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCLow)
                    .HasColumnName("M_C_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCNormal)
                    .HasColumnName("M_C_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MHigh)
                    .HasColumnName("M_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MLow)
                    .HasColumnName("M_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MNormal)
                    .HasColumnName("M_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PrintRange).HasColumnName("Print_Range");

                entity.Property(e => e.ROCode)
                    .HasColumnName("R_O_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReflexTestResultValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResFormat)
                    .HasColumnName("Res_Format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue1)
                    .HasColumnName("Result_Value1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue2)
                    .HasColumnName("Result_Value2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultVerificationTypeId).HasColumnName("ResultVerificationTypeID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_Name")
                    .IsUnicode(false);

                entity.Property(e => e.TestShortName)
                    .HasColumnName("TestShort_Name")
                    .IsUnicode(false);

                entity.Property(e => e.TestTypeName)
                    .HasColumnName("testTypeName")
                    .HasMaxLength(30);

                entity.Property(e => e.Tube)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ResultVerificationType)
                    .WithMany(p => p.ClinicalTest)
                    .HasForeignKey(d => d.ResultVerificationTypeId)
                    .HasConstraintName("FK_ResultVerificationType");
            });

            modelBuilder.Entity<ClinicalTestAutoVerificationTypes>(entity =>
            {
                entity.HasKey(e => e.ResultVerificationTypeId);

                entity.Property(e => e.ResultVerificationTypeId).HasColumnName("ResultVerificationTypeID");

                entity.Property(e => e.VerificationType)
                    .HasColumnName("Verification_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClinicalTestBackup>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("Clinical_Test_Backup");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.AgeRange).HasColumnName("Age_Range");

                entity.Property(e => e.AutoTest1)
                    .HasColumnName("Auto_Test1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AutoTest2)
                    .HasColumnName("Auto_Test2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CalculationFormula)
                    .HasColumnName("Calculation_Formula")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRange).HasColumnName("Check_Range");

                entity.Property(e => e.ClId)
                    .HasColumnName("CL_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cond1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cond2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultVal)
                    .HasColumnName("Default_Val")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaCheckValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExtRange).HasColumnName("Ext_Range");

                entity.Property(e => e.ExtRangeDesc)
                    .HasColumnName("Ext_Range_Desc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtRangeDescTmp)
                    .HasColumnName("Ext_Range_Desc_Tmp")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayHigh)
                    .HasColumnName("F_Assay_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayLow)
                    .HasColumnName("F_Assay_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayNormal)
                    .HasColumnName("F_Assay_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCHigh)
                    .HasColumnName("F_C_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCLow)
                    .HasColumnName("F_C_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCNormal)
                    .HasColumnName("F_C_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FHigh)
                    .HasColumnName("F_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FLow)
                    .HasColumnName("F_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNormal)
                    .HasColumnName("F_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayHigh)
                    .HasColumnName("M_Assay_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayLow)
                    .HasColumnName("M_Assay_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayNormal)
                    .HasColumnName("M_Assay_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCHigh)
                    .HasColumnName("M_C_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCLow)
                    .HasColumnName("M_C_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCNormal)
                    .HasColumnName("M_C_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MHigh)
                    .HasColumnName("M_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MLow)
                    .HasColumnName("M_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MNormal)
                    .HasColumnName("M_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintRange).HasColumnName("Print_Range");

                entity.Property(e => e.ReflexTestResultValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResFormat)
                    .HasColumnName("Res_Format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue1)
                    .HasColumnName("Result_Value1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue2)
                    .HasColumnName("Result_Value2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultVerificationTypeId).HasColumnName("ResultVerificationTypeID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_Name")
                    .IsUnicode(false);

                entity.Property(e => e.TestShortName)
                    .HasColumnName("TestShort_Name")
                    .IsUnicode(false);

                entity.Property(e => e.Tube)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClinicalTestBackupBackup>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("Clinical_Test_Backup_Backup");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.AdditionalInfoReq).HasDefaultValueSql("((0))");

                entity.Property(e => e.AgeRange).HasColumnName("Age_Range");

                entity.Property(e => e.AutoTest1)
                    .HasColumnName("Auto_Test1")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AutoTest2)
                    .HasColumnName("Auto_Test2")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CalculationFormula)
                    .HasColumnName("Calculation_Formula")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRange).HasColumnName("Check_Range");

                entity.Property(e => e.ClId)
                    .HasColumnName("CL_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Commissionable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cond1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cond2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultVal)
                    .HasColumnName("Default_Val")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaCheckValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExtRange).HasColumnName("Ext_Range");

                entity.Property(e => e.ExtRangeDesc)
                    .HasColumnName("Ext_Range_Desc")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtRangeDescTmp)
                    .HasColumnName("Ext_Range_Desc_Tmp")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayHigh)
                    .HasColumnName("F_Assay_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayLow)
                    .HasColumnName("F_Assay_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAssayNormal)
                    .HasColumnName("F_Assay_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCHigh)
                    .HasColumnName("F_C_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCLow)
                    .HasColumnName("F_C_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FCNormal)
                    .HasColumnName("F_C_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FHigh)
                    .HasColumnName("F_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FLow)
                    .HasColumnName("F_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNormal)
                    .HasColumnName("F_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayHigh)
                    .HasColumnName("M_Assay_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayLow)
                    .HasColumnName("M_Assay_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAssayNormal)
                    .HasColumnName("M_Assay_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCHigh)
                    .HasColumnName("M_C_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCLow)
                    .HasColumnName("M_C_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCNormal)
                    .HasColumnName("M_C_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MHigh)
                    .HasColumnName("M_High")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MLow)
                    .HasColumnName("M_Low")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MNormal)
                    .HasColumnName("M_Normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintRange).HasColumnName("Print_Range");

                entity.Property(e => e.ReflexTestResultValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResFormat)
                    .HasColumnName("Res_Format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue1)
                    .HasColumnName("Result_Value1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue2)
                    .HasColumnName("Result_Value2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultVerificationTypeId).HasColumnName("ResultVerificationTypeID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_Name")
                    .IsUnicode(false);

                entity.Property(e => e.TestShortName)
                    .HasColumnName("TestShort_Name")
                    .IsUnicode(false);

                entity.Property(e => e.Tube)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClinicalTestRefLabMapping>(entity =>
            {
                entity.HasKey(e => e.TestRefLabId);

                entity.Property(e => e.TestRefLabId).HasColumnName("TestRefLabID");

                entity.Property(e => e.ClId).HasColumnName("CL_Id");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.HasOne(d => d.Cl)
                    .WithMany(p => p.ClinicalTestRefLabMapping)
                    .HasForeignKey(d => d.ClId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClinicalTestRefLabMapping_Ref_Clinic_Lab");

                entity.HasOne(d => d.Ins)
                    .WithMany(p => p.ClinicalTestRefLabMapping)
                    .HasForeignKey(d => d.InsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClinicalTestRefLabMapping_Insurance");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.ClinicalTestRefLabMapping)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClinicalTestRefLabMapping_Clinical_Test");
            });

            modelBuilder.Entity<Cobase411results>(entity =>
            {
                entity.ToTable("cobase411results");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ordercode)
                    .HasColumnName("ordercode")
                    .IsUnicode(false);

                entity.Property(e => e.PreDilutionType)
                    .HasColumnName("preDilutionType")
                    .IsUnicode(false);

                entity.Property(e => e.Result).IsUnicode(false);

                entity.Property(e => e.ResultDate)
                    .HasColumnName("RESULT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestNo)
                    .HasColumnName("testNo")
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.ColId);

                entity.Property(e => e.ColId)
                    .HasColumnName("Col_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ColorName)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.HasIndex(e => e.CtId)
                    .HasName("IX_Comments_CTID");

                entity.HasIndex(e => new { e.ComId, e.CtId })
                    .HasName("IX_Comments");

                entity.Property(e => e.ComId).HasColumnName("Com_Id");

                entity.Property(e => e.ComCode).HasColumnName("Com_Code");

                entity.Property(e => e.ComDescription)
                    .HasColumnName("Com_Description")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CtId).HasColumnName("CT_Id");

                entity.Property(e => e.RichTextFormat).IsUnicode(false);

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CtId)
                    .HasConstraintName("FK_Comments_CommentType");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.HasKey(e => e.CtId);

                entity.Property(e => e.CtId).HasColumnName("CT_Id");

                entity.Property(e => e.CtCode)
                    .HasColumnName("CT_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtDescription)
                    .HasColumnName("CT_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CtName)
                    .HasColumnName("CT_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyInformation>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.Property(e => e.AbmOnFileMod)
                    .HasColumnName("ABM_On_File_Mod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillPen).HasColumnName("Bill_Pen");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ComAddress)
                    .HasColumnName("Com_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ComClia)
                    .HasColumnName("Com_Clia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComEmpId)
                    .HasColumnName("Com_EmpId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComFax)
                    .HasColumnName("Com_Fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComName)
                    .HasColumnName("Com_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComPhone)
                    .HasColumnName("Com_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComSubmitterId)
                    .HasColumnName("Com_SubmitterID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDevicePin)
                    .HasColumnName("ElectronicDevicePIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityIdnumber)
                    .HasColumnName("FacilityIDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityNetworkIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaidNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoAbmMod)
                    .HasColumnName("No_ABM_Mod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npinumber)
                    .HasColumnName("NPINumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PharmacyProcessorNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderPlanNetwrok)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpUnHold).HasColumnName("Sp_UnHold");

                entity.Property(e => e.Upinnumber)
                    .HasColumnName("UPINNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");
            });

            modelBuilder.Entity<CompanyProviderId>(entity =>
            {
                entity.HasKey(e => e.CompanyPkproviderId);

                entity.ToTable("CompanyProviderID");

                entity.Property(e => e.CompanyPkproviderId).HasColumnName("CompanyPKProviderID");

                entity.Property(e => e.EligibilityInsuranceId).HasColumnName("EligibilityInsuranceID");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerId)
                    .HasColumnName("PayerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("ProviderID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompletedReport>(entity =>
            {
                entity.ToTable("Completed_Report");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PreAccno)
                    .HasColumnName("Pre_accno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cptcodes>(entity =>
            {
                entity.HasKey(e => e.CptcodeId);

                entity.ToTable("CPTCodes");

                entity.Property(e => e.CptcodeId).HasColumnName("CPTCodeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Cptcode)
                    .HasColumnName("CPTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcode2)
                    .HasColumnName("CPTCode2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcode3)
                    .HasColumnName("CPTCode3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cptdescription)
                    .HasColumnName("CPTDescription")
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price1).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price10).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price11).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price12).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price13).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price14).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price15).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price2).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price3).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price4).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price5).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price6).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price7).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price8).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Price9).HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<CytoCatagory>(entity =>
            {
                entity.HasKey(e => e.CcId);

                entity.ToTable("Cyto_Catagory");

                entity.Property(e => e.CcId).HasColumnName("CC_ID");

                entity.Property(e => e.CatId).HasColumnName("Cat_ID");

                entity.Property(e => e.CtId).HasColumnName("CT_ID");
            });

            modelBuilder.Entity<CytologyTest>(entity =>
            {
                entity.HasKey(e => e.CtId);

                entity.ToTable("Cytology_Test");

                entity.Property(e => e.CtId).HasColumnName("CT_ID");

                entity.Property(e => e.ClId).HasColumnName("CL_ID");

                entity.Property(e => e.Source)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestNo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cl)
                    .WithMany(p => p.CytologyTest)
                    .HasForeignKey(d => d.ClId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Cytology_Test_Ref_Clinic_Lab");
            });

            modelBuilder.Entity<CytoParameters>(entity =>
            {
                entity.HasKey(e => e.CpId);

                entity.ToTable("Cyto_Parameters");

                entity.Property(e => e.CpId)
                    .HasColumnName("CP_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BCptcode)
                    .HasColumnName("B_CPTCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BCunits)
                    .HasColumnName("B_CUnits")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BMcdcode)
                    .HasColumnName("B_MCDCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BMunits)
                    .HasColumnName("B_MUnits")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BPrice)
                    .HasColumnName("B_Price")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ICptcode)
                    .HasColumnName("I_CPTCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ICunits)
                    .HasColumnName("I_CUnits")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IMcdcode)
                    .HasColumnName("I_MCDCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IMunits)
                    .HasColumnName("I_MUnits")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IPrice)
                    .HasColumnName("I_Price")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<CytoSpeciality>(entity =>
            {
                entity.HasKey(e => e.CsId);

                entity.ToTable("Cyto_Speciality");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CtId).HasColumnName("CT_ID");

                entity.Property(e => e.SpId).HasColumnName("SP_ID");
            });

            modelBuilder.Entity<DeletedTest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PreId).HasColumnName("Pre_ID");

                entity.Property(e => e.PrtId).HasColumnName("PRT_ID");

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("Test_id");
            });

            modelBuilder.Entity<Deletelog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Computername)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deletedby)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Preaccno)
                    .HasColumnName("preaccno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Preid)
                    .HasColumnName("preid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prtid)
                    .HasColumnName("prtid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasKey(e => e.DiaId);

                entity.Property(e => e.DiaId).HasColumnName("Dia_Id");

                entity.Property(e => e.DiaCode)
                    .IsRequired()
                    .HasColumnName("Dia_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaName)
                    .HasColumnName("Dia_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diagnosis10>(entity =>
            {
                entity.HasKey(e => e.DiaId);

                entity.ToTable("Diagnosis_10");

                entity.Property(e => e.DiaId).HasColumnName("Dia_ID");

                entity.Property(e => e.DiaCode)
                    .HasColumnName("Dia_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaName)
                    .HasColumnName("Dia_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diagnosis10new>(entity =>
            {
                entity.HasKey(e => e.DiaId);

                entity.ToTable("Diagnosis_10new");

                entity.Property(e => e.DiaId).HasColumnName("Dia_ID");

                entity.Property(e => e.DiaCode)
                    .HasColumnName("Dia_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaName)
                    .HasColumnName("Dia_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocReview>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Doc_Review");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatId).HasColumnName("Cat_ID");

                entity.Property(e => e.ClinicalDisgnosis)
                    .HasColumnName("Clinical_Disgnosis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dre)
                    .HasColumnName("DRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinalDate)
                    .HasColumnName("Final_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FollowUp)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gleason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GrId).HasColumnName("GR_ID");

                entity.Property(e => e.History)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Image1).HasColumnType("image");

                entity.Property(e => e.NotesDescription)
                    .HasColumnName("Notes_Description")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PcId).HasColumnName("PC_ID");

                entity.Property(e => e.Pct)
                    .HasColumnName("PCT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreDate)
                    .HasColumnName("Pre_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Preminilary)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psa)
                    .HasColumnName("PSA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewedBy)
                    .HasColumnName("reviewedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScanedImage).HasColumnType("image");

                entity.Property(e => e.Site)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocReviewMicroCodes>(entity =>
            {
                entity.HasKey(e => e.Rmid);

                entity.ToTable("Doc_Review_MicroCodes");

                entity.Property(e => e.Rmid).HasColumnName("RMID");

                entity.Property(e => e.Cptcode)
                    .HasColumnName("CPTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IcdCode)
                    .HasColumnName("ICD_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicroCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MicroDescription)
                    .HasColumnName("Micro_Description")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<Edicomments>(entity =>
            {
                entity.HasKey(e => e.EdicommentId);

                entity.ToTable("EDIComments");

                entity.Property(e => e.EdicommentId).HasColumnName("EDICommentID");

                entity.Property(e => e.EdiCommentCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdiCommentDesc)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Edicontrols>(entity =>
            {
                entity.HasKey(e => e.EdicontrolIds);

                entity.ToTable("EDIControls");

                entity.Property(e => e.EdicontrolIds).HasColumnName("EDIControlIds");

                entity.Property(e => e.ControlNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode)
                    .HasColumnName("Ins_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Edisubmission>(entity =>
            {
                entity.HasKey(e => e.EdiId);

                entity.ToTable("EDISubmission");

                entity.Property(e => e.EdiId).HasColumnName("EDI_ID");

                entity.Property(e => e.ControlNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmdeonFileReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsCode)
                    .HasColumnName("Ins_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfClaims).HasColumnName("No_Of_Claims");

                entity.Property(e => e.NoOfPatients).HasColumnName("No_Of_Patients");

                entity.Property(e => e.SubmissionDate)
                    .HasColumnName("Submission_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmissionTime)
                    .HasColumnName("Submission_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");
            });

            modelBuilder.Entity<EdisubmissionDetail>(entity =>
            {
                entity.HasKey(e => e.EdiDetailId);

                entity.ToTable("EDISubmission_Detail");

                entity.Property(e => e.EdiDetailId).HasColumnName("EDI_Detail_ID");

                entity.Property(e => e.AmountCharged).HasColumnName("Amount_Charged");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("Claim_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdiId).HasColumnName("EDI_ID");

                entity.Property(e => e.InsId)
                    .HasColumnName("Ins_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfService).HasColumnName("No_Of_Service");

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PricedCode)
                    .HasColumnName("Priced_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferringPhysician)
                    .HasColumnName("Referring_Physician")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDate)
                    .HasColumnName("Service_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElegibiltyError>(entity =>
            {
                entity.HasKey(e => e.ElgibilityId);

                entity.Property(e => e.ElgibilityId).HasColumnName("ElgibilityID");

                entity.Property(e => e.Accno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("PreID");
            });

            modelBuilder.Entity<EligibilityInsurance>(entity =>
            {
                entity.Property(e => e.EligibilityInsuranceId).HasColumnName("EligibilityInsuranceID");

                entity.Property(e => e.EligibilityRule)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Extra1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode)
                    .HasColumnName("Ins_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.PayerId)
                    .HasColumnName("PayerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EligibilityMapping>(entity =>
            {
                entity.Property(e => e.EligibilityMappingId).HasColumnName("EligibilityMappingID");

                entity.Property(e => e.EligibilityInsuranceId).HasColumnName("EligibilityInsuranceID");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");
            });

            modelBuilder.Entity<Emdeon>(entity =>
            {
                entity.Property(e => e.EmdeonId).HasColumnName("EmdeonID");

                entity.Property(e => e.EmdeonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmdeonPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmdeonUserId)
                    .HasColumnName("EmdeonUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmdeonReports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EmdeonRefernceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FileDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PickedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaxCoverPageInfo>(entity =>
            {
                entity.HasKey(e => e.FaxCoverPageId);

                entity.Property(e => e.FaxCoverPageId).HasColumnName("FaxCoverPageID");

                entity.Property(e => e.CofidentialMessage)
                    .HasMaxLength(3500)
                    .IsUnicode(false);

                entity.Property(e => e.FromMessage)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ToMessage)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaxLog>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("Fax_Log");

                entity.Property(e => e.PkId)
                    .HasColumnName("Pk_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasColumnName("Acc_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoFaxCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocCode)
                    .HasColumnName("Doc_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasColumnName("Doc_Name")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FaxJobId).HasColumnName("Fax_JobID");

                entity.Property(e => e.FaxNumber)
                    .HasColumnName("Fax_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxPages).HasColumnName("Fax_Pages");

                entity.Property(e => e.FaxSize).HasColumnName("Fax_Size");

                entity.Property(e => e.FaxStatus)
                    .HasColumnName("Fax_Status")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FaxTime)
                    .HasColumnName("Fax_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName).HasColumnName("File_Name");

                entity.Property(e => e.IsAutoFax).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FaxReportCriteria>(entity =>
            {
                entity.Property(e => e.FaxReportCriteriaId).HasColumnName("FaxReportCriteriaID");

                entity.Property(e => e.FaxReportCriteria1)
                    .IsRequired()
                    .HasColumnName("FaxReportCriteria")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FaxReportError)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FaxReprotCreationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FaxReportCriteriaAccessions>(entity =>
            {
                entity.HasKey(e => e.FaxReportCriteriaAccessionId);

                entity.Property(e => e.FaxReportCriteriaAccessionId).HasColumnName("FaxReportCriteriaAccessionID");

                entity.Property(e => e.AccesionNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxReportCriteriaId).HasColumnName("FaxReportCriteriaID");

                entity.Property(e => e.Message)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.FaxReportCriteria)
                    .WithMany(p => p.FaxReportCriteriaAccessions)
                    .HasForeignKey(d => d.FaxReportCriteriaId)
                    .HasConstraintName("FK_FaxReportCriteriaAccessions_FaxReportCriteria");
            });

            modelBuilder.Entity<Fix>(entity =>
            {
                entity.Property(e => e.FixId)
                    .HasColumnName("Fix_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FixName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormDescription>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("Form_Description");

                entity.Property(e => e.FormId)
                    .HasColumnName("Form_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FormKeyword)
                    .HasColumnName("Form_keyword")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasColumnName("Form_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Frequency>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.Fcode)
                    .HasColumnName("FCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fdescription)
                    .HasColumnName("FDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ffrequency)
                    .HasColumnName("FFrequency")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ffri)
                    .HasColumnName("FFri")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fmon)
                    .HasColumnName("FMon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fnodays)
                    .HasColumnName("FNODays")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Fsat)
                    .HasColumnName("FSat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fsun)
                    .HasColumnName("FSun")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fthur)
                    .HasColumnName("FThur")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ftues)
                    .HasColumnName("FTues")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ftype)
                    .HasColumnName("FType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fwed)
                    .HasColumnName("FWed")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Grossing>(entity =>
            {
                entity.HasKey(e => e.GrossId);

                entity.Property(e => e.GrossId).HasColumnName("Gross_id");

                entity.Property(e => e.GrossCode)
                    .IsRequired()
                    .HasColumnName("Gross_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossDes)
                    .HasColumnName("Gross_Des")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrossResults>(entity =>
            {
                entity.HasKey(e => e.GrId);

                entity.ToTable("Gross_Results");

                entity.Property(e => e.GrId).HasColumnName("GR_ID");

                entity.Property(e => e.BiopsyComments)
                    .HasColumnName("Biopsy_Comments")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Bnumber)
                    .HasColumnName("BNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C1g)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cassetes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CytoType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fibrinogen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fixative)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImmuneComments)
                    .HasColumnName("Immune_Comments")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Measure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcId).HasColumnName("PC_ID");

                entity.Property(e => e.Pieces)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Propardin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shape)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecType)
                    .HasColumnName("Spec_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupDetail>(entity =>
            {
                entity.HasKey(e => e.GrDId);

                entity.ToTable("Group_Detail");

                entity.HasIndex(e => e.GrId)
                    .HasName("IX_Group_DetailGrID");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_Group_DetailTestID");

                entity.Property(e => e.GrDId).HasColumnName("GrD_Id");

                entity.Property(e => e.GrId).HasColumnName("Gr_Id");

                entity.Property(e => e.TestId).HasColumnName("Test_Id");

                entity.HasOne(d => d.Gr)
                    .WithMany(p => p.GroupDetail)
                    .HasForeignKey(d => d.GrId)
                    .HasConstraintName("FK_Group_Detail_Group_Test");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.GroupDetail)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_Group_Detail_Clinical_Test");
            });

            modelBuilder.Entity<GroupRights>(entity =>
            {
                entity.Property(e => e.GroupRightsId).HasColumnName("GroupRightsID");

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.GroupId).HasColumnName("Group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupRights)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_rights_Groups_Right_table");
            });

            modelBuilder.Entity<GroupTest>(entity =>
            {
                entity.HasKey(e => e.GrId);

                entity.ToTable("Group_Test");

                entity.Property(e => e.GrId).HasColumnName("Gr_ID");

                entity.Property(e => e.Commissionable).HasDefaultValueSql("((0))");

                entity.Property(e => e.GrCode)
                    .HasColumnName("Gr_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GrDescription)
                    .HasColumnName("Gr_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GrName)
                    .HasColumnName("Gr_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tube)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupTestDetail>(entity =>
            {
                entity.HasKey(e => e.GroupTestId);

                entity.Property(e => e.GroupTestId).HasColumnName("GroupTestID");

                entity.Property(e => e.GdPreAccno)
                    .HasColumnName("GdPre_Accno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GdPreId).HasColumnName("GdPre_ID");

                entity.Property(e => e.GdPrtId).HasColumnName("GdPRT_ID");

                entity.Property(e => e.GdStype)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GdTestCode)
                    .HasColumnName("GdTest_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GdTestId).HasColumnName("GdTest_ID");

                entity.Property(e => e.GdTestName)
                    .HasColumnName("GdTest_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GdType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GroupTestRefLabMapping>(entity =>
            {
                entity.HasKey(e => e.GroupRefLabId);

                entity.Property(e => e.GroupRefLabId).HasColumnName("GroupRefLabID");

                entity.Property(e => e.ClId).HasColumnName("CL_Id");

                entity.Property(e => e.GrId).HasColumnName("Gr_ID");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");
            });

            modelBuilder.Entity<Hl7interface>(entity =>
            {
                entity.ToTable("HL7Interface");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InterfaceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hl7log>(entity =>
            {
                entity.ToTable("HL7Log");

                entity.Property(e => e.Hl7logId).HasColumnName("HL7LogID");

                entity.Property(e => e.AccessionNosInHl7)
                    .HasColumnName("AccessionNosInHL7")
                    .IsUnicode(false);

                entity.Property(e => e.DateHl7Generated).HasColumnType("datetime");

                entity.Property(e => e.Hl7filePath).HasColumnName("HL7FilePath");

                entity.Property(e => e.Hl7string)
                    .HasColumnName("HL7String")
                    .IsUnicode(false);

                entity.Property(e => e.PreAccNo).HasColumnName("PRe_AccNo");
            });

            modelBuilder.Entity<Hl7Zef>(entity =>
            {
                entity.HasKey(e => e.ZefId);

                entity.ToTable("HL7_Zef");

                entity.Property(e => e.ZefId).HasColumnName("ZefID");

                entity.Property(e => e.Pdf)
                    .HasColumnName("PDF")
                    .IsUnicode(false);

                entity.Property(e => e.PreAccno)
                    .HasColumnName("Pre_accno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportData).IsUnicode(false);

                entity.Property(e => e.TestId)
                    .HasColumnName("TestID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hl7Zps>(entity =>
            {
                entity.HasKey(e => e.Hzid);

                entity.ToTable("HL7_ZPS");

                entity.Property(e => e.Hzid).HasColumnName("HZId");

                entity.Property(e => e.DirName).HasMaxLength(200);

                entity.Property(e => e.LabAddress).HasMaxLength(200);

                entity.Property(e => e.LabCode).HasMaxLength(50);

                entity.Property(e => e.LabName).HasMaxLength(200);

                entity.Property(e => e.LabPhone).HasMaxLength(50);

                entity.Property(e => e.PreAccno)
                    .HasColumnName("Pre_accno")
                    .HasMaxLength(50);

                entity.Property(e => e.PreId).HasColumnName("Pre_id");

                entity.Property(e => e.SpecimenNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Indications>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.Property(e => e.Pkid)
                    .HasColumnName("pkid")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IndiName)
                    .HasColumnName("Indi_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfoSheet>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.Property(e => e.InfoId).HasColumnName("INFO_ID");

                entity.Property(e => e.InfoCode)
                    .HasColumnName("INFO_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InfoDesc)
                    .HasColumnName("INFO_DESC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InfoMemo)
                    .HasColumnName("INFO_MEMO")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<InhouseLabTestMapping>(entity =>
            {
                entity.HasKey(e => e.IhmapId);

                entity.ToTable("Inhouse_LabTestMapping");

                entity.Property(e => e.IhmapId).HasColumnName("IHMapID");

                entity.Property(e => e.ClCode)
                    .HasColumnName("CL_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MapTestCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestShortName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsSpecificBill>(entity =>
            {
                entity.HasKey(e => e.IbId);

                entity.ToTable("Ins_Specific_Bill");

                entity.Property(e => e.IbId).HasColumnName("IB_ID");

                entity.Property(e => e.Amount1)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Amount2)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Amount3)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CptCode1)
                    .HasColumnName("CPT_Code1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptCode2)
                    .HasColumnName("CPT_Code2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptCode3)
                    .HasColumnName("CPT_Code3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId)
                    .HasColumnName("Ins_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PlaceOfServ)
                    .HasColumnName("Place_Of_Serv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestId)
                    .HasColumnName("Test_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfServ)
                    .HasColumnName("Type_OF_Serv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Unit1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsTranMaster>(entity =>
            {
                entity.HasKey(e => e.ItmId);

                entity.ToTable("Ins_Tran_Master");

                entity.Property(e => e.ItmId)
                    .HasColumnName("ITM_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.InsId)
                    .HasColumnName("Ins_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceTestId)
                    .HasColumnName("Invoice_Test_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate).HasColumnType("datetime");

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.InsTranMaster)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ins_Tran_Master_Batch_Master");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.InsTranMaster)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK_Ins_Tran_Master_B_Doctor");

                entity.HasOne(d => d.Ins)
                    .WithMany(p => p.InsTranMaster)
                    .HasForeignKey(d => d.InsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ins_Tran_Master_B_Insurance");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.InsTranMaster)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ins_Tran_Master_TransactionType");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.Assign).HasDefaultValueSql("((0))");

                entity.Property(e => e.Commissionable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Emc)
                    .HasColumnName("EMC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Emc1)
                    .HasColumnName("EMC1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ForceHoldNdr).HasColumnName("Force_Hold_NDR");

                entity.Property(e => e.FormType)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsAddress)
                    .HasColumnName("Ins_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode)
                    .HasColumnName("Ins_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsContactPerson)
                    .HasColumnName("Ins_ContactPerson")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsEmail)
                    .HasColumnName("Ins_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsFax)
                    .HasColumnName("Ins_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsName)
                    .HasColumnName("Ins_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsPhone)
                    .HasColumnName("Ins_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("Other_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerId)
                    .HasColumnName("PayerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayorOrgId)
                    .HasColumnName("Payor_OrgId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceIndex)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReAddress)
                    .HasColumnName("Re_Address")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDiag)
                    .HasColumnName("Re_Diag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDob)
                    .HasColumnName("Re_DOB")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDocLic)
                    .HasColumnName("Re_Doc_LIC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDocMcd)
                    .HasColumnName("Re_Doc_MCD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDocMcr)
                    .HasColumnName("Re_Doc_MCR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDocUpin)
                    .HasColumnName("Re_Doc_UPIN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReDosCollege)
                    .HasColumnName("Re_DOS_College")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReFname)
                    .HasColumnName("Re_FName")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReGroup).HasColumnName("Re_Group");

                entity.Property(e => e.ReGroupLen)
                    .HasColumnName("Re_Group_Len")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReInsId)
                    .HasColumnName("Re_InsID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReInsIdLen)
                    .HasColumnName("Re_InsID_len")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReLname)
                    .HasColumnName("Re_LName")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RePatSignText)
                    .HasColumnName("Re_Pat_SignText")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReSex)
                    .HasColumnName("Re_Sex")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelatDcode).HasColumnName("Relat_DCode");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("Submitter_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tos)
                    .HasColumnName("TOS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ucf)
                    .HasColumnName("UCF")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ucf1)
                    .HasColumnName("UCF1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");

                entity.HasOne(d => d.Zip)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.ZipId)
                    .HasConstraintName("FK_Insurance_ZipCode");
            });

            modelBuilder.Entity<InsuranceProviderOrganization>(entity =>
            {
                entity.Property(e => e.InsuranceProviderOrganizationId).HasColumnName("InsuranceProviderOrganizationID");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EligibilityRule)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Emc)
                    .HasColumnName("EMC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Emc1)
                    .HasColumnName("EMC1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ForceHoldNdr).HasColumnName("Force_Hold_NDR");

                entity.Property(e => e.FormType).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdNo)
                    .HasColumnName("ID_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsAddress)
                    .HasColumnName("Ins_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InsContactPerson)
                    .HasColumnName("Ins_ContactPerson")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsEmail)
                    .HasColumnName("Ins_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsFax)
                    .HasColumnName("Ins_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsPhone)
                    .HasColumnName("Ins_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceProviderOrganization1)
                    .HasColumnName("InsuranceProviderOrganization")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceProviderOrganizationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("Other_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayorOrgId)
                    .HasColumnName("Payor_OrgId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceIndex).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReAddress).HasColumnName("Re_Address");

                entity.Property(e => e.ReDiag).HasColumnName("Re_Diag");

                entity.Property(e => e.ReDob).HasColumnName("Re_DOB");

                entity.Property(e => e.ReDocLic).HasColumnName("Re_Doc_LIC");

                entity.Property(e => e.ReDocMcd).HasColumnName("Re_Doc_MCD");

                entity.Property(e => e.ReDocMcr).HasColumnName("Re_Doc_MCR");

                entity.Property(e => e.ReDocUpin).HasColumnName("Re_Doc_UPIN");

                entity.Property(e => e.ReDosCollege)
                    .HasColumnName("Re_DOS_College")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReFname).HasColumnName("Re_FName");

                entity.Property(e => e.ReGroup).HasColumnName("Re_Group");

                entity.Property(e => e.ReGroupLen)
                    .HasColumnName("Re_Group_Len")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReInsId).HasColumnName("Re_InsID");

                entity.Property(e => e.ReInsIdLen)
                    .HasColumnName("Re_InsID_len")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReLname).HasColumnName("Re_LName");

                entity.Property(e => e.RePatSignText)
                    .HasColumnName("Re_Pat_SignText")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReSex).HasColumnName("Re_Sex");

                entity.Property(e => e.RelatDcode).HasColumnName("Relat_DCode");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("Submitter_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tos)
                    .HasColumnName("TOS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ucf)
                    .HasColumnName("UCF")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ucf1)
                    .HasColumnName("UCF1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");
            });

            modelBuilder.Entity<InsuranceRequestMain>(entity =>
            {
                entity.HasKey(e => e.EligibilityRequestMainId);

                entity.Property(e => e.EligibilityRequestMainId).HasColumnName("EligibilityRequestMainID");

                entity.Property(e => e.BeginingHeaderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EligibilityInsuranceId).HasColumnName("EligibilityInsuranceID");

                entity.Property(e => e.EmdeonUserId)
                    .HasColumnName("EmdeonUserID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmrproviderId).HasColumnName("EMRProviderID");

                entity.Property(e => e.ErrorDescription).HasColumnType("text");

                entity.Property(e => e.GroupControlNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceProviderOrganizationId).HasColumnName("InsuranceProviderOrganizationID");

                entity.Property(e => e.InterchangeControlNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InterchangeDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalMessage).IsUnicode(false);

                entity.Property(e => e.PatientDemographicsId).HasColumnName("PatientDemographicsID");

                entity.Property(e => e.PatientVisitDetailId).HasColumnName("PatientVisitDetailID");

                entity.Property(e => e.PocparticipantId)
                    .HasColumnName("POCParticipantID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedMessage).IsUnicode(false);

                entity.Property(e => e.ServerId).HasColumnName("ServerID");
            });

            modelBuilder.Entity<InsuranceRequestPhysician>(entity =>
            {
                entity.HasKey(e => e.EligibilityRequestPhysicianId);

                entity.Property(e => e.EligibilityRequestPhysicianId).HasColumnName("EligibilityRequestPhysicianID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDevicePin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityRequestMainId).HasColumnName("EligibilityRequestMainID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityIdnumber)
                    .HasColumnName("FacilityIDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityNetworkId)
                    .HasColumnName("FacilityNetworkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FederalTaxpayerId)
                    .HasColumnName("FederalTaxpayerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Hpi)
                    .HasColumnName("HPI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MedicaidProviderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareProviderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Npi)
                    .HasColumnName("NPI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalIdentificationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PharmacyProcessorNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriorIdentifierNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderPlanNetworkId)
                    .HasColumnName("ProviderPlanNetworkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProviderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateLicenseNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateLicenseNumberDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("SubmitterID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseDetail>(entity =>
            {
                entity.HasKey(e => e.EligibilityResponseDetailId);

                entity.Property(e => e.EligibilityResponseDetailId).HasColumnName("EligibilityResponseDetailID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EligibilityResponseMainId).HasColumnName("EligibilityResponseMainID");

                entity.Property(e => e.Entity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eq01)
                    .HasColumnName("EQ01")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Eq02)
                    .HasColumnName("EQ02")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorDescription).HasColumnType("text");

                entity.Property(e => e.IdentificationId)
                    .HasColumnName("IdentificationID")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PayerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PerName1)
                    .HasColumnName("PER_Name_1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerName2)
                    .HasColumnName("PER_Name_2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerName3)
                    .HasColumnName("PER_Name_3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber11)
                    .HasColumnName("PER_Number_1_1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber12)
                    .HasColumnName("PER_Number_1_2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber13)
                    .HasColumnName("PER_Number_1_3")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber18)
                    .HasColumnName("PER_Number_1_8")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber21)
                    .HasColumnName("PER_Number_2_1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber22)
                    .HasColumnName("PER_Number_2_2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber23)
                    .HasColumnName("PER_Number_2_3")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber28)
                    .HasColumnName("PER_Number_2_8")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber31)
                    .HasColumnName("PER_Number_3_1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber32)
                    .HasColumnName("PER_Number_3_2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber33)
                    .HasColumnName("PER_Number_3_3")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber38)
                    .HasColumnName("PER_Number_3_8")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType11)
                    .HasColumnName("PER_Number_Type_1_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType12)
                    .HasColumnName("PER_Number_Type_1_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType13)
                    .HasColumnName("PER_Number_Type_1_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType21)
                    .HasColumnName("PER_Number_Type_2_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType22)
                    .HasColumnName("PER_Number_Type_2_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType23)
                    .HasColumnName("PER_Number_Type_2_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType31)
                    .HasColumnName("PER_Number_Type_3_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType32)
                    .HasColumnName("PER_Number_Type_3_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType33)
                    .HasColumnName("PER_Number_Type_3_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceIdentification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSetControlNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseEbadditionalInfo>(entity =>
            {
                entity.HasKey(e => e.EligibilityEbadditionalId);

                entity.ToTable("InsuranceResponseEBAdditionalInfo");

                entity.Property(e => e.EligibilityEbadditionalId).HasColumnName("EligibilityEBAdditionalID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountrySubdivistionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberEbid).HasColumnName("EligibilityResponseSuscriberEBID");

                entity.Property(e => e.Entity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationCode)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PerName1)
                    .HasColumnName("PER_Name_1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerName2)
                    .HasColumnName("PER_Name_2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerName3)
                    .HasColumnName("PER_Name_3")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber11)
                    .HasColumnName("PER_Number_1_1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber12)
                    .HasColumnName("PER_Number_1_2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber13)
                    .HasColumnName("PER_Number_1_3")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber18)
                    .HasColumnName("PER_Number_1_8")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber21)
                    .HasColumnName("PER_Number_2_1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber22)
                    .HasColumnName("PER_Number_2_2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber23)
                    .HasColumnName("PER_Number_2_3")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber28)
                    .HasColumnName("PER_Number_2_8")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber31)
                    .HasColumnName("PER_Number_3_1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber32)
                    .HasColumnName("PER_Number_3_2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber33)
                    .HasColumnName("PER_Number_3_3")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumber38)
                    .HasColumnName("PER_Number_3_8")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType11)
                    .HasColumnName("PER_Number_Type_1_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType12)
                    .HasColumnName("PER_Number_Type_1_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType13)
                    .HasColumnName("PER_Number_Type_1_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType21)
                    .HasColumnName("PER_Number_Type_2_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType22)
                    .HasColumnName("PER_Number_Type_2_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType23)
                    .HasColumnName("PER_Number_Type_2_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType31)
                    .HasColumnName("PER_Number_Type_3_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType32)
                    .HasColumnName("PER_Number_Type_3_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerNumberType33)
                    .HasColumnName("PER_Number_Type_3_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderIdentification)
                    .HasColumnName("Provider_Identification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderOrganization)
                    .HasColumnName("Provider_Organization")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderReference)
                    .HasColumnName("Provider_Reference")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderSpeciality)
                    .HasColumnName("Provider_Speciality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderState)
                    .HasColumnName("Provider_State")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseEbdates>(entity =>
            {
                entity.HasKey(e => e.EligibilityEbidateId);

                entity.ToTable("InsuranceResponseEBDates");

                entity.Property(e => e.EligibilityEbidateId).HasColumnName("EligibilityEBIDateID");

                entity.Property(e => e.DateDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberEbid).HasColumnName("EligibilityResponseSuscriberEBID");

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsuranceResponseEbidentification>(entity =>
            {
                entity.HasKey(e => e.EligibilityEbidentificationId);

                entity.ToTable("InsuranceResponseEBIdentification");

                entity.Property(e => e.EligibilityEbidentificationId).HasColumnName("EligibilityEBIdentificationID");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberEbid).HasColumnName("EligibilityResponseSuscriberEBID");

                entity.Property(e => e.ReferenceIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceIdentificationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseEbmessages>(entity =>
            {
                entity.HasKey(e => e.EligibilityEbimessageId);

                entity.ToTable("InsuranceResponseEBMessages");

                entity.Property(e => e.EligibilityEbimessageId).HasColumnName("EligibilityEBIMessageID");

                entity.Property(e => e.EligibilityResponseSuscriberEbid).HasColumnName("EligibilityResponseSuscriberEBID");

                entity.Property(e => e.Message)
                    .HasMaxLength(264)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseEbprocedures>(entity =>
            {
                entity.HasKey(e => e.EligibilityEbprocedureId);

                entity.ToTable("InsuranceResponseEBProcedures");

                entity.Property(e => e.EligibilityEbprocedureId).HasColumnName("EligibilityEBProcedureID");

                entity.Property(e => e.DxPointer1)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DxPointer2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DxPointer3)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DxPointer4)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberEbid).HasColumnName("EligibilityResponseSuscriberEBID");

                entity.Property(e => e.ProcedureCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureDescription).HasMaxLength(80);

                entity.Property(e => e.ProcedureModifier1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureModifier2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureModifier3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureModifier4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductServiceId)
                    .HasColumnName("ProductServiceID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductServiceId2)
                    .HasColumnName("ProductServiceID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseMain>(entity =>
            {
                entity.HasKey(e => e.EligibilityResponseMainId);

                entity.Property(e => e.EligibilityResponseMainId).HasColumnName("EligibilityResponseMainID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EligibilityRequestMainId).HasColumnName("EligibilityRequestMainID");

                entity.Property(e => e.EmrappointmentId).HasColumnName("EMRAppointmentID");

                entity.Property(e => e.InterchangeDate).HasColumnType("datetime");

                entity.Property(e => e.InterchangeTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalMessage).IsUnicode(false);

                entity.Property(e => e.PatientDemographicsId).HasColumnName("PatientDemographicsID");

                entity.Property(e => e.PocparticipantId)
                    .HasColumnName("POCParticipantID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedMessage).IsUnicode(false);

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.SurescriptsParticipantId)
                    .HasColumnName("SurescriptsParticipantID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsageIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponsePhysician>(entity =>
            {
                entity.HasKey(e => e.EligibilityResponsePhysicianId);

                entity.Property(e => e.EligibilityResponsePhysicianId).HasColumnName("EligibilityResponsePhysicianID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDevicePin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseDetailId).HasColumnName("EligibilityResponseDetailID");

                entity.Property(e => e.EligibilityResponseMainId).HasColumnName("EligibilityResponseMainID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityIdnumber)
                    .HasColumnName("FacilityIDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityNetworkId)
                    .HasColumnName("FacilityNetworkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FederalTaxpayerId)
                    .HasColumnName("FederalTaxpayerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Hpi)
                    .HasColumnName("HPI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MedicaidProviderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareProviderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Npi)
                    .HasColumnName("NPI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayerIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalIdentificationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PharmacyProcessorNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriorIdentifierNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderPlanNetworkId)
                    .HasColumnName("ProviderPlanNetworkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderReferenceIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderReferenceQualifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceProviderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateLicenseNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateLicenseNumberDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("SubmitterID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseSubscriber>(entity =>
            {
                entity.HasKey(e => e.EligibilityResponseSuscriberId);

                entity.Property(e => e.EligibilityResponseSuscriberId).HasColumnName("EligibilityResponseSuscriberID");

                entity.Property(e => e.AddressInformation1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AddressInformation2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.BenifitStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ConfidentialyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsolidatedStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.EligibilityResponseDetailId).HasColumnName("EligibilityResponseDetailID");

                entity.Property(e => e.EligibilityResponseMainId).HasColumnName("EligibilityResponseMainID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsCity).HasMaxLength(10);

                entity.Property(e => e.InsCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsdateTime)
                    .HasColumnName("INSDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MedicareStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderReferenceIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderReferenceIdentificationDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Trace1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace1OriginatingCompanyIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace1ReferenceIdentification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Trace1ReferenceIdentification2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Trace2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace2OriginatingCompanyIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace2ReferenceIdentification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Trace2ReferenceIdentification2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Trace3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace3OriginatingCompanyIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trace3ReferenceIdentification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Trace3ReferenceIdentification2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseSubscriberDates>(entity =>
            {
                entity.HasKey(e => e.EligibilitySubscriberDateId);

                entity.Property(e => e.EligibilitySubscriberDateId).HasColumnName("EligibilitySubscriberDateID");

                entity.Property(e => e.DateDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberId).HasColumnName("EligibilityResponseSuscriberID");

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsuranceResponseSubscriberEb>(entity =>
            {
                entity.HasKey(e => e.EligibilityResponseSuscriberEbid);

                entity.ToTable("InsuranceResponseSubscriberEB");

                entity.Property(e => e.EligibilityResponseSuscriberEbid).HasColumnName("EligibilityResponseSuscriberEBID");

                entity.Property(e => e.AgeHighValueQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgeLowValueQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPercent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BenifitInformationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BenifitInformationDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageLevel)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CoveredActualQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoveredEstimatedQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DaysQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeductableBloodUnitsQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberEbmainId).HasColumnName("EligibilityResponseSuscriberEBMainID");

                entity.Property(e => e.HoursQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceType)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LifeTimeReservedActualQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LifeTimeReservedEstimatedQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MonetryAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MonthQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfCoInsuranceDaysQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfServicesOrProceduresQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlanCoverageDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityApprovedQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityUsedQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimePeriodQualifier)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisitsQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YearsQty)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseSubscriberEbmain>(entity =>
            {
                entity.HasKey(e => e.EligibilityResponseSuscriberEbmainId);

                entity.ToTable("InsuranceResponseSubscriberEBMain");

                entity.Property(e => e.EligibilityResponseSuscriberEbmainId).HasColumnName("EligibilityResponseSuscriberEBMainID");

                entity.Property(e => e.EligibilityResponseSuscriberId).HasColumnName("EligibilityResponseSuscriberID");

                entity.Property(e => e.EligibilityType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseSubscriberIdentification>(entity =>
            {
                entity.HasKey(e => e.EligibilitySubscriberIdentificationId);

                entity.Property(e => e.EligibilitySubscriberIdentificationId).HasColumnName("EligibilitySubscriberIdentificationID");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EligibilityResponseSuscriberId).HasColumnName("EligibilityResponseSuscriberID");

                entity.Property(e => e.ReferenceIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceIdentificationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceResponseValidations>(entity =>
            {
                entity.HasKey(e => e.EligibilityResposeValidationId);

                entity.Property(e => e.EligibilityResposeValidationId).HasColumnName("EligibilityResposeValidationID");

                entity.Property(e => e.EligibilityResponseDetailId).HasColumnName("EligibilityResponseDetailID");

                entity.Property(e => e.FollowupActionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupActionDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsurnaceRequestSubscriber>(entity =>
            {
                entity.HasKey(e => e.EligibilityRequestSuscriberId);

                entity.Property(e => e.EligibilityRequestSuscriberId).HasColumnName("EligibilityRequestSuscriberID");

                entity.Property(e => e.AddressInformation1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressInformation2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.EligibilityRequestMainId).HasColumnName("EligibilityRequestMainID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.OriginatingCompanyIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceIdentification2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceInsurance>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.InsId });

                entity.ToTable("Invoice_Insurance");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InsId)
                    .HasColumnName("Ins_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TypeOfInsurance)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ins)
                    .WithMany(p => p.InvoiceInsurance)
                    .HasForeignKey(d => d.InsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Insurance_B_Insurance");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceInsurance)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Insurance_Invoice_Master");
            });

            modelBuilder.Entity<InvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Invoice_Master");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_Invoice_Master");

                entity.HasIndex(e => e.ServiceDate)
                    .HasName("IX_Invoice_Master_1");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.AccessionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adjustments).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Assignment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CollectionDate).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId1)
                    .HasColumnName("Ins_ID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId2)
                    .HasColumnName("Ins_ID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.TotalCharges).HasColumnName("Total_Charges");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InvoiceMaster)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Invoice_Master_B_Doctor1");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.InvoiceMaster)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Invoice_Master_B_Patient1");
            });

            modelBuilder.Entity<InvoicePatientInsurance>(entity =>
            {
                entity.HasKey(e => e.PatRelationId);

                entity.ToTable("Invoice_Patient_Insurance");

                entity.Property(e => e.PatRelationId)
                    .HasColumnName("PatRelationID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccCode)
                    .HasColumnName("Acc_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Assignment1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrnaIndicator)
                    .HasColumnName("CRNA_Indicator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeathIndicarot)
                    .HasColumnName("Death_Indicarot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRelated)
                    .HasColumnName("Emp_Related")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Epsdt)
                    .HasColumnName("EPSDT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtInsNo)
                    .HasColumnName("Ext_Ins_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FamPlanning)
                    .HasColumnName("Fam_Planning")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBoundInd)
                    .HasColumnName("Home_Bound_Ind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icity)
                    .HasColumnName("ICity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceName)
                    .HasColumnName("Insurance_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredFirstName)
                    .HasColumnName("Insured_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredGroupNo)
                    .HasColumnName("Insured_GroupNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredLastName)
                    .HasColumnName("Insured_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredRelationship)
                    .HasColumnName("Insured_Relationship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredSex)
                    .HasColumnName("Insured_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Istate)
                    .HasColumnName("IState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Izip)
                    .HasColumnName("IZip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartBBlood)
                    .HasColumnName("Part_B_Blood")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatSignature)
                    .HasColumnName("Pat_Signature")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriorAuthNumber)
                    .HasColumnName("Prior_Auth_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Privacy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDg)
                    .HasColumnName("Purchase_DG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicePatientInsurance)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Invoice_Patient_Insurance_Invoice_Master");
            });

            modelBuilder.Entity<InvoiceTest>(entity =>
            {
                entity.ToTable("Invoice_Test");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("IX_Invoice_Test");

                entity.Property(e => e.InvoiceTestId)
                    .HasColumnName("Invoice_Test_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptCode)
                    .HasColumnName("CPT_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateBilled)
                    .HasColumnName("Date_Billed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dx)
                    .HasColumnName("DX")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Pre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unt)
                    .HasColumnName("UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceTest)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Test_Invoice_Master");
            });

            modelBuilder.Entity<InvoiceTestForGroupedCpt>(entity =>
            {
                entity.HasKey(e => e.InvoiceTestId);

                entity.ToTable("Invoice_Test_for_Grouped_cpt");

                entity.Property(e => e.InvoiceTestId)
                    .HasColumnName("Invoice_Test_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptCode)
                    .HasColumnName("CPT_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateBilled)
                    .HasColumnName("Date_Billed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dx)
                    .HasColumnName("DX")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Pre).HasMaxLength(10);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unt)
                    .HasColumnName("UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Labcorptest>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Labcorptest$");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCodeName).HasMaxLength(255);

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCodeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Labcorptest1>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Labcorptest$1");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCodeName).HasMaxLength(255);

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCodeName).HasMaxLength(255);
            });

            modelBuilder.Entity<LabPro>(entity =>
            {
                entity.Property(e => e.LabProId).HasColumnName("LabPro_ID");

                entity.Property(e => e.AccessionNo)
                    .HasColumnName("Accession_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BioTypeNumber)
                    .HasColumnName("Bio_Type_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugTestCode)
                    .HasColumnName("Drug_Test_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugTestDescription)
                    .HasColumnName("Drug_Test_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsolateNo)
                    .HasColumnName("Isolate_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicId)
                    .HasColumnName("MIC_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicValue)
                    .HasColumnName("MIC_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NosocomialInfection)
                    .HasColumnName("Nosocomial_Infection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismClass)
                    .HasColumnName("Organism_Class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismCode)
                    .HasColumnName("Organism_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismDescription)
                    .HasColumnName("Organism_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismSet)
                    .HasColumnName("Organism_Set")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sensitivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenDate)
                    .HasColumnName("Specimen_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenNo)
                    .HasColumnName("Specimen_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenStatus)
                    .HasColumnName("Specimen_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestGroupCode)
                    .HasColumnName("Test_Group_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestGroupDescription)
                    .HasColumnName("Test_Group_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabProLog>(entity =>
            {
                entity.HasKey(e => e.LabProId);

                entity.ToTable("LabPro_log");

                entity.Property(e => e.LabProId).HasColumnName("LabPro_ID");

                entity.Property(e => e.AccessionNo)
                    .HasColumnName("Accession_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BioTypeNumber)
                    .HasColumnName("Bio_Type_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugTestCode)
                    .HasColumnName("Drug_Test_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugTestDescription)
                    .HasColumnName("Drug_Test_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsolateNo)
                    .HasColumnName("Isolate_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicId)
                    .HasColumnName("MIC_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicValue)
                    .HasColumnName("MIC_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NosocomialInfection)
                    .HasColumnName("Nosocomial_Infection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismClass)
                    .HasColumnName("Organism_Class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismCode)
                    .HasColumnName("Organism_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismDescription)
                    .HasColumnName("Organism_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismSet)
                    .HasColumnName("Organism_Set")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sensitivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenDate)
                    .HasColumnName("Specimen_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenNo)
                    .HasColumnName("Specimen_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenStatus)
                    .HasColumnName("Specimen_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestGroupCode)
                    .HasColumnName("Test_Group_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestGroupDescription)
                    .HasColumnName("Test_Group_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabTestMapping>(entity =>
            {
                entity.HasKey(e => e.RefId);

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.LabCode)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.LabId)
                    .IsRequired()
                    .HasColumnName("LabID")
                    .IsUnicode(false);

                entity.Property(e => e.Nsmlcode)
                    .IsRequired()
                    .HasColumnName("NSMLCode")
                    .IsUnicode(false);

                entity.Property(e => e.TestNameQdx)
                    .HasColumnName("TestName_Qdx")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LetterTemplate>(entity =>
            {
                entity.Property(e => e.LetterTemplateId).HasColumnName("LetterTemplateID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LetterDescription).IsUnicode(false);

                entity.Property(e => e.LetterDescriptionRtf)
                    .HasColumnName("LetterDescriptionRTF")
                    .IsUnicode(false);

                entity.Property(e => e.LetterSubject)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LmsauditOther>(entity =>
            {
                entity.ToTable("LMSAuditOther");

                entity.Property(e => e.LmsauditOtherId).HasColumnName("LMSAuditOtherID");

                entity.Property(e => e.LmsauditId).HasColumnName("LMSAuditID");

                entity.Property(e => e.LmsnewVal)
                    .HasColumnName("LMSNewVal")
                    .HasColumnType("image");

                entity.HasOne(d => d.Lmsaudit)
                    .WithMany(p => p.LmsauditOther)
                    .HasForeignKey(d => d.LmsauditId)
                    .HasConstraintName("FK_LMSAuditOther_LMSAuditTrial");
            });

            modelBuilder.Entity<LmsauditTrial>(entity =>
            {
                entity.ToTable("LMSAuditTrial");

                entity.HasIndex(e => e.DateNtime)
                    .HasName("IX_LMSAuditTrial_5");

                entity.HasIndex(e => e.FormTitle)
                    .HasName("IX_LMSAuditTrial_3");

                entity.HasIndex(e => e.Ip)
                    .HasName("IX_LMSAuditTrial_2");

                entity.HasIndex(e => e.LmsUserId)
                    .HasName("IX_LMSAuditTrial");

                entity.HasIndex(e => new { e.LmsUserId, e.LmsauditTrialId })
                    .HasName("IX_LMSAuditTrial_1");

                entity.HasIndex(e => new { e.UserId, e.FormTitle })
                    .HasName("IX_LMSAuditTrial_4");

                entity.Property(e => e.LmsauditTrialId).HasColumnName("LMSAuditTrialID");

                entity.Property(e => e.AccessionNo).HasMaxLength(15);

                entity.Property(e => e.ActionDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AuditAction)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditActionId).HasColumnName("AuditActionID");

                entity.Property(e => e.DateNtime)
                    .HasColumnName("DateNTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormBlname)
                    .HasColumnName("FormBLName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormDll)
                    .HasColumnName("FormDLL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormExtraValue1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LmsUserId).HasColumnName("LMS_User_ID");

                entity.Property(e => e.OldData).HasColumnType("image");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuditActionNavigation)
                    .WithMany(p => p.LmsauditTrial)
                    .HasForeignKey(d => d.AuditActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LMSAuditTrial_AuditAction");
            });

            modelBuilder.Entity<LmsUser>(entity =>
            {
                entity.ToTable("LMS_User");

                entity.Property(e => e.LmsUserId).HasColumnName("LMS_User_Id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.Initials)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Password)
                    .HasMaxLength(551)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.LmsUser)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Sys_User_Groups_Right_table");
            });

            modelBuilder.Entity<MachineTests>(entity =>
            {
                entity.HasKey(e => e.MachineTestId);

                entity.Property(e => e.MachineTestId).HasColumnName("MachineTestID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cvalue)
                    .HasColumnName("CValue")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cvalue1)
                    .HasColumnName("CValue1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DPoint).HasColumnName("D_Point");

                entity.Property(e => e.FalseResult)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabTest).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MachineCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTest)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Op)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Op1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrueResult)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.MachineTests)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MachineTests_Clinical_Test");
            });

            modelBuilder.Entity<MicrobialMapping>(entity =>
            {
                entity.HasKey(e => e.MapId);

                entity.ToTable("Microbial_Mapping");

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.AgCode)
                    .HasColumnName("Ag_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("Ag_ID")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AgName)
                    .HasColumnName("Ag_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MapTestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MicroBiologyResult>(entity =>
            {
                entity.HasKey(e => e.MbrId);

                entity.ToTable("Micro_Biology_Result");

                entity.Property(e => e.MbrId).HasColumnName("MBR_ID");

                entity.Property(e => e.AccNo).HasColumnName("Acc_No");

                entity.Property(e => e.FiveColCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FiveOrganism).HasDefaultValueSql("((0))");

                entity.Property(e => e.FiveResult).HasDefaultValueSql("((0))");

                entity.Property(e => e.FourColCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FourOrganism).HasDefaultValueSql("((0))");

                entity.Property(e => e.FourResult).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.OneColCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.OneOrganism).HasDefaultValueSql("((0))");

                entity.Property(e => e.OneResult).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeColCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThreeOrganism).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThreeResult).HasDefaultValueSql("((0))");

                entity.Property(e => e.TwoColCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TwoOrganism).HasDefaultValueSql("((0))");

                entity.Property(e => e.TwoResult).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Prt)
                    .WithMany(p => p.MicroBiologyResult)
                    .HasForeignKey(d => d.PrtId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Micro_Biology_Result_PatientReq_Test");
            });

            modelBuilder.Entity<MicrobiologyTest>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("Microbiology_Test");

                entity.Property(e => e.TestId).HasColumnName("Test_Id");

                entity.Property(e => e.ClId).HasColumnName("CL_ID");

                entity.Property(e => e.Commissionable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Source)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode).HasColumnName("Test_Code");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tube)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MicroCodes>(entity =>
            {
                entity.HasKey(e => e.MicroId);

                entity.Property(e => e.MicroId).HasColumnName("Micro_Id");

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.CptCode)
                    .HasColumnName("CPT_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IcdCode)
                    .HasColumnName("ICD_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfoId).HasColumnName("Info_ID");

                entity.Property(e => e.MicroCode)
                    .HasColumnName("Micro_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MicroDescription)
                    .HasColumnName("Micro_Description")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MicroFollowUp)
                    .HasColumnName("Micro_FollowUp")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MicroHl7Result>(entity =>
            {
                entity.HasKey(e => e.LabProId);

                entity.ToTable("Micro_HL7_Result");

                entity.Property(e => e.LabProId).HasColumnName("LabPro_ID");

                entity.Property(e => e.AccessionNo)
                    .HasColumnName("Accession_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BioTypeNumber)
                    .HasColumnName("Bio_Type_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugTestCode)
                    .HasColumnName("Drug_Test_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrugTestDescription)
                    .HasColumnName("Drug_Test_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsolateNo)
                    .HasColumnName("Isolate_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicId)
                    .HasColumnName("MIC_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MicValue)
                    .HasColumnName("MIC_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NosocomialInfection)
                    .HasColumnName("Nosocomial_Infection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismClass)
                    .HasColumnName("Organism_Class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismCode)
                    .HasColumnName("Organism_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismDescription)
                    .HasColumnName("Organism_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismSet)
                    .HasColumnName("Organism_Set")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sensitivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenDate)
                    .HasColumnName("Specimen_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenNo)
                    .HasColumnName("Specimen_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenStatus)
                    .HasColumnName("Specimen_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestGroupCode)
                    .HasColumnName("Test_Group_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestGroupDescription)
                    .HasColumnName("Test_Group_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MicroResultIsolate>(entity =>
            {
                entity.HasKey(e => e.MriId);

                entity.ToTable("Micro_Result_Isolate");

                entity.Property(e => e.MriId).HasColumnName("MRI_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Isolate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MbrId).HasColumnName("MBR_ID");

                entity.HasOne(d => d.Mbr)
                    .WithMany(p => p.MicroResultIsolate)
                    .HasForeignKey(d => d.MbrId)
                    .HasConstraintName("FK_Micro_Result_Isolate_Micro_Biology_Result");
            });

            modelBuilder.Entity<MicroResultOrganism>(entity =>
            {
                entity.HasKey(e => e.MroId);

                entity.ToTable("Micro_Result_Organism");

                entity.Property(e => e.MroId).HasColumnName("MRO_ID");

                entity.Property(e => e.AgId).HasColumnName("Ag_ID");

                entity.Property(e => e.ColCode)
                    .HasColumnName("Col_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColCount)
                    .HasColumnName("Col_Count")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.MicValue)
                    .HasColumnName("MIC_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MriId).HasColumnName("MRI_ID");

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.Sensitivity)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.MicroResultOrganism)
                    .HasForeignKey(d => d.AgId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Micro_Result_Organism_Anti_Micro_Agent");

                entity.HasOne(d => d.Mri)
                    .WithMany(p => p.MicroResultOrganism)
                    .HasForeignKey(d => d.MriId)
                    .HasConstraintName("FK_Micro_Result_Organism_Micro_Result_Isolate");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.MicroResultOrganism)
                    .HasForeignKey(d => d.OrgId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Micro_Result_Organism_Organism");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.HasKey(e => e.NotId);

                entity.Property(e => e.NotId)
                    .HasColumnName("Not_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CatId)
                    .HasColumnName("Cat_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NotCode)
                    .HasColumnName("Not_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NotDescription)
                    .HasColumnName("Not_Description")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NotFollow)
                    .HasColumnName("Not_Follow")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("now_category");

                entity.HasIndex(e => e.CategoryStateId)
                    .HasName("FK_NOW_Category");

                entity.HasIndex(e => e.CategoryTypeId)
                    .HasName("FK_category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Active).HasDefaultValueSql("(0)");

                entity.Property(e => e.Address1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address4)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address5)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryStateId).HasColumnName("CategoryStateID");

                entity.Property(e => e.CategoryTypeId).HasColumnName("CategoryTypeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Pocemail)
                    .HasColumnName("POCEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pocname)
                    .HasColumnName("POCName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Poctel)
                    .HasColumnName("POCTel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uic)
                    .HasColumnName("UIC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vpocemail)
                    .HasColumnName("VPOCEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vpocname)
                    .HasColumnName("VPOCName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vpoctel)
                    .HasColumnName("VPOCTel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryType)
                    .WithMany(p => p.NowCategory)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .HasConstraintName("FK_now_categorytype_now_category");
            });

            modelBuilder.Entity<NowCategorymodule>(entity =>
            {
                entity.HasKey(e => e.CategoryModuleId);

                entity.ToTable("now_categorymodule");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_now_categorymodule");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("FK_now_categorymodule_moduleID");

                entity.Property(e => e.CategoryModuleId).HasColumnName("CategoryModuleID");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.NowCategorymodule)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_category_now_categorymodule");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.NowCategorymodule)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_module_now_categorymodule");
            });

            modelBuilder.Entity<NowCategorytype>(entity =>
            {
                entity.HasKey(e => e.CategoryTypeId);

                entity.ToTable("now_categorytype");

                entity.Property(e => e.CategoryTypeId).HasColumnName("CategoryTypeID");

                entity.Property(e => e.CategoryTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NowClient>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("now_client");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_Now_client");

                entity.HasIndex(e => e.ClientStateId)
                    .HasName("FK_client_ClientStateID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientActive).HasDefaultValueSql("(0)");

                entity.Property(e => e.ClientStateId).HasColumnName("ClientStateID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ssno)
                    .HasColumnName("SSNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.NowClient)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_now_category_now_client");
            });

            modelBuilder.Entity<NowClientmodule>(entity =>
            {
                entity.HasKey(e => e.ClientModuleId);

                entity.ToTable("now_clientmodule");

                entity.HasIndex(e => e.ClientId)
                    .HasName("FK_now_clientmodule");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("FK_now_clientmodule_ModuleID");

                entity.Property(e => e.ClientModuleId).HasColumnName("ClientModuleID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.NowClientmodule)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_now_client_now_clientmodule");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.NowClientmodule)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_module_now_clientmodule");
            });

            modelBuilder.Entity<NowCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("now_company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("now_country");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NowFilestatus>(entity =>
            {
                entity.HasKey(e => e.FileStausId);

                entity.ToTable("now_filestatus");

                entity.Property(e => e.FileStausId).HasColumnName("FileStausID");

                entity.Property(e => e.FileStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowFiletype>(entity =>
            {
                entity.HasKey(e => new { e.FileTypeId, e.FileType });

                entity.ToTable("now_filetype");

                entity.HasIndex(e => e.FileTypeId)
                    .HasName("FileTypeID")
                    .IsUnique();

                entity.Property(e => e.FileTypeId)
                    .HasColumnName("FileTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FileType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NowFileuploadPatient>(entity =>
            {
                entity.HasKey(e => e.FileUploadId);

                entity.ToTable("now_fileupload_patient");

                entity.HasIndex(e => e.FileTypeId)
                    .HasName("FK_now_fileupload_patient");

                entity.HasIndex(e => e.Status)
                    .HasName("FK_now_fileupload_patient_stiid");

                entity.Property(e => e.FileUploadId).HasColumnName("FileUploadID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileDownloadPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FileDownloadSize).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FileDownloadTime).HasColumnType("datetime");

                entity.Property(e => e.FileDownloadVirtualPath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FileIsDownloaded).HasDefaultValueSql("(0)");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FileSystemName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.NowFileuploadPatient)
                    .HasPrincipalKey(p => p.FileTypeId)
                    .HasForeignKey(d => d.FileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_filetype_now_fileupload_patient");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.NowFileuploadPatient)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_filestatus_now_fileupload_patient");
            });

            modelBuilder.Entity<NowLabitem>(entity =>
            {
                entity.HasKey(e => e.LabtItemId);

                entity.ToTable("now_labitem");

                entity.HasIndex(e => e.UnitType)
                    .HasName("FK_labitem");

                entity.Property(e => e.LabtItemId).HasColumnName("LabtItemID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.QtyInStock).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.UnitTypeNavigation)
                    .WithMany(p => p.NowLabitem)
                    .HasForeignKey(d => d.UnitType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_labitemunittype_now_labitem");
            });

            modelBuilder.Entity<NowLabitemcategory>(entity =>
            {
                entity.HasKey(e => e.LabItemCategoryId);

                entity.ToTable("now_labitemcategory");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_now_labitemcategory");

                entity.HasIndex(e => e.LabItemId)
                    .HasName("FK_now_labitemcategory_labItmeID");

                entity.Property(e => e.LabItemCategoryId).HasColumnName("LabItemCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LabItemId).HasColumnName("LabItemID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.NowLabitemcategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_category_now_labitemcategory");

                entity.HasOne(d => d.LabItem)
                    .WithMany(p => p.NowLabitemcategory)
                    .HasForeignKey(d => d.LabItemId)
                    .HasConstraintName("FK_now_labitem_now_labitemcategory");
            });

            modelBuilder.Entity<NowLabitemclientaddress>(entity =>
            {
                entity.HasKey(e => e.CustomerAddressId);

                entity.ToTable("now_labitemclientaddress");

                entity.Property(e => e.CustomerAddressId).HasColumnName("CustomerAddressID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OtherState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowLabitemrequest>(entity =>
            {
                entity.HasKey(e => e.LabItemRequestId);

                entity.ToTable("now_labitemrequest");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_now_labitemrequest_CateogryID");

                entity.HasIndex(e => e.ClientAddressId)
                    .HasName("FK_now_labitemrequest_ClientAddress");

                entity.HasIndex(e => e.ClientId)
                    .HasName("FK_now_labitemrequest_clientID");

                entity.HasIndex(e => e.LabItemRequestStatusId)
                    .HasName("FK_now_labitemrequest");

                entity.Property(e => e.LabItemRequestId).HasColumnName("LabItemRequestID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ClientAddressId).HasColumnName("ClientAddressID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LabItemRequestStatusId).HasColumnName("LabItemRequestStatusID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.NowLabitemrequest)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_category_now_labitemrequest");

                entity.HasOne(d => d.ClientAddress)
                    .WithMany(p => p.NowLabitemrequest)
                    .HasForeignKey(d => d.ClientAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_labitemclientaddress_now_labitemrequest");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.NowLabitemrequest)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_now_client_now_labitemrequest");

                entity.HasOne(d => d.LabItemRequestStatus)
                    .WithMany(p => p.NowLabitemrequest)
                    .HasForeignKey(d => d.LabItemRequestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_labitemrequeststatus_now_labitemrequest");
            });

            modelBuilder.Entity<NowLabitemrequestdetail>(entity =>
            {
                entity.HasKey(e => e.LabItemRequestDetailId);

                entity.ToTable("now_labitemrequestdetail");

                entity.HasIndex(e => e.LabItemId)
                    .HasName("FK_now_labitemrequestdetail_LabItemID");

                entity.HasIndex(e => e.LabItemRequestId)
                    .HasName("FK_labitemrequestdetail");

                entity.HasIndex(e => e.LabItemRequestShipmentCompanyId)
                    .HasName("FK_now_labitemrequestdetail_shipcomid");

                entity.HasIndex(e => e.LabItemSupplierId)
                    .HasName("FK_now_labitemrequestdetail");

                entity.Property(e => e.LabItemRequestDetailId).HasColumnName("LabItemRequestDetailID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LabItemId).HasColumnName("LabItemID");

                entity.Property(e => e.LabItemRequestId).HasColumnName("LabItemRequestID");

                entity.Property(e => e.LabItemRequestShipmentCompanyId).HasColumnName("LabItemRequestShipmentCompanyID");

                entity.Property(e => e.LabItemSupplierId).HasColumnName("LabItemSupplierID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.LabItem)
                    .WithMany(p => p.NowLabitemrequestdetail)
                    .HasForeignKey(d => d.LabItemId)
                    .HasConstraintName("FK_now_labitem_now_labitemrequestdetail");

                entity.HasOne(d => d.LabItemRequest)
                    .WithMany(p => p.NowLabitemrequestdetail)
                    .HasForeignKey(d => d.LabItemRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_labitemrequest_now_labitemrequestdetail");

                entity.HasOne(d => d.LabItemRequestShipmentCompany)
                    .WithMany(p => p.NowLabitemrequestdetail)
                    .HasForeignKey(d => d.LabItemRequestShipmentCompanyId)
                    .HasConstraintName("FK_now_labitemrequestshipmentcomany_now_labitemrequestdetail");

                entity.HasOne(d => d.LabItemSupplier)
                    .WithMany(p => p.NowLabitemrequestdetail)
                    .HasForeignKey(d => d.LabItemSupplierId)
                    .HasConstraintName("FK_now_labitemsupplier_now_labitemrequestdetail");
            });

            modelBuilder.Entity<NowLabitemrequestshipmentcomany>(entity =>
            {
                entity.HasKey(e => e.LabItemRequestShipmentComanyId);

                entity.ToTable("now_labitemrequestshipmentcomany");

                entity.Property(e => e.LabItemRequestShipmentComanyId).HasColumnName("LabItemRequestShipmentComanyID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentCompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentWebsite)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowLabitemrequestshipmentdetail>(entity =>
            {
                entity.HasKey(e => e.LabItemRequestShipmentDetailId);

                entity.ToTable("now_labitemrequestshipmentdetail");

                entity.HasIndex(e => e.LabitemrequestdetailId)
                    .HasName("FK_now_labitemrequestshipmentdetail_reqdetialID");

                entity.Property(e => e.LabItemRequestShipmentDetailId).HasColumnName("LabItemRequestShipmentDetailID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EventCode).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LabitemrequestdetailId).HasColumnName("LabitemrequestdetailID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Labitemrequestdetail)
                    .WithMany(p => p.NowLabitemrequestshipmentdetail)
                    .HasForeignKey(d => d.LabitemrequestdetailId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_now_labitemrequestdetail_now_labitemrequestshipmentdetail");
            });

            modelBuilder.Entity<NowLabitemrequeststatus>(entity =>
            {
                entity.HasKey(e => e.LabItemRequestStatusId);

                entity.ToTable("now_labitemrequeststatus");

                entity.Property(e => e.LabItemRequestStatusId).HasColumnName("LabItemRequestStatusID");

                entity.Property(e => e.LabItemRequestDesc)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowLabitemsupplier>(entity =>
            {
                entity.HasKey(e => e.LabItemSupplierId);

                entity.ToTable("now_labitemsupplier");

                entity.Property(e => e.LabItemSupplierId).HasColumnName("LabItemSupplierID");

                entity.Property(e => e.Address)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowLabitemsupplierdetail>(entity =>
            {
                entity.HasKey(e => e.LabItemSupplierDetail);

                entity.ToTable("now_labitemsupplierdetail");

                entity.HasIndex(e => e.LabItemId)
                    .HasName("FK_now_labitemsupplierdetail_labItemID");

                entity.HasIndex(e => e.LabItemSupplierId)
                    .HasName("FK_now_labitemsupplierdetail");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LabItemId).HasColumnName("LabItemID");

                entity.Property(e => e.LabItemSupplierId).HasColumnName("LabItemSupplierID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.LabItem)
                    .WithMany(p => p.NowLabitemsupplierdetail)
                    .HasForeignKey(d => d.LabItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_labitem_now_labitemsupplierdetail");

                entity.HasOne(d => d.LabItemSupplier)
                    .WithMany(p => p.NowLabitemsupplierdetail)
                    .HasForeignKey(d => d.LabItemSupplierId)
                    .HasConstraintName("FK_now_labitemsupplier_now_labitemsupplierdetail");
            });

            modelBuilder.Entity<NowLabitemunittype>(entity =>
            {
                entity.HasKey(e => e.LabItemUnitId);

                entity.ToTable("now_labitemunittype");

                entity.Property(e => e.LabItemUnitId).HasColumnName("LabItemUnitID");

                entity.Property(e => e.LabItemUnitName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowModule>(entity =>
            {
                entity.HasKey(e => e.ModulesId);

                entity.ToTable("now_module");

                entity.Property(e => e.ModulesId).HasColumnName("ModulesID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowPatwebreq>(entity =>
            {
                entity.HasKey(e => e.ReqId);

                entity.ToTable("now_patwebreq");

                entity.HasIndex(e => e.BatchNo)
                    .HasName("FK_patwebreq_BatchID");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_now_patwebreq");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.AccessionNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CollectionDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PaientFirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientDob)
                    .HasColumnName("PatientDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientDutyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PatientFmp)
                    .HasColumnName("PatientFMP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PatientLastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientMidInitial)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PatientSsn)
                    .HasColumnName("PatientSSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SpecimenSourceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BatchNoNavigation)
                    .WithMany(p => p.NowPatwebreq)
                    .HasForeignKey(d => d.BatchNo)
                    .HasConstraintName("FK_now_patwebreqbatch_now_patwebreq");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.NowPatwebreq)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_now_category_now_patwebreq");
            });

            modelBuilder.Entity<NowPatwebreqbatch>(entity =>
            {
                entity.HasKey(e => e.PatWebReqBatchId);

                entity.ToTable("now_patwebreqbatch");

                entity.HasIndex(e => e.PwrbcategoryId)
                    .HasName("FK_now_patwebreqbatch");

                entity.Property(e => e.PatWebReqBatchId).HasColumnName("PatWebReqBatchID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.PwrbbatchNumber)
                    .IsRequired()
                    .HasColumnName("PWRBBatchNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PwrbcategoryId).HasColumnName("PWRBCategoryID");

                entity.Property(e => e.PwrbisOpen).HasColumnName("PWRBIsOpen");

                entity.HasOne(d => d.Pwrbcategory)
                    .WithMany(p => p.NowPatwebreqbatch)
                    .HasForeignKey(d => d.PwrbcategoryId)
                    .HasConstraintName("FK_now_category_now_patwebreqbatch");
            });

            modelBuilder.Entity<NowPatwebtest>(entity =>
            {
                entity.HasKey(e => e.ReqTestId);

                entity.ToTable("now_patwebtest");

                entity.HasIndex(e => e.ReqId)
                    .HasName("FK_now_patwebtest");

                entity.Property(e => e.ReqTestId).HasColumnName("ReqTestID");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.NowPatwebtest)
                    .HasForeignKey(d => d.ReqId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_now_patwebreq_now_patwebtest");
            });

            modelBuilder.Entity<NowProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("now_product");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_product_Category");

                entity.HasIndex(e => e.ProductCompanyId)
                    .HasName("FK_product_Company");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LargImage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCompanyId).HasColumnName("ProductCompanyID");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.NowProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_productcategory_now_product");

                entity.HasOne(d => d.ProductCompany)
                    .WithMany(p => p.NowProduct)
                    .HasForeignKey(d => d.ProductCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_productcompany_now_product");
            });

            modelBuilder.Entity<NowProductcategory>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId);

                entity.ToTable("now_productcategory");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NowProductcategoryspec>(entity =>
            {
                entity.HasKey(e => e.ProductCategorySpecId);

                entity.ToTable("now_productcategoryspec");

                entity.Property(e => e.ProductCategorySpecId).HasColumnName("ProductCategorySpecID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductSpecification)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowProductcatspecvalue>(entity =>
            {
                entity.HasKey(e => e.ProductCatSpecValueId);

                entity.ToTable("now_productcatspecvalue");

                entity.Property(e => e.ProductCatSpecValueId).HasColumnName("ProductCatSpecValueID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCategorySpecId).HasColumnName("ProductCategorySpecID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SpecValue)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowProductcompany>(entity =>
            {
                entity.HasKey(e => e.ProductCompanyId);

                entity.ToTable("now_productcompany");

                entity.Property(e => e.ProductCompanyId).HasColumnName("ProductCompanyID");

                entity.Property(e => e.Address)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NowProductcustomeraddress>(entity =>
            {
                entity.HasKey(e => e.CustomerAddressId);

                entity.ToTable("now_productcustomeraddress");

                entity.HasIndex(e => e.Country)
                    .HasName("FK_productcustomeraddress");

                entity.HasIndex(e => e.StateId)
                    .HasName("FK_productcustomeraddress_State");

                entity.Property(e => e.CustomerAddressId).HasColumnName("CustomerAddressID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OtherState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.NowProductcustomeraddress)
                    .HasForeignKey(d => d.Country)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_now_country_now_productcustomeraddress");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.NowProductcustomeraddress)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_now_state_now_productcustomeraddress");
            });

            modelBuilder.Entity<NowState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("now_state");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(19548107650959083)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Olympusdata>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("OLYMPUSDATA");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasError)
                    .HasColumnName("hasError")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferred)
                    .HasColumnName("isTransferred")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Orders)
                    .HasColumnName("orders")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TestNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestResult)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OlympusdataCopy>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("OLYMPUSDATA_copy");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HasError)
                    .HasColumnName("hasError")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferred)
                    .HasColumnName("isTransferred")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Orders)
                    .HasColumnName("orders")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestResult)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Olympusdatanew>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("OLYMPUSDATAnew");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasError)
                    .HasColumnName("hasError")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTransferred)
                    .HasColumnName("isTransferred")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Orders)
                    .HasColumnName("orders")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TestNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestResult)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Organism>(entity =>
            {
                entity.HasKey(e => e.OrgId);

                entity.Property(e => e.OrgId).HasColumnName("Org_Id");

                entity.Property(e => e.AmaGrId).HasColumnName("AMA_Gr_Id");

                entity.Property(e => e.OrgCode).HasColumnName("Org_Code");

                entity.Property(e => e.OrgName)
                    .HasColumnName("Org_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AmaGr)
                    .WithMany(p => p.Organism)
                    .HasForeignKey(d => d.AmaGrId)
                    .HasConstraintName("FK_Organism_AMA_Group");
            });

            modelBuilder.Entity<OrgnismMapping>(entity =>
            {
                entity.HasKey(e => e.MapId);

                entity.ToTable("Orgnism_Mapping");

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MapTestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatCyto>(entity =>
            {
                entity.HasKey(e => e.PcId);

                entity.ToTable("Pat_Cyto");

                entity.Property(e => e.PcId).HasColumnName("PC_ID");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BodyCode)
                    .HasColumnName("Body_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BodyId).HasColumnName("Body_Id");

                entity.Property(e => e.BodyName)
                    .HasColumnName("Body_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtId).HasColumnName("CT_ID");

                entity.Property(e => e.CytoImage).HasColumnType("image");

                entity.Property(e => e.CytoType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PatId).HasColumnName("Pat_ID");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Body)
                    .WithMany(p => p.PatCyto)
                    .HasForeignKey(d => d.BodyId)
                    .HasConstraintName("FK_Pat_Cyto_BodyParts");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.PatCyto)
                    .HasForeignKey(d => d.CtId)
                    .HasConstraintName("FK_Pat_Cyto_Cytology_Test");

                entity.HasOne(d => d.Pat)
                    .WithMany(p => p.PatCyto)
                    .HasForeignKey(d => d.PatId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Pat_Cyto_Patient_Req");
            });

            modelBuilder.Entity<Pathologist>(entity =>
            {
                entity.HasKey(e => e.PatId);

                entity.Property(e => e.PatId).HasColumnName("Pat_Id");

                entity.Property(e => e.CellNo)
                    .HasColumnName("Cell_No")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.HasEnd).HasColumnName("hasEnd");

                entity.Property(e => e.LicenceNo)
                    .HasColumnName("Licence_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaId)
                    .HasColumnName("Medica_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareId)
                    .HasColumnName("Medicare_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatAddress)
                    .HasColumnName("Pat_Address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatCode)
                    .HasColumnName("Pat_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatDescription)
                    .HasColumnName("Pat_Description")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PatEmail)
                    .HasColumnName("Pat_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatEndDate)
                    .HasColumnName("Pat_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatFax)
                    .HasColumnName("Pat_Fax")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PatFirstName)
                    .HasColumnName("Pat_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatLastName)
                    .HasColumnName("Pat_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatPhone)
                    .HasColumnName("Pat_Phone")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PatSsn)
                    .HasColumnName("Pat_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PatStartDate)
                    .HasColumnName("Pat_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpinNo)
                    .HasColumnName("UPIN_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PaId);

                entity.Property(e => e.PaId).HasColumnName("Pa_Id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId).HasColumnName("InsID");

                entity.Property(e => e.InsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaAddress)
                    .HasColumnName("Pa_Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaChartNo)
                    .HasColumnName("Pa_ChartNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaEmail)
                    .HasColumnName("Pa_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaFax)
                    .HasColumnName("Pa_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaPhone)
                    .HasColumnName("Pa_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaSex)
                    .HasColumnName("Pa_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaSsn)
                    .HasColumnName("Pa_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ZipId).HasColumnName("Zip_ID");
            });

            modelBuilder.Entity<PatientE>(entity =>
            {
                entity.HasKey(e => e.PaIdE);

                entity.ToTable("Patient_E");

                entity.Property(e => e.PaIdE).HasColumnName("Pa_Id_e");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId).HasColumnName("InsID");

                entity.Property(e => e.InsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaAddress)
                    .HasColumnName("Pa_Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaChartNo)
                    .HasColumnName("Pa_ChartNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaEmail)
                    .HasColumnName("Pa_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaFax)
                    .HasColumnName("Pa_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaPhone)
                    .HasColumnName("Pa_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaSex)
                    .HasColumnName("Pa_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaSsn)
                    .HasColumnName("Pa_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_ID");
            });

            modelBuilder.Entity<PatientReq>(entity =>
            {
                entity.HasKey(e => e.PreId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Patient_Req");

                entity.HasIndex(e => e.Completed);

                entity.HasIndex(e => e.PaId)
                    .HasName("IX_Patient_Req_PatientID");

                entity.HasIndex(e => e.PreAccDate)
                    .HasName("Patient_Req_PRe_AccDate");

                entity.HasIndex(e => e.PreAccNo)
                    .HasName("IX_Patient_Req")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.PreDocId)
                    .HasName("IX_Patient_Req_DocID");

                entity.HasIndex(e => e.PreSpType)
                    .HasName("IX_Patient_Req_3");

                entity.HasIndex(e => new { e.PaId, e.PreId })
                    .HasName("IDX_PateintReq_PaID_PreID");

                entity.HasIndex(e => new { e.PreAccNo, e.PreId })
                    .HasName("IX_PatientReq_PreAccno_PreID");

                entity.HasIndex(e => new { e.PreId, e.PreAccDate })
                    .HasName("IX_Patient_Req_ACCnDATE");

                entity.HasIndex(e => new { e.PreId, e.PreAccNo })
                    .HasName("IX_Patient_Req_2");

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.AddAfp).HasColumnName("AddAFP");

                entity.Property(e => e.BillTo)
                    .HasColumnName("Bill_To")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Blu)
                    .HasColumnName("BLU")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Completed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateSpecimenRecvd).HasColumnType("datetime");

                entity.Property(e => e.DeletedTestsCodes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DirId).HasColumnName("Dir_Id");

                entity.Property(e => e.DrAccno)
                    .HasColumnName("Dr_Accno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fasting)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Grn)
                    .HasColumnName("GRN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gry)
                    .HasColumnName("GRY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hl7messageControlId)
                    .HasColumnName("HL7MessageControlID")
                    .HasMaxLength(1000);

                entity.Property(e => e.Hl7sendDate)
                    .HasColumnName("HL7sendDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsGroupNo)
                    .HasColumnName("Ins_Group_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId1).HasColumnName("Ins_ID1");

                entity.Property(e => e.InsId2).HasColumnName("Ins_ID2");

                entity.Property(e => e.InsId3).HasColumnName("Ins_ID3");

                entity.Property(e => e.InsNo1)
                    .HasColumnName("Ins_No1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNo2)
                    .HasColumnName("Ins_No2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNo3)
                    .HasColumnName("Ins_No3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsFinal).HasColumnName("isFinal");

                entity.Property(e => e.IsHl7).HasColumnName("isHL7");

                entity.Property(e => e.IsPdf).HasColumnName("isPdf");

                entity.Property(e => e.IsPdfDate)
                    .HasColumnName("isPdfDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsSpecimenVerified)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Lav)
                    .HasColumnName("LAV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineRportDate).HasColumnType("datetime");

                entity.Property(e => e.Oth)
                    .HasColumnName("OTH")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaId).HasColumnName("Pa_ID");

                entity.Property(e => e.PatComments)
                    .HasColumnName("Pat_Comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PatId).HasColumnName("Pat_ID");

                entity.Property(e => e.PatientNotes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PreAccDate)
                    .HasColumnName("PRe_AccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreAccNo).HasColumnName("PRe_AccNo");

                entity.Property(e => e.PreDocId).HasColumnName("PRe_DocID");

                entity.Property(e => e.PreDocId1)
                    .HasColumnName("PRe_DocID1")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PreDocId2)
                    .HasColumnName("PRe_DocID2")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PreDocId3)
                    .HasColumnName("PRe_DocID3")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PreDrawnDate)
                    .HasColumnName("PRe_DrawnDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreRecDate)
                    .HasColumnName("PRe_RecDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreReqNo)
                    .HasColumnName("PRe_ReqNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreSpType)
                    .HasColumnName("PRe_SpType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pregnant)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.Printed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Psc).HasColumnName("PSC");

                entity.Property(e => e.Race)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecentAddTestsCodes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecentDeletedTestsCodes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Red)
                    .HasColumnName("RED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefLabComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RelClinicalInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepComments)
                    .HasColumnName("Rep_Comments")
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("Report_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportIntDate)
                    .HasColumnName("Report_IntDate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportLstDate)
                    .HasColumnName("Report_LstDate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelfInsured)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.SiteNo)
                    .HasColumnName("Site_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sst)
                    .HasColumnName("SST")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sto)
                    .HasColumnName("STO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Swa)
                    .HasColumnName("SWA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempPreAccno).HasColumnName("TempPre_Accno");

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ViaHl7).HasColumnName("ViaHL7");

                entity.Property(e => e.WsComments)
                    .HasColumnName("WS_Comments")
                    .IsUnicode(false);

                entity.HasOne(d => d.Pa)
                    .WithMany(p => p.PatientReq)
                    .HasForeignKey(d => d.PaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Req_Patient");

                entity.HasOne(d => d.Pat)
                    .WithMany(p => p.PatientReq)
                    .HasForeignKey(d => d.PatId)
                    .HasConstraintName("FK_Patient_Req_Pathologist");

                entity.HasOne(d => d.PreDoc)
                    .WithMany(p => p.PatientReq)
                    .HasForeignKey(d => d.PreDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Req_Ref_Doctor");
            });

            modelBuilder.Entity<PatientReqAddnBillInfo>(entity =>
            {
                entity.HasKey(e => e.PrAbiId);

                entity.ToTable("PatientReq_AddnBillInfo");

                entity.HasIndex(e => e.PreId)
                    .HasName("IX_PatientReq_AddnBillInfo");

                entity.Property(e => e.PrAbiId).HasColumnName("PR_ABI_Id");

                entity.Property(e => e.AccidentCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AssignAccpt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BenefitAssigned)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeceasedDate).HasColumnType("datetime");

                entity.Property(e => e.DelayReason)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmergDate).HasColumnType("datetime");

                entity.Property(e => e.Emergency)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentRel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Epsdt)
                    .HasColumnName("EPSDT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraInsuranceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FamilyPlanning)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HomeBoundInd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode)
                    .HasColumnName("Ins_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsDob)
                    .HasColumnName("InsDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsSsn)
                    .HasColumnName("InsSSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsdAddress)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InsdFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsdGroupNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsdLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsdPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InsdSex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PatSignSource)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PatientSign)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.PriorAuth)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Privacy)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecProgCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .HasColumnName("Zip_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.InsdRelationshipNavigation)
                    .WithMany(p => p.PatientReqAddnBillInfo)
                    .HasForeignKey(d => d.InsdRelationship)
                    .HasConstraintName("FK_ReqAddBill_Relation");

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.PatientReqAddnBillInfo)
                    .HasForeignKey(d => d.PreId)
                    .HasConstraintName("FK_PatientReq_AddnBillInfo_PatientReq_AddnBillInfo");
            });

            modelBuilder.Entity<PatientReqBillTests>(entity =>
            {
                entity.HasKey(e => e.PrbtId);

                entity.ToTable("PatientReq_BillTests");

                entity.HasIndex(e => e.PreId)
                    .HasName("IX_PatientReq_BillTests");

                entity.Property(e => e.PrbtId).HasColumnName("PRBT_Id");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Billable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CptCode)
                    .HasColumnName("CPT_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("Pre_Id");

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestDescription)
                    .HasColumnName("Test_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TestId)
                    .HasColumnName("Test_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.PatientReqBillTests)
                    .HasForeignKey(d => d.PreId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PatientReq_BillTests_Patient_Req");
            });

            modelBuilder.Entity<PatientReqDiag>(entity =>
            {
                entity.HasKey(e => e.PreDiagId);

                entity.ToTable("PatientReq_Diag");

                entity.HasIndex(e => e.PreId)
                    .HasName("IX_PatientReq_Diag");

                entity.Property(e => e.PreDiagId).HasColumnName("PreDiagID");

                entity.Property(e => e.DiaId).HasColumnName("Dia_Id");

                entity.Property(e => e.DiaId10).HasColumnName("Dia_ID_10");

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.HasOne(d => d.Dia)
                    .WithMany(p => p.PatientReqDiag)
                    .HasForeignKey(d => d.DiaId)
                    .HasConstraintName("FK_PatientReq_Diag_Diagnosis");

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.PatientReqDiag)
                    .HasForeignKey(d => d.PreId)
                    .HasConstraintName("FK_PatientReq_Diag_Patient_Req");
            });

            modelBuilder.Entity<PatientReqDiagE>(entity =>
            {
                entity.HasKey(e => e.PreDiagIdE);

                entity.ToTable("PatientReq_Diag_e");

                entity.Property(e => e.PreDiagIdE).HasColumnName("PreDiagID_e");

                entity.Property(e => e.DiaId).HasColumnName("Dia_Id");

                entity.Property(e => e.DiaId10).HasColumnName("Dia_ID_10");

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");
            });

            modelBuilder.Entity<PatientReqDocuments>(entity =>
            {
                entity.HasKey(e => e.PreDocId);

                entity.Property(e => e.PreDocId).HasColumnName("PReDocID");

                entity.Property(e => e.Createdtime).HasColumnType("datetime");

                entity.Property(e => e.DocumentComment).HasMaxLength(200);

                entity.Property(e => e.FileName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("PReID");

                entity.Property(e => e.ReqDocument).HasColumnType("image");

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.PatientReqDocuments)
                    .HasForeignKey(d => d.PreId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PatientReqDocuments_Patient_Req");
            });

            modelBuilder.Entity<PatientReqE>(entity =>
            {
                entity.HasKey(e => e.PreIdE)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Patient_Req_E");

                entity.Property(e => e.PreIdE).HasColumnName("PRe_Id_E");

                entity.Property(e => e.AddAfp).HasColumnName("AddAFP");

                entity.Property(e => e.BillTo)
                    .HasColumnName("Bill_To")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Blu)
                    .HasColumnName("BLU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Completed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateSpecimenRecvd).HasColumnType("datetime");

                entity.Property(e => e.DeletedTestsCodes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DirId).HasColumnName("Dir_Id");

                entity.Property(e => e.DrAccno)
                    .HasColumnName("Dr_Accno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fasting)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Grn)
                    .HasColumnName("GRN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Gry)
                    .HasColumnName("GRY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7messageControlId)
                    .HasColumnName("HL7MessageControlID")
                    .HasMaxLength(1000);

                entity.Property(e => e.Hl7sendDate)
                    .HasColumnName("HL7sendDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsGroupNo)
                    .HasColumnName("Ins_Group_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId1).HasColumnName("Ins_ID1");

                entity.Property(e => e.InsId2).HasColumnName("Ins_ID2");

                entity.Property(e => e.InsId3).HasColumnName("Ins_ID3");

                entity.Property(e => e.InsNo1)
                    .HasColumnName("Ins_No1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNo2)
                    .HasColumnName("Ins_No2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNo3)
                    .HasColumnName("Ins_No3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsFinal).HasColumnName("isFinal");

                entity.Property(e => e.IsHl7).HasColumnName("isHL7");

                entity.Property(e => e.IsPdf).HasColumnName("isPdf");

                entity.Property(e => e.IsPdfDate)
                    .HasColumnName("isPdfDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsSpecimenVerified)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lav)
                    .HasColumnName("LAV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Oth)
                    .HasColumnName("OTH")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaId).HasColumnName("Pa_ID");

                entity.Property(e => e.PatComments)
                    .HasColumnName("Pat_Comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PatId).HasColumnName("Pat_ID");

                entity.Property(e => e.PatientNotes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PreAccDate)
                    .HasColumnName("PRe_AccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreAccNo).HasColumnName("PRe_AccNo");

                entity.Property(e => e.PreDocId).HasColumnName("PRe_DocID");

                entity.Property(e => e.PreDocId1)
                    .HasColumnName("PRe_DocID1")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PreDocId2)
                    .HasColumnName("PRe_DocID2")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PreDocId3)
                    .HasColumnName("PRe_DocID3")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PreDrawnDate)
                    .HasColumnName("PRe_DrawnDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreRecDate)
                    .HasColumnName("PRe_RecDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreReqNo)
                    .HasColumnName("PRe_ReqNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreSpType)
                    .HasColumnName("PRe_SpType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pregnant)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Printed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Psc).HasColumnName("PSC");

                entity.Property(e => e.Race)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Red)
                    .HasColumnName("RED")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RefLabComments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RelClinicalInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepComments)
                    .HasColumnName("Rep_Comments")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("Report_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportIntDate)
                    .HasColumnName("Report_IntDate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportLstDate)
                    .HasColumnName("Report_LstDate")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelfInsured)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo)
                    .HasColumnName("Site_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sst)
                    .HasColumnName("SST")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sto)
                    .HasColumnName("STO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Swa)
                    .HasColumnName("SWA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TempPreAccno).HasColumnName("TempPre_Accno");

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaHl7).HasColumnName("ViaHL7");

                entity.Property(e => e.WsComments)
                    .HasColumnName("WS_Comments")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientReqOtherInfo>(entity =>
            {
                entity.HasKey(e => e.PrOiId);

                entity.ToTable("PatientReq_OtherInfo");

                entity.HasIndex(e => e.PreId)
                    .HasName("IX_PatientReq_OtherInfo");

                entity.Property(e => e.PrOiId).HasColumnName("PR_OI_Id");

                entity.Property(e => e.BlhispanicHeritage)
                    .HasColumnName("BLHispanicHeritage")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Clsource)
                    .HasColumnName("CLSource")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.Zblcountry)
                    .HasColumnName("ZBLCountry")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zblpurpose)
                    .HasColumnName("ZBLPurpose")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zbltype)
                    .HasColumnName("ZBLType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZciHeightInch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZciVquantity)
                    .HasColumnName("ZciVQuantity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZciVquantityUom)
                    .HasColumnName("ZciVQuantityUOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZciVweightOunce)
                    .HasColumnName("ZciVWeightOunce")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZciWeightPound)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZciWeightUom)
                    .HasColumnName("ZciWeightUOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyAllOtherPat)
                    .HasColumnName("ZcyAll_Other_Pat")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyAtypical)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyBroomAlone)
                    .HasColumnName("ZcyBroom_Alone")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyBrushAlone)
                    .HasColumnName("ZcyBrush_Alone")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyBrushSpatula)
                    .HasColumnName("ZcyBrush_Spatula")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyCaInSitu)
                    .HasColumnName("ZcyCa_In_Situ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyCervical)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyColpBx)
                    .HasColumnName("ZcyColp_BX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyConiza)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyCyro)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyDatesResult)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyDysplasia)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyEndocervical)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyEndometrial)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyEstroRx)
                    .HasColumnName("ZcyEstro_RX")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyHyst)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyInvasive)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyIud)
                    .HasColumnName("ZcyIUD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyLabiaVulva)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyLactating)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyLaserVap)
                    .HasColumnName("ZcyLaser_Vap")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyLmpdate)
                    .HasColumnName("ZcyLMPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZcyMenopausal)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyNegative)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyNone)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyOralContraceptives)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyOtherCollTech)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyPmpBleeding)
                    .HasColumnName("ZcyPMP_Bleeding")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyPostPart)
                    .HasColumnName("ZcyPost_Part")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyPrevCytoInfo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyRadiation)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcySpatulaAlone)
                    .HasColumnName("ZcySpatula_Alone")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcySwabSpatula)
                    .HasColumnName("ZcySwab_Spatula")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZcyVaginal)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaadditionalInfo)
                    .HasColumnName("ZSAAdditionalInfo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaadvanceMaternalAge)
                    .HasColumnName("ZSAAdvanceMaternalAge")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaageDate)
                    .HasColumnName("ZSAAgeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZsaageDays)
                    .HasColumnName("ZSAAgeDays")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaageInDecimal)
                    .HasColumnName("ZSAAgeInDecimal")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaageWeeks)
                    .HasColumnName("ZSAAgeWeeks")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaeddEdc)
                    .HasColumnName("ZSAEDD_EDC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaeddEdcdate)
                    .HasColumnName("ZSAEDD_EDCDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZsafetusNo)
                    .HasColumnName("ZSAFetusNo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsahisCysticFibrosis)
                    .HasColumnName("ZSAHisCysticFibrosis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsahisDownSyndrome)
                    .HasColumnName("ZSAHisDownSyndrome")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsainsulinDep)
                    .HasColumnName("ZSAInsulinDep")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zsalmp)
                    .HasColumnName("ZSALMP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zsalmpdate)
                    .HasColumnName("ZSALMPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZsaotherIndications)
                    .HasColumnName("ZSAOtherIndications")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsapreEval)
                    .HasColumnName("ZSAPreEval")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsapreNeuralTubeDefects)
                    .HasColumnName("ZSAPreNeuralTubeDefects")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsareasonRepeatEarlyGa)
                    .HasColumnName("ZSAReasonRepeatEarlyGA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsareasonRepeatHemolyzed)
                    .HasColumnName("ZSAReasonRepeatHemolyzed")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsarouteScreening)
                    .HasColumnName("ZSARouteScreening")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zsaultrasond)
                    .HasColumnName("ZSAUltrasond")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZsaultrasoundDate)
                    .HasColumnName("ZSAUltrasoundDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.PatientReqOtherInfo)
                    .HasForeignKey(d => d.PreId)
                    .HasConstraintName("FK_PatientReq_OtherInfo_Patient_Req");
            });

            modelBuilder.Entity<PatientReqTest>(entity =>
            {
                entity.HasKey(e => e.PrtId);

                entity.ToTable("PatientReq_Test");

                entity.HasIndex(e => e.PreId)
                    .HasName("IX_PatientReq_Test_1");

                entity.HasIndex(e => e.TgpsCode)
                    .HasName("IX_PatientReq_Test_4");

                entity.HasIndex(e => e.TgpsId)
                    .HasName("IX_PatientReq_Test");

                entity.HasIndex(e => new { e.PreId, e.TgpsId })
                    .HasName("IX_PatientReq_Test_3");

                entity.HasIndex(e => new { e.PrtType, e.PreId })
                    .HasName("IX_PatientReq_Test_2");

                entity.HasIndex(e => new { e.TgpsCode, e.PreId })
                    .HasName("IX_PatientReq_Test_6");

                entity.HasIndex(e => new { e.TgpsCode, e.PrtId })
                    .HasName("IX_PatientReq_Test_5");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Labperformed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.PrtType)
                    .IsRequired()
                    .HasColumnName("PRT_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Prtidu).HasColumnName("PRTIDU");

                entity.Property(e => e.TgpsCode).HasColumnName("TGPS_Code");

                entity.Property(e => e.TgpsId).HasColumnName("TGPS_Id");

                entity.Property(e => e.TgpsName)
                    .HasColumnName("TGPS_Name")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsType)
                    .IsRequired()
                    .HasColumnName("TGPS_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pre)
                    .WithMany(p => p.PatientReqTest)
                    .HasForeignKey(d => d.PreId)
                    .HasConstraintName("FK_PatientReq_Test_Patient_Req");
            });

            modelBuilder.Entity<PatientReqTestE>(entity =>
            {
                entity.HasKey(e => e.PrtId);

                entity.ToTable("PatientReq_Test_E");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.PrtType)
                    .HasColumnName("PRT_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsCode)
                    .HasColumnName("TGPS_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsId).HasColumnName("TGPS_Id");

                entity.Property(e => e.TgpsName)
                    .HasColumnName("TGPS_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsType)
                    .HasColumnName("TGPS_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientReqTestU>(entity =>
            {
                entity.HasKey(e => e.PrtId);

                entity.ToTable("PatientReq_Test_U");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.PrtType)
                    .HasColumnName("PRT_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsCode)
                    .HasColumnName("TGPS_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsId).HasColumnName("TGPS_Id");

                entity.Property(e => e.TgpsName)
                    .HasColumnName("TGPS_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsType)
                    .HasColumnName("TGPS_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientReqTestUnMap>(entity =>
            {
                entity.HasKey(e => e.PrtId);

                entity.ToTable("PatientReq_Test_UnMap");

                entity.Property(e => e.PrtId).HasColumnName("PRT_Id");

                entity.Property(e => e.Labperformed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreId).HasColumnName("PRe_Id");

                entity.Property(e => e.PrtType)
                    .IsRequired()
                    .HasColumnName("PRT_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsCode)
                    .IsRequired()
                    .HasColumnName("TGPS_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsId).HasColumnName("TGPS_Id");

                entity.Property(e => e.TgpsName)
                    .HasColumnName("TGPS_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TgpsType)
                    .IsRequired()
                    .HasColumnName("TGPS_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientUnSpecefied>(entity =>
            {
                entity.HasKey(e => e.PaId);

                entity.ToTable("Patient_UnSpecefied");

                entity.Property(e => e.PaId).HasColumnName("Pa_Id");

                entity.Property(e => e.AccessionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsId).HasColumnName("InsID");

                entity.Property(e => e.InsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Lab)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaAddress)
                    .HasColumnName("Pa_Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaChartNo)
                    .HasColumnName("Pa_ChartNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaEmail)
                    .HasColumnName("Pa_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaFax)
                    .HasColumnName("Pa_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaPhone)
                    .HasColumnName("Pa_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaSex)
                    .HasColumnName("Pa_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaSsn)
                    .HasColumnName("Pa_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PreAccDate)
                    .HasColumnName("PRe_AccDate")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Preid)
                    .HasColumnName("PREID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ZipId).HasColumnName("Zip_ID");
            });

            modelBuilder.Entity<PatSchedule>(entity =>
            {
                entity.HasKey(e => e.Psid);

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.PsDate)
                    .HasColumnName("PS_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PsDia1)
                    .HasColumnName("PS_Dia1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PsDia2)
                    .HasColumnName("PS_Dia2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PsDia3)
                    .HasColumnName("PS_Dia3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PsDia4)
                    .HasColumnName("PS_Dia4")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PsDia5)
                    .HasColumnName("PS_Dia5")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PsInsGroupNo)
                    .HasColumnName("PS_InsGroupNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsIsActive).HasColumnName("PS_IsActive");

                entity.Property(e => e.PsPatAddress)
                    .HasColumnName("PS_PatAddress")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatChartNo)
                    .HasColumnName("PS_PatChartNo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatDob)
                    .HasColumnName("PS_PatDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.PsPatDocId).HasColumnName("PS_PatDoc_ID");

                entity.Property(e => e.PsPatFax)
                    .HasColumnName("PS_PatFax")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatFirstName)
                    .HasColumnName("PS_PatFirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatId)
                    .HasColumnName("PS_PatID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatInsId1).HasColumnName("PS_PatIns_ID1");

                entity.Property(e => e.PsPatInsId2).HasColumnName("PS_PatIns_ID2");

                entity.Property(e => e.PsPatInsNo1)
                    .HasColumnName("PS_PatInsNo1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatInsNo2)
                    .HasColumnName("PS_PatInsNo2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatLastName)
                    .HasColumnName("PS_PatLastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatSex)
                    .HasColumnName("PS_PatSex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PsPatTel)
                    .HasColumnName("PS_PatTel")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PsRemarks)
                    .HasColumnName("PS_Remarks")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PsRoom)
                    .HasColumnName("PS_Room")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsStatus)
                    .HasColumnName("PS_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsWardRoom)
                    .HasColumnName("PS_WardRoom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PsZipId).HasColumnName("PS_Zip_ID");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.PatSchedule)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("FK_PatSchedule_Site");
            });

            modelBuilder.Entity<PatScheduleTest>(entity =>
            {
                entity.HasKey(e => e.PstId);

                entity.ToTable("PatSchedule_Test");

                entity.Property(e => e.PstId).HasColumnName("PST_ID");

                entity.Property(e => e.Fcode)
                    .HasColumnName("FCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.PsId).HasColumnName("PS_ID");

                entity.Property(e => e.PstEndDate)
                    .HasColumnName("PST_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PstLastSceduled)
                    .HasColumnName("PST_LastSceduled")
                    .HasColumnType("datetime");

                entity.Property(e => e.PstStartDate)
                    .HasColumnName("PST_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PstStatus)
                    .HasColumnName("PST_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestTube)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.F)
                    .WithMany(p => p.PatScheduleTest)
                    .HasForeignKey(d => d.Fid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PatSchedule_Test_Frequency");

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.PatScheduleTest)
                    .HasForeignKey(d => d.PsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PatSchedule_Test_PatSchedule");
            });

            modelBuilder.Entity<PayerDictionaryUpdate>(entity =>
            {
                entity.HasKey(e => e.InsuranceUpdateId);

                entity.Property(e => e.InsuranceUpdateId).HasColumnName("InsuranceUpdateID");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfUpdate)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PracAdditionalTest>(entity =>
            {
                entity.HasKey(e => e.PracAddTestDetailsId);

                entity.ToTable("Prac_AdditionalTest");

                entity.Property(e => e.PracAddTestDetailsId).HasColumnName("PracAddTestDetailsID");

                entity.Property(e => e.AdditionalTestDetails).IsUnicode(false);
            });

            modelBuilder.Entity<PracCat>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("Prac_Cat");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.CatId).HasColumnName("Cat_id");

                entity.Property(e => e.PracId).HasColumnName("Prac_ID");
            });

            modelBuilder.Entity<PracDoc>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("Prac_Doc");

                entity.HasIndex(e => e.DocId)
                    .HasName("IX_PracDoc_DocID");

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.PracId).HasColumnName("Prac_Id");
            });

            modelBuilder.Entity<Practice>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.Property(e => e.Pkid).HasColumnName("pkid");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.IsIcdonReport).HasColumnName("IsICDOnReport");

                entity.Property(e => e.IsSendToRefDoctor).HasColumnName("IsSendToRef_Doctor");

                entity.Property(e => e.NoOfCopies)
                    .HasColumnName("No_Of_Copies")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OtherPractice)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Paddress)
                    .HasColumnName("PAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatInfoSheet).HasColumnName("Pat_Info_Sheet");

                entity.Property(e => e.PatLetter).HasColumnName("Pat_Letter");

                entity.Property(e => e.PatLetterType)
                    .HasColumnName("Pat_Letter_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdeclaimer)
                    .HasColumnName("PDeclaimer")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PinstructionsforReviewingPathologist)
                    .HasColumnName("PInstructionsforReviewingPathologist")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("PName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PnameOnReport)
                    .HasColumnName("PNameOnReport")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ppassword)
                    .HasColumnName("PPassword")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PracCell)
                    .HasColumnName("Prac_Cell")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PracFax)
                    .HasColumnName("Prac_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PracPhone)
                    .HasColumnName("Prac_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PracStatus)
                    .HasColumnName("Prac_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrLetter).HasColumnName("Ref_Dr_Letter");

                entity.Property(e => e.ZipId).HasColumnName("Zip_ID");
            });

            modelBuilder.Entity<PracticeAutoRemotePrintLog>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("Practice_AutoRemotePrintLog");

                entity.Property(e => e.PkId).HasColumnName("Pk_ID");

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasColumnName("Acc_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoPrintCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocCode).HasColumnName("Doc_Code");

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasColumnName("Doc_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("File_Name");

                entity.Property(e => e.FileSize).HasColumnName("File_Size");

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeName)
                    .HasColumnName("Practice_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintJobId)
                    .HasColumnName("Print_JobID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatus)
                    .HasColumnName("Print_Status")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintTime)
                    .HasColumnName("Print_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Prices>(entity =>
            {
                entity.HasKey(e => e.PrId);

                entity.Property(e => e.PrId)
                    .HasColumnName("Pr_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PrIndex)
                    .HasColumnName("Pr_Index")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TgrCode)
                    .HasColumnName("TGr_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TgrId)
                    .HasColumnName("TGr_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TgrPrice).HasColumnName("TGr_Price");

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrintLog>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("Print_Log");

                entity.Property(e => e.PkId)
                    .HasColumnName("Pk_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasColumnName("Acc_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AutoPrintCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocCode)
                    .HasColumnName("Doc_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasColumnName("Doc_Name")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("File_Name");

                entity.Property(e => e.FileSize).HasColumnName("File_Size");

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintJobId)
                    .HasColumnName("Print_JobID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrintStatus)
                    .HasColumnName("Print_Status")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintTime)
                    .HasColumnName("Print_Time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Procedures>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.Property(e => e.ProId)
                    .HasColumnName("Pro_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.ProCode)
                    .HasColumnName("Pro_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProDescription)
                    .HasColumnName("Pro_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProName)
                    .HasColumnName("Pro_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfileDetail>(entity =>
            {
                entity.HasKey(e => e.ProDId);

                entity.ToTable("Profile_Detail");

                entity.HasIndex(e => e.ProId)
                    .HasName("IX_Profile_DetailProId");

                entity.HasIndex(e => e.TestGrId)
                    .HasName("IX_Profile_DetailGrpID");

                entity.Property(e => e.ProDId)
                    .HasColumnName("ProD_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.TestGrCode)
                    .HasColumnName("TestGr_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestGrId)
                    .HasColumnName("TestGr_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestGrType)
                    .HasColumnName("TestGr_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.ProfileDetail)
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Profile_Detail_Profile");
            });

            modelBuilder.Entity<ProfileTestRefLabMapping>(entity =>
            {
                entity.HasKey(e => e.ProfileRefLabId);

                entity.Property(e => e.ProfileRefLabId).HasColumnName("ProfileRefLabID");

                entity.Property(e => e.ClId).HasColumnName("CL_Id");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");
            });

            modelBuilder.Entity<Qcmain>(entity =>
            {
                entity.ToTable("QCMain");

                entity.HasIndex(e => e.LotNo)
                    .HasName("IX_QCMain");

                entity.HasIndex(e => new { e.LotNo, e.QcmainId })
                    .HasName("IX_QCMain_1");

                entity.Property(e => e.QcmainId).HasColumnName("QCMain_ID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Qctest>(entity =>
            {
                entity.ToTable("QCTest");

                entity.HasIndex(e => e.QcmainId)
                    .HasName("IX_QCTest_1");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_QCTest");

                entity.HasIndex(e => new { e.QcmainId, e.QctestId })
                    .HasName("IX_QCTest_2");

                entity.HasIndex(e => new { e.QcmainId, e.TestId })
                    .HasName("IX_QCTest_4");

                entity.HasIndex(e => new { e.TestId, e.QctestId })
                    .HasName("IX_QCTest_3");

                entity.Property(e => e.QctestId).HasColumnName("QCTestID");

                entity.Property(e => e.LotNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QcXAxisValue)
                    .HasColumnName("QC_X_AxisValue")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.QcYAxisValue)
                    .HasColumnName("QC_Y_AxisValue")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.QcmainId).HasColumnName("QCMainID");

                entity.Property(e => e.StandardCv)
                    .HasColumnName("StandardCV")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.StandardMean).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.StandardNormal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StandardSd)
                    .HasColumnName("StandardSD")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.StarndardHigh).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.StarndardLow).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.TestId).HasColumnName("Test_Id");

                entity.Property(e => e.TestName)
                    .IsRequired()
                    .HasColumnName("Test_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TestShortName)
                    .IsRequired()
                    .HasColumnName("TestShort_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Qcmain)
                    .WithMany(p => p.Qctest)
                    .HasForeignKey(d => d.QcmainId)
                    .HasConstraintName("FK_QCTest_QCMain");
            });

            modelBuilder.Entity<QctestResult>(entity =>
            {
                entity.ToTable("QCTestResult");

                entity.HasIndex(e => new { e.QctestId, e.QctestResultId })
                    .HasName("IX_QCTestResult");

                entity.Property(e => e.QctestResultId).HasColumnName("QCTestResultID");

                entity.Property(e => e.LotNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QcmainId).HasColumnName("QCMainID");

                entity.Property(e => e.QctestId).HasColumnName("QCTestID");

                entity.Property(e => e.Result).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.ResultCharater)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResultDate).HasColumnType("datetime");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Qcmain)
                    .WithMany(p => p.QctestResult)
                    .HasForeignKey(d => d.QcmainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QCTestResult_QCMain");

                entity.HasOne(d => d.Qctest)
                    .WithMany(p => p.QctestResult)
                    .HasForeignKey(d => d.QctestId)
                    .HasConstraintName("FK_QCTestResult_QCTest");
            });

            modelBuilder.Entity<QuestResultLabCodes>(entity =>
            {
                entity.HasKey(e => e.ResultTestId);

                entity.Property(e => e.ResultTestId).HasColumnName("ResultTestID");

                entity.Property(e => e.Loinc)
                    .HasColumnName("LOINC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTestCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTestName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResultName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestTests>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.Property(e => e.RaceId)
                    .HasColumnName("Race_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RaceDescription)
                    .HasColumnName("Race_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefClinicLab>(entity =>
            {
                entity.HasKey(e => e.ClId);

                entity.ToTable("Ref_Clinic_Lab");

                entity.HasIndex(e => e.ZipId)
                    .HasName("IX_Ref_Clinic_LabZip");

                entity.Property(e => e.ClId).HasColumnName("CL_Id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClAddress)
                    .HasColumnName("CL_Address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClCode)
                    .HasColumnName("CL_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClContactPerson)
                    .HasColumnName("CL_ContactPerson")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClDescription)
                    .HasColumnName("CL_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClEmail)
                    .HasColumnName("CL_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClFax)
                    .HasColumnName("CL_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClName)
                    .HasColumnName("CL_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClPhone)
                    .HasColumnName("CL_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClSign)
                    .HasColumnName("CL_Sign")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClType)
                    .HasColumnName("CL_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7OrderPath)
                    .HasColumnName("HL7_OrderPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7ResultPath)
                    .HasColumnName("HL7_ResultPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestPrefix).HasMaxLength(20);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");
            });

            modelBuilder.Entity<RefDocSpIns>(entity =>
            {
                entity.ToTable("RefDoc_Sp_Ins");

                entity.Property(e => e.RefDocSpInsId).HasColumnName("RefDocSpInsID");

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.TestId).HasColumnName("TestID");
            });

            modelBuilder.Entity<RefDocSpTest>(entity =>
            {
                entity.ToTable("RefDoc_Sp_Test");

                entity.Property(e => e.RefDocSpTestId).HasColumnName("RefDocSpTestID");

                entity.Property(e => e.Amount)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.TgspCode)
                    .HasColumnName("TGSP_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TgspId).HasColumnName("TGSP_ID");

                entity.Property(e => e.TgspName)
                    .HasColumnName("TGSP_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TgspType)
                    .HasColumnName("TGSP_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefDoctor>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("Ref_Doctor");

                entity.HasIndex(e => e.DocCode)
                    .HasName("IX_Ref_DoctorCode");

                entity.HasIndex(e => e.DocSsn)
                    .HasName("IX_Ref_DoctorSSN");

                entity.HasIndex(e => new { e.DocCode, e.DocId })
                    .HasName("IX_Ref_Doctor_1");

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.AterNo)
                    .HasColumnName("Ater_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeeperNo)
                    .HasColumnName("Beeper_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompRp).HasColumnName("Comp_Rp");

                entity.Property(e => e.DocAddress)
                    .HasColumnName("Doc_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocCode)
                    .HasColumnName("Doc_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocDescription)
                    .HasColumnName("Doc_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocEmail)
                    .HasColumnName("Doc_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocFax)
                    .HasColumnName("Doc_Fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocMobileNo)
                    .HasColumnName("Doc_MobileNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocSex)
                    .HasColumnName("Doc_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocSsn)
                    .HasColumnName("Doc_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorStatus)
                    .HasColumnName("Doctor_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7OrderPath)
                    .HasColumnName("HL7_OrderPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7ResultPath)
                    .HasColumnName("HL7_ResultPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IncludeAbnormalResults).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeInSummaryRep).HasDefaultValueSql("((0))");

                entity.Property(e => e.Includeadditionaltest).HasColumnName("includeadditionaltest");

                entity.Property(e => e.IniRepSet)
                    .HasColumnName("Ini_Rep_Set")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InterFaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsSendPdf).HasColumnName("IsSendPDF");

                entity.Property(e => e.Isorder).HasColumnName("ISOrder");

                entity.Property(e => e.LastAccessed).HasColumnType("datetime");

                entity.Property(e => e.LicenceNo)
                    .HasColumnName("Licence_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaIdNo)
                    .HasColumnName("MedicaId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareIdNo)
                    .HasColumnName("MedicareId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModemNo)
                    .HasColumnName("Modem_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nipnumber)
                    .HasColumnName("NIPNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherDocCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemPrinterNo)
                    .HasColumnName("Rem_Printer_No")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RemotePrinter).HasColumnName("Remote_Printer");

                entity.Property(e => e.RemotePrinter1)
                    .HasColumnName("RemotePrinter")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RouteNo)
                    .HasColumnName("Route_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sal2AcDate).HasColumnType("datetime");

                entity.Property(e => e.Sal2Comm).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Sal2Id).HasColumnName("Sal2_Id");

                entity.Property(e => e.Sal3AcDate).HasColumnType("datetime");

                entity.Property(e => e.Sal3Comm).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Sal3Id).HasColumnName("Sal3_Id");

                entity.Property(e => e.SalAcDate).HasColumnType("datetime");

                entity.Property(e => e.SalComm).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SalId).HasColumnName("Sal_Id");

                entity.Property(e => e.SpOption)
                    .HasColumnName("Sp_Option")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest)
                    .HasColumnName("Special_Test")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpinNo)
                    .HasColumnName("UPIN_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");
            });

            modelBuilder.Entity<RefDoctorAdditionalTest>(entity =>
            {
                entity.HasKey(e => e.RefDocAddTestId);

                entity.ToTable("Ref_Doctor_AdditionalTest");

                entity.Property(e => e.RefDocAddTestId).HasColumnName("RefDocAddTestID");

                entity.Property(e => e.AdditionalTest)
                    .HasMaxLength(7500)
                    .IsUnicode(false);

                entity.Property(e => e.AdocId).HasColumnName("ADoc_Id");

                entity.Property(e => e.Type).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Adoc)
                    .WithMany(p => p.RefDoctorAdditionalTest)
                    .HasForeignKey(d => d.AdocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ref_Doctor_AdditionalTest_Ref_Doctor");
            });

            modelBuilder.Entity<RefDoctorOld>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("Ref_Doctor_Old");

                entity.Property(e => e.DocId)
                    .HasColumnName("Doc_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AterNo)
                    .HasColumnName("Ater_No")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BeeperNo)
                    .HasColumnName("Beeper_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompRp).HasColumnName("Comp_Rp");

                entity.Property(e => e.DocAddress)
                    .HasColumnName("Doc_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocCode)
                    .HasColumnName("Doc_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocDescription)
                    .HasColumnName("Doc_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocEmail)
                    .HasColumnName("Doc_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocFax)
                    .HasColumnName("Doc_Fax")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocMobileNo)
                    .HasColumnName("Doc_MobileNo")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocSex)
                    .HasColumnName("Doc_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocSsn)
                    .HasColumnName("Doc_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IniRepSet)
                    .HasColumnName("Ini_Rep_Set")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicenceNo)
                    .HasColumnName("Licence_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaIdNo)
                    .HasColumnName("MedicaId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareIdNo)
                    .HasColumnName("MedicareId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModemNo)
                    .HasColumnName("Modem_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemPrinterNo)
                    .HasColumnName("Rem_Printer_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RemotePrinter).HasColumnName("Remote_Printer");

                entity.Property(e => e.RouteNo)
                    .HasColumnName("Route_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalId)
                    .HasColumnName("Sal_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpOption)
                    .HasColumnName("Sp_Option")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest)
                    .HasColumnName("Special_Test")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpinNo)
                    .HasColumnName("UPIN_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .HasColumnName("Zip_Id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<RefDoctorOld2>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("Ref_Doctor_old_2");

                entity.Property(e => e.DocId)
                    .HasColumnName("Doc_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AterNo)
                    .HasColumnName("Ater_No")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BeeperNo)
                    .HasColumnName("Beeper_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompRp).HasColumnName("Comp_Rp");

                entity.Property(e => e.DocAddress)
                    .HasColumnName("Doc_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocCode)
                    .HasColumnName("Doc_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocDescription)
                    .HasColumnName("Doc_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DocEmail)
                    .HasColumnName("Doc_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocFax)
                    .HasColumnName("Doc_Fax")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocFirstName)
                    .HasColumnName("Doc_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocLastName)
                    .HasColumnName("Doc_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocMobileNo)
                    .HasColumnName("Doc_MobileNo")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocPhone)
                    .HasColumnName("Doc_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DocSex)
                    .HasColumnName("Doc_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocSsn)
                    .HasColumnName("Doc_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IniRepSet)
                    .HasColumnName("Ini_Rep_Set")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LicenceNo)
                    .HasColumnName("Licence_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicaIdNo)
                    .HasColumnName("MedicaId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicareIdNo)
                    .HasColumnName("MedicareId_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModemNo)
                    .HasColumnName("Modem_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemPrinterNo)
                    .HasColumnName("Rem_Printer_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RemotePrinter).HasColumnName("Remote_Printer");

                entity.Property(e => e.RouteNo)
                    .HasColumnName("Route_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalId)
                    .HasColumnName("Sal_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SpOption)
                    .HasColumnName("Sp_Option")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest)
                    .HasColumnName("Special_Test")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpinNo)
                    .HasColumnName("UPIN_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .HasColumnName("Zip_Id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Reflab>(entity =>
            {
                entity.HasKey(e => e.RefLabno);

                entity.ToTable("reflab");

                entity.Property(e => e.RefLabno)
                    .HasColumnName("ref_labno")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LabName)
                    .IsRequired()
                    .HasColumnName("lab_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LabSign)
                    .IsRequired()
                    .HasColumnName("lab_sign")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Relations>(entity =>
            {
                entity.HasKey(e => e.RelationId);

                entity.Property(e => e.RelationId).HasColumnName("RelationID");

                entity.Property(e => e.IsFavorite)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelationDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemotePrintingData>(entity =>
            {
                entity.HasKey(e => e.RemotePrintingDataId);

                entity.Property(e => e.RemotePrintingDataId).HasColumnName("RemotePrintingDataID");

                entity.Property(e => e.DisplayField1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayField2)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraValue1)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraValue2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MainValue)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Query)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.TransmittingJobNavigation)
                    .WithMany(p => p.RemotePrintingData)
                    .HasForeignKey(d => d.TransmittingJob)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_RemotePrintingData_TransmittingJob");
            });

            modelBuilder.Entity<ReportSetup>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportTest>(entity =>
            {
                entity.HasKey(e => e.RtId);

                entity.ToTable("Report_Test");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_Report_Test_unq_TestID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReportId, e.TestId })
                    .HasName("IX_Report_Test");

                entity.HasIndex(e => new { e.ReportId, e.TestId, e.Ord })
                    .HasName("IX_Report_Test_1");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportTest)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_Report_Test_ReportSetup");

                entity.HasOne(d => d.Test)
                    .WithOne(p => p.ReportTest)
                    .HasForeignKey<ReportTest>(d => d.TestId)
                    .HasConstraintName("FK_Report_Test_Clinical_Test");
            });

            modelBuilder.Entity<SalesMan>(entity =>
            {
                entity.HasKey(e => e.SalId);

                entity.Property(e => e.SalId).HasColumnName("Sal_Id");

                entity.Property(e => e.SalAddress)
                    .HasColumnName("Sal_Address")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SalCell)
                    .HasColumnName("Sal_Cell")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalCode)
                    .HasColumnName("Sal_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SalComm1)
                    .HasColumnName("Sal_Comm1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalComm2)
                    .HasColumnName("Sal_Comm2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalComm3)
                    .HasColumnName("Sal_Comm3")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SalEmail)
                    .HasColumnName("Sal_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalFax)
                    .HasColumnName("Sal_Fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalFirstName)
                    .HasColumnName("Sal_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalLastName)
                    .HasColumnName("Sal_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalPhone)
                    .HasColumnName("Sal_Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalRemark)
                    .HasColumnName("Sal_Remark")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SalSsn)
                    .HasColumnName("Sal_SSN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");
            });

            modelBuilder.Entity<Shape>(entity =>
            {
                entity.Property(e => e.ShapeId)
                    .HasColumnName("Shape_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShapeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShielCompendiumT>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Shiel_Compendium_T");

                entity.Property(e => e.OrderTestName).HasMaxLength(100);

                entity.Property(e => e.ResultTestCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShortcutKeys>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Functionality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeysCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.Saddress)
                    .HasColumnName("SAddress")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Scode)
                    .HasColumnName("SCode")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Scomments)
                    .HasColumnName("SComments")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Sfnumber)
                    .HasColumnName("SFNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasColumnName("SName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stnumber)
                    .HasColumnName("STNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId).HasColumnName("Zip_ID");
            });

            modelBuilder.Entity<SiteIdentifier>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Npi).HasColumnName("NPI");

                entity.Property(e => e.ProviderSiteId)
                    .HasColumnName("ProviderSiteID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateLicense).IsUnicode(false);
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.HasKey(e => e.SpId);

                entity.Property(e => e.SpId).HasColumnName("sp_id");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyCode)
                    .HasColumnName("Specialty_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyName)
                    .HasColumnName("Specialty_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specimen>(entity =>
            {
                entity.HasKey(e => e.SpId);

                entity.Property(e => e.SpId)
                    .HasColumnName("Sp_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SpCode)
                    .HasColumnName("Sp_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SpDescription)
                    .HasColumnName("Sp_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpName)
                    .HasColumnName("Sp_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpTId)
                    .HasColumnName("SpT_Id")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<SpecimenType>(entity =>
            {
                entity.HasKey(e => e.SpTId);

                entity.ToTable("Specimen_Type");

                entity.Property(e => e.SpTId)
                    .HasColumnName("SpT_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SpTDescription)
                    .HasColumnName("SpT_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.Property(e => e.StId).HasColumnName("St_Id");

                entity.Property(e => e.StFullName)
                    .HasColumnName("St_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StName)
                    .HasColumnName("St_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuperProfile>(entity =>
            {
                entity.HasKey(e => e.SproId);

                entity.Property(e => e.SproId).HasColumnName("SPro_ID");

                entity.Property(e => e.SproCode).HasColumnName("SPro_Code");

                entity.Property(e => e.SproDescription)
                    .HasColumnName("SPro_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SproName)
                    .HasColumnName("SPro_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuperProfileDetail>(entity =>
            {
                entity.HasKey(e => e.SpdId);

                entity.ToTable("SuperProfile_Detail");

                entity.HasIndex(e => e.SproId)
                    .HasName("IX_SuperProfile_DetailPro");

                entity.HasIndex(e => e.TgproId)
                    .HasName("IX_SuperProfile_DetailTGPro");

                entity.Property(e => e.SpdId).HasColumnName("SPD_Id");

                entity.Property(e => e.SproId).HasColumnName("SPro_Id");

                entity.Property(e => e.TgproCode)
                    .HasColumnName("TGPro_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TgproId)
                    .HasColumnName("TGPro_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TgproType)
                    .HasColumnName("TGPro_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Spro)
                    .WithMany(p => p.SuperProfileDetail)
                    .HasForeignKey(d => d.SproId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SuperProfile_Detail_SuperProfile");
            });

            modelBuilder.Entity<SuperProfileTestRefLabMapping>(entity =>
            {
                entity.HasKey(e => e.SuperProfileRefLabId);

                entity.Property(e => e.SuperProfileRefLabId).HasColumnName("SuperProfileRefLabID");

                entity.Property(e => e.ClId).HasColumnName("CL_Id");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.SproId).HasColumnName("SPro_ID");
            });

            modelBuilder.Entity<SysForms>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("Sys_Forms");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysUserForms>(entity =>
            {
                entity.HasKey(e => new { e.FkUserId, e.FkFormId });

                entity.ToTable("Sys_UserForms");

                entity.Property(e => e.FkUserId).HasColumnName("fkUser_Id");

                entity.Property(e => e.FkFormId)
                    .HasColumnName("fkForm_Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.FkForm)
                    .WithMany(p => p.SysUserForms)
                    .HasForeignKey(d => d.FkFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sys_UserForms_Sys_Forms1");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.SysUserForms)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_Sys_UserForms_Sys_User1");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.Countryid);

                entity.ToTable("tblCountry");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TempPrice>(entity =>
            {
                entity.HasKey(e => e.Priceid);

                entity.ToTable("temp_Price");

                entity.Property(e => e.PrIndex).HasColumnName("pr_index");

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test_Code")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Temprecdate>(entity =>
            {
                entity.HasKey(e => e.Tempid);

                entity.Property(e => e.Tempid).HasColumnName("tempid");

                entity.Property(e => e.RecDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestBilling>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("Test_Billing");

                entity.Property(e => e.Pkid)
                    .HasColumnName("pkid")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillAccount).HasColumnName("Bill_Account");

                entity.Property(e => e.BillIns).HasColumnName("Bill_Ins");

                entity.Property(e => e.BillPpatient).HasColumnName("Bill_PPatient");

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CptCode)
                    .HasColumnName("CPT_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptCombCode)
                    .HasColumnName("CPT_Comb_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptSubstCode)
                    .HasColumnName("CPT_Subst_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CptUnit).HasColumnName("CPT_Unit");

                entity.Property(e => e.McdCode)
                    .HasColumnName("MCD_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.McdCombCode)
                    .HasColumnName("MCD_Comb_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.McdSubstCode)
                    .HasColumnName("MCD_Subst_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.McdUnit).HasColumnName("MCD_Unit");

                entity.Property(e => e.PosMcd)
                    .HasColumnName("POS_MCD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosMcr)
                    .HasColumnName("POS_MCR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosUcf)
                    .HasColumnName("POS_UCF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestCost).HasColumnName("Test_Cost");

                entity.Property(e => e.TestId)
                    .HasColumnName("Test_ID")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TosMcd)
                    .HasColumnName("TOS_MCD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TosMcr)
                    .HasColumnName("TOS_MCR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TosUcf)
                    .HasColumnName("TOS_UCF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestRelatedDiag>(entity =>
            {
                entity.HasKey(e => e.DtId);

                entity.ToTable("Test_Related_Diag");

                entity.Property(e => e.DtId).HasColumnName("DT_ID");

                entity.Property(e => e.DiaId).HasColumnName("Dia_ID");

                entity.Property(e => e.Relevence).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestId)
                    .HasColumnName("Test_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dia)
                    .WithMany(p => p.TestRelatedDiag)
                    .HasForeignKey(d => d.DiaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Test_Related_Diag_Diagnosis");
            });

            modelBuilder.Entity<TestRelatedDiag10>(entity =>
            {
                entity.HasKey(e => e.DtId);

                entity.ToTable("Test_Related_Diag_10");

                entity.Property(e => e.DtId)
                    .HasColumnName("DT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaId).HasColumnName("Dia_ID");

                entity.Property(e => e.Relevence).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestId)
                    .HasColumnName("Test_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dia)
                    .WithMany(p => p.TestRelatedDiag10)
                    .HasForeignKey(d => d.DiaId)
                    .HasConstraintName("FK__Test_Rela__Dia_I__79DF8032");
            });

            modelBuilder.Entity<TestRelatedDiag101>(entity =>
            {
                entity.HasKey(e => e.DtId);

                entity.ToTable("Test_Related_Diag10");

                entity.Property(e => e.DtId).HasColumnName("DT_ID");

                entity.Property(e => e.DiaId).HasColumnName("Dia_ID");

                entity.Property(e => e.Relevence).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestId)
                    .HasColumnName("Test_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestType)
                    .HasColumnName("Test_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dia)
                    .WithMany(p => p.TestRelatedDiag101)
                    .HasForeignKey(d => d.DiaId)
                    .HasConstraintName("FK__Test_Rela__Dia_I__7CBBECDD");
            });

            modelBuilder.Entity<TestResultRange>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.ToTable("Test_Result_Range");

                entity.HasIndex(e => e.TestId)
                    .HasName("idx_testresultrange_testid");

                entity.HasIndex(e => new { e.TestId, e.PkId })
                    .HasName("idx_testresultrange_testid_pkid");

                entity.Property(e => e.PkId).HasColumnName("PK_ID");

                entity.Property(e => e.AgeFrom).HasColumnName("Age_From");

                entity.Property(e => e.AgeTo).HasColumnName("Age_To");

                entity.Property(e => e.FHigh)
                    .HasColumnName("F_High")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FLow)
                    .HasColumnName("F_Low")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FNormal)
                    .HasColumnName("F_Normal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MHigh)
                    .HasColumnName("M_High")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MLow)
                    .HasColumnName("M_Low")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MNormal)
                    .HasColumnName("M_Normal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("Test_Id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestResultRange)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Test_Result_Range_Clinical_Test");
            });

            modelBuilder.Entity<TestType>(entity =>
            {
                entity.ToTable("testType");

                entity.Property(e => e.TestTypeId).HasColumnName("testTypeID");

                entity.Property(e => e.TestTypeName)
                    .HasColumnName("testTypeName")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransCode)
                    .HasColumnName("Trans_Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasColumnName("Trans_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransmittingJob>(entity =>
            {
                entity.HasKey(e => e.TransmittingJob1);

                entity.Property(e => e.TransmittingJob1).HasColumnName("TransmittingJob");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Query)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ReportBl)
                    .HasColumnName("ReportBL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDcoument)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDll)
                    .HasColumnName("ReportDLL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.StartingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UltimatePatient>(entity =>
            {
                entity.HasKey(e => e.PaId);

                entity.ToTable("Ultimate_Patient");

                entity.Property(e => e.PaId).HasColumnName("Pa_Id");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsCode1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsCode2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsGroupNo)
                    .HasColumnName("Ins_Group_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNo1)
                    .HasColumnName("Ins_No1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsNo2)
                    .HasColumnName("Ins_No2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaAddress)
                    .HasColumnName("Pa_Address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaChartNo)
                    .HasColumnName("Pa_ChartNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaEmail)
                    .HasColumnName("Pa_Email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaFax)
                    .HasColumnName("Pa_Fax")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PaFirstName)
                    .HasColumnName("Pa_FirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaLastName)
                    .HasColumnName("Pa_LastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaMiddleName)
                    .HasColumnName("Pa_MiddleName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaPhone)
                    .HasColumnName("Pa_Phone")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PaSex)
                    .HasColumnName("Pa_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaSsn)
                    .HasColumnName("Pa_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StName)
                    .HasColumnName("ST_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).HasColumnName("Group_id");

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupSecurityLevel).HasColumnName("Group_Security_level");
            });

            modelBuilder.Entity<Vitek>(entity =>
            {
                entity.Property(e => e.VitekId).HasColumnName("VitekID");

                entity.Property(e => e.AccessionNumber)
                    .HasColumnName("Accession Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AntimicrobialCodeA1)
                    .HasColumnName("Antimicrobial Code(a1)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AntimicrobialDescriptionA2)
                    .HasColumnName("Antimicrobial Description(a2)")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ColonyCountCode)
                    .HasColumnName("Colony Count Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColonyCountDesc)
                    .HasColumnName("Colony Count Desc")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ExamId)
                    .HasColumnName("Exam ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsolateCode)
                    .HasColumnName("Isolate Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsolateDescription)
                    .HasColumnName("Isolate Description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MicA3)
                    .HasColumnName("MIC (a3)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismCode)
                    .HasColumnName("Organism Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganismName)
                    .HasColumnName("Organism Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResultA4)
                    .HasColumnName("Result (a4)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestCode)
                    .HasColumnName("Test Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasColumnName("Test Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.Verified).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WorkSheet>(entity =>
            {
                entity.HasKey(e => e.WsId);

                entity.Property(e => e.WsId).HasColumnName("WS_Id");

                entity.Property(e => e.WsCode)
                    .HasColumnName("WS_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WsDescription)
                    .HasColumnName("WS_Description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.WsName)
                    .HasColumnName("WS_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkSheetTest>(entity =>
            {
                entity.HasKey(e => e.WtId);

                entity.ToTable("WorkSheet_Test");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_WorkSheet_Test_3")
                    .IsUnique();

                entity.HasIndex(e => e.WsId)
                    .HasName("IX_WorkSheet_ID");

                entity.HasIndex(e => new { e.WsId, e.TestId })
                    .HasName("IX_WorkSheet_Test_1");

                entity.HasIndex(e => new { e.WtId, e.TestId })
                    .HasName("IX_WS_TestID_WTID");

                entity.HasIndex(e => new { e.WtId, e.WsId })
                    .HasName("IX_WorkSheet_Test_2");

                entity.Property(e => e.WtId).HasColumnName("WT_Id");

                entity.Property(e => e.TestId).HasColumnName("Test_Id");

                entity.Property(e => e.WsCode)
                    .HasColumnName("WS_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WsId).HasColumnName("WS_Id");

                entity.HasOne(d => d.Test)
                    .WithOne(p => p.WorkSheetTest)
                    .HasForeignKey<WorkSheetTest>(d => d.TestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WorkSheet_Test_Clinical_Test");

                entity.HasOne(d => d.Ws)
                    .WithMany(p => p.WorkSheetTest)
                    .HasForeignKey(d => d.WsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_WorkSheet_Test_WorkSheet");
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasKey(e => e.ZipId);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StFullName)
                    .HasColumnName("St_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StId).HasColumnName("St_Id");

                entity.Property(e => e.StName)
                    .HasColumnName("St_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode1)
                    .IsRequired()
                    .HasColumnName("ZipCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ZipCode)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZipCode_City");
            });

            modelBuilder.Entity<ZipCodenew>(entity =>
            {
                entity.HasKey(e => e.ZipId);

                entity.Property(e => e.ZipId).HasColumnName("Zip_Id");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.CityName)
                    .HasColumnName("City_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.StFullName)
                    .HasColumnName("St_FullName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StId).HasColumnName("St_Id");

                entity.Property(e => e.StName)
                    .HasColumnName("St_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}

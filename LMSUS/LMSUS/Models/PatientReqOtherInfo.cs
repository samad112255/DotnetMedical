using System;
using System.Collections.Generic;

namespace LMSUS.Models
{
    public partial class PatientReqOtherInfo
    {
        public long PrOiId { get; set; }
        public long PreId { get; set; }
        public string Clsource { get; set; }
        public string ZciHeightInch { get; set; }
        public string ZciWeightPound { get; set; }
        public string ZciWeightUom { get; set; }
        public string ZciVweightOunce { get; set; }
        public string ZciVquantity { get; set; }
        public string ZciVquantityUom { get; set; }
        public string BlhispanicHeritage { get; set; }
        public string Zbltype { get; set; }
        public string Zblpurpose { get; set; }
        public string Zblcountry { get; set; }
        public string ZsainsulinDep { get; set; }
        public string ZsaageWeeks { get; set; }
        public string ZsaageDays { get; set; }
        public string ZsaageInDecimal { get; set; }
        public DateTime? ZsaageDate { get; set; }
        public string Zsalmp { get; set; }
        public DateTime? Zsalmpdate { get; set; }
        public string Zsaultrasond { get; set; }
        public DateTime? ZsaultrasoundDate { get; set; }
        public string ZsaeddEdc { get; set; }
        public DateTime? ZsaeddEdcdate { get; set; }
        public string ZsafetusNo { get; set; }
        public string ZsarouteScreening { get; set; }
        public string ZsapreNeuralTubeDefects { get; set; }
        public string ZsaadvanceMaternalAge { get; set; }
        public string ZsahisDownSyndrome { get; set; }
        public string ZsahisCysticFibrosis { get; set; }
        public string ZsaotherIndications { get; set; }
        public string ZsaadditionalInfo { get; set; }
        public string ZsapreEval { get; set; }
        public string ZsareasonRepeatEarlyGa { get; set; }
        public string ZsareasonRepeatHemolyzed { get; set; }
        public string ZcyCervical { get; set; }
        public string ZcyEndocervical { get; set; }
        public string ZcyLabiaVulva { get; set; }
        public string ZcyVaginal { get; set; }
        public string ZcyEndometrial { get; set; }
        public string ZcySwabSpatula { get; set; }
        public string ZcyBrushSpatula { get; set; }
        public string ZcySpatulaAlone { get; set; }
        public string ZcyBrushAlone { get; set; }
        public string ZcyBroomAlone { get; set; }
        public string ZcyOtherCollTech { get; set; }
        public DateTime? ZcyLmpdate { get; set; }
        public string ZcyPrevCytoInfo { get; set; }
        public string ZcyDatesResult { get; set; }
        public string ZcyLactating { get; set; }
        public string ZcyOralContraceptives { get; set; }
        public string ZcyMenopausal { get; set; }
        public string ZcyEstroRx { get; set; }
        public string ZcyPmpBleeding { get; set; }
        public string ZcyPostPart { get; set; }
        public string ZcyIud { get; set; }
        public string ZcyAllOtherPat { get; set; }
        public string ZcyNone { get; set; }
        public string ZcyHyst { get; set; }
        public string ZcyConiza { get; set; }
        public string ZcyColpBx { get; set; }
        public string ZcyLaserVap { get; set; }
        public string ZcyCyro { get; set; }
        public string ZcyRadiation { get; set; }
        public string ZcyNegative { get; set; }
        public string ZcyAtypical { get; set; }
        public string ZcyDysplasia { get; set; }
        public string ZcyCaInSitu { get; set; }
        public string ZcyInvasive { get; set; }

        public PatientReq Pre { get; set; }
    }
}

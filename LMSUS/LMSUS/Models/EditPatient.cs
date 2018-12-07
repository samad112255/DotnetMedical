using System;
using System.Collections.Generic;
using System.Linq;

namespace LMSUS.Models
{
    public partial class EditPatient
    {


        // public PatientEditModel PatientEditModel { get; set; }
        public PatientE PatientE { get; set; }
        public PatientReqE PatientReqE { get; set; }
        public Insurance Insurance { get; set; }
        public RefDoctor RefDoctor { get; set; }
        public List<State> States { get; set; }
        public List<City> Cities { get; set; }
        public ZipCode Zipcode { get; set; }
        public State State { get; set; }
        public City City { get; set; }
       // public List<InsuranceDropDownViewModel> Insurances { get; set; }
        //public List<DoctorDropDownViewModel> refDoctors { get; set; }
        public List<TestDropDownViewModel> TestDropDown { get; set; }
        public  List<PatientReqTestE> PatientReqTestEs { get; set; }
    }
}

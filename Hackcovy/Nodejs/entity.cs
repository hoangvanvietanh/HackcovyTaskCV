using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackcovy.Nodejs
{
    class Entity
    {
    }

    public class EmailAndReminder
    {
        public String Email;
        public PrescriptionNodejs Reminder;
    }

    public class UserNodejs
    {
        private String fullName;
        private String email;
        private String pictureProfile;
        private String phoneNumber;
        private String address;
        private String yearOfBirth;
        private String gender;
        private List<PrescriptionNodejs> listReminder;

        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string PictureProfile { get => pictureProfile; set => pictureProfile = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public List<PrescriptionNodejs> ListReminder { get => listReminder; set => listReminder = value; }
        public string Address { get => address; set => address = value; }
        public string YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
    }

    public class PrescriptionNodejs
    {
        private String notes;
        private String emailShare;
        private String diagnostic;
        private String reExamination;
        private String date;
        private List<DrugNodejs> drugs;

        public string Notes { get => notes; set => notes = value; }
        public string Share { get => emailShare; set => emailShare = value; }
        public string Diagnostic { get => diagnostic; set => diagnostic = value; }
        public string ReExamination { get => reExamination; set => reExamination = value; }
        public List<DrugNodejs> Drugs { get => drugs; set => drugs = value; }
        public string Date { get => date; set => date = value; }
    }

    public class DrugNodejs
    {
        private String drugName;
        private String dosage;
        private String time;
        private String amountOfMedicine;
        private String image;
        private String color;

        public string DrugName { get => drugName; set => drugName = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public string Time { get => time; set => time = value; }
        public string AmountOfMedicine { get => amountOfMedicine; set => amountOfMedicine = value; }
        public string Image { get => image; set => image = value; }
        public string Color { get => color; set => color = value; }
    }

    public class HistoryAppointment
    {
        private String date;
        private String time;
        private String status;
        private String specialist;
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Status { get => status; set => status = value; }
        public string Specialist { get => specialist; set => specialist = value; }

    }
}

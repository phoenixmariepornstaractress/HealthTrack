using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var hospital = new Hospital();

            while (true)
            {
                Console.WriteLine("\nHospital Management System");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Add Appointment");
                Console.WriteLine("4. Add Bill");
                Console.WriteLine("5. Add Prescription");
                Console.WriteLine("6. Display Patients");
                Console.WriteLine("7. Display Doctors");
                Console.WriteLine("8. Display Appointments");
                Console.WriteLine("9. Display Bills");
                Console.WriteLine("10. Display Prescriptions");
                Console.WriteLine("11. Delete Patient");
                Console.WriteLine("12. Delete Doctor");
                Console.WriteLine("13. Delete Appointment");
                Console.WriteLine("14. Delete Bill");
                Console.WriteLine("15. Delete Prescription");
                Console.WriteLine("16. Update Patient");
                Console.WriteLine("17. Update Doctor");
                Console.WriteLine("18. Update Appointment");
                Console.WriteLine("19. Update Bill");
                Console.WriteLine("20. Update Prescription");
                Console.WriteLine("21. Search Patients");
                Console.WriteLine("22. Search Doctors");
                Console.WriteLine("23. Search Appointments");
                Console.WriteLine("24. Search Bills");
                Console.WriteLine("25. Search Prescriptions");
                Console.WriteLine("26. View Patient Details");
                Console.WriteLine("27. View Doctor Details");
                Console.WriteLine("28. View Appointment Details");
                Console.WriteLine("29. View Bill Details");
                Console.WriteLine("30. View Prescription Details");
                Console.WriteLine("31. Sort Patients");
                Console.WriteLine("32. Sort Doctors");
                Console.WriteLine("33. Reschedule Appointment");
                Console.WriteLine("34. View Statistics");
                Console.WriteLine("35. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        hospital.AddPatient(CreatePatient());
                        break;
                    case "2":
                        hospital.AddDoctor(CreateDoctor());
                        break;
                    case "3":
                        hospital.AddAppointment(CreateAppointment());
                        break;
                    case "4":
                        hospital.AddBill(CreateBill());
                        break;
                    case "5":
                        hospital.AddPrescription(CreatePrescription());
                        break;
                    case "6":
                        hospital.DisplayPatients();
                        break;
                    case "7":
                        hospital.DisplayDoctors();
                        break;
                    case "8":
                        hospital.DisplayAppointments();
                        break;
                    case "9":
                        hospital.DisplayBills();
                        break;
                    case "10":
                        hospital.DisplayPrescriptions();
                        break;
                    case "11":
                        Console.Write("Enter Patient Name to delete: ");
                        var patientNameToDelete = Console.ReadLine();
                        hospital.DeletePatient(patientNameToDelete);
                        break;
                    case "12":
                        Console.Write("Enter Doctor Name to delete: ");
                        var doctorNameToDelete = Console.ReadLine();
                        hospital.DeleteDoctor(doctorNameToDelete);
                        break;
                    case "13":
                        Console.Write("Enter Patient Name for Appointment to delete: ");
                        var appointmentPatientNameToDelete = Console.ReadLine();
                        hospital.DeleteAppointment(appointmentPatientNameToDelete);
                        break;
                    case "14":
                        Console.Write("Enter Patient Name for Bill to delete: ");
                        var billPatientNameToDelete = Console.ReadLine();
                        hospital.DeleteBill(billPatientNameToDelete);
                        break;
                    case "15":
                        Console.Write("Enter Patient Name for Prescription to delete: ");
                        var prescriptionPatientNameToDelete = Console.ReadLine();
                        hospital.DeletePrescription(prescriptionPatientNameToDelete);
                        break;
                    case "16":
                        Console.Write("Enter Patient Name to update: ");
                        var patientNameToUpdate = Console.ReadLine();
                        hospital.UpdatePatient(patientNameToUpdate);
                        break;
                    case "17":
                        Console.Write("Enter Doctor Name to update: ");
                        var doctorNameToUpdate = Console.ReadLine();
                        hospital.UpdateDoctor(doctorNameToUpdate);
                        break;
                    case "18":
                        Console.Write("Enter Patient Name for Appointment to update: ");
                        var appointmentPatientNameToUpdate = Console.ReadLine();
                        hospital.UpdateAppointment(appointmentPatientNameToUpdate);
                        break;
                    case "19":
                        Console.Write("Enter Patient Name for Bill to update: ");
                        var billPatientNameToUpdate = Console.ReadLine();
                        hospital.UpdateBill(billPatientNameToUpdate);
                        break;
                    case "20":
                        Console.Write("Enter Patient Name for Prescription to update: ");
                        var prescriptionPatientNameToUpdate = Console.ReadLine();
                        hospital.UpdatePrescription(prescriptionPatientNameToUpdate);
                        break;
                    case "21":
                        Console.Write("Enter Patient Name to search: ");
                        var patientNameToSearch = Console.ReadLine();
                        hospital.SearchPatient(patientNameToSearch);
                        break;
                    case "22":
                        Console.Write("Enter Doctor Name to search: ");
                        var doctorNameToSearch = Console.ReadLine();
                        hospital.SearchDoctor(doctorNameToSearch);
                        break;
                    case "23":
                        Console.Write("Enter Patient Name for Appointment to search: ");
                        var appointmentPatientNameToSearch = Console.ReadLine();
                        hospital.SearchAppointment(appointmentPatientNameToSearch);
                        break;
                    case "24":
                        Console.Write("Enter Patient Name for Bill to search: ");
                        var billPatientNameToSearch = Console.ReadLine();
                        hospital.SearchBill(billPatientNameToSearch);
                        break;
                    case "25":
                        Console.Write("Enter Patient Name for Prescription to search: ");
                        var prescriptionPatientNameToSearch = Console.ReadLine();
                        hospital.SearchPrescription(prescriptionPatientNameToSearch);
                        break;
                    case "26":
                        Console.Write("Enter Patient Name to view details: ");
                        var patientNameToView = Console.ReadLine();
                        hospital.ViewPatientDetails(patientNameToView);
                        break;
                    case "27":
                        Console.Write("Enter Doctor Name to view details: ");
                        var doctorNameToView = Console.ReadLine();
                        hospital.ViewDoctorDetails(doctorNameToView);
                        break;
                    case "28":
                        Console.Write("Enter Patient Name for Appointment details: ");
                        var appointmentPatientNameToView = Console.ReadLine();
                        hospital.ViewAppointmentDetails(appointmentPatientNameToView);
                        break;
                    case "29":
                        Console.Write("Enter Patient Name for Bill details: ");
                        var billPatientNameToView = Console.ReadLine();
                        hospital.ViewBillDetails(billPatientNameToView);
                        break;
                    case "30":
                        Console.Write("Enter Patient Name for Prescription details: ");
                        var prescriptionPatientNameToView = Console.ReadLine();
                        hospital.ViewPrescriptionDetails(prescriptionPatientNameToView);
                        break;
                    case "31":
                        hospital.SortPatients();
                        break;
                    case "32":
                        hospital.SortDoctors();
                        break;
                    case "33":
                        Console.Write("Enter Patient Name for Appointment to reschedule: ");
                        var patientNameToReschedule = Console.ReadLine();
                        hospital.RescheduleAppointment(patientNameToReschedule);
                        break;
                    case "34":
                        hospital.ViewStatistics();
                        break;
                    case "35":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static Patient CreatePatient()
        {
            Console.Write("Enter Patient Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Patient Age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient Phone: ");
            var phone = Console.ReadLine();
            return new Patient(name, age, phone);
        }

        static Doctor CreateDoctor()
        {
            Console.Write("Enter Doctor Name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Doctor Specialty: ");
            var specialty = Console.ReadLine();
            return new Doctor(name, specialty);
        }

        static Appointment CreateAppointment()
        {
            Console.Write("Enter Patient Name for Appointment: ");
            var patientName = Console.ReadLine();
            Console.Write("Enter Doctor Name for Appointment: ");
            var doctorName = Console.ReadLine();
            Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
            var date = DateTime.Parse(Console.ReadLine());
            return new Appointment(patientName, doctorName, date);
        }

        static Bill CreateBill()
        {
            Console.Write("Enter Patient Name for Bill: ");
            var patientName = Console.ReadLine();
            Console.Write("Enter Bill Amount: ");
            var amount = decimal.Parse(Console.ReadLine());
            return new Bill(patientName, amount);
        }

        static Prescription CreatePrescription()
        {
            Console.Write("Enter Patient Name for Prescription: ");
            var patientName = Console.ReadLine();
            Console.Write("Enter Prescription Details: ");
            var details = Console.ReadLine();
            return new Prescription(patientName, details);
        }
    }

    class Hospital
    {
        private List<Patient> Patients { get; set; }
        private List<Doctor> Doctors { get; set; }
        private List<Appointment> Appointments { get; set; }
        private List<Bill> Bills { get; set; }
        private List<Prescription> Prescriptions { get; set; }

        public Hospital()
        {
            Patients = new List<Patient>();
            Doctors = new List<Doctor>();
            Appointments = new List<Appointment>();
            Bills = new List<Bill>();
            Prescriptions = new List<Prescription>();
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine("Patient added successfully.");
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine("Doctor added successfully.");
        }

        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
            Console.WriteLine("Appointment added successfully.");
        }

        public void AddBill(Bill bill)
        {
            Bills.Add(bill);
            Console.WriteLine("Bill added successfully.");
        }

        public void AddPrescription(Prescription prescription)
        {
            Prescriptions.Add(prescription);
            Console.WriteLine("Prescription added successfully.");
        }

        public void DisplayPatients()
        {
            Console.WriteLine("\nPatients:");
            foreach (var patient in Patients)
            {
                Console.WriteLine(patient);
            }
        }

        public void DisplayDoctors()
        {
            Console.WriteLine("\nDoctors:");
            foreach (var doctor in Doctors)
            {
                Console.WriteLine(doctor);
            }
        }

        public void DisplayAppointments()
        {
            Console.WriteLine("\nAppointments:");
            foreach (var appointment in Appointments)
            {
                Console.WriteLine(appointment);
            }
        }

        public void DisplayBills()
        {
            Console.WriteLine("\nBills:");
            foreach (var bill in Bills)
            {
                Console.WriteLine(bill);
            }
        }

        public void DisplayPrescriptions()
        {
            Console.WriteLine("\nPrescriptions:");
            foreach (var prescription in Prescriptions)
            {
                Console.WriteLine(prescription);
            }
        }

        public void DeletePatient(string name)
        {
            var patient = Patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (patient != null)
            {
                Patients.Remove(patient);
                Console.WriteLine("Patient deleted successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void DeleteDoctor(string name)
        {
            var doctor = Doctors.FirstOrDefault(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (doctor != null)
            {
                Doctors.Remove(doctor);
                Console.WriteLine("Doctor deleted successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        public void DeleteAppointment(string patientName)
        {
            var appointment = Appointments.FirstOrDefault(a => a.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (appointment != null)
            {
                Appointments.Remove(appointment);
                Console.WriteLine("Appointment deleted successfully.");
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }

        public void DeleteBill(string patientName)
        {
            var bill = Bills.FirstOrDefault(b => b.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (bill != null)
            {
                Bills.Remove(bill);
                Console.WriteLine("Bill deleted successfully.");
            }
            else
            {
                Console.WriteLine("Bill not found.");
            }
        }

        public void DeletePrescription(string patientName)
        {
            var prescription = Prescriptions.FirstOrDefault(p => p.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (prescription != null)
            {
                Prescriptions.Remove(prescription);
                Console.WriteLine("Prescription deleted successfully.");
            }
            else
            {
                Console.WriteLine("Prescription not found.");
            }
        }

        public void UpdatePatient(string name)
        {
            var patient = Patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (patient != null)
            {
                Console.Write("Enter new Patient Age: ");
                patient.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter new Patient Phone: ");
                patient.Phone = Console.ReadLine();
                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void UpdateDoctor(string name)
        {
            var doctor = Doctors.FirstOrDefault(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (doctor != null)
            {
                Console.Write("Enter new Doctor Specialty: ");
                doctor.Specialty = Console.ReadLine();
                Console.WriteLine("Doctor updated successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        public void UpdateAppointment(string patientName)
        {
            var appointment = Appointments.FirstOrDefault(a => a.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (appointment != null)
            {
                Console.Write("Enter new Doctor Name for Appointment: ");
                appointment.DoctorName = Console.ReadLine();
                Console.Write("Enter new Appointment Date (yyyy-mm-dd): ");
                appointment.Date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Appointment updated successfully.");
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }

        public void UpdateBill(string patientName)
        {
            var bill = Bills.FirstOrDefault(b => b.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (bill != null)
            {
                Console.Write("Enter new Bill Amount: ");
                bill.Amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Bill updated successfully.");
            }
            else
            {
                Console.WriteLine("Bill not found.");
            }
        }

        public void UpdatePrescription(string patientName)
        {
            var prescription = Prescriptions.FirstOrDefault(p => p.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (prescription != null)
            {
                Console.Write("Enter new Prescription Details: ");
                prescription.Details = Console.ReadLine();
                Console.WriteLine("Prescription updated successfully.");
            }
            else
            {
                Console.WriteLine("Prescription not found.");
            }
        }

        public void SearchPatient(string name)
        {
            var patient = Patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (patient != null)
            {
                Console.WriteLine(patient);
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void SearchDoctor(string name)
        {
            var doctor = Doctors.FirstOrDefault(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (doctor != null)
            {
                Console.WriteLine(doctor);
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        public void SearchAppointment(string patientName)
        {
            var appointment = Appointments.FirstOrDefault(a => a.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (appointment != null)
            {
                Console.WriteLine(appointment);
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }

        public void SearchBill(string patientName)
        {
            var bill = Bills.FirstOrDefault(b => b.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (bill != null)
            {
                Console.WriteLine(bill);
            }
            else
            {
                Console.WriteLine("Bill not found.");
            }
        }

        public void SearchPrescription(string patientName)
        {
            var prescription = Prescriptions.FirstOrDefault(p => p.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (prescription != null)
            {
                Console.WriteLine(prescription);
            }
            else
            {
                Console.WriteLine("Prescription not found.");
            }
        }

        public void ViewPatientDetails(string name)
        {
            var patient = Patients.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (patient != null)
            {
                Console.WriteLine(patient);
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void ViewDoctorDetails(string name)
        {
            var doctor = Doctors.FirstOrDefault(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (doctor != null)
            {
                Console.WriteLine(doctor);
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        public void ViewAppointmentDetails(string patientName)
        {
            var appointment = Appointments.FirstOrDefault(a => a.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (appointment != null)
            {
                Console.WriteLine(appointment);
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }

        public void ViewBillDetails(string patientName)
        {
            var bill = Bills.FirstOrDefault(b => b.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (bill != null)
            {
                Console.WriteLine(bill);
            }
            else
            {
                Console.WriteLine("Bill not found.");
            }
        }

        public void ViewPrescriptionDetails(string patientName)
        {
            var prescription = Prescriptions.FirstOrDefault(p => p.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (prescription != null)
            {
                Console.WriteLine(prescription);
            }
            else
            {
                Console.WriteLine("Prescription not found.");
            }
        }

        public void SortPatients()
        {
            Patients = Patients.OrderBy(p => p.Name).ToList();
            Console.WriteLine("Patients sorted successfully.");
        }

        public void SortDoctors()
        {
            Doctors = Doctors.OrderBy(d => d.Name).ToList();
            Console.WriteLine("Doctors sorted successfully.");
        }

        public void RescheduleAppointment(string patientName)
        {
            var appointment = Appointments.FirstOrDefault(a => a.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (appointment != null)
            {
                Console.Write("Enter new Appointment Date (yyyy-mm-dd): ");
                appointment.Date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Appointment rescheduled successfully.");
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var hospital = new Hospital();
            var exit = false;

            while (!exit)
            {
                Console.WriteLine("\nHospital Management System");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Add Appointment");
                Console.WriteLine("4. Add Bill");
                Console.WriteLine("5. Add Prescription");
                Console.WriteLine("6. Display Patients");
                Console.WriteLine("7. Display Doctors");
                Console.WriteLine("8. Display Appointments");
                Console.WriteLine("9. Display Bills");
                Console.WriteLine("10. Display Prescriptions");
                Console.WriteLine("11. Delete Patient");
                Console.WriteLine("12. Delete Doctor");
                Console.WriteLine("13. Delete Appointment");
                Console.WriteLine("14. Delete Bill");
                Console.WriteLine("15. Delete Prescription");
                Console.WriteLine("16. Update Patient");
                Console.WriteLine("17. Update Doctor");
                Console.WriteLine("18. Update Appointment");
                Console.WriteLine("19. Update Bill");
                Console.WriteLine("20. Update Prescription");
                Console.WriteLine("21. Search Patient");
                Console.WriteLine("22. Search Doctor");
                Console.WriteLine("23. Search Appointment");
                Console.WriteLine("24. Search Bill");
                Console.WriteLine("25. Search Prescription");
                Console.WriteLine("26. View Patient Details");
                Console.WriteLine("27. View Doctor Details");
                Console.WriteLine("28. View Appointment Details");
                Console.WriteLine("29. View Bill Details");
                Console.WriteLine("30. View Prescription Details");
                Console.WriteLine("31. Sort Patients");
                Console.WriteLine("32. Sort Doctors");
                Console.WriteLine("33. Reschedule Appointment");
                Console.WriteLine("34. Exit");

                Console.Write("\nChoose an option: ");
                var choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Patient Name: ");
                        var patientName = Console.ReadLine();
                        Console.Write("Enter Patient Age: ");
                        var patientAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter Patient Phone: ");
                        var patientPhone = Console.ReadLine();
                        hospital.AddPatient(new Patient(patientName, patientAge, patientPhone));
                        break;

                    case 2:
                        Console.Write("Enter Doctor Name: ");
                        var doctorName = Console.ReadLine();
                        Console.Write("Enter Doctor Specialty: ");
                        var doctorSpecialty = Console.ReadLine();
                        hospital.AddDoctor(new Doctor(doctorName, doctorSpecialty));
                        break;

                    case 3:
                        Console.Write("Enter Patient Name for Appointment: ");
                        var appointmentPatientName = Console.ReadLine();
                        Console.Write("Enter Doctor Name for Appointment: ");
                        var appointmentDoctorName = Console.ReadLine();
                        Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
                        var appointmentDate = DateTime.Parse(Console.ReadLine());
                        hospital.AddAppointment(new Appointment(appointmentPatientName, appointmentDoctorName, appointmentDate));
                        break;

                    case 4:
                        Console.Write("Enter Patient Name for Bill: ");
                        var billPatientName = Console.ReadLine();
                        Console.Write("Enter Bill Amount: ");
                        var billAmount = decimal.Parse(Console.ReadLine());
                        hospital.AddBill(new Bill(billPatientName, billAmount));
                        break;

                    case 5:
                        Console.Write("Enter Patient Name for Prescription: ");
                        var prescriptionPatientName = Console.ReadLine();
                        Console.Write("Enter Prescription Details: ");
                        var prescriptionDetails = Console.ReadLine();
                        hospital.AddPrescription(new Prescription(prescriptionPatientName, prescriptionDetails));
                        break;

                    case 6:
                        hospital.DisplayPatients();
                        break;

                    case 7:
                        hospital.DisplayDoctors();
                        break;

                    case 8:
                        hospital.DisplayAppointments();
                        break;

                    case 9:
                        hospital.DisplayBills();
                        break;

                    case 10:
                        hospital.DisplayPrescriptions();
                        break;

                    case 11:
                        Console.Write("Enter Patient Name to Delete: ");
                        var deletePatientName = Console.ReadLine();
                        hospital.DeletePatient(deletePatientName);
                        break;

                    case 12:
                        Console.Write("Enter Doctor Name to Delete: ");
                        var deleteDoctorName = Console.ReadLine();
                        hospital.DeleteDoctor(deleteDoctorName);
                        break;

                    case 13:
                        Console.Write("Enter Patient Name for Appointment to Delete: ");
                        var deleteAppointmentPatientName = Console.ReadLine();
                        hospital.DeleteAppointment(deleteAppointmentPatientName);
                        break;

                    case 14:
                        Console.Write("Enter Patient Name for Bill to Delete: ");
                        var deleteBillPatientName = Console.ReadLine();
                        hospital.DeleteBill(deleteBillPatientName);
                        break;

                    case 15:
                        Console.Write("Enter Patient Name for Prescription to Delete: ");
                        var deletePrescriptionPatientName = Console.ReadLine();
                        hospital.DeletePrescription(deletePrescriptionPatientName);
                        break;

                    case 16:
                        Console.Write("Enter Patient Name to Update: ");
                        var updatePatientName = Console.ReadLine();
                        hospital.UpdatePatient(updatePatientName);
                        break;

                    case 17:
                        Console.Write("Enter Doctor Name to Update: ");
                        var updateDoctorName = Console.ReadLine();
                        hospital.UpdateDoctor(updateDoctorName);
                        break;

                    case 18:
                        Console.Write("Enter Patient Name for Appointment to Update: ");
                        var updateAppointmentPatientName = Console.ReadLine();
                        hospital.UpdateAppointment(updateAppointmentPatientName);
                        break;

                    case 19:
                        Console.Write("Enter Patient Name for Bill to Update: ");
                        var updateBillPatientName = Console.ReadLine();
                        hospital.UpdateBill(updateBillPatientName);
                        break;

                    case 20:
                        Console.Write("Enter Patient Name for Prescription to Update: ");
                        var updatePrescriptionPatientName = Console.ReadLine();
                        hospital.UpdatePrescription(updatePrescriptionPatientName);
                        break;

                    case 21:
                        Console.Write("Enter Patient Name to Search: ");
                        var searchPatientName = Console.ReadLine();
                        hospital.SearchPatient(searchPatientName);
                        break;

                    case 22:
                        Console.Write("Enter Doctor Name to Search: ");
                        var searchDoctorName = Console.ReadLine();
                        hospital.SearchDoctor(searchDoctorName);
                        break;

                    case 23:
                        Console.Write("Enter Patient Name for Appointment to Search: ");
                        var searchAppointmentPatientName = Console.ReadLine();
                        hospital.SearchAppointment(searchAppointmentPatientName);
                        break;

                    case 24:
                        Console.Write("Enter Patient Name for Bill to Search: ");
                        var searchBillPatientName = Console.ReadLine();
                        hospital.SearchBill(searchBillPatientName);
                        break;

                    case 25:
                        Console.Write("Enter Patient Name for Prescription to Search: ");
                        var searchPrescriptionPatientName = Console.ReadLine();
                        hospital.SearchPrescription(searchPrescriptionPatientName);
                        break;

                    case 26:
                        Console.Write("Enter Patient Name to View Details: ");
                        var viewPatientDetailsName = Console.ReadLine();
                        hospital.ViewPatientDetails(viewPatientDetailsName);
                        break;

                    case 27:
                        Console.Write("Enter Doctor Name to View Details: ");
                        var viewDoctorDetailsName = Console.ReadLine();
                        hospital.ViewDoctorDetails(viewDoctorDetailsName);
                        break;

                    case 28:
                        Console.Write("Enter Patient Name for Appointment to View Details: ");
                        var viewAppointmentDetailsPatientName = Console.ReadLine();
                        hospital.ViewAppointmentDetails(viewAppointmentDetailsPatientName);
                        break;

                    case 29:
                        Console.Write("Enter Patient Name for Bill to View Details: ");
                        var viewBillDetailsPatientName = Console.ReadLine();
                        hospital.ViewBillDetails(viewBillDetailsPatientName);
                        break;

                    case 30:
                        Console.Write("Enter Patient Name for Prescription to View Details: ");
                        var viewPrescriptionDetailsPatientName = Console.ReadLine();
                        hospital.ViewPrescriptionDetails(viewPrescriptionDetailsPatientName);
                        break;

                    case 31:
                        hospital.SortPatients();
                        break;

                    case 32:
                        hospital.SortDoctors();
                        break;

                    case 33:
                        Console.Write("Enter Patient Name for Appointment to Reschedule: ");
                        var rescheduleAppointmentPatientName = Console.ReadLine();
                        hospital.RescheduleAppointment(rescheduleAppointmentPatientName);
                        break;

                    case 34:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}


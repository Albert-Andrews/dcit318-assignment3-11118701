using System;
using System.Collections.Generic;
using System.Linq;

namespace Question2
{
    public class HealthSystemApp
    {
        private readonly Repository<Patient> _patientRepo = new();
        private readonly Repository<Prescription> _prescriptionRepo = new();
        private Dictionary<int, List<Prescription>> _prescriptionMap = new();

        public void SeedData()
        {
            // Patients
            _patientRepo.Add(new Patient(1, "Alice Mensah", 24, "Female"));
            _patientRepo.Add(new Patient(2, "Kojo Owusu", 31, "Male"));
            _patientRepo.Add(new Patient(3, "Ama Dede", 28, "Female"));

            // Prescriptions
            _prescriptionRepo.Add(new Prescription(101, 1, "Amoxicillin 500mg", DateTime.Today.AddDays(-5)));
            _prescriptionRepo.Add(new Prescription(102, 1, "Ibuprofen 200mg", DateTime.Today.AddDays(-1)));
            _prescriptionRepo.Add(new Prescription(103, 2, "Loratadine 10mg", DateTime.Today));
            _prescriptionRepo.Add(new Prescription(104, 3, "Paracetamol 1g", DateTime.Today.AddDays(-2)));
            _prescriptionRepo.Add(new Prescription(105, 2, "Omeprazole 20mg", DateTime.Today.AddDays(-3)));
        }

        public void BuildPrescriptionMap()
        {
            _prescriptionMap = _prescriptionRepo
                .GetAll()
                .GroupBy(rx => rx.PatientId)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public void PrintAllPatients()
        {
            Console.WriteLine("--- Patients ---");
            foreach (var p in _patientRepo.GetAll())
                Console.WriteLine(p);
        }

        public void PrintPrescriptionsForPatient(int patientId)
        {
            Console.WriteLine($"\n--- Prescriptions for Patient #{patientId} ---");
            if (_prescriptionMap.TryGetValue(patientId, out var list))
            {
                foreach (var rx in list) Console.WriteLine(rx);
            }
            else
            {
                Console.WriteLine("No prescriptions found.");
            }
        }

        public void Run()
        {
            SeedData();
            BuildPrescriptionMap();
            PrintAllPatients();
            PrintPrescriptionsForPatient(2); // Example: Patient ID 2
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using patientBackend1.Models.DTOs.UserDTOs;
using PatientBackend1.Models;

namespace PatientBackend1.Services.PatientServices
{
    public interface IPatientService
    {
          Task<(int, string?, UsagePatientDTO?)> GetpatientrById(string patientId);
           Task<(int, string?,UsagePatientDTO[])> GetPatients ();
           Task<(int, string, UsagePatientDTO?)> UpdatePatient(UsagePatientDTO model, string patientId);
         Task<bool>UpdatePatientSubscriptionInSystemAsync(Patient patient);

        
    }
}
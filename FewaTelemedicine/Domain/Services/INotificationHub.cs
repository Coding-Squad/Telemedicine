﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewaTelemedicine.Domain.Services
{
    public interface INotificationHub
    {

        // reactive
        Task PatientLoggedIn(string payLoad);

        // proactive
        // proactive
        Task GetAllPatients(string payLoad);
        Task CallPatient(string payLoad);

        Task CompletePatient(string payLoad);

        Task ChatMessage(string message);
        Task GetAllDoctors(string payLoad);
    }
}

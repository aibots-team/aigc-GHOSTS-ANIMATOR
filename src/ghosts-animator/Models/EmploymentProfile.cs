// Copyright 2020 Carnegie Mellon University. All Rights Reserved. See LICENSE.md file for terms.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ghosts.Animator.Models
{
    public class EmploymentProfile
    {
        public IList<EmploymentRecord> EmploymentRecords { get; set; }

        public EmploymentProfile()
        {
            this.EmploymentRecords = new List<EmploymentRecord>();
        }
        
        public class EmploymentRecord
        {
            public string Company { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string Department { get; set; }
            public string Organization { get; set; }
            public string JobTitle { get; set; }
            public int Level { get; set; }
            public double Salary { get; set; }
            public Guid Manager { get; set; }
            public string EmailSuffix { get; set; }
            public string Email { get; set; }
            public AddressProfiles.AddressProfile Address { get; set; }
            public string Phone { get; set; }
            public EmploymentStatuses EmploymentStatus { get; set; }

            [JsonConverter(typeof(StringEnumConverter))]
            public enum EmploymentStatuses
            {
                FullTime = 0,
                PartTime = 1,
                Suspended = 2,
                Temporary = 3,
                Resigned = -5,
                Terminated = -9
            }

            public EmploymentRecord()
            {
                this.Address = new AddressProfiles.AddressProfile();
            }
        }
    }
}
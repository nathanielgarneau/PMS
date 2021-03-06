﻿using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;

namespace PMS.DAL.Seeds
{
    public class IdentificationType : ISeed
    {
        private readonly List<string> IdentificationTypes = new List<string>
        {
            "Birth certificate",
            "Driver's license",
            "Passport",
            "Record of landing",
            "Citizenship card",
            "Permanent resident card",
            "Health card",
            "Social insurance number card",
            "Certificate of Indian Status",
            "Identification card"
        };

        public void Seed(CodeFirstModel context)
        {
            context.IdentificationType.AddOrUpdate(
                x => x.Name,
                GetIdentificationTypes()
                );
        }

        private Xam.DAL.Model.IdentificationType[] GetIdentificationTypes()
        {
            var identificationTypes = new List<Xam.DAL.Model.IdentificationType>();
            foreach (var name in IdentificationTypes)
            {
                var identificationType = new Xam.DAL.Model.IdentificationType
                {
                    Name = name
                };
                identificationTypes.Add(identificationType);
            }
            return identificationTypes.ToArray();
        }
    }
}
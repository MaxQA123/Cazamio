﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableApplicationRequiredDocuments
{
    public class DBModelsApplicationRequiredDocuments
    {
        public long? Id { get; set; } // this might be another data type
        public object? OriginalRecordId { get; set; }
        public object? ApartmentApplicationId { get; set; }
    }
}
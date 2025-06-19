﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class EmployeeWithIdResponse : Response
    {
        public IEnumerable<EmployeeWithId> Employees { get; set; }
        public EmployeeWithIdResponse(EmployeeWithId employee)
        {
            Employees = new List<EmployeeWithId>() {employee};
            Success = true;
        }
        public EmployeeWithIdResponse(IEnumerable<EmployeeWithId> employees)
        {
            Employees = employees;
            Success = true;
        }

        public EmployeeWithIdResponse() { }
    }
}
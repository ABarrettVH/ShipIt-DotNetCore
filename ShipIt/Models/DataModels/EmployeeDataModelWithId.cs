using System;
using System.Data;
using ShipIt.Models.ApiModels;

namespace ShipIt.Models.DataModels
{
    public class EmployeeDataModelWithId : DataModel
    {
        [DatabaseColumnName("id")]
        public int Id { get; set; }
        [DatabaseColumnName("name")]
        public string Name { get; set; }
        [DatabaseColumnName("w_id")]
        public int WarehouseId { get; set; }
        [DatabaseColumnName("role")]
        public string Role { get; set; }
        [DatabaseColumnName("ext")]
        public string Ext { get; set; }

        public EmployeeDataModelWithId(IDataReader dataReader) : base(dataReader)
        { }

        public EmployeeDataModelWithId()
        { }

        public EmployeeDataModelWithId(EmployeeWithId employee)
        {

            this.Name = employee.Name;
            this.WarehouseId = employee.WarehouseId;
            this.Role = MapApiRoleToDatabaseRole(employee.role);
            this.Ext = employee.ext;
            this.Id = employee.Id;
        }

        private string MapApiRoleToDatabaseRole(EmployeeRole employeeRole)
        {
            if (employeeRole == EmployeeRole.CLEANER) return DataBaseRoles.Cleaner;
            if (employeeRole == EmployeeRole.MANAGER) return DataBaseRoles.Manager;
            if (employeeRole == EmployeeRole.OPERATIONS_MANAGER) return DataBaseRoles.OperationsManager;
            if (employeeRole == EmployeeRole.PICKER) return DataBaseRoles.Picker;
            throw new ArgumentOutOfRangeException("EmployeeRole");
        }
    }
}
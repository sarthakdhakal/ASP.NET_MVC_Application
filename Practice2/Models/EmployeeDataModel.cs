using System;

namespace Practice2.Models
{
    public class EmployeeDataModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Department Department { get; set; }
        
        public string DepartmentName   {get; set; }
    }
}
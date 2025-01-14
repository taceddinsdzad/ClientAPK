using ClientMVC.Models.Base;

namespace ClientMVC.Models
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

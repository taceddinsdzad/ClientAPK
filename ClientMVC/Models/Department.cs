using ClientMVC.Models.Base;

namespace ClientMVC.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        List<Doctor> Doctors { get; set; }
    }
}

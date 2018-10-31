using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string HoTen { get; set; }

        public double? DiemToan { get; set; }

        public double? DiemLy { get; set; }

        public double? DiemHoa { get; set; }

    }

}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace HtthLesson07.Models
{
    //author hoang thi thu hue
    public class HtthMember
    {
        public int Id { get; set; }

        [DisplayName("Tai khoan")]
        [Required(ErrorMessage ="Tai khoan khong dc de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Tai khoan co do dai trong khoang 3-20 ki tu")]
        public string HtthUserName { get; set; }

        [DisplayName("Mat khau")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mat khau toi thieu 8 ki tu")]
        public string HtthPassword { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage ="Email khong dc de trong")]
        [DataType(DataType.EmailAddress)]
        public string HtthEmail { get; set; }


        [DisplayName("So dien thoai")]
        [Required(ErrorMessage = "Sdt khong dc de trong")]
        [RegularExpression(@"^0\d{9,9}",ErrorMessage = "Dien thoai sai dinh dang, dien thoai phai bat dau bang so 0")]
        public string HtthPhone { get; set; }

    }
}

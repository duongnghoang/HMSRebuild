using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Users
{
    /// <summary>
    /// Pages to Access
    /// </summary>
    public class Menu : BaseEntity
    {
        /// <summary>
        /// dành cho user, tên hiển thị của Menu, 
        /// theo format như sau: MENU_MANAGE_BOOKING
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// dành cho dev, dùng để xử lý logic
        /// có thể trùng với menu
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// sử dụng Icon của Material UI
        /// (mới test thử thành công với icon của MUI)
        /// </summary>
        public string? IConName { get; set; }

        /// <summary>
        /// cấp cha liền kề
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// phần chính của url
        /// BASEURL: https://pms.ezcloudhotel.com/
        /// format: BASEURL/Url ~ BASEURL/config/HotelInfo
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// thứ tự hiển thị
        /// null khi không nằm trong menu, không cần hiển thị
        /// </summary>
        public int? OrderNumber { get; set; }

        /// <summary>
        /// is in used?
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// is show in sidebar
        /// </summary>
        public bool IsPresentInSideBar { get; set; }

        public bool IsAllowAnonymous { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Menu? ParentMenu { get; set; }

        public virtual ICollection<Menu>? ChildrenMenu { get; set; }
        //public virtual ICollection<Permission>? Permissions { get; set; }

    }
}

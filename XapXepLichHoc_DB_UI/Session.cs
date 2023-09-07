using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XapXepLichHoc_DB_UI
{
    //lớp tĩnh dùng để lưu tài khoản đăng nhập
    internal static class Session
    {
        public static string UserName { get; set; }
        public static int UserId { get; set; }

        
    }
}

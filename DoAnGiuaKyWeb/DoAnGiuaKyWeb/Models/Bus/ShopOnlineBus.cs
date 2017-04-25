using PetaPoco;
using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKyWeb.Models.Bus
{
    public class ShopOnlineBus
    {
        public static IEnumerable<SanPham> DS()
        {
            {
                var db = new ShopOnlineConnectionDB();
                return db.Query<SanPham>("select * from SanPham where TinhTrang='0'");
            }
        }

        public static SanPham ChiTiet(String a)
        {
            var db = new ShopOnlineConnectionDB();
            var sql = string.Format("select * from SanPham where masanpham='{0}'", a);
            return db.SingleOrDefault<SanPham>(sql);
        }
        public static Page<SanPham> DS(int page, int itempage)
        {
            var sql = new ShopOnlineConnectionDB();
            return sql.Page<SanPham>(page, itempage, "select * from SanPham where TinhTrang=0");
        }


    }
}
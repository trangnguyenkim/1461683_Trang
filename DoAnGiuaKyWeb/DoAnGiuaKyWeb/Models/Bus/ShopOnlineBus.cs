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
        //---------------------------menu nhà sản xuất-----------------------------------------//
        public static IEnumerable<NhaSanXuat> NhaSanXuat()
        {
            var sql = new ShopOnlineConnectionDB();
            return sql.Query<NhaSanXuat>("select * from NhaSanXuat where TinhTrang=0");
        }
        public static IEnumerable<SanPham> TatCaSanPham(string id)
        {
            var sql = new ShopOnlineConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where Manhasanxuat = @0", id).ToList();
        }
        //---------------------------------menu loại sản phẩm--------------------------------------//
        public static IEnumerable<LoaiSanPham> LoaiSanPham()
        {
            var sql = new ShopOnlineConnectionDB();
            return sql.Query<LoaiSanPham>("select * from LoaiSanPham where TinhTrang=0");
        }
        public static IEnumerable<SanPham> TatCaSLoaiSanPham(string id)
        {
            var sql = new ShopOnlineConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where Maloaisanpham = @0", id).ToList();
        }
    }
}
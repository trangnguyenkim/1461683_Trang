using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKyWeb.Areas.Admin.Models.BusAdmin
{
    public class SanPhamAdmin
    {
        public static IEnumerable<SanPham> DS()
        {
            {
                var db = new ShopOnlineConnectionDB();
                return db.Query<SanPham>("select * from SanPham");
            }
        }


        public static void Them(SanPham sx)
        {
            var sql = new ShopOnlineConnectionDB();
            sql.Insert(sx);
        }
        //---sua-----//
        public static SanPham Update(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                return db.Single<SanPham>("select * from SanPham where Masanpham =@0", id);
            }
        }
        public static void UpdateDS(SanPham sx)
        {
            var sql = new ShopOnlineConnectionDB();
            sql.Update("SanPham", "Masanpham", sx);
        }
        //---xoa tam thoi----//
        public static void DeleteDS(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                var lsp = db.Single<SanPham>("select * from SanPham where Masanpham = @0", id);

                lsp.Tinhtrang = "1";
                db.Update("SanPham", "Masanpham", lsp);
            }
        }

        //---------khoi phuc-------------//
        public static void KhoiPhuc(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                var lsp = db.Single<SanPham>("select * from SanPham where Masanpham = @0", id);
                lsp.Tinhtrang = "0";
                db.Update("SanPham", "Masanpham", lsp);
            }
        }



        public static IEnumerable<LoaiSanPham> LoaiSanPham()
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                return db.Query<ShopOnlineConnection.LoaiSanPham>("select * from LoaiSanPham ");
            }
        }

        public static IEnumerable<NhaSanXuat> NhaSanXuat()
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                return db.Query<ShopOnlineConnection.NhaSanXuat>("select * from NhaSanXuat ");
            }
        }

        public static int XoaSanPham(string id)
        {
            var db = new ShopOnlineConnectionDB();

            return db.Delete("SanPham", "Masanpham", null, id);
        }
    }
}
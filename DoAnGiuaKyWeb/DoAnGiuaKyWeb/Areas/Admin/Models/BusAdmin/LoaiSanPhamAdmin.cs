using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKyWeb.Areas.Admin.Models.BusAdmin
{
    public class LoaiSanPhamAdmin
    {
        public static IEnumerable<LoaiSanPham> DS()
        {
            {
                var db = new ShopOnlineConnectionDB();
                return db.Query<LoaiSanPham>("select * from LoaiSanPham ");
            }
        }
        //----them---/
        public static void Them(LoaiSanPham sx)
        {
            var sql = new ShopOnlineConnectionDB();
            sql.Insert(sx);
        }
        //---sua-----//
        public static LoaiSanPham Update(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                return db.Single<LoaiSanPham>("select * from LoaiSanPham where Maloaisanpham =@0", id);
            }
        }
        public static void UpdateDS(LoaiSanPham sx)
        {
            var sql = new ShopOnlineConnectionDB();
            sql.Update("LoaiSanPham", "Maloaisanpham", sx);
        }
        //---xoa tam thoi----//
        public static void DeleteDS(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                var lsp = db.Single<LoaiSanPham>("select * from LoaiSanPham where MaLoaiSanPham = @0", id);

                lsp.TinhTrang = 1;
                db.Update("LoaiSanPham", "MaLoaiSanPham", lsp);
            }
        }

        //---------khoi phuc-------------//
        public static void KhoiPhuc(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                var lsp = db.Single<LoaiSanPham>("select * from LoaiSanPham where MaLoaiSanPham = @0", id);
 
                lsp.TinhTrang = 0;
                db.Update("LoaiSanPham", "MaLoaiSanPham", lsp);
            }
        }
    }
}
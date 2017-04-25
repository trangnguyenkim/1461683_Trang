using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKyWeb.Areas.Admin.Models.BusAdmin
{
    public class NhaSanXuatAdmin
    {
        public static IEnumerable<NhaSanXuat> DS()
        {
            {
                var db = new ShopOnlineConnectionDB();
                return db.Query<NhaSanXuat>("select * from NhaSanXuat ");
            }
        }

        public static void Them(NhaSanXuat sx)
        {
            var sql = new ShopOnlineConnectionDB();
            sql.Insert(sx);
        }
        //---sua-----//
        public static NhaSanXuat Update(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                return db.Single<NhaSanXuat>("select * from NhaSanXuat where Manhasanxuat =@0", id);
            }
        }
        public static void UpdateDS(NhaSanXuat sx)
        {
            var sql = new ShopOnlineConnectionDB();
            sql.Update("NhaSanXuat", "Manhasanxuat", sx);
        }
        //---xoa tam thoi----//
        public static void DeleteDS(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                var lsp = db.Single<NhaSanXuat>("select * from NhaSanXuat where Manhasanxuat = @0", id);

                lsp.TinhTrang = 1;
                db.Update("NhaSanXuat", "Manhasanxuat", lsp);
            }
        }

        //---------khoi phuc-------------//
        public static void KhoiPhuc(string id)
        {
            using (var db = new ShopOnlineConnectionDB())
            {
                var lsp = db.Single<NhaSanXuat>("select * from NhaSanXuat where Manhasanxuat = @0", id);
                lsp.TinhTrang = 0;
                db.Update("NhaSanXuat", "Manhasanxuat", lsp);
            }
        }
    }
}
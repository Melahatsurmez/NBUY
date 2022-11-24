using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        //Þuan burada IGenericRepositoryden gelen kitap için hazýrlanmýþ Crud metotlarý var.
        //Eðer bir class IKitapRepositoryden miras alýrsa,tüm bu Crud metotlarý da oraya implemente edilir.
        //Buraya ayrýca yazýlacak metotlar (aþaðýdaki gibi) sadece kitap entitysine özgü metotlardýr
        List<Kitap> KategoriyeGoreKitapListesi(int id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        //�uan burada IGenericRepositoryden gelen kitap i�in haz�rlanm�� Crud metotlar� var.
        //E�er bir class IKitapRepositoryden miras al�rsa,t�m bu Crud metotlar� da oraya implemente edilir.
        //Buraya ayr�ca yaz�lacak metotlar (a�a��daki gibi) sadece kitap entitysine �zg� metotlard�r
        List<Kitap> KategoriyeGoreKitapListesi(int id);
    }
}
﻿using KitabeviApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IGenericRepository<T>
    {
        T Getir(int id);
        List<T> Listele();
        void Ekle(T varlık);
        void Guncelle(T varlık);
        void Sil(T varlık);
        
    }
}
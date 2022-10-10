﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Methods
{
    public class MethodOverload
    {
        private int price; //Field
        public int Price { get; set; } //property
        public void DenemeMetodu()
        {
            Console.WriteLine("Merhaba. Ben MethodOverload classındayım!");
            Console.WriteLine(Program.Topla(3,5));
        } //Method

        public int Topla(int s1, int s2, int s3=0)
        {
            return s1 + s2 + s3; 
        }
        // Gönderilen 3 sayı arasında istersem toplama istersem çarpma yapsın
        public int Islem(int s1, int s2, int s3 = 0, bool islemTuru= true) 
        {
            if (islemTuru== true)
            {
                return s1 + s2 + s3;
            }
            else
            {
                if(s3== 0) s3= 1;
                return s1 * s2 * s3;
            }
            
        }

        public int Topla(int[] sayilar) // overload aynı ismi kulllanmak
        {
            int sonuc = sayilar.Sum();
            return sonuc;
        }

    }
    
}

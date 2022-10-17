using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptoje12_OOP_Work_01
{
    public interface IBolum
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public interface IBolum2: IBolum
    {      
        public string Aciklama { get; set; }
    }
    public interface IOgrenci: IBolum
    {
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public List<IBolum> IBolumList { get; set; }
    }
}

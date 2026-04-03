using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Tabanlı_Programlama_Hafta_6
{
    public class C1
    {
        public int x; // ulaşılabilir
        int y; // default ulaşılamaz
        private int z; // private ulaşılamaz kapsülleme gerekli
        public void m1() { }
        void m2() { } // default ulaşılamaz kapsülleme gerekli
        private void m3() { } // private ulaşılamaz kapsülleme gerekli
    }
}

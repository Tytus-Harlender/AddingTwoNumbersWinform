using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SemiconductorsApp
{
    public class SumCalculation
    {
        private int _s1 { get; set; }
        private int _s2 { get; set; }
        private int _s3 { get; set; }
        public SumCalculation(string S1, string S2)
        {
            _s1 = Int32.Parse(S1);
            _s2 = Int32.Parse(S2);
        }
        public string AddNumbers()
        {
            
            _s3 = _s1 + _s2;
            return _s3.ToString();
        }
    }
}

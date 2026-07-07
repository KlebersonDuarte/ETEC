using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj12
{
    internal class clsPrazo
    {
       private DateTime _strData;
       private double _vlBruto;


        public DateTime strData
        {
            get { return _strData; }
            set { _strData = value; }
        }

        public double vlBruto
        {
            get { return _vlBruto; }
            set { _vlBruto = value; }
        }
        public double CalcularPrazo()
        {

            if (_strData.Day < 5)
            {
                return _vlBruto -= _vlBruto * 0.05;
            }
            else if (_strData.Day > 5)
            {
                return _vlBruto += _vlBruto * 0.0725;
            }
            else {
                return _vlBruto; 
            }
        }
    }
}

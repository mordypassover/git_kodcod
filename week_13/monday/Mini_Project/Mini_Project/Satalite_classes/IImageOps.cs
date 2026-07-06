using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Project.Satalite_Image
{
    interface IImageOps
    {
        int CalcScore();
        void Retask();
        void CalibrateThermal();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.classes
{
    class ImegePipline
    {
        private readonly IStorer _store;

        public ImegePipline(IStorer Store) { _store = Store; }

        public void AddToStore(List<SatelliteImage> imeges) 
        {
            foreach (SatelliteImage img in imeges) 
            { 
                if (img is Iscorabul imgs) {imgs.CalcScore() ; }
                _store.Save(img);
            }
            Console.WriteLine($"stored {_store.CountData()} images");
        }
        
    }
    
}

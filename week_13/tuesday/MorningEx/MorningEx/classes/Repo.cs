
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MorningEx.classes
{
    class Repo<T> where T : SatelliteImage
    {
        private readonly List<T> _repo = new List<T>();

        public void Add(T imege) => _repo.Add(imege);

        public void GetAll()
            
        {
            foreach (T imege in _repo)
            {
                if (imege is Iscorabul scorabulimege)
                Console.WriteLine($"{imege.Format()}, {scorabulimege.CalcScore()}");
            }
        }
    }
}

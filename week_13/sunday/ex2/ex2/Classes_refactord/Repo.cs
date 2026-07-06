using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ex2.Classes_refactord
{
    class Repo<T> where T : BaseManeger
    {
        private readonly List<T> _repo = new List<T>();

        public void Add(T imege) => _repo.Add(imege);

        public void GetAll()
        {
            foreach (T imege in _repo)
            {
                Console.WriteLine($"{imege.Format()}, {imege.CalcScore()}");
            }
        }





    }
}

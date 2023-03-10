using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relevance_ConsoleApp
{
    public class Ghiozdan
    {
        private readonly int _numarMaximArticole;
        private readonly float _greutateMaxima;
        private readonly float _volumMaxim;
        private readonly ArticolInventar[,] _articole;

        public int NumarMaximArticole => _numarMaximArticole;
        public float GreutateMaxima => _greutateMaxima;
        public float VolumMaxim => _volumMaxim;

        public int NumarArticole { get; private set; }
        public float Greutate { get; private set; }
        public float Volum { get; private set; }

        public Ghiozdan(int numarMaximArticole, float greutateMaxima, float volumMaxim)
        {
            _numarMaximArticole = numarMaximArticole;
            _greutateMaxima = greutateMaxima;
            _volumMaxim = volumMaxim;
            _articole = new ArticolInventar[numarMaximArticole, 1];
        }

        public bool Adauga(ArticolInventar articol)
        {
            if (NumarArticole >= NumarMaximArticole ||
                Greutate + articol.Greutate > GreutateMaxima ||
                Volum + articol.Volum > VolumMaxim)
            {
                return false;
            }

            for (int i = 0; i < NumarMaximArticole; i++)
            {
                if (_articole[i, 0] == null)
                {
                    _articole[i, 0] = articol;
                    NumarArticole++;
                    Greutate += articol.Greutate;
                    Volum += articol.Volum;
                    return true;
                }
            }

            return false;
        }

        public void AfiseazaArticole()
        {
            for (int i = 0; i < _articole.GetLength(0); i++)
            {
                for (int j = 0; j < _articole.GetLength(1); j++)
                {
                    if (_articole[i, j] != null)
                    {
                        Console.WriteLine($"Articol: {_articole[i, j].GetType().Name}");
                    }
                }
            }
        }
    }
}

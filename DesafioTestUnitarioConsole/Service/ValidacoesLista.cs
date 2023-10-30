﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTestUnitarioConsole.Service
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumeroNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();

        }

        public int RetornarMenosNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
using System;
using System.Collections.Generics;
using DIO.Series.interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries = new  List<Serie>();

        public void Atualiza(int id, Serie entidade)
        {
            listaSeries[id] = entidade
        }
        
        public void Exclui(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSeries.Add(entidade);
        }

        public int ProximoID()
        {
            return listaSeries.Count;
        }

        public List<Serie> Lista()
        {
            return listaSeries;
        }

        public Serie retornaPorId()
        {
            return listaSeries[id];
        }
    }
}
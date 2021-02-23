using System;
using System.Collections.Generic;
using projeto1_Dio.repositorio;

namespace projeto1_Dio{
    public class SeriesInterface : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void atualizaId(int id, Series objeto)
        {
            listaSeries[id] = objeto;
            
        }

        public void excluiID(int id)
        {
            listaSeries[id].Excluir();
            
        }

        public void insere(Series entidade)
        {
            listaSeries.Add(entidade);
            
        }

        public List<Series> Lista()
        {
            return listaSeries;
            
        }

        public int proximoId()
        {
            return listaSeries.Count;
            
        }

        public Series retornaId(int id)
        {
            return listaSeries[id];
            
        }
    }
}
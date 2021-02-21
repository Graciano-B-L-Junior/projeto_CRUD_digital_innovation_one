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
            throw new NotImplementedException();
        }

        public void excluiID(int id)
        {
            listaSeries[id].Excluir();
            throw new NotImplementedException();
        }

        public void insere(Series entidade)
        {
            listaSeries.Add(entidade);
            
        }

        public List<Series> Lista()
        {
            return listaSeries;
            throw new NotImplementedException();
        }

        public int proximoId()
        {
            return listaSeries.Count;
            throw new NotImplementedException();
        }

        public Series retornaId(int id)
        {
            return listaSeries[id];
            throw new NotImplementedException();
        }
    }
}
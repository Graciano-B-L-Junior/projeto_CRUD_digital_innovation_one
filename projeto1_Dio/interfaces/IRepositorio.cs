using System;
using System.Collections.Generic;

namespace projeto1_Dio.repositorio
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T retornaId(int id);
        void insere(T entidade);
        void excluiID(int id);
        void atualizaId(int id, T entidade);
        int proximoId();
    }
}
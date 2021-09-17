using System.Collections.Generics;

namespace DIO.Series.interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T retornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoID();
    }
}
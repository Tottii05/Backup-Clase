using System;

namespace Pruebas
{
    public interface IBorrowable
    {
        void Let();
        void Returned();
        int LateReturned();
    }

}

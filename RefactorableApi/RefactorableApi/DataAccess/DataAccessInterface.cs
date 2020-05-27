using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorableApi.DataAccess
{
    interface DataAccessInterface
    {
        dynamic Get(string id);

        dynamic Add(string id, dynamic newItem);

        void Delete(string id, string id2);
    }
}

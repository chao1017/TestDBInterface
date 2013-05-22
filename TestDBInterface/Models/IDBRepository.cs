using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBInterface.Models
{
    interface IDBRepository
    {
        
        //connect to database
        bool ConnectDB(string dbType);

        //insert data to database
        void InsertData(string para1);
    }
}

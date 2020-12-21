using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class UniqueItem
    {
        static int Id;
        public UniqueItem()
        {
            Id = Id+1;
        }

        public UniqueItem(int id)
        {
            Id = id;
        }

    }
}

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
            Id = Id++;
        }

        public UniqueItem(int id)
        {
            Id = id;
        }

    }
}

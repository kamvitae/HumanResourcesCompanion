using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_5_2_HRCompanion
{
    public interface ISortLists<T> where T : new()
    {
        List<T> CheckSortingMethod(int sortMethod, List<T> listToSort);
        List<T> GetSortedList();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_5_2_HRCompanion
{
    class SortWorkers: ISortLists<Worker>
    {
        private List<Worker> workers;
        private int sortMethod;
        public SortWorkers (List<Worker> listToSort, int comboSelectedIndex)
        {
            workers = listToSort;
            sortMethod = comboSelectedIndex;
        }
        public List<Worker> CheckSortingMethod(int sortMethod, List<Worker> listToSort) //deFacto niepotrzebna metoda
        {
            switch (sortMethod)
            {
                case 0:
                    return OrderByID(workers);
                    break;
                case 1:
                    return OrderByIDdescending(workers);
                    break;
                 case 2:
                    return OrderByLastName(workers);
                     break;
                 case 3:
                    return OrderByLastNameDescending(workers);
                    break;
                // case 4:
                //     break;
                // case 5:
                //     break;
                // case 6:
                //     break;
                // case 7:
                //     break;
                default:
                    return OrderByID(workers);
                    break;
            }
        }
        public List<Worker> GetSortedList()
        {
            return CheckSortingMethod(sortMethod, workers);
        }
        private List<Worker> OrderByID(List<Worker> list)
        {
            var orderBy = list.OrderBy(Worker => Worker.WorkerID);
            return list = orderBy.ToList();
        }
        private List<Worker> OrderByIDdescending(List<Worker> list)
        {
            var orderBy = list.OrderByDescending(Worker => Worker.WorkerID);
            return list = orderBy.ToList();
        }
        private List<Worker> OrderByLastName(List<Worker> list)
        {
            var orderBy = list.OrderBy(Worker => Worker.LastName);
            return list = orderBy.ToList();
        }
        private List<Worker> OrderByLastNameDescending(List<Worker> list)
        {
            var orderBy = list.OrderByDescending(Worker => Worker.LastName);
            return list = orderBy.ToList();
        }

        // private List<Worker> FilterStudentsByGroup(List<Worker> listToFilter, int groupFilter)
        //{
        //    return listToFilter.Where(x => x.GroupID == groupFilter).ToList();
        //}

    }
}

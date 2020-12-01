using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_5_2_HRCompanion
{
    class SortWorkers : ISortLists<Worker>
    {
        private List<Worker> workers;
        private int _sortMethod;
        public SortWorkers(List<Worker> listToSort, int comboSelectedIndex, bool hideFired)
        {
            if (hideFired)
                workers = FilterCurrentyHiredOnly(listToSort, hideFired);

            else
                workers = listToSort;
            _sortMethod = comboSelectedIndex;
        }
        public List<Worker> CheckSortingMethod(int sortMethod, List<Worker> listToSort) //deFacto niepotrzebna metoda
        {
            switch (sortMethod)
            {
                case 0:
                    return OrderByID(workers);

                case 1:
                    return OrderByIDdescending(workers);

                case 2:
                    return OrderByLastName(workers);

                case 3:
                    return OrderByLastNameDescending(workers);

                case 4:
                    return OrderByHireDate(workers);

                case 5:
                    return OrderByHireDateDescending(workers);

                case 6:
                    return OrderBySalary(workers);

                case 7:
                    return OrderBySalaryDescending(workers);

                default:
                    return OrderByID(workers);

            }
        }
        public List<Worker> GetSortedList()
        {
            return CheckSortingMethod(_sortMethod, workers);
        }
        private List<Worker> OrderByID(List<Worker> list)
        { 
            return list.OrderBy(Worker => Worker.WorkerID).ToList();
        }
        private List<Worker> OrderByIDdescending(List<Worker> list)
        {
            return list.OrderByDescending(Worker => Worker.WorkerID).ToList();
        }
        private List<Worker> OrderByLastName(List<Worker> list)
        {
            
            return list.OrderBy(Worker => Worker.LastName).ToList();
        }
        private List<Worker> OrderByLastNameDescending(List<Worker> list)
        {
            return list.OrderByDescending(Worker => Worker.LastName).ToList();
        }
        private List<Worker> OrderByHireDate(List<Worker> list)
        {
            return list.OrderBy(
                    Worker => Convert.ToDateTime(Worker.Hired)).ToList();
        }
        private List<Worker> OrderByHireDateDescending(List<Worker> list)
        {
            return list.OrderByDescending(
                    Worker => Convert.ToDateTime(Worker.Hired)).ToList();
        }
        private List<Worker> OrderBySalary(List<Worker> list)
        {
            return list.OrderBy(Worker => Worker.Salary).ToList();
        }
        private List<Worker> OrderBySalaryDescending(List<Worker> list)
        {
            return list.OrderByDescending(Worker => Worker.Salary).ToList();
        }

        private List<Worker> FilterCurrentyHiredOnly(List<Worker> list, bool hideFired)
        {
            return list.Where(Worker => Worker.Fired == null).ToList();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_5_2_HRCompanion
{
    public static class ComboboxHelper
    {
        internal static void InitComboboxGroups(ComboBox comboBox)
        {
            var _sortBy = new List<Sort>
            {
                new Sort { Id = 0, SortBy = "ID, rosnąco" },
                new Sort { Id = 1, SortBy = "ID, malejąco" },
                new Sort { Id = 2, SortBy = "Nazwisko, rosnąco" },
                new Sort { Id = 3, SortBy = "Nazwisko, malejąco" },
                new Sort { Id = 4, SortBy = "Stażu pracy, rosnąco" },
                new Sort { Id = 5, SortBy = "Stażu pracy, malejąco" },
                new Sort { Id = 6, SortBy = "Zarobków, rosnąco" },
                new Sort { Id = 7, SortBy = "Zarobków, malejąco" }
            };
            comboBox.DataSource = _sortBy;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "SortBy";
        }
    }

    public class Sort
    {
        public int Id { get; set; }
        public string SortBy { get; set; }
    }
}

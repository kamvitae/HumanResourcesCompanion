using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using MP_5_2_HRCompanion.Properties;

namespace MP_5_2_HRCompanion
{
    public partial class FormMain : Form
    {
        private FileHelper<List<Worker>> _fileHelper =
            new FileHelper<List<Worker>>(Program.DataPath);

        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                // Gdzie można usunąć status "readonly"?
                // Settings.Default.IsMaximize = value;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            ComboboxHelper.InitComboboxGroups(cbboxSorter);

            RefreshGrid();
            SetColumnsHeader();

        }
        private void RefreshGrid()
        {
            var workers = _fileHelper.DeserializeFromFile();
            var sortWorkers = new SortWorkers(workers, cbboxSorter.SelectedIndex);
            dgvWorkers.DataSource = sortWorkers.GetSortedList();
        }


        private void SetColumnsHeader()
        {
            dgvWorkers.Columns[0].HeaderText = "Identyfikatow pracownika"; // ustaw niemodyfikowalne wszystkie z poziomu dgv
            dgvWorkers.Columns[1].HeaderText = "Nazwisko";
            dgvWorkers.Columns[2].HeaderText = "Imię";
            dgvWorkers.Columns[3].HeaderText = "Data zatrudnienia";
            dgvWorkers.Columns[4].HeaderText = "Zakończył(a) pracę";
            dgvWorkers.Columns[5].HeaderText = "Pensja brutto";
            dgvWorkers.Columns[6].HeaderText = "Uwagi"; // z wyjątkiem uwag
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var AddEditWorker = new AddEditWorker(DateTime.Today);

            AddEditWorker.FormClosing += AddEditWorker_FormClosing;
            AddEditWorker.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika do edycji");
                return;
            }
            var addEditWorker = new AddEditWorker(
                Convert.ToInt32(
                    dgvWorkers.SelectedRows[0].Cells[0].Value));
            addEditWorker.FormClosing += AddEditWorker_FormClosing;
            addEditWorker.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnFired_Click(object sender, EventArgs e)
        {
            if (dgvWorkers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie zaznaczono pracownika");
                return;
            }
            else
            {
                var title = "Rozwiązanie umowy o zatrudnienie";
                var message = "Czy na pewno chcesz zwolnić tego pracownika?";
                if (MessageBox.Show(message, title, 
                    MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    FireSelectedWorker();
                }
            }

            // po kliknięciu otwiera się okno z pytaniem czy na pewno chesz zwolnić pracownika. 
            // nieaktywny przycisk "ok" uaktywni się po wpisaniu w txtBox Imienia i Nazwiska zwalnianego pracownika
            // "ok" wprowawdzi do pola Fired pracownika aktualną datę.
        }

        private void FireSelectedWorker()
        {
            var addEditWorker = new AddEditWorker(
                DateTime.Today,
                Convert.ToInt32(
                    dgvWorkers.SelectedRows[0].Cells[0].Value));
            addEditWorker.FormClosing += AddEditWorker_FormClosing;
            addEditWorker.ShowDialog();
        }

        private void chboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // filtrowanie wg : Alfabetycznie, Identyfikator, StanuZatrudnienia. Wys.Stawki 
        }



        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();
        }
        private void AddEditWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGrid();
        }
    }
}


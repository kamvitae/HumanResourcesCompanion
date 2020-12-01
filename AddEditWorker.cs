using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MP_5_2_HRCompanion
{
    public partial class AddEditWorker : Form
    {
        private int _workerId;
        private Worker _worker;

        private FileHelper<List<Worker>> _fileHelper =
            new FileHelper<List<Worker>>(Program.DataPath);

        public AddEditWorker(int id = 0)
        {
            InitializeComponent();
            _workerId = id;
            GetWorkerData();
        }

        public AddEditWorker(DateTime today)
        {
            InitializeComponent();
            tbHired.Text = GetTodaysDate(today);
        }
        public AddEditWorker(DateTime today, int id = 0)
        {
            InitializeComponent();
            _workerId = id;
            GetWorkerData();
            tbFired.Text = GetTodaysDate(today);
        }

        private void GetWorkerData()
        {
            if (_workerId != 0)
            {
                Text = "Edytuj dane pracownika";

                List<Worker> workers = _fileHelper.DeserializeFromFile();
                _worker = workers.FirstOrDefault(x => x.WorkerID == _workerId);

                if (_worker == null)
                {
                    throw new Exception("Pracownik o podanym identyfikatorze nie istnieje");
                }
                FillTextBoxes();
            }
        }
        private void FillTextBoxes()
        {
            tbWorkerID.Text = _worker.WorkerID.ToString();
            tbName.Text = _worker.Name;
            tbLastName.Text = _worker.LastName;
            tbHired.Text = _worker.Hired.ToString();
            tbFired.Text = _worker.Fired.ToString();
            tbSalary.Text = _worker.Salary.ToString();
            rtbComments.Text = _worker.Comments;
        }
        private void AddWorkerToList(List<Worker> workers)
        {
            var worker = new Worker
            {
                WorkerID = _workerId, // raz ustawiony powinien być readonly
                Name = tbName.Text,
                LastName = tbLastName.Text,
                Hired = tbHired.Text,
                Fired = tbFired.Text,
                Comments = rtbComments.Text

            };
            if (decimal.TryParse(tbSalary.Text, out decimal result))
            {
                worker.Salary = result; // żeby nie zmienić "przypadkowo" wypłaty po wciśnięciu okienka otworzymy nowe
            }
        workers.Add(worker);
        }
    private void AssignIdToWorker(List<Worker> workers)
    {
        var workerWithHigherID = workers.
            OrderByDescending(x => x.WorkerID).FirstOrDefault();

        _workerId = workerWithHigherID ==
            null ? 1001 : workerWithHigherID.WorkerID + 1;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        List<Worker> workers = _fileHelper.DeserializeFromFile();

        if (_workerId != 0)
            workers.RemoveAll(x => x.WorkerID == _workerId);
        else
            AssignIdToWorker(workers);

        AddWorkerToList(workers);

        _fileHelper.SerializeToFile(workers);
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private string GetTodaysDate(DateTime todaysDate)
    {
        var dateTime = todaysDate;
        return dateTime.ToString("d");
    }
}
}

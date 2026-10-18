using BRAnimalRehabSystem.ApplicationLogic;
using BRAnimalRehabSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAnimalRehabSystem.PresentationLayer
{
    public partial class SummaryForm : Form
    {
        AnimalFileHandler animalFileHandler = new AnimalFileHandler();
        List<Animal> animals;
        string animalDataPath = @"C:\Users\Cactu\OneDrive - belgiumcampus.ac.za\Belgium College Work\2nd Year 120 Credits\Semester 2\PRG282\wildlife_rehabilitation_records_system\BRAnimalRehabSystem\DataLayer\animals.txt";
        string summaryDataPath = @"AnimalSummary.txt";

        public SummaryForm()
        {
            InitializeComponent();
            animals = animalFileHandler.LoadAnimalList(animalDataPath);
        }

        public string[] SummaryDocFormat(string dateOfSummary, string TotalAnimals, string AverageAnimalAge, string AverageRecoveryScore, string AnimalStatusCountCritical, string AnimalStatusCountSerious, string AnimalStatusCountStable, string AnimalStatusCountRecovering, string AnimalStatusCountRelease)
        {
            string[] SummaryArr = { "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE", "ANIMAL SUMMARY REPORT", dateOfSummary, "----------------------------------------------", $"Total animals: {TotalAnimals}", $"Average age (years): {AverageAnimalAge}", $"Average recovery score: {AverageRecoveryScore}", "----------------------------------------------", "Animals per status: ", $"Critical: {AnimalStatusCountCritical}", $"Serious: {AnimalStatusCountSerious}", $"Stable: {AnimalStatusCountStable}", $"Recovering: {AnimalStatusCountRecovering}", $"Release-Ready: {AnimalStatusCountRelease}" };
            return SummaryArr;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dateOfSummary = DateTime.Now;
                lblGenerateDate.Text = dateOfSummary.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

                int TotalAnimals = animals.Count;
                lblGenerateTotalAnimals.Text = TotalAnimals.ToString();

                if (TotalAnimals != 0)
                {
                    double AverageAnimalAge = 0.00;
                    foreach (Animal a in animals)
                    {
                        AverageAnimalAge += (double)a.AnimalAge / TotalAnimals;
                    }

                    double AverageRecoveryScore = animals.Average(a => a.AnimalRecoveryScore);

                    lblGenerateAverageAge.Text = Math.Round(AverageAnimalAge, 2).ToString(CultureInfo.InvariantCulture);
                    lblGenerateAverageRecovery.Text = Math.Round(AverageRecoveryScore, 2).ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    lblGenerateAverageAge.Text = "N / A";
                    lblGenerateAverageRecovery.Text = "N / A";
                }

                int AnimalStatusCountCritical = animals.Count(a => a.AnimalStatus.Trim().ToLower() == "critical");
                int AnimalStatusCountSerious = animals.Count(a => a.AnimalStatus.Trim().ToLower() == "serious");
                int AnimalStatusCountStable = animals.Count(a => a.AnimalStatus.Trim().ToLower() == "stable");
                int AnimalStatusCountRecovering = animals.Count(a => a.AnimalStatus.Trim().ToLower() == "recovering");
                int AnimalStatusCountRelease = animals.Count(a => a.AnimalStatus.Trim().ToLower() == "release-ready");

                lblGenerateStatusCritical.Text = AnimalStatusCountCritical.ToString();
                lblGenerateStatusSerious.Text = AnimalStatusCountSerious.ToString();
                lblGenerateStatusStable.Text = AnimalStatusCountStable.ToString();
                lblGenerateStatusRecovering.Text = AnimalStatusCountRecovering.ToString();
                lblGenerateStatusRelease.Text = AnimalStatusCountRelease.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("A fatal error occured please inform IT personel or contact support about this error: \n" + exc.Message);
            }
        }

        private void btnBackStatistics_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            this.Hide();
            frm1.Show();
        }

        private void btnSaveSummary_Click(object sender, EventArgs e)
        {
            try
            {
                string[] SummaryArr = SummaryDocFormat(lblGenerateDate.Text, lblGenerateTotalAnimals.Text, lblGenerateAverageAge.Text, lblGenerateAverageRecovery.Text, lblGenerateStatusCritical.Text, lblGenerateStatusSerious.Text, lblGenerateStatusStable.Text, lblGenerateStatusRecovering.Text, lblGenerateStatusRelease.Text);

                FileStream fsSummary = new FileStream(summaryDataPath, FileMode.Create);
                StreamWriter swSummary = new StreamWriter(fsSummary);

                for (int i = 0; i < SummaryArr.Length; i++)
                {
                    swSummary.WriteLine(SummaryArr[i]);
                }

                swSummary.Close();
                fsSummary.Close();

                string SummaryFoundHere = Path.GetFullPath(summaryDataPath);
                MessageBox.Show($"The AnimalSummary.txt doc saved can be found here: \n{SummaryFoundHere}");
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Fatal error occured when saving the AnimalSummary: \n" + exc.Message);
            }
        }

        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}

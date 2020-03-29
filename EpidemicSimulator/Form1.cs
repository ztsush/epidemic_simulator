// thanks to Kevin Simler for the idea // original-https://www.meltingasphalt.com/interactive/outbreak/
// !Importantly, I just tried to repeat the seen, I do not claim authorship, commercial / non-commercial use of the code is welcome :)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpidemicSimulator
{
    public partial class Form1 : Form
    {
        public int TransmissionRate { get; set; }           // ймовірність зараження
        public int RetransmissionRate { get; set; }         // ймовірність повторного зараження
        public int DaysInIncubation { get; set; }           // інкубаційний період
        public int DurationOfSymptoms { get; set; }         // тривалість симптомів
        public int TravelRadius { get; set; }               // радіус преміщення
        public int EncountersPerDay { get; set; }           // контактів в день
        public int SelfQuarantineRate { get; set; }         // частота самоізоляції
        public int SelfQuarantineStrictness { get; set; }   // строгість самоізоляції
        public int InputFatalityRate { get; set; }          // вхідна смертність
        public int HospitalCapacity { get; set; }           // місткість лікарень

        private Color[] statusColors = {
            Color.FromArgb(224, 224, 224), // Susceptible
            Color.FromArgb(255, 192, 192), // Infected (incubation period, no symptoms)
            Color.FromArgb(255, 128, 128), // Infected (with symptoms)
            Color.FromArgb(129, 129, 129), // Recovered
            Color.FromArgb(2, 101, 251),   // SelfInsulated
            Color.FromArgb(0, 0, 0)        // Dead
        };

        FormOptions formOptions = new FormOptions();

        private void UpdateValues()
        {
            TransmissionRate = formOptions.TransmissionRate;
            RetransmissionRate = formOptions.RetransmissionRate;
            DaysInIncubation = formOptions.DaysInIncubation;
            DurationOfSymptoms = formOptions.DurationOfSymptoms;
            TravelRadius = formOptions.TravelRadius;
            EncountersPerDay = formOptions.EncountersPerDay;
            SelfQuarantineRate = formOptions.SelfQuarantineRate;
            SelfQuarantineStrictness = formOptions.SelfQuarantineStrictness;
            InputFatalityRate = formOptions.InputFatalityRate;
            HospitalCapacity = formOptions.HospitalCapacity;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb0.BackColor = statusColors[0];
            pb1.BackColor = statusColors[1];
            pb2.BackColor = statusColors[2];
            pb3.BackColor = statusColors[3];
            pb4.BackColor = statusColors[4];
            pb5.BackColor = statusColors[5];
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            formOptions.Show();
            formOptions.Focus();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {

        }
    }
}

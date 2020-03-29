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
    public partial class FormOptions : Form
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


        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            trbTransmissionRate.Maximum = 100;
            trbRetransmissionRate.Maximum = 100;
            trbDaysInIncubation.Maximum = 30;
            trbDurationOfSymptoms.Maximum = 30;
            trbTravelRadius.Maximum = 10;
            trbEncountersPerDay.Maximum = 30;
            trbSelfQuarantineRate.Maximum = 100;
            trbSelfQuarantineStrictness.Maximum = 100;
            trbInputFatalityRate.Maximum = 100;
            trbHospitalCapacity.Maximum = 100;

            TransmissionRate = -1;
            RetransmissionRate = -1;
            DaysInIncubation = -1;
            DurationOfSymptoms = -1;
            TravelRadius = -1;
            EncountersPerDay = -1;
            SelfQuarantineRate = -1;
            SelfQuarantineStrictness = -1;
            InputFatalityRate = -1;
            HospitalCapacity = -1;

        }

        private void trbTransmissionRate_Scroll(object sender, EventArgs e)
        {
            TransmissionRate = trbTransmissionRate.Value;
            lbTransmissionRateValue.Text = trbTransmissionRate.Value.ToString();
        }

        private void trbRetransmissionRate_Scroll(object sender, EventArgs e)
        {
            RetransmissionRate = trbRetransmissionRate.Value;
            lbRetransmissionRateValue.Text = trbRetransmissionRate.Value.ToString();
        }

        private void trbDaysInIncubation_Scroll(object sender, EventArgs e)
        {
            DaysInIncubation = trbDaysInIncubation.Value;
            lbDaysInIncubationValue.Text = trbDaysInIncubation.Value.ToString();
        }

        private void trbDurationOfSymptoms_Scroll(object sender, EventArgs e)
        {
            DurationOfSymptoms = trbDurationOfSymptoms.Value;
            lbDurationOfSymptomsValue.Text = trbDurationOfSymptoms.Value.ToString();
        }

        private void trbTravelRadius_Scroll(object sender, EventArgs e)
        {
            TravelRadius = trbTravelRadius.Value;
            lbTravelRadiusValue.Text = trbTravelRadius.Value.ToString();
        }

        private void trbEncountersPerDay_Scroll(object sender, EventArgs e)
        {
            EncountersPerDay = trbEncountersPerDay.Value;
            lbEncountersPerDayValue.Text = trbEncountersPerDay.Value.ToString();
        }

        private void trbSelfQuarantineRate_Scroll(object sender, EventArgs e)
        {
            SelfQuarantineRate = trbSelfQuarantineRate.Value;
            lbSelfQuarantineRateValue.Text = trbSelfQuarantineRate.Value.ToString();
        }

        private void trbSelfQuarantineStrictness_Scroll(object sender, EventArgs e)
        {
            SelfQuarantineStrictness = trbSelfQuarantineStrictness.Value;
            lbSelfQuarantineStrictnessValue.Text = trbSelfQuarantineStrictness.Value.ToString();
        }

        private void trbInputFatalityRate_Scroll(object sender, EventArgs e)
        {
            InputFatalityRate = trbInputFatalityRate.Value;
            lbInputFatalityRateValue.Text = trbInputFatalityRate.Value.ToString();
        }

        private void trbHospitalCapacity_Scroll(object sender, EventArgs e)
        {
            HospitalCapacity = trbHospitalCapacity.Value;
            lbHospitalCapacityValue.Text = trbHospitalCapacity.Value.ToString();
        }
    }
}
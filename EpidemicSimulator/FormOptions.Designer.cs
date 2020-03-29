namespace EpidemicSimulator
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.lbTransmissionRate = new System.Windows.Forms.Label();
            this.lbRetransmissionRate = new System.Windows.Forms.Label();
            this.lbDaysInIncubation = new System.Windows.Forms.Label();
            this.lbDurationOfSymptoms = new System.Windows.Forms.Label();
            this.lbTravelRadius = new System.Windows.Forms.Label();
            this.lbEncountersPerDay = new System.Windows.Forms.Label();
            this.lbSelfQuarantineRate = new System.Windows.Forms.Label();
            this.lbSelfQuarantineStrictness = new System.Windows.Forms.Label();
            this.lbInputFatalityRate = new System.Windows.Forms.Label();
            this.lbHospitalCapacity = new System.Windows.Forms.Label();
            this.trbTransmissionRate = new System.Windows.Forms.TrackBar();
            this.trbRetransmissionRate = new System.Windows.Forms.TrackBar();
            this.trbDaysInIncubation = new System.Windows.Forms.TrackBar();
            this.trbDurationOfSymptoms = new System.Windows.Forms.TrackBar();
            this.trbTravelRadius = new System.Windows.Forms.TrackBar();
            this.trbEncountersPerDay = new System.Windows.Forms.TrackBar();
            this.trbSelfQuarantineRate = new System.Windows.Forms.TrackBar();
            this.trbSelfQuarantineStrictness = new System.Windows.Forms.TrackBar();
            this.trbInputFatalityRate = new System.Windows.Forms.TrackBar();
            this.trbHospitalCapacity = new System.Windows.Forms.TrackBar();
            this.lbTransmissionRateValue = new System.Windows.Forms.Label();
            this.lbRetransmissionRateValue = new System.Windows.Forms.Label();
            this.lbDaysInIncubationValue = new System.Windows.Forms.Label();
            this.lbDurationOfSymptomsValue = new System.Windows.Forms.Label();
            this.lbTravelRadiusValue = new System.Windows.Forms.Label();
            this.lbEncountersPerDayValue = new System.Windows.Forms.Label();
            this.lbSelfQuarantineRateValue = new System.Windows.Forms.Label();
            this.lbSelfQuarantineStrictnessValue = new System.Windows.Forms.Label();
            this.lbInputFatalityRateValue = new System.Windows.Forms.Label();
            this.lbHospitalCapacityValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbTransmissionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRetransmissionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDaysInIncubation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDurationOfSymptoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTravelRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEncountersPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSelfQuarantineRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSelfQuarantineStrictness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbInputFatalityRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHospitalCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTransmissionRate
            // 
            this.lbTransmissionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTransmissionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransmissionRate.Location = new System.Drawing.Point(12, 9);
            this.lbTransmissionRate.Name = "lbTransmissionRate";
            this.lbTransmissionRate.Size = new System.Drawing.Size(300, 30);
            this.lbTransmissionRate.TabIndex = 0;
            this.lbTransmissionRate.Text = "ймовірність зараження";
            this.lbTransmissionRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRetransmissionRate
            // 
            this.lbRetransmissionRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRetransmissionRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRetransmissionRate.Location = new System.Drawing.Point(12, 48);
            this.lbRetransmissionRate.Name = "lbRetransmissionRate";
            this.lbRetransmissionRate.Size = new System.Drawing.Size(300, 30);
            this.lbRetransmissionRate.TabIndex = 1;
            this.lbRetransmissionRate.Text = "ймовірність повторного зараження";
            this.lbRetransmissionRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDaysInIncubation
            // 
            this.lbDaysInIncubation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDaysInIncubation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDaysInIncubation.Location = new System.Drawing.Point(12, 87);
            this.lbDaysInIncubation.Name = "lbDaysInIncubation";
            this.lbDaysInIncubation.Size = new System.Drawing.Size(300, 30);
            this.lbDaysInIncubation.TabIndex = 2;
            this.lbDaysInIncubation.Text = "інкубаційний період";
            this.lbDaysInIncubation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDurationOfSymptoms
            // 
            this.lbDurationOfSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDurationOfSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDurationOfSymptoms.Location = new System.Drawing.Point(12, 126);
            this.lbDurationOfSymptoms.Name = "lbDurationOfSymptoms";
            this.lbDurationOfSymptoms.Size = new System.Drawing.Size(300, 30);
            this.lbDurationOfSymptoms.TabIndex = 3;
            this.lbDurationOfSymptoms.Text = "тривалість симптомів";
            this.lbDurationOfSymptoms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTravelRadius
            // 
            this.lbTravelRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTravelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTravelRadius.Location = new System.Drawing.Point(12, 165);
            this.lbTravelRadius.Name = "lbTravelRadius";
            this.lbTravelRadius.Size = new System.Drawing.Size(300, 30);
            this.lbTravelRadius.TabIndex = 4;
            this.lbTravelRadius.Text = "радіус преміщення";
            this.lbTravelRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEncountersPerDay
            // 
            this.lbEncountersPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEncountersPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEncountersPerDay.Location = new System.Drawing.Point(12, 204);
            this.lbEncountersPerDay.Name = "lbEncountersPerDay";
            this.lbEncountersPerDay.Size = new System.Drawing.Size(300, 30);
            this.lbEncountersPerDay.TabIndex = 5;
            this.lbEncountersPerDay.Text = "контактів в день";
            this.lbEncountersPerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelfQuarantineRate
            // 
            this.lbSelfQuarantineRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelfQuarantineRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelfQuarantineRate.Location = new System.Drawing.Point(12, 243);
            this.lbSelfQuarantineRate.Name = "lbSelfQuarantineRate";
            this.lbSelfQuarantineRate.Size = new System.Drawing.Size(300, 30);
            this.lbSelfQuarantineRate.TabIndex = 6;
            this.lbSelfQuarantineRate.Text = "частота самоізоляції";
            this.lbSelfQuarantineRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelfQuarantineStrictness
            // 
            this.lbSelfQuarantineStrictness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelfQuarantineStrictness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelfQuarantineStrictness.Location = new System.Drawing.Point(12, 282);
            this.lbSelfQuarantineStrictness.Name = "lbSelfQuarantineStrictness";
            this.lbSelfQuarantineStrictness.Size = new System.Drawing.Size(300, 30);
            this.lbSelfQuarantineStrictness.TabIndex = 7;
            this.lbSelfQuarantineStrictness.Text = "строгість самоізоляції";
            this.lbSelfQuarantineStrictness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInputFatalityRate
            // 
            this.lbInputFatalityRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputFatalityRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInputFatalityRate.Location = new System.Drawing.Point(12, 321);
            this.lbInputFatalityRate.Name = "lbInputFatalityRate";
            this.lbInputFatalityRate.Size = new System.Drawing.Size(300, 30);
            this.lbInputFatalityRate.TabIndex = 8;
            this.lbInputFatalityRate.Text = "вхідна смертність";
            this.lbInputFatalityRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHospitalCapacity
            // 
            this.lbHospitalCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHospitalCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHospitalCapacity.Location = new System.Drawing.Point(12, 360);
            this.lbHospitalCapacity.Name = "lbHospitalCapacity";
            this.lbHospitalCapacity.Size = new System.Drawing.Size(300, 30);
            this.lbHospitalCapacity.TabIndex = 9;
            this.lbHospitalCapacity.Text = "місткість лікарень";
            this.lbHospitalCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbTransmissionRate
            // 
            this.trbTransmissionRate.AutoSize = false;
            this.trbTransmissionRate.Location = new System.Drawing.Point(318, 9);
            this.trbTransmissionRate.Name = "trbTransmissionRate";
            this.trbTransmissionRate.Size = new System.Drawing.Size(400, 30);
            this.trbTransmissionRate.TabIndex = 10;
            this.trbTransmissionRate.Scroll += new System.EventHandler(this.trbTransmissionRate_Scroll);
            // 
            // trbRetransmissionRate
            // 
            this.trbRetransmissionRate.AutoSize = false;
            this.trbRetransmissionRate.Location = new System.Drawing.Point(318, 48);
            this.trbRetransmissionRate.Name = "trbRetransmissionRate";
            this.trbRetransmissionRate.Size = new System.Drawing.Size(400, 30);
            this.trbRetransmissionRate.TabIndex = 11;
            this.trbRetransmissionRate.Scroll += new System.EventHandler(this.trbRetransmissionRate_Scroll);
            // 
            // trbDaysInIncubation
            // 
            this.trbDaysInIncubation.AutoSize = false;
            this.trbDaysInIncubation.Location = new System.Drawing.Point(318, 87);
            this.trbDaysInIncubation.Name = "trbDaysInIncubation";
            this.trbDaysInIncubation.Size = new System.Drawing.Size(400, 30);
            this.trbDaysInIncubation.TabIndex = 12;
            this.trbDaysInIncubation.Scroll += new System.EventHandler(this.trbDaysInIncubation_Scroll);
            // 
            // trbDurationOfSymptoms
            // 
            this.trbDurationOfSymptoms.AutoSize = false;
            this.trbDurationOfSymptoms.Location = new System.Drawing.Point(318, 126);
            this.trbDurationOfSymptoms.Name = "trbDurationOfSymptoms";
            this.trbDurationOfSymptoms.Size = new System.Drawing.Size(400, 30);
            this.trbDurationOfSymptoms.TabIndex = 13;
            this.trbDurationOfSymptoms.Scroll += new System.EventHandler(this.trbDurationOfSymptoms_Scroll);
            // 
            // trbTravelRadius
            // 
            this.trbTravelRadius.AutoSize = false;
            this.trbTravelRadius.Location = new System.Drawing.Point(318, 165);
            this.trbTravelRadius.Name = "trbTravelRadius";
            this.trbTravelRadius.Size = new System.Drawing.Size(400, 30);
            this.trbTravelRadius.TabIndex = 14;
            this.trbTravelRadius.Scroll += new System.EventHandler(this.trbTravelRadius_Scroll);
            // 
            // trbEncountersPerDay
            // 
            this.trbEncountersPerDay.AutoSize = false;
            this.trbEncountersPerDay.Location = new System.Drawing.Point(318, 204);
            this.trbEncountersPerDay.Name = "trbEncountersPerDay";
            this.trbEncountersPerDay.Size = new System.Drawing.Size(400, 30);
            this.trbEncountersPerDay.TabIndex = 15;
            this.trbEncountersPerDay.Scroll += new System.EventHandler(this.trbEncountersPerDay_Scroll);
            // 
            // trbSelfQuarantineRate
            // 
            this.trbSelfQuarantineRate.AutoSize = false;
            this.trbSelfQuarantineRate.Location = new System.Drawing.Point(318, 243);
            this.trbSelfQuarantineRate.Name = "trbSelfQuarantineRate";
            this.trbSelfQuarantineRate.Size = new System.Drawing.Size(400, 30);
            this.trbSelfQuarantineRate.TabIndex = 16;
            this.trbSelfQuarantineRate.Scroll += new System.EventHandler(this.trbSelfQuarantineRate_Scroll);
            // 
            // trbSelfQuarantineStrictness
            // 
            this.trbSelfQuarantineStrictness.AutoSize = false;
            this.trbSelfQuarantineStrictness.Location = new System.Drawing.Point(318, 282);
            this.trbSelfQuarantineStrictness.Name = "trbSelfQuarantineStrictness";
            this.trbSelfQuarantineStrictness.Size = new System.Drawing.Size(400, 30);
            this.trbSelfQuarantineStrictness.TabIndex = 17;
            this.trbSelfQuarantineStrictness.Scroll += new System.EventHandler(this.trbSelfQuarantineStrictness_Scroll);
            // 
            // trbInputFatalityRate
            // 
            this.trbInputFatalityRate.AutoSize = false;
            this.trbInputFatalityRate.Location = new System.Drawing.Point(318, 321);
            this.trbInputFatalityRate.Name = "trbInputFatalityRate";
            this.trbInputFatalityRate.Size = new System.Drawing.Size(400, 30);
            this.trbInputFatalityRate.TabIndex = 18;
            this.trbInputFatalityRate.Scroll += new System.EventHandler(this.trbInputFatalityRate_Scroll);
            // 
            // trbHospitalCapacity
            // 
            this.trbHospitalCapacity.AutoSize = false;
            this.trbHospitalCapacity.Location = new System.Drawing.Point(318, 361);
            this.trbHospitalCapacity.Name = "trbHospitalCapacity";
            this.trbHospitalCapacity.Size = new System.Drawing.Size(400, 30);
            this.trbHospitalCapacity.TabIndex = 19;
            this.trbHospitalCapacity.Scroll += new System.EventHandler(this.trbHospitalCapacity_Scroll);
            // 
            // lbTransmissionRateValue
            // 
            this.lbTransmissionRateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTransmissionRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTransmissionRateValue.Location = new System.Drawing.Point(724, 9);
            this.lbTransmissionRateValue.Name = "lbTransmissionRateValue";
            this.lbTransmissionRateValue.Size = new System.Drawing.Size(50, 30);
            this.lbTransmissionRateValue.TabIndex = 20;
            this.lbTransmissionRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRetransmissionRateValue
            // 
            this.lbRetransmissionRateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRetransmissionRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRetransmissionRateValue.Location = new System.Drawing.Point(724, 48);
            this.lbRetransmissionRateValue.Name = "lbRetransmissionRateValue";
            this.lbRetransmissionRateValue.Size = new System.Drawing.Size(50, 30);
            this.lbRetransmissionRateValue.TabIndex = 20;
            this.lbRetransmissionRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDaysInIncubationValue
            // 
            this.lbDaysInIncubationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDaysInIncubationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDaysInIncubationValue.Location = new System.Drawing.Point(724, 87);
            this.lbDaysInIncubationValue.Name = "lbDaysInIncubationValue";
            this.lbDaysInIncubationValue.Size = new System.Drawing.Size(50, 30);
            this.lbDaysInIncubationValue.TabIndex = 20;
            this.lbDaysInIncubationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDurationOfSymptomsValue
            // 
            this.lbDurationOfSymptomsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDurationOfSymptomsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDurationOfSymptomsValue.Location = new System.Drawing.Point(724, 126);
            this.lbDurationOfSymptomsValue.Name = "lbDurationOfSymptomsValue";
            this.lbDurationOfSymptomsValue.Size = new System.Drawing.Size(50, 30);
            this.lbDurationOfSymptomsValue.TabIndex = 20;
            this.lbDurationOfSymptomsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTravelRadiusValue
            // 
            this.lbTravelRadiusValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTravelRadiusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTravelRadiusValue.Location = new System.Drawing.Point(724, 165);
            this.lbTravelRadiusValue.Name = "lbTravelRadiusValue";
            this.lbTravelRadiusValue.Size = new System.Drawing.Size(50, 30);
            this.lbTravelRadiusValue.TabIndex = 20;
            this.lbTravelRadiusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEncountersPerDayValue
            // 
            this.lbEncountersPerDayValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEncountersPerDayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEncountersPerDayValue.Location = new System.Drawing.Point(724, 204);
            this.lbEncountersPerDayValue.Name = "lbEncountersPerDayValue";
            this.lbEncountersPerDayValue.Size = new System.Drawing.Size(50, 30);
            this.lbEncountersPerDayValue.TabIndex = 20;
            this.lbEncountersPerDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelfQuarantineRateValue
            // 
            this.lbSelfQuarantineRateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelfQuarantineRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelfQuarantineRateValue.Location = new System.Drawing.Point(724, 243);
            this.lbSelfQuarantineRateValue.Name = "lbSelfQuarantineRateValue";
            this.lbSelfQuarantineRateValue.Size = new System.Drawing.Size(50, 30);
            this.lbSelfQuarantineRateValue.TabIndex = 20;
            this.lbSelfQuarantineRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelfQuarantineStrictnessValue
            // 
            this.lbSelfQuarantineStrictnessValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelfQuarantineStrictnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelfQuarantineStrictnessValue.Location = new System.Drawing.Point(724, 282);
            this.lbSelfQuarantineStrictnessValue.Name = "lbSelfQuarantineStrictnessValue";
            this.lbSelfQuarantineStrictnessValue.Size = new System.Drawing.Size(50, 30);
            this.lbSelfQuarantineStrictnessValue.TabIndex = 20;
            this.lbSelfQuarantineStrictnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInputFatalityRateValue
            // 
            this.lbInputFatalityRateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputFatalityRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInputFatalityRateValue.Location = new System.Drawing.Point(724, 321);
            this.lbInputFatalityRateValue.Name = "lbInputFatalityRateValue";
            this.lbInputFatalityRateValue.Size = new System.Drawing.Size(50, 30);
            this.lbInputFatalityRateValue.TabIndex = 20;
            this.lbInputFatalityRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHospitalCapacityValue
            // 
            this.lbHospitalCapacityValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHospitalCapacityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHospitalCapacityValue.Location = new System.Drawing.Point(724, 360);
            this.lbHospitalCapacityValue.Name = "lbHospitalCapacityValue";
            this.lbHospitalCapacityValue.Size = new System.Drawing.Size(50, 30);
            this.lbHospitalCapacityValue.TabIndex = 20;
            this.lbHospitalCapacityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 403);
            this.Controls.Add(this.lbHospitalCapacityValue);
            this.Controls.Add(this.lbInputFatalityRateValue);
            this.Controls.Add(this.lbSelfQuarantineStrictnessValue);
            this.Controls.Add(this.lbSelfQuarantineRateValue);
            this.Controls.Add(this.lbEncountersPerDayValue);
            this.Controls.Add(this.lbTravelRadiusValue);
            this.Controls.Add(this.lbDurationOfSymptomsValue);
            this.Controls.Add(this.lbDaysInIncubationValue);
            this.Controls.Add(this.lbRetransmissionRateValue);
            this.Controls.Add(this.lbTransmissionRateValue);
            this.Controls.Add(this.trbHospitalCapacity);
            this.Controls.Add(this.trbInputFatalityRate);
            this.Controls.Add(this.trbSelfQuarantineStrictness);
            this.Controls.Add(this.trbSelfQuarantineRate);
            this.Controls.Add(this.trbEncountersPerDay);
            this.Controls.Add(this.trbTravelRadius);
            this.Controls.Add(this.trbDurationOfSymptoms);
            this.Controls.Add(this.trbDaysInIncubation);
            this.Controls.Add(this.trbRetransmissionRate);
            this.Controls.Add(this.trbTransmissionRate);
            this.Controls.Add(this.lbHospitalCapacity);
            this.Controls.Add(this.lbInputFatalityRate);
            this.Controls.Add(this.lbSelfQuarantineStrictness);
            this.Controls.Add(this.lbSelfQuarantineRate);
            this.Controls.Add(this.lbEncountersPerDay);
            this.Controls.Add(this.lbTravelRadius);
            this.Controls.Add(this.lbDurationOfSymptoms);
            this.Controls.Add(this.lbDaysInIncubation);
            this.Controls.Add(this.lbRetransmissionRate);
            this.Controls.Add(this.lbTransmissionRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbTransmissionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRetransmissionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDaysInIncubation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDurationOfSymptoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTravelRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEncountersPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSelfQuarantineRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSelfQuarantineStrictness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbInputFatalityRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHospitalCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTransmissionRate;
        private System.Windows.Forms.Label lbRetransmissionRate;
        private System.Windows.Forms.Label lbDaysInIncubation;
        private System.Windows.Forms.Label lbDurationOfSymptoms;
        private System.Windows.Forms.Label lbTravelRadius;
        private System.Windows.Forms.Label lbEncountersPerDay;
        private System.Windows.Forms.Label lbSelfQuarantineRate;
        private System.Windows.Forms.Label lbSelfQuarantineStrictness;
        private System.Windows.Forms.Label lbInputFatalityRate;
        private System.Windows.Forms.Label lbHospitalCapacity;
        private System.Windows.Forms.TrackBar trbTransmissionRate;
        private System.Windows.Forms.TrackBar trbRetransmissionRate;
        private System.Windows.Forms.TrackBar trbDaysInIncubation;
        private System.Windows.Forms.TrackBar trbDurationOfSymptoms;
        private System.Windows.Forms.TrackBar trbTravelRadius;
        private System.Windows.Forms.TrackBar trbEncountersPerDay;
        private System.Windows.Forms.TrackBar trbSelfQuarantineRate;
        private System.Windows.Forms.TrackBar trbSelfQuarantineStrictness;
        private System.Windows.Forms.TrackBar trbInputFatalityRate;
        private System.Windows.Forms.TrackBar trbHospitalCapacity;
        private System.Windows.Forms.Label lbTransmissionRateValue;
        private System.Windows.Forms.Label lbRetransmissionRateValue;
        private System.Windows.Forms.Label lbDaysInIncubationValue;
        private System.Windows.Forms.Label lbDurationOfSymptomsValue;
        private System.Windows.Forms.Label lbTravelRadiusValue;
        private System.Windows.Forms.Label lbEncountersPerDayValue;
        private System.Windows.Forms.Label lbSelfQuarantineRateValue;
        private System.Windows.Forms.Label lbSelfQuarantineStrictnessValue;
        private System.Windows.Forms.Label lbInputFatalityRateValue;
        private System.Windows.Forms.Label lbHospitalCapacityValue;
    }
}
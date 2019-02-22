using System;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CircuitCalculator.CalculusForms;
using CircuitCalculator.DataForms;
using CircuitCalculator.OtherForms;

namespace CircuitCalculator.Forms
{
    public partial class ResonanceCalculator : Form
    {
        readonly Random _randomNumber = new Random(1);
        private const string Factor = "cm";
        private const double SpeedOfLight = 2.99792458E8;

        //public delegate void SessionUpdateHandler(object sender,SessionEventArgs e);
        //public event SessionUpdateHandler SessionUpdated;

        public ResonanceCalculator()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ControlBox = false;
        }
        /// <summary>
        /// The load event for the resonance calculator form.
        /// </summary>
        private void ResonanceCalculatorLoad(object sender, EventArgs e)
        {
            int session = _randomNumber.Next(100);
            sessionValue.Text = session.ToString(CultureInfo.InvariantCulture);
            lengthFactor.SelectedItem = Factor;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(saveSessionSelectionBox, "If you would like to save your calculation session data in the database, check this box");
            toolTip.SetToolTip(userIdLabel, "Input your assigned User ID.");
            toolTip.SetToolTip(userIdTextBox, "The format should be 0-9, two to four-digit numbers. For example, '01', or '4367'");
            toolTip.SetToolTip(recallSessionButton, "Recall a stored session");
            toolTip.SetToolTip(recallSessionTextBox, "Input a stored Session ID");
            toolTip.SetToolTip(inductanceCalculatorButton, "The inductance calculator form");
            toolTip.SetToolTip(impedenceCalculatorButton, "The impedance calculator form");
            toolTip.SetToolTip(rcNetworkCalculatorButton, "The RC network resonance form");
            toolTip.SetToolTip(rlcNetworkCalculatorButton, "The RLC network resonance form");
            toolTip.SetToolTip(couplingCoefficentCacluatorButton, "The coupling coefficent calculator");
            toolTip.SetToolTip(resonanceEquationPictureBox, "The equation of the resonance of an LC circuit");
            toolTip.SetToolTip(capacitanceValueBox, "The calue of the capacitor in the circuit");
            toolTip.SetToolTip(capacitanceFactor, "The dimension of the capacitance");
            toolTip.SetToolTip(inductanceValueBox, "The value of the inductor in the circuit");
            toolTip.SetToolTip(inductanceFactor, "The dimension of the inductance");
            toolTip.SetToolTip(calculateButton, "Calculate the source frequency");
            toolTip.SetToolTip(calculateReceiverFrequencyButton, "Calculate the receiver frequency");
            toolTip.SetToolTip(resultBox, "The resonance frequency of the circuit");
            toolTip.SetToolTip(notepadButton, "The notepad window");
            toolTip.SetToolTip(efficiencyCalculatorButton, "The efficiency calculator form");
            toolTip.SetToolTip(qualityFactorCalculatorButton, "The quality factor calculator form");
            toolTip.SetToolTip(mutualInductanceCalculatorButton, "The mutual inductance calculator form");
            toolTip.SetToolTip(magneticFieldCalculatorButton, "The magnetic field (H) calculator form");
            toolTip.SetToolTip(matrixCalculatorButton, "The matrix calculator form");
            toolTip.SetToolTip(wavelengthResultBox, "Result is for a 1/4 wavelength");
            toolTip.SetToolTip(closeButton, "Exit the program");
            toolTip.SetToolTip(vectorPotentialFormButton, "The vector potential calculator form");
            toolTip.SetToolTip(vectorPotentialVisualizerFormButton, "The elliptical PDE visualizer form");
            toolTip.SetToolTip(apertureFormButton, "The antenna aperature form--high frequency");
            toolTip.SetToolTip(plotFormButton, "The function graphics plotter form");
            toolTip.SetToolTip(investorFormButton, "The investor record form");
            toolTip.SetToolTip(exportDataButton, "Export stored data");
            toolTip.SetToolTip(prototypeDataButton, "Data entry for any constructed prototypes");
            toolTip.SetToolTip(directCalculationSelection, "Select this button if you want to calculate the wavelength from the frequency");
            toolTip.SetToolTip(radiationResistanceCalculatorButton, "The fields and radiation calculator");
            toolTip.SetToolTip(integratorButton, "The symbolic integration calculator");
            toolTip.SetToolTip(energyPowerCalculatorButton, "The energy and power calculator form");
            toolTip.SetToolTip(ratioPowerButton, "The ratio-power calculator form");

        }
        /// <summary>
        /// Calculates the resonance frequency of the transmission coil.
        /// </summary>
        /// <param name="cap">The capacitance.</param>
        /// <param name="ind">The inductance.</param>
        public double CalculateResonance(string cap, string ind)
        {
            double capacitance = 0;
            double inductance = 0;

            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);
            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);

            if (capacitanceFactor.Text == @"uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == @"nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == @"pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            if (inductanceFactor.Text == @"H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor.Text == @"mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == @"uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor.Text == @"nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor.Text == @"pH")
            {
                inductance = tempInductance * 1E-12;
            }
            // Perform the calculation.
            double sqrt = Math.Sqrt(inductance * capacitance);
            double result = 1 / (2 * Math.PI * sqrt);

            //decimal result = Decimal.Parse(result, NumberStyles.AllowExponent); // Returns the resonance frequency in exponent (Hertz).
            resultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            return result;
        }
        /// <summary>
        /// Calculates the wavelength.
        /// </summary>
        public double CalculateWavelength()
        {
            double frequency = Convert.ToDouble(resultBox.Text);
            double wavelength = SpeedOfLight / frequency;
            wavelengthResultBox.Text = wavelength.ToString(CultureInfo.InvariantCulture);
            lengthFactor.Text = @"m";
            return wavelength;
        }
        /// <summary>
        /// Calculates the wavelength.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        public double CalculateWavelength(double frequency)
        {
            double wavelength = SpeedOfLight / frequency;
            wavelengthResultBox.Text = wavelength.ToString(CultureInfo.InvariantCulture);
            return wavelength;
        }
        /// <summary>
        /// Calculates the resonance frequency of the receiver coil.
        /// </summary>
        /// <param name="cap">The capacitance.</param>
        /// <param name="ind">The inductance.</param>
        public double CalculateResonance2(string cap, string ind)
        {
            double capacitance = 0;
            double inductance = 0;

            double tempCapacitance = Convert.ToDouble(receiverCapacitanceValueBox.Text);
            double tempInductance = Convert.ToDouble(receiverInductanceValueBox.Text);

            if (capacitanceFactor2.Text == @"uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor2.Text == @"nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor2.Text == @"pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            if (inductanceFactor2.Text == @"H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor2.Text == @"mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor2.Text == @"uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor2.Text == @"nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor2.Text == @"pH")
            {
                inductance = tempInductance * 1E-12;
            }
            // Perform the calculation.
            double sqrt = Math.Sqrt(inductance * capacitance);
            double result = 1 / (2 * Math.PI * sqrt);

            //decimal result = Decimal.Parse(result, NumberStyles.AllowExponent); // Returns the resonance frequency in exponent (Hertz).
            receiverFrequencyResultBox.Text = result.ToString(CultureInfo.InvariantCulture);


            return result;
        }
        /// <summary>
        /// Calculates the differential resonance frequency.
        /// </summary>
        public double CalculateDifferential()
        {
            // Calculate average (system resonant frequency).
            double fi = Convert.ToDouble(resultBox.Text);
            double fj = Convert.ToDouble(receiverFrequencyResultBox.Text);
            double average = (fi + fj) / 2;
            systemResonanceFrequencyResultBox.Text = average.ToString(CultureInfo.InvariantCulture);
            // Calculate differential.
            double differential = Math.Abs(fi - fj);
            differentialFrequencyResultBox.Text = differential.ToString(CultureInfo.InvariantCulture);
            // Calculate outside bandwidth.
            double f0Dt = Math.Abs(average + differential);
            systemPlusDifferentialResultBox.Text = f0Dt.ToString(CultureInfo.InvariantCulture);
            return average;
        }

        #region Click Events
        /// <summary>
        /// Handles the Click event of the calculateButton control.
        /// </summary>
        private void CalculateButtonClick(object sender, EventArgs e)
        {
            if (directCalculationSelection.Checked)
            {
                double freq = Convert.ToDouble(resultBox.Text);
                lengthFactor.Text = @"m";
                Refresh();
                CalculateWavelength(freq);
            }
            else
            {
                if (capacitanceValueBox.Text == "" | inductanceValueBox.Text == "")
                {
                    MessageBox.Show(@"Value boxes cannot be empty.", @"Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    CalculateResonance(capacitanceValueBox.Text, inductanceValueBox.Text);
                    CalculateWavelength();
                }
            }
        }
        /// <summary>
        /// Runs the calculation of the receiver group box: Frequency, the differential with the transmitter, and the bandwidth.
        /// </summary>
        private void CalculateReceiverFrequencyButtonClick(object sender, EventArgs e)
        {
            if (receiverCapacitanceValueBox.Text == "" | receiverInductanceValueBox.Text == "")
            {
                MessageBox.Show(@"Value boxes cannot be empty.", @"Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CalculateResonance2(receiverCapacitanceValueBox.Text, receiverInductanceValueBox.Text);
                CalculateDifferential();
            }
        }
        /// <summary>
        /// Opens an instance of the Inductance Calculator Form.
        /// </summary>
        private void InductanceCalculatorButtonClick(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.SetData("SessionID", sessionValue.Text);

            if (InductanceCalculator.Instance == false)
            {
                InductanceCalculator form = new InductanceCalculator(this);
                form.Show(this);
                InductanceCalculator.Instance = true;
            }
            else if (InductanceCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens an instance of the Notepad window.
        /// </summary>
        private void NotepadButtonClick(object sender, EventArgs e)
        {
            if (NoteTextPanel.Instance == false)
            {
                NoteTextPanel form = new NoteTextPanel(this);
                form.Show(this);
                NoteTextPanel.Instance = true;
            }
            else if (NoteTextPanel.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens an instance of the Inductance Calculator Form.
        /// </summary>
        private void ImpedenceCalculatorButtonClick(object sender, EventArgs e)
        {
            if (ImpedanceCalculator.Instance == false)
            {
                ImpedanceCalculator form = new ImpedanceCalculator(this);
                form.Show(this);
                ImpedanceCalculator.Instance = true;
            }
            else if (ImpedanceCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens an instance of the RC Calculator.
        /// </summary>
        private void RcCalculatorButtonClick(object sender, EventArgs e)
        {
            if (RCNetworkCalculator.Instance == false)
            {
                RCNetworkCalculator form = new RCNetworkCalculator(this);
                form.Show(this);
                RCNetworkCalculator.Instance = true;
            }
            else if (RCNetworkCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens an instance of the RLC Calculator.
        /// </summary>
        private void RlcNetworkCalculatorButtonClick(object sender, EventArgs e)
        {
            if (RLCNetworkCalculator.Instance == false)
            {
                RLCNetworkCalculator form = new RLCNetworkCalculator(this);
                form.Show(this);
                RLCNetworkCalculator.Instance = true;
            }
            else if (RLCNetworkCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the coupling coefficent calculator form.
        /// </summary>
        private void CouplingCoefficentCacluatorButtonClick(object sender, EventArgs e)
        {
            if (CouplingCoefficientCalculator.Instance == false)
            {
                CouplingCoefficientCalculator form = new CouplingCoefficientCalculator(this);
                form.Show(this);
                CouplingCoefficientCalculator.Instance = true;
            }
            else if (CouplingCoefficientCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the ratio power calculator form.
        /// </summary>
        private void ratioPowerButton_Click(object sender, EventArgs e)
        {
            if (RatioPowerCalculator.Instance == false)
            {
                var form = new RatioPowerCalculator(this);
                form.Show(this);
                RatioPowerCalculator.Instance = true;
            }
            else if (RatioPowerCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Exports data from the database.
        /// </summary>
        private void ExportDataButtonClick(object sender, EventArgs e)
        {
            // Export to a text file.
        }
        /// <summary>
        /// Cleans up resources and closes the application.
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        /// <summary>
        /// Generates a session ID based on the input user ID.
        /// </summary>
        private void GenerateSessionButtonClick(object sender, EventArgs e)
        {
            int seed = 1;
            if (userIdTextBox.Text == "")
                MessageBox.Show(@"Input a user ID to create your session ID", @"User ID Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            seed = Convert.ToInt16(userIdTextBox.Text);
            Random randomNumberSeeded = new Random(seed);
            int sessionSeed = randomNumberSeeded.Next(10000);
            sessionValue.Text = sessionSeed.ToString(CultureInfo.InvariantCulture);
            //seed = Convert.ToInt16(sessionValue.Text) + 20;
        }
        /// <summary>
        /// Recall a session.
        /// </summary>
        private void RecallSessionButtonClick(object sender, EventArgs e)
        {
            // Recall the data by session ID.
            if (recallSessionTextBox.Text != "")
            {
                // Search the database for the requested ID and fill the boxes with data.
            }
            else
                MessageBox.Show(@"Input a session value first.", @"Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        /// <summary>
        /// Call the stored data form.
        /// </summary>
        private void ReviewStoredDataButtonClick(object sender, EventArgs e)
        {
            //string session = sessionValue.Text;
            //SessionEventArgs args = new SessionEventArgs(session);

            // Raise the event with the updated arguments.
            //SessionUpdated(this, args);

            AppDomain.CurrentDomain.SetData("SessionID", sessionValue.Text);

            if (StoreCalculationData.Instance == false)
            {
                var form = new StoreCalculationData(this);
                form.Show(this);
                StoreCalculationData.Instance = true;
            }
            else if (StoreCalculationData.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Saves the session information.
        /// </summary>
        private void SaveSessionSelectionBoxClick(object sender, EventArgs e)
        {
            if (userIdTextBox.Text != "" && sessionValue.Text != "")
            {
                // Store the user and session IDs.
                string directory = MapPath(@"\db\sessions.db");
                const string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO UserData (SessionID, UserID) VALUES ('" + sessionValue.Text + "', '" + userIdTextBox.Text + "')";
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                trans.Dispose();
                cmd.Dispose();
                conn.Dispose();
            }
            else
                MessageBox.Show(@"Input a UserID and create a SessionID before choosing to save your session.", @"Session Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            saveSessionSelectionBox.Checked = false;

        }
        /// <summary>
        /// Call the stored prototype specification data form.
        /// </summary>
        private void PrototypeDataButtonClick(object sender, EventArgs e)
        {
            if (PrototypeDataPanel.Instance == false)
            {
                var form = new PrototypeDataPanel(this);
                form.Show(this);
                PrototypeDataPanel.Instance = true;
            }
            else if (PrototypeDataPanel.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Call the efficiency calculation form.
        /// </summary>
        private void EfficiencyCalculatorButtonClick(object sender, EventArgs e)
        {
            if (EfficiencyCalculator.Instance == false)
            {
                var form = new EfficiencyCalculator(this);
                form.Show(this);
                EfficiencyCalculator.Instance = true;
            }
            else if (EfficiencyCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the quality factor calculation form.
        /// </summary>
        private void QualityFactorCalculatorButtonClick(object sender, EventArgs e)
        {
            if (QualityFactorCalculator.Instance == false)
            {
                var form = new QualityFactorCalculator(this);
                form.Show(this);
                QualityFactorCalculator.Instance = true;
            }
            else if (QualityFactorCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the mutual inductance calculation form.
        /// </summary>
        private void MutualInductanceCalculatorButtonClick(object sender, EventArgs e)
        {
            if (MutualInductanceCalculator.Instance == false)
            {
                var form = new MutualInductanceCalculator(this);
                form.Show(this);
                MutualInductanceCalculator.Instance = true;
            }
            else if (MutualInductanceCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the investor data record form.
        /// </summary>
        private void InvestorFormButtonClick(object sender, EventArgs e)
        {
            if (InvestorInteractionForm.Instance == false)
            {
                var form = new InvestorInteractionForm(this);
                form.Show(this);
                InvestorInteractionForm.Instance = true;
            }
            else if (InvestorInteractionForm.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the magnetic field calculator form.
        /// </summary>
        private void MagneticFieldCalculatorButtonClick(object sender, EventArgs e)
        {
            if (MagneticFieldCalculator.Instance == false)
            {
                var form = new MagneticFieldCalculator(this);
                form.Show(this);
                MagneticFieldCalculator.Instance = true;
            }
            else if (MagneticFieldCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the matrix calculator form.
        /// </summary>
        private void MatrixCalculatorButtonClick(object sender, EventArgs e)
        {
            if (MatrixCalculator.Instance == false)
            {
                var form = new MatrixCalculator(this);
                form.Show(this);
                MatrixCalculator.Instance = true;
            }
            else if (MatrixCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the equation plotting form.
        /// </summary>
        private void PlotFormButtonClick(object sender, EventArgs e)
        {
            if (PlotDataForm.Instance == false)
            {
                var form = new PlotDataForm(this);
                form.Show(this);
                PlotDataForm.Instance = true;
            }
            else if (PlotDataForm.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Changes the scale of the result.
        /// </summary>
        private void LengthFactorSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lengthFactor.SelectedItem.ToString() == "cm" && wavelengthResultBox.Text != "")
            {
                double theFactor = Convert.ToDouble(wavelengthResultBox.Text);
                double result = theFactor * 1E2;
                wavelengthResultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            else if (lengthFactor.SelectedItem.ToString() == "m" && wavelengthResultBox.Text != "")
            {
                double theFactor = Convert.ToDouble(wavelengthResultBox.Text);
                double result = theFactor * 1E-2;
                wavelengthResultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            }
        }
        /// <summary>
        /// Resets the direct calculation command to false.
        /// </summary>
        private void CapacitanceFactorSelectedIndexChanged(object sender, EventArgs e)
        {
            directCalculationSelection.Checked = false;
            Refresh();
        }
        /// <summary>
        /// Resets the direct calculation command to false.
        /// </summary>
        private void InductanceFactorSelectedIndexChanged(object sender, EventArgs e)
        {
            directCalculationSelection.Checked = false;
            Refresh();
        }
        /// <summary>
        /// Opens the aperture (antennas) form.
        /// </summary>
        private void ApertureFormButtonClick(object sender, EventArgs e)
        {
            if (AntennaAperture.Instance == false)
            {
                var form = new AntennaAperture(this);
                form.Show(this);
                AntennaAperture.Instance = true;
            }
            else if (AntennaAperture.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the vector potential calculator form.
        /// </summary>
        private void vectorPotentialFormButton_Click(object sender, EventArgs e)
        {
            if (VectorPotentialCalculator.Instance == false)
            {
                VectorPotentialCalculator form = new VectorPotentialCalculator(this);
                form.Show(this);
                VectorPotentialCalculator.Instance = true;
            }
            else if (VectorPotentialCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calls the vector potential visualizer form.
        /// </summary>
        private void vectorPotentialVisualizerFormButton_Click(object sender, EventArgs e)
        {
            if (VectorExpressionForm.Instance == false)
            {
                VectorExpressionForm form = new VectorExpressionForm(this);
                form.Show(this);
                VectorExpressionForm.Instance = true;
            }
            else if (VectorExpressionForm.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the project form.
        /// </summary>
        private void projectFormButton_Click(object sender, EventArgs e)
        {
            if (ProjectDataForm.Instance == false)
            {
                ProjectDataForm form = new ProjectDataForm(this);
                form.Show(this);
                ProjectDataForm.Instance = true;
            }
            else if (ProjectDataForm.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the fields and radiation calculator.
        /// </summary>
        private void radiationResistanceCalculatorButton_Click(object sender, EventArgs e)
        {
            if (FieldsRadiativeCalculator.Instance == false)
            {
                FieldsRadiativeCalculator form = new FieldsRadiativeCalculator(this);
                form.Show(this);
                FieldsRadiativeCalculator.Instance = true;
            }
            else if (FieldsRadiativeCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the energy and power calculator.
        /// </summary>
        private void energyPowerCalculatorButton_Click(object sender, EventArgs e)
        {
            if (EnergyPowerCalculator.Instance == false)
            {
                EnergyPowerCalculator form = new EnergyPowerCalculator(this);
                form.Show(this);
                EnergyPowerCalculator.Instance = true;
            }
            else if (EnergyPowerCalculator.Instance)
            {
                // Do nothing.
            }
            
        }
        /// <summary>
        /// Opens the integrator form.
        /// </summary>
        private void integratorButton_Click(object sender, EventArgs e)
        {
            if (IntegrationCalculator.Instance == false)
            {
                IntegrationCalculator form = new IntegrationCalculator(this);
                form.Show(this);
                IntegrationCalculator.Instance = true;
            }
            else if (IntegrationCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the machine data form.
        /// </summary>
        private void physicalElectricalMachineDataFormButton_Click(object sender, EventArgs e)
        {
            if (StorePhysicalElectricalMachineData.Instance == false)
            {
                var form = new StorePhysicalElectricalMachineData(this);
                form.Show(this);
                StorePhysicalElectricalMachineData.Instance = true;
            }
            else if (StorePhysicalElectricalMachineData.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Shows the about this program window.
        /// </summary>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Experimenter's Station" + Environment.NewLine + @"Cartheur Robotics, spol. s r.o." + Environment.NewLine + @"Copyright © 2010 - 2018", @"About this program", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        #endregion

        #region Receiver Frequency Group Box
        /// <summary>
        /// Displays the equation for the frequency of the scheme.
        /// </summary>
        private void frequencyEquationButton_Click(object sender, EventArgs e)
        {
            if (ResonanceFrequency.Instance == false)
            {
                ResonanceFrequency form = new ResonanceFrequency(this);
                form.Show(this);
                ResonanceFrequency.Instance = true;
            }
            else if (ResonanceFrequency.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Displays the equation for the differential with the transmitter.
        /// </summary>
        private void differentialFrequencyButton_Click(object sender, EventArgs e)
        {
            if (DifferentialFrequency.Instance == false)
            {
                DifferentialFrequency form = new DifferentialFrequency(this);
                form.Show(this);
                DifferentialFrequency.Instance = true;
            }
            else if (DifferentialFrequency.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Displays the equation for the bandwidth.
        /// </summary>
        private void bandwidthButton_Click(object sender, EventArgs e)
        {
            if (Bandwidth.Instance == false)
            {
                Bandwidth form = new Bandwidth(this);
                form.Show(this);
                Bandwidth.Instance = true;
            }
            else if (Bandwidth.Instance)
            {
                // Do nothing.
            }
        }
        #endregion

        /// <summary>
        /// Maps the path of the executing file.
        /// </summary>
        /// <param name="path">The path to map.</param>
        public virtual string MapPath(string path)
        {
           // string location = Assembly.GetEntryAssembly().Location;
            string zebra = AppDomain.CurrentDomain.BaseDirectory;
            //string local = Environment.CurrentDirectory;
            return Path.Combine(zebra, path);
        }

    }

    public class SessionEventArgs : EventArgs
    {
        private readonly string _sessionid;

        public SessionEventArgs(string sessionID)
        {
            _sessionid = sessionID;
        }
        /// <summary>
        /// Gets the session ID. Accessible by the listener.
        /// </summary>
        public string SessionID { get { return _sessionid; } }

    }
}

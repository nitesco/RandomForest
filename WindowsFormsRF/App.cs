using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsRF
{
    public partial class App : Form
    {
        public static App AppForm;

        string trainingFilePath;
        string inputFilePath;
        List<BuildDecisionTree> forest;

        public App()
        {
            InitializeComponent();
            AppForm = this;
        }

        public int ProgressBarValue { get { return progressBar.Value; } set { progressBar.Value = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Comma-Separated Values (*.data, *.csv, *.txt)|*.DATA;*.CSV;*.TXT";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                trainingFilePath = ofd.FileName;
                Parser ps = new Parser(trainingFilePath);
                if (ps.Data == null) return; 
                FillDataGridView(trainingGridView, ps.Data, ps.Rows, ps.Cols);

                progressBar.Value = 0;

                OpenInputButton.Enabled = true;
                buildingButton.Enabled = true;
                classifyButton.Enabled = false;
                ConfigBox.Enabled = true;
                clearButton.Enabled = true;

                DataTabs.SelectedTab = trainingTab;
            }                      
        }

        private void OpenLearningButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Comma-Separated Values (*.data, *.csv, *.txt)|*.DATA;*.CSV;*.TXT";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = ofd.FileName;
                Parser ps = new Parser(inputFilePath);
                if (ps.Data == null) return;
                FillDataGridView(inputGridView, ps.Data, ps.Rows, ps.Cols);

                progressBar.Value = 0;

                DataTabs.SelectedTab = inputTab;

                if (forest != null) classifyButton.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputFilePath != null) classifyButton.Enabled = true;

            BuildDecisionTree.entropyThreshold = (double)ThresholdUpDown.Value;
            BuildDecisionTree.minItemsCount = (int)MinItemsCountUpDown.Value;
            BuildDecisionTree.categoryAttribute = "Category";

            RandomForest.maxTreeDepth = (int)MaxTreeDepthUpDown.Value;
            RandomForest.numberOfTrees = (int)NumberOfTreesUpDown.Value;

            Parser trainingReader = new Parser(trainingFilePath);
            Hashtable[] trainingSet = trainingReader.ToDataSet("TrainingData");

            progressBar.Value = 1;
            progressBar.Visible = true;
            progressBar.Maximum = (int)NumberOfTreesUpDown.Value + 1;

            RandomForest rf = new RandomForest(trainingSet);
            forest = rf.Forest;
        }

        private void classifyButton_Click(object sender, EventArgs e)
        {
            if (!CheckCompatibility()) return;
            Parser inputReader = new Parser(inputFilePath);
            Hashtable[] inputSet = inputReader.ToDataSet("InputData");

            Predict pr = new Predict(forest, inputSet);
            FillResultsGridView(resultsGridView, pr.ResultsData);

            DataTabs.SelectedTab = resultsTab;
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            trainingFilePath = null;
            inputFilePath = null;
            forest = null;

            classifyButton.Enabled = false;
            buildingButton.Enabled = false;

            trainingGridView.Rows.Clear();
            inputGridView.Rows.Clear();
            resultsGridView.Rows.Clear();

            progressBar.Value = 0;
            progressBar.Visible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void NumberOfTreesUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MinItemsCountUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        void FillDataGridView(DataGridView grid, string[,] DataArray, int rows, int cols)
        {       
            grid.RowCount = rows;
            grid.ColumnCount = cols;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    grid.Rows[i].Cells[j].Value = DataArray[i, j];
        }

        void FillResultsGridView(DataGridView grid, Hashtable[] DataSet)
        {
            int rows = DataSet.Length;
            int cols = DataSet[0].Count;

            grid.RowCount = rows;
            grid.ColumnCount = cols;

            for (int i = 0; i < rows; i++)
            {
                int j = 0;
                ICollection keys = DataSet[i].Keys;
                foreach (object key in keys)
                {
                   grid.Rows[i].Cells[j].Value = DataSet[i][key];
                   j++;
                }
            }
        }

        bool CheckCompatibility()
        {
            Parser inputCheck = new Parser(inputFilePath);
            Parser trainingCheck = new Parser(trainingFilePath);

            if (inputCheck.Cols == trainingCheck.Cols - 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("It seems that input data \n don't match with training data. \n Try to load a new file.", "Error");
                return false;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaxTreeDepthUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        

        private void progressBar_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}

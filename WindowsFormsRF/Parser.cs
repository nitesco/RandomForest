using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsRF
{
    class Parser
    {
        string[,] data;
        public string[,] Data { get { return data; } }

        int rows, cols;
        public int Rows { get { return rows; } }
        public int Cols { get { return cols; } }

        public Parser(string FilePath)
        {

            try
            {
                CountDataLength(FilePath);
                if (rows <= 1 || cols <= 1) throw new Exception();

                Parse(FilePath);
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("The selected file is in the wrong format. For Data File, the type should be a 'CSV' fomat", "Exception");
                data = null;
                return;
            }

            catch (Exception)
            {
                MessageBox.Show("The selected file is in the wrong format", "Exception");
                data = null;
                return;
            }
 
        }

        void Parse(string FilePath)
        {
            using (TextFieldParser tfp = new TextFieldParser(FilePath))
            {
                data = new string[rows, cols];

                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");

                for (int i = 0; i < rows; i++)
                {
                    string[] temp = tfp.ReadFields();
                    for (int j = 0; j < cols; j++)
                    {
                        data[i, j] = temp[j];
                    }
                }

                tfp.Close();
                tfp.Dispose();
            }
        }

        public Hashtable[] ToDataSet(string dataType)
        {
            Hashtable[] hashArray = new Hashtable[rows];

            int k = 0;
            if (dataType == "TrainingData") k = 1;

            for (int i = 0; i < rows; i++)
            {
                Hashtable ht = new Hashtable();

                for (int j = 0; j < cols - k; j++)
                    ht.Add(Convert.ToString(j), Convert.ToDouble(data[i, j], CultureInfo.InvariantCulture));

                if(dataType == "TrainingData") ht.Add("Category", data[i, cols - 1]);

                hashArray[i] = ht;
            }
         
            return hashArray;
        }

        void CountDataLength(string FilePath)
        {
            using (TextFieldParser tfp = new TextFieldParser(FilePath))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");

                string[] firstRow = tfp.ReadFields();

                rows = 1;
                cols = firstRow.Length;

                while (!tfp.EndOfData)
                {
                    tfp.ReadFields();
                    rows++;
                }

                tfp.Close();
                tfp.Dispose();
            }

        } 
     
    }
}

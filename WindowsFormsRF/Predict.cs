using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsRF
{
    class Predict
    {
        Hashtable[] resultsData;
        public Hashtable[] ResultsData { get => resultsData;}

        public Predict(List<BuildDecisionTree> forest, Hashtable[] inputData)
        {
            resultsData = new Hashtable[inputData.Length];

            for (int i = 0; i < inputData.Length; i++)
            {
                Hashtable item = inputData[i];

                Hashtable votingResults = new Hashtable();

                foreach (BuildDecisionTree tree in forest)
                {
                    // Creating a classifier for each tree-item combination
                    Classifier cf = new Classifier(tree, item);
                  
                    int counter = Convert.ToInt16(votingResults[cf.Result]) + 1;
                    votingResults[cf.Result] = counter;
                }

                int max = 0;
                string maxResult = null;

                // Finding category with the max number of votes
                ICollection keys = votingResults.Keys;
                foreach (string key in keys)
                {
                    int counter = (int)votingResults[key];
                    if (counter > max)
                    {
                        max = counter;
                        maxResult = key;
                    }
                }

                item.Add("Category", maxResult);
                resultsData[i] = item;
                
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsRF
{
    class RandomForest
    {
        List<BuildDecisionTree> forest;
        public List<BuildDecisionTree> Forest { get => forest; }

        public static int numberOfTrees;
        public static int maxTreeDepth;

        public RandomForest(Hashtable[] trainingSet)
        {
            forest = new List<BuildDecisionTree>();
            List<Hashtable> trainingList = new List<Hashtable>(trainingSet);

            // Building a single decision tree
            if (numberOfTrees == 1)
            {                
                Hashtable[] trainingHash = trainingList.ToArray();
                BuildDecisionTree singleTree = new BuildDecisionTree(trainingHash, maxTreeDepth);

                forest.Add(singleTree);
                App.AppForm.ProgressBarValue++;
                return;
            }

            
            Random random = new Random();
            trainingList.Shuffle(random);

            // Building a forest of random decision trees
            for (int i = 0; i < numberOfTrees; i++)
            {
                List<Hashtable> randomTrainingList = new List<Hashtable>();
                randomTrainingList = getRandomSubset(trainingList, i + 2);

                Hashtable[] trainingHash = randomTrainingList.ToArray();
                BuildDecisionTree tree = new BuildDecisionTree(trainingHash, maxTreeDepth);

                forest.Add(tree);
                App.AppForm.ProgressBarValue++;
            }
                
        }

        private static List<Hashtable> getRandomSubset(List<Hashtable> dataSet, int excepted)
        {
            List<Hashtable> result = new List<Hashtable>();

            for (int i = 0; i < dataSet.Count(); i++)
            {
                if ((i % excepted) != 0)
                {
                    result.Add(dataSet[i]);
                }
            }

            return result;
        }

    }

}

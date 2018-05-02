using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace WindowsFormsRF
{
    class BuildDecisionTree
    {
        public static double entropyThreshold;
        public static int minItemsCount;
        public static string categoryAttribute;

        string category;
        public string Category { get { return category; } }

        string splitAttribute;
        public string SplitAttribute { get { return splitAttribute; } }

        double splitPivot;
        public double SplitPivot { get { return splitPivot; } }

        BuildDecisionTree matchSubTree;
        public BuildDecisionTree MatchSubTree { get { return matchSubTree; } }

        BuildDecisionTree notMatchSubTree;
        public BuildDecisionTree NotMatchSubTree { get { return notMatchSubTree; } }

        int matchedLength, notMatchedLength;
        public int MatchedLength { get { return matchedLength; } }
        public int NotMatchedLength { get { return notMatchedLength; } }

        public BuildDecisionTree(Hashtable[] trainingSet, int maxTreeDepth)
        {
            {
                // Checking if maxTreeDepth/minItemsCount is reached
                if (maxTreeDepth == 0 || trainingSet.Length <= minItemsCount)
                {
                    category = MostFrequentValue(trainingSet, categoryAttribute);
                    return;
                }

                double initialEntropy = Entropy(trainingSet, categoryAttribute);

                // Checking if entropyThreshold is reached
                if (initialEntropy <= entropyThreshold)
                {
                    category = MostFrequentValue(trainingSet, categoryAttribute);
                    return;
                }
            
                Hashtable bestSplit = new Hashtable();
                bestSplit.Add("gain", 0);
            
                List<string> alreadyChecked = new List<string>();

                for (int i = 0; i < trainingSet.Length; i++)
                {
                    Hashtable instance = trainingSet[i];
                    ICollection keys = instance.Keys;

                    // Iterating over all attributes of instance
                    foreach (object attribute in keys)
                    {
                        if (Convert.ToString(attribute) == categoryAttribute) continue;

                        // Let the value of current attribute be the pivot
                        double pivot = (Convert.ToDouble(instance[attribute]));

                        string attributePivot = attribute + Convert.ToString(pivot);

                        if (alreadyChecked.Contains(attributePivot)) continue;

                        alreadyChecked.Add(attributePivot);

                        // Splitting training set 
                        Hashtable currentSplit = Split(trainingSet, attribute, pivot);

                        // Calculating entropy of subsets
                        double matchEntropy = Entropy((Hashtable[])currentSplit["match"], categoryAttribute);
                        double notMatchEntropy = Entropy((Hashtable[])currentSplit["notMatch"], categoryAttribute);

                        // Calculating informational gain
                        double newEntropy = 0;
                        newEntropy += matchEntropy * ((Hashtable[])currentSplit["match"]).Length;
                        newEntropy += notMatchEntropy * ((Hashtable[])currentSplit["notMatch"]).Length; 
                        newEntropy /= trainingSet.Length;

                        double currentGain = initialEntropy - newEntropy;

                        if (currentGain > Convert.ToDouble(bestSplit["gain"]))
                        {
                            bestSplit = currentSplit;
                            bestSplit.Add("splitAttribute", attribute);
                            bestSplit.Add("splitPivot", pivot);
                            bestSplit.Add("gain", currentGain);
                        }
                    }
                }

                if (Convert.ToDouble(bestSplit["gain"]) == 0)
                    category = MostFrequentValue(trainingSet, categoryAttribute);

                // Building subtrees
                maxTreeDepth--;
                matchSubTree = new BuildDecisionTree((Hashtable[])bestSplit["match"], maxTreeDepth);              
                notMatchSubTree = new BuildDecisionTree((Hashtable[])bestSplit["notMatch"], maxTreeDepth);

                splitAttribute = Convert.ToString(bestSplit["splitAttribute"]);
                splitPivot = Convert.ToDouble(bestSplit["splitPivot"]);
                matchedLength = ((Hashtable[])bestSplit["match"]).Length;
                notMatchedLength = ((Hashtable[])bestSplit["notMatch"]).Length;
            }
        }   
            
        Dictionary<string, double> CountUniqueValues(Hashtable[] dataSet, string feature)
        {
            Dictionary<string, double> counter = new Dictionary<string, double>();
            // detecting different values of attribute
            for (int i = dataSet.Length - 1; i >= 0; i--)
                counter[(string)dataSet[i][feature]] = 0;  // dataSet[i][feature] - value of feature

            // counting number of occurrences of each of values of attribute
            for (int i = dataSet.Length - 1; i >= 0; i--)
                counter[(string)dataSet[i][feature]] += 1;

            return counter;
        }

        double Entropy(Hashtable[] dataSet, string attribute)
        {
            Dictionary<string, double> counter = CountUniqueValues(dataSet, attribute);
            double entropy = 0;
            double p;

            ICollection<string> keys = counter.Keys;

            foreach (string element in keys)
            {
                p = counter[element] / dataSet.Length;
                entropy += -p * Math.Log(p);
            }

            return entropy;
        }

        string MostFrequentValue(Hashtable[] dataSet, string attribute)
        {
            Dictionary<string, double> counter = CountUniqueValues(dataSet, attribute);
            double mostFrequentCount = 0;
            string mostFrequentValue = "";

            ICollection<string> keys = counter.Keys;

            foreach (string element in keys)
            {
                if (counter[element] > mostFrequentCount)
                {
                    mostFrequentCount = counter[element];
                    mostFrequentValue = element;
                }

            }

            return mostFrequentValue;
        }

        Hashtable Split(Hashtable[] dataSet, object attribue, double pivot)
        {
            int k1 = 0, k2 = 0;
            for (int i = dataSet.Length - 1; i >= 0; i--)
            {
                if (Convert.ToDouble(dataSet[i][attribue]) >= pivot) k1++;
                else k2++;
            }

            Hashtable[] match = new Hashtable[k1]; int n = 0;
            Hashtable[] notMatch = new Hashtable[k2]; int m = 0;

            for (int i = 0; i < dataSet.Length; i++)
                if (Convert.ToDouble(dataSet[i][attribue]) >= pivot) {match[n] = dataSet[i]; n++; }
                else {notMatch[m] = dataSet[i]; m++; }    

            Hashtable HashtableArray = new Hashtable(2);
            HashtableArray.Add("match", match);
            HashtableArray.Add("notMatch", notMatch);

            return (HashtableArray);
        }

    }

}
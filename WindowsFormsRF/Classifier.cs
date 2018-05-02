using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRF
{
    class Classifier
    {
        string result;
        public string Result => result;

        public Classifier(BuildDecisionTree tree, Hashtable item)
        {
           while(true)
            {
                if (tree.Category != null)
                {
                    result = tree.Category;
                    return;
                }

                double itemValue = (double)item[tree.SplitAttribute];

                if (itemValue >= tree.SplitPivot) tree = tree.MatchSubTree;
                else tree = tree.NotMatchSubTree;
            }

        }
    }
}

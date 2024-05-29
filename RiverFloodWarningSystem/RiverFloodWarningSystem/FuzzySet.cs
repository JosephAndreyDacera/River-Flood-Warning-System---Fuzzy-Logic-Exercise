using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverFloodWarningSystem
{
    class FuzzySet
    {

        //===================================================================================
        // Variable Declaration
        //===================================================================================
        // Fuzzy Logic
        FuzzyLogic accessor;
        public double classification_COA = 0.0;
        public double membershipOfweight = 0.0;

        public FuzzyLogic[] flood = new FuzzyLogic[3];
        public FuzzyLogic[] rainfall = new FuzzyLogic[3];
        public FuzzyLogic[] classification = new FuzzyLogic[3];

        // Input Variables
        private const int low = 0;
        private const int moderate = 1;
        private const int high = 2;

        // Output Variables
        private const int YELLOW = 0;
        private const int ORANGE = 1;
        private const int RED = 2;

        int[,] matched_features = new int[3,3];

        public void InitializeFuzzySets()
        {
            //Input variables
            for (int i = 0; i < 3; i++)
            {
                flood[i] = new FuzzyLogic();
                rainfall[i] = new FuzzyLogic();
            }

            //Output variable
            for (int i = 0; i < 3; i++)
            {
                classification[i] = new FuzzyLogic();
            }

            // Membership function for flood height
            flood[0].Set("LOW", 0, 0, 1, 0.75, 1, 0.75, 1, 1.5, 0);
            flood[1].Set("MODERATE", 1, 1, 0, 1.75, 1, 1.75, 1, 2.5, 0);
            flood[2].Set("HIGH", 2, 2, 0, 3, 1, 3, 1, 4, 1);

            // Membership function for rainfall
            rainfall[0].Set("LIGHT", 0, 0, 1, 7.5, 1, 7.5, 1, 18, 0);
            rainfall[1].Set("MODERATE", 1, 15, 0, 22.25, 1, 22.25, 1, 30, 0);
            rainfall[2].Set("HEAVY", 2, 27, 0, 37.5, 1, 37.5, 1, 65, 1);

            // Membership function for classification
            classification[0].Set("YELLOW", 0, 0, 1, 13, 1, 13, 1, 25, 0);
            classification[1].Set("ORANGE", 1, 20, 0, 40, 1, 40, 1, 60, 0);
            classification[2].Set("RED", 2, 50, 0, 75, 1, 75, 1, 100, 1);

            //Fuzzy Rules
            matched_features[0, 0] = YELLOW;
            matched_features[0, 1] = YELLOW;
            matched_features[0, 2] = ORANGE;

            matched_features[1, 0] = ORANGE;
            matched_features[1, 1] = ORANGE;
            matched_features[1, 2] = RED;

            matched_features[2, 0] = RED;
            matched_features[2, 1] = RED;
            matched_features[2, 2] = RED;
        }

        public double computeCentroid(double floodVal, double rainfallVal)
        {
            accessor = new FuzzyLogic();
            int i = 0, j = 0;
            double area = 0, centroid = 0, numerator = 0, denominator = 0, minimum = 0.0, centerOfArea = 0.0;

            for (i = 0; i < 3; i++) 
                for (j = 0; j < 3; j++) 
                {
                    minimum = accessor.min(flood[i].membership(floodVal), rainfall[j].membership(rainfallVal));
                    if (minimum != 0)
                    {
                        area = classification[matched_features[flood[i].GetIndex(), rainfall[j].GetIndex()]].Area(minimum);
                        centroid = classification[matched_features[flood[i].GetIndex(), rainfall[j].GetIndex()]].CenterOfArea(minimum);
                        numerator += area * centroid;
                        denominator += area;
                    }
                }

            centerOfArea = numerator / denominator;

            if (denominator == 0.0)
                return 0.0;
            else 
                return centerOfArea;
        }

        //Get the membership inference value
        public string defuzzify(double masked_reg, double var)
        {   
            InitializeFuzzySets();
            classification_COA = computeCentroid(masked_reg, var);
            double[] membershipArray = new double[5];

            double maxMembership = membershipArray[0];
            string classification_linguistic = "";
            for (int i = 0; i < 3; i++)
            {
                if ((classification[i].membership(classification_COA)) > maxMembership)
                {
                    maxMembership = classification[i].membership(classification_COA);
                    classification_linguistic = classification[i].GetLinguistic();
                }
            }
            return classification_linguistic;
        }
    }
}

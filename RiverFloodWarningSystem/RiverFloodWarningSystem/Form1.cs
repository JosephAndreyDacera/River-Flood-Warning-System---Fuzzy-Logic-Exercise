using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverFloodWarningSystem
{
    public partial class Form1 : Form
    {

        private FuzzySet fs = new FuzzySet();

        public Form1()
        {
            InitializeComponent();
            fs.InitializeFuzzySets();
            showRainfallDOM();
            showFloodDOM();
        }

        private void floodValChanged(object sender, EventArgs e)
        {
            showFloodDOM();
            resetCentroid();
        }

        private void rainfallValChanged(object sender, EventArgs e)
        {
            showRainfallDOM();
            resetCentroid();
        }

        private void showFloodDOM()
        {
            floodLow.Text = fs.flood[0].membership(Convert.ToDouble(floodVal.Value)).ToString();
            floodMod.Text = fs.flood[1].membership(Convert.ToDouble(floodVal.Value)).ToString();
            floodHigh.Text = fs.flood[2].membership(Convert.ToDouble(floodVal.Value)).ToString();
        }

        private void showRainfallDOM()
        {
            rainfallLow.Text = fs.rainfall[0].membership(Convert.ToDouble(rainfallVal.Value)).ToString();
            rainfallAve.Text = fs.rainfall[1].membership(Convert.ToDouble(rainfallVal.Value)).ToString();
            rainfallHeavy.Text = fs.rainfall[2].membership(Convert.ToDouble(rainfallVal.Value)).ToString();
        }


        private void showCentroid()
        {
            centroid.Text = fs.computeCentroid(Convert.ToDouble(floodVal.Value), Convert.ToDouble(rainfallVal.Value)).ToString();
            yellow.Text = fs.classification[0].membership(Convert.ToDouble(centroid.Text)).ToString();
            orange.Text = fs.classification[1].membership(Convert.ToDouble(centroid.Text)).ToString();
            red.Text = fs.classification[2].membership(Convert.ToDouble(centroid.Text)).ToString();

            string deffuzify = fs.defuzzify(Convert.ToDouble(floodVal.Value), Convert.ToDouble(rainfallVal.Value));

            if(deffuzify == "YELLOW")
            {
                result.Text = "YELLOW   |   Flooding is Possible. Please monitor the weather condition.";
            }
            else if(deffuzify == "ORANGE")
            {
                result.Text = "ORANGE   |   Flooding is Threatening. Alert for possible evacuation.";
            }
            else 
            {
                result.Text = "RED   |   Serious Flooding is expected in low lying areas. Evacuate Immediately.";
            }
        }

        private void resetCentroid()
        {
            centroid.Text = "_ _ _ _ _";
            yellow.Text = "_ _ _ _ _ _ _ _ _ _";
            orange.Text = "_ _ _ _ _ _ _ _ _ _";
            red.Text = "_ _ _ _ _ _ _ _ _ _";
            result.Text = "_ _ _ _ _";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetCentroid();
            rainfallVal.Value = 7.50M;
            floodVal.Value = .30M;
            showRainfallDOM();
            showFloodDOM();
        }

        private void analyzeBtn_Click(object sender, EventArgs e)
        {
            resetCentroid();
            showCentroid();
        }
    }
}

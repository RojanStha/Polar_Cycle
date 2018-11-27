using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace Rojan_ASE_PolarCycle
{
    public partial class Graph : Form
    {

        public Graph()
        {
            InitializeComponent();
        }

        List<hrdata> hr = new List<hrdata>();
        private object g;

        public void setHR(List<hrdata> hr)
        {
            this.hr = hr;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            plotGraph();
        }

        //heart rate data build up
        private int[] buildHeartRateData()
        {
            int[] HeartRateArray = new int[hr.Count];
            int i = 0;

            foreach (hrdata value in hr)
            {
                HeartRateArray[i] = value.HeartRate;
                i++;
            }

            return HeartRateArray;
        }

        //speed data build up
        private double[] buildSpeedData()
        {
            double[] SpeedArray = new double[hr.Count];
            int i = 0;

            foreach (hrdata value in hr)
            {
                SpeedArray[i] = value.Speed;
                i++;
            }

            return SpeedArray;
        }

        //cadence data build up
        private int[] buildCadenceData()
        {
            int[] CadenceArray = new int[hr.Count];
            int i = 0;

            foreach (hrdata value in hr)
            {
                CadenceArray[i] = value.Cadence;
                i++;
            }

            return CadenceArray;
        }

        //power data build up
        private int[] buildPowerData()
        {
            int[] PowerArray = new int[hr.Count];
            int i = 0;

            foreach (hrdata value in hr)
            {
                PowerArray[i] = value.Power;
                i++;
            }

            return PowerArray;
        }

        //altitude data build up
        private int[] buildAltitudeData()
        {
            int[] AltitudeArray = new int[hr.Count];
            int i = 0;

            foreach (hrdata value in hr)
            {
                AltitudeArray[i] = value.Altitude;
                i++;
            }

            return AltitudeArray;
        }

        //plot graph method
        public void plotGraph()
        {
            GraphPane myPane = zedGraphControl2.GraphPane;

            // Setting the Titles
            myPane.Title = "Graph Analytics for Speed, Cadence, Altitude, Heart Rate and Power";
            myPane.XAxis.Title = "Time in seconds";
            myPane.YAxis.Title = "Individual Units of Measurements";

            //scaling the graph
            myPane.XAxis.Min = 0.0;
            myPane.XAxis.Max = 1000.0;
            myPane.YAxis.Min = 0.0;
            myPane.YAxis.Max = 500.0;

          //  myPane.AxisChange();
            zedGraphControl2.Refresh();

            PointPairList HeartRatePairList = new PointPairList();
            PointPairList SpeedPairList = new PointPairList();
            PointPairList CadencePairList = new PointPairList();
            PointPairList PowerPairList = new PointPairList();
            PointPairList AltitudePairList = new PointPairList();

            int[] HeartRateData = buildHeartRateData();
            double[] SpeedData = buildSpeedData();
            int[] CadenceData = buildCadenceData();
            int[] PowerData = buildPowerData();
            int[] AltitudeData = buildAltitudeData();

            for (int i = 0; i < hr.Count; i++)
            {
                HeartRatePairList.Add(i, HeartRateData[i]);
                SpeedPairList.Add(i, SpeedData[i]);
                CadencePairList.Add(i, CadenceData[i]);
                PowerPairList.Add(i, PowerData[i]);
                AltitudePairList.Add(i, AltitudeData[i]);
            }

            LineItem HeartRateCurve = myPane.AddCurve("Heart Rate", HeartRatePairList, Color.Red, SymbolType.None);
            LineItem SpeedCurve = myPane.AddCurve("Speed", SpeedPairList, Color.Blue, SymbolType.None);
            LineItem CadenceCurve = myPane.AddCurve("Cadence", CadencePairList, Color.Yellow, SymbolType.None);
            LineItem PowerCurve = myPane.AddCurve("Power", PowerPairList, Color.Black, SymbolType.None);
            LineItem AltitudeCurve = myPane.AddCurve("Altitude", AltitudePairList, Color.Brown, SymbolType.None);

        }


    }
}

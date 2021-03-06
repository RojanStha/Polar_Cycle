﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rojan_ASE_PolarCycle
{
    public partial class Dashboard : Form
    {
        private int seconds; private int counter; private int NumberOfLines; private string heart; private string speed; private string cadence;// = string.Empty;private string altitude;
        private string power; private string powerbal; private string line; private string HData; private double[] hgraph; private string altitude; DateTime myDateTime;
        int lineNo;

        string lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10, lb11, lb12;

    
       

        public Dashboard()
        {
            InitializeComponent();
        }


        List<header> headVal = new List<header>();

        private void btngraph_Click(object sender, EventArgs e)
        {
            Graph gr = new Graph();
            gr.setHR(hr);
            gr.Show();
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph gr = new Graph();
            gr.setHR(hr);
            gr.Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        public List<hrdata> hr = new List<hrdata>();

        parameters allParameters = new parameters();

        DataTable dt = new DataTable();
        private string[] Filelines;

        private void DashboardFomLoad(object sender, EventArgs e)
        {

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog browseFile = new OpenFileDialog())
            {
                if (browseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = browseFile.FileName;
                    //Reading the File
                    lblFileName.Visible = true;
                    lblFileName.Text = browseFile.FileName;
                    Filelines = File.ReadAllLines(filename);


                    for (int linecount = 0; linecount < Filelines.Length; linecount++)
                    {
                        //checking file if is null
                        if (Filelines[linecount].Length > 0)
                        {

                            if (Filelines[linecount][0] == '[' && Filelines[linecount][Filelines[linecount].Length - 1] == ']')
                            {

                                headVal.Add(new header { headername = Filelines[linecount].Substring(1, Filelines[linecount].Length - 2), headerline = linecount });

                                lblversion.Visible = true;
                                lblstartdate.Visible = true;
                                lbldate.Visible = true;
                                lblinterval.Visible = true;
                                lblmonitor.Visible = true;
                                lbllength.Visible = true;
                                lblsmode.Visible = true;
                                lblFileName.Visible = true;
                                btngraph.Visible = true;
                                dataGridView.Visible = true;
                                lblmaxheartrate.Visible = true;
                                lblminheartrate.Visible = true;
                                lblavgheartrate.Visible = true;
                                lblmaxspeed.Visible = true;
                                lblminspeed.Visible = true;
                                lblavgspeed.Visible = true;
                                lblmaxpower.Visible = true;
                                lblminpower.Visible = true;
                                lblavgpower.Visible = true;
                                lblmaxaltitude.Visible = true;
                                lblminaltitude.Visible = true;
                                lblavgaltitude.Visible = true;




                            }
                        }
                    }

                    StreamReader reader = new StreamReader(browseFile.FileName, System.Text.Encoding.Default);
                    string readFileText = reader.ReadToEnd();

                    //read from the textfile
                    int lineIndex = readFileText.IndexOf("Date=");
                    string dateLines = readFileText.Substring(lineIndex + 5, 8);

                    //for reading the date from the text file
                    dateLines = dateLines.Insert(4, "-");
                    dateLines = dateLines.Insert(7, "-");

                    //read text with certain symbols
                    lineIndex = readFileText.IndexOf("StartTime=");
                    string lineTime = readFileText.Substring(lineIndex + 10, 8); 
                    // for the time with hour minute and seconds
                    lineIndex = readFileText.IndexOf("Interval=");
                    string lineinter1 = readFileText.Substring(lineIndex + 9, 1);
                    // for the time with hour minute and seconds 
                    lineIndex = readFileText.IndexOf("Length=");
                    string lineLength = readFileText.Substring(lineIndex + 7, 8);
                    // for the time with hour minute and seconds
                    string textTimeStamp = dateLines + "   " + lineTime;
                    StreamReader sr = new StreamReader(browseFile.FileName, System.Text.Encoding.Default);
                    HData = null;
                    NumberOfLines = File.ReadAllLines(browseFile.FileName).Length;
                    while ((HData = sr.ReadLine()) != null)
                    {
                        if (HData.IndexOf("[HRData]") != -1)
                        {
                            //found it
                            break;
                        }
                    }
                    line = sr.ReadLine();
                    // Setup an accumulator
                    int heartTotal = 0, speedTotal = 0, powerTotal = 0, altTotal = 0;
                    double mph = 0;

                    DataGridViewColumn timestamp = new DataGridViewTextBoxColumn();
                    timestamp.HeaderText = "Time Stamp";
                    int dataCol1 = dataGridView.Columns.Add(timestamp);

                    DataGridViewColumn heartrate = new DataGridViewTextBoxColumn();
                    heartrate.HeaderText = "Heart Rate";
                    int dataCol2 = dataGridView.Columns.Add(heartrate);

                    DataGridViewColumn speedval = new DataGridViewTextBoxColumn();
                    speedval.HeaderText = "Speed";
                    int dataCol3 = dataGridView.Columns.Add(speedval);

                    DataGridViewColumn cadencer = new DataGridViewTextBoxColumn();
                    cadencer.HeaderText = "Cadence";
                    int dataCol4 = dataGridView.Columns.Add(cadencer);

                    DataGridViewColumn altit = new DataGridViewTextBoxColumn();
                    altit.HeaderText = "Altitude";
                    int dataCol5 = dataGridView.Columns.Add(altit);

                    DataGridViewColumn pwr = new DataGridViewTextBoxColumn();
                    pwr.HeaderText = "Power (watts)";
                    int dataCol6 = dataGridView.Columns.Add(pwr);

                    DataGridViewColumn pwrbal = new DataGridViewTextBoxColumn();
                    pwrbal.HeaderText = "Power Balance";
                    int colIndex7 = dataGridView.Columns.Add(pwrbal);

            



                    seconds = Convert.ToInt32(lineinter1);
                    counter = 0;
                    hgraph = new double[0];
                    while (line != null)
                    {
                        List<string> heartarray = new List<string>();


                        counter++;
                        if (seconds <= 1)
                        {
                            myDateTime = myDateTime.AddSeconds(seconds);
                        }
                        else
                        {
                            if (seconds >= 1)
                                myDateTime = myDateTime.AddSeconds(seconds);
                        }
                        heart = line.Split('\t')[0];
                        int heartint = Convert.ToInt32(heart);

                        heartarray.Add(heart);
                        heartTotal += heartint;
                        speed = line.Split('\t')[1];
                        int speedint = Convert.ToInt32(speed);
                        speedTotal += speedint;
                        mph = ((double)speedint / (double)1.6);

                        if (speedint <= 1)
                        {
                            speed = speed.Insert(1, ".");
                        }
                        else
                        {
                            if (speedint >= 1)
                                speed = speed.Insert(2, ".");
                        }
                        cadence = line.Split('\t')[2];
                        int cadenceint = Convert.ToInt32(cadence);
                        altitude = line.Split('\t')[3];
                        int altitudeint = Convert.ToInt32(altitude);
                        altTotal += altitudeint;
                        power = line.Split('\t')[4];

                        powerbal = line.Split('\t')[5];
                        int Powerbalint = Convert.ToInt32(powerbal);
                        int powerint = Convert.ToInt32(power);
                        powerTotal += powerint;
                        line = sr.ReadLine();
                        dataGridView.Rows.Add(myDateTime, heart, speed, cadence, altitude, power, powerbal);


                    }
                    int[] powerlist = new int[] { Convert.ToInt32(powerbal) };

                    for (int i = 0; i < powerlist.Count(); i++)
                    {
                        double movingArea30 = 0;

                        for (int j = 0; j < 30; j++)
                        {
                            int index = i + j;
                            index %= powerlist.Count();
                            movingArea30 += powerlist[index];
                        }
                        movingArea30 /= 30;
                        dataGridView.Rows.Add(movingArea30);
                    }
                }
                fileParse();
                dataGridView.Visible = true;
            }
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {


            lblversion.Visible = false;
            lblstartdate.Visible = false;
            lbldate.Visible = false;
            lblinterval.Visible = false;
            lblmonitor.Visible = false;
            lbllength.Visible = false;
            lblsmode.Visible = false;
            lblFileName.Visible = false;
            btngraph.Visible = false;
            dataGridView.Visible = true;
            lblmaxheartrate.Visible = false;
            lblminheartrate.Visible = false;
            lblavgheartrate.Visible = false;
            lblmaxspeed.Visible = false;
            lblminspeed.Visible = false;
            lblavgspeed.Visible = false;
            lblmaxpower.Visible = false;
            lblminpower.Visible = false;
            lblavgpower.Visible = false;
            lblmaxaltitude.Visible = false;
            lblminaltitude.Visible = false;
            lblavgaltitude.Visible = false;



        }


        public void fileParse()
        {
            //textfile with certain characters checking
            foreach (header a in headVal)
            {
                lineNo = a.headerline;

                switch (a.headername)
                {
                    case "Params":
                        {
                            int nextLine = lineNo + 1;
                            //seperating the values with tabs
                            string[] newline = Filelines[nextLine].Split('\t');
                            string value = newline[0];
                            int add = 0;
                            int addval = 1;
                            string[] paramsValue = new string[22];
                            do
                            {

                                foreach (char checkequal in value)
                                {
                                    if (checkequal == '=')
                                    {
                                        paramsValue[add] = value.Substring(addval, value.Length - addval);

                                    }

                                    addval++;
                                }


                                addval = 1;
                                add++;
                                nextLine++;
                                newline = Filelines[nextLine].Split('\t');
                                value = newline[0];

                            } while (nextLine < 24);//newline!=null);


                            allParameters.Version = paramsValue[0];
                            allParameters.Monitor = paramsValue[1];
                            allParameters.SMode = paramsValue[2];
                            allParameters.Date = paramsValue[3];
                            allParameters.StartTime = paramsValue[4];
                            allParameters.Length = paramsValue[5];
                            allParameters.Interval = paramsValue[6];
                            allParameters.Upper1 = paramsValue[7];
                            allParameters.Lower1 = paramsValue[8];
                            allParameters.Upper2 = paramsValue[9];
                            allParameters.Lower2 = paramsValue[10];
                            allParameters.Upper3 = paramsValue[11];
                            allParameters.Lower3 = paramsValue[12];
                            allParameters.Timer1 = paramsValue[13];
                            allParameters.Timer2 = paramsValue[14];
                            allParameters.Timer3 = paramsValue[15];
                            allParameters.ActiveLimit = paramsValue[16];
                            allParameters.MaxHR = paramsValue[17];
                            allParameters.RestHR = paramsValue[18];
                            allParameters.StartDelay = paramsValue[19];
                            allParameters.VO2max = paramsValue[20];
                            allParameters.Weight = paramsValue[21];


                            //adding the getter and setter
                            lblversion.Text = "" + allParameters.Version;
                            lblmonitor.Text = " " + allParameters.Monitor;
                            lblsmode.Text = " " + allParameters.SMode;
                            lbldate.Text = "" + allParameters.Date;
                            lblstartdate.Text = " " + allParameters.StartTime;
                            lbllength.Text = " " + allParameters.Length;
                            lblinterval.Text = " " + allParameters.Interval;
                          

                          
                            lblmaxheartrate.Text = "" + allParameters.MaxHR;
                         


                            break;
                        }
                    case "HRData":
                        {


                            //using the loop to till the end of array to get values 
                            for (int j = lineNo + 1; j < Filelines.Length; j++)
                            {
                                //Spliting chars with tabs
                                string[] newline = Filelines[j].Split('\t');


                                //Switching different versions 
                                switch (allParameters.Version)
                                {

                                    case "105":
                                        {
                                            hr.Add(new hrdata
                                            {
                                                HeartRate = int.Parse(newline[0]),
                                                Speed = int.Parse(newline[1]),
                                                Cadence = int.Parse(newline[2])
                                            });

                                            break;
                                        }
                                    case "106":
                                        {


                                            //adding the values 
                                            hr.Add(new hrdata
                                            {

                                                HeartRate = int.Parse(newline[0]),
                                                Speed = double.Parse(newline[1]) * 0.1,
                                                Cadence = int.Parse(newline[2]),
                                                Altitude = int.Parse(newline[3]),
                                                Power = int.Parse(newline[4]),
                                                PowerBalancePedalling = int.Parse(newline[5])
                                            });

                                            break;
                                        }
                                    case "107":
                                        {
                                            //adding the values to the parameters
                                            hr.Add(new hrdata
                                            {
                                                HeartRate = int.Parse(newline[1]),
                                                Speed = double.Parse(newline[2]) * 0.1,
                                                Cadence = int.Parse(newline[3]),
                                                Altitude = int.Parse(newline[4]),
                                                Power = int.Parse(newline[5]),
                                                PowerBalancePedalling = int.Parse(newline[6]),
                                                AirPressure = int.Parse(newline[7])
                                            });
                                            break;
                                        }

                                }
                            }
                            break;

                        }
                }

            }


            //putting column name is data grid view as per version of parmas
            string[] columnNames = { "Time Stamp", " HeartRate", " Speed", " Cadence", " Altitude", " Power", "PowerBalancePedalling" };


            foreach (string col in columnNames)
            {
                dt.Columns.Add(col);
            }


            foreach (hrdata hd in hr)
            {



                dt.Rows.Add(hd.TimeStamp, hd.HeartRate, hd.Speed, hd.Cadence, hd.Altitude, hd.Power, hd.PowerBalancePedalling);
            }

            //variables initiated for heart rate
            int minHeartRate = 1000;
            int maxHeartRate = 0, sum = 0;
            int count = 0;

            //variables for altitude ,power,speed

            int minAltitude = 1000;
            int maxAltitude = 0;
            int avgaltitude = 0;

            int minPower = 1000;
            int maxPower = 0;
            int avgPower = 0;

            double minSpeed = 1000;
            double maxSpeed = 0;
            double avgspeed = 0;



            //calculating the data to find maximum,minimum


            foreach (hrdata value in hr)
            {

                //for heart rate
                int hrValue = value.HeartRate;
                if (hrValue < minHeartRate)
                {
                    minHeartRate = hrValue;
                }
                else if (hrValue > maxHeartRate)
                {
                    maxHeartRate = hrValue;
                }
                sum += hrValue;
                count++;
                //calculation for altitude 
                int altValue = value.Altitude;
                if (altValue < minAltitude)
                {
                    minAltitude = altValue;
                }
                else if (altValue > maxAltitude)
                {
                    maxAltitude = altValue;
                }
                if (altValue <= minAltitude && altValue >= maxAltitude)
                {
                    avgaltitude = altValue;
                }


                //calculation for the power
                int PowerValue = value.Power;
                if (PowerValue < minPower)
                {
                    minPower = PowerValue;
                }
                else if (altValue > maxPower)
                {
                    maxPower = PowerValue;
                }
                if (PowerValue != 0)
                {
                    if (PowerValue <= minPower && PowerValue >= minPower)
                    {
                        avgPower = PowerValue;
                    }
                }


                //calculation of the speed
                double SpeedValue = value.Speed;
                if (SpeedValue < minSpeed)
                {
                    minSpeed = SpeedValue;
                }
                else if (SpeedValue > maxSpeed)
                {
                    maxSpeed = SpeedValue;
                }
                if (SpeedValue <= minSpeed && SpeedValue >= maxSpeed)
                {
                    avgspeed = SpeedValue;
                }

            }





            //calculating the stats of heart rate
            lblavgheartrate.Text = "" + (sum / count).ToString(); // Average Heart Rate
            lblmaxheartrate.Text = " " + maxHeartRate.ToString() + " beats per minute"; //Maximum Heart Rate
            lblminheartrate.Text = "" + minHeartRate.ToString() + " beats per minute"; //Minimum Heart Rate
             lb10 = lblavgspeed.Text = "" + avgspeed.ToString() + " Miles/Hr"; // Average Speed
            lb4 = "" + (avgspeed * 1.6).ToString() + " KM/Hr";//Average Speed km/hr

            lb12 = lblavgaltitude.Text = " " + avgaltitude.ToString() + " Meter"; // Average Altitude
            lb6 = " " + (avgaltitude / 0.304).ToString().Substring(0, 4) + " Feet";// Average Altitude In feet

            lblavgpower.Text = "" + avgPower.ToString() + " Watt"; // Average Power in watt

            //calculating for altitude ,power ,speed
            lblmaxpower.Text = "" + maxPower.ToString() + "Watt"; // maximum powein watt

            lb7 = lblTotaldistance.Text = " " + (avgspeed * 1).ToString() + " Miles";// totaldistance in miles 
            lb1 = " " + (avgspeed / 0.6).ToString().Substring(0, 4) + " KM"; // total distance in km


            lb11 = lblmaxaltitude.Text = " " + maxAltitude.ToString() + "Meter"; // maximum altitudein meter
            double tomile = Convert.ToDouble(maxSpeed) * 0.62137119;
            lb5 = " " + (maxAltitude / 0.304).ToString().Substring(0, 4) + "Feet";

            lb8 = lblmaxspeed.Text = " " + (maxSpeed + tomile).ToString() + " Miles/Hr"; // max speed in miles/hr
            lb2 = "" + (maxSpeed).ToString() + " KM/Hr";

            lb9 = lblminspeed.Text = "" + minSpeed.ToString() + " Miles/Hr";// minimum speedin miles/hr
            lb3 = "" + (minSpeed * 1.6).ToString() + " KM/Hr";

           // cycleInfo.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


            lblTotaldistance.Text = lb1.ToString();
            lblmaxaltitude.Text = lb5.ToString();
            lblmaxspeed.Text = lb2.ToString();
            lblminspeed.Text = lb3.ToString();
            lblavgspeed.Text = lb4.ToString();
            lblavgaltitude.Text = lb6.ToString();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblTotaldistance.Text = lb7.ToString();
            lblmaxaltitude.Text = lb11.ToString();
            lblmaxspeed.Text = lb8.ToString();
            lblminspeed.Text = lb9.ToString();
            lblavgspeed.Text = lb10.ToString();
            lblavgaltitude.Text = lb12.ToString();
        }






        private void data_load_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    } 
           
}

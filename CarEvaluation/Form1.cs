using SOFM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CarEvaluation
{
    public partial class Form1 : Form
    {
        private NeuralNetwork nn;
        private Color[,] colorMatrix;
        private const int nnDimension = 10;
        private const int cellSize = 20;
        private const int cellsNumber = nnDimension * nnDimension;
        private NeuralNetwork evaluationNetwork;

        public Form1()
        {
            InitializeComponent();
            colorMatrix = new Color[nnDimension, nnDimension];
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "Map2.sofm";
            evaluationNetwork = ReadFromBinaryFile<NeuralNetwork>(@filepath);
            //Car car = new Car(Image.FromFile(@"D:\Code\Visual Studio\source\repos\CarEvaluation\Cars\Range Rover.png"),
            //    "Land Rover Range Rover",
            //    1, 2, 5, 5, 3, 3);
            //car.SaveCar();
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            openFileDialogLearn.ShowDialog();
            //nn = new NeuralNetwork(nnDimension, 10000, 0.0000001, Functions.FrenchHat);
            //nn.ReadDataFromFile(@"C:\Users\Franz\Desktop\car_60.txt");
            //nn.StartLearning();
            //colorMatrix = nn.ColorSOFM();
            //panelMap.Invalidate();
            //AddLegend();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogLoad.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogSave.ShowDialog();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            List<double> pattern = new List<double>() { 4, 4, 4, 5, 1, 3 };
            Neuron winner = nn.FindWinner(pattern);
            Graphics g = panelMap.CreateGraphics();
            g.FillEllipse(Brushes.HotPink, winner.Coordinate.Y * cellSize, 
                winner.Coordinate.X * cellSize, cellSize, cellSize);
        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //draw map colors
            for (int i = 0; i < nnDimension; i++)
            {
                for (int j = 0; j < nnDimension; j++)
                {
                    g.FillRectangle(new SolidBrush(colorMatrix[i, j]), j * cellSize, i * cellSize, cellSize, cellSize);
                }
            }
            //draw grid lines
            for (int i = 0; i < 100; i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(75,75,75)), 0, i * cellSize, cellsNumber * cellSize, i * cellSize);
                g.DrawLine(new Pen(Color.FromArgb(75, 75, 75)), i * cellSize, 0, i * cellSize, cellsNumber * cellSize);
            }
        }

        private void openFileDialogLearn_FileOk(object sender, CancelEventArgs e)
        {
            nn = new NeuralNetwork(nnDimension, 10000, 0.0000001, Functions.FrenchHat);
            nn.ReadDataFromFile(openFileDialogLearn.FileName);
            nn.StartLearning();
            colorMatrix = nn.ColorSOFM();
            panelMap.Invalidate();
            AddLegend();
        }

        private void openFileDialogLoad_FileOk(object sender, CancelEventArgs e)
        {
            nn = ReadFromBinaryFile<NeuralNetwork>(openFileDialogLoad.FileName);
            colorMatrix = nn.ColorSOFM();
            panelMap.Invalidate();
            AddLegend();
        }

        private void saveFileDialogSave_FileOk(object sender, CancelEventArgs e)
        {
            WriteToBinaryFile<NeuralNetwork>(saveFileDialogSave.FileName, nn, false);
        }

        private void AddLegend()
        {
            panelLegend.Controls.Clear();
            for (int i = 0; i < nn.ExistentClasses.Count; i++)
            {
                Panel panel = new Panel();
                panel.Name = "panel" + nn.ExistentClasses.Keys[i];
                panel.Width = 10;
                panel.Height = 10;
                panel.BackColor = nn.UsedColors[i];
                panelLegend.Controls.Add(panel);

                Label label = new Label();
                label.Name = "label" + nn.ExistentClasses.Keys[i];
                label.Text = " - " + nn.ExistentClasses.Keys[i];
                label.AutoSize = true;
                label.Left = 0;
                label.Top = 0;
                panelLegend.Controls.Add(label);
                panelLegend.SetFlowBreak(label, true);
            }
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        //Car Evaluation Tab

        private void trackBarPrice_ValueChange(object sender, EventArgs e)
        {
            string price = "";
            switch (-trackBarPrice.Value)
            {
                case 1: price = "$$$$"; break;
                case 2: price = "$$$"; break;
                case 3: price = "$$"; break;
                case 4: price = "$"; break;
            }
            labelPrice.Text = price;
            LightStars(0);
        }

        private void trackBarCost_ValueChange(object sender, EventArgs e)
        {
            string cost = "";
            switch (-trackBarCost.Value)
            {
                case 1: cost = "$$$$"; break;
                case 2: cost = "$$$"; break;
                case 3: cost = "$$"; break;
                case 4: cost = "$"; break;
            }
            labelCost.Text = cost;
            LightStars(0);
        }

        private void trackBarDoor_ValueChange(object sender, EventArgs e)
        {
            string door = "";
            switch (trackBarDoor.Value)
            {
                case 2: door = "2"; break;
                case 3: door = "3"; break;
                case 4: door = "4"; break;
                case 5: door = "5 ↑"; break;
            }
            labelDoor.Text = door;
            LightStars(0);
        }

        private void trackBarPassenger_ValueChange(object sender, EventArgs e)
        {
            string person = "";
            switch (trackBarPassenger.Value)
            {
                case 1: person = "2"; break;
                case 2: person = "4"; break;
                case 3: person = "5 ↑"; break;
            }
            labelPassenger.Text = person;
            LightStars(0);
        }

        private void trackBarLuggage_ValueChange(object sender, EventArgs e)
        {
            string luggage = "";
            switch (trackBarLuggage.Value)
            {
                case 1: luggage = "Small"; break;
                case 2: luggage = "Medium"; break;
                case 3: luggage = "Big"; break;
            }
            labelLuggage.Text = luggage;
            LightStars(0);
        }

        private void trackBarSafety_ValueChange(object sender, EventArgs e)
        {
            string safety = "";
            switch (trackBarSafety.Value)
            {
                case 1: safety = "Low"; break;
                case 2: safety = "Medium"; break;
                case 3: safety = "High"; break;
            }
            labelSafety.Text = safety;
            LightStars(0);
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            nn = evaluationNetwork;
            double price = -trackBarPrice.Value;
            double cost = -trackBarCost.Value;
            double door = trackBarDoor.Value;
            double passenger = GetPassenger(trackBarPassenger.Value);
            double luggage = trackBarLuggage.Value;
            double safety = trackBarSafety.Value;
            List<double> pattern = new List<double>() { price, cost, door, passenger, luggage, safety };
            Neuron winner = nn.FindWinner(pattern);
            AddRating(winner);
            labelRating.ForeColor = Color.White;
        }

        private void AddRating(Neuron winner)
        {
            Color[,] colors = nn.ColorSOFM();
            Color indexColor = colors[winner.Coordinate.X, winner.Coordinate.Y];
            string[] classes = nn.ExistentClasses.Keys.ToArray();
            int index = nn.UsedColors.IndexOf(indexColor);
            if (index == -1)
            {
                index = GetCloseClass(winner, 2);
            }
            LightStars(GetRating(classes[index]));
            //Debug.WriteLine(GetRating(classes[index]));
        }

        private void pictureBoxCar_Click(object sender, EventArgs e)
        {
            Car car = Car.LoadCar();
            if(car != null)
            {
                pictureBoxCar.Image = car.Image;
                labelSpecs.Text = car.Name;
                labelSpecs.ForeColor = Color.FromArgb(243, 156, 18);
                trackBarPrice.Value = -car.Price;
                trackBarCost.Value = -car.Maintenance;
                trackBarDoor.Value = car.Doors;
                trackBarPassenger.Value = GetPassengersTrackValue(car.Passengers);
                trackBarLuggage.Value = car.Luggage;
                trackBarSafety.Value = car.Safety;
            }
        }

        private int GetCloseClass(Neuron neuron, int neighborhoodSize)
        {
            Tuple<int, int, int, int> neighbor = GetNeighborhood(neuron.Coordinate.X,
                neuron.Coordinate.Y, neighborhoodSize);
            Color[,] colors = nn.ColorSOFM();
            Color[] used = nn.UsedColors.ToArray();
            int[] counter = new int[used.Length];
            for (int t = 0; t < used.Length; t++)
            {
                for (int i = neighbor.Item1; i < neighbor.Item3; i++)
                {
                    for (int j = neighbor.Item2; j < neighbor.Item4; j++)
                    {
                        Color color = colors[i, j];
                        if (color != SystemColors.ButtonFace)
                        {
                            if (color == used[t]) counter[t]++;
                        }
                    }
                } 
            }
            int maxIndex = counter.ToList().IndexOf(counter.Max());
            return maxIndex;
        }

        private Tuple<int, int, int, int> GetNeighborhood(int x, int y, int neighborhoodSize)
        {
            int x1 = x - neighborhoodSize < 0 ? 0 : x - neighborhoodSize;
            int y1 = y - neighborhoodSize < 0 ? 0 : y - neighborhoodSize;
            int x2 = x + neighborhoodSize > nnDimension - 1 ? nnDimension - 1 : x + neighborhoodSize;
            int y2 = y + neighborhoodSize > nnDimension - 1 ? nnDimension - 1 : y + neighborhoodSize;
            return Tuple.Create(x1, y1, x2, y2);
        }

        private void LightStars(int count)
        {
            Color on = Color.FromArgb(241, 196, 15);
            Color off = Color.FromArgb(127, 140, 141);
            switch (count)
            {
                case 1:
                    labelStar1.ForeColor = on;
                    labelStar2.ForeColor = off;
                    labelStar3.ForeColor = off;
                    labelStar4.ForeColor = off;
                    labelStar5.ForeColor = off;
                    labelGrade.Text = "Unacceptable";
                    labelGrade.ForeColor = Color.FromArgb(231, 76, 60);

                    break;
                case 2:
                    labelStar1.ForeColor = on;
                    labelStar2.ForeColor = on;
                    labelStar3.ForeColor = off;
                    labelStar4.ForeColor = off;
                    labelStar5.ForeColor = off;
                    labelGrade.Text = "Unacceptable";
                    labelGrade.ForeColor = Color.FromArgb(231, 76, 60);
                    break;
                case 3:
                    labelStar1.ForeColor = on;
                    labelStar2.ForeColor = on;
                    labelStar3.ForeColor = on;
                    labelStar4.ForeColor = off;
                    labelStar5.ForeColor = off;
                    labelGrade.Text = "Acceptable";
                    labelGrade.ForeColor = Color.FromArgb(230, 126, 34);
                    break;
                case 4:
                    labelStar1.ForeColor = on;
                    labelStar2.ForeColor = on;
                    labelStar3.ForeColor = on;
                    labelStar4.ForeColor = on;
                    labelStar5.ForeColor = off;
                    labelGrade.Text = "Good";
                    labelGrade.ForeColor = Color.FromArgb(241, 196, 15);
                    break;
                case 5:
                    labelStar1.ForeColor = on;
                    labelStar2.ForeColor = on;
                    labelStar3.ForeColor = on;
                    labelStar4.ForeColor = on;
                    labelStar5.ForeColor = on;
                    labelGrade.Text = "Very Good";
                    labelGrade.ForeColor = Color.FromArgb(46, 204, 113);
                    break;
                default:
                    labelStar1.ForeColor = off;
                    labelStar2.ForeColor = off;
                    labelStar3.ForeColor = off;
                    labelStar4.ForeColor = off;
                    labelStar5.ForeColor = off;
                    labelGrade.Text = "";
                    break;
            }
        }

        private int GetRating(string rating)
        {
            //Debug.WriteLine("--"+rating+ "--");
            if (rating == " vgood") return 5;
            else if (rating == " good") return 4;
            else if (rating == " acc") return 3;
            else if (rating == " unacc") return 2;
            else return 1;
        }

        private int GetPassenger(int i)
        {
            switch (i)
            {
                case 1: return 2;
                case 2: return 4;
                case 3: return 5;
                default: return 0;
            }
        }

        private int GetPassengersTrackValue(int passengers)
        {
            switch (passengers)
            {
                case 1:
                case 2: return 1;
                case 3:
                case 4: return 2;
                default: return 3;
            }
        }

        private void ResetCar()
        {
            if (labelSpecs.Text != "Specifications")
            {
                labelSpecs.Text = "Specifications";
                labelSpecs.ForeColor = Color.FromArgb(44, 62, 80);
                pictureBoxCar.Image = Properties.Resources.Car01;
            }
            labelRating.ForeColor = Color.FromArgb(127, 140, 141);
            labelGrade.Text = "";
        }

        private void trackBarPrice_Scroll(object sender, EventArgs e)
        {
            ResetCar();
        }
    }
}
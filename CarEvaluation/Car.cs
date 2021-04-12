using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarEvaluation
{
    [Serializable]
    public class Car
    {
        private Image image;
        private string name;
        private int price;
        private int maintenance;
        private int doors;
        private int passengers;
        private int luggage;
        private int safety;

        public Image Image { get => image; set => image = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Maintenance { get => maintenance; set => maintenance = value; }
        public int Doors { get => doors; set => doors = value; }
        public int Passengers { get => passengers; set => passengers = value; }
        public int Luggage { get => luggage; set => luggage = value; }
        public int Safety { get => safety; set => safety = value; }

        public Car(Image image,string name, int price, int maintenance, int doors, int passengers, 
            int luggage, int safety)
        {
            this.image = image;
            this.name = name;
            this.price = price;
            this.maintenance = maintenance;
            this.doors = doors;
            this.passengers = passengers;
            this.luggage = luggage;
            this.safety = safety;
        }

        public void SaveCar()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "car";
            saveFile.AddExtension = true;
            saveFile.Filter = "Car files | *.car";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                WriteToBinaryFile<Car>(saveFile.FileName, this, false);
            }
            else
            {
                MessageBox.Show("Error saving car.");
            }
        }

        static public Car LoadCar()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Car files | *.car";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return ReadFromBinaryFile<Car>(openFile.FileName);
            }
            return null;
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
    }
}

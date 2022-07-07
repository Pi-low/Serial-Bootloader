using System;
using System.IO.Ports;


namespace NelloCom
{
	public partial class Form1 : Form
	{
		private List<messageHex> HexList;
		public Form1()
		{
			InitializeComponent();
			HexList = new List<messageHex>();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames();

			

			// Display each port name to the console.
			foreach (string port in ports)
			{
				cmbListSerial.Items.Add(port);
			}
		}

		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			HexList.Clear();
			foreach (string line in File.ReadLines(openFileDialog1.FileName))
			{
				HexList.Add(new messageHex(line));
			}
		}

		private void BtOuvrir_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = Environment.SpecialFolder.Personal.ToString();
			openFileDialog1.Filter = "binaire files (*.srec)|*.srec|hexa files (*.hex)|*.hex|All files (*.*)|*.*";
			openFileDialog1.Title = "Selectionner un fichier";
			openFileDialog1.FilterIndex = 2;
			//openFileDialog1.RestoreDirectory = true;
			openFileDialog1.ShowDialog();

		}
	}
}
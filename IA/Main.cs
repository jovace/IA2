using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IA
{
    public partial class Main : Form
    {
        Dictionary<string, Estacion> estaciones;
        Dictionary<int, string> estacionesName;

        public Main()
        {
            InitializeComponent();
            this.estaciones = new Dictionary<string, Estacion>();
            this.estacionesName = new Dictionary<int, string>();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtRutaGrafo.Text = openFileGrafo.FileName;
        }

        private void btnAbrirGrafo_Click(object sender, EventArgs e)
        {
            openFileGrafo.ShowDialog();
        }

        private void btnAbrirDistancias_Click(object sender, EventArgs e)
        {
            openFileDistancias.ShowDialog();
        }

        private void openFileDistancias_FileOk(object sender, CancelEventArgs e)
        {
            txtRutaDistancias.Text = openFileDistancias.FileName;
            analizarFicheroDistancias();
        }

        private void analizarFicheroDistancias()
        {
            string[] filelines2 = File.ReadAllLines(openFileDistancias.FileName);
            string[] filelines = filelines2[0].Split(';');

            for (int i = 0; i < filelines.Length-1; i++) {
                string[] linea = filelines[i].Split(':');
                string nombre = linea[0];
                double lat = Double.Parse(linea[1], CultureInfo.InvariantCulture);
                double lng = Double.Parse(linea[2], CultureInfo.InvariantCulture);
                Estacion estacion = new Estacion(nombre, lat, lng);
                estaciones[nombre] = estacion;
                estacionesName[i] = nombre;
            }


            for (int i = 0; i < filelines.Length - 1; i++)
            {
                Estacion estacion = estaciones[estacionesName[i]];
                string[] linea = filelines[i].Split(':');
                string[] dists = linea[3].Trim('[').Trim(']').Split(',');
                for (int j = 0; j < dists.Length - 1; j++)
                {
                    estacion.putDist(estacionesName[j], Double.Parse(dists[j], CultureInfo.InvariantCulture));
                }

            }

            Console.WriteLine("Todo correcto");    
        }
    }

    class Estacion {
        string name;
        double lat;
        double lng;
        Dictionary<String, double> distances;

        public Estacion(string name, double lat, double lng) {
            this.name = name;
            this.lat = lat;
            this.lng = lng;
            this.distances = new Dictionary<string, double>();
        }

        public void putDist(string to, double dist) {
            this.distances[to] = dist;
        }

        public double getDist(string to) {
            return this.distances[to];
        }
    }
}

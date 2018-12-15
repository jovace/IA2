using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IA
{
    public partial class DetalleRuta : Form
    {
        Dictionary<Estacion, Estacion> vieneDe = new Dictionary<Estacion, Estacion>();
        Dictionary<Estacion, double> gScore = new Dictionary<Estacion, double>();
        Estacion estFinal, estInicio;

        public DetalleRuta()
        {
            InitializeComponent();
        }

        public void setVariables(Dictionary<Estacion, Estacion> vieneDe, Dictionary<Estacion, double> gScore, Estacion estInicio, Estacion estFinal) {
            this.vieneDe = vieneDe;
            this.gScore = gScore;
            this.estInicio = estInicio;
            this.estFinal = estFinal;
            rellenarCampos();
        }

        public void rellenarCampos()
        {
            dataGridView1.Rows.Clear();
            Estacion actual = this.estFinal;
            int nEstaciones = 1;

            while (!actual.Equals(this.estInicio))
            {
                nEstaciones++;
                actual = vieneDe[actual];
            }

            actual = this.estFinal;
            int cEstaciones = 0;
            while (!actual.Equals(this.estInicio))
            {
                dataGridView1.Rows.Add(nEstaciones - cEstaciones-1, actual.getName(), gScore[actual], gScore[actual] - gScore[vieneDe[actual]], getTiempoAc(gScore[actual]), getTiempoInt(actual), hayTransbordo(actual));
                actual = vieneDe[actual];
                cEstaciones++;
            }

            dataGridView1.Sort(dataGridView1.Columns["Paso"], ListSortDirection.Ascending);
        }

        private object hayTransbordo(Estacion actual)
        {
            if (actual.getName().Equals("Alisher-Navoi")) {
                    if (vieneDe[actual].getName().Equals("Pakhtakor")) return true;
            }
            if (actual.getName().Equals("Pakhtakor"))
            {
                if (vieneDe[actual].getName().Equals("Alisher-Navoi")) return true;
            }
            if (actual.getName().Equals("Ming-Urik"))
            {
                if (vieneDe[actual].getName().Equals("Oybek")) return true;
            }
            if (actual.getName().Equals("Oybek"))
            {
                if (vieneDe[actual].getName().Equals("Ming-Urik")) return true;
            }
            if (actual.getName().Equals("Amir-Temur-Hiyoboni"))
            {
                if (vieneDe[actual].getName().Equals("Yunus-Rajabiy")) return true;
            }
            if (actual.getName().Equals("Yunus-Rajabiy"))
            {
                if (vieneDe[actual].getName().Equals("Amir-Temur-Hiyoboni")) return true;
            }
            return false;
        }

        public int getTiempoAc(double dist)
        {
            return (int)Math.Ceiling((dist / 46000) * 60);
        }

        public double getTiempoInt(Estacion actual) {
            return Math.Round(((gScore[actual] - gScore[vieneDe[actual]] / 46000) * 60),2,MidpointRounding.AwayFromZero);
        }
    }
}

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
    public partial class DetalleVariables : Form
    {
        //private HashSet<Estacion> conjuntoCerrado;
        //private HashSet<Estacion> conjuntoAbierto;
        //private Dictionary<Estacion, Estacion> vieneDe;
        //private Dictionary<Estacion, double> gScore;
        //private Dictionary<Estacion, double> fScore;
        public DetalleVariables()
        {
            InitializeComponent();
        }

        public void SetVariables(Dictionary<int, string> estacionesName,
            Dictionary<Estacion, double> gScore,
            Dictionary<Estacion, double> fScore,
            HashSet<Estacion> conjuntoCerrado,
            HashSet<Estacion> conjuntoAbierto,
            Dictionary<Estacion, Estacion> vieneDe)
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";

            foreach (Estacion est in gScore.Keys) {
                dataGridView1.Rows.Add(est.getName(), (int) gScore[est], (int) fScore[est], vieneDe[est].getName());
            }

            conjuntoAbierto.OrderBy(est => fScore[est]); //-
            conjuntoCerrado.OrderBy(est => gScore[est]);
            foreach (Estacion est in conjuntoAbierto) {
                textBox1.Text=textBox1.Text+(est.getName()+"->"+(int)fScore[est]+"\r\n");
            }
            foreach (Estacion est in conjuntoCerrado)
            {
                textBox2.Text = textBox2.Text + (est.getName() + "->" + (int)gScore[est] + "\r\n");
            }

            dataGridView1.Sort(this.dataGridView1.Columns["Column1"], ListSortDirection.Descending);
        }
    }
}

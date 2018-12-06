using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IA
{
    public partial class Main : Form
    {
        //Velocidad media del metro en metros/hora
        const double VELMEDIA = 46000;

        Dictionary<string, Estacion> estaciones;
        Dictionary<int, string> estacionesName;
        //double minlat=90, maxlat=0, minlng=180, maxlng=0;
        bool inicioSet = false;
        bool finalSet = false;
        Estacion estacionInicio;
        Estacion estacionFinal;

        public Main()
        {
            InitializeComponent();
            this.estaciones = new Dictionary<string, Estacion>();
            this.estacionesName = new Dictionary<int, string>();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtRutaGrafo.Text = openFileGrafo.FileName;
            analizarFicheroGrafo();
        }

        private void analizarFicheroGrafo()
        {
            string[] filelines2 = File.ReadAllLines(openFileGrafo.FileName);

            for (int i = 0; i < filelines2.Length; i++) {
                string[] data = filelines2[i].Split(';');
                string nombre = data[0];
                Estacion estacion = estaciones[nombre];
                string[] vecinos = data[1].Trim('[').Trim(']').Split(',');
                for (int j = 0; j < vecinos.Length; j++) {
                    Estacion estacionVecina = estaciones[vecinos[j]];
                    estacion.conectar(estacionVecina);
                    estacionVecina.conectar(estacion);
                }
            }

            Console.WriteLine("Todo correcto");
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Estacion item in estaciones.Values)
            {
                item.dibujar(e.Graphics);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Estacion clicked=null;
            bool encontrado = false;
            for (int i = 0; i < estaciones.Values.Count && !encontrado; i++)
            {
                if (estaciones[estacionesName[i]].esDentro(e.X, e.Y)) {
                    encontrado = true;
                    clicked = estaciones[estacionesName[i]];
                }
            }
            if (clicked == null)
            {
                return;
            }

            if (!inicioSet) {
                estacionInicio = clicked;
                cbEstacionInicio.Text = clicked.getName();
                inicioSet = true;
            }
            else
            {
                if (!finalSet)
                {
                    estacionFinal = clicked;
                    cbEstacionFinal.Text = clicked.getName();
                    finalSet = true;
                }
                else
                {
                    finalSet = false;
                    estacionInicio = clicked;
                    cbEstacionInicio.Text = clicked.getName();
                    inicioSet = true;
                }
            }
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
                /*if (lat < minlat) minlat = lat;
                if (lat > maxlat) maxlat = lat;
                if (lng < minlng) minlng = lng;
                if (lng > maxlng) maxlng = lng;*/
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

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            foreach (String nombre in estaciones.Keys) {
                cbEstacionFinal.Items.Add(nombre);
                cbEstacionInicio.Items.Add(nombre);
            }
            panel2.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Estacion item in estaciones.Values)
            {
                item.dibujar(e.Graphics);
            }
        }

        private void cbEstacionInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            if (!inicioSet || estacionInicio==null) {
                //Error
            }
            if (!finalSet || estacionFinal==null) {
                //Error
            }

            calcularRuta(estacionInicio, estacionFinal);
        }

        private void calcularRuta(Estacion estacionInicio, Estacion estacionFinal) {
            HashSet<Estacion> conjuntoCerrado = new HashSet<Estacion>();
            HashSet<Estacion> conjuntoAbierto = new HashSet<Estacion>();
            Dictionary<Estacion, Estacion> vieneDe = new Dictionary<Estacion, Estacion>();
            Dictionary<Estacion, double> gScore = new Dictionary<Estacion, double>();
            Dictionary<Estacion, double> fScore = new Dictionary<Estacion, double>();

            foreach (Estacion item in estaciones.Values) {
                gScore[item] = double.PositiveInfinity;
                fScore[item] = double.PositiveInfinity;
            }

            gScore[estacionInicio] = 0;
            fScore[estacionInicio] = estacionInicio.getDist(estacionFinal.getName());

            conjuntoAbierto.Add(estacionInicio);

            while (conjuntoAbierto.Count != 0) {
                Estacion actual = menorFScore(fScore, conjuntoAbierto);
                if (actual.Equals(estacionFinal)) {
                    txtTiempo.Text = Math.Ceiling((gScore[estacionFinal] / VELMEDIA) * 60).ToString();
                    MessageBox.Show(reconstruirRuta(vieneDe, actual,estacionInicio), "Ruta más corta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conjuntoAbierto.Remove(actual);
                conjuntoCerrado.Add(actual);

                foreach (Estacion vecino in actual.getAdyacentes().Values) {
                    if (conjuntoCerrado.Contains(vecino)) continue;

                    double distAproximadaG = gScore[actual] + actual.getDist(vecino.getName());

                    if (!conjuntoAbierto.Contains(vecino))
                    {
                        conjuntoAbierto.Add(vecino);
                    }
                    else if (distAproximadaG >= gScore[vecino]) {
                        continue;
                    }

                    vieneDe[vecino] = actual;
                    gScore[vecino] = distAproximadaG;
                    fScore[vecino] = gScore[vecino] + vecino.getDist(estacionFinal.getName());
                }

            }


        }

        private String reconstruirRuta(Dictionary<Estacion, Estacion> vieneDe, Estacion actual, Estacion inicio) {
            String ruta = "Ruta desde "+inicio.getName()+" hasta "+actual.getName()+": \n " + inicio.getName();
            String listaEstaciones = "";
            while (!actual.Equals(inicio)) {
                listaEstaciones = " -> " + actual.getName() + listaEstaciones;
                actual = vieneDe[actual];
            }
            return ruta + listaEstaciones;
        }

        private Estacion menorFScore(Dictionary<Estacion, double> fScore, HashSet<Estacion> conjuntoAbierto) {
            Estacion menor = null;
            double menorValor = double.PositiveInfinity;
            foreach (Estacion item in conjuntoAbierto) {
                if (fScore[item] < menorValor) {
                    menorValor = fScore[item];
                    menor = item;
                }
            }

            return menor;
        }
    }

    class Estacion {
        const double MAXLAT = 41.352894;
        const double MINLAT = 41.257376;
        const double MAXLNG = 69.327885;
        const double MINLNG = 69.195797;
        const int ALTO = 555;
        const int ANCHO = 917;
        const int RADIO = 30;
        


        string name;
        double lat;
        double lng;
        Dictionary<String, double> distances;
        Dictionary<String, Estacion> adyacentes;

        Pen circulo;
        Pen lin;
        GraphicsPath gp;
        Font letra;
        Rectangle rec;

        public Estacion(string name, double lat, double lng) {
            this.name = name;
            this.lat = lat;
            this.lng = lng;
            this.distances = new Dictionary<string, double>();
            this.adyacentes = new Dictionary<string, Estacion>();
            circulo = new Pen(Brushes.Black, 3);
            gp = new GraphicsPath();
            letra = new Font("arial", 10);
            rec = new Rectangle(getPosX() - RADIO, getPosY() - RADIO, 2 * RADIO, 2 * RADIO);
            lin = new Pen(Brushes.DimGray, 1);
        }

        public void putDist(string to, double dist) {
            this.distances[to] = dist;
        }

        public double getDist(string to) {
            return this.distances[to];
        }

        public string getName() {
            return this.name;
        }

        public void conectar(Estacion vecino) {
            adyacentes[vecino.getName()] = vecino;
        }

        public int getPosY() {
            double latDiff = MAXLAT - MINLAT;

            int pix = (int)(((this.lat - MINLAT) / latDiff) * ALTO);

            return 599-(pix+22);
        }

        public int getPosX()
        {
            double lngDiff = MAXLNG - MINLNG;

            int pix = (int)(((this.lng - MINLNG) / lngDiff) * ANCHO);

            return pix+22;
        }

        public bool esDentro(int clickX, int clickY) {
            int difX=Math.Abs(this.getPosX()-clickX);
            int difY = Math.Abs(this.getPosY() - clickY);
            difX *= difX;
            difY *= difY;
            difX += difY;
            if (Math.Sqrt(difX) < 21) { return true; } else { return false; }
        }

        public void dibujar(Graphics g) {
            DibujaNodo(g);
            DibujaArista(g);
        }

        public virtual void DibujaNodo(Graphics g)
        {
            g.FillPath(Brushes.Goldenrod, gp);
            g.DrawPath(circulo, gp);
            if (!this.name.Equals("Alisher-Navoi") && !this.name.Equals("Amir-Temur-Hiyoboni") && !this.name.Equals("Ming-Urik"))
            {
                g.DrawString(this.name, letra, Brushes.Black, rec, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        
        public virtual void DibujaArista(Graphics g)
        {
            foreach (Estacion item in adyacentes.Values)
            {
                double tg = (double)(getPosY() - item.getPosY()) / (item.getPosX() - getPosX());
                double atg = Math.Atan(tg);

                int a = (int)(RADIO * Math.Cos(atg));
                int b = (int)(RADIO * Math.Sin(atg));

                if ((getPosX() < item.getPosX()))
                {
                    a *= -1;
                    b *= -1;
                }

                Point p = new Point(item.getPosX() + a, item.getPosY() - b);
                g.DrawLine(lin, getPosX(),getPosY(),item.getPosX(),item.getPosY());
            }
        }

        public Dictionary<String, Estacion> getAdyacentes() {
            return this.adyacentes;
        }
    }
}

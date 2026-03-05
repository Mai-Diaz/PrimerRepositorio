namespace PruebaWindowsForm
{
    public partial class Form1 : Form
    {
        public int Count{ get; set; }

        public Form1()
        {
            InitializeComponent();
            Count = 0;
            InicializarBoton();
        }

        private void InicializarBoton()
        {
            Button btnMostrarEtiqueta = new Button();
            btnMostrarEtiqueta.Text = "Mostrar";
            btnMostrarEtiqueta.Size = new Size(200, 50);
            btnMostrarEtiqueta.Location = new Point(350, 30);
            btnMostrarEtiqueta.Click += Mostrar_Etiqueta;
            btnMostrarEtiqueta.Click += button1_Click;
            this.Controls.Add(btnMostrarEtiqueta); //'controls' es una lista interna de los formularios
                                                    //que tiene todos los componentes
        }

        public void Mostrar_Etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();//genere etiqueta cuando de clic
            //lblEtiqueta FontColor = Color.BlueViolet;
            lblEtiqueta.Text = "Soy Una Etiqueta";
            lblEtiqueta.Size = new Size(100, 50);
            lblEtiqueta.Location = new Point(100,250);
            this.Controls.Add(lblEtiqueta);

        }

        private void button1_Click(object sender, EventArgs e) //sender-> quien mando a llamar al Evento
        {
            Count++;
            btn1.Text = Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

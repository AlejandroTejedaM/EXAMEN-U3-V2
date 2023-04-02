using System.Drawing.Text;
using System.Resources;
using ControlVehiculo;
using EXAMEN_U3_V2;
using EXAMEN_U3_V2.Properties;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EXAMEN_U3_V2
{
    public partial class Form1 : Form
    {

        #region Variables
        bool movimiento;
        Thread hiloMovimientoCarro;
        Thread hiloPintura;
        Thread hiloEnsamblado;
        List<ControlVehiculo.ControlVehiculo> ListaVehiculosVerificados;
        List<ControlVehiculo.ControlVehiculo> ListaCarroUnico;
        ControlVehiculo.ControlVehiculo ImagenCarroNuevo;
        bool botonCrearCarros;
        int contCola;
        int contProceso;
        int contTerminados;
        int velocidad;
        bool IndicarMSJ = false;
        List<PictureBox> listaGotas;
        List<PictureBox> listaTuercas;
        int auxIntDelegado = 0;
        List<int> listaNumerosCarrosTerminados;
        bool opcion = false;
        #endregion
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            listaGotas = new List<PictureBox>();
            listaTuercas = new List<PictureBox>();
            movimiento = true;
            botonCrearCarros = true;
            contCola = 0;
            contProceso = 0;
            contTerminados = 0;
            velocidad = 80;
            listaNumerosCarrosTerminados = new List<int>();

            btnIngresarVehiculoNuevo.Visible = botonCrearCarros;

            txtCola.Text = contCola.ToString();
            txtProceso.Text = contProceso.ToString();
            txtTerminados.Text = contTerminados.ToString();
        }

        #region Delegados
        private delegate void delegado_mover_carro_inicio(int x, int y, Control sender, bool opcion);

        private delegate void delegado_imagenes_pintura(Control pintura, bool opcion, int x, int y);

        private delegate void delegado_imagenes_tuerca(Control pintura, bool opcion, int x, int y);
        #endregion

        #region Métodos Delegados
        private void metodo_llamar_delegado_carro_inicio(int x, int y, Control carro, bool opcion)
        {
            try
            {
                if (InvokeRequired)
                {
                    delegado_mover_carro_inicio DMcarroInicio = new delegado_mover_carro_inicio(metodo_llamar_delegado_carro_inicio);
                    object[] parametros = new object[] { x, y, carro, opcion };
                    Invoke(DMcarroInicio, parametros);
                }
                else
                {
                    if (opcion == true)
                    {
                        Controls.Add(carro);
                    }
                    carro.Location = new Point(x, y);
                    if (x + carro.Width >= Width)
                    {

                        auxIntDelegado += 1;
                        carro.Dispose();
                        contProceso = 0;
                        txtProceso.Text = contProceso.ToString();
                        txtTerminados.Text = contTerminados.ToString();
                        botonCrearCarros = true;
                        btnIngresarVehiculoNuevo.Visible = botonCrearCarros;
                        if (IndicarMSJ == false)
                        {
                            MessageBox.Show("Vehiculo terminado y verificado");
                            IndicarMSJ = !IndicarMSJ;
                        }
                        else
                        {
                            IndicarMSJ = !IndicarMSJ;
                        }
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }

        }
        private void llamar_imagenes_pintura(Control pintura, bool opcion, int x, int y)
        {
            try
            {
                if (InvokeRequired)
                {
                    delegado_imagenes_pintura DMcarroInicio = new delegado_imagenes_pintura(llamar_imagenes_pintura);
                    object[] parametros = new object[] { pintura, opcion, x, y };
                    Invoke(DMcarroInicio, parametros);
                }
                else
                {
                    if (opcion == true)
                    {
                        Controls.Add(pintura);
                    }
                    pintura.Location = new Point(x, y);
                    if (x + pintura.Width >= pbPintura.Width)
                    {
                        pintura.Visible = true;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }
        private void llamar_imagenes_tuerca(Control tuerca, bool opcion, int x, int y)
        {
            try
            {
                if (InvokeRequired)
                {
                    delegado_imagenes_tuerca DMcarroInicio = new delegado_imagenes_tuerca(llamar_imagenes_tuerca);
                    object[] parametros = new object[] { tuerca, opcion, x, y };
                    Invoke(DMcarroInicio, parametros);
                }
                else
                {
                    if (opcion == true)
                    {
                        Controls.Add(tuerca);
                    }
                    tuerca.Location = new Point(x, y);
                    if (x + tuerca.Width >= pbEnsambladora.Width)
                    {
                        tuerca.Visible = true;
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }

        #endregion

        #region Métodos Hilos
        private void movimiento_carro_inicio()
        {
            try
            {
                int x = ImagenCarroNuevo.Location.X;
                int y = ImagenCarroNuevo.Location.Y;
                bool derecha = true;
                metodo_llamar_delegado_carro_inicio(x, y, ImagenCarroNuevo, true);
                while (true)
                {
                    if (derecha)
                    {
                        metodo_llamar_delegado_carro_inicio(x, y, ImagenCarroNuevo, false);
                        if (x + ImagenCarroNuevo.Width >= Width)
                        {
                            derecha = !derecha;
                        }
                        if (ImagenCarroNuevo.Bounds.IntersectsWith(pbEnsambladora.Bounds))
                        {
                            velocidad = 150;
                            var disminuir = new Action(() =>
                            {
                                ImagenCarroNuevo.SetParametros(Resources._2car);
                            });
                            ImagenCarroNuevo.Invoke(disminuir);
                        }
                        if (x + ImagenCarroNuevo.Width >= pbEnsambladora.Width)
                        {
                            velocidad = 80;
                        }
                        if (ImagenCarroNuevo.Bounds.IntersectsWith(pbPintura.Bounds))
                        {
                            var disminuir = new Action(() =>
                            {
                                ImagenCarroNuevo.SetParametros(Resources.queeeeeeeeeep__1_);
                            });
                            ImagenCarroNuevo.Invoke(disminuir);
                        }
                        if (ImagenCarroNuevo.Bounds.IntersectsWith(pbVerificacion.Bounds))
                        {
                            int xAux = ImagenCarroNuevo.Location.X;
                            x += 5;

                            if (ImagenCarroNuevo.Bounds.IntersectsWith(pbVerificacion.Bounds))
                            {
                                velocidad = 300;
                                if (progressBar1.Value <= 10)
                                {
                                    var disminuir = new Action(() =>
                                    {
                                        if (progressBar1.Value < 10)
                                        {
                                            progressBar1.Value++;
                                        }

                                    });
                                    progressBar1.Invoke(disminuir);
                                }
                            }

                        }
                        if (x + ImagenCarroNuevo.Width >= Width)
                        {
                            velocidad = 80;
                            if (opcion == false || x + ImagenCarroNuevo.Width >= Width)
                            {
                                var BajarGotas = new Action(() =>
                                {
                                    foreach (PictureBox g in listaGotas)
                                    {
                                        g.Visible = false;
                                    }
                                });
                                pbPintura.Invoke(BajarGotas);

                                if (progressBar1.Value <= 10)
                                {
                                    var disminuir = new Action(() =>
                                    {
                                        if (progressBar1.Value <= 10)
                                        {
                                            progressBar1.Value = 0;
                                        }
                                    });
                                    progressBar1.Invoke(disminuir);
                                }

                                var BajarTuercas = new Action(() =>
                                {
                                    foreach (PictureBox g in listaTuercas)
                                    {
                                        g.Visible = false;
                                    }
                                });
                                pbPintura.Invoke(BajarTuercas);
                            }

                        }
                        if (x + ImagenCarroNuevo.Height + 50 >= pbPintura.Height + 20)
                        {
                            var BajarGotas = new Action(() =>
                            {
                                foreach (PictureBox g in listaGotas)
                                {
                                    g.Visible = false;
                                }
                            });
                            pbPintura.Invoke(BajarGotas);
                        }
                        if (x + ImagenCarroNuevo.Height + 50 >= pbEnsambladora.Height + 20)
                        {
                            var BajarTuercas = new Action(() =>
                            {
                                foreach (PictureBox g in listaTuercas)
                                {
                                    g.Visible = false;
                                }
                            });
                            pbPintura.Invoke(BajarTuercas);
                        }
                        metodo_llamar_delegado_carro_inicio(x, y, ImagenCarroNuevo, false);
                        x += 20;
                    }

                    Thread.Sleep(velocidad);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }
        private void movimiento_pintura()
        {
            try
            {
                Random rand = new Random();
                int contador = 0;
                opcion = true;
                bool pasada = false;
                while (true)
                {
                    if (ImagenCarroNuevo.Bounds.IntersectsWith(pbPintura.Bounds))
                    {
                        while (contador != 100)
                        {
                            PictureBox gota = new PictureBox();
                            gota.Image = Properties.Resources.Gotas;
                            gota.SizeMode = PictureBoxSizeMode.StretchImage;
                            gota.Size = new Size(40, 40);
                            int x = rand.Next(1047, 1185);
                            int y = rand.Next(100, 300);
                            int medio = x - 10 + (pbPintura.Width / 2);
                            llamar_imagenes_pintura(gota, true, x, y);
                            while (y <= pbPintura.Height)
                            {
                                llamar_imagenes_pintura(gota, false, x, y + 20);
                                y += 9;
                            }
                            llamar_imagenes_pintura(gota, false, x, y + 9);
                            contador += 1;
                            listaGotas.Add(gota);
                        }
                    }

                    Thread.Sleep(45);
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }

        private void movimiento_Ensamblado()
        {

            try
            {
                Random rand = new Random();
                int contador = 0;
                opcion = true;
                bool pasada = false;
                while (true)
                {
                    if (ImagenCarroNuevo.Bounds.IntersectsWith(pbEnsambladora.Bounds))
                    {
                        while (contador != 100)
                        {
                            PictureBox tuerca = new PictureBox();
                            tuerca.Image = Properties.Resources.llaveInglesa;
                            tuerca.SizeMode = PictureBoxSizeMode.StretchImage;
                            tuerca.Size = new Size(40, 40);
                            int x = rand.Next(481, 600);
                            int y = rand.Next(100, 300);
                            int medio = x - 10 + (pbEnsambladora.Width / 2);
                            llamar_imagenes_tuerca(tuerca, true, x, y);
                            while (y <= pbEnsambladora.Height)
                            {
                                llamar_imagenes_tuerca(tuerca, false, x, y + 20);
                                y += 9;
                            }
                            llamar_imagenes_tuerca(tuerca, false, x, y + 9);
                            contador += 1;
                            listaTuercas.Add(tuerca);
                        }
                    }

                    Thread.Sleep(45);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }

        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Bienvenido a la MATRIX");
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }

        private void btnIngresarVehiculoNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                //creado
                ImagenCarroNuevo = new ControlVehiculo.ControlVehiculo();
                ImagenCarroNuevo.SetParametros(Resources._1car);
                ImagenCarroNuevo.Location = new Point(0, 300);
                ControlVehiculo.ControlVehiculo carro = ImagenCarroNuevo.Clone() as ControlVehiculo.ControlVehiculo;

                ListaCarroUnico = new List<ControlVehiculo.ControlVehiculo>();
                ListaCarroUnico.Add(carro);

                //inicia movimiento
                hiloMovimientoCarro = new Thread(movimiento_carro_inicio);
                hiloMovimientoCarro.Start();

                //desactivamos para crear mas carros
                botonCrearCarros = false;
                btnIngresarVehiculoNuevo.Visible = botonCrearCarros;
                contProceso += 1;
                contTerminados += 1;
                txtProceso.Text = contProceso.ToString();

                hiloPintura = new Thread(movimiento_pintura);
                hiloPintura.Start();

                hiloEnsamblado = new Thread(movimiento_Ensamblado);
                hiloEnsamblado.Start();

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
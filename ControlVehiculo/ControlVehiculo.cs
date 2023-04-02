using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVehiculo
{
    public partial class ControlVehiculo : UserControl
    {
        public ControlVehiculo()
        {
            InitializeComponent();
        }

        public ControlVehiculo Clone()
        {
            return (ControlVehiculo)MemberwiseClone();
        }

        public void SetParametros(Image image)
        {
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

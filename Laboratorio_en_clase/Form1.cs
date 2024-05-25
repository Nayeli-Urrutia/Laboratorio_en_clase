using Laboratorio_en_clase.Data;
using Laboratorio_en_clase.Data.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_en_clase
{
    public partial class Form1 : Form


    {
        private CLASE_LABORATORIO objeto;

        public Form1()
        {
            InitializeComponent();
            objeto = new CLASE_LABORATORIO ("localhost", "root", "");
        }

       
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewcatalogo.DataSource = objeto.LeerObjetos();
        }










    }
 }


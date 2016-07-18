using System;
using System.Windows.Forms;
using IRI.Win32.CSharp.IRIWrapper;
using System.IO.Ports;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Net.NetworkInformation;
using System.Drawing;

namespace TagGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //using (var db = new BD())
            //{
            //    db.Terceirizados.Add(new Terceirizado
            //    {
            //        Empresa = "CETUC",
            //        Nome = "Anderson",
            //        Identificacao = "Bacharel em elétrica"
            //    });

            //    db.SaveChanges();
            //}


            ReaderHelper.Instance.Connect("COM3");
            ReaderHelper.Instance.Start();
            ReaderHelper.Instance.TagReported += tag => Invoke(new MethodInvoker(() => textBoxEPC.Text = tag.Epc));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
   }
}
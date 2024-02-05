using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetSatis.BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetSatisContext context = new NetSatisContext();
            CariDAL cariDal = new CariDAL();
            Cari entitiy = new Cari
            {
                CariKodu="1234456789"
                
            };

            cariDal.AddOrUpdate(context, entitiy);
            cariDal.Save(context);

        }
    }
}

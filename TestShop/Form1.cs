﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestShop.Model;
using TestShop.Services;

namespace TestShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Университет Университеты = new Университет();
            Университеты.Название = "Пгу Пи....фывф";
            DBService.Save(Университеты);
            Факультет Факультеты = new Факультет();
            Факультеты.Название = "Свинофак";
            Факультеты.idУниверситет = Университеты;
            DBService.Save(Факультеты);
        }
    }
}

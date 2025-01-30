﻿using MasterPolZAA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterPolZAA.CustomControls;
using MasterPolZAA.Services;
using MasterPolZAA.Services.MasterPol.Services;

namespace MasterPolZAA.AppForms
{
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            UserExperienceManager.SetTitle(this, "Список партнеров");
        }

        private void ShowPartners()
        {
            List<Partner> partners = Program.context.Partner.OrderBy(p => p.PartnerName).ToList();

            foreach (Partner partner in partners)
            {
                splitContainer.Panel2.Controls[0].Controls.Add(new PartnerUserControl(partner));
            }
        }
        private void ClearPartnerList()
        {
            splitContainer.Panel2.Controls[0].Controls.Clear();
        }

        public void RefreshPartners()
        {
            ClearPartnerList();
            ShowPartners();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowPartners();
            UserExperienceManager.CustomizeControls(splitContainer.Panel1.Controls);
        }

        private void newPartnerAttentionBackground_Click(object sender, EventArgs e)
        {
            CreateUpdatePartnerForm createUpdatePartnerForm = new CreateUpdatePartnerForm();
            DialogResult partnerSaved = createUpdatePartnerForm.ShowDialog();

            if (partnerSaved == DialogResult.OK)
            {
                RefreshPartners();
            }
        }
    }
}

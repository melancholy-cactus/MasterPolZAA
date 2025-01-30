﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterPolZAA.AppForms;
using MasterPolZAA.Models;
using MasterPolZAA.Services.MasterPol.Services;

namespace MasterPolZAA.CustomControls
{
    public partial class PartnerUserControl : UserControl
    {
        private Partner _partner;
        public PartnerUserControl(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
            SetLabelTextValues();
        }

        private void SetLabelTextValues()
        {
            typeAndName.Text = $"{_partner.PartnerType.PartnerTypeName} | {_partner.PartnerName}";
            ceo.Text = _partner.Ceo;
            phone.Text = String.Format("{0: +0 000 000 00 00}", _partner.Phone);      
            rating.Text = $"Рейтинг: {_partner.Rating}";
            discount.Text = $"{_partner.Discount} %";
        }

        private void historyAttentionBackground_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(_partner);
            historyForm.ShowDialog();
        }

        private void PartnerUserControl_Click(object sender, EventArgs e)
        {
            CreateUpdatePartnerForm createUpdatePartnerForm = new CreateUpdatePartnerForm(_partner);
            DialogResult partnerSaved = createUpdatePartnerForm.ShowDialog();
            
            if (partnerSaved == DialogResult.OK)
            {
                MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;
                mainForm.RefreshPartners();
            }
        }

        private void PartnerUserControl_Load(object sender, EventArgs e)
        {
            UserExperienceManager.CustomizeControls(this.Controls);
        }

        private void PartnerUserControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                ColorTranslator.FromHtml(Constants.Color.attentionColor), ButtonBorderStyle.Solid);
        }
    }
}

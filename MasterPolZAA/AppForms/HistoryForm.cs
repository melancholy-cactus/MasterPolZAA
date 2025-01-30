using MasterPolZAA.Models;
using MasterPolZAA.Services.MasterPol.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolZAA.AppForms
{
    public partial class HistoryForm : ParentForm
    {
        private Partner _partner;
        public HistoryForm(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
            UserExperienceManager.SetTitle(this, $"История продаж компании \"{_partner.PartnerName}\"");
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "master_pol_zaaDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.master_pol_zaaDataSet.Product);
            partnerProductBindingSource.DataSource = Program.context.PartnerProduct.
                Where(p=>p.PartnerId==_partner.IdPartner).OrderByDescending(p=>p.Date).ToList();
            UserExperienceManager.CustomizeControls(splitContainer.Panel1.Controls);
        }
    }
}

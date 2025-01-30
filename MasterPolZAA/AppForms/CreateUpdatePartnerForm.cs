using MasterPolZAA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterPolZAA.Exceptions;
using System.Text.RegularExpressions;
using System.Globalization;
using MasterPolZAA.Services.MasterPol.Services;

namespace MasterPolZAA.AppForms
{
    public partial class CreateUpdatePartnerForm : ParentForm
    {
        Partner _partner;
        public CreateUpdatePartnerForm()
        {
            InitializeComponent();
            _partner = new Partner();
            Program.context.Partner.Add(_partner);
            UserExperienceManager.SetTitle(this, "Новый партнер");
        }

        public CreateUpdatePartnerForm(Partner partner)
        {
            InitializeComponent();
            _partner = partner;
            UserExperienceManager.SetTitle(this, $"Изменить партнера: \"{_partner.PartnerName}\"");
        }


        private void CreateUpdatePartnerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "master_pol_zaaDataSet.PartnerType". При необходимости она может быть перемещена или удалена.
            this.partnerTypeTableAdapter.Fill(this.master_pol_zaaDataSet.PartnerType);
            if (!_partner.isNew())
            {
                partnerBindingSource.DataSource = _partner;
            }
            UserExperienceManager.CustomizeControls(splitContainer.Panel1.Controls);
            UserExperienceManager.CustomizeControls(splitContainer.Panel2.Controls);
        }

        private void FillModelFields()
        {
            _partner.PartnerName = partnerNameTextBox.Text.Trim();
            _partner.PartnerTypeId = (int)this.partnerTypeIdComboBox.SelectedValue;
            _partner.Rating = int.Parse(this.ratingTextBox.Text);
            _partner.Address = this.addressTextBox.Text.Trim();
            _partner.Ceo = this.ceoTextBox.Text.Trim();
            _partner.Phone = this.phoneMaskedTextBox.Text;
            this.ceoTextBox.Text.Trim();
            _partner.Email = this.emailTextBox.Text.Trim();
        }

        private void ValidateGeneral(string userInputText, string field, string messageAboutAllowedSymbols = "поле не должно быть пустым.", string pattern = @"^.+$")
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(userInputText.Trim());
            if (!isValid)
            {
                throw new ValidationException($"{field}: {messageAboutAllowedSymbols}");
            }
        }

        private void ValidatePartnerName()
        {
            ValidateGeneral(partnerNameTextBox.Text, "Наименование");
        }

        private void ValidateRaiting()
        {
            ValidateGeneral(ratingTextBox.Text, "Рейтинг", "Допустимо только целое неотрицательное число.", @"^\d+$");
        }

        private void ValidateAddress()
        {
            ValidateGeneral(addressTextBox.Text, "Адрес");
        }

        private void ValidateCeo() 
        {
            ValidateGeneral(ceoTextBox.Text, "Директор");
        }

        private void ValidatePhone()
        {
            var phone = phoneMaskedTextBox.Text.Replace(" ", "");

            if(phone.Length != 13)
            {
                throw new ValidationException($"Телефон введен не полностью");
            }
            ValidateGeneral(phoneMaskedTextBox.Text, "Телефон");
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void ValidateEmail()
        {
            if (!IsValidEmail(emailTextBox.Text.Trim()))
            {
                throw new ValidationException("Неверный формат электронной почты");
            }
        }

        private void Validate()
        {
            ValidatePartnerName();
            ValidateRaiting();
            ValidateAddress();
            ValidateCeo();
            ValidatePhone();
            ValidateEmail();
        }

        private void saveAttentionBackground_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();

            if (_partner.isNew())
            {
                Program.context.Partner.Add(_partner);
            }

            DialogResult toBeSaved = MessageBox.Show("Сохранить?", "Запрос подтверждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(toBeSaved == DialogResult.No)
            {
                return;
            }

            try
            {
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

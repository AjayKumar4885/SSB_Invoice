using DAL;
using System;
using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.PartyMaster
{
    public partial class PartyMasterForm : Form
    {
        public DAL_PartyMaster _objDal;

        public PartyMasterForm()
        {
            InitializeComponent();

            FillPartyMaster(new Models.PartyMasterRQ() { });
        }

        private void FillPartyMaster(Models.PartyMasterRQ _obj)
        {
            try
            {
                _objDal = new DAL_PartyMaster();
                var result = _objDal.GetPartyMaster(_obj);
                grdvwPartyMaster.DataSource = result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lblMobile_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPartyName.Text))
                {
                    var result = _objDal.CreatepartyMaster(new Models.PartyMaster()
                    {
                        Address = txtAddress.Text,
                        ContactPerson = txtContactPerson.Text,
                        Email = txtEmail.Text,
                        Fax = txtFax.Text,
                        Mobile = txtMobile.Text,
                        Pager = txtPager.Text,
                        PartyName = txtPartyName.Text,
                        IsActive = chckStatus.Checked,
                        Phone = txtPhone.Text
                    });

                    if (result != null && !string.IsNullOrWhiteSpace(result.MessageText))
                    {
                        lblStatus.Visible = true;
                        lblStatus.Text = result.MessageText;
                        if (result.Code == Models.MessageCode.Success)
                        {

                            FillPartyMaster(new Models.PartyMasterRQ() { });
                            txtBxSearhPartyName.Text = string.Empty;
                            ClearControl();
                        }
                    }
                    else
                    {
                        lblStatus.Visible = false;
                    }
                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "Please enter party name to create party!!";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ClearControl()
        {
            lblPartyId.Text = string.Empty;
            txtPartyCode.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtPager.Text = string.Empty;
            txtPartyName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            chckStatus.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPartyName.Text))
                {
                    var result = _objDal.UpdatePartyMaster(new Models.PartyMaster()
                    {
                        PartyId = Convert.ToInt32(lblPartyId.Text),
                        Address = txtAddress.Text,
                        ContactPerson = txtContactPerson.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        Fax = txtFax.Text,
                        Mobile = txtMobile.Text,
                        Pager = txtPager.Text,
                        PartyName = txtPartyName.Text,
                        IsActive = chckStatus.Checked
                    });

                    if (result != null && !string.IsNullOrWhiteSpace(result.MessageText))
                    {
                        lblStatus.Visible = true;
                        lblStatus.Text = result.MessageText;
                        if (result.Code == Models.MessageCode.Success)
                        {

                            FillPartyMaster(new Models.PartyMasterRQ() { });
                            txtBxSearhPartyName.Text = string.Empty;
                            ClearControl();
                        }
                    }
                    else
                    {
                        lblStatus.Visible = false;
                    }
                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "Please enter party name to create party!!";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void grdvwPartyMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PartyId = Convert.ToInt32(this.grdvwPartyMaster.CurrentRow.Cells[0].Value);
            FillPartyMasterForUpdate(PartyId);
        }

        private void FillPartyMasterForUpdate(int partyId)
        {
            try
            {
                _objDal = new DAL_PartyMaster();
                var result = _objDal.GetPartyMasterByID(new PartyMasterRQ() { PartyId = partyId });
                if (result != null && result.PartyName != null)
                {
                    lblPartyId.Text = result.PartyId.ToString();
                    btnUpdate.Enabled = true;
                    btnCreate.Enabled = false;
                    txtAddress.Text = result.Address;
                    txtContactPerson.Text = result.ContactPerson;
                    txtEmail.Text = result.Email;
                    txtFax.Text = result.Fax;
                    txtMobile.Text = result.Mobile;
                    txtPager.Text = result.Pager;
                    txtPartyName.Text = result.PartyName;
                    txtPhone.Text = result.Phone;
                    chckStatus.Checked = result.IsActive;
                    txtPartyCode.Text = result.PartyCode;

                }
                else
                {
                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControl();
            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBxSearhPartyName.Text))
            {
                FillPartyMaster(new Models.PartyMasterRQ() { PartyName = txtBxSearhPartyName.Text });
            }
            else
            {

            }
        }
    }
}

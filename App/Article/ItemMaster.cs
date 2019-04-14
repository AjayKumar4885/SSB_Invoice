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
using DAL;

namespace App.Article
{
    public partial class ItemMaster : Form
    {
        public DAL_Article _objDal;
        public ItemMaster()
        {
            InitializeComponent();

            FillArticle(new ArticleRQ() { });
        }

        private void FillArticle(ArticleRQ articleRQ)
        {
            try
            {
                _objDal = new DAL_Article();
                var result = _objDal.GetArticle(articleRQ);
                grdvwArticle.DataSource = result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lblWorkDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControl();
            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDesc.Text))
                {
                    var result = _objDal.UpdateArticleMaster(new Models.Article()
                    {
                        ArtId = Convert.ToInt32(lblID.Text),
                        ArtNo = txtArtNo.Text,
                        Desc = txtDesc.Text,
                        WorkOrderDesc = txtWorkOrderDesc.Text,
                        Rate = Convert.ToDouble(txtRate.Text),
                        Unit = txtUnit.Text,
                        IsActive = chckStatus.Checked
                    });

                    if (result != null && !string.IsNullOrWhiteSpace(result.MessageText))
                    {
                        lblStatus.Visible = true;
                        lblStatus.Text = result.MessageText;
                        if (result.Code == Models.MessageCode.Success)
                        {

                            FillArticle(new Models.ArticleRQ() { });
                            txtSearchArt.Text = string.Empty;
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
                    lblStatus.Text = "Please enter art desc to create article!!";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidArticle())
                {
                    if (!string.IsNullOrWhiteSpace(txtDesc.Text))
                    {
                        var result = _objDal.CreateArticleMaster(new Models.Article()
                        {
                            ArtNo = txtArtNo.Text,
                            Desc = txtDesc.Text,
                            Rate = Convert.ToDouble(txtRate.Text),
                            Unit = txtUnit.Text,
                            WorkOrderDesc = txtWorkOrderDesc.Text,
                            IsActive = chckStatus.Checked,
                        });

                        if (result != null && !string.IsNullOrWhiteSpace(result.MessageText))
                        {
                            lblStatus.Visible = true;
                            lblStatus.Text = result.MessageText;
                            if (result.Code == Models.MessageCode.Success)
                            {

                                FillArticle(new Models.ArticleRQ() { });
                                txtSearchArt.Text = string.Empty;
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
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool IsValidArticle()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(txtArtNo.Text)) { flag = false; }
            if (string.IsNullOrWhiteSpace(txtDesc.Text)) { flag = false; }
            if (string.IsNullOrWhiteSpace(txtRate.Text)) { flag = false; }
            return flag;
        }

        private void ClearControl()
        {
            txtArtNo.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtSearchArt.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtWorkOrderDesc.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchArt.Text))
            {
                FillArticle(new ArticleRQ() { Desc = txtSearchArt.Text.Trim() });
            }
        }
        private void grdvwArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PartyId = Convert.ToInt32(this.grdvwArticle.CurrentRow.Cells[0].Value);
            FillArticleMasterForUpdate(PartyId);
        }

        private void FillArticleMasterForUpdate(int artId)
        {
            try
            {
                _objDal = new DAL_Article();
                var result = _objDal.GetArticleByID(new ArticleRQ() { ArtId = artId });
                if (result != null && result.Desc != null)
                {
                    lblID.Text = result.ArtId.ToString();
                    btnUpdate.Enabled = true;
                    btnCreate.Enabled = false;
                    txtArtNo.Text = result.ArtNo;
                    txtDesc.Text = result.Desc;
                    txtWorkOrderDesc.Text = result.WorkOrderDesc;
                    txtUnit.Text = result.Unit;
                    txtRate.Text = Convert.ToString(result.Rate);
                    chckStatus.Checked = result.IsActive;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.Drawing;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventory : Smobiler.Core.Controls.MobileForm
    {
        #region  �������
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        #endregion
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventory_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// ���ݰ�
        /// </summary>
        public void Bind()
        {
            try
            {
                string LocationId = "";
                string UserId = Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOWMSAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.ConInventoryService.GetConInventoryList(Client.Session["Role"].ToString() == "SMOWMSUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                listView.Rows.Clear();
                if (assInventoryList.Rows.Count > 0)
                {
                    listView.DataSource = assInventoryList;
                    listView.DataBind();
                }
                foreach (var row in listView.Rows)
                {
                    frmConInventoryLayout layout = (frmConInventoryLayout)row.Control;
                    if (layout.lblStatus.Text == "�̵���")
                    {
                        layout.lblStatus.ForeColor = Color.FromArgb(77, 216, 101);
                        layout.ibEdit.Visible = false;
                    }
                    else if (layout.lblStatus.Text == "�̵����")
                    {
                        layout.lblStatus.ForeColor = Color.FromArgb(3, 58, 82);
                        layout.ibEdit.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// �رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plBack_Press(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// �Ĳ��̵㵥����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            try
            {
                frmConInventoryCreate conInventoryCreate = new frmConInventoryCreate();
                Show(conInventoryCreate, (MobileForm sender1, object args) =>
                {
                    if (conInventoryCreate.ShowResult == ShowResult.Yes)
                    {
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
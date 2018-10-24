using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConInventoryLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//����������
        /// <summary>
        /// �̵㵥���
        /// </summary>
        internal string IID
        {
            get
            {
                return this.lblName.BindDataValue.ToString();
            }
        }
        /// <summary>
        /// ���������ת�鿴����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            try
            {
                var inventory = autofacConfig.ConInventoryService.GetConInventoryById(lblName.BindDataValue.ToString());
                frmConInventoryResult result = new frmConInventoryResult();
                result.IID = lblName.BindDataValue.ToString();
                result.lblWareHouse.Tag = inventory.WAREID;
                Form.Show(result, (MobileForm sender1, object args) =>
                {
                    ((frmConInventory)Form).Bind();
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �̵㵥�༭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            frmConInventoryEdit edit = new frmConInventoryEdit { IID = lblName.BindDataValue.ToString() };
            Form.Show(edit, (MobileForm sender1, object args) =>
            {
                if (edit.ShowResult == ShowResult.Yes)
                {
                    ((frmConInventory)Form).Bind();
                }
            });
        }
    }
}
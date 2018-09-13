using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCIResultTotalLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region �������
        AutofacConfig autofacConfig = new AutofacConfig();
        #endregion
        /// <summary>
        /// ȡ���������رյ�ǰ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ȷ�����������������̵�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (lblName.Tag == null) throw new Exception("��ɨ���̵�Ĳ�");
                if (String.IsNullOrEmpty(txtRealAmount.Text)) throw new Exception("ʵ����������Ϊ��!");
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRealAmount.Text.Trim(), "^\\d+$") == false)
                {
                    throw new Exception("����������!");
                }
                this.Close();          //�رյ�ǰ������
                ((frmConInventoryResult)Form).AddConToDictionary(lblName.Tag.ToString(), Convert.ToDecimal(txtRealAmount.Text));
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// �Ĳ�ɨ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibCons_Press(object sender, EventArgs e)
        {
            bsCons.GetBarcode();
        }
        /// <summary>
        /// ɨ�赽�Ĳ�����ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsCons_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(e.error))
                {
                    String cId = e.Value;
                    Consumables con = autofacConfig.consumablesService.GetConsById(cId);
                    if (con == null) throw new Exception("�����ڴ˺Ĳ�");
                    String[] locData= ((frmConInventoryResult)Form).locData;

                     ConInventoryResult result = autofacConfig.ConInventoryService.GetResultBySL(
                        ((frmConInventoryResult)Form).IID, e.Value,
                        locData[0], locData[1], locData[2]);
                    if (result == null) throw new Exception("�����ڸ��̵�����");

                    lblName.Text = con.NAME;
                    lblName.Tag = con.CID;
                    lblNumber.Text = result.TOTAL.ToString();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
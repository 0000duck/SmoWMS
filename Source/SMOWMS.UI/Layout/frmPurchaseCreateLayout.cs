using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmPurchaseCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ����ɾ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_LongPress(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("�Ƿ�ɾ��������?", "ϵͳ����", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)     //ɾ��������
                        {
                            ((frmConPurchaseCreate)Form).ReMoveAss(lblName.BindDataValue.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// �ɹ�������ʱ��ȡ��������
        /// </summary>
        /// <returns></returns>
        public ConPurAndSaleCreateInputDto getData()
        {
            ConPurAndSaleCreateInputDto RowData = new ConPurAndSaleCreateInputDto();
            RowData.CID = lblName.BindDataValue.ToString();
            RowData.IMAGE = imgCon.BindDisplayValue.ToString();
            if (numQuant.Value == 0)
            {
                throw new Exception("�ɹ���������Ϊ0");
            }
            RowData.QUANTPURCHASED = Convert.ToDecimal(numQuant.Value);
            if (numPrice.Value == 0)
            {
                throw new Exception("�ɹ��۸���Ϊ0");
            }
            RowData.REALPRICE = Convert.ToDecimal(numPrice.Value);
            return RowData;
        }
    }
}
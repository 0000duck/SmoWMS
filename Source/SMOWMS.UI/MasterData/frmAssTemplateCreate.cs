using System;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplateCreate : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        public string UserId; //�û���
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        private AssetTypeTree tree = new AssetTypeTree();
        #endregion

        /// <summary>
        /// ����ʲ�ģ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnType.Tag==null)
                {
                    throw new Exception("��ѡ�����.");
                }
                decimal? price=null;

                if (!string.IsNullOrEmpty(txtPrice.Text))
                {
                    decimal p2;
                    if (!decimal.TryParse(txtPrice.Text, out p2))
                    {
                        throw new Exception("��������ȷ�ļ۸�.");
                    }
                    else
                    {
                        price = p2;
                    }
                }
                
                AssTemplateInputDto assTemplateInputDto = new AssTemplateInputDto
                {
                    IMAGE = ImgPicture.ResourceID,
                    NAME = txtName.Text,
                    NOTE = txtNote.Text,
                    PRICE = price,
                    SPECIFICATION = txtSpe.Text,
                    TYPEID = btnType.Tag.ToString(),
                    UNIT = txtUnit.Text,
                    VENDOR = txtVendor.Text
                };
                ReturnInfo returnInfo = _autofacConfig.SettingService.AddAssTemplate(assTemplateInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Close();
                    Toast("��ӳɹ�.�ʲ�ģ����Ϊ" + returnInfo.ErrorInfo);
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            ShowDialog(tree, GetType);
        }

        /// <summary>
        /// �ϴ�ͼƬ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelImg_Press(object sender, EventArgs e)
        {
            CamPicture.GetPhoto();
        }

        /// <summary>
        /// ͼƬ��ȡ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CamPicture_ImageCaptured(object sender, BinaryResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    e.SaveFile(UserId + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                    ImgPicture.ResourceID = UserId + DateTime.Now.ToString("yyyyMMddHHmmss");
                    ImgPicture.Refresh();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ����ѡ�к�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopType_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopType.Selection == null) return;
                btnType.Text = PopType.Selection.Text;
                btnType.Tag = PopType.Selection.Value;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ������ʱ���رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// �����ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssTemplateCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (btnType.Tag != null)
                {
                    var type = _autofacConfig.assTypeService.GetByID(btnType.Tag.ToString());
                    btnType.Text = type.NAME;
                }
                UserId = Client.Session["UserID"].ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        public void GetType(object sender, EventArgs e)
        {
            btnType.Tag = tree.ID;
            btnType.Text = tree.TypeName;
        }
    }
}
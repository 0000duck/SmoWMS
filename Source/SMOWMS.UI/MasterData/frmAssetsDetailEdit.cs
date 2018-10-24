using System;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.MasterData
{
    /// <summary>
    /// �ʲ��޸�
    /// </summary>
    partial class frmAssetsDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        public string UserId;  //�û����
        public string TypeId; //���ͱ��
        public string SLID;  //��λ���
        public string ManagerId;  //����Ա���
        public string CurrentUserId;  //��ǰ�û����

        AutofacConfig _autofacConfig = new AutofacConfig();//����������

        public string DepId; //���ű��
        public string AssId;  //�ʲ����
        public string STID;
        public string WAREID;

        #endregion

        /// <summary>
        /// �۸�ı�ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal price;
                if (decimal.TryParse(txtPrice1.Text, out price) == false)
                {
                    throw new Exception("��������ȷ�Ľ�");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


//        /// <summary>
//        /// �ʲ�����ѡ��ʱ
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btnType_Press(object sender, EventArgs e)
//        {
//            try
//            {
//                PopType.Groups.Clear();
//                PopListGroup typeGroup = new PopListGroup();
//                typeGroup.Title = "�ʲ�����";
//                var typelist = _autofacConfig.assTypeService.GetAll();
//                foreach (var type in typelist)
//                {
//                    PopListItem item = new PopListItem
//                    {
//                        Value = type.TYPEID,
//                        Text = type.NAME
//                    };
//                    typeGroup.Items.Add(item);
//                }
//                PopType.Groups.Add(typeGroup);
//                if (!string.IsNullOrEmpty(btnType.Text))
//                {
//                    foreach (PopListItem row in PopType.Groups[0].Items)
//                    {
//                        if (row.Text == btnType.Text)
//                        {
//                            PopType.SetSelections(row);
//                        }
//                    }
//                }
//                PopType.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }

        /// <summary>
        /// ����ϴ�ͼƬʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelImg_Press(object sender, EventArgs e)
        {
            CamPicture.GetPhoto();
        }

        
//        /// <summary>
//        /// �ʲ�����ѡ�к�
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void PopType_Selected(object sender, EventArgs e)
//        {
//            try
//            {
//                if (PopType.Selection == null) return;
//                btnType.Text = PopType.Selection.Text;
//                TypeId = PopType.Selection.Value;                
//            }
//            catch (Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }

        /// <summary>
        /// ��ȡ��ͼƬ���ݺ�
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
                    image2.ResourceID = UserId + DateTime.Now.ToString("yyyyMMddHHmmss");
                    image2.Refresh();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        private void Bind()
        {

            try
            {
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsByID(AssId);
                if (outputDto != null)
                {
                    txtAssID.Text = outputDto.AssId;
                    image2.ResourceID = outputDto.Image;
                    txtNote1.Text = outputDto.Note;
                    DatePickerExpiry.Value = outputDto.ExpiryDate;
                    txtName1.Text = outputDto.Name;
                    txtPrice1.Text = outputDto.Price.ToString();
                    txtSPE1.Text = outputDto.Specification;
                    txtNote1.Text = outputDto.Note;
                    txtPlace1.Text = outputDto.Place;
                    txtSN.Text = outputDto.SN;
                    txtUnit1.Text = outputDto.Unit;
                    txtVendor1.Text = outputDto.Vendor;
                    txtATID.Text = outputDto.ATID;
                    txtType.Text = outputDto.TypeName;
                    TypeId = outputDto.TypeId;
                    txtSL.Text = outputDto.SLName;
                    SLID = outputDto.SLID;
                    STID = outputDto.STID;
                    WAREID = outputDto.WAREID;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �����˼�ʱ���رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetailEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();

            }
            
        }

        /// <summary>
        /// �����ʼ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetailEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                UserId = Session["UserID"].ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֻ�ɨ��ά�����SN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ImgBtnForAssId_Press(object sender, EventArgs e)
        {
            try
            {
                barcodeScanner1.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֳ�������ɨ���ά�룬ɨ�赽��ά������ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                txtSN.Text = barCode;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֳ�������ɨ��RFID��ɨ�赽RFIDʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            try
            {
                string RFID = e.Epc;
                txtSN.Text = RFID;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֻ�ɨ�赽��ά��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                txtSN.Text = barCode;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �޸��ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                AssetsInputDto assetsInputDto = new AssetsInputDto
                {
                    ASSID = txtAssID.Text,
                    BUYDATE = DatePickerBuy.Value,
                    CREATEUSER = UserId,
                    IMAGE = image2.ResourceID,
                    SLID = SLID,
                    STID = STID,
                    WAREID = WAREID,
                    MODIFYUSER = UserId,
                    NAME = txtName1.Text,
                    NOTE = txtNote1.Text,
                    PLACE = txtPlace1.Text,
                    SPECIFICATION = txtSPE1.Text,
                    TYPEID = TypeId,
                    UNIT = txtUnit1.Text,
                    VENDOR = txtVendor1.Text,
                    EXPIRYDATE = DatePickerExpiry.Value,
                    SN = txtSN.Text
                };
                if (String.IsNullOrEmpty(txtPrice1.Text) == false)
                {
                    assetsInputDto.PRICE = decimal.Parse(txtPrice1.Text);
                }
                ReturnInfo returnInfo = _autofacConfig.SettingService.UpdateAssets(assetsInputDto);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Close();
                    Toast("�޸ĳɹ�.");
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
    }
}
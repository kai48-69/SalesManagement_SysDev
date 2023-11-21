﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_顧客管理 : Form
    {
        readonly ClientDataAccess ClientDataAccess = new ClientDataAccess();
        private readonly InputCheck ichk = new InputCheck();
        readonly ClientDbConnection DB = new ClientDbConnection();
        private static List<M_SalesOffice> SoNameDsp;

        public F_顧客管理()
        {
            InitializeComponent();
        }

        //画面ロード時処理
        private void F_顧客管理_Load(object sender, EventArgs e)
        {
            SetFormComboBox();

            TextboxKokyakuID.ReadOnly = true;
            TextboxHihyouji.Enabled = false;

            if (!GetDataGridView())
            {
                MessageBox.Show("顧客情報を取得することができません。", "顧客確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //データ全件表示
        private bool GetDataGridView()
        {
            //在庫情報の全件取得
            List<DispClientListDTO> tb = DB.ClientGetData("", "");
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //コンボボックスの設定
        private void SetFormComboBox()
        {
            SoNameDsp = DB.GetSoNameDspData();
            ComboEigyousyoName.Items.AddRange(SoNameDsp.ToArray());
            ComboEigyousyoName.DisplayMember = "SoName";
            ComboEigyousyoName.ValueMember = "SoID";
            ComboEigyousyoName.DataSource = SoNameDsp;

            //初期値を０に
            ComboEigyousyoName.SelectedIndex = 0;


            //読み込み専用に
            ComboEigyousyoName.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispClientListDTO> tb)
        {
            dataGridView1.DataSource = tb;
            //列幅自動設定解除
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //ヘッダーの高さ
            dataGridView1.ColumnHeadersHeight = 50;
            //ヘッダーの折り返し表示
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //行単位選択     
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ヘッダー文字位置、セル文字位置、列幅の設定
            ////顧客ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 40;
            ////営業所名
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].Width = 100;
            //顧客名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].Width = 80;
            //住所
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].Width = 200;
            ////電話番号
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].Width = 90;
            ////郵便番号
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].Width = 55;
            ////FAX
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 80;
            ////非表示理由
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].Width = 265;

            dataGridView1.Refresh();
        }

        //データグリッドビューをクリックしたときの処理
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RadioTouroku.Checked == true)
            {
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TextboxKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TextboxAdress.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                TextboxTelNo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                TextboxPostCD.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                TextboxFAX.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            }
            else
            {
                TextboxKokyakuID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                ComboEigyousyoName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TextboxKokyakuName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                TextboxAdress.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                TextboxTelNo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                TextboxPostCD.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                TextboxFAX.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            }

        }

        //実行ボタン
        private void ButtonExe_Click(object sender, EventArgs e)
        {
            //登録処理----------------------------------------------------------------------
            if (RadioTouroku.Checked == true)
            {
                if (!GetVaildDataAtRegistration())
                {
                    return;
                }
                var regCl = GenerateDataAtRegistration();

                RegistrationClient(regCl);
            }

            //検索処理----------------------------------------------------------------------
            if (RadioKensaku.Checked == true)
            {
                {
                    if (!GetVaildDataAtSelect())
                    {
                        return;
                    }
                    GenerateDataAtSelect();
                }
            }

            //更新処理----------------------------------------------------------------------
            if (RadioKousin.Checked == true)
            {
                if (!GetVaildDataAtUpdate())
                {
                    return;
                }

                var updProduct = GenereteDataAtUpdate();

                UpdateClient(updProduct);

                //非表示処理----------------------------------------------------------------------
                if (RadioHihyouji.Checked == true)
                {
                    if (!GetVaildDataAtHide())
                    {
                        return;
                    }

                    var hidClient = GenereteDataAtHidden();

                    HideClient(hidClient);
                }
            }

            //非表示処理--------------------------------------------------------------------
            if (RadioHihyouji.Checked == true)
            {
                if (!GetVaildDataAtHide())
                {
                    return;
                }

                var hidProduct = GenereteDataAtHidden();

                HideClient(hidProduct);
            }
        }

        //登録処理--------------------------------------------------------------------------
        private bool GetVaildDataAtRegistration() //入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxKokyakuName.Text.Trim()))
            {
                MessageBox.Show("顧客名が入力されていません");
                TextboxKokyakuName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxTelNo.Text.Trim()))
            {
                MessageBox.Show("電話番号が入力されていません");
                TextboxTelNo.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(TextboxFAX.Text.Trim()))
            {
                MessageBox.Show("FAXが入力されていません");
                TextboxFAX.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxPostCD.Text.Trim()))
            {
                MessageBox.Show("郵便番号が入力されていません");
                TextboxPostCD.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(TextboxAdress.Text.Trim()))
            {
                MessageBox.Show("住所が入力されていません");
            }

            return true;
        }

        private M_Client GenerateDataAtRegistration() //登録データ生成
        {
            int SoID = ComboEigyousyoName.SelectedIndex;
            return new M_Client
            {
                SoID = SoID,
                ClName = TextboxKokyakuName.Text.Trim(),
                ClAddress = TextboxAdress.Text.Trim(),
                ClPhone = TextboxTelNo.Text.Trim(),
                ClPostal = TextboxPostCD.Text.Trim(),
                ClFAX = TextboxFAX.Text.Trim(),
                ClHidden = null,
            };
        }

        private void RegistrationClient(M_Client regCl) //データ登録処理
        {
            DialogResult result = MessageBox.Show("顧客データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = ClientDataAccess.AddClientData(regCl);
            if (flg == true)
            {
                MessageBox.Show("データを登録しました");
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxKokyakuID.Focus();
            }
            ClearInput();
            GetDataGridView();
        }

        //検索処理------------------------------------------------------------------------
        private bool GetVaildDataAtSelect() //入力データチェック
        {
            if (!String.IsNullOrEmpty(TextboxKokyakuID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxKokyakuID.Text.Trim()))
                {
                    MessageBox.Show("顧客IDはすべて半角数字で入力してください。");
                    TextboxKokyakuID.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool GenerateDataAtSelect() //検索データ生成
        {
            int SoID;
            if (ComboEigyousyoName.SelectedIndex == -1)
            {
                SoID = -1;
            }
            else
            {
                SoID = int.Parse(ComboEigyousyoName.SelectedValue.ToString());
            }

            //整数型(int)に変換する準備
            //顧客ID
            var ClID = TextboxKokyakuID.Text.Trim();



            //変換処理
            if (!int.TryParse(ClID, out int KokyakuID))
            {
                KokyakuID = -1;
            }

            M_Client selectCondition = new M_Client()
            {
                ClID = KokyakuID,
                SoID = SoID,
                ClAddress = TextboxAdress.Text.Trim(),

            };

            List<DispClientListDTO> tb = DB.GetClientData(selectCondition);
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //更新処理-----------------------------------------------------------------------
        private bool GetVaildDataAtUpdate()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxKokyakuID.Text.Trim()))
            {
                MessageBox.Show("更新する顧客データを選択してください");
            }

            if (String.IsNullOrEmpty(TextboxKokyakuName.Text.Trim()))
            {
                MessageBox.Show("顧客名が入力されていません");
                TextboxKokyakuName.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxTelNo.Text.Trim()))
            {
                MessageBox.Show("電話番号が入力されていません");
                TextboxTelNo.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(TextboxFAX.Text.Trim()))
            {
                MessageBox.Show("FAXが入力されていません");
                TextboxFAX.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(TextboxPostCD.Text.Trim()))
            {
                MessageBox.Show("郵便番号が入力されていません");
                TextboxPostCD.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(TextboxAdress.Text.Trim()))
            {
                MessageBox.Show("住所が入力されていません");
            }
            return true;
        }

        private M_Client GenereteDataAtUpdate() //更新データ生成
        {
            string SoID = ComboEigyousyoName.SelectedIndex.ToString();
            return new M_Client
            {
                SoID = int.Parse(SoID),
                ClID = int.Parse(TextboxKokyakuID.Text.Trim()),
                ClName = TextboxKokyakuName.Text.Trim(),
                ClPhone = TextboxTelNo.Text.Trim(),
                ClFAX = TextboxFAX.Text.Trim(),
                ClPostal = TextboxPostCD.Text.Trim(),
                ClAddress = TextboxAdress.Text.Trim(),
                ClHidden = null,
            };
        }

        private void UpdateClient(M_Client updCl) //データ更新処理
        {
            DialogResult result = MessageBox.Show("顧客データを更新します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = ClientDataAccess.UpdateClientData(updCl);
            if (flg == true)
            {
                MessageBox.Show("データを更新しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの更新に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxKokyakuName.Focus();
            }
            ClearInput();

            GetDataGridView();
        }

        //非表示処理---------------------------------------------------------------------

        private bool GetVaildDataAtHide()//入力データチェック
        {
            if (String.IsNullOrEmpty(TextboxKokyakuID.Text.Trim()))
            {
                MessageBox.Show("非表示にする顧客データを選択してください");
            }

            if (ClientDataAccess.CheckCascadeClient(int.Parse(TextboxKokyakuID.Text.Trim())))
            {
                MessageBox.Show("入力された顧客IDは他で使用されているため非表示にできません。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(TextboxHihyouji.Text.Trim()))
            {
                MessageBox.Show("非表示理由を記入してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private M_Client GenereteDataAtHidden() //非表示データ生成(フラグの更新データ生成)
        {
            string SoID = ComboEigyousyoName.SelectedIndex.ToString();
            return new M_Client
            {
                SoID = int.Parse(SoID),
                ClID = int.Parse(TextboxKokyakuID.Text.Trim()),
                ClName = TextboxKokyakuName.Text.Trim(),
                ClPhone = TextboxTelNo.Text.Trim(),
                ClFAX = TextboxFAX.Text.Trim(),
                ClPostal = TextboxPostCD.Text.Trim(),
                ClAddress = TextboxAdress.Text.Trim(),
                ClFlag = 2,
                ClHidden = null,
            };
        }

        private void HideClient(M_Client hidCl) //データ非表示処理
        {
            DialogResult result = MessageBox.Show("顧客データを非表示にします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = ClientDataAccess.HideClientData(hidCl);
            if (flg == true)
            {
                MessageBox.Show("データを非表示にしました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("データの非表示に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearInput();
            GetDataGridView();
        }

        //入力クリア----------------------------------------------------------------------
        private void ClearInput()
        {

            if (RadioKensaku.Checked == true)//検索時はコンボボックスの値を空にする
            {
                ComboEigyousyoName.SelectedIndex = -1;
                TextboxKokyakuID.Text = "";
                TextboxKokyakuName.Text = "";
                TextboxTelNo.Text = "";
                TextboxFAX.Text = "";
                TextboxPostCD.Text = "";
                TextboxAdress.Text = "";
                TextboxHihyouji.Text = "";
            }
            else   //検索時以外は表示する
            {
                ComboEigyousyoName.SelectedIndex = 0;
                TextboxKokyakuID.Text = "";
                TextboxKokyakuName.Text = "";
                TextboxTelNo.Text = "";
                TextboxFAX.Text = "";
                TextboxPostCD.Text = "";
                TextboxAdress.Text = "";
                TextboxHihyouji.Text = ""; ;
            }
        }

        //戻るボタン
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        //入力リセットボタン
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }


        //登録時の入力項目選択-----------------------------------------------------------
        private void RadioTouroku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxKokyakuID.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = 0;
            TextboxKokyakuName.ReadOnly = false;
            TextboxAdress.ReadOnly = false;
            TextboxPostCD.ReadOnly = false;
            TextboxTelNo.ReadOnly = false;
            TextboxFAX.ReadOnly = false;
            TextboxHihyouji.Enabled = false; ;

            GetDataGridView();
        }

        //検索時の入力項目選択-----------------------------------------------------------
        private void RadioKensaku_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxKokyakuID.ReadOnly = false;
            ComboEigyousyoName.SelectedIndex = -1;
            TextboxKokyakuName.ReadOnly = true;
            TextboxAdress.ReadOnly = false;
            TextboxPostCD.ReadOnly = false;
            TextboxTelNo.ReadOnly = false;
            TextboxFAX.ReadOnly = false;
            TextboxHihyouji.Enabled = false; ;
            GetDataGridView();
        }

        //更新時の入力項目選択-----------------------------------------------------------
        private void RadioKousin_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxKokyakuID.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = 0;
            TextboxKokyakuName.ReadOnly = false;
            TextboxAdress.ReadOnly = false;
            TextboxPostCD.ReadOnly = false;
            TextboxTelNo.ReadOnly = false;
            TextboxFAX.ReadOnly = false;
            TextboxHihyouji.Enabled = false; ;
            GetDataGridView();
        }

        //非表示時の入力項目選択-----------------------------------------------------------
        private void RadioHihyouji_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
            TextboxKokyakuID.ReadOnly = true;
            ComboEigyousyoName.SelectedIndex = 0;
            TextboxKokyakuName.ReadOnly = true;
            TextboxAdress.ReadOnly = true;
            TextboxPostCD.ReadOnly = true;
            TextboxTelNo.ReadOnly = true;
            TextboxFAX.ReadOnly = true;
            TextboxHihyouji.Enabled = true;
            GetDataGridView();
        }
    }
}




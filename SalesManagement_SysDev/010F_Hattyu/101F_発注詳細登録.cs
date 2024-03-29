﻿using SalesManagement_SysDev.Order;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class _101F_発注詳細登録 : Form
    {
        readonly LoginData LoginData;
        readonly InputCheck ichk = new InputCheck();
        readonly HattyuDataAccess HDA=new HattyuDataAccess();
        readonly ProductDbConnection DB = new ProductDbConnection();
        readonly HattyuDbConnection DB1 = new HattyuDbConnection();
        public _101F_発注詳細登録(LoginData LData)
        {
            InitializeComponent();
            LoginData = LData;
        }

        private bool GetDataGridView()
        {
            //商品情報の全件取得
            List<DispHattyuDetailListDTO> tb = DB1.HattyuDetailGetData(DB1.GetHaID());
            if (tb == null)
                return false;
            //データグリッドビューへの設定
            SetDataGridView(tb);
            return true;
        }

        //データグリッドビューの表示設定
        private void SetDataGridView(List<DispHattyuDetailListDTO> tb)
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
            ////商品ID
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 80;
            ////メーカー名
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 100;
            //商品名
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 242;
            //価格
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].Visible = false;


            dataGridView1.Refresh();
        }

        private void ButtonTouroku_Click(object sender, EventArgs e)
        {
            int opt = GetVaildData();
            if(opt==-1)
            {
                return;
            }
            if (opt == 1)
            {
                var regHaD = GenerateDataAtRegistration();

                RegistrationHattyuDetail(regHaD);
            }
            if (opt == 2)
            {
                var updHaD = GenerateDataAtUpdate();

                UpdateOrderDetail(updHaD);
            }
        }

        //登録処理----------------------------------------------------------------------------------
        private int GetVaildData() //入力データチェック
        {

            if (!String.IsNullOrEmpty(TextboxSyohinID.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSyohinID.Text.Trim()))
                {
                    MessageBox.Show("商品IDは半角数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                if (HDA.CheckProductID(int.Parse(TextboxSyohinID.Text.Trim())))
                {
                    return 2;
                }
            }
            else
            {
                MessageBox.Show("商品IDを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (String.IsNullOrEmpty(TextboxSyohinName.Text))
            {
                MessageBox.Show("正しい商品IDを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (!String.IsNullOrEmpty(TextboxSuryou.Text.Trim()))
            {
                if (!ichk.IntegerCheck(TextboxSuryou.Text.Trim()))
                {
                    MessageBox.Show("数量は半角数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                if (int.Parse(TextboxSuryou.Text) <= 0)
                {
                    MessageBox.Show("数量は０以上の値を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("数量が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return 1;
        }

        private T_HattyuDetail GenerateDataAtRegistration() //登録データ生成
        {
            int Quantity = int.Parse(TextboxSuryou.Text);
            int PrID = int.Parse(TextboxSyohinID.Text);
            decimal Price = DB.GetPrice(PrID);
            return new T_HattyuDetail
            {
                HaID = DB1.GetHaID(),
                PrID = PrID,
                HaQuantity = Quantity,
            };
        }

        private void RegistrationHattyuDetail(T_HattyuDetail regHaD) //データ登録処理
        {
            DialogResult result = MessageBox.Show("発注商品データを登録します。よろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            bool flg = HDA.AddHattyuDetailData(regHaD);
            if (flg == true)
            {
                GetDataGridView();
                ButtonBack.Visible = true;
                DialogResult result1 = MessageBox.Show("データを登録しました\n続けて登録しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result1 == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    this.Close();
                    F_発注管理 f_hattyu = new F_発注管理(LoginData);
                    f_hattyu.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("データの登録に失敗しました");
                TextboxSyohinName.Focus();
                return;
            }

        }

        //更新処理----------------------------------------------------------------------------------
        private T_HattyuDetail GenerateDataAtUpdate() //更新データ生成
        {
            int Quantity = int.Parse(TextboxSuryou.Text) + DB1.GetQuantity(int.Parse(TextboxSyohinID.Text));
            int PrID = int.Parse(TextboxSyohinID.Text);
            decimal Price = DB.GetPrice(PrID);
            return new T_HattyuDetail
            {
                HaID = DB1.GetHaID(),
                PrID = PrID,
                HaQuantity = Quantity,
            };
        }
        private void UpdateOrderDetail(T_HattyuDetail updHaD)　//データ更新処理
        {
            DialogResult result = MessageBox.Show("この商品は既に登録済みです。数量を追加しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            bool flg = HDA.UpdateHattyuDetailData(updHaD);
            if (flg == true)
            {
                MessageBox.Show("数量を更新しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("数量の更新に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextboxSyohinName.Focus();
            }

            GetDataGridView();
        }

        private void TextboxSyohinID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextboxSyohinID.Text.Trim(), out int PrID))
            {
                if (DB.CheckCascadeProduct(PrID) != -1)
                {
                    int HaID = DB1.GetHaID();
                    TextboxSyohinName.Text = DB.GetPrName(PrID,HaID);
                }
                else
                {
                    TextboxSyohinName.Text = "";
                }
            }
            if (String.IsNullOrEmpty(TextboxSyohinID.Text))
            {
                TextboxSyohinName.Text = "";
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_発注管理 f_hattyu = new F_発注管理(LoginData);
            f_hattyu.Show();
        }
    }
}

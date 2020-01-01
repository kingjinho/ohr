using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetMeTheAddress
{
    public partial class OHR100CS : Form
    {
        static readonly HttpClient client = new HttpClient();
        List<Shop> shopList = new List<Shop>();
        public Shop selectedShop;

        public OHR100CS()
        {
            InitializeComponent();
            client.BaseAddress = new Uri($"https://openapi.naver.com/v1/search/local.json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Naver-Client-Id", "fLDnB9DzbE04YzzqF_9U");
            client.DefaultRequestHeaders.Add("X-Naver-Client-Secret", "v9KlD_LUAP");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onButtonGetAddressClickListener(object sender, EventArgs e)
        {
            if(!isShopNameEmpty())
                getAddress();

        }

        private void onAddressClickListener(object sender, MouseEventArgs e)
        {
            onButtonGetAddressClickListener(sender, e);
        }


        private void onKeypressListener(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (!isShopNameEmpty())
                    getAddress();
            }
        }

        private async void getAddress()
        {
            shopList.Clear();

            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync($"?query={mTbShopName.Text}&display=30");
                httpResponse.EnsureSuccessStatusCode();
                string response = await httpResponse.Content.ReadAsStringAsync();
                JObject jo = JObject.Parse(response);
                foreach(var item in jo["items"])
                {
                    Shop shop = new Shop
                    {
                        title = JsonConvert.SerializeObject(item["title"]).Replace("\"", "").Replace("<b>", "").Replace("</b>", ""),
                        roadAddress = JsonConvert.SerializeObject(item["roadAddress"]).Replace("\"", ""),
                        telephone = JsonConvert.SerializeObject(item["telephone"]).Replace("\"", "")
                    };
                    shopList.Add(shop);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            if(shopList.Count != 0)
            {
                ShopList listDialog = new ShopList(shopList);
                listDialog.Owner = this;
                listDialog.ShowDialog();
                mTbShopName.Text = selectedShop?.title;
                mTbShopAddress.Text = selectedShop?.roadAddress;
                mTbPhone1.Text = selectedShop?.telephone;
            }
            else
            {
                MessageBox.Show("조회결과가 없습니다");
            }
        }

        private Boolean isShopNameEmpty()
        {
            if (string.IsNullOrWhiteSpace(mTbShopName.Text))
            {
                MessageBox.Show("매장명을 입력하셔야지여...바보바보~", "저런...");
                mTbShopName.Focus();
                return true;
            }
            return false;
        }

        private void mBtnClear_Click(object sender, EventArgs e)
        {
            mTbCause1.Text = String.Empty;
            mTbCause2.Text = String.Empty;
            mTbCause3.Text = String.Empty;
            mTbCause4.Text = String.Empty;
            mTbShopName.Text = String.Empty;
            mTbShopAddress.Text = String.Empty;
            mTbPhone1.Text = String.Empty;
            mTbPhone2.Text = String.Empty;
        }

        private void mBtnCopy_Click(object sender, EventArgs e)
        {
            string formattedPhone = String.Empty;
            if(mTbPhone2.TextLength == 11)
                formattedPhone = string.Format("{0}-{1}-{2}", mTbPhone2.Text.Substring(0,3), mTbPhone2.Text.Substring(3,4), mTbPhone2.Text.Substring(7));
            else if(mTbPhone2.TextLength == 10)
                formattedPhone = string.Format("{0}-{1}-{2}", mTbPhone2.Text.Substring(0, 3), mTbPhone2.Text.Substring(3, 3), mTbPhone2.Text.Substring(6));
            Clipboard.SetText($"{mLabelReceptionist.Text}: {mCbReceptionist.SelectedItem}\n"
                            + $"{mLabelShopName.Text}: {mTbShopName.Text}\n"
                            + $"{mLabelShopAddress.Text}: {mTbShopAddress.Text}\n"
                            + $"{mLabelPhoneNumber.Text}: {mTbPhone1.Text} / {formattedPhone}\n"
                            + $"{mLabelModel.Text}: {(mRb100H.Checked ? mRb100H.Text : mRb100S.Text)}\n"
                            + $"{mLabelCause.Text} : {mTbCause1.Text}{(mTbCause2.Text != String.Empty? mTbCause2.Text + "/" : "")}{(mTbCause3.Text != String.Empty ? mTbCause3.Text + "/" : "")}"
                            + $"{(mTbCause4.Text != String.Empty ? mTbCause4.Text + "/" : "")}");
        }
    }
}
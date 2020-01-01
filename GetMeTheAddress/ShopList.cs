using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMeTheAddress
{
    public partial class ShopList : Form
    {
        List<Shop> shopList;
        public ShopList()
        {
            InitializeComponent();
        }

        public ShopList(List<Shop> shopList)
        {
            InitializeComponent();
            this.shopList = shopList;
            setShopList(shopList);
        }

        private void setShopList(List<Shop> shopList)
        {
            foreach(var shop in shopList)
                mCbShopList.Items.Add($"{shop.title} / {shop.roadAddress} / {shop.telephone}");
            mCbShopList.SelectedIndex = 0;
        }

        private void onButtonClickListener(object sender, MouseEventArgs e)
        {
            try
            {
                OHR100CS parent = Owner as OHR100CS;
                parent.selectedShop = shopList[mCbShopList.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

using ASM_2;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using static asm_2.CalculateForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace asm_2
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
            if (customer != null)
            {
                LoadDataIntoListView();
            }
                
        }
        // one class is the customer
        public class Customer
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public int Kind { get; set; }
            public int Members { get; set; }
            public double WaterLastMonth { get; set; }
            public double WaterThisMonth { get; set; }
            public double Amount { get; set; }
            public double Price { get; set; }
            public double Total { get; set; }
            public Customer()
            {
            }
            public Customer(string id, string name, string phoneNumber, 
                int type, int member, double waterlastmonth, double waterthismonth, double amount,
                double price, double total)
            {
                ID = id;
                Name = name;
                Phone = phoneNumber;
                Kind = type;
                Members = member;
                WaterLastMonth = waterlastmonth;
                WaterThisMonth = waterthismonth;
                Amount = amount;
                Price = price;
                Total = total;
            }

        }
        public static string id = null;
        public static string name = null;
        public static string phone = null;
        public static int type = -1;
        public static double WaterLastMonth = 0;
        public static double WaterThisMonth = 0;
        public static int numbermember = 0;
        public static double amount = 0;
        public static double Price = 0;
        public static double Total = 0;
        private List<Customer> customer;

        // button add
        private void button1_Click(object sender, EventArgs e)
        {
            customer = new List<Customer>();
            ListViewItem item = new ListViewItem();
            id = tbId.Text;
            name = tbName.Text;
            phone = tbPhone.Text;
            type = cbType.SelectedIndex;
            if (int.TryParse(tbnum.Text, out int member))
            {
                numbermember = member;
            }

            if (!double.TryParse(tblastmonth.Text, out double waterlastmonth) )
            {
                MessageBox.Show("Please enter correct information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!double.TryParse(tbthismonth.Text, out double waterthismonth) )
            {
                MessageBox.Show("Please enter correct information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WaterLastMonth = waterlastmonth;
                WaterThisMonth = waterthismonth;
            }
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(cbType.Text))
            {
                MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(tbnum.Text) && cbType.SelectedIndex == 0  )
            {
                MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( cbType.SelectedIndex == 0 && numbermember == 0)
            {
                MessageBox.Show("Please enter correct information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else if (string.IsNullOrEmpty(tblastmonth.Text) || WaterLastMonth < 0)
            {
                MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(tbthismonth.Text)|| WaterThisMonth < WaterLastMonth || WaterThisMonth < 0)
            {
                MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                item.Text = id;
                item.SubItems.Add(name);
                item.SubItems.Add(phone);
                if (type == 0)
                {
                    tbnum.ReadOnly = true;
                    item.SubItems.Add("Household");

                }
                else if (type == 1)
                {
                    item.SubItems.Add("Administrative agency, public services");
                    tbnum.ReadOnly = false;
                    numbermember = 0;
                }
                else if (type == 2)
                {
                    item.SubItems.Add("Production units");
                    tbnum.ReadOnly = false;
                    numbermember = 0;
                }
                else if (type == 3)
                {
                    item.SubItems.Add("Business services");
                    tbnum.ReadOnly = false;
                    numbermember = 0;
                }
                else
                {
                    tbnum.ReadOnly = false;
                    item.SubItems.Add("");
                    numbermember = 0;
                }
                amount = WaterThisMonth - WaterLastMonth;
                Price = CalculateWaterBill(type, amount, numbermember);
                Total = Price * 1.21;
                item.SubItems.Add(member.ToString());
                item.SubItems.Add(WaterLastMonth.ToString());
                item.SubItems.Add(WaterThisMonth.ToString());
                item.SubItems.Add(amount.ToString());
                item.SubItems.Add(Total.ToString("F2"));
                //đẩy item vào lsvStudent
                customer.Add(new Customer(id, name, phone, type,
                    numbermember, WaterLastMonth, WaterThisMonth, amount, Price, Total));
                lvWaterBill.Items.Add(item);
                tbId.Text = null;
                tbName.Text = null;
                tbPhone.Text = null;
                cbType.SelectedIndex = -1;
                tbnum.Text = null;
                tblastmonth.Text = null;
                tbthismonth.Text = null;
                tbamout.Text = null;
                tbtotal.Text = null;
                tbdes.Text = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lvWaterBill.SelectedItems[0];
                item.SubItems.Clear();

                customer = new List<Customer>();
                //string ID = customer.ID;
                id = tbId.Text;
                name = tbName.Text;
                phone = tbPhone.Text;
                //des = tbdes.Text;
                type = cbType.SelectedIndex;
                if (int.TryParse(tbnum.Text, out int member))
                {
                    numbermember = member;
                }

                if (!double.TryParse(tblastmonth.Text, out double waterlastmonth))
                {
                    MessageBox.Show("Please enter correct information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!double.TryParse(tbthismonth.Text, out double waterthismonth))
                {
                    MessageBox.Show("Please enter correct information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    WaterLastMonth = waterlastmonth;
                    WaterThisMonth = waterthismonth;
                }
                if (string.IsNullOrEmpty(tbId.Text))
                {
                    MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(tbName.Text))
                {
                    MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(cbType.Text))
                {
                    MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(tbnum.Text) && cbType.SelectedIndex == 0)
                {
                    MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbType.SelectedIndex == 0 && numbermember == 0)
                {
                    MessageBox.Show("Please enter correct information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(tblastmonth.Text) || WaterLastMonth < 0)
                {
                    MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(tbthismonth.Text) || WaterThisMonth < WaterLastMonth || WaterThisMonth < 0)
                {
                    MessageBox.Show("Please complete all information", "warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    item.Text = id;
                    item.SubItems.Add(name);
                    item.SubItems.Add(phone);
                    //item.SubItems.Add(type.ToString());
                    if (type == 0)
                    {
                        tbnum.ReadOnly = true;
                        item.SubItems.Add("Household");

                    }
                    else if (type == 1)
                    {
                        item.SubItems.Add("Administrative agency, public services");
                        tbnum.ReadOnly = false;
                        numbermember = 0;
                    }
                    else if (type == 2)
                    {
                        item.SubItems.Add("Production units");
                        tbnum.ReadOnly = false;
                        numbermember = 0;
                    }
                    else if (type == 3)
                    {
                        item.SubItems.Add("Business services");
                        tbnum.ReadOnly = false;
                        numbermember = 0;
                    }
                    else
                    {
                        tbnum.ReadOnly = false;
                        item.SubItems.Add("");
                        numbermember = 0;
                    }
                    amount = WaterThisMonth - WaterLastMonth;
                    Price = CalculateWaterBill(type, amount, numbermember);
                    Total = Price * 1.21;
                    item.SubItems.Add(member.ToString());
                    item.SubItems.Add(WaterLastMonth.ToString());
                    item.SubItems.Add(WaterThisMonth.ToString());
                    item.SubItems.Add(amount.ToString());
                    //item.SubItems.Add(Price.ToString());
                    item.SubItems.Add(Total.ToString("F2"));
                    //đẩy item vào lsvStudent
                    customer.Add(new Customer(id, name, phone, type, numbermember, WaterLastMonth, WaterThisMonth, amount, Price, Total));
                    //lvWaterBill.Items.Add(item);
                    tbId.Text = null;
                    tbName.Text = null;
                    tbPhone.Text = null;
                    cbType.SelectedIndex = -1;
                    tbnum.Text = null;
                    tblastmonth.Text = null;
                    tbthismonth.Text = null;
                    tbamout.Text = null;
                    tbtotal.Text = null;
                    tbdes.Text = null;
                }
            }
        }
        static double CalculateWaterBill(double price, double water, double members)
        {
            switch (price)
            {
                case 0:
                    price = CarlculateHouseHoldWaterBill(price, water, members);
                    break;

                case 1:
                    price = 9955 * water;
                    break;
                case 2:
                    price = 11615 * water;
                    break;
                case 3:
                    price = 22068 * water;
                    break;
            }
            return price;
        }
        static double CarlculateHouseHoldWaterBill(double price, double water, double members)
        {
            water = water / members;
            if (water > 30)
            {
                price = (5973 * 10 + 7052 * 10 + 8699 * 10 + 15929 * (water - 30));
            }
            else if (20 < water && water <= 30)
            {
                price = (5973 * 10 + 7052 * 10 + 8699 * (water - 20));
            }
            else if (10 < water && water <= 20)
            {
                price = (5973 * 10 + 7052 * (water - 10));
            }
            else
            {
                price = (5973 * water);
            }


            return price * members;
        }
        private void LoadDataIntoListView()
        {
            foreach (var customer in customer)
            {
                ListViewItem item = new ListViewItem(customer.ID);
                item.SubItems.Add(customer.Name);
                item.SubItems.Add(customer.Phone);
                item.SubItems.Add(customer.Total.ToString("F2"));
                lvWaterBill.Items.Add(item);
            }
        }
        // Event driven programming
        private void Form1_Load(object sender, EventArgs e)
        {
            lvWaterBill.Columns.Add("ID", 100);
            lvWaterBill.Columns.Add("Name", 150);
            lvWaterBill.Columns.Add("Phone", 150);
            lvWaterBill.Columns.Add("Type of customer", 150);
            lvWaterBill.Columns.Add("Number of members", 100);
            lvWaterBill.Columns.Add("Water last month (m3)", 150);
            lvWaterBill.Columns.Add("Water This month (m3)", 150);
            lvWaterBill.Columns.Add("Water used (m3)", 150);
            lvWaterBill.Columns.Add("Total (VNĐ)", 150);
            lvWaterBill.Columns.Add("Description", 150);         
        }

        private void tbamout_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                tbnum.ReadOnly = false;
                tbdes.Text = $"Household customer{"",-22}|Price{"",-15}\r\nTo 10 m3/people/month{"",-16}|5,973 VND"
                    + $"\r\nFrom 10-20 m3/people/month{"",-6}|7.052 VND/m3 \r\nFrom 20-30 m3/people/month {"",-5}|8.699 VND/m3 \r\nOver 30 m3/people/month{"",-12}|15.929 VND/m3"
                    + $"--------------------------------------------------------------\r\nEnviroment fees (10%)\r\nVAT (10%)";
                type = 0;
                amount = WaterThisMonth - WaterLastMonth;
                Price = CalculateWaterBill(type, amount, numbermember);
                Total = Price * 1.21;
                tbamout.Text = amount.ToString("F2");
                tbtotal.Text = Total.ToString("F2");
            }
            else if (cbType.SelectedIndex == 1)
            {
                tbnum.ReadOnly = true;
                tbnum.Text = "";
                tbdes.Text = $"Administrative agency, public services{"",-1}|Price" + $"\r\n{"",-64}|9.955 VND/m3" +
                    $"--------------------------------------------------------------\r\nEnviroment fees (10%)\r\nVAT (10%)";
                type = 1;
                numbermember = 0;
                amount = WaterThisMonth - WaterLastMonth;
                Price = CalculateWaterBill(type, amount, numbermember);
                Total = Price * 1.21;
                tbamout.Text = amount.ToString("F2");
                tbtotal.Text = Total.ToString("F2");
            }
            else if (cbType.SelectedIndex == 2)
            {
                tbnum.ReadOnly = true;
                tbnum.Text = "";
                tbdes.Text = $"Production units{"",-37}|Price" + $"\r\n{"",-64}|11.615 VND/m3" +
                    $"--------------------------------------------------------------\r\nEnviroment fees (10%)\r\nVAT (10%)";
                type = 2;
                numbermember = 0;
                amount = WaterThisMonth - WaterLastMonth;
                Price = CalculateWaterBill(type, amount, numbermember);
                Total = Price * 1.21;
                tbamout.Text = amount.ToString("F2");
                tbtotal.Text = Total.ToString("F2");
            }
            else if (cbType.SelectedIndex == 3)
            {
                tbnum.ReadOnly = true;
                tbnum.Text = "";
                tbdes.Text = $"Business services{"",-37}|Price" + $"\r\n{"",-64}|22.068 VND/m3" +
                    $"--------------------------------------------------------------\r\nEnviroment fees (10%)\r\nVAT (10%)";
                type = 3;
                numbermember = 0;
                amount = WaterThisMonth - WaterLastMonth;
                Price = CalculateWaterBill(type, amount, numbermember);
                Total = Price * 1.21;
                tbamout.Text = amount.ToString("F2");
                tbtotal.Text = Total.ToString("F2");
            }
            else
            {
                tbnum.ReadOnly = true;
                type = -1;
            }




        }

        private void tbnum_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbnum.Text, out int member))
            {
                numbermember = member;
            }
            if (double.TryParse(tblastmonth.Text, out double waterlastmonth))
            {
                WaterLastMonth = waterlastmonth;
            }
            if (double.TryParse(tbthismonth.Text, out double waterthismonth))
            {
                WaterThisMonth = waterthismonth;
            }
            amount = WaterThisMonth - WaterLastMonth;
            Price = CalculateWaterBill(type, amount, numbermember);
            Total = Price * 1.21;
            tbamout.Text = amount.ToString("F2");
            tbtotal.Text = Total.ToString("F2");
        }

        private void tblastmonth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbnum.Text, out int member))
            {
                numbermember = member;
            }
            if (double.TryParse(tblastmonth.Text, out double waterlastmonth))
            {
                WaterLastMonth = waterlastmonth;
            }
            if (double.TryParse(tbthismonth.Text, out double waterthismonth))
            {
                WaterThisMonth = waterthismonth;
            }
            amount = WaterThisMonth - WaterLastMonth;
            tbamout.Text = amount.ToString("F2");
            Price = CalculateWaterBill(type, amount, numbermember);
            Total = Price * 1.21;
            tbtotal.Text = Total.ToString("F2");
        }

        private void tbthismonth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbnum.Text, out int member))
            {
                numbermember = member;
            }
            if (double.TryParse(tblastmonth.Text, out double waterlastmonth))
            {
                WaterLastMonth = waterlastmonth;
            }
            if (double.TryParse(tbthismonth.Text, out double waterthismonth))
            {
                WaterThisMonth = waterthismonth;
            }
            amount = WaterThisMonth - WaterLastMonth;
            tbamout.Text = amount.ToString("F2");
            Price = CalculateWaterBill(type, amount, numbermember);
            Total = Price * 1.21;
            tbtotal.Text = Total.ToString("F2");
        }

        private void tbdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                ListViewItem seleted_Item = lvWaterBill.SelectedItems[0];
                string ID = seleted_Item.SubItems[0].Text;
                string Name = seleted_Item.SubItems[1].Text;
                string Phone = seleted_Item.SubItems[2].Text;
                string kind = seleted_Item.SubItems[3].Text;
                string members = seleted_Item.SubItems[4].Text;
                string Waterlastmonth = seleted_Item.SubItems[5].Text;
                string Waterthismonth = seleted_Item.SubItems[6].Text;
                string Waterused = seleted_Item.SubItems[7].Text;
                string total = seleted_Item.SubItems[8].Text;
                tbId.Text = ID;
                tbName.Text = Name;
                tbPhone.Text = Phone;
                if (kind == "Household")
                {
                    cbType.SelectedIndex = 0;
                }
                else if (kind == "Administrative agency, public services")
                {
                    cbType.SelectedIndex = 1;
                }
                else if (kind == "Production units")
                {
                    cbType.SelectedIndex = 2;
                }
                else if (kind == "Business services")
                {
                    cbType.SelectedIndex = 3;
                }
                else cbType.SelectedIndex = -1;
                tbnum.Text = members;
                tblastmonth.Text = Waterlastmonth;
                tbthismonth.Text = Waterthismonth;
                tbamout.Text = Waterused;
                tbtotal.Text = total;
            }
        }
        // button delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                lvWaterBill.Items.Remove(lvWaterBill.SelectedItems[0]);
                tbId.Text = null;
                tbName.Text = null;
                tbPhone.Text = null;
                cbType.SelectedIndex = -1;
                tbnum.Text = null;
                tblastmonth.Text = null;
                tbthismonth.Text = null;
                tbamout.Text = null;
                tbtotal.Text = null;
                tbdes.Text = null;
            }
        }
        // button reset
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to delete ?",
                "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                lvWaterBill.Items.Clear();
                lvWaterBill.Columns.Clear();
                tbId.Text = null;
                tbName.Text = null;
                tbPhone.Text = null;
                cbType.SelectedIndex = -1;
                tbnum.Text = null;
                tblastmonth.Text = null;
                tbthismonth.Text = null;
                tbamout.Text = null;
                tbtotal.Text = null;
                tbdes.Text = null;
            }

        }
        // button print bill
        private void button5_Click(object sender, EventArgs e)
        {
            BillForm billform = new BillForm();
            this.Hide();
            billform.ShowDialog();
        }
        // change form
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                BillForm billform = new BillForm();
                this.Hide();
                billform.ShowDialog();
            }
        }
        // form closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
                Application.Exit();            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Name:
//Date:
namespace MackayLab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //4. class-level lists
        List<Customer> customers = new List<Customer>();
        List<Furniture> products = new List<Furniture>();
        List<Cart> lineItems = new List<Cart>();
        private void Form1_Load(object sender, EventArgs e)
        { //3. form load code
            FlipSwitch(true);
            PopulateProducts();
            ReadInCustomers();
        }
        private void PopulateProducts()
        {   //5.
            products.Add(new Sofas("SKW", "Key West", 799.99m, "Blue", 3));
            products.Add(new DiningRoom("DS", "Sabrina", 1599m, "Rectangular", 6));
            products.Add(new Sofas("SMO", "Monica", 545m, "Red", 2));
            products.Add(new DiningRoom("DJ", "Jericho", 2150m, "Oval", 4));
            products.Add(new Sofas("SIK", "IKEA", 1299.5m, "Green", 6));
            products.Add(new DiningRoom("DH", "Hatfield", 899.6m, "Square", 2));

            //use foreach to display all products in combobox with type and description
            foreach (Furniture item in products)
            {
                cboProducts.Items.Add(item.ToString());
            }

        }
        //switchs groupbox shown and resets groupboxes
        private void FlipSwitch(bool loginOn)
        {
            grpLogin.Visible = loginOn;
            grpCustomer.Visible = !loginOn;
            grpProducts.Visible = !loginOn;
            grpCart.Visible = !loginOn;
            cboNames.SelectedIndex = -1;
            lblID.Text = "";
            lblFirstName.Text = "";
            lblLastName.Text = "";
            nudNumber.Value = 1;
            cboProducts.SelectedIndex = -1;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //7. if Name selected, find the customer from list
            if (cboNames.SelectedIndex == -1)
                MessageBox.Show("Select last name", "Field Required");
            else
            {
                //find the customer in the list
                int record = FindCustomer(cboNames.Text);
                if (record != -1)
                {
                    //customer found - flip groupboxes
                    FlipSwitch(false);
                    //fill data
                    lblID.Text = customers[record].ID;
                    lblFirstName.Text = customers[record].FirstName;
                    lblLastName.Text = customers[record].LastName;

                    //determine if goldstar for 2nd card
                    if (customers[record].GetType().Name == "Customer")
                        btn2ndCard.Enabled = false;
                    else
                    {
                        //if goldstar - determine if 2nd card already used
                        if ((customers[record] as GoldStar).Cards > 1)
                            btn2ndCard.Enabled = false;
                        else
                            btn2ndCard.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Lastname: " + cboNames.Text + " not found", "Customer Invalid");
            } 
        }
        public int FindCustomer(string lastName)
        {
            int foundCust = -1, count = 0;
            //attempt to find lastname in file
            foreach (Customer c in customers)
            {
                if (lastName.ToLower() == (c.LastName).ToLower())
                {
                    foundCust = count;
                    break; // stop loop
                }
                count++;
            }
            //return location found (index)
            return foundCust;
            //return -1; // used to test if customer not found
        }

        public void ReadInCustomers()
        {
            try
            {    //hard coded filename     
                StreamReader inputFile = new StreamReader(@"c:\files\Customers.txt");
                string inID, inLastName, inFirstName;
                while (inputFile.Peek() != -1)
                {
                    string row = inputFile.ReadLine();
                    string[] columns = row.Split('|');

                    inID = columns[0];
                    inLastName = columns[1];
                    inFirstName = columns[2];
                    cboNames.Items.Add(inLastName);
                    //6. determine type of customer based on length of code and place in customers list
                    if (inID.Length == 1)
                        customers.Add(new Customer(inID, inLastName, inFirstName));
                    else
                        customers.Add(new GoldStar(inID, inLastName, inFirstName));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Closing Program", "File Error");
                Close();
            }
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //set index of item to add
            int i = cboProducts.SelectedIndex;
            if (i >= 0)
            {
                int qty = Convert.ToInt32(nudNumber.Value);
                //create cart object and put in list of lineItems
                lineItems.Add(new Cart(products[i].Code, products[i].Description, products[i].Price, qty));
                //add to cart display
                lstCart.Items.Add(lineItems[lineItems.Count - 1].ToString());
            }

        }
        private void btn2ndCard_Click(object sender, EventArgs e)
        {
            // 8. clone the customer and give them a second card
            int record = FindCustomer(lblLastName.Text);
            GoldStar c = (GoldStar)customers[record]; // must declare a GoldStar before cloning on next line
            GoldStar c2 = (GoldStar)c.Clone();
            //returns null if problem
            if (c2 != null)
            {
                customers.Add(c2);
                cboNames.Items.Add(c2.LastName);
                btn2ndCard.Enabled = false;
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //check items in cart
            if (lstCart.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?\nYes: Order Processed " + 
                    "\nNo: Return and finish order \nCancel: Cancel order and logout", 
                    "Confirm Order", MessageBoxButtons.YesNoCancel);
                if (result != DialogResult.No)
                {
                    if (result == DialogResult.Yes)
                        ProcessOrder();
                    lstCart.Items.Clear();
                    FlipSwitch(true);
                    lineItems.Clear();
                }
            }
        }
        private void ProcessOrder()
        {
            decimal totalOrder = 0;
            //add to total order
            foreach (Cart item in lineItems)
                totalOrder += item.LineTotal;
            //find customer linked to order
            int record = FindCustomer(lblLastName.Text);
            //add Order to customer
            if (record != -1)
            {
                customers[record].Invoices.Add(new Orders(totalOrder));
                //display customer order info
                int num = customers[record].Invoices.Count - 1;
                MessageBox.Show("Order number: " + customers[record].Invoices[num].OrderNumber +
                    "\nDate: " + DateTime.Today.ToString("MM/dd/yyyy") +
                    "\nGrand Total: " + customers[record].Invoices[num].GrandTotal.ToString("c"),
                    "Order Confirmed");
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            //get the index of both the products combobox and Cart listbox
            int pRecord = cboProducts.SelectedIndex;
            int cRecord = lstCart.SelectedIndex;
            //if two items selected (even if same item)
            if (pRecord >= 0 && cRecord >= 0)
            {
                string msg = products[pRecord].Description + " in product list is";
                switch (products[pRecord].CompareTo(lineItems[cRecord]))
                {
                    case 1:
                        msg += " more expensive than ";
                        break;
                    case 0:
                        msg += " same price as ";
                        break;
                    default:
                        msg += " less expensive than ";
                        break;
                }
                msg += lineItems[cRecord].Description + " cart item";
                MessageBox.Show(msg, "Comparison");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //display all customers who places orders
            //with their last name and number of orders places
        }
    } // end Form Class
    /* 2. code all
     * other classes here */

    /*****************************************************************/
    public class Orders
    {
        //fields & properties
        private static int nextID = 1;
        public int OrderNumber;
        public DateTime OrderDate;
        public decimal GrandTotal;

        //default constructor
        public Orders ()
        {
            OrderNumber =nextID++;
            OrderDate = DateTime.Today;
        }
        //custom constructor - calls default
        public Orders (decimal inGrandTotal): this() =>
           GrandTotal = inGrandTotal;  
    }
    /*****************************************************************/
    public class Customer
    {
        //field
        private string id;
        //properties
        public string ID
        {
            get { return id; }
            set 
            {   id = value;
                //id's have to be 2 characters or less
                if (id.Length > 2)
                    id = id.Remove(2); // implies only first 2 characters are KEPT
            }
        }
        //auto-implemented properties
        public string LastName;
        public string FirstName;
        public List<Orders> Invoices; // declared but not initialized

        //default constructor
        public Customer() => Invoices = new List<Orders>(); // invoices list is initialized in default constructor

        //custom constructor
        public Customer(string inID, string inLastName, string inFirstName) : this()
        {
            ID = inID;
            LastName = inLastName;
            FirstName = inFirstName;
        } 
    }
    /*****************************************************************/
    public class GoldStar : Customer, ICloneable
    {
        //constant
        private const int MAXCARDS = 2;
        //properties
        public int Cards = 1; //set to 1 for all, not needed in constructor

        //default constructor
        public GoldStar() { }

        //custom constructor
        public GoldStar(string inID, string inLastName, string inFirstName) : base(inID, inLastName, inFirstName) {}

        //Clone - return null or a cloned object
        public object Clone()
        {
            GoldStar g = null;
            if (Cards < MAXCARDS)
            {
                //deep copy adding -2 to lastName
                g = new GoldStar(ID, LastName + "-2", FirstName);
                //put 2 in both cards
                Cards++;
                g.Cards++;
            }
            return g;
            // return null; // test what happens
        }
    }
    /*****************************************************************/
    public abstract class Furniture : IComparable<Furniture>
    {
        //fields
        private decimal price;
        //auto-implemented properties
        public string Code;
        public string Description;
        public decimal Price
        {   get { return price; }
            set
            {
                price = value;
                //validate ID is between 5 - 2500, set to 5000 if invalid set to 599.99
                if (price < 5m || price > 2500m)
                    price = 599.99m;
            }
        }
        //default constructor
        public Furniture() { }

        //custom constructor
        public Furniture(string inCode, string inDescription, decimal inPrice)
        {
            Code = inCode;
            Description = inDescription;
            Price = inPrice;
        }

        //override ToString formatted
        public override string ToString() =>
                 String.Format("{0, -5}{1, -15}{2, 9:c2}", Code, Description, Price);

        //implement Icomparable to compare prices of two pieces of furniture
        public int CompareTo(Furniture other)
        {
            int moreExpensive = -1;
            if (Price > other.Price)
                moreExpensive = 1;
            else if (Price == other.Price)
                moreExpensive = 0;
            return moreExpensive;
        }
    }
    /*****************************************************************/
    public class Sofas : Furniture
    {
        //fields
        private int seats;
        //auto-implemented properties
        public string Color;
        public int Seats
        {
            get { return seats; }
            set
            {
                seats = value;
                if (seats <= 0 || seats > 4)
                    seats = 3;
            }
        }

        //default constructor
        public Sofas() { }

        //custom constructor
        public Sofas(string inCode, string inDescription, decimal inPrice, string inColor, int inSeats)
            : base(inCode, inDescription, inPrice) 
        {
            Color = inColor;
            Seats = inSeats;
        }

        //override ToString - call base first, add properties here
        public override string ToString() =>
                 base.ToString() + Color + " " + Seats + "-seater";
    }
    /*****************************************************************/
    public sealed class DiningRoom : Furniture
    {
        //fields
        private int chairs;
        //properties
        public string TableShape;
        public int Chairs
        {
            get { return chairs; }
            set
            {
                chairs = (value > 6 || value < 2 ? 4 : value);
            }
        }
        //default constructor
        public DiningRoom() { }

        //custom constructor - call base
        public DiningRoom(string inCode, string inDescription, decimal inPrice, string inTableShape, int inChairs) 
            : base(inCode, inDescription, inPrice)
        {
            TableShape = inTableShape;
            Chairs = inChairs;
        }

        //display method
        public override string ToString() =>
                 base.ToString() + TableShape + " " + Chairs + " chairs";
    }
    /*****************************************************************/
    public sealed class Cart : Furniture
    {
        //fields
        private int amount;
        //properties
        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value >= 1 && value <= 10 ? value : 1;
            }
        }
        public decimal LineTotal;

        //default constructor
        public Cart() { }

        //custom constructor - call base
        public Cart(string inCode, string inDescription, decimal inPrice, int inAmount) 
            : base(inCode, inDescription, inPrice)
        {
            Amount = inAmount;
            LineTotal = Math.Round(Amount * Price, 2);
        }

        //override ToString, calls base first
        public override string ToString() =>
                 base.ToString() + String.Format("{0,5}{1,12:c2}", Amount, LineTotal);
    }
}
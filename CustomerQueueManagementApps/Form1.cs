using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerQueueManagementApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<Customer> customerQueue = new Queue<Customer>();
        
        private int indexSerialNo=1;
        private ListViewItem items = new ListViewItem();
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            
            customer.name = enqueueNameTextBox.Text;
            customer.complain = enqueueComplainTextBox.Text;
            customer.serialNo = indexSerialNo;

            customerQueue.Enqueue(customer);
            indexSerialNo++;

            ListViewItem items=new ListViewItem();
            items.Text = customer.serialNo.ToString();
            items.SubItems.Add(customer.name);
            items.SubItems.Add(customer.complain);

            waitingQueueListView.Items.Add(items);

            enqueueNameTextBox.Text = "";
            enqueueComplainTextBox.Text = "";

            MessageBox.Show(customer.name+" Serial No is "+customer.serialNo);
         
        }

       

        private void dequeueButton_Click(object sender, EventArgs e)
            {
            
            
            serialNoTextBox.Text = "";
            dequeueNameTextBox.Text = "";
            dequeueComplainTextBox.Text = "";
            waitingQueueListView.Items[0].Remove();
            if (customerQueue.Count == 0)
                {
                MessageBox.Show("There is no more Waiting Queue Left");
                }

            }

        private void waitingQueueListView_MouseClick(object sender, MouseEventArgs e)
            {
            Customer customer = new Customer();
            customer = customerQueue.Dequeue();
           

            serialNoTextBox.Text = customer.serialNo.ToString();
            dequeueNameTextBox.Text = customer.name;
            dequeueComplainTextBox.Text = customer.complain;

            }

        
        
    }
}

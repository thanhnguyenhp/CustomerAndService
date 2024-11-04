using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndService
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        List<Service > services = new List<Service>();
        int nextCustomerId = 1;
        public Form1()
        {
            InitializeComponent();
            Loadservice();
            UpdateCustomerGrid();
            UpdateServiceGrid();
        }

        private void Loadservice()
        {
            services.Add(new Service { Id = 1, Name = "Dich vu 1", Price = 145});
            services.Add(new Service { Id = 2, Name = "Dich vu 2", Price = 60 });
            services.Add(new Service { Id = 3, Name = "Dich vu 3", Price = 90 });
            services.Add(new Service { Id = 4, Name = "Dich vu 4", Price = 210});
            services.Add(new Service { Id = 5, Name = "Dich vu 5", Price = 140 });
            services.Add(new Service { Id = 6, Name = "Dich vu 6", Price = 105 });
        }

        private void UpdateCustomerGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customers;
        }

        private void UpdateServiceGrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = services;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ClearCustomerFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = nextCustomerId++,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
            };
            customers.Add(customer);
            UpdateCustomerGrid();
            ClearCustomerFields();
        }

        private void btnfix_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) { 
                var customer = (Customer)dataGridView1.CurrentRow.DataBoundItem;
                customer.Name = txtName.Text;
                customer.Phone = txtPhone.Text;
                customer.Address = txtAddress.Text;
                UpdateCustomerGrid();
                ClearCustomerFields();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) 
            {
                var customer = (Customer)dataGridView1.CurrentRow.DataBoundItem;
                var selectedServiceIds = GetSelectedServiceIds();
                CreateInvoice(customer, selectedServiceIds);
            }
        }

        private List<int> GetSelectedServiceIds()
        {
            List<int> selectedIds = new List<int>();
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                var service = (Service)row.DataBoundItem;
                selectedIds.Add(service.Id);
            }
            return selectedIds;
        }

        private void CreateInvoice(Customer customer,List<int> selectedServiceIds)
        {
            var selectedServices =services.Where(s=> selectedServiceIds.Contains(s.Id)).ToList();
            decimal total = selectedServices.Sum(s=> s.Price);
            MessageBox.Show($"Hoa don cho {customer.Name}:\n" +
                            $"Dich vu:{string.Join("", "", selectedServices.Select(s => s.Name))}\n" +
                            $"Tong tien:{total} VND", "Hoa don", MessageBoxButtons.OK);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
        
}

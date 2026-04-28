using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Programming_Language_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            // checking empty input
            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

            // Hnadling of duplicates
            if (listBox1.Items.Contains(language))
            {
                MessageBox.Show("This programming language is already in the list.");
                return;
            }

            // Adding a languge to the list
            listBox1.Items.Add(language);

            // Showing the time a language was added
            lblDateTime.Text = $" Added: {language} at {DateTime.Now:dd MMM yyyy HH:mm:ss}";


            txtLanguage.Clear();
            txtLanguage.Focus();
        }

        // Remove button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string removed = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);


                // Showing the time a language was removed
                lblDateTime.Text = $"Removed: {removed} at {DateTime.Now: dd MMM yyyy HH:mm:ss}";

            }
            else
            {
                MessageBox.Show("Please select a programming language to remove.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
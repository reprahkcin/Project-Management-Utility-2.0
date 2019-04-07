﻿using System;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class DeliverableForm : Form
    {
        public DeliverableForm()
        {
            InitializeComponent();
        }

        public string name
        {
            get { return name_textBox.Text; }
        }

        public string description
        {
            get { return description_textBox.Text; }
        }

        public string priority
        {
            get { return priority_comboBox.Text; }
        }

        public string mediaType
        {
            get { return mediaType_comboBox.Text; }
        }

        public DateTime dueDate
        {
            get { return dueDate_picker.Value; }
        }
        public string status
        {
            get { return status_comboBox.Text; }
        }
        public string quantity
        {
            get { return quantity_textBox.Text; }
        }
        public string estimatedTimePer
        {
            get { return estimatedTimePer_textBox.Text; }
        }
        public string accessibility
        {
            get { return accessibility_comboBox.Text; }
        }
        public string teamResponsible
        {
            get { return teamResponsible_comboBox.Text; }
        }
        public string finalLink
        {
            get { return finalLink_textBox.Text; }
        }

        public string duration
        {
            get { return duration_maskedTextBox.Text; }
        }

        private void Duration_maskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{
    public partial class frm_update_subject_enrolment_page1 : Form
    {
        private update_subject_enrolment updater;

        public frm_update_subject_enrolment_page1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frm_update_subject_Enrolment_Page_1_Load(object sender, EventArgs e)
        {
            string s = null;
            updater = new update_subject_enrolment(s);
            DataTable table = updater.GetRequestTable();
            dgv_update_subject_enrolment.DataSource = table;

            // register the EditingControlShowing event handler
            dgv_update_subject_enrolment.EditingControlShowing += dgv_update_subject_enrolment_EditingControlShowing;

            foreach (DataGridViewColumn dc in dgv_update_subject_enrolment.Columns)
            {
                if (dc.Index.Equals(0))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }
        private void dgv_update_subject_enrolment_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // check if the current column is the "Subject Code" column
            if (dgv_update_subject_enrolment.CurrentCell.OwningColumn.Name == "Subject Code")
            {
                // create a new TextBox control and set its properties
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.MaxLength = 8; // set the maximum length of the text box
                    tb.CharacterCasing = CharacterCasing.Upper; // convert all characters to uppercase
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
        }

        private void btn_view_subject_enrolment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_update_subject_enrolment_page2 secondForm = new frm_update_subject_enrolment_page2();
            secondForm.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string g = null;
            update_subject_enrolment obj1 = new update_subject_enrolment(g);
            obj1.update_request(dgv_update_subject_enrolment);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Main_Menu firstForm = new frm_Main_Menu();
            firstForm.Show();
        }

        private void grbDeleteRequest_Enter(object sender, EventArgs e)
        {

        }

        // This method is an event handler for the 'btnDelReq' button, which is clicked by the user
        private void btnDelReq_Click(object sender, EventArgs e)
        {
            // Initialize three string variables, which will be used to store the results of various methods
            string s = null;
            string t = null;
            string u = null;
            // Create a new update_subject_enrolment object with a parameter of 'txtRequestID.Text'
            update_subject_enrolment obj2 = new update_subject_enrolment(txtRequestID.Text);
            // Call the 'find_request_id' method on the update_subject_enrolment object, and store the result in 's'
            s = obj2.find_request_id(txtRequestID.Text);
            // If the result of 'find_request_id' is "Request ID exist", continue with the deletion process
            if (s == "Request ID exist")
            {
                // Create another update_subject_enrolment object with a parameter of 'txtRequestID.Text'
                update_subject_enrolment obj3 = new update_subject_enrolment(txtRequestID.Text);
                // Call the 'check_status' method on the new update_subject_enrolment object, and store the result in 't'
                t = obj3.check_status(txtRequestID.Text);
                // If the result of 'check_status' is "Request ID exists and is pending", notify the user that the request cannot be deleted
                if (t == "Request ID exists and is pending")
                {
                    MessageBox.Show(" Unable to delete " + txtRequestID.Text + " as status is still pending", "Delete Request ");
                }
                // If the result of 'check_status' is not "Request ID exists and is pending", proceed with the deletion process
                else
                {
                    // Create a third update_subject_enrolment object with a parameter of 'txtRequestID.Text'
                    update_subject_enrolment obj4 = new update_subject_enrolment(txtRequestID.Text);
                    // Call the 'delete_request' method on the new update_subject_enrolment object, and store the result in 'u'
                    u = obj4.delete_request(txtRequestID.Text);
                    // Notify the user that the request has been successfully deleted
                    MessageBox.Show("Request successfully deleted", "Delete Request");
                }
            }
            // If the result of 'find_request_id' is not "Request ID exist", notify the user that the request cannot be found
            else
            {
                MessageBox.Show("Request ID does not exist", "Delete Request");
                // Notify the user to enter an existing request ID
                MessageBox.Show("Please enter an existing Request ID", "Delete Request");
            }
        }
    }
}

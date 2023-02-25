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

        private void btnDelReq_Click(object sender, EventArgs e)
        {
            string s = null;
            string t = null;
            string u = null;
            update_subject_enrolment obj2 = new update_subject_enrolment(txtRequestID.Text);
            s= obj2.find_request_id(txtRequestID.Text);
            if (s == "Request ID exist")
            {
                update_subject_enrolment obj3 = new update_subject_enrolment(txtRequestID.Text);
                t = obj3.check_status(txtRequestID.Text);
                if (t == "Request ID exists and is pending")
                {
                    MessageBox.Show(" Unable to delete " + txtRequestID.Text + " as status is still pending", "Delete Request ");
                }
                else
                {
                    update_subject_enrolment obj4 = new update_subject_enrolment(txtRequestID.Text);
                    u = obj4.delete_request(txtRequestID.Text);
                    MessageBox.Show("Request successfully deleted", "Delete Request");
                }
            }
            else
            {
                MessageBox.Show("Request ID does not exist", "Delete Request");
                MessageBox.Show("Please enter an existing Request ID", "Delete Request");
            }
        }
    }
}

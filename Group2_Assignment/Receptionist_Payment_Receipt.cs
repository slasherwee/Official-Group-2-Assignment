using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Assignment
{

    public partial class frm_payment_receipt : Form
    {
        public frm_payment_receipt()
        {
            InitializeComponent();
        }
        public string Receipt_no { get; set; }
        private void gb_receipt_Enter(object sender, EventArgs e)
        {
        }

        private void frm_payment_receipt_Load(object sender, EventArgs e)
        {
            Payment_section obj8 = new Payment_section(Receipt_no);
            Payment_section obj2 = new Payment_section(Receipt_no);
            Payment_section obj3 = new Payment_section(Receipt_no);
            Payment_section obj4 = new Payment_section(Receipt_no);
            Payment_section obj5 = new Payment_section(Receipt_no);
            Payment_section obj6 = new Payment_section(Receipt_no);
            Payment_section obj7 = new Payment_section(Receipt_no);
            lbl_student_id_2.Text = (obj8.generate_receipt_1(Receipt_no));
            lbl_student_name.Text = (obj2.generate_receipt_2(Receipt_no));
            lbl_receipt_no_1.Text = (obj3.generate_receipt_7(Receipt_no));
            lbl_payment_method_1.Text = (obj4.generate_receipt_5(Receipt_no));
            lbl_total_1.Text = (obj5.generate_receipt_3(Receipt_no));
            lbl_date_1.Text = (obj6.generate_receipt_4(Receipt_no));
            lbl_remarks_1.Text = (obj7.generate_receipt_6(Receipt_no));
        }
    }
}

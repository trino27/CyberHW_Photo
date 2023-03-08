using System;

namespace CyberHW_Photo
{
    class Presenter
    {
        Model model = null;
        Form1 view = null;

        private const int photoPrice_9_12 = 10;
        private const int photoPrice_12_15 = 13;
        private const int photoPrice_18_24 = 17;

        public Presenter(Form1 form)
        {
            this.model = new Model();
            this.view = form;

            this.view.UserEvent += new EventHandler(UserEvent);

            InitDefaultForm();
        }

        public void UserEvent(object sender, EventArgs e)
        {
            if (this.model.IsInputCorrect(this.view.textBox_num.Text) && this.view.textBox_num.Text != "")
            {
                if (this.view.radioButton_9_12.Checked)
                {
                    this.view.label_bill.Text = this.model.CalcBill(photoPrice_9_12, Convert.ToInt32(this.view.textBox_num.Text));
                }
                else if (this.view.radioButton_12_15.Checked)
                {
                    this.view.label_bill.Text = this.model.CalcBill(photoPrice_12_15, Convert.ToInt32(this.view.textBox_num.Text));
                }
                else if (this.view.radioButton_18_24.Checked)
                {
                    this.view.label_bill.Text = this.model.CalcBill(photoPrice_18_24, Convert.ToInt32(this.view.textBox_num.Text));
                }
            }
            else
            {
                this.view.label_bill.Text = "Incorrect!";
            }
        }
        public void InitDefaultForm()
        {
            
            this.view.label_9_12.Text = photoPrice_9_12.ToString() + "грн";
            this.view.label_12_15.Text = photoPrice_12_15.ToString() + "грн";
            this.view.label_18_24.Text = photoPrice_18_24.ToString() + "грн";

            this.view.radioButton_9_12.Checked = true;
            this.view.textBox_num.Text = "1";
        }
    }
}

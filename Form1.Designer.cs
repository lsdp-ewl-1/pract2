
namespace pract2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_question = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.RadioButton();
            this.field_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text_invite = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.RadioButton();
            this.label_name = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Location = new System.Drawing.Point(211, 18);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(217, 20);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "Вы придете на мероприятие?";
            this.label_question.Click += new System.EventHandler(this.label1_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(413, 51);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(55, 24);
            this.no.TabIndex = 2;
            this.no.TabStop = true;
            this.no.Text = "Нет";
            this.no.UseVisualStyleBackColor = true;
            this.no.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // field_name
            // 
            this.field_name.Location = new System.Drawing.Point(205, 81);
            this.field_name.Multiline = true;
            this.field_name.Name = "field_name";
            this.field_name.Size = new System.Drawing.Size(271, 34);
            this.field_name.TabIndex = 3;
            this.field_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Получить приглашение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_invite
            // 
            this.text_invite.AutoSize = true;
            this.text_invite.Location = new System.Drawing.Point(189, 217);
            this.text_invite.Name = "text_invite";
            this.text_invite.Size = new System.Drawing.Size(144, 20);
            this.text_invite.TabIndex = 5;
            this.text_invite.Text = "Текст приглашения";
            this.text_invite.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(38, 382);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(322, 20);
            this.label_amount.TabIndex = 6;
            this.label_amount.Text = "Количество сформированных приглашений:";
            this.label_amount.Click += new System.EventHandler(this.label3_Click);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(117, 51);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(52, 24);
            this.yes.TabIndex = 7;
            this.yes.TabStop = true;
            this.yes.Text = " Да";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(91, 89);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(100, 20);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Введите имя:";
            this.label_name.Click += new System.EventHandler(this.label4_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(396, 382);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(17, 20);
            this.amount.TabIndex = 9;
            this.amount.Text = "0";
            this.amount.Click += new System.EventHandler(this.amount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 458);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.text_invite);
            this.Controls.Add(this.field_name);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label_question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.TextBox field_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label text_invite;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label amount;
    }
}


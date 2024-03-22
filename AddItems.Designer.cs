namespace Lab_6_C_
{
    partial class AddItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtNo
            // 
            txtNo.Location = new Point(346, 79);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(193, 27);
            txtNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 82);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Item No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 124);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Description : ";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(346, 121);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(193, 27);
            txtDesc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 164);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Price : ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(346, 164);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 27);
            txtPrice.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(250, 237);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(445, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(label1);
            Controls.Add(txtNo);
            Name = "AddItems";
            Text = "New Inventory Items";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNo;
        private Label label1;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}
namespace WinFormsApp2
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
            button1=new Button();
            button2=new Button();
            button3=new Button();
            txtCommand=new TextBox();
            dataGridView1=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(12, 90);
            button1.Name="button1";
            button1.Size=new Size(97, 39);
            button1.TabIndex=0;
            button1.Text="Exec";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Font=new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location=new Point(594, 90);
            button2.Name="button2";
            button2.Size=new Size(94, 39);
            button2.TabIndex=1;
            button2.Text="Fill";
            button2.UseVisualStyleBackColor=true;
            // 
            // button3
            // 
            button3.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location=new Point(694, 90);
            button3.Name="button3";
            button3.Size=new Size(94, 39);
            button3.TabIndex=2;
            button3.Text="Update";
            button3.UseVisualStyleBackColor=true;
            // 
            // txtCommand
            // 
            txtCommand.Location=new Point(15, 43);
            txtCommand.Name="txtCommand";
            txtCommand.Size=new Size(773, 23);
            txtCommand.TabIndex=3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(12, 135);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size(776, 303);
            dataGridView1.TabIndex=4;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtCommand);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtCommand;
        private DataGridView dataGridView1;
    }
}
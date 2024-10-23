namespace FotoMarcaDagua
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
            label1 = new Label();
            label2 = new Label();
            txtMoldura = new TextBox();
            txtPasta = new TextBox();
            btnSrcMold = new Button();
            btnSrcPasta = new Button();
            btnSobrepor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Escolha a moldura.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecione a pasta.";
            // 
            // txtMoldura
            // 
            txtMoldura.Location = new Point(12, 27);
            txtMoldura.Name = "txtMoldura";
            txtMoldura.Size = new Size(171, 23);
            txtMoldura.TabIndex = 2;
            // 
            // txtPasta
            // 
            txtPasta.Location = new Point(12, 71);
            txtPasta.Name = "txtPasta";
            txtPasta.Size = new Size(171, 23);
            txtPasta.TabIndex = 3;
            // 
            // btnSrcMold
            // 
            btnSrcMold.Location = new Point(189, 26);
            btnSrcMold.Name = "btnSrcMold";
            btnSrcMold.Size = new Size(28, 23);
            btnSrcMold.TabIndex = 4;
            btnSrcMold.Text = "...";
            btnSrcMold.UseVisualStyleBackColor = true;
            btnSrcMold.Click += btnSrcMold_Click;
            // 
            // btnSrcPasta
            // 
            btnSrcPasta.Location = new Point(189, 71);
            btnSrcPasta.Name = "btnSrcPasta";
            btnSrcPasta.Size = new Size(28, 23);
            btnSrcPasta.TabIndex = 5;
            btnSrcPasta.Text = "...";
            btnSrcPasta.UseVisualStyleBackColor = true;
            btnSrcPasta.Click += btnSrcPasta_Click;
            // 
            // btnSobrepor
            // 
            btnSobrepor.Location = new Point(12, 101);
            btnSobrepor.Name = "btnSobrepor";
            btnSobrepor.Size = new Size(205, 23);
            btnSobrepor.TabIndex = 6;
            btnSobrepor.Text = "Sobrepor";
            btnSobrepor.UseVisualStyleBackColor = true;
            btnSobrepor.Click += btnSobrepor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 136);
            Controls.Add(btnSobrepor);
            Controls.Add(btnSrcPasta);
            Controls.Add(btnSrcMold);
            Controls.Add(txtPasta);
            Controls.Add(txtMoldura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMoldura;
        private TextBox txtPasta;
        private Button btnSrcMold;
        private Button btnSrcPasta;
        private Button btnSobrepor;
    }
}

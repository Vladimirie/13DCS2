namespace autoform
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.ListBox listBoxEredmeny;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBetolt = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.btnSzures = new System.Windows.Forms.Button();
            this.listBoxEredmeny = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // btnBetolt
            this.btnBetolt.Location = new System.Drawing.Point(12, 12);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(75, 30);
            this.btnBetolt.TabIndex = 0;
            this.btnBetolt.Text = "Betölt";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);

            // btnKilep
            this.btnKilep.Location = new System.Drawing.Point(100, 12);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 30);
            this.btnKilep.TabIndex = 1;
            this.btnKilep.Text = "Bezár";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 200);
            this.dataGridView1.TabIndex = 2;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gyártási év:";

            // txtEv
            this.txtEv.Location = new System.Drawing.Point(74, 272);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(100, 22);
            this.txtEv.TabIndex = 4;

            // btnSzures
            this.btnSzures.Location = new System.Drawing.Point(190, 268);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(75, 30);
            this.btnSzures.TabIndex = 5;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);

            // listBoxEredmeny
            this.listBoxEredmeny.FormattingEnabled = true;
            this.listBoxEredmeny.ItemHeight = 16;
            this.listBoxEredmeny.Location = new System.Drawing.Point(12, 310);
            this.listBoxEredmeny.Name = "listBoxEredmeny";
            this.listBoxEredmeny.Size = new System.Drawing.Size(460, 132);
            this.listBoxEredmeny.TabIndex = 6;

            // Form1
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.listBoxEredmeny);
            this.Controls.Add(this.btnSzures);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnBetolt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

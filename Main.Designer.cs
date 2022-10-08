
namespace ProyectoCorreos
{
    partial class Main
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
            this.btnProfesion = new System.Windows.Forms.Button();
            this.btnCumpleaños = new System.Windows.Forms.Button();
            this.btnDividendos = new System.Windows.Forms.Button();
            this.btnCampañas = new System.Windows.Forms.Button();
            this.btnCartera = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnProfesion
            // 
            this.btnProfesion.Location = new System.Drawing.Point(12, 72);
            this.btnProfesion.Name = "btnProfesion";
            this.btnProfesion.Size = new System.Drawing.Size(75, 23);
            this.btnProfesion.TabIndex = 0;
            this.btnProfesion.Text = "Profesion";
            this.btnProfesion.UseVisualStyleBackColor = true;
            this.btnProfesion.Click += new System.EventHandler(this.btnProfesion_Click);
            // 
            // btnCumpleaños
            // 
            this.btnCumpleaños.Location = new System.Drawing.Point(12, 101);
            this.btnCumpleaños.Name = "btnCumpleaños";
            this.btnCumpleaños.Size = new System.Drawing.Size(75, 23);
            this.btnCumpleaños.TabIndex = 1;
            this.btnCumpleaños.Text = "Cumpleaños";
            this.btnCumpleaños.UseVisualStyleBackColor = true;
            this.btnCumpleaños.Click += new System.EventHandler(this.btnCumpleaños_Click);
            // 
            // btnDividendos
            // 
            this.btnDividendos.Location = new System.Drawing.Point(12, 130);
            this.btnDividendos.Name = "btnDividendos";
            this.btnDividendos.Size = new System.Drawing.Size(75, 23);
            this.btnDividendos.TabIndex = 2;
            this.btnDividendos.Text = "Dividendos";
            this.btnDividendos.UseVisualStyleBackColor = true;
            this.btnDividendos.Click += new System.EventHandler(this.btnDividendos_Click);
            // 
            // btnCampañas
            // 
            this.btnCampañas.Location = new System.Drawing.Point(12, 159);
            this.btnCampañas.Name = "btnCampañas";
            this.btnCampañas.Size = new System.Drawing.Size(75, 23);
            this.btnCampañas.TabIndex = 3;
            this.btnCampañas.Text = "Campañas";
            this.btnCampañas.UseVisualStyleBackColor = true;
            this.btnCampañas.Click += new System.EventHandler(this.btnCampañas_Click);
            // 
            // btnCartera
            // 
            this.btnCartera.Location = new System.Drawing.Point(12, 188);
            this.btnCartera.Name = "btnCartera";
            this.btnCartera.Size = new System.Drawing.Size(75, 23);
            this.btnCartera.TabIndex = 4;
            this.btnCartera.Text = "Cartera";
            this.btnCartera.UseVisualStyleBackColor = true;
            this.btnCartera.Click += new System.EventHandler(this.btnCartera_Click);
            // 
            // pMain
            // 
            this.pMain.Location = new System.Drawing.Point(90, 15);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(300, 300);
            this.pMain.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.btnCartera);
            this.Controls.Add(this.btnCampañas);
            this.Controls.Add(this.btnDividendos);
            this.Controls.Add(this.btnCumpleaños);
            this.Controls.Add(this.btnProfesion);
            this.Name = "Main";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfesion;
        private System.Windows.Forms.Button btnCumpleaños;
        private System.Windows.Forms.Button btnDividendos;
        private System.Windows.Forms.Button btnCampañas;
        private System.Windows.Forms.Button btnCartera;
        private System.Windows.Forms.Panel pMain;
    }
}


namespace GestioneManeggio
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
            txtNome = new TextBox();
            txtRazza = new TextBox();
            txtNascita = new TextBox();
            rdbMaschio = new RadioButton();
            rdbFemmina = new RadioButton();
            btnAggiungi = new Button();
            label1 = new Label();
            lblNascita = new Label();
            lblRazza = new Label();
            lblNome = new Label();
            lstManeggio = new ListBox();
            btnCerca = new Button();
            btnModifica = new Button();
            btnRimuovi = new Button();
            btnSalva = new Button();
            txtRisposta = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(51, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtRazza
            // 
            txtRazza.Location = new Point(232, 56);
            txtRazza.Name = "txtRazza";
            txtRazza.Size = new Size(100, 23);
            txtRazza.TabIndex = 1;
            // 
            // txtNascita
            // 
            txtNascita.Location = new Point(391, 62);
            txtNascita.MaxLength = 4;
            txtNascita.Name = "txtNascita";
            txtNascita.Size = new Size(100, 23);
            txtNascita.TabIndex = 2;
            txtNascita.KeyPress += txtNascita_KeyPress;
            // 
            // rdbMaschio
            // 
            rdbMaschio.AutoSize = true;
            rdbMaschio.Location = new Point(545, 45);
            rdbMaschio.Name = "rdbMaschio";
            rdbMaschio.Size = new Size(70, 19);
            rdbMaschio.TabIndex = 3;
            rdbMaschio.TabStop = true;
            rdbMaschio.Text = "Maschio";
            rdbMaschio.UseVisualStyleBackColor = true;
            // 
            // rdbFemmina
            // 
            rdbFemmina.AutoSize = true;
            rdbFemmina.Location = new Point(545, 70);
            rdbFemmina.Name = "rdbFemmina";
            rdbFemmina.Size = new Size(75, 19);
            rdbFemmina.TabIndex = 4;
            rdbFemmina.TabStop = true;
            rdbFemmina.Text = "Femmina";
            rdbFemmina.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(640, 59);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 5;
            btnAggiungi.Text = "AGGIUNGI";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 38);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // lblNascita
            // 
            lblNascita.AutoSize = true;
            lblNascita.Location = new Point(391, 44);
            lblNascita.Name = "lblNascita";
            lblNascita.Size = new Size(89, 15);
            lblNascita.TabIndex = 7;
            lblNascita.Text = "Anno di nascita";
            // 
            // lblRazza
            // 
            lblRazza.AutoSize = true;
            lblRazza.Location = new Point(232, 38);
            lblRazza.Name = "lblRazza";
            lblRazza.Size = new Size(36, 15);
            lblRazza.TabIndex = 8;
            lblRazza.Text = "Razza";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(51, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // lstManeggio
            // 
            lstManeggio.FormattingEnabled = true;
            lstManeggio.Location = new Point(334, 95);
            lstManeggio.Name = "lstManeggio";
            lstManeggio.Size = new Size(444, 214);
            lstManeggio.TabIndex = 10;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(51, 149);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(75, 23);
            btnCerca.TabIndex = 11;
            btnCerca.Text = "CERCA";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(51, 191);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(75, 23);
            btnModifica.TabIndex = 12;
            btnModifica.Text = "MODIFICA";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnRimuovi
            // 
            btnRimuovi.Location = new Point(144, 149);
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.Size = new Size(75, 23);
            btnRimuovi.TabIndex = 13;
            btnRimuovi.Text = "RIMUOVI";
            btnRimuovi.UseVisualStyleBackColor = true;
            btnRimuovi.Click += btnRimuovi_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(144, 191);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 14;
            btnSalva.Text = "SALVA";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // txtRisposta
            // 
            txtRisposta.Location = new Point(40, 315);
            txtRisposta.Name = "txtRisposta";
            txtRisposta.ReadOnly = true;
            txtRisposta.Size = new Size(440, 23);
            txtRisposta.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRisposta);
            Controls.Add(btnSalva);
            Controls.Add(btnRimuovi);
            Controls.Add(btnModifica);
            Controls.Add(btnCerca);
            Controls.Add(lstManeggio);
            Controls.Add(lblNome);
            Controls.Add(lblRazza);
            Controls.Add(lblNascita);
            Controls.Add(label1);
            Controls.Add(btnAggiungi);
            Controls.Add(rdbFemmina);
            Controls.Add(rdbMaschio);
            Controls.Add(txtNascita);
            Controls.Add(txtRazza);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtNome;
        private TextBox txtRazza;
        private TextBox txtNascita;
        private RadioButton rdbMaschio;
        private RadioButton rdbFemmina;
        private Button btnAggiungi;
        private Label label1;
        private Label lblNascita;
        private Label lblRazza;
        private Label lblNome;
        private ListBox lstManeggio;
        private Button btnCerca;
        private Button btnModifica;
        private Button btnRimuovi;
        private Button btnSalva;
        private TextBox txtRisposta;
    }
}

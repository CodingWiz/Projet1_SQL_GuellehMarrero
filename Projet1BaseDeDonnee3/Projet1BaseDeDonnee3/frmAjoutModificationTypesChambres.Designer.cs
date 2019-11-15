namespace Projet1BaseDeDonnee3
{
    partial class frmAjoutModificationTypesChambres
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPrixBas = new System.Windows.Forms.NumericUpDown();
            this.numPrixMoyen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numPrixHaut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPlaceholder = new System.Windows.Forms.GroupBox();
            this.btnPlaceholderEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errMsgTypes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPrixBas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixMoyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixHaut)).BeginInit();
            this.gbPlaceholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMsgTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Label placeholder";
            // 
            // tbNo
            // 
            this.tbNo.Enabled = false;
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNo.Location = new System.Drawing.Point(302, 55);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(33, 30);
            this.tbNo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "No type chambre";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(158, 110);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(253, 30);
            this.tbDescription.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Prix Bas ($)";
            // 
            // numPrixBas
            // 
            this.numPrixBas.DecimalPlaces = 2;
            this.numPrixBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrixBas.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numPrixBas.Location = new System.Drawing.Point(158, 176);
            this.numPrixBas.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrixBas.Name = "numPrixBas";
            this.numPrixBas.Size = new System.Drawing.Size(117, 30);
            this.numPrixBas.TabIndex = 23;
            // 
            // numPrixMoyen
            // 
            this.numPrixMoyen.DecimalPlaces = 2;
            this.numPrixMoyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrixMoyen.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numPrixMoyen.Location = new System.Drawing.Point(158, 237);
            this.numPrixMoyen.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrixMoyen.Name = "numPrixMoyen";
            this.numPrixMoyen.Size = new System.Drawing.Size(117, 30);
            this.numPrixMoyen.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prix Moyen ($)";
            // 
            // numPrixHaut
            // 
            this.numPrixHaut.DecimalPlaces = 2;
            this.numPrixHaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrixHaut.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numPrixHaut.Location = new System.Drawing.Point(158, 298);
            this.numPrixHaut.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrixHaut.Name = "numPrixHaut";
            this.numPrixHaut.Size = new System.Drawing.Size(117, 30);
            this.numPrixHaut.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prix Haut ($)";
            // 
            // gbPlaceholder
            // 
            this.gbPlaceholder.Controls.Add(this.btnPlaceholderEnregistrer);
            this.gbPlaceholder.Controls.Add(this.btnAnnuler);
            this.gbPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlaceholder.Location = new System.Drawing.Point(12, 334);
            this.gbPlaceholder.Name = "gbPlaceholder";
            this.gbPlaceholder.Size = new System.Drawing.Size(464, 120);
            this.gbPlaceholder.TabIndex = 29;
            this.gbPlaceholder.TabStop = false;
            // 
            // btnPlaceholderEnregistrer
            // 
            this.btnPlaceholderEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceholderEnregistrer.Location = new System.Drawing.Point(6, 37);
            this.btnPlaceholderEnregistrer.Name = "btnPlaceholderEnregistrer";
            this.btnPlaceholderEnregistrer.Size = new System.Drawing.Size(175, 63);
            this.btnPlaceholderEnregistrer.TabIndex = 7;
            this.btnPlaceholderEnregistrer.UseVisualStyleBackColor = true;
            this.btnPlaceholderEnregistrer.Click += new System.EventHandler(this.btnPlaceholderEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(283, 37);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(175, 63);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // errMsgTypes
            // 
            this.errMsgTypes.ContainerControl = this;
            // 
            // frmAjoutModificationTypesChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 476);
            this.Controls.Add(this.gbPlaceholder);
            this.Controls.Add(this.numPrixHaut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPrixMoyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPrixBas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutModificationTypesChambres";
            this.Text = "frmAjoutModificationTypesChambres";
            this.Load += new System.EventHandler(this.frmAjoutModificationTypesChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrixBas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixMoyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrixHaut)).EndInit();
            this.gbPlaceholder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMsgTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPrixBas;
        private System.Windows.Forms.NumericUpDown numPrixMoyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPrixHaut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPlaceholder;
        private System.Windows.Forms.Button btnPlaceholderEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errMsgTypes;
    }
}
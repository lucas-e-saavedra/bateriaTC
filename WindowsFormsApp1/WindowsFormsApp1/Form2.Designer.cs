
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.vistaObservador1 = new WindowsFormsApp1.Observer.WidgetBateria();
            this.vistaObservador2 = new WindowsFormsApp1.Observer.WidgetBateria();
            this.vistaObservador3 = new WindowsFormsApp1.Observer.WidgetBateria();
            this.SuspendLayout();
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(27, 32);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(65, 39);
            this.btnMas.TabIndex = 0;
            this.btnMas.Text = "BAT +";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(125, 32);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(65, 39);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "BAT -";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // vistaObservador1
            // 
            this.vistaObservador1.AutoSize = true;
            this.vistaObservador1.bateria = null;
            this.vistaObservador1.Location = new System.Drawing.Point(38, 199);
            this.vistaObservador1.Name = "vistaObservador1";
            this.vistaObservador1.Size = new System.Drawing.Size(90, 13);
            this.vistaObservador1.TabIndex = 2;
            this.vistaObservador1.Text = "vistaObservador1";
            // 
            // vistaObservador2
            // 
            this.vistaObservador2.AutoSize = true;
            this.vistaObservador2.bateria = null;
            this.vistaObservador2.Location = new System.Drawing.Point(315, 199);
            this.vistaObservador2.Name = "vistaObservador2";
            this.vistaObservador2.Size = new System.Drawing.Size(90, 13);
            this.vistaObservador2.TabIndex = 3;
            this.vistaObservador2.Text = "vistaObservador2";
            // 
            // vistaObservador3
            // 
            this.vistaObservador3.AutoSize = true;
            this.vistaObservador3.bateria = null;
            this.vistaObservador3.Location = new System.Drawing.Point(570, 199);
            this.vistaObservador3.Name = "vistaObservador3";
            this.vistaObservador3.Size = new System.Drawing.Size(90, 13);
            this.vistaObservador3.TabIndex = 4;
            this.vistaObservador3.Text = "vistaObservador3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vistaObservador3);
            this.Controls.Add(this.vistaObservador2);
            this.Controls.Add(this.vistaObservador1);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private Observer.WidgetBateria vistaObservador1;
        private Observer.WidgetBateria vistaObservador2;
        private Observer.WidgetBateria vistaObservador3;
    }
}

namespace CuadradoMagico_CSharp
{
    partial class CuadradoMagico_Form
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
            this.components = new System.ComponentModel.Container();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResolver = new System.Windows.Forms.Button();
            this.tmrLlenar = new System.Windows.Forms.Timer(this.components);
            this.trkbrIntervalo = new System.Windows.Forms.TrackBar();
            this.btnVerificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtN.Location = new System.Drawing.Point(134, 34);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(30, 29);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "5";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(184, 34);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(91, 29);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 522);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamaño";
            // 
            // btnResolver
            // 
            this.btnResolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResolver.Location = new System.Drawing.Point(499, 12);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(91, 29);
            this.btnResolver.TabIndex = 5;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // tmrLlenar
            // 
            this.tmrLlenar.Interval = 1000;
            this.tmrLlenar.Tick += new System.EventHandler(this.tmrLlenar_Tick);
            // 
            // trkbrIntervalo
            // 
            this.trkbrIntervalo.Location = new System.Drawing.Point(596, 14);
            this.trkbrIntervalo.Minimum = 1;
            this.trkbrIntervalo.Name = "trkbrIntervalo";
            this.trkbrIntervalo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trkbrIntervalo.Size = new System.Drawing.Size(104, 45);
            this.trkbrIntervalo.TabIndex = 6;
            this.trkbrIntervalo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkbrIntervalo.Value = 10;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.Location = new System.Drawing.Point(357, 34);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 32);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // CuadradoMagico_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 602);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.trkbrIntervalo);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtN);
            this.MaximizeBox = false;
            this.Name = "CuadradoMagico_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadrado Mágico";
            ((System.ComponentModel.ISupportInitialize)(this.trkbrIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Timer tmrLlenar;
        private System.Windows.Forms.TrackBar trkbrIntervalo;
        private System.Windows.Forms.Button btnVerificar;
    }
}


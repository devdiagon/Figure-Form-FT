namespace TareaFormas.form_views
{
    partial class FrmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTriangulo));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.lblInputB = new System.Windows.Forms.Label();
            this.lblInputA = new System.Windows.Forms.Label();
            this.gbrProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbrOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtInputC = new System.Windows.Forms.TextBox();
            this.lblInputC = new System.Windows.Forms.Label();
            this.grbInputs.SuspendLayout();
            this.gbrProcess.SuspendLayout();
            this.gbrOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(270, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRIÁNGULO";
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtInputC);
            this.grbInputs.Controls.Add(this.lblInputC);
            this.grbInputs.Controls.Add(this.txtInputB);
            this.grbInputs.Controls.Add(this.txtInputA);
            this.grbInputs.Controls.Add(this.lblInputB);
            this.grbInputs.Controls.Add(this.lblInputA);
            this.grbInputs.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 60);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(368, 176);
            this.grbInputs.TabIndex = 1;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtInputB
            // 
            this.txtInputB.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputB.Location = new System.Drawing.Point(139, 77);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(206, 28);
            this.txtInputB.TabIndex = 6;
            // 
            // txtInputA
            // 
            this.txtInputA.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputA.Location = new System.Drawing.Point(139, 32);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(206, 28);
            this.txtInputA.TabIndex = 4;
            // 
            // lblInputB
            // 
            this.lblInputB.AutoSize = true;
            this.lblInputB.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputB.Location = new System.Drawing.Point(44, 80);
            this.lblInputB.Name = "lblInputB";
            this.lblInputB.Size = new System.Drawing.Size(77, 20);
            this.lblInputB.TabIndex = 5;
            this.lblInputB.Text = "Lado (b):";
            // 
            // lblInputA
            // 
            this.lblInputA.AutoSize = true;
            this.lblInputA.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputA.Location = new System.Drawing.Point(45, 40);
            this.lblInputA.Name = "lblInputA";
            this.lblInputA.Size = new System.Drawing.Size(76, 20);
            this.lblInputA.TabIndex = 4;
            this.lblInputA.Text = "Lado (a):";
            // 
            // gbrProcess
            // 
            this.gbrProcess.Controls.Add(this.btnExit);
            this.gbrProcess.Controls.Add(this.btnReset);
            this.gbrProcess.Controls.Add(this.btnCalculate);
            this.gbrProcess.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrProcess.Location = new System.Drawing.Point(14, 242);
            this.gbrProcess.Name = "gbrProcess";
            this.gbrProcess.Size = new System.Drawing.Size(367, 93);
            this.gbrProcess.TabIndex = 2;
            this.gbrProcess.TabStop = false;
            this.gbrProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(259, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(138, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(20, 39);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbrOutputs
            // 
            this.gbrOutputs.Controls.Add(this.txtArea);
            this.gbrOutputs.Controls.Add(this.txtPerimeter);
            this.gbrOutputs.Controls.Add(this.lblArea);
            this.gbrOutputs.Controls.Add(this.lblPerimeter);
            this.gbrOutputs.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrOutputs.Location = new System.Drawing.Point(13, 356);
            this.gbrOutputs.Name = "gbrOutputs";
            this.gbrOutputs.Size = new System.Drawing.Size(367, 130);
            this.gbrOutputs.TabIndex = 3;
            this.gbrOutputs.TabStop = false;
            this.gbrOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(139, 84);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(206, 28);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimeter.Location = new System.Drawing.Point(139, 42);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(206, 28);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(73, 87);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 20);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(32, 45);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(89, 20);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(466, 95);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(285, 260);
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // txtInputC
            // 
            this.txtInputC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputC.Location = new System.Drawing.Point(140, 123);
            this.txtInputC.Name = "txtInputC";
            this.txtInputC.Size = new System.Drawing.Size(206, 28);
            this.txtInputC.TabIndex = 8;
            // 
            // lblInputC
            // 
            this.lblInputC.AutoSize = true;
            this.lblInputC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputC.Location = new System.Drawing.Point(45, 126);
            this.lblInputC.Name = "lblInputC";
            this.lblInputC.Size = new System.Drawing.Size(76, 20);
            this.lblInputC.TabIndex = 7;
            this.lblInputC.Text = "Lado (c):";
            // 
            // FrmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 519);
            this.ControlBox = false;
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.gbrOutputs);
            this.Controls.Add(this.gbrProcess);
            this.Controls.Add(this.grbInputs);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmTriangulo";
            this.Text = "FrmTriangulo";
            this.Load += new System.EventHandler(this.FrmTriangulo_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.gbrProcess.ResumeLayout(false);
            this.gbrOutputs.ResumeLayout(false);
            this.gbrOutputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.GroupBox gbrProcess;
        private System.Windows.Forms.GroupBox gbrOutputs;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.Label lblInputB;
        private System.Windows.Forms.Label lblInputA;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtInputC;
        private System.Windows.Forms.Label lblInputC;
    }
}
﻿namespace TareaFormas.form_views
{
    partial class FrmDeltoide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeltoide));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtInputAngle = new System.Windows.Forms.TextBox();
            this.lblInputAngle = new System.Windows.Forms.Label();
            this.txtInputSideB = new System.Windows.Forms.TextBox();
            this.lblInputSideB = new System.Windows.Forms.Label();
            this.txtInputSideA = new System.Windows.Forms.TextBox();
            this.lblInputSideA = new System.Windows.Forms.Label();
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
            this.lblTitle.Location = new System.Drawing.Point(347, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Deltoide";
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtInputAngle);
            this.grbInputs.Controls.Add(this.lblInputAngle);
            this.grbInputs.Controls.Add(this.txtInputSideB);
            this.grbInputs.Controls.Add(this.lblInputSideB);
            this.grbInputs.Controls.Add(this.txtInputSideA);
            this.grbInputs.Controls.Add(this.lblInputSideA);
            this.grbInputs.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 60);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(431, 216);
            this.grbInputs.TabIndex = 1;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtInputAngle
            // 
            this.txtInputAngle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputAngle.Location = new System.Drawing.Point(105, 165);
            this.txtInputAngle.Name = "txtInputAngle";
            this.txtInputAngle.Size = new System.Drawing.Size(206, 28);
            this.txtInputAngle.TabIndex = 12;
            // 
            // lblInputAngle
            // 
            this.lblInputAngle.AutoSize = true;
            this.lblInputAngle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputAngle.Location = new System.Drawing.Point(25, 127);
            this.lblInputAngle.Name = "lblInputAngle";
            this.lblInputAngle.Size = new System.Drawing.Size(367, 20);
            this.lblInputAngle.TabIndex = 11;
            this.lblInputAngle.Text = "Ánuglo entre (a) y (b) en grados entre 0° y 180°:";
            // 
            // txtInputSideB
            // 
            this.txtInputSideB.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSideB.Location = new System.Drawing.Point(193, 81);
            this.txtInputSideB.Name = "txtInputSideB";
            this.txtInputSideB.Size = new System.Drawing.Size(206, 28);
            this.txtInputSideB.TabIndex = 10;
            // 
            // lblInputSideB
            // 
            this.lblInputSideB.AutoSize = true;
            this.lblInputSideB.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputSideB.Location = new System.Drawing.Point(25, 81);
            this.lblInputSideB.Name = "lblInputSideB";
            this.lblInputSideB.Size = new System.Drawing.Size(162, 20);
            this.lblInputSideB.TabIndex = 9;
            this.lblInputSideB.Text = "Lados inferiores (b):";
            // 
            // txtInputSideA
            // 
            this.txtInputSideA.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSideA.Location = new System.Drawing.Point(193, 32);
            this.txtInputSideA.Name = "txtInputSideA";
            this.txtInputSideA.Size = new System.Drawing.Size(206, 28);
            this.txtInputSideA.TabIndex = 8;
            // 
            // lblInputSideA
            // 
            this.lblInputSideA.AutoSize = true;
            this.lblInputSideA.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputSideA.Location = new System.Drawing.Point(18, 35);
            this.lblInputSideA.Name = "lblInputSideA";
            this.lblInputSideA.Size = new System.Drawing.Size(170, 20);
            this.lblInputSideA.TabIndex = 7;
            this.lblInputSideA.Text = "Lados superiores (a):";
            // 
            // gbrProcess
            // 
            this.gbrProcess.Controls.Add(this.btnExit);
            this.gbrProcess.Controls.Add(this.btnReset);
            this.gbrProcess.Controls.Add(this.btnCalculate);
            this.gbrProcess.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrProcess.Location = new System.Drawing.Point(14, 299);
            this.gbrProcess.Name = "gbrProcess";
            this.gbrProcess.Size = new System.Drawing.Size(430, 93);
            this.gbrProcess.TabIndex = 2;
            this.gbrProcess.TabStop = false;
            this.gbrProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(313, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Cerrar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(171, 39);
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
            this.btnCalculate.Location = new System.Drawing.Point(35, 39);
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
            this.gbrOutputs.Location = new System.Drawing.Point(13, 413);
            this.gbrOutputs.Name = "gbrOutputs";
            this.gbrOutputs.Size = new System.Drawing.Size(431, 130);
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
            this.picImage.Location = new System.Drawing.Point(500, 95);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(285, 260);
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // FrmDeltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 559);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.gbrOutputs);
            this.Controls.Add(this.gbrProcess);
            this.Controls.Add(this.grbInputs);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmDeltoide";
            this.Text = "FrmTriangulo";
            this.Load += new System.EventHandler(this.FrmDeltoide_Load);
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
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtInputSideA;
        private System.Windows.Forms.Label lblInputSideA;
        private System.Windows.Forms.TextBox txtInputSideB;
        private System.Windows.Forms.Label lblInputSideB;
        private System.Windows.Forms.Label lblInputAngle;
        private System.Windows.Forms.TextBox txtInputAngle;
    }
}
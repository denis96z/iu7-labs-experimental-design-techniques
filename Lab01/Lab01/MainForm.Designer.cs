namespace Lab01
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbGenerator = new System.Windows.Forms.GroupBox();
            this.gbService = new System.Windows.Forms.GroupBox();
            this.lblGeneratorDistribution = new System.Windows.Forms.Label();
            this.lblServiceDistribution = new System.Windows.Forms.Label();
            this.lblσ = new System.Windows.Forms.Label();
            this.lblλ = new System.Windows.Forms.Label();
            this.tbσ = new System.Windows.Forms.TextBox();
            this.tbλ = new System.Windows.Forms.TextBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblB0 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblB3 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbGenerator.SuspendLayout();
            this.gbService.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGenerator
            // 
            this.gbGenerator.Controls.Add(this.tbN);
            this.gbGenerator.Controls.Add(this.lblN);
            this.gbGenerator.Controls.Add(this.tbσ);
            this.gbGenerator.Controls.Add(this.lblσ);
            this.gbGenerator.Controls.Add(this.lblGeneratorDistribution);
            this.gbGenerator.Location = new System.Drawing.Point(12, 12);
            this.gbGenerator.Name = "gbGenerator";
            this.gbGenerator.Size = new System.Drawing.Size(200, 108);
            this.gbGenerator.TabIndex = 0;
            this.gbGenerator.TabStop = false;
            this.gbGenerator.Text = "Параметры генератора:";
            // 
            // gbService
            // 
            this.gbService.Controls.Add(this.tbλ);
            this.gbService.Controls.Add(this.lblλ);
            this.gbService.Controls.Add(this.lblServiceDistribution);
            this.gbService.Location = new System.Drawing.Point(12, 126);
            this.gbService.Name = "gbService";
            this.gbService.Size = new System.Drawing.Size(200, 91);
            this.gbService.TabIndex = 1;
            this.gbService.TabStop = false;
            this.gbService.Text = "Параметры обслуживающего аппарата:";
            // 
            // lblGeneratorDistribution
            // 
            this.lblGeneratorDistribution.AutoSize = true;
            this.lblGeneratorDistribution.Location = new System.Drawing.Point(6, 16);
            this.lblGeneratorDistribution.Name = "lblGeneratorDistribution";
            this.lblGeneratorDistribution.Size = new System.Drawing.Size(120, 13);
            this.lblGeneratorDistribution.TabIndex = 0;
            this.lblGeneratorDistribution.Text = "Распределение Релея";
            // 
            // lblServiceDistribution
            // 
            this.lblServiceDistribution.AutoSize = true;
            this.lblServiceDistribution.Location = new System.Drawing.Point(6, 28);
            this.lblServiceDistribution.Name = "lblServiceDistribution";
            this.lblServiceDistribution.Size = new System.Drawing.Size(185, 13);
            this.lblServiceDistribution.TabIndex = 1;
            this.lblServiceDistribution.Text = "Экспоненциальное распределение";
            // 
            // lblσ
            // 
            this.lblσ.AutoSize = true;
            this.lblσ.Location = new System.Drawing.Point(6, 46);
            this.lblσ.Name = "lblσ";
            this.lblσ.Size = new System.Drawing.Size(17, 13);
            this.lblσ.TabIndex = 1;
            this.lblσ.Text = "σ:";
            // 
            // lblλ
            // 
            this.lblλ.AutoSize = true;
            this.lblλ.Location = new System.Drawing.Point(6, 57);
            this.lblλ.Name = "lblλ";
            this.lblλ.Size = new System.Drawing.Size(15, 13);
            this.lblλ.TabIndex = 2;
            this.lblλ.Text = "λ:";
            // 
            // tbσ
            // 
            this.tbσ.Location = new System.Drawing.Point(29, 43);
            this.tbσ.Name = "tbσ";
            this.tbσ.Size = new System.Drawing.Size(100, 20);
            this.tbσ.TabIndex = 2;
            // 
            // tbλ
            // 
            this.tbλ.Location = new System.Drawing.Point(29, 54);
            this.tbλ.Name = "tbλ";
            this.tbλ.Size = new System.Drawing.Size(100, 20);
            this.tbλ.TabIndex = 3;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.btnCalculate);
            this.gbResults.Controls.Add(this.lblT);
            this.gbResults.Controls.Add(this.lblT2);
            this.gbResults.Controls.Add(this.lblT1);
            this.gbResults.Controls.Add(this.lblB3);
            this.gbResults.Controls.Add(this.lblB2);
            this.gbResults.Controls.Add(this.lblB1);
            this.gbResults.Controls.Add(this.lblB0);
            this.gbResults.Location = new System.Drawing.Point(218, 12);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(173, 205);
            this.gbResults.TabIndex = 2;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Результаты:";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(29, 69);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 4;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(6, 72);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(18, 13);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "N:";
            // 
            // lblB0
            // 
            this.lblB0.AutoSize = true;
            this.lblB0.Location = new System.Drawing.Point(6, 16);
            this.lblB0.Name = "lblB0";
            this.lblB0.Size = new System.Drawing.Size(22, 13);
            this.lblB0.TabIndex = 0;
            this.lblB0.Text = "b0:";
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(6, 29);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(22, 13);
            this.lblB1.TabIndex = 1;
            this.lblB1.Text = "b1:";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Location = new System.Drawing.Point(6, 42);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(22, 13);
            this.lblB2.TabIndex = 2;
            this.lblB2.Text = "b2:";
            // 
            // lblB3
            // 
            this.lblB3.AutoSize = true;
            this.lblB3.Location = new System.Drawing.Point(6, 55);
            this.lblB3.Name = "lblB3";
            this.lblB3.Size = new System.Drawing.Size(22, 13);
            this.lblB3.TabIndex = 3;
            this.lblB3.Text = "b3:";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(6, 95);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(19, 13);
            this.lblT1.TabIndex = 4;
            this.lblT1.Text = "t1:";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(6, 108);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(19, 13);
            this.lblT2.TabIndex = 5;
            this.lblT2.Text = "t2:";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(6, 142);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(13, 13);
            this.lblT.TabIndex = 6;
            this.lblT.Text = "t:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(92, 176);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 231);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbService);
            this.Controls.Add(this.gbGenerator);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №1";
            this.gbGenerator.ResumeLayout(false);
            this.gbGenerator.PerformLayout();
            this.gbService.ResumeLayout(false);
            this.gbService.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenerator;
        private System.Windows.Forms.GroupBox gbService;
        private System.Windows.Forms.Label lblGeneratorDistribution;
        private System.Windows.Forms.Label lblServiceDistribution;
        private System.Windows.Forms.Label lblσ;
        private System.Windows.Forms.Label lblλ;
        private System.Windows.Forms.TextBox tbσ;
        private System.Windows.Forms.TextBox tbλ;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblB0;
        private System.Windows.Forms.Label lblB3;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Button btnCalculate;
    }
}


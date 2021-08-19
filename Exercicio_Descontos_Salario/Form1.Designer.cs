
namespace Exercicio_Descontos_Salario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIrs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSalFinal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 194);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 39);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(111, 21);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(94, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salario Liquido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desconto Seg Social";
            // 
            // lblSs
            // 
            this.lblSs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSs.Location = new System.Drawing.Point(142, 90);
            this.lblSs.Name = "lblSs";
            this.lblSs.Size = new System.Drawing.Size(63, 23);
            this.lblSs.TabIndex = 4;
            this.lblSs.Text = "label3";
            this.lblSs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desconto Irs";
            // 
            // lblIrs
            // 
            this.lblIrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIrs.Location = new System.Drawing.Point(142, 124);
            this.lblIrs.Name = "lblIrs";
            this.lblIrs.Size = new System.Drawing.Size(63, 23);
            this.lblIrs.TabIndex = 6;
            this.lblIrs.Text = "label5";
            this.lblIrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salario Bruto";
            // 
            // lblSalFinal
            // 
            this.lblSalFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalFinal.Location = new System.Drawing.Point(142, 155);
            this.lblSalFinal.Name = "lblSalFinal";
            this.lblSalFinal.Size = new System.Drawing.Size(63, 23);
            this.lblSalFinal.TabIndex = 8;
            this.lblSalFinal.Text = "label7";
            this.lblSalFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(154, 218);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(57, 39);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(223, 269);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblSalFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIrs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculo Salario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIrs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalFinal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


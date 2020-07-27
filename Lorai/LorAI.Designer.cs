namespace Lorai
{
    partial class LorAI
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.btnDragNDrop = new System.Windows.Forms.Button();
            this.btnAllin = new System.Windows.Forms.Button();
            this.btnRAll = new System.Windows.Forms.Button();
            this.txtBoxArray = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.rdBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(23, 26);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inici&o";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnEmoji
            // 
            this.btnEmoji.Location = new System.Drawing.Point(23, 143);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(75, 23);
            this.btnEmoji.TabIndex = 3;
            this.btnEmoji.Text = "&Emoji";
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // btnDragNDrop
            // 
            this.btnDragNDrop.Location = new System.Drawing.Point(23, 88);
            this.btnDragNDrop.Name = "btnDragNDrop";
            this.btnDragNDrop.Size = new System.Drawing.Size(75, 23);
            this.btnDragNDrop.TabIndex = 4;
            this.btnDragNDrop.Text = "&JogarCarta";
            this.btnDragNDrop.UseVisualStyleBackColor = true;
            this.btnDragNDrop.Click += new System.EventHandler(this.btnDragNDrop_Click);
            // 
            // btnAllin
            // 
            this.btnAllin.Location = new System.Drawing.Point(104, 88);
            this.btnAllin.Name = "btnAllin";
            this.btnAllin.Size = new System.Drawing.Size(75, 23);
            this.btnAllin.TabIndex = 5;
            this.btnAllin.Text = "All-&in";
            this.btnAllin.UseVisualStyleBackColor = true;
            this.btnAllin.Click += new System.EventHandler(this.btnAllin_Click);
            // 
            // btnRAll
            // 
            this.btnRAll.Location = new System.Drawing.Point(185, 88);
            this.btnRAll.Name = "btnRAll";
            this.btnRAll.Size = new System.Drawing.Size(79, 23);
            this.btnRAll.TabIndex = 6;
            this.btnRAll.Text = "&RandomAll-in";
            this.btnRAll.UseVisualStyleBackColor = true;
            this.btnRAll.Click += new System.EventHandler(this.btnRAll_Click);
            // 
            // txtBoxArray
            // 
            this.txtBoxArray.Location = new System.Drawing.Point(104, 28);
            this.txtBoxArray.Name = "txtBoxArray";
            this.txtBoxArray.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArray.TabIndex = 7;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(211, 25);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "Re&place";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(104, 143);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "&Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // rdBtn
            // 
            this.rdBtn.AutoSize = true;
            this.rdBtn.Location = new System.Drawing.Point(185, 146);
            this.rdBtn.Name = "rdBtn";
            this.rdBtn.Size = new System.Drawing.Size(62, 17);
            this.rdBtn.TabIndex = 10;
            this.rdBtn.TabStop = true;
            this.rdBtn.Text = "Achou?";
            this.rdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdBtn.UseVisualStyleBackColor = true;
            // 
            // LorAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.rdBtn);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtBoxArray);
            this.Controls.Add(this.btnRAll);
            this.Controls.Add(this.btnAllin);
            this.Controls.Add(this.btnDragNDrop);
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.btnInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LorAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LorAI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.Button btnDragNDrop;
        private System.Windows.Forms.Button btnAllin;
        private System.Windows.Forms.Button btnRAll;
        private System.Windows.Forms.TextBox txtBoxArray;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.RadioButton rdBtn;
    }
}


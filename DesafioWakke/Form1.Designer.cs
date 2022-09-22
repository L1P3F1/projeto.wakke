namespace DesafioWakke
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDPESSOAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARSELECIONADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCLUIRSELECIONADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            this.oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDPESSOAToolStripMenuItem,
            this.eDITARSELECIONADOToolStripMenuItem,
            this.eXCLUIRSELECIONADOToolStripMenuItem});
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            this.oPÇÕESToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.oPÇÕESToolStripMenuItem.Text = "OPÇÕES";
            // 
            // aDDPESSOAToolStripMenuItem
            // 
            this.aDDPESSOAToolStripMenuItem.Name = "aDDPESSOAToolStripMenuItem";
            this.aDDPESSOAToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aDDPESSOAToolStripMenuItem.Text = "ADICIONAR PESSOA";
            this.aDDPESSOAToolStripMenuItem.Click += new System.EventHandler(this.aDDPESSOAToolStripMenuItem_Click);
            // 
            // eDITARSELECIONADOToolStripMenuItem
            // 
            this.eDITARSELECIONADOToolStripMenuItem.Name = "eDITARSELECIONADOToolStripMenuItem";
            this.eDITARSELECIONADOToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.eDITARSELECIONADOToolStripMenuItem.Text = "EDITAR SELECIONADO";
            this.eDITARSELECIONADOToolStripMenuItem.Click += new System.EventHandler(this.eDITARSELECIONADOToolStripMenuItem_Click);
            // 
            // eXCLUIRSELECIONADOToolStripMenuItem
            // 
            this.eXCLUIRSELECIONADOToolStripMenuItem.Name = "eXCLUIRSELECIONADOToolStripMenuItem";
            this.eXCLUIRSELECIONADOToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.eXCLUIRSELECIONADOToolStripMenuItem.Text = "EXCLUIR SELECIONADO";
            this.eXCLUIRSELECIONADOToolStripMenuItem.Click += new System.EventHandler(this.eXCLUIRSELECIONADOToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 248);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PESSOAS CADASTRADAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(687, 326);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private ToolStripMenuItem aDDPESSOAToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private ToolStripMenuItem eDITARSELECIONADOToolStripMenuItem;
        private ToolStripMenuItem eXCLUIRSELECIONADOToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}
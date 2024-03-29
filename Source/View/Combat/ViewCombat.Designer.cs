﻿namespace RPGMasterTools.Source.View.Character
{
    partial class ViewCombat
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tStripSound = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCombatPanel = new System.Windows.Forms.Panel();
            this.fLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tLayoutMain.SuspendLayout();
            this.tStripSound.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayoutMain
            // 
            this.tLayoutMain.ColumnCount = 1;
            this.tLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutMain.Controls.Add(this.tStripSound, 0, 0);
            this.tLayoutMain.Controls.Add(this.pnlMain, 0, 1);
            this.tLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tLayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutMain.Name = "tLayoutMain";
            this.tLayoutMain.RowCount = 2;
            this.tLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutMain.Size = new System.Drawing.Size(1242, 675);
            this.tLayoutMain.TabIndex = 0;
            // 
            // tStripSound
            // 
            this.tStripSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tStripSound.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tStripSound.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd});
            this.tStripSound.Location = new System.Drawing.Point(0, 0);
            this.tStripSound.Name = "tStripSound";
            this.tStripSound.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tStripSound.Size = new System.Drawing.Size(1242, 49);
            this.tStripSound.TabIndex = 3;
            this.tStripSound.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::RPGMasterTools.Properties.Resources.ico_add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 46);
            this.btnAdd.Text = "New Combat";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMain.Location = new System.Drawing.Point(5, 54);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(1232, 616);
            this.pnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCombatPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1218, 602);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlCombatPanel
            // 
            this.pnlCombatPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCombatPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCombatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCombatPanel.Location = new System.Drawing.Point(405, 0);
            this.pnlCombatPanel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlCombatPanel.Name = "pnlCombatPanel";
            this.pnlCombatPanel.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCombatPanel.Size = new System.Drawing.Size(813, 602);
            this.pnlCombatPanel.TabIndex = 1;
            // 
            // fLayoutPanel
            // 
            this.fLayoutPanel.AutoSize = true;
            this.fLayoutPanel.BackColor = System.Drawing.Color.White;
            this.fLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.fLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.fLayoutPanel.Name = "fLayoutPanel";
            this.fLayoutPanel.Size = new System.Drawing.Size(400, 602);
            this.fLayoutPanel.TabIndex = 2;
            this.fLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.fLayoutPanel_ControlAdded);
            // 
            // ViewCombat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLayoutMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewCombat";
            this.Size = new System.Drawing.Size(1242, 675);
            this.tLayoutMain.ResumeLayout(false);
            this.tLayoutMain.PerformLayout();
            this.tStripSound.ResumeLayout(false);
            this.tStripSound.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStrip tStripSound;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCombatPanel;
        private System.Windows.Forms.FlowLayoutPanel fLayoutPanel;
        private System.Windows.Forms.ToolStripButton btnAdd;
    }
}

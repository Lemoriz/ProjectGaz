namespace Attempt3
{
    partial class MainScreen
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PerformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConstructAGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem1,
            this.EditToolStripMenuItem,
            this.СalculationToolStripMenuItem,
            this.ViewDataBaseToolStripMenuItem,
            this.AboutTheProgramToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(707, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FileStripMenuItem1
            // 
            this.FileStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProjectToolStripMenuItem,
            this.OpenProjectToolStripMenuItem,
            this.SaveProjectToolStripMenuItem,
            this.CloseProjectToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileStripMenuItem1.Name = "FileStripMenuItem1";
            this.FileStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.FileStripMenuItem1.Text = "Файл";
            this.FileStripMenuItem1.Click += new System.EventHandler(this.FileStripMenuItem1_Click);
            // 
            // CreateProjectToolStripMenuItem
            // 
            this.CreateProjectToolStripMenuItem.Name = "CreateProjectToolStripMenuItem";
            this.CreateProjectToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CreateProjectToolStripMenuItem.Text = "Создать проект";
            this.CreateProjectToolStripMenuItem.Click += new System.EventHandler(this.CreateProjectToolStripMenuItem_Click_1);
            // 
            // OpenProjectToolStripMenuItem
            // 
            this.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            this.OpenProjectToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.OpenProjectToolStripMenuItem.Text = "Открыть проект";
            this.OpenProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectToolStripMenuItem_Click_1);
            // 
            // SaveProjectToolStripMenuItem
            // 
            this.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem";
            this.SaveProjectToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.SaveProjectToolStripMenuItem.Text = "Сохранить проект";
            this.SaveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectToolStripMenuItem_Click_1);
            // 
            // CloseProjectToolStripMenuItem
            // 
            this.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem";
            this.CloseProjectToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CloseProjectToolStripMenuItem.Text = "Закрыть проект";
            this.CloseProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItem_Click_1);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // СalculationToolStripMenuItem
            // 
            this.СalculationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PerformToolStripMenuItem,
            this.ConstructAGraphToolStripMenuItem});
            this.СalculationToolStripMenuItem.Name = "СalculationToolStripMenuItem";
            this.СalculationToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.СalculationToolStripMenuItem.Text = "Расчет";
            this.СalculationToolStripMenuItem.Click += new System.EventHandler(this.СalculationToolStripMenuItem_Click);
            // 
            // PerformToolStripMenuItem
            // 
            this.PerformToolStripMenuItem.Name = "PerformToolStripMenuItem";
            this.PerformToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.PerformToolStripMenuItem.Text = "Выполнить";
            this.PerformToolStripMenuItem.Click += new System.EventHandler(this.PerformToolStripMenuItem_Click);
            // 
            // ConstructAGraphToolStripMenuItem
            // 
            this.ConstructAGraphToolStripMenuItem.Name = "ConstructAGraphToolStripMenuItem";
            this.ConstructAGraphToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ConstructAGraphToolStripMenuItem.Text = "Построить график";
            this.ConstructAGraphToolStripMenuItem.Click += new System.EventHandler(this.ConstructAGraphToolStripMenuItem_Click);
            // 
            // ViewDataBaseToolStripMenuItem
            // 
            this.ViewDataBaseToolStripMenuItem.Name = "ViewDataBaseToolStripMenuItem";
            this.ViewDataBaseToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.ViewDataBaseToolStripMenuItem.Text = "Просмотр базы";
            this.ViewDataBaseToolStripMenuItem.Click += new System.EventHandler(this.ViewDataBaseToolStripMenuItem_Click);
            // 
            // AboutTheProgramToolStripMenuItem
            // 
            this.AboutTheProgramToolStripMenuItem.Name = "AboutTheProgramToolStripMenuItem";
            this.AboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutTheProgramToolStripMenuItem.Text = "О программе";
            this.AboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 322);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет интенсивности отказа оборудования";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PerformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConstructAGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewDataBaseToolStripMenuItem;
    }
}


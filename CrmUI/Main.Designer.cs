namespace CrmUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CostumerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.CostumerToolStripMenuItem,
            this.ReceiptToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            this.сущностиToolStripMenuItem.Click += new System.EventHandler(this.СущностиToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductToolStripMenuItem.Text = "Товар";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ТоварToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem1,
            this.вывестиСписокToolStripMenuItem});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellerToolStripMenuItem.Text = "Продавец";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // CostumerToolStripMenuItem
            // 
            this.CostumerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem2,
            this.ShowCustomersToolStripMenuItem});
            this.CostumerToolStripMenuItem.Name = "CostumerToolStripMenuItem";
            this.CostumerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CostumerToolStripMenuItem.Text = "Покупатель";
         
            // 
            // ReceiptToolStripMenuItem
            // 
            this.ReceiptToolStripMenuItem.Name = "ReceiptToolStripMenuItem";
            this.ReceiptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReceiptToolStripMenuItem.Text = "Чек";
            this.ReceiptToolStripMenuItem.Click += new System.EventHandler(this.ReceiptToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem1
            // 
            this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
            this.AddToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem1.Text = "Добавить";
            // 
            // AddToolStripMenuItem2
            // 
            this.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2";
            this.AddToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem2.Text = "Добавить";
            this.AddToolStripMenuItem2.Click += new System.EventHandler(this.AddToolStripMenuItem2_Click);
            // 
            // вывестиСписокToolStripMenuItem
            // 
            this.вывестиСписокToolStripMenuItem.Name = "вывестиСписокToolStripMenuItem";
            this.вывестиСписокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вывестиСписокToolStripMenuItem.Text = "Вывести список";
            // 
            // ShowCustomersToolStripMenuItem
            // 
            this.ShowCustomersToolStripMenuItem.Name = "ShowCustomersToolStripMenuItem";
            this.ShowCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowCustomersToolStripMenuItem.Text = "Вывести список";
            this.ShowCustomersToolStripMenuItem.Click += new System.EventHandler(this.ВывестиСпиToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CostumerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem вывестиСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowCustomersToolStripMenuItem;
    }
}


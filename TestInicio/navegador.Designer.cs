namespace TestInicio
{
    partial class navegador
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
            this.webBrowserTab = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserTab
            // 
            this.webBrowserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTab.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserTab.Location = new System.Drawing.Point(0, 0);
            this.webBrowserTab.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTab.Name = "webBrowserTab";
            this.webBrowserTab.Size = new System.Drawing.Size(800, 450);
            this.webBrowserTab.TabIndex = 0;
            this.webBrowserTab.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserTab);
            this.Name = "navegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab Telefonia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.navegador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserTab;
    }
}
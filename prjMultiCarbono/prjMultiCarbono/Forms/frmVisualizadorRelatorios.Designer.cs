namespace prjMultiCarbono.Forms
{
    partial class frmVisualizadorRelatorios
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
            this.crvInterface = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInterface
            // 
            this.crvInterface.ActiveViewIndex = -1;
            this.crvInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInterface.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInterface.Location = new System.Drawing.Point(0, 0);
            this.crvInterface.Name = "crvInterface";
            this.crvInterface.ShowCloseButton = false;
            this.crvInterface.ShowLogo = false;
            this.crvInterface.Size = new System.Drawing.Size(800, 450);
            this.crvInterface.TabIndex = 0;
            this.crvInterface.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmVisualizadorRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvInterface);
            this.Name = "frmVisualizadorRelatorios";
            this.ShowIcon = false;
            this.Text = "MultiCarbono - ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisualizadorRelatorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInterface;
    }
}
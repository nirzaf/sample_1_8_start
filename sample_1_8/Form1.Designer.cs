namespace sample_1_8 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
      this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // progressBarControl1
      // 
      this.progressBarControl1.EditValue = 60;
      this.progressBarControl1.Location = new System.Drawing.Point(149, 52);
      this.progressBarControl1.Name = "progressBarControl1";
      this.progressBarControl1.Size = new System.Drawing.Size(304, 18);
      this.progressBarControl1.TabIndex = 0;
      // 
      // textEdit1
      // 
      this.textEdit1.EditValue = "Text here";
      this.textEdit1.Location = new System.Drawing.Point(149, 93);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Size = new System.Drawing.Size(304, 20);
      this.textEdit1.TabIndex = 1;
      // 
      // simpleButton1
      // 
      this.simpleButton1.Location = new System.Drawing.Point(378, 150);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(75, 23);
      this.simpleButton1.TabIndex = 2;
      this.simpleButton1.Text = "simpleButton1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.textEdit1);
      this.Controls.Add(this.progressBarControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
  }
}


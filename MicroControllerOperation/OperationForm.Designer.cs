
namespace MicroControllerOperation
{
    partial class OperationForm
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
            this.cmb_PortSelect = new System.Windows.Forms.ComboBox();
            this.btn_PortOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PortUpdate = new System.Windows.Forms.Button();
            this.grpB_PortConnection = new System.Windows.Forms.GroupBox();
            this.btn_Debug = new System.Windows.Forms.Button();
            this.txtB_Debug = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbB_Baudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpB_PortConnection.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_PortSelect
            // 
            this.cmb_PortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PortSelect.FormattingEnabled = true;
            this.cmb_PortSelect.Location = new System.Drawing.Point(103, 29);
            this.cmb_PortSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_PortSelect.Name = "cmb_PortSelect";
            this.cmb_PortSelect.Size = new System.Drawing.Size(230, 23);
            this.cmb_PortSelect.TabIndex = 0;
            // 
            // btn_PortOpen
            // 
            this.btn_PortOpen.Location = new System.Drawing.Point(19, 28);
            this.btn_PortOpen.Name = "btn_PortOpen";
            this.btn_PortOpen.Size = new System.Drawing.Size(78, 25);
            this.btn_PortOpen.TabIndex = 1;
            this.btn_PortOpen.Text = "Open";
            this.btn_PortOpen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_PortUpdate
            // 
            this.btn_PortUpdate.Location = new System.Drawing.Point(339, 29);
            this.btn_PortUpdate.Name = "btn_PortUpdate";
            this.btn_PortUpdate.Size = new System.Drawing.Size(78, 25);
            this.btn_PortUpdate.TabIndex = 3;
            this.btn_PortUpdate.Text = "Update";
            this.btn_PortUpdate.UseVisualStyleBackColor = true;
            // 
            // grpB_PortConnection
            // 
            this.grpB_PortConnection.Controls.Add(this.btn_PortUpdate);
            this.grpB_PortConnection.Controls.Add(this.button1);
            this.grpB_PortConnection.Controls.Add(this.btn_PortOpen);
            this.grpB_PortConnection.Controls.Add(this.cmb_PortSelect);
            this.grpB_PortConnection.Location = new System.Drawing.Point(6, 6);
            this.grpB_PortConnection.Name = "grpB_PortConnection";
            this.grpB_PortConnection.Size = new System.Drawing.Size(440, 105);
            this.grpB_PortConnection.TabIndex = 4;
            this.grpB_PortConnection.TabStop = false;
            this.grpB_PortConnection.Text = "ポート";
            // 
            // btn_Debug
            // 
            this.btn_Debug.Location = new System.Drawing.Point(487, 497);
            this.btn_Debug.Name = "btn_Debug";
            this.btn_Debug.Size = new System.Drawing.Size(78, 25);
            this.btn_Debug.TabIndex = 4;
            this.btn_Debug.Text = "デバッグ";
            this.btn_Debug.UseVisualStyleBackColor = true;
            this.btn_Debug.Click += new System.EventHandler(this.btn_Debug_Click);
            // 
            // txtB_Debug
            // 
            this.txtB_Debug.Location = new System.Drawing.Point(594, 421);
            this.txtB_Debug.Multiline = true;
            this.txtB_Debug.Name = "txtB_Debug";
            this.txtB_Debug.Size = new System.Drawing.Size(323, 129);
            this.txtB_Debug.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 361);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpB_PortConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UART";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbB_Baudrate);
            this.groupBox1.Location = new System.Drawing.Point(471, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 300);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通信設定";
            // 
            // cmbB_Baudrate
            // 
            this.cmbB_Baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbB_Baudrate.FormattingEnabled = true;
            this.cmbB_Baudrate.Location = new System.Drawing.Point(107, 48);
            this.cmbB_Baudrate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbB_Baudrate.Name = "cmbB_Baudrate";
            this.cmbB_Baudrate.Size = new System.Drawing.Size(230, 23);
            this.cmbB_Baudrate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "通信速度";
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtB_Debug);
            this.Controls.Add(this.btn_Debug);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OperationForm";
            this.Text = "操作画面";
            this.grpB_PortConnection.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_PortSelect;
        private System.Windows.Forms.Button btn_PortOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_PortUpdate;
        private System.Windows.Forms.GroupBox grpB_PortConnection;
        private System.Windows.Forms.Button btn_Debug;
        private System.Windows.Forms.TextBox txtB_Debug;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbB_Baudrate;
    }
}


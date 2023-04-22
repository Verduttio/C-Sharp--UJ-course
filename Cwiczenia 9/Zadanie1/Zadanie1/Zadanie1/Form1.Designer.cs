
namespace Zadanie1
{
    partial class TextAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAnalyzer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.countsLabel = new System.Windows.Forms.Label();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxErrors = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCounts = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.countsLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxErrors, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxCounts, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonVerify, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.errorsLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.759124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.24088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // countsLabel
            // 
            this.countsLabel.AutoSize = true;
            this.countsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countsLabel.Location = new System.Drawing.Point(525, 0);
            this.countsLabel.Name = "countsLabel";
            this.countsLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.countsLabel.Size = new System.Drawing.Size(96, 25);
            this.countsLabel.TabIndex = 5;
            this.countsLabel.Text = "Counts:";
            this.countsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.Location = new System.Drawing.Point(20, 35);
            this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(238, 327);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // richTextBoxErrors
            // 
            this.richTextBoxErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxErrors.Location = new System.Drawing.Point(281, 35);
            this.richTextBoxErrors.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.richTextBoxErrors.Name = "richTextBoxErrors";
            this.richTextBoxErrors.ReadOnly = true;
            this.richTextBoxErrors.Size = new System.Drawing.Size(238, 327);
            this.richTextBoxErrors.TabIndex = 1;
            this.richTextBoxErrors.Text = "";
            // 
            // richTextBoxCounts
            // 
            this.richTextBoxCounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCounts.Location = new System.Drawing.Point(542, 35);
            this.richTextBoxCounts.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.richTextBoxCounts.Name = "richTextBoxCounts";
            this.richTextBoxCounts.ReadOnly = true;
            this.richTextBoxCounts.Size = new System.Drawing.Size(239, 327);
            this.richTextBoxCounts.TabIndex = 2;
            this.richTextBoxCounts.Text = "";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputLabel.Location = new System.Drawing.Point(3, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inputLabel.Size = new System.Drawing.Size(122, 25);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Input text:";
            this.inputLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonVerify.Location = new System.Drawing.Point(164, 368);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(94, 29);
            this.buttonVerify.TabIndex = 6;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorsLabel.Location = new System.Drawing.Point(264, 0);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.errorsLabel.Size = new System.Drawing.Size(87, 25);
            this.errorsLabel.TabIndex = 4;
            this.errorsLabel.Text = "Errors:";
            this.errorsLabel.Click += new System.EventHandler(this.errorsLabel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.27778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.722222F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(10, 416);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 24);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // TextAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "TextAnalyzer";
            this.Text = "Text analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxErrors;
        private System.Windows.Forms.RichTextBox richTextBoxCounts;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label countsLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


namespace Course_MathCalculate
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelInfoEntry = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.tablePrint = new System.Windows.Forms.TableLayoutPanel();
            this.labelFirstColumnIndex = new System.Windows.Forms.Label();
            this.labelFirstColumnValue = new System.Windows.Forms.Label();
            this.labelSecondColumnIndex = new System.Windows.Forms.Label();
            this.labelSecondColumnValue = new System.Windows.Forms.Label();
            this.labelThirdColumnIndex = new System.Windows.Forms.Label();
            this.labelThirdColumnValue = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tablePrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tablePrint);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.buttonHistory);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonCalculate);
            this.panel2.Controls.Add(this.labelInfoEntry);
            this.panel2.Controls.Add(this.textBoxExpression);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 113);
            this.panel2.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClear.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(660, 74);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 36);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear Solution";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCalculate.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(348, 74);
            this.buttonCalculate.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelInfoEntry
            // 
            this.labelInfoEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfoEntry.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoEntry.Location = new System.Drawing.Point(0, 0);
            this.labelInfoEntry.Name = "labelInfoEntry";
            this.labelInfoEntry.Padding = new System.Windows.Forms.Padding(5);
            this.labelInfoEntry.Size = new System.Drawing.Size(800, 33);
            this.labelInfoEntry.TabIndex = 0;
            this.labelInfoEntry.Text = "Write your expression";
            this.labelInfoEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxExpression.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpression.Location = new System.Drawing.Point(248, 39);
            this.textBoxExpression.MaximumSize = new System.Drawing.Size(300, 30);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(300, 30);
            this.textBoxExpression.TabIndex = 1;
            // 
            // tablePrint
            // 
            this.tablePrint.ColumnCount = 3;
            this.tablePrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePrint.Controls.Add(this.labelFirstColumnIndex, 0, 0);
            this.tablePrint.Controls.Add(this.labelFirstColumnValue, 0, 1);
            this.tablePrint.Controls.Add(this.labelSecondColumnIndex, 1, 0);
            this.tablePrint.Controls.Add(this.labelSecondColumnValue, 1, 1);
            this.tablePrint.Controls.Add(this.labelThirdColumnIndex, 2, 0);
            this.tablePrint.Controls.Add(this.labelThirdColumnValue, 2, 1);
            this.tablePrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePrint.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tablePrint.Location = new System.Drawing.Point(0, 113);
            this.tablePrint.Margin = new System.Windows.Forms.Padding(10);
            this.tablePrint.Name = "tablePrint";
            this.tablePrint.Padding = new System.Windows.Forms.Padding(10);
            this.tablePrint.RowCount = 2;
            this.tablePrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePrint.Size = new System.Drawing.Size(800, 337);
            this.tablePrint.TabIndex = 4;
            // 
            // labelFirstColumnIndex
            // 
            this.labelFirstColumnIndex.AutoSize = true;
            this.labelFirstColumnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirstColumnIndex.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstColumnIndex.Location = new System.Drawing.Point(15, 15);
            this.labelFirstColumnIndex.Margin = new System.Windows.Forms.Padding(5);
            this.labelFirstColumnIndex.Name = "labelFirstColumnIndex";
            this.labelFirstColumnIndex.Size = new System.Drawing.Size(249, 148);
            this.labelFirstColumnIndex.TabIndex = 0;
            this.labelFirstColumnIndex.Text = "label1";
            this.labelFirstColumnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstColumnValue
            // 
            this.labelFirstColumnValue.AutoSize = true;
            this.labelFirstColumnValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirstColumnValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstColumnValue.Location = new System.Drawing.Point(15, 173);
            this.labelFirstColumnValue.Margin = new System.Windows.Forms.Padding(5);
            this.labelFirstColumnValue.Name = "labelFirstColumnValue";
            this.labelFirstColumnValue.Size = new System.Drawing.Size(249, 149);
            this.labelFirstColumnValue.TabIndex = 1;
            this.labelFirstColumnValue.Text = "label2";
            this.labelFirstColumnValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFirstColumnValue.Visible = false;
            // 
            // labelSecondColumnIndex
            // 
            this.labelSecondColumnIndex.AutoSize = true;
            this.labelSecondColumnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSecondColumnIndex.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondColumnIndex.Location = new System.Drawing.Point(274, 15);
            this.labelSecondColumnIndex.Margin = new System.Windows.Forms.Padding(5);
            this.labelSecondColumnIndex.Name = "labelSecondColumnIndex";
            this.labelSecondColumnIndex.Size = new System.Drawing.Size(249, 148);
            this.labelSecondColumnIndex.TabIndex = 2;
            this.labelSecondColumnIndex.Text = "label3";
            this.labelSecondColumnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondColumnValue
            // 
            this.labelSecondColumnValue.AutoSize = true;
            this.labelSecondColumnValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSecondColumnValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondColumnValue.Location = new System.Drawing.Point(274, 173);
            this.labelSecondColumnValue.Margin = new System.Windows.Forms.Padding(5);
            this.labelSecondColumnValue.Name = "labelSecondColumnValue";
            this.labelSecondColumnValue.Size = new System.Drawing.Size(249, 149);
            this.labelSecondColumnValue.TabIndex = 3;
            this.labelSecondColumnValue.Text = "label4";
            this.labelSecondColumnValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSecondColumnValue.Visible = false;
            // 
            // labelThirdColumnIndex
            // 
            this.labelThirdColumnIndex.AutoSize = true;
            this.labelThirdColumnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelThirdColumnIndex.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThirdColumnIndex.Location = new System.Drawing.Point(533, 15);
            this.labelThirdColumnIndex.Margin = new System.Windows.Forms.Padding(5);
            this.labelThirdColumnIndex.Name = "labelThirdColumnIndex";
            this.labelThirdColumnIndex.Size = new System.Drawing.Size(252, 148);
            this.labelThirdColumnIndex.TabIndex = 4;
            this.labelThirdColumnIndex.Text = "label5";
            this.labelThirdColumnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThirdColumnValue
            // 
            this.labelThirdColumnValue.AutoSize = true;
            this.labelThirdColumnValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelThirdColumnValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThirdColumnValue.Location = new System.Drawing.Point(533, 173);
            this.labelThirdColumnValue.Margin = new System.Windows.Forms.Padding(5);
            this.labelThirdColumnValue.Name = "labelThirdColumnValue";
            this.labelThirdColumnValue.Size = new System.Drawing.Size(252, 149);
            this.labelThirdColumnValue.TabIndex = 5;
            this.labelThirdColumnValue.Text = "label6";
            this.labelThirdColumnValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelThirdColumnValue.Visible = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHistory.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistory.Location = new System.Drawing.Point(660, 12);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(104, 36);
            this.buttonHistory.TabIndex = 4;
            this.buttonHistory.Text = "View History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tablePrint.ResumeLayout(false);
            this.tablePrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfoEntry;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TableLayoutPanel tablePrint;
        private System.Windows.Forms.Label labelFirstColumnIndex;
        private System.Windows.Forms.Label labelFirstColumnValue;
        private System.Windows.Forms.Label labelSecondColumnIndex;
        private System.Windows.Forms.Label labelSecondColumnValue;
        private System.Windows.Forms.Label labelThirdColumnIndex;
        private System.Windows.Forms.Label labelThirdColumnValue;
        private System.Windows.Forms.Button buttonHistory;
    }
}
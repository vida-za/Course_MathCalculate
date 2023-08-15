namespace Course_MathCalculate
{
    partial class HistoryForm
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
            this.panelBackgroud = new System.Windows.Forms.Panel();
            this.tableLayoutPanelValues = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tableLayoutPanelIndexes = new System.Windows.Forms.TableLayoutPanel();
            this.labelThirdColumnIndex = new System.Windows.Forms.Label();
            this.labelSecondColumnIndex = new System.Windows.Forms.Label();
            this.labelFirstColumnIndex = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelBackgroud.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanelIndexes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackgroud
            // 
            this.panelBackgroud.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBackgroud.Controls.Add(this.tableLayoutPanelValues);
            this.panelBackgroud.Controls.Add(this.panelHeader);
            this.panelBackgroud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackgroud.Location = new System.Drawing.Point(0, 0);
            this.panelBackgroud.Name = "panelBackgroud";
            this.panelBackgroud.Size = new System.Drawing.Size(800, 450);
            this.panelBackgroud.TabIndex = 0;
            // 
            // tableLayoutPanelValues
            // 
            this.tableLayoutPanelValues.AutoScroll = true;
            this.tableLayoutPanelValues.AutoSize = true;
            this.tableLayoutPanelValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelValues.ColumnCount = 3;
            this.tableLayoutPanelValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelValues.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanelValues.Name = "tableLayoutPanelValues";
            this.tableLayoutPanelValues.RowCount = 1;
            this.tableLayoutPanelValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanelValues.Size = new System.Drawing.Size(800, 350);
            this.tableLayoutPanelValues.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelHeader.Controls.Add(this.buttonReset);
            this.panelHeader.Controls.Add(this.tableLayoutPanelIndexes);
            this.panelHeader.Controls.Add(this.buttonBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.MaximumSize = new System.Drawing.Size(0, 100);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(405, 5);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(5);
            this.buttonReset.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonReset.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 30);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tableLayoutPanelIndexes
            // 
            this.tableLayoutPanelIndexes.ColumnCount = 3;
            this.tableLayoutPanelIndexes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIndexes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIndexes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIndexes.Controls.Add(this.labelThirdColumnIndex, 2, 0);
            this.tableLayoutPanelIndexes.Controls.Add(this.labelSecondColumnIndex, 1, 0);
            this.tableLayoutPanelIndexes.Controls.Add(this.labelFirstColumnIndex, 0, 0);
            this.tableLayoutPanelIndexes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelIndexes.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanelIndexes.Name = "tableLayoutPanelIndexes";
            this.tableLayoutPanelIndexes.RowCount = 1;
            this.tableLayoutPanelIndexes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelIndexes.Size = new System.Drawing.Size(800, 40);
            this.tableLayoutPanelIndexes.TabIndex = 4;
            // 
            // labelThirdColumnIndex
            // 
            this.labelThirdColumnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelThirdColumnIndex.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThirdColumnIndex.Location = new System.Drawing.Point(537, 5);
            this.labelThirdColumnIndex.Margin = new System.Windows.Forms.Padding(5);
            this.labelThirdColumnIndex.Name = "labelThirdColumnIndex";
            this.labelThirdColumnIndex.Size = new System.Drawing.Size(258, 30);
            this.labelThirdColumnIndex.TabIndex = 3;
            this.labelThirdColumnIndex.Text = "Result";
            this.labelThirdColumnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondColumnIndex
            // 
            this.labelSecondColumnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSecondColumnIndex.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondColumnIndex.Location = new System.Drawing.Point(271, 5);
            this.labelSecondColumnIndex.Margin = new System.Windows.Forms.Padding(5);
            this.labelSecondColumnIndex.Name = "labelSecondColumnIndex";
            this.labelSecondColumnIndex.Size = new System.Drawing.Size(256, 30);
            this.labelSecondColumnIndex.TabIndex = 2;
            this.labelSecondColumnIndex.Text = "Postfix form";
            this.labelSecondColumnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstColumnIndex
            // 
            this.labelFirstColumnIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirstColumnIndex.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstColumnIndex.Location = new System.Drawing.Point(5, 5);
            this.labelFirstColumnIndex.Margin = new System.Windows.Forms.Padding(5);
            this.labelFirstColumnIndex.Name = "labelFirstColumnIndex";
            this.labelFirstColumnIndex.Size = new System.Drawing.Size(256, 30);
            this.labelFirstColumnIndex.TabIndex = 1;
            this.labelFirstColumnIndex.Text = "Expression";
            this.labelFirstColumnIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1095, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBack.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonBack.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 30);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back to Calc";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackgroud);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.panelBackgroud.ResumeLayout(false);
            this.panelBackgroud.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanelIndexes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackgroud;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelValues;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIndexes;
        private System.Windows.Forms.Label labelThirdColumnIndex;
        private System.Windows.Forms.Label labelSecondColumnIndex;
        private System.Windows.Forms.Label labelFirstColumnIndex;
        private System.Windows.Forms.Button buttonReset;
    }
}
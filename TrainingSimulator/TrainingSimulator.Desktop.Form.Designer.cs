using System.Windows.Forms;

namespace TrainingSimulator
{
    partial class TrainingSimulatorForm
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
            this.mapPanel = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.ColumnCount = 3;
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33331F));
            this.mapPanel.Location = new System.Drawing.Point(13, 13);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.RowCount = 4;
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.Size = new System.Drawing.Size(428, 539);
            this.mapPanel.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(745, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(236, 165);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // upButton
            // 
            this.upButton.BackgroundImage = global::TrainingSimulator.Properties.Resources.arrow;
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upButton.Location = new System.Drawing.Point(560, 298);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(60, 60);
            this.upButton.TabIndex = 2;
            this.upButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackgroundImage = global::TrainingSimulator.Properties.Resources.arrow;
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftButton.Location = new System.Drawing.Point(494, 364);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(60, 60);
            this.leftButton.TabIndex = 2;
            this.leftButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackgroundImage = global::TrainingSimulator.Properties.Resources.arrow;
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightButton.Location = new System.Drawing.Point(626, 364);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(60, 60);
            this.rightButton.TabIndex = 2;
            this.rightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // downButton
            // 
            this.downButton.BackgroundImage = global::TrainingSimulator.Properties.Resources.arrow;
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downButton.Location = new System.Drawing.Point(560, 430);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(60, 60);
            this.downButton.TabIndex = 2;
            this.downButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainingSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 642);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.mapPanel);
            this.Name = "TrainingSimulatorForm";
            this.Text = "chrome";
            this.Load += new System.EventHandler(this.TrainingSimulatorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mapPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Button upButton;
        private Button leftButton;
        private Button rightButton;
        private Button downButton;
    }
}


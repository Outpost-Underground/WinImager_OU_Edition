namespace WinImager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonCreateImage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDownChunkMB;
        private System.Windows.Forms.Label labelChunkSize;
        private System.Windows.Forms.CheckBox checkBoxGentle;
        private System.Windows.Forms.CheckBox checkBoxComputeHashes;
        private System.Windows.Forms.ProgressBar progressBarHash;
        private System.Windows.Forms.Label labelHashProgress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))            
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonCreateImage = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDownChunkMB = new System.Windows.Forms.NumericUpDown();
            this.labelChunkSize = new System.Windows.Forms.Label();
            this.checkBoxGentle = new System.Windows.Forms.CheckBox();
            this.checkBoxComputeHashes = new System.Windows.Forms.CheckBox();
            this.progressBarHash = new System.Windows.Forms.ProgressBar();
            this.labelHashProgress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChunkMB)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxDrives.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrives.Location = new System.Drawing.Point(12, 53);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(348, 24);
            this.comboBoxDrives.TabIndex = 0;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.Location = new System.Drawing.Point(12, 102);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(316, 22);
            this.textBoxDestination.TabIndex = 1;
            this.textBoxDestination.Text = "Destination Directory";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(334, 103);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 21);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonCreateImage
            // 
            this.buttonCreateImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateImage.Location = new System.Drawing.Point(36, 227);
            this.buttonCreateImage.Name = "buttonCreateImage";
            this.buttonCreateImage.Size = new System.Drawing.Size(351, 28);
            this.buttonCreateImage.TabIndex = 3;
            this.buttonCreateImage.Text = "Create Disk Image";
            this.buttonCreateImage.UseVisualStyleBackColor = false;
            this.buttonCreateImage.Click += new System.EventHandler(this.buttonCreateImage_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(12, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(12, 306);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(80, 18);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "Progress: ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // numericUpDownChunkMB
            // 
            this.numericUpDownChunkMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownChunkMB.Location = new System.Drawing.Point(125, 143);
            this.numericUpDownChunkMB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChunkMB.Name = "numericUpDownChunkMB";
            this.numericUpDownChunkMB.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownChunkMB.TabIndex = 6;
            this.numericUpDownChunkMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownChunkMB.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownChunkMB.ValueChanged += new System.EventHandler(this.numericUpDownChunkMB_ValueChanged);
            // 
            // labelChunkSize
            // 
            this.labelChunkSize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelChunkSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelChunkSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChunkSize.Location = new System.Drawing.Point(12, 143);
            this.labelChunkSize.MaximumSize = new System.Drawing.Size(107, 30);
            this.labelChunkSize.Name = "labelChunkSize";
            this.labelChunkSize.Size = new System.Drawing.Size(107, 22);
            this.labelChunkSize.TabIndex = 7;
            this.labelChunkSize.Text = "Chunk (MB)   : ";
            this.labelChunkSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxGentle
            // 
            this.checkBoxGentle.AutoSize = true;
            this.checkBoxGentle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBoxGentle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGentle.Location = new System.Drawing.Point(14, 179);
            this.checkBoxGentle.Name = "checkBoxGentle";
            this.checkBoxGentle.Size = new System.Drawing.Size(114, 20);
            this.checkBoxGentle.TabIndex = 8;
            this.checkBoxGentle.Text = "Gentle Mode";
            this.checkBoxGentle.UseVisualStyleBackColor = true;
            // 
            // checkBoxComputeHashes
            // 
            this.checkBoxComputeHashes.AutoSize = true;
            this.checkBoxComputeHashes.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxComputeHashes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBoxComputeHashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComputeHashes.Location = new System.Drawing.Point(146, 179);
            this.checkBoxComputeHashes.Name = "checkBoxComputeHashes";
            this.checkBoxComputeHashes.Size = new System.Drawing.Size(169, 20);
            this.checkBoxComputeHashes.TabIndex = 9;
            this.checkBoxComputeHashes.Text = "Compute MD5 & SHA1";
            this.checkBoxComputeHashes.UseVisualStyleBackColor = false;
            // 
            // progressBarHash
            // 
            this.progressBarHash.Location = new System.Drawing.Point(12, 351);
            this.progressBarHash.MaximumSize = new System.Drawing.Size(400, 23);
            this.progressBarHash.MinimumSize = new System.Drawing.Size(350, 23);
            this.progressBarHash.Name = "progressBarHash";
            this.progressBarHash.Size = new System.Drawing.Size(400, 23);
            this.progressBarHash.TabIndex = 10;
            // 
            // labelHashProgress
            // 
            this.labelHashProgress.AutoSize = true;
            this.labelHashProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelHashProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHashProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHashProgress.Location = new System.Drawing.Point(12, 377);
            this.labelHashProgress.Name = "labelHashProgress";
            this.labelHashProgress.Size = new System.Drawing.Size(116, 18);
            this.labelHashProgress.TabIndex = 11;
            this.labelHashProgress.Text = "Hash Progress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select source from the following available drives:";
            // 
            // MainForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxComputeHashes);
            this.Controls.Add(this.checkBoxGentle);
            this.Controls.Add(this.labelChunkSize);
            this.Controls.Add(this.numericUpDownChunkMB);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCreateImage);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.progressBarHash);
            this.Controls.Add(this.labelHashProgress);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "WinImager v1.0 - Outpost Edition";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChunkMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}


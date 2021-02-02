namespace Inkumbulabuso_ML_App
{
    partial class Form1
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(12, 12);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(444, 426);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(621, 148);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(169, 137);
            this.picDetected.TabIndex = 1;
            this.picDetected.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(619, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(169, 31);
            this.btnCapture.TabIndex = 2;
            this.btnCapture.Text = "Start";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(619, 49);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(169, 33);
            this.btnDetectFaces.TabIndex = 3;
            this.btnDetectFaces.Text = "Detect Face";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(621, 371);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(169, 27);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(621, 404);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(169, 34);
            this.btnRecognize.TabIndex = 6;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(622, 305);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(168, 22);
            this.txtPersonName.TabIndex = 7;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(619, 88);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(168, 36);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 196);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(462, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 207);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


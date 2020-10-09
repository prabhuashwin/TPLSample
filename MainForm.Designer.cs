namespace TasksInDotNet
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
            this.btnNormalThreading = new System.Windows.Forms.Button();
            this.btnSumUsingFor = new System.Windows.Forms.Button();
            this.btnWithSync = new System.Windows.Forms.Button();
            this.btnWithTasks = new System.Windows.Forms.Button();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnTasksWithCancellation = new System.Windows.Forms.Button();
            this.btnCancelTasks = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnUpdateUiControl = new System.Windows.Forms.Button();
            this.btnUpdateUiTpl = new System.Windows.Forms.Button();
            this.btnLongRunningWork = new System.Windows.Forms.Button();
            this.btnLongWorkWithThreading = new System.Windows.Forms.Button();
            this.btnLongWorkWithThreadpool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormalThreading
            // 
            this.btnNormalThreading.Location = new System.Drawing.Point(12, 55);
            this.btnNormalThreading.Name = "btnNormalThreading";
            this.btnNormalThreading.Size = new System.Drawing.Size(244, 23);
            this.btnNormalThreading.TabIndex = 0;
            this.btnNormalThreading.Text = "Multi-Threading without thread Synchronization";
            this.btnNormalThreading.UseVisualStyleBackColor = true;
            this.btnNormalThreading.Click += new System.EventHandler(this.btnNormalThreading_Click);
            // 
            // btnSumUsingFor
            // 
            this.btnSumUsingFor.Location = new System.Drawing.Point(12, 12);
            this.btnSumUsingFor.Name = "btnSumUsingFor";
            this.btnSumUsingFor.Size = new System.Drawing.Size(244, 23);
            this.btnSumUsingFor.TabIndex = 1;
            this.btnSumUsingFor.Text = "Sum Using Simple For Loop";
            this.btnSumUsingFor.UseVisualStyleBackColor = true;
            this.btnSumUsingFor.Click += new System.EventHandler(this.btnSumUsingFor_Click);
            // 
            // btnWithSync
            // 
            this.btnWithSync.Location = new System.Drawing.Point(12, 96);
            this.btnWithSync.Name = "btnWithSync";
            this.btnWithSync.Size = new System.Drawing.Size(244, 23);
            this.btnWithSync.TabIndex = 2;
            this.btnWithSync.Text = "Multi-Threading With Synchronization";
            this.btnWithSync.UseVisualStyleBackColor = true;
            this.btnWithSync.Click += new System.EventHandler(this.btnWithSync_Click);
            // 
            // btnWithTasks
            // 
            this.btnWithTasks.Location = new System.Drawing.Point(12, 144);
            this.btnWithTasks.Name = "btnWithTasks";
            this.btnWithTasks.Size = new System.Drawing.Size(244, 23);
            this.btnWithTasks.TabIndex = 3;
            this.btnWithTasks.Text = "Multi-Threading with Tasks in TPL";
            this.btnWithTasks.UseVisualStyleBackColor = true;
            this.btnWithTasks.Click += new System.EventHandler(this.btnWithTasks_Click);
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(69, 247);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 4;
            this.btnClickMe.Text = "Click Me!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnTasksWithCancellation
            // 
            this.btnTasksWithCancellation.Location = new System.Drawing.Point(12, 189);
            this.btnTasksWithCancellation.Name = "btnTasksWithCancellation";
            this.btnTasksWithCancellation.Size = new System.Drawing.Size(244, 23);
            this.btnTasksWithCancellation.TabIndex = 5;
            this.btnTasksWithCancellation.Text = "Tasks with Cancellation";
            this.btnTasksWithCancellation.UseVisualStyleBackColor = true;
            this.btnTasksWithCancellation.Click += new System.EventHandler(this.btnTasksWithCancellation_Click);
            // 
            // btnCancelTasks
            // 
            this.btnCancelTasks.Location = new System.Drawing.Point(170, 247);
            this.btnCancelTasks.Name = "btnCancelTasks";
            this.btnCancelTasks.Size = new System.Drawing.Size(110, 23);
            this.btnCancelTasks.TabIndex = 6;
            this.btnCancelTasks.Text = "Cancel Tasks";
            this.btnCancelTasks.UseVisualStyleBackColor = true;
            this.btnCancelTasks.Click += new System.EventHandler(this.btnCancelTasks_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(498, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(322, 195);
            this.lblTotal.TabIndex = 7;
            // 
            // btnUpdateUiControl
            // 
            this.btnUpdateUiControl.Location = new System.Drawing.Point(276, 12);
            this.btnUpdateUiControl.Name = "btnUpdateUiControl";
            this.btnUpdateUiControl.Size = new System.Drawing.Size(200, 23);
            this.btnUpdateUiControl.TabIndex = 8;
            this.btnUpdateUiControl.Text = "Update UI Control from background";
            this.btnUpdateUiControl.UseVisualStyleBackColor = true;
            this.btnUpdateUiControl.Click += new System.EventHandler(this.btnUpdateUiControl_Click);
            // 
            // btnUpdateUiTpl
            // 
            this.btnUpdateUiTpl.Location = new System.Drawing.Point(276, 55);
            this.btnUpdateUiTpl.Name = "btnUpdateUiTpl";
            this.btnUpdateUiTpl.Size = new System.Drawing.Size(200, 23);
            this.btnUpdateUiTpl.TabIndex = 9;
            this.btnUpdateUiTpl.Text = "Update UI With Summation - TPL";
            this.btnUpdateUiTpl.UseVisualStyleBackColor = true;
            this.btnUpdateUiTpl.Click += new System.EventHandler(this.btnUpdateUiTpl_Click);
            // 
            // btnLongRunningWork
            // 
            this.btnLongRunningWork.Location = new System.Drawing.Point(276, 96);
            this.btnLongRunningWork.Name = "btnLongRunningWork";
            this.btnLongRunningWork.Size = new System.Drawing.Size(200, 23);
            this.btnLongRunningWork.TabIndex = 10;
            this.btnLongRunningWork.Text = "Start Long Running Work";
            this.btnLongRunningWork.UseVisualStyleBackColor = true;
            this.btnLongRunningWork.Click += new System.EventHandler(this.btnLongRunningWork_Click);
            // 
            // btnLongWorkWithThreading
            // 
            this.btnLongWorkWithThreading.Location = new System.Drawing.Point(276, 144);
            this.btnLongWorkWithThreading.Name = "btnLongWorkWithThreading";
            this.btnLongWorkWithThreading.Size = new System.Drawing.Size(200, 23);
            this.btnLongWorkWithThreading.TabIndex = 11;
            this.btnLongWorkWithThreading.Text = "Long work with Threading";
            this.btnLongWorkWithThreading.UseVisualStyleBackColor = true;
            this.btnLongWorkWithThreading.Click += new System.EventHandler(this.btnLongWorkWithThreading_Click);
            // 
            // btnLongWorkWithThreadpool
            // 
            this.btnLongWorkWithThreadpool.Location = new System.Drawing.Point(276, 189);
            this.btnLongWorkWithThreadpool.Name = "btnLongWorkWithThreadpool";
            this.btnLongWorkWithThreadpool.Size = new System.Drawing.Size(200, 23);
            this.btnLongWorkWithThreadpool.TabIndex = 12;
            this.btnLongWorkWithThreadpool.Text = "Long work with Threadpool";
            this.btnLongWorkWithThreadpool.UseVisualStyleBackColor = true;
            this.btnLongWorkWithThreadpool.Click += new System.EventHandler(this.btnLongWorkWithThreadpool_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 307);
            this.Controls.Add(this.btnLongWorkWithThreadpool);
            this.Controls.Add(this.btnLongWorkWithThreading);
            this.Controls.Add(this.btnLongRunningWork);
            this.Controls.Add(this.btnUpdateUiTpl);
            this.Controls.Add(this.btnUpdateUiControl);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelTasks);
            this.Controls.Add(this.btnTasksWithCancellation);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.btnWithTasks);
            this.Controls.Add(this.btnWithSync);
            this.Controls.Add(this.btnSumUsingFor);
            this.Controls.Add(this.btnNormalThreading);
            this.Name = "MainForm";
            this.Text = "Tasks in .Net";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormalThreading;
        private System.Windows.Forms.Button btnSumUsingFor;
        private System.Windows.Forms.Button btnWithSync;
        private System.Windows.Forms.Button btnWithTasks;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnTasksWithCancellation;
        private System.Windows.Forms.Button btnCancelTasks;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnUpdateUiControl;
        private System.Windows.Forms.Button btnUpdateUiTpl;
        private System.Windows.Forms.Button btnLongRunningWork;
        private System.Windows.Forms.Button btnLongWorkWithThreading;
        private System.Windows.Forms.Button btnLongWorkWithThreadpool;
    }
}


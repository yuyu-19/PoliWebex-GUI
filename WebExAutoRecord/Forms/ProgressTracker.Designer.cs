﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PoliDLGUI.Forms
{
    [DesignerGenerated()]
    public partial class ProgressTracker : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OverallProgressCompleted = new System.Windows.Forms.ProgressBar();
            this.FileNum = new System.Windows.Forms.Label();
            this.DLspeed = new System.Windows.Forms.Label();
            this._Timer = new System.Windows.Forms.Timer(this.components);
            this.l1 = new System.Windows.Forms.Label();
            this.WorkingOnItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OverallProgressCompleted
            // 
            this.OverallProgressCompleted.Location = new System.Drawing.Point(12, 37);
            this.OverallProgressCompleted.Name = "OverallProgressCompleted";
            this.OverallProgressCompleted.Size = new System.Drawing.Size(424, 23);
            this.OverallProgressCompleted.TabIndex = 0;
            // 
            // FileNum
            // 
            this.FileNum.AutoSize = true;
            this.FileNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNum.Location = new System.Drawing.Point(7, 9);
            this.FileNum.Name = "FileNum";
            this.FileNum.Size = new System.Drawing.Size(88, 25);
            this.FileNum.TabIndex = 1;
            this.FileNum.Text = "File X/Y";
            // 
            // DLspeed
            // 
            this.DLspeed.AutoSize = true;
            this.DLspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLspeed.Location = new System.Drawing.Point(337, 9);
            this.DLspeed.Name = "DLspeed";
            this.DLspeed.Size = new System.Drawing.Size(0, 25);
            this.DLspeed.TabIndex = 2;
            // 
            // _Timer
            // 
            this._Timer.Enabled = true;
            this._Timer.Interval = 500;
            this._Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(12, 97);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(121, 25);
            this.l1.TabIndex = 3;
            this.l1.Text = "Working on";
            // 
            // WorkingOnItems
            // 
            this.WorkingOnItems.AutoSize = true;
            this.WorkingOnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingOnItems.Location = new System.Drawing.Point(139, 97);
            this.WorkingOnItems.Name = "WorkingOnItems";
            this.WorkingOnItems.Size = new System.Drawing.Size(48, 25);
            this.WorkingOnItems.TabIndex = 4;
            this.WorkingOnItems.Text = "999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "items";
            // 
            // ProgressTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkingOnItems);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.DLspeed);
            this.Controls.Add(this.FileNum);
            this.Controls.Add(this.OverallProgressCompleted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProgressTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ProgressTracker_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressTracker_FormClosing);
            this.Load += new System.EventHandler(this.ProgressTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Label FileNum;
        public Label DLspeed;
        public ProgressBar OverallProgressCompleted;
        private Timer _Timer;
        public Label l1;
        public Label WorkingOnItems;
        public Label label2;

        internal Timer Timer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer != null)
                {
                    _Timer.Tick -= Timer_Tick;
                }

                _Timer = value;
                if (_Timer != null)
                {
                    _Timer.Tick += Timer_Tick;
                }
            }
        }
    }
}
﻿namespace MachineLearningKit
{
    partial class FormCoverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoverage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.entityBox1 = new System.Windows.Forms.EntityBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.entityBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Size = new System.Drawing.Size(837, 527);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 0;
            // 
            // entityBox1
            // 
            this.entityBox1.AutoPriority = true;
            this.entityBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.entityBox1.BeaconPriority = 4;
            this.entityBox1.CellAdderColor = System.Drawing.Color.Red;
            this.entityBox1.CellBufferColor = System.Drawing.Color.Navy;
            this.entityBox1.CellBusSuppColor = System.Drawing.Color.DarkViolet;
            this.entityBox1.CellFlipFlopColor = System.Drawing.Color.Lime;
            this.entityBox1.CellLatchColor = System.Drawing.Color.Cyan;
            this.entityBox1.CellLogicColor = System.Drawing.Color.Yellow;
            this.entityBox1.CellMuxColor = System.Drawing.Color.DarkOrange;
            this.entityBox1.CellNotColor = System.Drawing.Color.Navy;
            this.entityBox1.CellOpacity = 128;
            this.entityBox1.CellOtherColor = System.Drawing.Color.Snow;
            this.entityBox1.CellOverrideColor = System.Drawing.Color.Black;
            this.entityBox1.CellPriority = 1;
            this.entityBox1.CellTextAlignment = TextAlignment.TopLeft;
            this.entityBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityBox1.ForeColor = System.Drawing.Color.Snow;
            this.entityBox1.Grayscale = false;
            this.entityBox1.HideCells = false;
            this.entityBox1.HideGrid = false;
            this.entityBox1.HideImage = false;
            this.entityBox1.HideLambdaMetrics = false;
            this.entityBox1.HideRegions = false;
            this.entityBox1.HideVias = false;
            this.entityBox1.HideWires = false;
            this.entityBox1.ImageOpacity0 = 100;
            this.entityBox1.ImageOpacity1 = 100;
            this.entityBox1.ImageOpacity2 = 100;
            this.entityBox1.Lambda = 5F;
            this.entityBox1.Location = new System.Drawing.Point(0, 0);
            this.entityBox1.LockScroll0 = false;
            this.entityBox1.LockScroll1 = false;
            this.entityBox1.LockScroll2 = false;
            this.entityBox1.LockZoom0 = false;
            this.entityBox1.LockZoom1 = false;
            this.entityBox1.LockZoom2 = false;
            this.entityBox1.Mode = System.Windows.Forms.EntityMode.Selection;
            this.entityBox1.Name = "entityBox1";
            this.entityBox1.RegionOpacity = 128;
            this.entityBox1.RegionOverrideColor = System.Drawing.Color.Black;
            this.entityBox1.RegionPriority = 0;
            this.entityBox1.ScrollImage0 = ((System.Drawing.PointF)(resources.GetObject("entityBox1.ScrollImage0")));
            this.entityBox1.ScrollImage1 = ((System.Drawing.PointF)(resources.GetObject("entityBox1.ScrollImage1")));
            this.entityBox1.ScrollImage2 = ((System.Drawing.PointF)(resources.GetObject("entityBox1.ScrollImage2")));
            this.entityBox1.ScrollX = 0F;
            this.entityBox1.ScrollY = 0F;
            this.entityBox1.SelectEntitiesAfterAdd = true;
            this.entityBox1.SelectionBoxColor = System.Drawing.Color.Red;
            this.entityBox1.SelectionColor = System.Drawing.Color.LimeGreen;
            this.entityBox1.Size = new System.Drawing.Size(837, 461);
            this.entityBox1.TabIndex = 0;
            this.entityBox1.Text = "entityBox1";
            this.entityBox1.UnitCustomColor = System.Drawing.Color.Snow;
            this.entityBox1.UnitMemoryColor = System.Drawing.Color.Snow;
            this.entityBox1.UnitRegfileColor = System.Drawing.Color.Snow;
            this.entityBox1.ViasBaseSize = 4;
            this.entityBox1.ViasConnectColor = System.Drawing.Color.Black;
            this.entityBox1.ViasFloatingColor = System.Drawing.Color.Gray;
            this.entityBox1.ViasGroundColor = System.Drawing.Color.Black;
            this.entityBox1.ViasInoutColor = System.Drawing.Color.Yellow;
            this.entityBox1.ViasInputColor = System.Drawing.Color.Green;
            this.entityBox1.ViasOpacity = 255;
            this.entityBox1.ViasOutputColor = System.Drawing.Color.Red;
            this.entityBox1.ViasOverrideColor = System.Drawing.Color.Black;
            this.entityBox1.ViasPowerColor = System.Drawing.Color.Black;
            this.entityBox1.ViasPriority = 3;
            this.entityBox1.ViasShape = ViasShape.Square;
            this.entityBox1.ViasTextAlignment = TextAlignment.Top;
            this.entityBox1.WireBaseSize = 3;
            this.entityBox1.WireGroundColor = System.Drawing.Color.Green;
            this.entityBox1.WireInterconnectColor = System.Drawing.Color.Blue;
            this.entityBox1.WireOpacity = 128;
            this.entityBox1.WireOverrideColor = System.Drawing.Color.Black;
            this.entityBox1.WirePowerColor = System.Drawing.Color.Red;
            this.entityBox1.WirePriority = 2;
            this.entityBox1.WireTextAlignment = TextAlignment.TopLeft;
            this.entityBox1.Zoom = 100;
            this.entityBox1.ZoomImage0 = 100;
            this.entityBox1.ZoomImage1 = 100;
            this.entityBox1.ZoomImage2 = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feature";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // FormCoverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 527);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCoverage";
            this.Text = "Feature Coverage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.EntityBox entityBox1;
    }
}
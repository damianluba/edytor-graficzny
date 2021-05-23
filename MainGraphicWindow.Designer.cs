
namespace edytor_graficzny {
	partial class MainGraphicWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGraphicWindow));
			this.toolsPanel = new System.Windows.Forms.Panel();
			this.drawArcPictureBox = new System.Windows.Forms.PictureBox();
			this.bottomLabel = new System.Windows.Forms.Label();
			this.rightLabel = new System.Windows.Forms.Label();
			this.topLabel = new System.Windows.Forms.Label();
			this.leftLabel = new System.Windows.Forms.Label();
			this.DrawPiePictureBox = new System.Windows.Forms.PictureBox();
			this.DrawPolygonPictureBox = new System.Windows.Forms.PictureBox();
			this.drawEllipsePictureBox = new System.Windows.Forms.PictureBox();
			this.fillingInCheckBox = new System.Windows.Forms.CheckBox();
			this.ErasePictureBox = new System.Windows.Forms.PictureBox();
			this.selectedColorButton = new System.Windows.Forms.Button();
			this.shapeThicknessPictureBox = new System.Windows.Forms.PictureBox();
			this.drawRectanglePictureBox = new System.Windows.Forms.PictureBox();
			this.drawWithPencilPictureBox = new System.Windows.Forms.PictureBox();
			this.drawLinePictureBox = new System.Windows.Forms.PictureBox();
			this.drawCurvePictureBox = new System.Windows.Forms.PictureBox();
			this.drawCirclePictureBox = new System.Windows.Forms.PictureBox();
			this.startPointPositionLabel = new System.Windows.Forms.Label();
			this.currentPositionLabel = new System.Windows.Forms.Label();
			this.shapeNameLabel = new System.Windows.Forms.Label();
			this.endPointPositionLabel = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editorFieldPictureBox = new System.Windows.Forms.PictureBox();
			this.lineThicknessTrackBar = new System.Windows.Forms.TrackBar();
			this.toolsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.drawArcPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DrawPiePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DrawPolygonPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawEllipsePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ErasePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shapeThicknessPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawRectanglePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawWithPencilPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawLinePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawCurvePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawCirclePictureBox)).BeginInit();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.editorFieldPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// toolsPanel
			// 
			this.toolsPanel.BackColor = System.Drawing.Color.Transparent;
			this.toolsPanel.Controls.Add(this.drawArcPictureBox);
			this.toolsPanel.Controls.Add(this.bottomLabel);
			this.toolsPanel.Controls.Add(this.rightLabel);
			this.toolsPanel.Controls.Add(this.topLabel);
			this.toolsPanel.Controls.Add(this.leftLabel);
			this.toolsPanel.Controls.Add(this.DrawPiePictureBox);
			this.toolsPanel.Controls.Add(this.DrawPolygonPictureBox);
			this.toolsPanel.Controls.Add(this.drawEllipsePictureBox);
			this.toolsPanel.Controls.Add(this.fillingInCheckBox);
			this.toolsPanel.Controls.Add(this.ErasePictureBox);
			this.toolsPanel.Controls.Add(this.selectedColorButton);
			this.toolsPanel.Controls.Add(this.shapeThicknessPictureBox);
			this.toolsPanel.Controls.Add(this.drawRectanglePictureBox);
			this.toolsPanel.Controls.Add(this.drawWithPencilPictureBox);
			this.toolsPanel.Controls.Add(this.drawLinePictureBox);
			this.toolsPanel.Controls.Add(this.drawCurvePictureBox);
			this.toolsPanel.Controls.Add(this.drawCirclePictureBox);
			this.toolsPanel.Location = new System.Drawing.Point(85, 32);
			this.toolsPanel.Name = "toolsPanel";
			this.toolsPanel.Size = new System.Drawing.Size(392, 75);
			this.toolsPanel.TabIndex = 20;
			// 
			// drawArcPictureBox
			// 
			this.drawArcPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawArcPictureBox.Image = global::edytor_graficzny.Properties.Resources.arc;
			this.drawArcPictureBox.Location = new System.Drawing.Point(184, 5);
			this.drawArcPictureBox.Name = "drawArcPictureBox";
			this.drawArcPictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawArcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drawArcPictureBox.TabIndex = 32;
			this.drawArcPictureBox.TabStop = false;
			this.drawArcPictureBox.Click += new System.EventHandler(this.DrawArcPictureBox_Click);
			// 
			// bottomLabel
			// 
			this.bottomLabel.AutoSize = true;
			this.bottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bottomLabel.Location = new System.Drawing.Point(359, 40);
			this.bottomLabel.Name = "bottomLabel";
			this.bottomLabel.Size = new System.Drawing.Size(2, 15);
			this.bottomLabel.TabIndex = 31;
			this.bottomLabel.Visible = false;
			// 
			// rightLabel
			// 
			this.rightLabel.AutoSize = true;
			this.rightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.rightLabel.Location = new System.Drawing.Point(311, 40);
			this.rightLabel.Name = "rightLabel";
			this.rightLabel.Size = new System.Drawing.Size(2, 15);
			this.rightLabel.TabIndex = 30;
			this.rightLabel.Visible = false;
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.topLabel.Location = new System.Drawing.Point(359, 21);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(2, 15);
			this.topLabel.TabIndex = 29;
			this.topLabel.Visible = false;
			// 
			// leftLabel
			// 
			this.leftLabel.AutoSize = true;
			this.leftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.leftLabel.Location = new System.Drawing.Point(311, 20);
			this.leftLabel.Name = "leftLabel";
			this.leftLabel.Size = new System.Drawing.Size(2, 15);
			this.leftLabel.TabIndex = 28;
			this.leftLabel.Visible = false;
			// 
			// DrawPiePictureBox
			// 
			this.DrawPiePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DrawPiePictureBox.Image = global::edytor_graficzny.Properties.Resources.pie;
			this.DrawPiePictureBox.Location = new System.Drawing.Point(148, 4);
			this.DrawPiePictureBox.Name = "DrawPiePictureBox";
			this.DrawPiePictureBox.Size = new System.Drawing.Size(30, 30);
			this.DrawPiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DrawPiePictureBox.TabIndex = 25;
			this.DrawPiePictureBox.TabStop = false;
			this.DrawPiePictureBox.Click += new System.EventHandler(this.DrawPiePictureBox_Click);
			// 
			// DrawPolygonPictureBox
			// 
			this.DrawPolygonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DrawPolygonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DrawPolygonPictureBox.Image")));
			this.DrawPolygonPictureBox.Location = new System.Drawing.Point(148, 40);
			this.DrawPolygonPictureBox.Name = "DrawPolygonPictureBox";
			this.DrawPolygonPictureBox.Size = new System.Drawing.Size(30, 30);
			this.DrawPolygonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DrawPolygonPictureBox.TabIndex = 24;
			this.DrawPolygonPictureBox.TabStop = false;
			this.DrawPolygonPictureBox.Click += new System.EventHandler(this.DrawPolygonPictureBox_Click);
			// 
			// drawEllipsePictureBox
			// 
			this.drawEllipsePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawEllipsePictureBox.Image = global::edytor_graficzny.Properties.Resources.ellipse;
			this.drawEllipsePictureBox.Location = new System.Drawing.Point(112, 4);
			this.drawEllipsePictureBox.Name = "drawEllipsePictureBox";
			this.drawEllipsePictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawEllipsePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.drawEllipsePictureBox.TabIndex = 23;
			this.drawEllipsePictureBox.TabStop = false;
			this.drawEllipsePictureBox.Click += new System.EventHandler(this.DrawEllipsePictureBox_Click);
			// 
			// fillingInCheckBox
			// 
			this.fillingInCheckBox.AutoSize = true;
			this.fillingInCheckBox.Location = new System.Drawing.Point(306, 4);
			this.fillingInCheckBox.Name = "fillingInCheckBox";
			this.fillingInCheckBox.Size = new System.Drawing.Size(60, 17);
			this.fillingInCheckBox.TabIndex = 21;
			this.fillingInCheckBox.Text = "filling in";
			this.fillingInCheckBox.UseVisualStyleBackColor = true;
			// 
			// ErasePictureBox
			// 
			this.ErasePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ErasePictureBox.Image = global::edytor_graficzny.Properties.Resources.erase;
			this.ErasePictureBox.Location = new System.Drawing.Point(112, 40);
			this.ErasePictureBox.Name = "ErasePictureBox";
			this.ErasePictureBox.Size = new System.Drawing.Size(30, 30);
			this.ErasePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ErasePictureBox.TabIndex = 22;
			this.ErasePictureBox.TabStop = false;
			this.ErasePictureBox.Click += new System.EventHandler(this.ErasePictureBox_Click);
			// 
			// selectedColorButton
			// 
			this.selectedColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.selectedColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.selectedColorButton.FlatAppearance.BorderSize = 5;
			this.selectedColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectedColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.selectedColorButton.Location = new System.Drawing.Point(234, 4);
			this.selectedColorButton.Name = "selectedColorButton";
			this.selectedColorButton.Size = new System.Drawing.Size(66, 66);
			this.selectedColorButton.TabIndex = 21;
			this.selectedColorButton.UseVisualStyleBackColor = true;
			this.selectedColorButton.Click += new System.EventHandler(this.SelectedColorButton_Click);
			// 
			// shapeThicknessPictureBox
			// 
			this.shapeThicknessPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.shapeThicknessPictureBox.Image = global::edytor_graficzny.Properties.Resources.line_thickness;
			this.shapeThicknessPictureBox.Location = new System.Drawing.Point(4, 40);
			this.shapeThicknessPictureBox.Name = "shapeThicknessPictureBox";
			this.shapeThicknessPictureBox.Size = new System.Drawing.Size(30, 30);
			this.shapeThicknessPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.shapeThicknessPictureBox.TabIndex = 5;
			this.shapeThicknessPictureBox.TabStop = false;
			this.shapeThicknessPictureBox.Click += new System.EventHandler(this.shapeThicknessPictureBox_Click);
			// 
			// drawRectanglePictureBox
			// 
			this.drawRectanglePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawRectanglePictureBox.Image = global::edytor_graficzny.Properties.Resources.rectangle;
			this.drawRectanglePictureBox.Location = new System.Drawing.Point(40, 40);
			this.drawRectanglePictureBox.Name = "drawRectanglePictureBox";
			this.drawRectanglePictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawRectanglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drawRectanglePictureBox.TabIndex = 4;
			this.drawRectanglePictureBox.TabStop = false;
			this.drawRectanglePictureBox.Click += new System.EventHandler(this.DrawRectanglePictureBox_Click);
			// 
			// drawWithPencilPictureBox
			// 
			this.drawWithPencilPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawWithPencilPictureBox.Image = global::edytor_graficzny.Properties.Resources.pencil;
			this.drawWithPencilPictureBox.Location = new System.Drawing.Point(76, 4);
			this.drawWithPencilPictureBox.Name = "drawWithPencilPictureBox";
			this.drawWithPencilPictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawWithPencilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drawWithPencilPictureBox.TabIndex = 3;
			this.drawWithPencilPictureBox.TabStop = false;
			this.drawWithPencilPictureBox.Click += new System.EventHandler(this.DrawWithPencilPictureBox_Click);
			// 
			// drawLinePictureBox
			// 
			this.drawLinePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawLinePictureBox.Image = global::edytor_graficzny.Properties.Resources.line;
			this.drawLinePictureBox.Location = new System.Drawing.Point(76, 40);
			this.drawLinePictureBox.Name = "drawLinePictureBox";
			this.drawLinePictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawLinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drawLinePictureBox.TabIndex = 2;
			this.drawLinePictureBox.TabStop = false;
			this.drawLinePictureBox.Click += new System.EventHandler(this.DrawLinePictureBox_Click);
			// 
			// drawCurvePictureBox
			// 
			this.drawCurvePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawCurvePictureBox.Image = global::edytor_graficzny.Properties.Resources.curve;
			this.drawCurvePictureBox.Location = new System.Drawing.Point(40, 4);
			this.drawCurvePictureBox.Name = "drawCurvePictureBox";
			this.drawCurvePictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawCurvePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drawCurvePictureBox.TabIndex = 1;
			this.drawCurvePictureBox.TabStop = false;
			this.drawCurvePictureBox.Click += new System.EventHandler(this.DrawCurvePictureBox_Click);
			// 
			// drawCirclePictureBox
			// 
			this.drawCirclePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.drawCirclePictureBox.Image = global::edytor_graficzny.Properties.Resources.circle;
			this.drawCirclePictureBox.Location = new System.Drawing.Point(4, 4);
			this.drawCirclePictureBox.Name = "drawCirclePictureBox";
			this.drawCirclePictureBox.Size = new System.Drawing.Size(30, 30);
			this.drawCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drawCirclePictureBox.TabIndex = 0;
			this.drawCirclePictureBox.TabStop = false;
			this.drawCirclePictureBox.Click += new System.EventHandler(this.DrawCirclePictureBox_Click);
			// 
			// startPointPositionLabel
			// 
			this.startPointPositionLabel.AutoSize = true;
			this.startPointPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.startPointPositionLabel.Location = new System.Drawing.Point(9, 38);
			this.startPointPositionLabel.Name = "startPointPositionLabel";
			this.startPointPositionLabel.Size = new System.Drawing.Size(2, 15);
			this.startPointPositionLabel.TabIndex = 24;
			this.startPointPositionLabel.Visible = false;
			// 
			// currentPositionLabel
			// 
			this.currentPositionLabel.AutoSize = true;
			this.currentPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.currentPositionLabel.Location = new System.Drawing.Point(9, 95);
			this.currentPositionLabel.Name = "currentPositionLabel";
			this.currentPositionLabel.Size = new System.Drawing.Size(2, 15);
			this.currentPositionLabel.TabIndex = 26;
			// 
			// shapeNameLabel
			// 
			this.shapeNameLabel.AutoSize = true;
			this.shapeNameLabel.BackColor = System.Drawing.SystemColors.Control;
			this.shapeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.shapeNameLabel.Location = new System.Drawing.Point(9, 19);
			this.shapeNameLabel.Name = "shapeNameLabel";
			this.shapeNameLabel.Size = new System.Drawing.Size(2, 15);
			this.shapeNameLabel.TabIndex = 23;
			this.shapeNameLabel.Visible = false;
			// 
			// endPointPositionLabel
			// 
			this.endPointPositionLabel.AutoSize = true;
			this.endPointPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.endPointPositionLabel.Location = new System.Drawing.Point(9, 58);
			this.endPointPositionLabel.Name = "endPointPositionLabel";
			this.endPointPositionLabel.Size = new System.Drawing.Size(2, 15);
			this.endPointPositionLabel.TabIndex = 27;
			this.endPointPositionLabel.Visible = false;
			// 
			// toolStrip
			// 
			this.toolStrip.AutoSize = false;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(489, 20);
			this.toolStrip.TabIndex = 30;
			// 
			// toolStripDropDownButton
			// 
			this.toolStripDropDownButton.AutoSize = false;
			this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
			this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
			this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton.Name = "toolStripDropDownButton";
			this.toolStripDropDownButton.Size = new System.Drawing.Size(38, 20);
			this.toolStripDropDownButton.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.saveAsToolStripMenuItem.Text = "Save as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// editorFieldPictureBox
			// 
			this.editorFieldPictureBox.BackColor = System.Drawing.Color.White;
			this.editorFieldPictureBox.Location = new System.Drawing.Point(13, 118);
			this.editorFieldPictureBox.Name = "editorFieldPictureBox";
			this.editorFieldPictureBox.Size = new System.Drawing.Size(465, 331);
			this.editorFieldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.editorFieldPictureBox.TabIndex = 0;
			this.editorFieldPictureBox.TabStop = false;
			this.editorFieldPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.EditorFieldPictureBox_Paint);
			this.editorFieldPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditorFieldPictureBox_MouseClick);
			this.editorFieldPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditorFieldPictureBox_MouseDown);
			this.editorFieldPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditorFieldPictureBox_MouseMove);
			this.editorFieldPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditorFieldPictureBox_MouseUp);
			// 
			// lineThicknessTrackBar
			// 
			this.lineThicknessTrackBar.Location = new System.Drawing.Point(51, 118);
			this.lineThicknessTrackBar.Name = "lineThicknessTrackBar";
			this.lineThicknessTrackBar.Size = new System.Drawing.Size(104, 45);
			this.lineThicknessTrackBar.TabIndex = 31;
			this.lineThicknessTrackBar.Visible = false;
			this.lineThicknessTrackBar.ValueChanged += new System.EventHandler(this.lineThicknessTrackBar_ValueChanged);
			// 
			// MainGraphicWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 461);
			this.Controls.Add(this.lineThicknessTrackBar);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.endPointPositionLabel);
			this.Controls.Add(this.currentPositionLabel);
			this.Controls.Add(this.startPointPositionLabel);
			this.Controls.Add(this.shapeNameLabel);
			this.Controls.Add(this.editorFieldPictureBox);
			this.Controls.Add(this.toolsPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(450, 200);
			this.Name = "MainGraphicWindow";
			this.Text = "Super Graphic Editor";
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.SizeChanged += new System.EventHandler(this.MainGraphicWindow_SizeChanged);
			this.toolsPanel.ResumeLayout(false);
			this.toolsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.drawArcPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DrawPiePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DrawPolygonPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawEllipsePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ErasePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shapeThicknessPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawRectanglePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawWithPencilPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawLinePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawCurvePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawCirclePictureBox)).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.editorFieldPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox editorFieldPictureBox;
		private System.Windows.Forms.Panel toolsPanel;
		private System.Windows.Forms.Button selectedColorButton;
		private System.Windows.Forms.PictureBox shapeThicknessPictureBox;
		private System.Windows.Forms.PictureBox drawRectanglePictureBox;
		private System.Windows.Forms.PictureBox drawWithPencilPictureBox;
		private System.Windows.Forms.PictureBox drawLinePictureBox;
		private System.Windows.Forms.PictureBox drawCurvePictureBox;
		private System.Windows.Forms.PictureBox drawCirclePictureBox;
		private System.Windows.Forms.PictureBox ErasePictureBox;
		private System.Windows.Forms.CheckBox fillingInCheckBox;
		private System.Windows.Forms.PictureBox drawEllipsePictureBox;
		private System.Windows.Forms.PictureBox DrawPolygonPictureBox;
		private System.Windows.Forms.PictureBox DrawPiePictureBox;
		private System.Windows.Forms.Label startPointPositionLabel;
		private System.Windows.Forms.Label currentPositionLabel;
		private System.Windows.Forms.Label shapeNameLabel;
		private System.Windows.Forms.Label endPointPositionLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.Label leftLabel;
		private System.Windows.Forms.Label bottomLabel;
		private System.Windows.Forms.Label rightLabel;
		private System.Windows.Forms.Label topLabel;
		private System.Windows.Forms.PictureBox drawArcPictureBox;
		private System.Windows.Forms.TrackBar lineThicknessTrackBar;
	}
}


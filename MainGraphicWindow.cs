using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Media;
using System.Security.Policy;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace edytor_graficzny {
	public partial class MainGraphicWindow : Form {
		string option;
		Graphics g;
		Point startPoint = Point.Empty, endPoint = Point.Empty, currentPosition = Point.Empty;
		Rectangle rectangle, circle, pie;
		private List<Point> Points = new List<Point>();
		List <string> functions= new List<string>() { "rectangle", "ellipse", "circle", "line", "curve", "pie", "polygon", "pencil" };
		Bitmap bitmap;
		OpenFileDialog openFileDialog = new OpenFileDialog();

		Pen pen = new Pen(Color.Black, 5);
		public MainGraphicWindow() {
			InitializeComponent();
			editorFieldPictureBox.Width = this.Width - 40;
			editorFieldPictureBox.Height = this.Height - 168;
			option = "pencil";
			selectedColorButton.BackColor = pen.Color;
			DisplayCoordinates();
		}

		private Rectangle GetRectangle() {
			rectangle = new Rectangle();
			rectangle.X = Math.Min(startPoint.X, currentPosition.X);
			rectangle.Y = Math.Min(startPoint.Y, currentPosition.Y);
			rectangle.Width = Math.Abs(startPoint.X - currentPosition.X);
			rectangle.Height = Math.Abs(startPoint.Y - currentPosition.Y);
			return rectangle;
		}
		private Rectangle GetCircle() {
			circle = new Rectangle();
			circle.X = circle.Y = Math.Min(startPoint.X, currentPosition.X);
			circle.Width = circle.Height = Math.Abs(startPoint.X - currentPosition.X);
			return circle;
		}
		private Rectangle GetPie() {
			pie = new Rectangle();
			pie.X = circle.Y = Math.Min(startPoint.X, currentPosition.X);
			pie.Width = circle.Height = Math.Abs(startPoint.X - currentPosition.X);
			return pie;
		}

		private void DisplayCoordinates() {
			startPointPositionLabel.Text = "start: " + startPoint.X + ", " + startPoint.Y;
			endPointPositionLabel.Text = "end: " + endPoint.X + ", " + endPoint.Y;
			currentPositionLabel.Text = "current position: " + currentPosition.X + ", " + currentPosition.Y;
			shapeNameLabel.Text = option;

			leftLabel.Text = "left: " + rectangle.X;
			rightLabel.Text = "width: " + rectangle.Width;
			topLabel.Text = "top: " + rectangle.Y;
			bottomLabel.Text = "height: " + rectangle.Height;
		}
		#region functions
		private void SelectedColorButton_Click(object sender, EventArgs e) {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.ShowDialog();
			selectedColorButton.BackColor = colorDialog.Color;
			Color selectdTextColor = new Color();
			selectdTextColor = Color.FromArgb(selectedColorButton.BackColor.ToArgb() ^ 0xffffff);   //setting negative, just to increase readability 
			selectedColorButton.ForeColor = selectdTextColor;
			pen.Color = colorDialog.Color;
		}

		private void DrawCirclePictureBox_Click(object sender, EventArgs e) {
			option = "circle";
		}
		private void DrawCurvePictureBox_Click(object sender, EventArgs e) {
			option = "curve";

		}
		private void DrawWithPencilPictureBox_Click(object sender, EventArgs e) {
			option = "pencil";
		}
		private void DrawEllipsePictureBox_Click(object sender, EventArgs e) {
			option = "ellipse";
		}
		private void DrawPiePictureBox_Click(object sender, EventArgs e) {
			option = "pie";
		}
		private void DrawRectanglePictureBox_Click(object sender, EventArgs e) {
			option = "rectangle";
		}
		private void DrawPolygonPictureBox_Click(object sender, EventArgs e) {
			option = "polygon";
		}
		private void DrawLinePictureBox_Click(object sender, EventArgs e) {
			option = "line";
		}
		private void DrawArcPictureBox_Click(object sender, EventArgs e) {
			option = "arc";
		}
		private void ErasePictureBox_Click(object sender, EventArgs e) {
			editorFieldPictureBox.Image = null;
		}
		private void shapeThicknessPictureBox_Click(object sender, EventArgs e) {
			lineThicknessTrackBar.Value = (int)pen.Width;
			if(lineThicknessTrackBar.Visible)
				lineThicknessTrackBar.Hide();
			else
				lineThicknessTrackBar.Show();
		}
		private void lineThicknessTrackBar_ValueChanged(object sender, EventArgs e) {
			pen.Width = lineThicknessTrackBar.Value;
		}
		#endregion

		#region toolstrip
		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			openFileDialog.Title = "Select a picture";
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			openFileDialog.Filter = "Images (*.bmp;*.jpg;*.gif;*.png;*.tiff)|*.bmp;*.jpg;*.gif;*.png;*.tiff|" + "All files (*.*)|*.*";
			
			if (openFileDialog.ShowDialog() == DialogResult.OK)
				try {
					editorFieldPictureBox.Image = new Bitmap(openFileDialog.FileName);
				}
				catch (Exception ex) {
					MessageBox.Show("Error: Could not read the picture from disk. Check access to the file.\n Original error: " + ex.Message);
				}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			g = Graphics.FromImage(editorFieldPictureBox.Image);
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "Picture";
			saveFileDialog.Filter = " jpg Image| *.jpg| bitmap image | *.bmp| gif image | *.gif| png image | *.png| All files | *.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				saveFileDialog.RestoreDirectory = true;
				int width = Convert.ToInt32(editorFieldPictureBox.Width);
				int height = Convert.ToInt32(editorFieldPictureBox.Height);
				Bitmap bmp = new Bitmap(width, height);
				editorFieldPictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
				bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
			}
		}
		#endregion

		private void MainGraphicWindow_SizeChanged(object sender, EventArgs e) {
			editorFieldPictureBox.Width = this.Width - 40;
			editorFieldPictureBox.Height = this.Height - 168;
		}

		#region editorFieldPictureBox events
		private void EditorFieldPictureBox_MouseClick(object sender, MouseEventArgs e) {
			Points.Add(e.Location);
			Refresh();
		}
		private void EditorFieldPictureBox_MouseDown(object sender, MouseEventArgs e) {
			startPoint = e.Location;    
			DisplayCoordinates();
		}

		private void EditorFieldPictureBox_MouseMove(object sender, MouseEventArgs e) {
			currentPosition = e.Location;
			DisplayCoordinates();

			//the condition is necessary because even that a user did not want to draw, would do it
			if (e.Button == MouseButtons.Left) {  //drawing condition
				if (startPoint != null) {
					if (editorFieldPictureBox.Image == null)
						editorFieldPictureBox.Image = new Bitmap(editorFieldPictureBox.Width, editorFieldPictureBox.Height);

					Graphics g = Graphics.FromImage(editorFieldPictureBox.Image);
					if (option == "pencil") {
						g.SmoothingMode = SmoothingMode.AntiAlias;
						g.DrawLine(pen, startPoint, currentPosition);
						editorFieldPictureBox.Invalidate();
						startPoint = e.Location;
					}
					Refresh();
				}
			}
		}

		private void EditorFieldPictureBox_MouseUp(object sender, MouseEventArgs e) {
			startPoint = Point.Empty;
		}

		private void EditorFieldPictureBox_Paint(object sender, PaintEventArgs e) { //previews of drawing shapes
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			switch (option) {  //drawing a shape must be in progress
				case "rectangle":
					if(rectangle!=null)
						if (fillingInCheckBox.Checked)
							e.Graphics.FillRectangle(pen.Brush, GetRectangle());
						else e.Graphics.DrawRectangle(pen, GetRectangle());
					break;

				case "line":
					e.Graphics.DrawLine(pen, startPoint, currentPosition);
					break;

				case "curve":
					foreach (Point point in Points)
						e.Graphics.FillEllipse(pen.Brush, point.X - 3, point.Y - 3, 5, 5);
					if (Points.Count < 2)
						return;
					e.Graphics.DrawCurve(pen, Points.ToArray());
					break;

				case "polygon":
					foreach (Point point in Points)
						e.Graphics.FillEllipse(pen.Brush, point.X - 3, point.Y - 3, 5, 5);
					if (Points.Count < 3)
						return;
					if (fillingInCheckBox.Checked)
						e.Graphics.FillPolygon(pen.Brush, Points.ToArray());
					else e.Graphics.DrawPolygon(pen, Points.ToArray());
					break;

				case "pie":
					if (pie != null) 
						if (fillingInCheckBox.Checked)
							e.Graphics.FillPie(pen.Brush, 10, 10, 100, 100, -90, 270);
						else e.Graphics.DrawPie(pen, 10, 10, 100, 100, -90, 270);
						//find the highest point on a screen - this will a,   y1=Min(Pie.Y), y0=center of the pie
						//measure the length between y1 and y0
						//draw a line to a cursor - this will be b
						//calculate tg(alpha)=a/b, calculate alpha from tg
					break;

				case "ellipse":
					if (rectangle != null)
						if (fillingInCheckBox.Checked)
							e.Graphics.FillEllipse(pen.Brush, GetRectangle());
						else e.Graphics.DrawEllipse(pen, GetRectangle());
					break;

				case "circle":
					if (rectangle != null)
						if (fillingInCheckBox.Checked)
							e.Graphics.FillEllipse(pen.Brush, GetCircle());
						else e.Graphics.DrawEllipse(pen, GetCircle());
					break;

				case "arc":
					if (rectangle != null)
						e.Graphics.DrawArc(pen, 10, 10, 100, 100, -90, 270);
					break;
			}
		}
		#endregion 
	}
}


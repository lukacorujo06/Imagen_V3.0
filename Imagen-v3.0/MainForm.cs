using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercitacion_4
{
	public partial class MainForm : Form
	{
		string [] imagenes;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Pic_imagenesClick(object sender, EventArgs e)
		{
			PictureBox pic = (PictureBox) sender;
			
			pic_imagenes.Image = pic.Image;
			
			int i = Convert.ToInt32 (pic.Tag);
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imagenes = new string[6];
			string direccion = "D:\\numeros\\";
			imagenes [1] = direccion + "uno.png";
			imagenes [2] = direccion + "dos.png";
			imagenes [3] = direccion + "tres.png";
			imagenes [4] = direccion + "cuatro.png";
			imagenes [5] = direccion + "cinco.png";
			
			pic_1.Image = Image.FromFile (imagenes [1]);
			pic_2.Image = Image.FromFile (imagenes [2]);
			pic_3.Image = Image.FromFile (imagenes [3]);
			pic_4.Image = Image.FromFile (imagenes [4]);
			pic_4.Image = Image.FromFile (imagenes [5]);
			
			pic_imagenes.Image = pic_1.Image;
		}
	}
}

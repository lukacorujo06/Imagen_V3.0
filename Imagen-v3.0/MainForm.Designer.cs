/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 28/11/2021
 * Hora: 17:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Ejercitacion_4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic_1 = new System.Windows.Forms.PictureBox();
			this.pic_2 = new System.Windows.Forms.PictureBox();
			this.pic_3 = new System.Windows.Forms.PictureBox();
			this.pic_4 = new System.Windows.Forms.PictureBox();
			this.pic_imagenes = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagenes)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_1
			// 
			this.pic_1.Location = new System.Drawing.Point(42, 36);
			this.pic_1.Name = "pic_1";
			this.pic_1.Size = new System.Drawing.Size(123, 104);
			this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_1.TabIndex = 0;
			this.pic_1.TabStop = false;
			this.pic_1.Tag = "1";
			this.pic_1.Click += new System.EventHandler(this.Pic_imagenesClick);
			// 
			// pic_2
			// 
			this.pic_2.Location = new System.Drawing.Point(42, 160);
			this.pic_2.Name = "pic_2";
			this.pic_2.Size = new System.Drawing.Size(123, 104);
			this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_2.TabIndex = 1;
			this.pic_2.TabStop = false;
			this.pic_2.Tag = "2";
			this.pic_2.Click += new System.EventHandler(this.Pic_imagenesClick);
			// 
			// pic_3
			// 
			this.pic_3.Location = new System.Drawing.Point(42, 293);
			this.pic_3.Name = "pic_3";
			this.pic_3.Size = new System.Drawing.Size(123, 104);
			this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_3.TabIndex = 2;
			this.pic_3.TabStop = false;
			this.pic_3.Tag = "3";
			this.pic_3.Click += new System.EventHandler(this.Pic_imagenesClick);
			// 
			// pic_4
			// 
			this.pic_4.Location = new System.Drawing.Point(42, 431);
			this.pic_4.Name = "pic_4";
			this.pic_4.Size = new System.Drawing.Size(123, 104);
			this.pic_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_4.TabIndex = 3;
			this.pic_4.TabStop = false;
			this.pic_4.Tag = "3";
			this.pic_4.Click += new System.EventHandler(this.Pic_imagenesClick);
			// 
			// pic_imagenes
			// 
			this.pic_imagenes.Location = new System.Drawing.Point(257, 87);
			this.pic_imagenes.Name = "pic_imagenes";
			this.pic_imagenes.Size = new System.Drawing.Size(407, 376);
			this.pic_imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagenes.TabIndex = 4;
			this.pic_imagenes.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 620);
			this.Controls.Add(this.pic_imagenes);
			this.Controls.Add(this.pic_4);
			this.Controls.Add(this.pic_3);
			this.Controls.Add(this.pic_2);
			this.Controls.Add(this.pic_1);
			this.Name = "MainForm";
			this.Text = "Ejercitacion 4";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagenes)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pic_imagenes;
		private System.Windows.Forms.PictureBox pic_4;
		private System.Windows.Forms.PictureBox pic_3;
		private System.Windows.Forms.PictureBox pic_2;
		private System.Windows.Forms.PictureBox pic_1;
	}
}

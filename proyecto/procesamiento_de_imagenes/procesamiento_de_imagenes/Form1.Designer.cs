namespace procesamiento_de_imagenes
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMax = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BtnCargarVideo = new System.Windows.Forms.Button();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.SubMenuArchivos = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SubMenuArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.BarraTitulo.Controls.Add(this.BtnRestaurar);
            this.BarraTitulo.Controls.Add(this.BtnMax);
            this.BarraTitulo.Controls.Add(this.BtnMin);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1733, 43);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = global::procesamiento_de_imagenes.Properties.Resources.restaurar;
            this.BtnRestaurar.Location = new System.Drawing.Point(1643, 9);
            this.BtnRestaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(33, 31);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMax.Image = global::procesamiento_de_imagenes.Properties.Resources.icons8_maximize_window_50;
            this.BtnMax.Location = new System.Drawing.Point(1643, 9);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(33, 31);
            this.BtnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMax.TabIndex = 2;
            this.BtnMax.TabStop = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = global::procesamiento_de_imagenes.Properties.Resources.icons8_minimize_window_30;
            this.BtnMin.Location = new System.Drawing.Point(1601, 9);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(33, 31);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMin.TabIndex = 1;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = global::procesamiento_de_imagenes.Properties.Resources.icons8_close_window_50;
            this.BtnCerrar.Location = new System.Drawing.Point(1684, 9);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(33, 31);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.SubMenuArchivos);
            this.MenuVertical.Controls.Add(this.BtnCargar);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.BtnFoto);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 43);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(309, 757);
            this.MenuVertical.TabIndex = 1;
            // 
            // BtnCargarVideo
            // 
            this.BtnCargarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(56)))));
            this.BtnCargarVideo.FlatAppearance.BorderSize = 0;
            this.BtnCargarVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCargarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarVideo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarVideo.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCargarVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargarVideo.Location = new System.Drawing.Point(0, 46);
            this.BtnCargarVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCargarVideo.Name = "BtnCargarVideo";
            this.BtnCargarVideo.Size = new System.Drawing.Size(195, 38);
            this.BtnCargarVideo.TabIndex = 9;
            this.BtnCargarVideo.Text = "Cargar Video";
            this.BtnCargarVideo.UseVisualStyleBackColor = false;
            this.BtnCargarVideo.Click += new System.EventHandler(this.BtnCargarVideo_Click);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.BtnCargarFoto.FlatAppearance.BorderSize = 0;
            this.BtnCargarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarFoto.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargarFoto.Location = new System.Drawing.Point(0, 0);
            this.BtnCargarFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(195, 38);
            this.BtnCargarFoto.TabIndex = 8;
            this.BtnCargarFoto.Text = "Cargar Imagen";
            this.BtnCargarFoto.UseVisualStyleBackColor = false;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(101)))), ((int)(((byte)(86)))));
            this.BtnCargar.FlatAppearance.BorderSize = 0;
            this.BtnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargar.Location = new System.Drawing.Point(59, 417);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(195, 38);
            this.BtnCargar.TabIndex = 5;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(59, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Video";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnFoto
            // 
            this.BtnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(129)))));
            this.BtnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFoto.FlatAppearance.BorderSize = 0;
            this.BtnFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFoto.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFoto.Location = new System.Drawing.Point(59, 326);
            this.BtnFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(195, 38);
            this.BtnFoto.TabIndex = 1;
            this.BtnFoto.Text = "Foto";
            this.BtnFoto.UseVisualStyleBackColor = false;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(210)))));
            this.PanelContenido.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(309, 43);
            this.PanelContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1424, 757);
            this.PanelContenido.TabIndex = 2;
            this.PanelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenido_Paint);
            // 
            // SubMenuArchivos
            // 
            this.SubMenuArchivos.Controls.Add(this.BtnCargarVideo);
            this.SubMenuArchivos.Controls.Add(this.BtnCargarFoto);
            this.SubMenuArchivos.Location = new System.Drawing.Point(59, 478);
            this.SubMenuArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.SubMenuArchivos.Name = "SubMenuArchivos";
            this.SubMenuArchivos.Size = new System.Drawing.Size(241, 123);
            this.SubMenuArchivos.TabIndex = 7;
            this.SubMenuArchivos.Visible = false;
            this.SubMenuArchivos.Paint += new System.Windows.Forms.PaintEventHandler(this.SubMenuArchivos_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SubMenuArchivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnMax;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCargarVideo;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.Panel SubMenuArchivos;
    }
}

